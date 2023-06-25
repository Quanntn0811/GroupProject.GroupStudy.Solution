namespace GroupStudyWinApp
{
    partial class frmGroupDetail
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
            ckStatus = new CheckBox();
            txtSize = new TextBox();
            lbStatus = new Label();
            lbSize = new Label();
            lbSubjectID = new Label();
            lbfrmGroup = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            cbSubjectID = new ComboBox();
            SuspendLayout();
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.Location = new Point(347, 193);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(18, 17);
            ckStatus.TabIndex = 115;
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // txtSize
            // 
            txtSize.BackColor = Color.White;
            txtSize.Location = new Point(347, 146);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(222, 27);
            txtSize.TabIndex = 114;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(260, 190);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 111;
            lbStatus.Text = "Status";
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Location = new Point(260, 146);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(36, 20);
            lbSize.TabIndex = 110;
            lbSize.Text = "Size";
            // 
            // lbSubjectID
            // 
            lbSubjectID.AutoSize = true;
            lbSubjectID.Location = new Point(260, 100);
            lbSubjectID.Name = "lbSubjectID";
            lbSubjectID.Size = new Size(73, 20);
            lbSubjectID.TabIndex = 109;
            lbSubjectID.Text = "SubjectID";
            // 
            // lbfrmGroup
            // 
            lbfrmGroup.AutoSize = true;
            lbfrmGroup.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbfrmGroup.Location = new Point(347, 22);
            lbfrmGroup.Name = "lbfrmGroup";
            lbfrmGroup.Size = new Size(97, 37);
            lbfrmGroup.TabIndex = 107;
            lbfrmGroup.Text = "Group";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(347, 234);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 116;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(475, 234);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 117;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cbSubjectID
            // 
            cbSubjectID.FormattingEnabled = true;
            cbSubjectID.Location = new Point(347, 100);
            cbSubjectID.Name = "cbSubjectID";
            cbSubjectID.Size = new Size(222, 28);
            cbSubjectID.TabIndex = 118;
            // 
            // frmGroupDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 430);
            Controls.Add(cbSubjectID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(ckStatus);
            Controls.Add(txtSize);
            Controls.Add(lbStatus);
            Controls.Add(lbSize);
            Controls.Add(lbSubjectID);
            Controls.Add(lbfrmGroup);
            Name = "frmGroupDetail";
            Text = "frmGroupDetail";
            Load += frmGroupDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ckStatus;
        private TextBox txtSize;
        private Label lbStatus;
        private Label lbSize;
        private Label lbSubjectID;
        private Label lbfrmGroup;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cbSubjectID;
    }
}