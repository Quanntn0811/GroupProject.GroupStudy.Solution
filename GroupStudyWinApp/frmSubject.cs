﻿using BusinessObjects.EntityModels;
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
    public partial class frmSubject : Form
    {
        ISubjectRepository repoSubject = new SubjectRepository();
        BindingSource source;
        //------------------------------------------------------
        private void ClearText()
        {
            txtSubjectID.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }
        // Get subject in row user choose in dvgSubject
        private Subject GetCurrentSubject()
        {
            return new Subject
            {
                SubjectId = txtSubjectID.Text,
                Description = txtDescription.Text,
                Status = Convert.ToBoolean(txtStatus.Text),
            };
        }
        // Show data to dgvSubject and fill data to DataBindings
        private void LoadListSubject()
        {
            var subjects = repoSubject.GetSubjects();
            try
            {
                source = new BindingSource();
                source.DataSource = subjects;

                txtSubjectID.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtSubjectID.DataBindings.Add("Text", source, "subjectId");
                txtDescription.DataBindings.Add("Text", source, "description");
                txtStatus.DataBindings.Add("Text", source, "status");

                dgvSubject.DataSource = null;
                dgvSubject.DataSource = source;

                if (subjects.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list subject");
            }
        }
        //------------------------------------------------------
        public frmSubject()
        {
            InitializeComponent();
        }
        // Button Load => show all subject in dgvSubject
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadListSubject();
        }
        // Button Close => show a message for user choose to close form
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want close ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        // Button Add => show a form for fill data to add subject
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSubjectDetail frmSubjectDetail = new frmSubjectDetail
            {
                Text = "Add Subject",
                isAdd = true,
            };
            frmSubjectDetail.ShowDialog();
            LoadListSubject();
        }
        // Button Delete => delete row (subject) user choose in dgvSubject
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Subject deleteSubject = GetCurrentSubject();
            if (MessageBox.Show("Do you want to delete ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                repoSubject.DeleteSubject(deleteSubject.SubjectId);
                LoadListSubject();
            }
        }
        // Double click one in dgvSubject will show form to update data for subject
        private void dgvSubject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSubjectDetail frmSubjectDetail = new frmSubjectDetail
            {
                isAdd = false,
                Text = "Update subject",
                currentSubject = GetCurrentSubject(),
            };
            frmSubjectDetail.ShowDialog();
            LoadListSubject();
        }
    }
}