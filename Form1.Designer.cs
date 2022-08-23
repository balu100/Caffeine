namespace Caffeine
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_KeepDisplayAwake = new System.Windows.Forms.CheckBox();
            this.checkbox_AfkMode = new System.Windows.Forms.CheckBox();
            this.linkLabel_About = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keepDisplayAwakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckboxTooltip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CheckboxTooltip2 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Windows will not go to sleep \r\nwhile this program is running.\r\n\r\n";
            // 
            // checkBox_KeepDisplayAwake
            // 
            this.checkBox_KeepDisplayAwake.AutoSize = true;
            this.checkBox_KeepDisplayAwake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_KeepDisplayAwake.Location = new System.Drawing.Point(89, 115);
            this.checkBox_KeepDisplayAwake.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_KeepDisplayAwake.Name = "checkBox_KeepDisplayAwake";
            this.checkBox_KeepDisplayAwake.Size = new System.Drawing.Size(151, 20);
            this.checkBox_KeepDisplayAwake.TabIndex = 1;
            this.checkBox_KeepDisplayAwake.Text = "Keep Display Awake";
            this.checkBox_KeepDisplayAwake.UseVisualStyleBackColor = true;
            this.checkBox_KeepDisplayAwake.CheckedChanged += new System.EventHandler(this.checkBox_KeepDisplayAwake_CheckedChanged);
            // 
            // checkbox_AfkMode
            // 
            this.checkbox_AfkMode.AutoSize = true;
            this.checkbox_AfkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkbox_AfkMode.Location = new System.Drawing.Point(89, 142);
            this.checkbox_AfkMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkbox_AfkMode.Name = "checkbox_AfkMode";
            this.checkbox_AfkMode.Size = new System.Drawing.Size(135, 20);
            this.checkbox_AfkMode.TabIndex = 2;
            this.checkbox_AfkMode.Text = "Enable AFK Mode";
            this.checkbox_AfkMode.UseVisualStyleBackColor = true;
            // 
            // linkLabel_About
            // 
            this.linkLabel_About.AutoSize = true;
            this.linkLabel_About.Location = new System.Drawing.Point(14, 209);
            this.linkLabel_About.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_About.Name = "linkLabel_About";
            this.linkLabel_About.Size = new System.Drawing.Size(164, 15);
            this.linkLabel_About.TabIndex = 3;
            this.linkLabel_About.TabStop = true;
            this.linkLabel_About.Text = "github.com/balu100/Caffeine";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Caffeine";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.keepDisplayAwakeToolStripMenuItem,
            this.afkModeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 98);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // keepDisplayAwakeToolStripMenuItem
            // 
            this.keepDisplayAwakeToolStripMenuItem.Name = "keepDisplayAwakeToolStripMenuItem";
            this.keepDisplayAwakeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.keepDisplayAwakeToolStripMenuItem.Text = "Keep Display Awake";
            // 
            // afkModeToolStripMenuItem
            // 
            this.afkModeToolStripMenuItem.Name = "afkModeToolStripMenuItem";
            this.afkModeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.afkModeToolStripMenuItem.Text = "Enable AFK Mode";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // CheckboxTooltip1
            // 
            this.CheckboxTooltip1.AutoPopDelay = 10000;
            this.CheckboxTooltip1.InitialDelay = 500;
            this.CheckboxTooltip1.ReshowDelay = 100;
            this.CheckboxTooltip1.ShowAlways = true;
            // 
            // CheckboxTooltip2
            // 
            this.CheckboxTooltip2.AutoPopDelay = 10000;
            this.CheckboxTooltip2.InitialDelay = 500;
            this.CheckboxTooltip2.ReshowDelay = 100;
            this.CheckboxTooltip2.ShowAlways = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(374, 234);
            this.Controls.Add(this.linkLabel_About);
            this.Controls.Add(this.checkbox_AfkMode);
            this.Controls.Add(this.checkBox_KeepDisplayAwake);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Caffeine";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckBox checkBox_KeepDisplayAwake;
        private CheckBox checkbox_AfkMode;
        private LinkLabel linkLabel_About;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem keepDisplayAwakeToolStripMenuItem;
        private ToolStripMenuItem afkModeToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolTip CheckboxTooltip1;
        private ToolTip CheckboxTooltip2;
    }
}