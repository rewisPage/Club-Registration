using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Alberto_Ariel_RegistrationWithDB
{
    public class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource bindingSource;

        private string connectionString;

        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;

        public ClubRegistrationQuery()
        {
            // Connection string configured for your SSMS instance (ANNEX-PC00)
            connectionString = @"Server=ANNEX-PC00; Database=ClubDB1; User Id=alberto.395919; Password=123456; TrustServerCertificate=True;";
            sqlConnect = new SqlConnection(connectionString);

            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public bool DisplayList()
        {
            string ViewClubMembers = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);

            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;

            return true;
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES (@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            return true;
        }

        // Helper for auto-incrementing ID safely even after restarting the app
        public int GetCurrentMaxID()
        {
            int maxId = 0;
            sqlCommand = new SqlCommand("SELECT ISNULL(MAX(ID), 0) FROM ClubMembers", sqlConnect);

            sqlConnect.Open();
            maxId = Convert.ToInt32(sqlCommand.ExecuteScalar());
            sqlConnect.Close();

            return maxId;
        }

        // Challenge Exercise: Load all StudentIds into FrmUpdateMember ComboBox
        public void LoadStudentIDs(ComboBox cbStudentId)
        {
            cbStudentId.Items.Clear();
            sqlCommand = new SqlCommand("SELECT StudentId FROM ClubMembers", sqlConnect);

            sqlConnect.Open();
            sqlReader = sqlCommand.ExecuteReader();
            while (sqlReader.Read())
            {
                cbStudentId.Items.Add(sqlReader["StudentId"].ToString());
            }
            sqlReader.Close();
            sqlConnect.Close();
        }

        // Challenge Exercise: Fetch student details when StudentId is selected
        public bool GetStudentDetails(long StudentID)
        {
            bool found = false;
            sqlCommand = new SqlCommand("SELECT FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers WHERE StudentId = @StudentID", sqlConnect);
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;

            sqlConnect.Open();
            sqlReader = sqlCommand.ExecuteReader();
            if (sqlReader.Read())
            {
                _FirstName = sqlReader["FirstName"].ToString();
                _MiddleName = sqlReader["MiddleName"].ToString();
                _LastName = sqlReader["LastName"].ToString();
                _Age = Convert.ToInt32(sqlReader["Age"]);
                _Gender = sqlReader["Gender"].ToString();
                _Program = sqlReader["Program"].ToString();
                found = true;
            }
            sqlReader.Close();
            sqlConnect.Close();

            return found;
        }

        // Challenge Exercise: Update student record
        public bool UpdateStudent(long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand(
                "UPDATE ClubMembers SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Age = @Age, Gender = @Gender, Program = @Program WHERE StudentId = @StudentID",
                sqlConnect);

            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();

            return true;
        }
    }
}