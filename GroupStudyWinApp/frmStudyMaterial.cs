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
        IStudyMaterialRepository repo = new StudyMaterialRepository();
        BindingSource source;
        public frmStudyMaterial()
        {
            InitializeComponent();
        }

        private void frmStudyMaterial_Load(object sender, EventArgs e)
        {
            LoadStudyMaterial();
        }

        private void LoadStudyMaterial()
        {
            var list = repo.GetStudyMaterials();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtStudyMaterialID.DataBindings.Clear();
                txtSlotID.DataBindings.Clear();
                txtLink.DataBindings.Clear();
                txtTitle.DataBindings.Clear();
                txtContent.DataBindings.Clear();
                ckStatus.DataBindings.Clear();

                txtStudyMaterialID.DataBindings.Add("Text", source, "StudyMaterialID");
                txtSlotID.DataBindings.Add("Text", source, "SlotID");
                txtLink.DataBindings.Add("Text", source, "Link");
                txtTitle.DataBindings.Add("Text", source, "Title");
                txtContent.DataBindings.Add("Text", source, "Content");
                ckStatus.DataBindings.Add("Checked", source, "Status", true, DataSourceUpdateMode.OnPropertyChanged);

                dgvGroupList.DataSource = null;
                dgvGroupList.DataSource = source;

                if (list.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadStudyMaterial(IEnumerable<StudyMaterial> list)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtStudyMaterialID.DataBindings.Clear();
                txtSlotID.DataBindings.Clear();
                txtLink.DataBindings.Clear();
                txtTitle.DataBindings.Clear();
                txtContent.DataBindings.Clear();
                ckStatus.DataBindings.Clear();

                txtStudyMaterialID.DataBindings.Add("Text", source, "StudyMaterialID");
                txtSlotID.DataBindings.Add("Text", source, "SlotID");
                txtLink.DataBindings.Add("Text", source, "Link");
                txtTitle.DataBindings.Add("Text", source, "Title");
                txtContent.DataBindings.Add("Text", source, "Content");
                ckStatus.DataBindings.Add("Checked", source, "Status", true, DataSourceUpdateMode.OnPropertyChanged);

                dgvGroupList.DataSource = null;
                dgvGroupList.DataSource = source;

                if (list.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStudyMaterialDetail f = new frmStudyMaterialDetail
            {
                Text = "Add Study Material",
                AddOrUpdate = true,
                StudyMaterialCurrent = new StudyMaterial()
            };

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadStudyMaterial();
                source.Position = source.Count - 1;
            }
            LoadStudyMaterial();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudyMaterial studyMaterial = new StudyMaterial
            {
                StudyMaterialId = int.Parse(txtStudyMaterialID.Text),
                SlotId = int.Parse(txtSlotID.Text),
                Link = txtLink.Text,
                Title = txtTitle.Text,
                Content = txtContent.Text,
                Status = ckStatus.Checked ? true : false
            };
            frmStudyMaterialDetail f = new frmStudyMaterialDetail
            {
                Text = "Update Study Material",
                AddOrUpdate = false,
                StudyMaterialCurrent = studyMaterial
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadStudyMaterial();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "Study Material Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                repo.DeleteStudyMaterialByID(int.Parse(txtStudyMaterialID.Text));
                LoadStudyMaterial();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<StudyMaterial> ListSearch;
            if (txtSearch.Text == null || txtSearch.Text == "Search Title here")
            {
                ListSearch = repo.GetStudyMaterials();
            }
            else
            {
                ListSearch = repo.GetStudyMaterials().Where(st => st.Title.ToUpper().Contains(txtSearch.Text.ToUpper())).ToList();
            }
            LoadStudyMaterial(ListSearch);
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Title here")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search Title here";
                txtSearch.ForeColor = Color.Gray;
            }
        }
    }
}
