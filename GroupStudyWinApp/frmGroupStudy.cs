using BusinessObjects.EntityModels;
using DataAccessObjects;
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
    public partial class frmGroupStudy : Form
    {
        ICommentRepository commentRepo = new CommentRepository();
        ISlotRepository slotRepo = new SlotRepository();
        BindingSource source = new BindingSource();
        //-----------------------------------------
        public frmGroupStudy()
        {
            InitializeComponent();
        }
        public Group CurrentGroup { get; set; }
        public User CurrentUser { get; set; }
        //-----------------------------------------
        private void frmGroupStudy_Load(object sender, EventArgs e)
        {
            LoadCommentList();
            LoadSlotList();
            lbxComment.HorizontalScrollbar = true;
        }

        //-----------------------------------------
        private void LoadCommentList()
        {
            var list = CommentDAO.Instance.GetCommentsByGroupId(CurrentGroup.GroupId);
            foreach (var item in list)
            {
                if (item.UserId == CurrentUser.UserId)
                {

                    lbxComment.Items.Add("You: " + item.Comment1);
                }
                else
                {
                    lbxComment.Items.Add(item.User.Username + ": " + item.Comment1);
                }

            }
        }

        private void LoadSlotList()
        {
            var list = slotRepo.GetSlotsByGroupId(CurrentGroup.GroupId);
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                dgvSlot.DataSource = null;
                dgvSlot.DataSource = list;

                dgvSlot.Columns[0].Visible = false;
                dgvSlot.Columns[1].Visible = false;
                dgvSlot.Columns[4].Visible = false;
                dgvSlot.Columns[5].Visible = false;
                dgvSlot.Columns[6].Visible = false;

                dgvSlot.Columns[3].Width = 500;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list");
            }
        }
        //-----------------------------------------
        private void btnComment_Click(object sender, EventArgs e)
        {
            if (txtComment.Text.Trim().Length == 0) MessageBox.Show("Please enter something", "Warning");
            else
            {
                lbxComment.Items.Clear();
                var comment = new Comment
                {
                    UserId = CurrentUser.UserId,
                    Comment1 = txtComment.Text,
                    GroupId = CurrentGroup.GroupId,
                };

                commentRepo.AddNew(comment);
                LoadCommentList();
                txtComment.Text = string.Empty;
            }
        }

    }
}
