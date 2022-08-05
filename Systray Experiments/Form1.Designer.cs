namespace Systray_Experiments
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelRunningProcesses = new System.Windows.Forms.Label();
            this.label_ProcessCounter = new System.Windows.Forms.Label();
            this.textBox_InputProgramName = new System.Windows.Forms.TextBox();
            this.button_AddProgramToList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_KilList = new System.Windows.Forms.ListBox();
            this.listBox_RunningProcesses = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete_menueItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_ProcessList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateonceProgram_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip_runningProcesses = new System.Windows.Forms.ToolTip(this.components);
            this.listBox_RunningServices = new System.Windows.Forms.ListBox();
            this.checkBox_log = new System.Windows.Forms.CheckBox();
            this.checkBox_notification = new System.Windows.Forms.CheckBox();
            this.button_ExportProcessList = new System.Windows.Forms.Button();
            this.button_ImportProcessList = new System.Windows.Forms.Button();
            this.pictureBox_logfile = new System.Windows.Forms.PictureBox();
            this.label_Services = new System.Windows.Forms.Label();
            this.label_RunningServicesCounter = new System.Windows.Forms.Label();
            this.listBox_StoppList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenu_RunningServices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToStopplistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateonceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_DeleteService = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_Settings = new System.Windows.Forms.GroupBox();
            this.pictureBox_reload = new System.Windows.Forms.PictureBox();
            this.markAsKnownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip_ProcessList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logfile)).BeginInit();
            this.contextMenu_RunningServices.SuspendLayout();
            this.contextMenu_DeleteService.SuspendLayout();
            this.groupBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reload)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRunningProcesses
            // 
            this.labelRunningProcesses.AutoSize = true;
            this.labelRunningProcesses.Location = new System.Drawing.Point(13, 13);
            this.labelRunningProcesses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRunningProcesses.Name = "labelRunningProcesses";
            this.labelRunningProcesses.Size = new System.Drawing.Size(196, 25);
            this.labelRunningProcesses.TabIndex = 0;
            this.labelRunningProcesses.Text = "Running Processes...";
            // 
            // label_ProcessCounter
            // 
            this.label_ProcessCounter.AutoSize = true;
            this.label_ProcessCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_ProcessCounter.Location = new System.Drawing.Point(293, 17);
            this.label_ProcessCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ProcessCounter.Name = "label_ProcessCounter";
            this.label_ProcessCounter.Size = new System.Drawing.Size(23, 25);
            this.label_ProcessCounter.TabIndex = 4;
            this.label_ProcessCounter.Text = "0";
            // 
            // textBox_InputProgramName
            // 
            this.textBox_InputProgramName.Location = new System.Drawing.Point(358, 85);
            this.textBox_InputProgramName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_InputProgramName.Name = "textBox_InputProgramName";
            this.textBox_InputProgramName.Size = new System.Drawing.Size(281, 29);
            this.textBox_InputProgramName.TabIndex = 5;
            // 
            // button_AddProgramToList
            // 
            this.button_AddProgramToList.Location = new System.Drawing.Point(653, 81);
            this.button_AddProgramToList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_AddProgramToList.Name = "button_AddProgramToList";
            this.button_AddProgramToList.Size = new System.Drawing.Size(182, 42);
            this.button_AddProgramToList.TabIndex = 6;
            this.button_AddProgramToList.Text = "Add Program";
            this.button_AddProgramToList.UseVisualStyleBackColor = true;
            this.button_AddProgramToList.Click += new System.EventHandler(this.button_AddProgramToList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "List of Programs that are not allowed to run...";
            // 
            // listBox_KilList
            // 
            this.listBox_KilList.FormattingEnabled = true;
            this.listBox_KilList.ItemHeight = 24;
            this.listBox_KilList.Location = new System.Drawing.Point(363, 159);
            this.listBox_KilList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_KilList.Name = "listBox_KilList";
            this.listBox_KilList.Size = new System.Drawing.Size(468, 364);
            this.listBox_KilList.TabIndex = 9;
            this.toolTip_runningProcesses.SetToolTip(this.listBox_KilList, "Rightclick to see options on the list entries");
            this.listBox_KilList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myListBox_MouseDown);
            // 
            // listBox_RunningProcesses
            // 
            this.listBox_RunningProcesses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox_RunningProcesses.FormattingEnabled = true;
            this.listBox_RunningProcesses.Location = new System.Drawing.Point(18, 44);
            this.listBox_RunningProcesses.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox_RunningProcesses.Name = "listBox_RunningProcesses";
            this.listBox_RunningProcesses.Size = new System.Drawing.Size(312, 628);
            this.listBox_RunningProcesses.TabIndex = 10;
            this.toolTip_runningProcesses.SetToolTip(this.listBox_RunningProcesses, "Right-Click on a program to see the Options on the Program");
            this.listBox_RunningProcesses.MouseDown += new System.Windows.Forms.MouseEventHandler(this.processList_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete_menueItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 40);
            // 
            // delete_menueItem
            // 
            this.delete_menueItem.Name = "delete_menueItem";
            this.delete_menueItem.Size = new System.Drawing.Size(146, 36);
            this.delete_menueItem.Text = "Delete";
            this.delete_menueItem.Click += new System.EventHandler(this.delete_menueItem_Click);
            // 
            // contextMenuStrip_ProcessList
            // 
            this.contextMenuStrip_ProcessList.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip_ProcessList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToListToolStripMenuItem,
            this.terminateonceProgram_ToolStripMenuItem1,
            this.markAsKnownToolStripMenuItem});
            this.contextMenuStrip_ProcessList.Name = "contextMenuStrip_ProcessList";
            this.contextMenuStrip_ProcessList.Size = new System.Drawing.Size(271, 150);
            // 
            // addToListToolStripMenuItem
            // 
            this.addToListToolStripMenuItem.Name = "addToListToolStripMenuItem";
            this.addToListToolStripMenuItem.Size = new System.Drawing.Size(240, 36);
            this.addToListToolStripMenuItem.Text = "Add to List";
            this.addToListToolStripMenuItem.Click += new System.EventHandler(this.add_menueItem_Click);
            // 
            // terminateonceProgram_ToolStripMenuItem1
            // 
            this.terminateonceProgram_ToolStripMenuItem1.Name = "terminateonceProgram_ToolStripMenuItem1";
            this.terminateonceProgram_ToolStripMenuItem1.Size = new System.Drawing.Size(240, 36);
            this.terminateonceProgram_ToolStripMenuItem1.Text = "Terminate (once)";
            this.terminateonceProgram_ToolStripMenuItem1.Click += new System.EventHandler(this.terminateonceProgram_ToolStripMenuItem1_Click);
            // 
            // listBox_RunningServices
            // 
            this.listBox_RunningServices.FormattingEnabled = true;
            this.listBox_RunningServices.ItemHeight = 24;
            this.listBox_RunningServices.Location = new System.Drawing.Point(20, 748);
            this.listBox_RunningServices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_RunningServices.Name = "listBox_RunningServices";
            this.listBox_RunningServices.Size = new System.Drawing.Size(312, 172);
            this.listBox_RunningServices.TabIndex = 14;
            this.toolTip_runningProcesses.SetToolTip(this.listBox_RunningServices, "shows the currently running services");
            this.listBox_RunningServices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.serviceList_MouseDown);
            // 
            // checkBox_log
            // 
            this.checkBox_log.AutoSize = true;
            this.checkBox_log.Location = new System.Drawing.Point(11, 35);
            this.checkBox_log.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox_log.Name = "checkBox_log";
            this.checkBox_log.Size = new System.Drawing.Size(95, 29);
            this.checkBox_log.TabIndex = 21;
            this.checkBox_log.Text = "Logfile";
            this.toolTip_runningProcesses.SetToolTip(this.checkBox_log, "Toogle Logfile on/off\r\nActivate to Log everything that is being terminated.");
            this.checkBox_log.UseVisualStyleBackColor = true;
            this.checkBox_log.CheckedChanged += new System.EventHandler(this.checkBox_log_CheckedChanged);
            // 
            // checkBox_notification
            // 
            this.checkBox_notification.AutoSize = true;
            this.checkBox_notification.Location = new System.Drawing.Point(11, 78);
            this.checkBox_notification.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox_notification.Name = "checkBox_notification";
            this.checkBox_notification.Size = new System.Drawing.Size(141, 29);
            this.checkBox_notification.TabIndex = 22;
            this.checkBox_notification.Text = "Notify on kill";
            this.toolTip_runningProcesses.SetToolTip(this.checkBox_notification, "Toogle Notification on/off\r\nShows a windows-notification every time the app kills" +
        " a process.");
            this.checkBox_notification.UseVisualStyleBackColor = true;
            this.checkBox_notification.CheckedChanged += new System.EventHandler(this.checkBox_notification_CheckedChanged);
            // 
            // button_ExportProcessList
            // 
            this.button_ExportProcessList.BackColor = System.Drawing.SystemColors.Control;
            this.button_ExportProcessList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ExportProcessList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExportProcessList.Location = new System.Drawing.Point(776, 484);
            this.button_ExportProcessList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_ExportProcessList.Name = "button_ExportProcessList";
            this.button_ExportProcessList.Size = new System.Drawing.Size(59, 42);
            this.button_ExportProcessList.TabIndex = 19;
            this.button_ExportProcessList.Text = ">>";
            this.toolTip_runningProcesses.SetToolTip(this.button_ExportProcessList, "Export\r\nExports the current deletionlist\r\n");
            this.button_ExportProcessList.UseVisualStyleBackColor = false;
            this.button_ExportProcessList.Click += new System.EventHandler(this.button_ExportProcessList_Click);
            // 
            // button_ImportProcessList
            // 
            this.button_ImportProcessList.BackColor = System.Drawing.SystemColors.Control;
            this.button_ImportProcessList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ImportProcessList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ImportProcessList.Location = new System.Drawing.Point(774, 430);
            this.button_ImportProcessList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_ImportProcessList.Name = "button_ImportProcessList";
            this.button_ImportProcessList.Size = new System.Drawing.Size(61, 42);
            this.button_ImportProcessList.TabIndex = 20;
            this.button_ImportProcessList.Text = "<<";
            this.toolTip_runningProcesses.SetToolTip(this.button_ImportProcessList, "Import \r\nImports the last exported deletionlist");
            this.button_ImportProcessList.UseVisualStyleBackColor = false;
            this.button_ImportProcessList.Click += new System.EventHandler(this.button_ImportProcessList_Click);
            // 
            // pictureBox_logfile
            // 
            this.pictureBox_logfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_logfile.Image = global::Systray_Experiments.Properties.Resources.magnifyingGlass;
            this.pictureBox_logfile.Location = new System.Drawing.Point(105, 35);
            this.pictureBox_logfile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox_logfile.Name = "pictureBox_logfile";
            this.pictureBox_logfile.Size = new System.Drawing.Size(37, 31);
            this.pictureBox_logfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logfile.TabIndex = 23;
            this.pictureBox_logfile.TabStop = false;
            this.toolTip_runningProcesses.SetToolTip(this.pictureBox_logfile, "Open the Logfile\r\nThe file ist opened by the program you have installed to open ." +
        "txt-Files");
            this.pictureBox_logfile.Click += new System.EventHandler(this.pictureBox_logfile_Click);
            // 
            // label_Services
            // 
            this.label_Services.AutoSize = true;
            this.label_Services.Location = new System.Drawing.Point(20, 714);
            this.label_Services.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Services.Name = "label_Services";
            this.label_Services.Size = new System.Drawing.Size(180, 25);
            this.label_Services.TabIndex = 15;
            this.label_Services.Text = "Running Services...";
            // 
            // label_RunningServicesCounter
            // 
            this.label_RunningServicesCounter.AutoSize = true;
            this.label_RunningServicesCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_RunningServicesCounter.Location = new System.Drawing.Point(211, 714);
            this.label_RunningServicesCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RunningServicesCounter.Name = "label_RunningServicesCounter";
            this.label_RunningServicesCounter.Size = new System.Drawing.Size(23, 25);
            this.label_RunningServicesCounter.TabIndex = 16;
            this.label_RunningServicesCounter.Text = "0";
            // 
            // listBox_StoppList
            // 
            this.listBox_StoppList.FormattingEnabled = true;
            this.listBox_StoppList.ItemHeight = 24;
            this.listBox_StoppList.Location = new System.Drawing.Point(363, 570);
            this.listBox_StoppList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_StoppList.Name = "listBox_StoppList";
            this.listBox_StoppList.Size = new System.Drawing.Size(468, 220);
            this.listBox_StoppList.TabIndex = 17;
            this.listBox_StoppList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stoppServiceList_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 543);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "List of Services that are not allowed to run...";
            // 
            // contextMenu_RunningServices
            // 
            this.contextMenu_RunningServices.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenu_RunningServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToStopplistToolStripMenuItem,
            this.terminateonceToolStripMenuItem});
            this.contextMenu_RunningServices.Name = "contextMenu_RunningServices";
            this.contextMenu_RunningServices.Size = new System.Drawing.Size(241, 76);
            // 
            // addToStopplistToolStripMenuItem
            // 
            this.addToStopplistToolStripMenuItem.Name = "addToStopplistToolStripMenuItem";
            this.addToStopplistToolStripMenuItem.Size = new System.Drawing.Size(240, 36);
            this.addToStopplistToolStripMenuItem.Text = "Add to Stopplist";
            this.addToStopplistToolStripMenuItem.Click += new System.EventHandler(this.add_ServiceToItemList_Click);
            // 
            // terminateonceToolStripMenuItem
            // 
            this.terminateonceToolStripMenuItem.Name = "terminateonceToolStripMenuItem";
            this.terminateonceToolStripMenuItem.Size = new System.Drawing.Size(240, 36);
            this.terminateonceToolStripMenuItem.Text = "Terminate (once)";
            this.terminateonceToolStripMenuItem.Click += new System.EventHandler(this.terminateonceToolStripMenuItem_Click);
            // 
            // contextMenu_DeleteService
            // 
            this.contextMenu_DeleteService.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenu_DeleteService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenu_DeleteService.Name = "contextMenu_DeleteService";
            this.contextMenu_DeleteService.Size = new System.Drawing.Size(161, 40);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(160, 36);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.delete_serviceItemFromList_Click);
            // 
            // groupBox_Settings
            // 
            this.groupBox_Settings.Controls.Add(this.pictureBox_logfile);
            this.groupBox_Settings.Controls.Add(this.checkBox_notification);
            this.groupBox_Settings.Controls.Add(this.checkBox_log);
            this.groupBox_Settings.Location = new System.Drawing.Point(356, 807);
            this.groupBox_Settings.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_Settings.Name = "groupBox_Settings";
            this.groupBox_Settings.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox_Settings.Size = new System.Drawing.Size(477, 135);
            this.groupBox_Settings.TabIndex = 23;
            this.groupBox_Settings.TabStop = false;
            this.groupBox_Settings.Text = "Settings";
            // 
            // pictureBox_reload
            // 
            this.pictureBox_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_reload.Image = global::Systray_Experiments.Properties.Resources.reloadIcon;
            this.pictureBox_reload.Location = new System.Drawing.Point(275, 681);
            this.pictureBox_reload.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox_reload.Name = "pictureBox_reload";
            this.pictureBox_reload.Size = new System.Drawing.Size(59, 57);
            this.pictureBox_reload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_reload.TabIndex = 24;
            this.pictureBox_reload.TabStop = false;
            this.pictureBox_reload.Click += new System.EventHandler(this.pictureBox_reload_Click);
            // 
            // markAsKnownToolStripMenuItem
            // 
            this.markAsKnownToolStripMenuItem.Name = "markAsKnownToolStripMenuItem";
            this.markAsKnownToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.markAsKnownToolStripMenuItem.Text = "Mark as known";
            this.markAsKnownToolStripMenuItem.Click += new System.EventHandler(this.markAsKnownToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 962);
            this.Controls.Add(this.pictureBox_reload);
            this.Controls.Add(this.groupBox_Settings);
            this.Controls.Add(this.button_ImportProcessList);
            this.Controls.Add(this.button_ExportProcessList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_StoppList);
            this.Controls.Add(this.label_RunningServicesCounter);
            this.Controls.Add(this.label_Services);
            this.Controls.Add(this.listBox_RunningServices);
            this.Controls.Add(this.listBox_RunningProcesses);
            this.Controls.Add(this.listBox_KilList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddProgramToList);
            this.Controls.Add(this.textBox_InputProgramName);
            this.Controls.Add(this.label_ProcessCounter);
            this.Controls.Add(this.labelRunningProcesses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(897, 980);
            this.Name = "Form1";
            this.Text = "Edit Process Termination";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip_ProcessList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logfile)).EndInit();
            this.contextMenu_RunningServices.ResumeLayout(false);
            this.contextMenu_DeleteService.ResumeLayout(false);
            this.groupBox_Settings.ResumeLayout(false);
            this.groupBox_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_reload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRunningProcesses;
        private System.Windows.Forms.Label label_ProcessCounter;
        private System.Windows.Forms.TextBox textBox_InputProgramName;
        private System.Windows.Forms.Button button_AddProgramToList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_KilList;
        private System.Windows.Forms.ListBox listBox_RunningProcesses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem delete_menueItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_ProcessList;
        private System.Windows.Forms.ToolStripMenuItem addToListToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip_runningProcesses;
        private System.Windows.Forms.ListBox listBox_RunningServices;
        private System.Windows.Forms.Label label_Services;
        private System.Windows.Forms.Label label_RunningServicesCounter;
        private System.Windows.Forms.ListBox listBox_StoppList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenu_RunningServices;
        private System.Windows.Forms.ToolStripMenuItem addToStopplistToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu_DeleteService;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateonceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminateonceProgram_ToolStripMenuItem1;
        private System.Windows.Forms.Button button_ExportProcessList;
        private System.Windows.Forms.Button button_ImportProcessList;
        private System.Windows.Forms.CheckBox checkBox_log;
        private System.Windows.Forms.CheckBox checkBox_notification;
        private System.Windows.Forms.GroupBox groupBox_Settings;
        private System.Windows.Forms.PictureBox pictureBox_logfile;
        private System.Windows.Forms.PictureBox pictureBox_reload;
        private System.Windows.Forms.ToolStripMenuItem markAsKnownToolStripMenuItem;
    }
}

