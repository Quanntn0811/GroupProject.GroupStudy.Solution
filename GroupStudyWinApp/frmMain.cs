using BusinessObjects.EntityModels;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupStudyWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //----------------------------------------------------
        public bool IsAdminOrStudent { get; set; } // admin = true; student = false;
        public User CurrentUser { get; set; }
        public IUserRepository Repo { get; set; }
        //----------------------------------------------------
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!IsAdminOrStudent)
            {
                manageToolStripMenuItem.Enabled = false;
            }
        }
        private void manageSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubject frmSubject = new frmSubject();
            frmSubject.MdiParent = this;
            frmSubject.Show();
        }
        //----------------------------------------------------
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to exit", "Notification",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetail f = new frmUserDetail
            {
                Text = "Profile",
                UserInfo = CurrentUser,
                IsAdminOrUser = false,
                Repo = this.Repo,
            };

            f.DialogOk += DialogForm_DialogClosed;
            f.MdiParent = this;
            f.Show();

        }
        
        private void manageGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGroup f = new frmGroup();
            f.MdiParent = this;
            f.Show();
        }
        
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to log out", "Notification",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                frmLogin f = new frmLogin();
                f.Show();
                this.Close();
            }
        }
        //----------------------------------------------------
        private void LoadCurrentUser()
        {
            CurrentUser = Repo.GetUsers().SingleOrDefault(x => x.UserId == CurrentUser.UserId);
        }

        private void DialogForm_DialogClosed(object sender, EventArgs e)
        {
            // Handle the event here
            // Perform actions or call methods associated with the OK event
            LoadCurrentUser();
        }
    }
}
