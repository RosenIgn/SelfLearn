using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Self_Learn
{
    public partial class SelfLearn : Form
    {
        /* Променливи */

        private readonly string clientUsername = Program.Globals.username;
        private readonly string typeOfAccount = Program.Globals.typeOfAccount;

        private MemoryStream ms;

        /* Променливи */
        public SelfLearn() /* Начало на програмата */
        {
            InitializeComponent();
            Program.Connection();

            LoadImage();
            SidePanel.Height = HomeButton.Height;
            homePage1.BringToFront();
            UserLabel.Text = clientUsername;
            TypeOfAccLabel.Text = typeOfAccount;

            if (typeOfAccount == "Administrator")
            {
                AdminButton.Visible = true;
            }
        }
        public string UpdateUsername
        {
            set => UserLabel.Text = value;
        } /* Обновяване на потребителското име на клиента при промяна от него */
        public Image UpdateImage
        {
            set => LogoBox.Image = value;
        } /* Обновяване на снимката на профила на клиента при промяна от него */
        private void MinimizeButton_Click(object sender, EventArgs e) /* Бутон за минимилизиране на програмата */
        {
            WindowState = FormWindowState.Minimized;
        }
        private void ExitButton_Click(object sender, EventArgs e) /* Бутон за затваряне на програмата */
        {
            Application.Exit();
        }
        private void LogOutButton_Click(object sender, EventArgs e) /* Бутон за връщане към формата за регистрация и влизане */
        {
            LoginRegister f1 = new LoginRegister();
            f1.Show();
            Visible = false;
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            homePage1.BringToFront();
        }  /* Бутон за отиване към Home Page */
        private void TextBookButton_Click(object sender, EventArgs e)
        {
            bool isStartedExam = Program.Globals.isStartedExam;
            if (isStartedExam)
            {
                MessageBox.Show("В момента проверявате знанията си, фокусирай се върху теста.", "SelfLearn");
            }
            else
            {
                SidePanel.Height = TextBookButton.Height;
                SidePanel.Top = TextBookButton.Top;
                textBookHeaderPage1.BringToFront();
            }
        } /* Бутон за отиване към TextBook Page */
        private void ExamsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ExamsButton.Height;
            SidePanel.Top = ExamsButton.Top;
            exams1.BringToFront();
        } /* Бутон за отиване към Exams Page */
        private void RankingsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = RankingsButton.Height;
            SidePanel.Top = RankingsButton.Top;
            rankingsHeaderPage1.BringToFront();
        } /* Бутон за отиване към Rankings Page */
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SettingsButton.Height;
            SidePanel.Top = SettingsButton.Top;
            newSettingsPage1.BringToFront();
        } /* Бутон за отиване към Settings Page */
        private void AdminButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = AdminButton.Height;
            SidePanel.Top = AdminButton.Top;
            adminPage1.BringToFront();
        }  /* Бутон за отиване към Admin Page */
        public void LoadImage() /* Функция за зареждане на профилната снимка на клиента */
        {
            string query = "select image from images where name='" + clientUsername + "'";
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
        }
    }
}