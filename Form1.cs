using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Self_Learn
{
    public partial class LoginRegister : Form
    {
        /* Променливи */

        private bool isTrue = false;
        private int imageCounter = 1;

        /* Променливи */
        public LoginRegister() /* Начало на програмата */
        {
            InitializeComponent();
            Program.Connection();
            mailBox.PlaceholderText = "selfteacher@example.com";
            usernameBox.PlaceholderText = "Потребителско име";
            passwordBox.PlaceholderText = "Въведи своята парола";
            slidingTimer.Enabled = true;
            AcceptButton = isTrue ? createButton : (IButtonControl)loginButton;
        }
        private void LoginRegister_Load(object sender, EventArgs e)
        {
            //SelfLearn form3 = new SelfLearn();
            //form3.Show();
        } /* Евент за тестване */
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } /* Бутон за затваряне на програмата */
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } /* Бутон за минимилизиране на програмата */
        private void CreateButton_Click(object sender, EventArgs e)
        {
            SwitchForms();
        } /* Бутон за смяна на формите */
        private void LoginButton_Click(object sender, EventArgs e) /* Бутон за влизане и регистрация на ученически акаунт */
        {
            bool isFirstBoxEmpty = string.IsNullOrEmpty(usernameBox.Text), isSecondBoxEmpty = string.IsNullOrEmpty(passwordBox.Text), isThirdBoxEmpty = string.IsNullOrEmpty(mailBox.Text);
            if (loginButton.Text == "Login")
            {
                DBConnection.conn.Open();
                MySqlCommand cmd = DBConnection.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from loginsystem where username='" + usernameBox.Text + "' and password='" + passwordBox.Text + "'";
                MySqlCommand command = new MySqlCommand(cmd.CommandText, DBConnection.conn);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                int i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (isFirstBoxEmpty || isSecondBoxEmpty)
                {
                    MessageBox.Show("Едно от полетата по-горе е празно, опитайте отново.");
                }
                else
                {
                    if (i == 0)
                    {
                        MessageBox.Show("Потребителското име или парола е грешно, моля опитайте отново.");
                    }
                    else
                    {
                        MessageBox.Show("Браво! Успешно влизане в акаунта: " + usernameBox.Text);
                        Program.Globals.username = usernameBox.Text;
                        Program.Globals.password = passwordBox.Text;

                        string selectQuery = "select name from loginsystem where username='" + usernameBox.Text + "'";
                        MySqlCommand myCommand = new MySqlCommand(selectQuery, DBConnection.conn);
                        MySqlDataReader myReader;
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();
                        Program.Globals.name = myReader.GetString(0);

                        DBConnection.conn.Close();
                        DBConnection.conn.Open();

                        string selectAccountQuery = "select type from loginsystem where username='" + usernameBox.Text + "'";
                        MySqlCommand myCommand2 = new MySqlCommand(selectAccountQuery, DBConnection.conn);
                        MySqlDataReader myReader2;
                        myReader2 = myCommand2.ExecuteReader();
                        myReader2.Read();
                        Program.Globals.typeOfAccount = myReader2.GetString(0);

                        DBConnection.conn.Close();
                        DBConnection.conn.Open();

                        string selectMailQuery = "select email from loginsystem where username='" + usernameBox.Text + "'";
                        MySqlCommand myCommand3 = new MySqlCommand(selectMailQuery, DBConnection.conn);
                        MySqlDataReader myReader3;
                        myReader3 = myCommand3.ExecuteReader();
                        myReader3.Read();
                        Program.Globals.mail = myReader3.GetString(0);

                        SelfLearn form3 = new SelfLearn();
                        form3.Show();
                        Visible = false;
                    }
                }
                DBConnection.conn.Close();
            }
            else
            {
                Random rnd = new Random();
                int generatedNumbers = rnd.Next(10000, 99999);
                string randomName = $"User{generatedNumbers}";
                string typeOfAccount = "Student";
                string insertQuery = "INSERT INTO selfteacher.loginsystem(username,name,email,password,type) VALUES('" + usernameBox.Text + "', + '" + randomName + "', '" + mailBox.Text + "','" + passwordBox.Text + "', '" + typeOfAccount + "')";
                DBConnection.conn.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, DBConnection.conn);
                MySqlCommand cmd = DBConnection.conn.CreateCommand();

                cmd.CommandText = "SELECT COUNT(*) FROM loginsystem WHERE email = @email ";
                cmd.Parameters.AddWithValue("@email", mailBox.Text);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
                var mailValidation = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                try
                {
                    if (isFirstBoxEmpty || isSecondBoxEmpty || isThirdBoxEmpty)
                    {
                        MessageBox.Show("Едно от полетата е празно, моля опитайте отново.");
                    }
                    else if (!mailValidation.IsMatch(mailBox.Text))
                    {
                        MessageBox.Show("Не можете да създадете акаунт с такъв мейл, моля опитайте отново.");
                    }
                    else if (hasSymbols.IsMatch(usernameBox.Text))
                    {
                        MessageBox.Show("Потребителското име не трябва да съдържа символи.");
                    }
                    else if (usernameBox.Text.Length < 5)
                    {
                        MessageBox.Show("Потребителското име която сте задали е с по-малко от 5 знака.");
                    }
                    else if (passwordBox.Text.Length < 8)
                    {
                        MessageBox.Show("Паролата която сте задали е с по-малко от 8 знака.");
                    }
                    else if (result > 0)
                    {
                        MessageBox.Show("Имейла вече съществува!");
                    }
                    else if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Успешно създаване на акаунт");
                        LoginRegister f1 = new LoginRegister();
                        f1.Show();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Грешка");
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Duplicate entry"))
                    {
                        MessageBox.Show("Потребителското име вече съществува!");
                    }
                    else
                    {
                        MessageBox.Show("Грешка с базата данни - " + ex.Message);
                    }
                }
                DBConnection.conn.Close();
            }
        } 
        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.UseSystemPasswordChar)
            {
                passwordBox.UseSystemPasswordChar = false;
                showPasswordButton.Image = Properties.Resources.showeye;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
                showPasswordButton.Image = Properties.Resources.splasheye;
            }
        } /* Бутон за показване/скриване на паролата */
        private void SlidingTimer_Tick(object sender, EventArgs e)
        {
            ImageSlider();
        } /* Евент за смяна на снимките през 3.5 секунди */
        private void ImageSlider()
        {
            pictureBox2.BackgroundImage = null;
            if (imageCounter == 4)
            {
                imageCounter = 1;
                pictureBox2.BackgroundImage = Properties.Resources.teacherIllustration1;
            }
            else
            {
                Image[] slidingImages = new Image[4];
                slidingImages[0] = Properties.Resources.teacherIllustration1;
                slidingImages[1] = Properties.Resources.teacherIlustration2;
                slidingImages[2] = Properties.Resources.teacherIlustration3;
                slidingImages[3] = Properties.Resources.teacherIlustration4;
                pictureBox2.BackgroundImage = slidingImages[imageCounter];
            }
            imageCounter++;
        } /* Функция за Slidera на снимки */
        private void SwitchForms()
        {
            if (isTrue)
            {
                usernameBox.Location = new Point(644, 226);
                userImage.Location = new Point(591, 226);
                passwordBox.Location = new Point(644, 297);
                passwordImage.Location = new Point(591, 297);
                showPasswordButton.Location = new Point(864, 306);
                loginButton.Location = new Point(644, 373);
                label.Text = "Влезте във вашият акаунт";
                createButton.Text = "Създай акаунт";
                loginButton.Text = "Login";
                mailBox.Visible = false;
                mailImage.Visible = false;
                isTrue = false;
                mailBox.Text = "";
                usernameBox.Text = "";
                passwordBox.Text = "";
            }
            else
            {
                usernameBox.Location = new Point(644, 297);
                userImage.Location = new Point(591, 297);
                passwordBox.Location = new Point(644, 366);
                passwordImage.Location = new Point(591, 366);
                showPasswordButton.Location = new Point(864, 375);
                loginButton.Location = new Point(644, 438);
                label.Text = "Създаване на нов акаунт";
                createButton.Text = "Влез в акаунт";
                loginButton.Text = "Register";
                mailBox.Text = "";
                usernameBox.Text = "";
                passwordBox.Text = "";
                mailBox.Visible = true;
                mailImage.Visible = true;
                isTrue = true;
            }
        } /* Функция за смяна на формите */
    }
}
