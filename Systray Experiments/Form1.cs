﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systray_Experiments
{

    public partial class Form1 : Form
    {
        private string _selectedMenuItem;
        private NotifyIcon messageTrayIcon;
        string workingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public Form1(NotifyIcon trayIcon)
        {
            InitializeComponent();
            messageTrayIcon = trayIcon;

            reloadProgramList();
            reloadServiceList();
            
            //Show amount of current running processes and services
            label_ProcessCounter.Text = listBox_RunningProcesses.Items.Count.ToString();
            label_RunningServicesCounter.Text = listBox_RunningServices.Items.Count.ToString();
            //setup the checkboxes for logging and notification on startup from settings
            checkBox_log.Checked = Properties.Settings.Default.logfile;
            checkBox_notification.Checked = Properties.Settings.Default.shownotification;

            //Show all unallowed programs in listbox on startup
            foreach (string programName in Properties.Settings.Default.programList.Cast<string>().ToArray())
            {
                    listBox_KilList.Items.Add(programName);
            }
            //Show all unallowed services in listbox on startup
            foreach (string serviceName in Properties.Settings.Default.serviceList.Cast<string>().ToArray())
            {
                    listBox_StoppList.Items.Add(serviceName);
            }
        }

        private void actionToBeCreated(object sender, EventArgs e)
        {

        }

        private void richTextBox_Processes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_AddProgramToList_Click(object sender, EventArgs e)
        {
            if (textBox_InputProgramName.Text == "") { return; }

            Properties.Settings.Default.programList.Add(textBox_InputProgramName.Text);
            Properties.Settings.Default.Save();

            listBox_KilList.Items.Add(textBox_InputProgramName.Text);

            textBox_InputProgramName.Text = "";
        }

        private void button_DeleteProgram_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.programList.Remove(textBox_InputProgramName.Text);
            Properties.Settings.Default.Save();
            textBox_InputProgramName.Text = "";
        }

        private void listBox_KillList_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void myListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = listBox_KilList.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                _selectedMenuItem = listBox_KilList.Items[index].ToString();
                contextMenuStrip1.Show(Cursor.Position);
                contextMenuStrip1.Visible = true;
            }
            else
            {
                contextMenuStrip1.Visible = false;
            }
        }
       
        private void processList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = listBox_RunningProcesses.IndexFromPoint(e.Location);
            
            if (index != ListBox.NoMatches)
            {
                _selectedMenuItem = listBox_RunningProcesses.Items[index].ToString();
                contextMenuStrip_ProcessList.Show(Cursor.Position);
                contextMenuStrip_ProcessList.Visible = true;
            }
            else
            {
                contextMenuStrip_ProcessList.Visible = false;
            }
        }
        private void serviceList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = listBox_RunningServices.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                _selectedMenuItem = listBox_RunningServices.Items[index].ToString();
                contextMenu_RunningServices.Show(Cursor.Position);
                contextMenu_RunningServices.Visible = true;
            }
            else
            {
                contextMenu_RunningServices.Visible = false;
            }
        }

        private void stoppServiceList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = listBox_StoppList.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                _selectedMenuItem = listBox_StoppList.Items[index].ToString();
                contextMenu_DeleteService.Show(Cursor.Position);
                contextMenu_DeleteService.Visible = true;
            }
            else
            {
                contextMenu_DeleteService.Visible = false;
            }
        }

        private void delete_menueItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.programList.Remove(listBox_KilList.SelectedItem.ToString());
            Properties.Settings.Default.Save();

            listBox_KilList.Items.Remove(listBox_KilList.SelectedItem.ToString());
            listBox_KilList.Refresh();
        }

        private void add_menueItem_Click(object sender, EventArgs e)
        {
            //cut off trailing spaces as provided by the processlist
            string cleanProcessName = listBox_RunningProcesses.SelectedItem.ToString().Replace("\n", "");

            //do not add own program name to list, this would be a huge mistake
            if (Process.GetCurrentProcess().ProcessName == cleanProcessName)
            {
                string title = "Cannot add the current running program to termination list!";
                string message = "You tried to add the program that is controlling the termination list to the list itself, " +
                                "this is not a good idea!" + "\n\n" +
                                "If you have a program with the very same name, consider renaming the .exe-File of this program";
                MessageBox.Show(message, title);
            }
            else
            {
                Properties.Settings.Default.programList.Add(cleanProcessName);
                Properties.Settings.Default.Save();

                listBox_KilList.Items.Add(cleanProcessName);
                listBox_KilList.Refresh();
            }
        }

        private void add_ServiceToItemList_Click(object sender, EventArgs e)
        {
            //cut off trailing spaces as provided by the processlist
            string cleanServiceName = listBox_RunningServices.SelectedItem.ToString().Replace("\n", "");
            //label3.Text = "#" + cleanServiceName + "#";
            Properties.Settings.Default.serviceList.Add(cleanServiceName);
            Properties.Settings.Default.Save();

            listBox_StoppList.Items.Add(cleanServiceName);
            listBox_StoppList.Refresh();

        }

        private void delete_serviceItemFromList_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.serviceList.Remove(listBox_StoppList.SelectedItem.ToString());
            Properties.Settings.Default.Save();

            listBox_StoppList.Items.Remove(listBox_StoppList.SelectedItem.ToString());
            listBox_StoppList.Refresh();
        }

        private void terminateonceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cleanServiceName = listBox_RunningServices.SelectedItem.ToString().Replace("\n", "");

            ServiceController sc = new ServiceController(cleanServiceName);

            if (sc.Status == ServiceControllerStatus.Running)
            {
                try
                {
                    sc.Stop();
                    sc.WaitForStatus(ServiceControllerStatus.Stopped);
                    showBallonNotification("Service was stopped by User", cleanServiceName + " has been stopped", ToolTipIcon.Warning);
                }
                catch (InvalidOperationException error)
                {
               //     messageTrayIcon.ShowBalloonTip(1000, "Service could not be stopped", cleanServiceName + " could not be stopped " +
               // "\n Error: " + error.Message, ToolTipIcon.Warning);
                    showBallonNotification("Service could not be stopped", cleanServiceName + " could not be stopped " +
                "\n Error: " + error.Message, ToolTipIcon.Warning);
                }
            }
            reloadServiceList();
        }

        private void terminateonceProgram_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string cleanProcessName = listBox_RunningProcesses.SelectedItem.ToString().Replace("\n", "");

            Process[] processesToKill = Process.GetProcessesByName(cleanProcessName);

            foreach (Process process in processesToKill)
            {
                try
                {
                    process.Kill();
                    process.WaitForExit();
                    //messageTrayIcon.ShowBalloonTip(1000, "Process killed", process.ProcessName + " has been killed", ToolTipIcon.Info);
                    showBallonNotification("Process killed", process.ProcessName + " has been killed", ToolTipIcon.Info);
                    logger("Process: " + process.ProcessName + " killed by User");
                }
                catch
                {
                    //messageTrayIcon.ShowBalloonTip(1000, "Access Denied Error", process.ProcessName + " has not been killed", ToolTipIcon.Info);
                    showBallonNotification("Access Denied Error", process.ProcessName + " has not been killed", ToolTipIcon.Info);
                }
            }
            reloadProgramList();
        }
        private void markAsKnownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = workingDirectory + @"\knownProcesses.txt";
            string cleanProcessName = listBox_RunningProcesses.SelectedItem.ToString().Replace("\n", "");

            File.AppendAllText(filePath, cleanProcessName + Environment.NewLine);
        }

        private void reloadServiceList()
        {
            listBox_RunningServices.Items.Clear();
            
            ServiceController[] allServices = ServiceController.GetServices();
            Array.Sort(allServices, (x, y) => String.Compare(x.ServiceName, y.ServiceName));
            
            foreach (ServiceController service in allServices)
            {
                if (service.Status == ServiceControllerStatus.Running)
                {
                    if (!listBox_RunningServices.Items.Contains(service.DisplayName))
                    {
                        listBox_RunningServices.Items.Add(service.DisplayName + "\n");
                    }
                }
            }
            label_RunningServicesCounter.Text = listBox_RunningServices.Items.Count.ToString();
        }

        private void reloadProgramList()
        {
            listBox_RunningProcesses.DrawItem += new DrawItemEventHandler(listBox_ColorHandler);
            listBox_RunningProcesses.Items.Clear();
            //listBox_RunningProcesses.DrawMode = DrawMode.OwnerDrawVariable;
            //listBox_RunningProcesses.BackColor = Color.Green;
            //listBox_RunningProcesses.ForeColor = Color.Orange;

            //listBox_RunningProcesses.DrawItem += new DrawItemEventHandler(listBox_ColorHandler);

            Process[] allProcesses = Process.GetProcesses();
            Array.Sort(allProcesses, (x, y) => String.Compare(x.ProcessName, y.ProcessName));
            
            foreach (Process p in allProcesses)
            {
                if (!listBox_RunningProcesses.Items.Contains(p.ProcessName + "\n"))
                {
                    listBox_RunningProcesses.Items.Add(p.ProcessName + "\n");
                }
            }
            label_ProcessCounter.Text = listBox_RunningProcesses.Items.Count.ToString();
        }
        
        // Anmerkung: vielleicht nicht jedes Mal die Datei lesen, sondern einmal alle Werte auslesen, beim Refresh
        // in übergeordnete Variable und diese auslesen
        private void listBox_ColorHandler(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) { return; }
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as red, as they are unknown.
            Brush myBrush = Brushes.DarkRed;
            //textBox_InputProgramName.Text=  listBox_RunningProcesses.Items[e.Index].ToString();
            string filePath = workingDirectory + @"\knownProcesses.txt";
            if(!File.Exists(filePath))
            {
                File.CreateText(filePath);
            }
            // every process listed in the "filePath" is marked green as known process
            foreach (var line in File.ReadLines(filePath))
            {
                if (listBox_RunningProcesses.Items[e.Index].ToString().Replace("\n", "") == line.Replace("\n", ""))
                {
                    myBrush = Brushes.DarkGreen;
                }
            }

            // Draw the current item text based on the current Font  
            // and the custom brush settings.
            e.Graphics.DrawString(
                (sender as ListBox).Items[e.Index].ToString(),
                e.Font, 
                myBrush, 
                e.Bounds, 
                StringFormat.GenericTypographic);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
        //END
        private void button_ExportProcessList_Click(object sender, EventArgs e)
        {
            string fileName = workingDirectory + @"\exportedProcessList.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (StreamWriter sw = File.CreateText(fileName))
                {
                   //write the items to file for safety reasons
                   foreach (var item in listBox_KilList.Items )
                   {
                        sw.WriteLine(item.ToString());
                   }
                }
            }
            catch (Exception Ex)
            {
                showBallonNotification("Export Error", "Could not export list to filesystem Error: " + Ex.Message, ToolTipIcon.Warning);
            }
        }

        private void button_ImportProcessList_Click(object sender, EventArgs e)
        {
            //Security question to warn overwrite
            string message = "The import of a list will overwrite your current list\n are you sure?";
            string title = "Import Process-Kill-List";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {
                return;
            }

            string fileName = workingDirectory + @"\exportedProcessList.txt";

            listBox_KilList.Items.Clear();
            foreach(var line in File.ReadLines(fileName))
            {
                listBox_KilList.Items.Add(line);
                if (!Properties.Settings.Default.programList.Contains(line))
                {
                    Properties.Settings.Default.programList.Add(line);
                }
            } 
            Properties.Settings.Default.Save();
        }

        private void logger(string message) //TODO
        {
            if (checkBox_log.Checked)
            {
                string filePath = workingDirectory + @"\logfile.txt";
                File.AppendAllText(filePath, message + " - " + DateTime.Now + "\n");
            }
        }

        //change status: logging all kills
        private void checkBox_log_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_log.Checked)
            {
                Properties.Settings.Default.logfile = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.logfile = false;
                Properties.Settings.Default.Save();
            }
        }

        //change status: showing balloon tipps on kill
        private void checkBox_notification_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_notification.Checked)
            {
                Properties.Settings.Default.shownotification = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.shownotification = false;
                Properties.Settings.Default.Save();
            }
            //label1.Text = Properties.Settings.Default.shownotification.ToString();
        }

        private void showBallonNotification(string title, string message, ToolTipIcon icon)
        {
            if (Properties.Settings.Default.shownotification)
            {
                messageTrayIcon.ShowBalloonTip(1000, title, message, icon);
            }
        }

        private void pictureBox_logfile_Click(object sender, EventArgs e)
        {
            if (File.Exists(workingDirectory + @"\logfile.txt"))
            {
                Process.Start(workingDirectory + @"\logfile.txt");
            }
        }

        private void pictureBox_reload_Click(object sender, EventArgs e)
        {
            reloadProgramList();
            reloadServiceList();
        }

       
    }
}
