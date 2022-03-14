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
            this.label_TotalKilled = new System.Windows.Forms.Label();
            this.label_TotalKilledCounter = new System.Windows.Forms.Label();
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
            this.label_Services = new System.Windows.Forms.Label();
            this.label_RunningServicesCounter = new System.Windows.Forms.Label();
            this.listBox_StoppList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenu_RunningServices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToStopplistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminateonceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_DeleteService = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_ExportProcessList = new System.Windows.Forms.Button();
            this.button_ImportProcessList = new System.Windows.Forms.Button();
            this.checkBox_log = new System.Windows.Forms.CheckBox();
            this.checkBox_notification = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip_ProcessList.SuspendLayout();
            this.contextMenu_RunningServices.SuspendLayout();
            this.contextMenu_DeleteService.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRunningProcesses
            // 
            this.labelRunningProcesses.AutoSize = true;
            this.labelRunningProcesses.Location = new System.Drawing.Point(7, 7);
            this.labelRunningProcesses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRunningProcesses.Name = "labelRunningProcesses";
            this.labelRunningProcesses.Size = new System.Drawing.Size(108, 13);
            this.labelRunningProcesses.TabIndex = 0;
            this.labelRunningProcesses.Text = "Running Processes...";
            // 
            // label_TotalKilled
            // 
            this.label_TotalKilled.AutoSize = true;
            this.label_TotalKilled.Location = new System.Drawing.Point(366, 128);
            this.label_TotalKilled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TotalKilled.Name = "label_TotalKilled";
            this.label_TotalKilled.Size = new System.Drawing.Size(114, 13);
            this.label_TotalKilled.TabIndex = 2;
            this.label_TotalKilled.Text = "Total Killed Processes:";
            // 
            // label_TotalKilledCounter
            // 
            this.label_TotalKilledCounter.AutoSize = true;
            this.label_TotalKilledCounter.Location = new System.Drawing.Point(486, 128);
            this.label_TotalKilledCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TotalKilledCounter.Name = "label_TotalKilledCounter";
            this.label_TotalKilledCounter.Size = new System.Drawing.Size(13, 13);
            this.label_TotalKilledCounter.TabIndex = 3;
            this.label_TotalKilledCounter.Text = "0";
            // 
            // label_ProcessCounter
            // 
            this.label_ProcessCounter.AutoSize = true;
            this.label_ProcessCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_ProcessCounter.Location = new System.Drawing.Point(160, 9);
            this.label_ProcessCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ProcessCounter.Name = "label_ProcessCounter";
            this.label_ProcessCounter.Size = new System.Drawing.Size(13, 13);
            this.label_ProcessCounter.TabIndex = 4;
            this.label_ProcessCounter.Text = "0";
            // 
            // textBox_InputProgramName
            // 
            this.textBox_InputProgramName.Location = new System.Drawing.Point(190, 104);
            this.textBox_InputProgramName.Name = "textBox_InputProgramName";
            this.textBox_InputProgramName.Size = new System.Drawing.Size(155, 20);
            this.textBox_InputProgramName.TabIndex = 5;
            // 
            // button_AddProgramToList
            // 
            this.button_AddProgramToList.Location = new System.Drawing.Point(351, 102);
            this.button_AddProgramToList.Name = "button_AddProgramToList";
            this.button_AddProgramToList.Size = new System.Drawing.Size(99, 23);
            this.button_AddProgramToList.TabIndex = 6;
            this.button_AddProgramToList.Text = "Add Program";
            this.button_AddProgramToList.UseVisualStyleBackColor = true;
            this.button_AddProgramToList.Click += new System.EventHandler(this.button_AddProgramToList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "List of Programs that are not allowed to run...";
            // 
            // listBox_KilList
            // 
            this.listBox_KilList.FormattingEnabled = true;
            this.listBox_KilList.Location = new System.Drawing.Point(193, 166);
            this.listBox_KilList.Name = "listBox_KilList";
            this.listBox_KilList.Size = new System.Drawing.Size(257, 199);
            this.listBox_KilList.TabIndex = 9;
            this.toolTip_runningProcesses.SetToolTip(this.listBox_KilList, "Rightclick to see options on the list entries");
            this.listBox_KilList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myListBox_MouseDown);
            // 
            // listBox_RunningProcesses
            // 
            this.listBox_RunningProcesses.FormattingEnabled = true;
            this.listBox_RunningProcesses.Location = new System.Drawing.Point(10, 24);
            this.listBox_RunningProcesses.Name = "listBox_RunningProcesses";
            this.listBox_RunningProcesses.Size = new System.Drawing.Size(172, 342);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // delete_menueItem
            // 
            this.delete_menueItem.Name = "delete_menueItem";
            this.delete_menueItem.Size = new System.Drawing.Size(107, 22);
            this.delete_menueItem.Text = "Delete";
            this.delete_menueItem.Click += new System.EventHandler(this.delete_menueItem_Click);
            // 
            // contextMenuStrip_ProcessList
            // 
            this.contextMenuStrip_ProcessList.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip_ProcessList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToListToolStripMenuItem,
            this.terminateonceProgram_ToolStripMenuItem1});
            this.contextMenuStrip_ProcessList.Name = "contextMenuStrip_ProcessList";
            this.contextMenuStrip_ProcessList.Size = new System.Drawing.Size(164, 48);
            // 
            // addToListToolStripMenuItem
            // 
            this.addToListToolStripMenuItem.Name = "addToListToolStripMenuItem";
            this.addToListToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addToListToolStripMenuItem.Text = "Add to List";
            this.addToListToolStripMenuItem.Click += new System.EventHandler(this.add_menueItem_Click);
            // 
            // terminateonceProgram_ToolStripMenuItem1
            // 
            this.terminateonceProgram_ToolStripMenuItem1.Name = "terminateonceProgram_ToolStripMenuItem1";
            this.terminateonceProgram_ToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.terminateonceProgram_ToolStripMenuItem1.Text = "Terminate (once)";
            this.terminateonceProgram_ToolStripMenuItem1.Click += new System.EventHandler(this.terminateonceProgram_ToolStripMenuItem1_Click);
            // 
            // listBox_RunningServices
            // 
            this.listBox_RunningServices.FormattingEnabled = true;
            this.listBox_RunningServices.Location = new System.Drawing.Point(10, 389);
            this.listBox_RunningServices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_RunningServices.Name = "listBox_RunningServices";
            this.listBox_RunningServices.Size = new System.Drawing.Size(172, 121);
            this.listBox_RunningServices.TabIndex = 14;
            this.toolTip_runningProcesses.SetToolTip(this.listBox_RunningServices, "shows the currently running services");
            this.listBox_RunningServices.MouseDown += new System.Windows.Forms.MouseEventHandler(this.serviceList_MouseDown);
            // 
            // label_Services
            // 
            this.label_Services.AutoSize = true;
            this.label_Services.Location = new System.Drawing.Point(7, 374);
            this.label_Services.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Services.Name = "label_Services";
            this.label_Services.Size = new System.Drawing.Size(100, 13);
            this.label_Services.TabIndex = 15;
            this.label_Services.Text = "Running Services...";
            // 
            // label_RunningServicesCounter
            // 
            this.label_RunningServicesCounter.AutoSize = true;
            this.label_RunningServicesCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_RunningServicesCounter.Location = new System.Drawing.Point(160, 374);
            this.label_RunningServicesCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RunningServicesCounter.Name = "label_RunningServicesCounter";
            this.label_RunningServicesCounter.Size = new System.Drawing.Size(13, 13);
            this.label_RunningServicesCounter.TabIndex = 16;
            this.label_RunningServicesCounter.Text = "0";
            // 
            // listBox_StoppList
            // 
            this.listBox_StoppList.FormattingEnabled = true;
            this.listBox_StoppList.Location = new System.Drawing.Point(193, 389);
            this.listBox_StoppList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_StoppList.Name = "listBox_StoppList";
            this.listBox_StoppList.Size = new System.Drawing.Size(257, 121);
            this.listBox_StoppList.TabIndex = 17;
            this.listBox_StoppList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stoppServiceList_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 13);
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
            this.contextMenu_RunningServices.Size = new System.Drawing.Size(164, 48);
            // 
            // addToStopplistToolStripMenuItem
            // 
            this.addToStopplistToolStripMenuItem.Name = "addToStopplistToolStripMenuItem";
            this.addToStopplistToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addToStopplistToolStripMenuItem.Text = "Add to Stopplist";
            this.addToStopplistToolStripMenuItem.Click += new System.EventHandler(this.add_ServiceToItemList_Click);
            // 
            // terminateonceToolStripMenuItem
            // 
            this.terminateonceToolStripMenuItem.Name = "terminateonceToolStripMenuItem";
            this.terminateonceToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.terminateonceToolStripMenuItem.Text = "Terminate (once)";
            this.terminateonceToolStripMenuItem.Click += new System.EventHandler(this.terminateonceToolStripMenuItem_Click);
            // 
            // contextMenu_DeleteService
            // 
            this.contextMenu_DeleteService.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenu_DeleteService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenu_DeleteService.Name = "contextMenu_DeleteService";
            this.contextMenu_DeleteService.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.delete_serviceItemFromList_Click);
            // 
            // button_ExportProcessList
            // 
            this.button_ExportProcessList.Location = new System.Drawing.Point(457, 342);
            this.button_ExportProcessList.Name = "button_ExportProcessList";
            this.button_ExportProcessList.Size = new System.Drawing.Size(42, 23);
            this.button_ExportProcessList.TabIndex = 19;
            this.button_ExportProcessList.Text = ">>";
            this.button_ExportProcessList.UseVisualStyleBackColor = true;
            this.button_ExportProcessList.Click += new System.EventHandler(this.button_ExportProcessList_Click);
            // 
            // button_ImportProcessList
            // 
            this.button_ImportProcessList.Location = new System.Drawing.Point(458, 313);
            this.button_ImportProcessList.Name = "button_ImportProcessList";
            this.button_ImportProcessList.Size = new System.Drawing.Size(42, 23);
            this.button_ImportProcessList.TabIndex = 20;
            this.button_ImportProcessList.Text = "<<";
            this.button_ImportProcessList.UseVisualStyleBackColor = true;
            this.button_ImportProcessList.Click += new System.EventHandler(this.button_ImportProcessList_Click);
            // 
            // checkBox_log
            // 
            this.checkBox_log.AutoSize = true;
            this.checkBox_log.Location = new System.Drawing.Point(193, 516);
            this.checkBox_log.Name = "checkBox_log";
            this.checkBox_log.Size = new System.Drawing.Size(57, 17);
            this.checkBox_log.TabIndex = 21;
            this.checkBox_log.Text = "Logfile";
            this.checkBox_log.UseVisualStyleBackColor = true;
            this.checkBox_log.CheckedChanged += new System.EventHandler(this.checkBox_log_CheckedChanged);
            // 
            // checkBox_notification
            // 
            this.checkBox_notification.AutoSize = true;
            this.checkBox_notification.Location = new System.Drawing.Point(265, 516);
            this.checkBox_notification.Name = "checkBox_notification";
            this.checkBox_notification.Size = new System.Drawing.Size(83, 17);
            this.checkBox_notification.TabIndex = 22;
            this.checkBox_notification.Text = "Notify on kill";
            this.checkBox_notification.UseVisualStyleBackColor = true;
            this.checkBox_notification.CheckedChanged += new System.EventHandler(this.checkBox_notification_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 552);
            this.Controls.Add(this.checkBox_notification);
            this.Controls.Add(this.checkBox_log);
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
            this.Controls.Add(this.label_TotalKilledCounter);
            this.Controls.Add(this.label_TotalKilled);
            this.Controls.Add(this.labelRunningProcesses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(533, 591);
            this.Name = "Form1";
            this.Text = "Edit Process Termination";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip_ProcessList.ResumeLayout(false);
            this.contextMenu_RunningServices.ResumeLayout(false);
            this.contextMenu_DeleteService.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRunningProcesses;
        private System.Windows.Forms.Label label_TotalKilled;
        private System.Windows.Forms.Label label_TotalKilledCounter;
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
    }
}

