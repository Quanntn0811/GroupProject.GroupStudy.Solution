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
    public partial class frmGroup : Form
    {
        IGroupRepository repo = new GroupRepository();
        BindingSource source;
        public frmGroup()
        {
            InitializeComponent();
        }

        private void frmGroup_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadGroupList();
        }

        private void LoadGroupList()
        {
            var list = repo.GetGroups();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtGroupID.DataBindings.Clear();
                txtSubjectID.DataBindings.Clear();
                txtSize.DataBindings.Clear();
                ckStatus.DataBindings.Clear();

                txtGroupID.DataBindings.Add("Text", source, "GroupID");
                txtSubjectID.DataBindings.Add("Text", source, "SubjectID");
                txtSize.DataBindings.Add("Text", source, "Size");
                ckStatus.DataBindings.Add("Checked", source, "Status", true, DataSourceUpdateMode.OnPropertyChanged);

                dgvGroupList.DataSource = null;
                dgvGroupList.DataSource = source;

                if (list.Count() != 0)
                {
                    btnDelete.Enabled = true;
                }
                else btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on load list of Group");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "FlowerBouquet Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                repo.Delete(int.Parse(txtGroupID.Text));
                LoadGroupList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnSort_Click(object sender, EventArgs e)
        {
            repo.SortByID();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmGroupDetail f = new frmGroupDetail
            {
                Text = "Add group",
                groupRepository = repo,
                AddOrUpdate = true,
                GroupInfo = new Group()
            };

            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadGroupList();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Group group = new Group
            {
                GroupId = int.Parse(txtGroupID.Text),
                SubjectId = txtSubjectID.Text,
                Size = int.Parse(txtSize.Text),
                Status = ckStatus.Checked ? true : false
            };
            frmGroupDetail f = new frmGroupDetail
            {
                Text = "Update group",
                groupRepository = repo,
                AddOrUpdate = false,
                GroupInfo = group
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadGroupList();
            }
        }
    }
}
