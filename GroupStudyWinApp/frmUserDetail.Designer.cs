namespace GroupStudyWinApp
{
    partial class frmUserDetail
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
            btnReset = new Button();
            dtpkBirthday = new DateTimePicker();
            txtConfirmPassword = new TextBox();
            label6 = new Label();
            btnRegister = new Button();
            txtAddress = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new Point(504, 338);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 27;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // dtpkBirthday
            // 
            dtpkBirthday.Location = new Point(348, 246);
            dtpkBirthday.Name = "dtpkBirthday";
            dtpkBirthday.Size = new Size(250, 27);
            dtpkBirthday.TabIndex = 23;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(348, 203);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(250, 27);
            txtConfirmPassword.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(203, 206);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 28;
            label6.Text = "Confirm-Password *";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(348, 338);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 26;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(348, 292);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 27);
            txtAddress.TabIndex = 25;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(348, 161);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(348, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 17;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(348, 83);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 27);
            txtUsername.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(203, 295);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 24;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 251);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 22;
            label4.Text = "Birthday *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 124);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 20;
            label3.Text = "Email *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 164);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 18;
            label2.Text = "Password *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 86);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 16;
            label1.Text = "Username *";
            // 
            // frmUserDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(dtpkBirthday);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label6);
            Controls.Add(btnRegister);
            Controls.Add(txtAddress);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUserDetail";
            Text = "frmUserDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private DateTimePicker dtpkBirthday;
        private TextBox txtConfirmPassword;
        private Label label6;
        private Button btnRegister;
        private TextBox txtAddress;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}