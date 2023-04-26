using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Self_Learn
{
    public partial class AdminPage : UserControl
    {
        /* Променливи */

        private DataTable dtRecords = new DataTable();
        private MySqlCommand myCommand;
        private MySqlDataReader myReader;

        private string query;
        private bool isSelected = false;

        /* Променливи */

        public AdminPage() /* Начало на програмата */
        {
            InitializeComponent();

            Program.Connection();
            DashboardInformation();
            LoadTypeOfAccounts();
            LoadDataIntoDataGrid();
        }
        private void SearchButton_Click(object sender, EventArgs e) /* Бутон за търсене на потребител в базата от данни на програмата */
        {
            if (SearchBox.Text == "")
            {
                MessageBox.Show("Не сте въвели нищо в търсачката..", "SelfLearn");
            }
            else
            {
                DataView dv = dtRecords.DefaultView;
                dv.RowFilter = string.Format("Потребител like '%{0}%'", SearchBox.Text);
                DataGrid.DataSource = dv.ToTable();
            }
        }
        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e) /* Event за търсене на потребител в базата от данни на програмата */
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (SearchBox.Text == "")
                {
                    MessageBox.Show("Не сте въвели нищо в търсачката..", "SelfLearn");
                }
                else
                {
                    DataView dv = dtRecords.DefaultView;
                    dv.RowFilter = string.Format("Потребител like '%{0}%'", SearchBox.Text);
                    DataGrid.DataSource = dv.ToTable();
                }
            }
        }
        private void LoadDataIntoDataGrid() /* Зареждане на информацията в DataGrid-a */
        {
            DBConnection.conn.Open();
            string selectQuery = "SELECT username as 'Потребител', name as 'Име', email as 'Мейл', password as 'Парола', type as 'Вид акаунт' FROM loginsystem";
            myCommand = new MySqlCommand(selectQuery, DBConnection.conn);
            myReader = myCommand.ExecuteReader();

            dtRecords.Clear();
            dtRecords.Load(myReader);

            DataGrid.DataSource = dtRecords;

            DBConnection.conn.Close();
        }
        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) /* Event за въвеждане автоматично на стойностите при натискане на клетка в DataGrid-a */
        {
            UsernameBox.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            NameBox.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            MailBox.Text = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            PasswordBox.Text = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
            TypeOfAccountBox.Text = DataGrid.SelectedRows[0].Cells[4].Value.ToString();
            isSelected = true;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                MessageBox.Show("Не сте избрали потребител в базата данни.", "SelfLearn");
                isSelected = false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Желаете ли да изтриете този потребител от базата данни на програмата ни?", "SelfLearn", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DBConnection.conn.Open();
                    query = $"DELETE FROM loginsystem where username = '{UsernameBox.Text}'";
                    myCommand = new MySqlCommand(query, DBConnection.conn);
                    myCommand.ExecuteNonQuery();
                    DBConnection.conn.Close();
                    LoadDataIntoDataGrid();
                    ClearText();
                }
            }
        } /* Бутон за изтриване на потребителски акаунт в програмата */
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "" || MailBox.Text == "" || NameBox.Text == "" || PasswordBox.Text == "" || TypeOfAccountBox.Text == "")
            {
                MessageBox.Show("Едно от полетата по-горе бе празно, моля проверете дали всичко е наред.", "SelfLearn");
            }
            else
            {
                DialogResult result = MessageBox.Show("Желаете ли да добавите този потребител в базата данни на програмата ни?", "SelfLearn", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DBConnection.conn.Open();
                    query = $"INSERT INTO loginsystem(username,name,email,password,type) VALUES('{UsernameBox.Text}', '{NameBox.Text}', '{MailBox.Text}', '{PasswordBox.Text}', '{TypeOfAccountBox.Text}')";
                    myCommand = new MySqlCommand(query, DBConnection.conn);
                    myCommand.ExecuteNonQuery();
                    DBConnection.conn.Close();
                    LoadDataIntoDataGrid();
                    ClearText();
                }
            }
        } /* Бутон за добавяне на нов потребителски акаунт в програмата */
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (!isSelected)
            {
                MessageBox.Show("Не сте избрали потребител в базата данни.", "SelfLearn");
                isSelected = false;
            }
            else
            {
                DialogResult result = MessageBox.Show("Желаете ли да обновите тези промени за този потребител в базата данни на програмата ни?", "SelfLearn", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DBConnection.conn.Open();
                    query = $"UPDATE loginsystem SET username = '{UsernameBox.Text}', name = '{NameBox.Text}', email = '{MailBox.Text}', password = '{PasswordBox.Text}', type = '{TypeOfAccountBox.Text}' WHERE username = '{DataGrid.SelectedRows[0].Cells[0].Value.ToString()}'";
                    myCommand = new MySqlCommand(query, DBConnection.conn);
                    myCommand.ExecuteNonQuery();
                    DBConnection.conn.Close();
                    LoadDataIntoDataGrid();
                    ClearText();
                }
            }
        } /* Бутон за обновяване на информация за даден потребителски акаунт в програмата */
        private void ClearText() /* Изчистване на всеки текст във всеки TextBox след като е изпълнена някоя команда */
        {
            UsernameBox.Text = "";
            NameBox.Text = "";
            MailBox.Text = "";
            PasswordBox.Text = "";
            NameBox.PlaceholderText = "Име";
            MailBox.PlaceholderText = "Мейл";
            PasswordBox.PlaceholderText = "Парола";
        }
        private void LoadTypeOfAccounts() /* Зареждане на видове акаунти в ComboBox TypeOfAccountBox */
        {
            string[] typeOfAccounts = {
                    "Student",
                    "Administrator"
                };
            for (int i = 0; i < typeOfAccounts.Length; i++)
            {
                TypeOfAccountBox.Items.Add(typeOfAccounts[i]);
            }
        }
        private void DashboardInformation()
        {
            /* Променливи */

            SearchBox.PlaceholderText = "Търсене...";
            UsernameBox.PlaceholderText = "Потребителско име";
            NameBox.PlaceholderText = "Име";
            MailBox.PlaceholderText = "Мейл";
            PasswordBox.PlaceholderText = "Парола";

            /* Променливи */

            /* Заявки */

            string totalUsersQuery = "SELECT COUNT(*) FROM loginsystem";
            string totalExcellentUsers = "SELECT COUNT(*) FROM results WHERE mark = 'Отличен 6'";
            string totalFinishedTests = "SELECT COUNT(*) FROM results";
            string totalStudentsQuery = "SELECT COUNT(*) FROM loginsystem WHERE type = 'Student'";

            /* Заявки */

            /* Взимане на броя потребители в програмата */

            DBConnection.conn.Open();
            myCommand = new MySqlCommand(totalUsersQuery, DBConnection.conn);
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            TotalAccountsLabel.Text = myReader.GetString(0);
            DBConnection.conn.Close();

            /* Взимане на броя потребители в програмата */

            /* Взимане на броя ученици с Отличен 6 в програмата */

            DBConnection.conn.Open();
            myCommand = new MySqlCommand(totalExcellentUsers, DBConnection.conn);
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            TotalExcellentUsersLabel.Text = myReader.GetString(0);
            DBConnection.conn.Close();

            /* Взимане на броя ученици с Отличен 6 в програмата */

            /* Взимане на броя направени тестове в програмата */

            DBConnection.conn.Open();
            myCommand = new MySqlCommand(totalFinishedTests, DBConnection.conn);
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            TotalFinishedTests.Text = myReader.GetString(0);
            DBConnection.conn.Close();

            /* Взимане на броя направени тестове в програмата */

            /* Взимане на броя ученически акаунта в програмата */

            DBConnection.conn.Open();
            myCommand = new MySqlCommand(totalStudentsQuery, DBConnection.conn);
            myReader = myCommand.ExecuteReader();
            myReader.Read();
            TotalTeachersLabel.Text = myReader.GetString(0);
            DBConnection.conn.Close();

            /* Взимане на броя ученически акаунта в програмата */
        } /* Зареждане на информацията за Dashboard-a */
    }
}
