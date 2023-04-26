using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Text.RegularExpressions;

namespace Self_Learn
{
    public partial class NewSettingsPage : UserControl
    {
        /* Променливи */

        private MemoryStream ms;
        private MySqlCommand myCommand;
        private MySqlCommand myCommand2;

        private string query = "";
        private string clientUsername = Program.Globals.username;
        private string clientName = Program.Globals.name;
        private string clientMail = Program.Globals.mail;

        /* Променливи */

        public NewSettingsPage()
        {
            InitializeComponent();

            Program.Connection();

            LoadImage();

            UsernameBox.PlaceholderText = clientUsername;
            PasswordBox.PlaceholderText = "Въведете парола";
            FullnameBox.Text = clientName;
            EmailBox.Text = clientMail;
        } /* Начало на програмата */
        public string UpdateUsername => UsernameBox.Text; /* Обновяване на потребителското име в програмата */
        public Image UpdateImage => LogoBox.Image; /* Обновяване на снимката на съответния профил в програмата */
        private void SaveButton_Click(object sender, EventArgs e) /* Бутон за запазване на информацията на съответния профил в програмата */
        {
            Regex hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            Regex mailValidation = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (UsernameBox.Text == "" || PasswordBox.Text == "" || EmailBox.Text == "" || FullnameBox.Text == "")
            {
                MessageBox.Show("Едно от полетата по-горе е празно, опитайте отново.");
            }
            else
            {
                DBConnection.conn.Open();

                string usernameQuery = $"SELECT COUNT(*) FROM loginsystem WHERE username = '{UsernameBox.Text}' ";
                string mailQuery = $"SELECT COUNT(*) FROM loginsystem WHERE email = '{EmailBox.Text}' ";

                myCommand = new MySqlCommand(usernameQuery, DBConnection.conn);
                myCommand2 = new MySqlCommand(mailQuery, DBConnection.conn);

                int usernameResult = Convert.ToInt32(myCommand.ExecuteScalar());
                int mailResult = Convert.ToInt32(myCommand2.ExecuteScalar());

                DBConnection.conn.Close();

                if (usernameResult > 0 && UsernameBox.Text != clientUsername)
                {
                    MessageBox.Show("Акаунт с това потребителско име вече съществува!");
                }
                else if (mailResult > 0 && EmailBox.Text != clientMail)
                {
                    MessageBox.Show("Акаунт с такъв имейл адрес вече съществува!");
                }
                else if (UsernameBox.Text.Length < 5)
                {
                    MessageBox.Show("Потребителското име която сте задали е с по-малко от 5 знака.");
                }
                else if (!mailValidation.IsMatch(EmailBox.Text))
                {
                    MessageBox.Show("Не можете да създадете акаунт с такъв мейл, моля опитайте отново.");
                }
                else if (hasSymbols.IsMatch(UsernameBox.Text))
                {
                    MessageBox.Show("Потребителското име не трябва да съдържа символи.");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да запазите промените по вашият акаунт?", "SelfLearn", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        DBConnection.conn.Open();

                        query = $"UPDATE loginsystem SET username = '{UsernameBox.Text}', name = '{FullnameBox.Text}', email = '{EmailBox.Text}', password = '{PasswordBox.Text}' WHERE username = '{clientUsername}' AND email = '{clientMail}'";

                        myCommand = new MySqlCommand(query, DBConnection.conn);
                        myCommand.ExecuteNonQuery();

                        clientUsername = UsernameBox.Text;
                        clientName = FullnameBox.Text;
                        clientMail = EmailBox.Text;

                        UsernameBox.PlaceholderText = clientUsername;
                        FullnameBox.Text = clientName;
                        EmailBox.Text = clientMail;

                        SelfLearn parent = Parent as SelfLearn;
                        parent.UpdateUsername = UpdateUsername;

                        DBConnection.conn.Close();
                        UsernameBox.Text = "";
                        PasswordBox.Text = "";
                    }
                }
            }
        }
        private void InsertImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "All Files(*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imageLocation = dialog.FileName;
                LogoBox.ImageLocation = imageLocation;
            }
        } /* Бутон за вмъкване на снимка за съответния профил в програмата */
        private void SaveImageButton_Click(object sender, EventArgs e)
        {
            DeleteImage();

            DBConnection.conn.Open();
            query = $"INSERT INTO images (name, image) VALUES('" + clientUsername + "',@Pic) ON DUPLICATE KEY UPDATE image = '@Pic'";

            MemoryStream stream = new MemoryStream();
            LogoBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();
            myCommand = new MySqlCommand(query, DBConnection.conn);
            myCommand.Parameters.AddWithValue("@Pic", pic);
            myCommand.ExecuteNonQuery();
            SelfLearn parent = Parent as SelfLearn;
            parent.UpdateImage = UpdateImage;
            DBConnection.conn.Close();
        } /* Бутон за запазване на снимката на съответния профил в програмата */
        private void DeactivateButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сигурни ли сте, че искате да деактивирате/изтриете акаунта си?", "SelfLearn", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBConnection.conn.Open();

                query = $"DELETE FROM loginsystem WHERE username = '{clientUsername}'";
                myCommand = new MySqlCommand(query, DBConnection.conn);
                myCommand.ExecuteNonQuery();

                DBConnection.conn.Close();

                Thread.Sleep(3000);
                Application.Exit();
            }
        } /* Бутон за деактивиране/изтриване на съответния акаунт в програмата */
        private void LoadImage()
        {
            query = "select image from images where name='" + clientUsername + "'";
            DBConnection.conn.Close();
            DBConnection.conn.Open();
            MySqlCommand myCommand = new MySqlCommand(query, DBConnection.conn);
            MySqlDataReader myReader = myCommand.ExecuteReader();
            if (myReader.Read())
            {
                byte[] picArr = (byte[])myReader["image"];
                ms = new MemoryStream(picArr);
                ms.Seek(0, SeekOrigin.Begin);
                LogoBox.Image = Image.FromStream(ms, false, true);
                DBConnection.conn.Close();
            }
        } /* Функция за зареждане на снимката в програмата */
        private void DeleteImage() /* Функция за изтриване на снимката в програмата */
        {
            DBConnection.conn.Open();
            query = $"DELETE FROM images WHERE name = '{clientUsername}'";
            myCommand = new MySqlCommand(query, DBConnection.conn);
            myCommand.ExecuteNonQuery();
            DBConnection.conn.Close();
        }
    }
}
