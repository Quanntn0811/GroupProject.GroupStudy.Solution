namespace GroupStudyWinApp
{
    partial class frmStudyMaterial
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
            txtSearch = new TextBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            ckStatus = new CheckBox();
            txtTitle = new TextBox();
            txtSlotID = new TextBox();
            txtStudyMaterialID = new TextBox();
            btnClose = new Button();
            btnDelete = new Button();
            lbStatus = new Label();
            lbTitle = new Label();
            dgvGroupList = new DataGridView();
            lbSlotID = new Label();
            lbStudyMaterialID = new Label();
            lbfrmStudyMaterial = new Label();
            txtLink = new TextBox();
            lbLink = new Label();
            txtContent = new TextBox();
            lbContent = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGroupList).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.ForeColor = SystemColors.ControlDark;
            txtSearch.Location = new Point(65, 205);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(242, 27);
            txtSearch.TabIndex = 124;
            txtSearch.Text = "Search Title here";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(641, 311);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 123;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(640, 247);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 122;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.Enabled = false;
            ckStatus.Location = new Point(506, 166);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(18, 17);
            ckStatus.TabIndex = 121;
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Control;
            txtTitle.Location = new Point(506, 74);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(228, 27);
            txtTitle.TabIndex = 120;
            // 
            // txtSlotID
            // 
            txtSlotID.BackColor = SystemColors.Control;
            txtSlotID.Location = new Point(161, 115);
            txtSlotID.Name = "txtSlotID";
            txtSlotID.ReadOnly = true;
            txtSlotID.Size = new Size(234, 27);
            txtSlotID.TabIndex = 119;
            // 
            // txtStudyMaterialID
            // 
            txtStudyMaterialID.BackColor = SystemColors.Control;
            txtStudyMaterialID.Location = new Point(161, 74);
            txtStudyMaterialID.Name = "txtStudyMaterialID";
            txtStudyMaterialID.ReadOnly = true;
            txtStudyMaterialID.Size = new Size(234, 27);
            txtStudyMaterialID.TabIndex = 118;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(641, 436);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 117;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(641, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 116;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(433, 160);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 115;
            lbStatus.Text = "Status";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(433, 74);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(38, 20);
            lbTitle.TabIndex = 114;
            lbTitle.Text = "Title";
            // 
            // dgvGroupList
            // 
            dgvGroupList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroupList.Location = new Point(31, 247);
            dgvGroupList.Name = "dgvGroupList";
            dgvGroupList.RowHeadersWidth = 51;
            dgvGroupList.RowTemplate.Height = 29;
            dgvGroupList.Size = new Size(576, 217);
            dgvGroupList.TabIndex = 113;
            // 
            // lbSlotID
            // 
            lbSlotID.AutoSize = true;
            lbSlotID.Location = new Point(31, 115);
            lbSlotID.Name = "lbSlotID";
            lbSlotID.Size = new Size(50, 20);
            lbSlotID.TabIndex = 112;
            lbSlotID.Text = "SlotID";
            // 
            // lbStudyMaterialID
            // 
            lbStudyMaterialID.AutoSize = true;
            lbStudyMaterialID.Location = new Point(31, 74);
            lbStudyMaterialID.Name = "lbStudyMaterialID";
            lbStudyMaterialID.Size = new Size(116, 20);
            lbStudyMaterialID.TabIndex = 111;
            lbStudyMaterialID.Text = "StudyMaterialID";
            // 
            // lbfrmStudyMaterial
            // 
            lbfrmStudyMaterial.AutoSize = true;
            lbfrmStudyMaterial.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbfrmStudyMaterial.Location = new Point(223, 19);
            lbfrmStudyMaterial.Name = "lbfrmStudyMaterial";
            lbfrmStudyMaterial.Size = new Size(384, 37);
            lbfrmStudyMaterial.TabIndex = 110;
            lbfrmStudyMaterial.Text = "Study Material Management";
            // 
            // txtLink
            // 
            txtLink.BackColor = SystemColors.Control;
            txtLink.Location = new Point(161, 157);
            txtLink.Name = "txtLink";
            txtLink.ReadOnly = true;
            txtLink.Size = new Size(234, 27);
            txtLink.TabIndex = 125;
            // 
            // lbLink
            // 
            lbLink.AutoSize = true;
            lbLink.Location = new Point(31, 160);
            lbLink.Name = "lbLink";
            lbLink.Size = new Size(35, 20);
            lbLink.TabIndex = 126;
            lbLink.Text = "Link";
            // 
            // txtContent
            // 
            txtContent.BackColor = SystemColors.Control;
            txtContent.Location = new Point(506, 115);
            txtContent.Name = "txtContent";
            txtContent.ReadOnly = true;
            txtContent.Size = new Size(228, 27);
            txtContent.TabIndex = 127;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Location = new Point(433, 115);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(61, 20);
            lbContent.TabIndex = 128;
            lbContent.Text = "Content";
            // 
            // frmStudyMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 484);
            Controls.Add(lbContent);
            Controls.Add(txtContent);
            Controls.Add(lbLink);
            Controls.Add(txtLink);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(ckStatus);
            Controls.Add(txtTitle);
            Controls.Add(txtSlotID);
            Controls.Add(txtStudyMaterialID);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(lbStatus);
            Controls.Add(lbTitle);
            Controls.Add(dgvGroupList);
            Controls.Add(lbSlotID);
            Controls.Add(lbStudyMaterialID);
            Controls.Add(lbfrmStudyMaterial);
            Name = "frmStudyMaterial";
            Text = "frmStudyMaterial";
            Load += frmStudyMaterial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGroupList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnUpdate;
        private Button btnAdd;
        private CheckBox ckStatus;
        private TextBox txtTitle;
        private TextBox txtSlotID;
        private TextBox txtStudyMaterialID;
        private Button btnClose;
        private Button btnDelete;
        private Label lbStatus;
        private Label lbTitle;
        private DataGridView dgvGroupList;
        private Label lbSlotID;
        private Label lbStudyMaterialID;
        private Label lbfrmStudyMaterial;
        private TextBox txtLink;
        private Label lbLink;
        private TextBox txtContent;
        private Label lbContent;
    }
}