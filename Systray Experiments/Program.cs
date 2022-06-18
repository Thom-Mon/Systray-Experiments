using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.IO;
using System.Reflection;

namespace Systray_Experiments
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //check if program is already running
            Process[] allProcesses = Process.GetProcesses();
            int occurences = allProcesses.Count(x => x.ProcessName == Process.GetCurrentProcess().ProcessName);
            if (occurences > 1)
            {
                string title = "Program already running";
                string message = "The Program is already running. \n It is not very clever to start several instances of this program";
                MessageBox.Show(message, title);
                return;
            }


            Application.Run(new MyCustomApplicationContext());
        }
    }


    public class MyCustomApplicationContext : ApplicationContext
    {
        private NotifyIcon trayIcon;
        Timer t = new Timer();
        ServiceController[] allServices; //stores all Services;
        Process[] processesToKill;
        string workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        bool showNotification = Properties.Settings.Default.shownotification;
        bool isStartUp = true;
        int counterServices = 0;
        int counterProcesses = 0;

        public MyCustomApplicationContext()
        {
            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = Properties.Resources.trashIcon,
                ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Show Processes", ShowProcesses),
                new MenuItem("Exit", Exit)
            }),
                Visible = true
            };

            //check for certain programm every x seconds and then kill it
            t.Interval = 5000;
            t.Tick += killProgram;
            t.Tick += stopService;
            t.Start();
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;
            Application.Exit();
        }

        void ShowProcesses(object sender, EventArgs e)
        {
            var myForm = new Form1(trayIcon);
            myForm.Show();
        }

        void killProgram(object sender, EventArgs e)
        {
            string[] killList = Properties.Settings.Default.programList.Cast<string>().ToArray(); //the kill-List is now saved on the Settings
          
            foreach(string programName in killList)
            {
                processesToKill = Process.GetProcessesByName(programName);
                
                foreach (Process process in processesToKill)
                {
                    try
                    {
                        process.Kill();
                    }
                    catch
                    {
                        //trayIcon.ShowBalloonTip(1000, "Access Denied Error", process.ProcessName + " has not been killed", ToolTipIcon.Info);
                        showBallonNotification("Access Denied Error", process.ProcessName + " has not been killed", ToolTipIcon.Info);
                        logger("Process: " + process.ProcessName + " unable to kill");
                    }
                    Properties.Settings.Default.countTelemetryKilled += 1;
                    Properties.Settings.Default.Save();

                    if (!isStartUp) //only show BalloonTips if program is not just started
                    {
                        //trayIcon.ShowBalloonTip(1000, "Process killed", process.ProcessName + " has been killed", ToolTipIcon.Info);
                        logger("Process: " + process.ProcessName + " killed");
                        if (showNotification)
                        {
                            showBallonNotification("Process killed", process.ProcessName + " has been killed", ToolTipIcon.Info);
                        }
                    }
                    else
                    {
                        counterProcesses++;
                        logger("Process: " + process.ProcessName + " killed (Startup-Kill)");
                    }
                }
            }
        }

        public void stopService(object sender, EventArgs e)
        {
            string[] serviceStoppList = Properties.Settings.Default.serviceList.Cast<string>().ToArray();

            foreach (string ServiceName in serviceStoppList)
            {
                ServiceController sc = new ServiceController(ServiceName);

                //get the services to ensure nothing has changed
                allServices = ServiceController.GetServices();

                //check if the service actually exists before stopping it
                var service = allServices.FirstOrDefault(s => s.ServiceName == sc.ServiceName);
                if (service != null)
                {
                    if (sc.Status == ServiceControllerStatus.Running)
                    {
                        try
                        {
                            sc.Stop();
                            sc.WaitForStatus(ServiceControllerStatus.Stopped);

                            // Display the current service status.
                            if (!isStartUp && showNotification)
                            {
                                //trayIcon.ShowBalloonTip(1000, "Service killed", ServiceName + " has been killed", ToolTipIcon.Warning);
                                showBallonNotification("Service killed", ServiceName + " has been killed", ToolTipIcon.Warning);
                                logger("Service: " + ServiceName + " killed");
                            }
                            else
                            {
                                counterServices++;
                                logger("Service: " + ServiceName + " killed (Startup-Kill)");
                            }
                        }
                        catch (InvalidOperationException error)
                        {
                            showBallonNotification("Service could not be stopped", ServiceName + " could not be stopped " +
                                "\n Error: " + error.Message, ToolTipIcon.Warning);
                            logger("Service: " + ServiceName + " unable to kill");
                        }
                    }
                }
                else
                {
                    //trayIcon.ShowBalloonTip(1000, "Service could not be found", "Cannot find a service with this name: " + ServiceName, ToolTipIcon.Warning);
                    showBallonNotification("Service could not be found", "Cannot find a service with this name: " + ServiceName, ToolTipIcon.Warning);
                }
            }

            if (isStartUp)
            {
                showTryIconsOnStartUp();
                isStartUp = false;
            }
        }

        private void showTryIconsOnStartUp()
        {
            showBallonNotification("Termination on StartUp", counterProcesses + " Processes killed \n" + counterServices + " Services stopped.", ToolTipIcon.Warning);
        }

        private void logger(string message) //TODO
        {
            if (Properties.Settings.Default.logfile)
            {
                string filePath = workingDirectory + @"\logfile.txt";
                File.AppendAllText(filePath, message + " - " + DateTime.Now + "\n");
            }
        }

        private void showBallonNotification(string title, string message, ToolTipIcon icon)
        {
            if (Properties.Settings.Default.shownotification)
            {
                trayIcon.ShowBalloonTip(1000, title, message, icon);
            }
        }
    }
}
