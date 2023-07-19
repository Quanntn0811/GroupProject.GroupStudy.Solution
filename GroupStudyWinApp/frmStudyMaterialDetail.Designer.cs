namespace GroupStudyWinApp
{
    partial class frmStudyMaterialDetail
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
            btnCancel = new Button();
            btnSave = new Button();
            lbContent = new Label();
            txtContent = new TextBox();
            lbLink = new Label();
            txtLink = new TextBox();
            ckStatus = new CheckBox();
            txtTitle = new TextBox();
            lbStatus = new Label();
            lbTitle = new Label();
            lbSlot = new Label();
            lbStudyMaterialID = new Label();
            cbSlot = new ComboBox();
            nupStudyMaterialID = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nupStudyMaterialID).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(257, 323);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 119;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(129, 323);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 118;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Location = new Point(55, 220);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(61, 20);
            lbContent.TabIndex = 140;
            lbContent.Text = "Content";
            // 
            // txtContent
            // 
            txtContent.BackColor = Color.White;
            txtContent.Location = new Point(183, 217);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(229, 27);
            txtContent.TabIndex = 139;
            // 
            // lbLink
            // 
            lbLink.AutoSize = true;
            lbLink.Location = new Point(53, 137);
            lbLink.Name = "lbLink";
            lbLink.Size = new Size(35, 20);
            lbLink.TabIndex = 138;
            lbLink.Text = "Link";
            // 
            // txtLink
            // 
            txtLink.BackColor = Color.White;
            txtLink.Location = new Point(183, 134);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(229, 27);
            txtLink.TabIndex = 137;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.Enabled = false;
            ckStatus.Location = new Point(183, 268);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(18, 17);
            ckStatus.TabIndex = 136;
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Location = new Point(183, 176);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(229, 27);
            txtTitle.TabIndex = 135;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(55, 265);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 132;
            lbStatus.Text = "Status";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(55, 179);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(38, 20);
            lbTitle.TabIndex = 131;
            lbTitle.Text = "Title";
            // 
            // lbSlot
            // 
            lbSlot.AutoSize = true;
            lbSlot.Location = new Point(53, 92);
            lbSlot.Name = "lbSlot";
            lbSlot.Size = new Size(35, 20);
            lbSlot.TabIndex = 130;
            lbSlot.Text = "Slot";
            // 
            // lbStudyMaterialID
            // 
            lbStudyMaterialID.AutoSize = true;
            lbStudyMaterialID.Location = new Point(53, 51);
            lbStudyMaterialID.Name = "lbStudyMaterialID";
            lbStudyMaterialID.Size = new Size(116, 20);
            lbStudyMaterialID.TabIndex = 129;
            lbStudyMaterialID.Text = "StudyMaterialID";
            // 
            // cbSlot
            // 
            cbSlot.FormattingEnabled = true;
            cbSlot.Location = new Point(183, 89);
            cbSlot.Name = "cbSlot";
            cbSlot.Size = new Size(229, 28);
            cbSlot.TabIndex = 141;
            // 
            // nupStudyMaterialID
            // 
            nupStudyMaterialID.Location = new Point(183, 44);
            nupStudyMaterialID.Name = "nupStudyMaterialID";
            nupStudyMaterialID.Size = new Size(229, 27);
            nupStudyMaterialID.TabIndex = 142;
            // 
            // frmStudyMaterialDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 404);
            Controls.Add(nupStudyMaterialID);
            Controls.Add(cbSlot);
            Controls.Add(lbContent);
            Controls.Add(txtContent);
            Controls.Add(lbLink);
            Controls.Add(txtLink);
            Controls.Add(ckStatus);
            Controls.Add(txtTitle);
            Controls.Add(lbStatus);
            Controls.Add(lbTitle);
            Controls.Add(lbSlot);
            Controls.Add(lbStudyMaterialID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmStudyMaterialDetail";
            Text = "frmStudyMaterialDetail";
            Load += frmStudyMaterialDetail_Load;
            ((System.ComponentModel.ISupportInitialize)nupStudyMaterialID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label lbContent;
        private TextBox txtContent;
        private Label lbLink;
        private TextBox txtLink;
        private CheckBox ckStatus;
        private TextBox txtTitle;
        private Label lbStatus;
        private Label lbTitle;
        private Label lbSlot;
        private Label lbStudyMaterialID;
        private ComboBox cbSlot;
        private NumericUpDown nupStudyMaterialID;
    }
}