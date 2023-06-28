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
    public partial class frmStudyMaterial : Form
    {
        IStudyMaterialRepository studyMRepo = new StudyMaterialRepository();
        //-------------------------------------------------
        public frmStudyMaterial()
        {
            InitializeComponent();
        }

        public Slot CurrentSlot { get; set; }
        //------------------------------------------------
        public void LoadStudyMaterialList()
        {
            var list = studyMRepo.GetStudyMaterialsByID(1);
            int i = 1;
            foreach (var item in list)
            {
                rtbContent.AppendText($"{i++}. " + item.Title + "\n", Color.Black);
                rtbContent.AppendText(item.Content + "\n\n");
            }

        }


        private void frmStudyMaterial_Load(object sender, EventArgs e)
        {
            LoadStudyMaterialList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to close", "Notification"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
