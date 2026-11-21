namespace Alberto_Ariel_RegistrationWithDB
{
    partial class FrmClubRegistration
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
            groupBox1 = new GroupBox();
            cbGender = new ComboBox();
            txtAge = new TextBox();
            txtMiddleName = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            cbProgram = new ComboBox();
            txtStudentId = new TextBox();
            lblGender = new Label();
            lblAge = new Label();
            lblMiddleName = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblProgram = new Label();
            lblStudentId = new Label();
            btnRegister = new Button();
            btnUpdate = new Button();
            lblListTitle = new Label();
            dataGridView = new DataGridView();
            btnRefresh = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbGender);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtMiddleName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(cbProgram);
            groupBox1.Controls.Add(txtStudentId);
            groupBox1.Controls.Add(lblGender);
            groupBox1.Controls.Add(lblAge);
            groupBox1.Controls.Add(lblMiddleName);
            groupBox1.Controls.Add(lblFirstName);
            groupBox1.Controls.Add(lblLastName);
            groupBox1.Controls.Add(lblProgram);
            groupBox1.Controls.Add(lblStudentId);
            groupBox1.Location = new Point(19, 16);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(817, 225);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 9.75F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(274, 178);
            cbGender.Margin = new Padding(4, 3, 4, 3);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(186, 25);
            cbGender.TabIndex = 13;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 9.75F);
            txtAge.Location = new Point(20, 178);
            txtAge.Margin = new Padding(4, 3, 4, 3);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(151, 25);
            txtAge.TabIndex = 11;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 9.75F);
            txtMiddleName.Location = new Point(523, 111);
            txtMiddleName.Margin = new Padding(4, 3, 4, 3);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(233, 25);
            txtMiddleName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9.75F);
            txtFirstName.Location = new Point(274, 111);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(233, 25);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9.75F);
            txtLastName.Location = new Point(20, 111);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(233, 25);
            txtLastName.TabIndex = 5;
            // 
            // cbProgram
            // 
            cbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProgram.Font = new Font("Segoe UI", 9.75F);
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Computer Science", "BS in Information Technology", "BS in Hospitality Management", "BS in Business Administration", "BS in Computer Engineering" });
            cbProgram.Location = new Point(523, 44);
            cbProgram.Margin = new Padding(4, 3, 4, 3);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(262, 25);
            cbProgram.TabIndex = 3;
            // 
            // txtStudentId
            // 
            txtStudentId.Font = new Font("Segoe UI", 9.75F);
            txtStudentId.Location = new Point(20, 44);
            txtStudentId.Margin = new Padding(4, 3, 4, 3);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(215, 25);
            txtStudentId.TabIndex = 1;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9.75F);
            lblGender.Location = new Point(271, 155);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(54, 17);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9.75F);
            lblAge.Location = new Point(16, 155);
            lblAge.Margin = new Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(34, 17);
            lblAge.TabIndex = 10;
            lblAge.Text = "Age:";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI", 9.75F);
            lblMiddleName.Location = new Point(519, 88);
            lblMiddleName.Margin = new Padding(4, 0, 4, 0);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(88, 17);
            lblMiddleName.TabIndex = 8;
            lblMiddleName.Text = "Middle name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 9.75F);
            lblFirstName.Location = new Point(271, 88);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(74, 17);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 9.75F);
            lblLastName.Location = new Point(16, 88);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(70, 17);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last name:";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Segoe UI", 9.75F);
            lblProgram.Location = new Point(519, 21);
            lblProgram.Margin = new Padding(4, 0, 4, 0);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(62, 17);
            lblProgram.TabIndex = 2;
            lblProgram.Text = "Program:";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI", 9.75F);
            lblStudentId.Location = new Point(16, 21);
            lblStudentId.Margin = new Padding(4, 0, 4, 0);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(71, 17);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9.75F);
            btnRegister.Location = new Point(854, 25);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(122, 42);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9.75F);
            btnUpdate.Location = new Point(854, 76);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(122, 42);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 9.75F);
            lblListTitle.Location = new Point(19, 258);
            lblListTitle.Margin = new Padding(4, 0, 4, 0);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(135, 17);
            lblListTitle.TabIndex = 3;
            lblListTitle.Text = "List Of Club Members";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(19, 286);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(817, 213);
            dataGridView.TabIndex = 4;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9.75F);
            btnRefresh.Location = new Point(854, 286);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(122, 42);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 522);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridView);
            Controls.Add(lblListTitle);
            Controls.Add(btnUpdate);
            Controls.Add(btnRegister);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmClubRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Registration";
            Load += FrmClubRegistration_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox cbProgram;
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
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnRefresh;
    }
}