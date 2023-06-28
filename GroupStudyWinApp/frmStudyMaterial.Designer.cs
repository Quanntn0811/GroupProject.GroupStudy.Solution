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
            rtbContent = new RichTextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(12, 12);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(917, 468);
            rtbContent.TabIndex = 0;
            rtbContent.TabStop = false;
            rtbContent.Text = "";
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Yes;
            btnClose.Location = new Point(835, 501);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmStudyMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 542);
            Controls.Add(btnClose);
            Controls.Add(rtbContent);
            Name = "frmStudyMaterial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStudyMaterial";
            Load += frmStudyMaterial_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbContent;
        private Button btnClose;
    }
}