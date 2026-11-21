namespace Alberto_Ariel_RegistrationWithDB
{
    partial class FrmUpdateMember
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblStudentId = new Label();
            cbStudentId = new ComboBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblGender = new Label();
            cbGender = new ComboBox();
            lblProgram = new Label();
            cbProgram = new ComboBox();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI", 9.75F);
            lblStudentId.Location = new Point(21, 18);
            lblStudentId.Margin = new Padding(4, 0, 4, 0);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(71, 17);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // cbStudentId
            // 
            cbStudentId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudentId.Font = new Font("Segoe UI", 9.75F);
            cbStudentId.FormattingEnabled = true;
            cbStudentId.Location = new Point(24, 42);
            cbStudentId.Margin = new Padding(4, 3, 4, 3);
            cbStudentId.Name = "cbStudentId";
            cbStudentId.Size = new Size(256, 25);
            cbStudentId.TabIndex = 1;
            cbStudentId.SelectedIndexChanged += cbStudentId_SelectedIndexChanged;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.75F);
            lblLastName.Location = new Point(21, 81);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(70, 17);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last name:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9.75F);
            txtLastName.Location = new Point(24, 104);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(227, 25);
            txtLastName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.75F);
            lblFirstName.Location = new Point(21, 143);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(74, 17);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9.75F);
            txtFirstName.Location = new Point(24, 166);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(227, 25);
            txtFirstName.TabIndex = 5;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI", 9.75F);
            lblMiddleName.Location = new Point(21, 205);
            lblMiddleName.Margin = new Padding(4, 0, 4, 0);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(88, 17);
            lblMiddleName.TabIndex = 6;
            lblMiddleName.Text = "Middle name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 9.75F);
            txtMiddleName.Location = new Point(24, 228);
            txtMiddleName.Margin = new Padding(4, 3, 4, 3);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(227, 25);
            txtMiddleName.TabIndex = 7;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9.75F);
            lblAge.Location = new Point(21, 268);
            lblAge.Margin = new Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(34, 17);
            lblAge.TabIndex = 8;
            lblAge.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 9.75F);
            txtAge.Location = new Point(24, 291);
            txtAge.Margin = new Padding(4, 3, 4, 3);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(145, 25);
            txtAge.TabIndex = 9;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9.75F);
            lblGender.Location = new Point(21, 330);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(54, 17);
            lblGender.TabIndex = 10;
            lblGender.Text = "Gender:";
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 9.75F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(24, 353);
            cbGender.Margin = new Padding(4, 3, 4, 3);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(186, 25);
            cbGender.TabIndex = 11;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Segoe UI", 9.75F);
            lblProgram.Location = new Point(21, 392);
            lblProgram.Margin = new Padding(4, 0, 4, 0);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(62, 17);
            lblProgram.TabIndex = 12;
            lblProgram.Text = "Program:";
            // 
            // cbProgram
            // 
            cbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProgram.Font = new Font("Segoe UI", 9.75F);
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Computer Science", "BS in Information Technology", "BS in Hospitality Management", "BS in Business Administration", "BS in Computer Engineering" });
            cbProgram.Location = new Point(24, 415);
            cbProgram.Margin = new Padding(4, 3, 4, 3);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(256, 25);
            cbProgram.TabIndex = 13;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9.75F);
            btnConfirm.Location = new Point(96, 464);
            btnConfirm.Margin = new Padding(4, 3, 4, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(122, 39);
            btnConfirm.TabIndex = 14;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 522);
            Controls.Add(btnConfirm);
            Controls.Add(cbProgram);
            Controls.Add(lblProgram);
            Controls.Add(cbGender);
            Controls.Add(lblGender);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(cbStudentId);
            Controls.Add(lblStudentId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpdateMember";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Member";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.ComboBox cbStudentId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Button btnConfirm;
    }
}