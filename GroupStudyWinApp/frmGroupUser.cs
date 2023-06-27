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
    public partial class frmGroupUser : Form
    {
        IUserRepository userRepository = new UserRepository();
        public int GroupId { get; set; }
        public frmGroupUser()
        {
            InitializeComponent();
        }

        private void frmGroupUser_Load(object sender, EventArgs e)
        {

        }
    }
}
