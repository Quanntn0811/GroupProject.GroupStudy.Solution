using BusinessObjects.EntityModels;
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

        //-----------------------------------
        public bool IsAdminOrStudent { get; set; } // admin = true; student = false;
        public User CurrentUser { get; set; }
        //-----------------------------------
        public frmMain()
        {
            InitializeComponent();
        }
        private void manageSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubject frmSubject = new frmSubject();
            frmSubject.ShowDialog();
        }
    }
}
