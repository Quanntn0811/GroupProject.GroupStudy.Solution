namespace GroupStudyWinApp
{
    partial class frmSubject
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSubjectID = new TextBox();
            txtDescription = new TextBox();
            txtStatus = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgvSubject = new DataGridView();
            btnLoad = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(203, 9);
            label1.Name = "label1";
            label1.Size = new Size(359, 46);
            label1.TabIndex = 0;
            label1.Text = "Management Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 98);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "SubjectID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 154);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 98);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "Desciption";
            // 
            // txtSubjectID
            // 
            txtSubjectID.Location = new Point(132, 91);
            txtSubjectID.Name = "txtSubjectID";
            txtSubjectID.Size = new Size(246, 27);
            txtSubjectID.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(517, 91);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(246, 27);
            txtDescription.TabIndex = 5;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(132, 147);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(246, 27);
            txtStatus.TabIndex = 6;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dgvSubject
            // 
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(53, 198);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.RowHeadersWidth = 51;
            dgvSubject.RowTemplate.Height = 29;
            dgvSubject.Size = new Size(428, 221);
            dgvSubject.TabIndex = 7;
            dgvSubject.CellDoubleClick += dgvSubject_CellDoubleClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(598, 196);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(598, 266);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(598, 328);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(598, 388);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(dgvSubject);
            Controls.Add(txtStatus);
            Controls.Add(txtDescription);
            Controls.Add(txtSubjectID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSubject";
            Text = "Subject";
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSubjectID;
        private TextBox txtDescription;
        private TextBox txtStatus;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgvSubject;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClose;
    }
}