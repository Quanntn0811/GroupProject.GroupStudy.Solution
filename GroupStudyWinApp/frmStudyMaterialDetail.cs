using BusinessObjects.EntityModels;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupStudyWinApp
{
    public partial class frmStudyMaterialDetail : Form
    {
        public StudyMaterial StudyMaterialCurrent { get; set; }
        public Boolean AddOrUpdate { get; set; }
        IStudyMaterialRepository repoStudy = new StudyMaterialRepository();
        ISlotRepository repoSlot = new SlotRepository();
        public frmStudyMaterialDetail()
        {
            InitializeComponent();
        }

        private void frmStudyMaterialDetail_Load(object sender, EventArgs e)
        {
            var slot = repoSlot.GetSlots().FirstOrDefault(s => s.SlotId == StudyMaterialCurrent.SlotId);
            LoadSubjectId();
            if (AddOrUpdate)
            {
                cbSlot.SelectedIndex = 0;
            }
            else
            {
                cbSlot.Text = slot.SlotName;
            }
            txtLink.Text = StudyMaterialCurrent.Link;
            txtTitle.Text = StudyMaterialCurrent.Title;
            txtContent.Text = StudyMaterialCurrent.Content;
            ckStatus.Checked = StudyMaterialCurrent.Status == true ? true : false;
        }

        public void LoadSubjectId()
        {
            try
            {
                var slotList = repoSlot.GetSlots();
                cbSlot.DataSource = slotList;
                cbSlot.DisplayMember = "SlotName";
                cbSlot.ValueMember = "SlotID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Slot");
            }
        }

        private string Validate(StudyMaterial study)
        {
            if (string.IsNullOrEmpty(study.Title.Trim()))
            {
                return "Title is required";
            }
            else if (string.IsNullOrEmpty(study.Content.Trim()))
            {
                return "Content is required";
            }
            return "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StudyMaterial study = new StudyMaterial
                {
                    StudyMaterialId = StudyMaterialCurrent.StudyMaterialId,
                    SlotId = int.Parse(cbSlot.SelectedValue.ToString()),
                    Link = txtLink.Text,
                    Title = txtTitle.Text,
                    Content = txtContent.Text,
                    Status = ckStatus.Checked ? true : false
                };
                string check = Validate(study);
                if (!string.IsNullOrEmpty(check))
                {
                    MessageBox.Show(check);
                }
                else
                {
                    if (AddOrUpdate)
                    {
                        repoStudy.AddStudyMaterial(study);
                        MessageBox.Show("Add successfully!", "Notification");
                    }
                    else
                    {
                        repoStudy.UpdateStudyMaterial(study);
                        if (MessageBox.Show("Update successfully!", "Notification", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, AddOrUpdate ? "Add Fail" : "Update Fail");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
