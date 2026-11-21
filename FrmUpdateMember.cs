using System;
using System.Windows.Forms;

namespace Alberto_Ariel_RegistrationWithDB
{
    public partial class FrmUpdateMember : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private long StudentId;
        private int Age;
        private string FirstName, MiddleName, LastName, Gender, Program;

        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            clubRegistrationQuery.LoadStudentIDs(cbStudentId);
        }

        private void cbStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStudentId.SelectedItem == null) return;

            StudentId = Convert.ToInt64(cbStudentId.SelectedItem.ToString());

            if (clubRegistrationQuery.GetStudentDetails(StudentId))
            {
                txtLastName.Text = clubRegistrationQuery._LastName;
                txtFirstName.Text = clubRegistrationQuery._FirstName;
                txtMiddleName.Text = clubRegistrationQuery._MiddleName;
                txtAge.Text = clubRegistrationQuery._Age.ToString();
                cbGender.SelectedItem = clubRegistrationQuery._Gender;
                cbProgram.SelectedItem = clubRegistrationQuery._Program;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbStudentId.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtMiddleName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                cbGender.SelectedIndex == -1 ||
                cbProgram.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Student ID and fill out all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAge.Text.Trim(), out Age))
            {
                MessageBox.Show("Age must be a valid integer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StudentId = Convert.ToInt64(cbStudentId.SelectedItem.ToString());
            FirstName = txtFirstName.Text.Trim();
            MiddleName = txtMiddleName.Text.Trim();
            LastName = txtLastName.Text.Trim();
            Gender = cbGender.SelectedItem.ToString();
            Program = cbProgram.SelectedItem.ToString();

            clubRegistrationQuery.UpdateStudent(StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
            MessageBox.Show("Member record updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}