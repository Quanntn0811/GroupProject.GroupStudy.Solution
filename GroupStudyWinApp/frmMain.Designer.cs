namespace GroupStudyWinApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            manageToolStripMenuItem = new ToolStripMenuItem();
            manageSubjectToolStripMenuItem = new ToolStripMenuItem();
            manageGroupToolStripMenuItem = new ToolStripMenuItem();
            manageUserToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            groupToolStripMenuItem = new ToolStripMenuItem();
            joinGroupToolStripMenuItem = new ToolStripMenuItem();
            yourGroupToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageToolStripMenuItem, exitToolStripMenuItem, logoutToolStripMenuItem, groupToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageSubjectToolStripMenuItem, manageGroupToolStripMenuItem, manageUserToolStripMenuItem });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(77, 24);
            manageToolStripMenuItem.Text = "Manage";
            // 
            // manageSubjectToolStripMenuItem
            // 
            manageSubjectToolStripMenuItem.Name = "manageSubjectToolStripMenuItem";
            manageSubjectToolStripMenuItem.Size = new Size(224, 26);
            manageSubjectToolStripMenuItem.Text = "Manage Subject";
            manageSubjectToolStripMenuItem.Click += manageSubjectToolStripMenuItem_Click;
            // 
            // manageGroupToolStripMenuItem
            // 
            manageGroupToolStripMenuItem.Name = "manageGroupToolStripMenuItem";
            manageGroupToolStripMenuItem.Size = new Size(224, 26);
            manageGroupToolStripMenuItem.Text = "Manage Group";
            // 
            // manageUserToolStripMenuItem
            // 
            manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            manageUserToolStripMenuItem.Size = new Size(224, 26);
            manageUserToolStripMenuItem.Text = "Manage User";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // groupToolStripMenuItem
            // 
            groupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { joinGroupToolStripMenuItem, yourGroupToolStripMenuItem });
            groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            groupToolStripMenuItem.Size = new Size(64, 24);
            groupToolStripMenuItem.Text = "Group";
            // 
            // joinGroupToolStripMenuItem
            // 
            joinGroupToolStripMenuItem.Name = "joinGroupToolStripMenuItem";
            joinGroupToolStripMenuItem.Size = new Size(166, 26);
            joinGroupToolStripMenuItem.Text = "Join Group";
            // 
            // yourGroupToolStripMenuItem
            // 
            yourGroupToolStripMenuItem.Name = "yourGroupToolStripMenuItem";
            yourGroupToolStripMenuItem.Size = new Size(166, 26);
            yourGroupToolStripMenuItem.Text = "Your Group";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(66, 24);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Group Study";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem manageSubjectToolStripMenuItem;
        private ToolStripMenuItem manageGroupToolStripMenuItem;
        private ToolStripMenuItem manageUserToolStripMenuItem;
        private ToolStripMenuItem groupToolStripMenuItem;
        private ToolStripMenuItem joinGroupToolStripMenuItem;
        private ToolStripMenuItem yourGroupToolStripMenuItem;
    }
}