namespace GroupStudyWinApp
{
    partial class frmGroupStudy
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
            dgvSlot = new DataGridView();
            lbxComment = new ListBox();
            txtComment = new TextBox();
            btnComment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSlot).BeginInit();
            SuspendLayout();
            // 
            // dgvSlot
            // 
            dgvSlot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSlot.Location = new Point(12, 12);
            dgvSlot.Name = "dgvSlot";
            dgvSlot.RowHeadersWidth = 51;
            dgvSlot.RowTemplate.Height = 29;
            dgvSlot.Size = new Size(764, 175);
            dgvSlot.TabIndex = 0;
            // 
            // lbxComment
            // 
            lbxComment.BorderStyle = BorderStyle.None;
            lbxComment.FormattingEnabled = true;
            lbxComment.ItemHeight = 20;
            lbxComment.Location = new Point(12, 212);
            lbxComment.Name = "lbxComment";
            lbxComment.RightToLeft = RightToLeft.No;
            lbxComment.Size = new Size(380, 180);
            lbxComment.TabIndex = 1;
            // 
            // txtComment
            // 
            txtComment.Location = new Point(12, 409);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(270, 27);
            txtComment.TabIndex = 2;
            // 
            // btnComment
            // 
            btnComment.Location = new Point(298, 409);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(94, 29);
            btnComment.TabIndex = 3;
            btnComment.Text = "Comment";
            btnComment.UseVisualStyleBackColor = true;
            btnComment.Click += btnComment_Click;
            // 
            // frmGroupStudy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnComment);
            Controls.Add(txtComment);
            Controls.Add(lbxComment);
            Controls.Add(dgvSlot);
            Name = "frmGroupStudy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Group Study";
            Load += frmGroupStudy_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSlot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSlot;
        private ListBox lbxComment;
        private TextBox txtComment;
        private Button btnComment;
    }
}