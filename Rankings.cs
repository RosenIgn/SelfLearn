using MySql.Data.MySqlClient;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;

namespace Self_Learn
{
    public partial class Rankings : UserControl
    {
        /* Променливи */

        DataTable dtRecords = new DataTable();
        MySqlCommand myCommand;
        MySqlDataReader myReader;

        private bool classCheck = RankingsHeaderPage.classCheck;
        private string query = "";

        /* Променливи */
        public Rankings() /* Начало на програмата */
        {
            InitializeComponent();
            Program.Connection();

            CheckClass();
            LoadDataIntoDataGrid();
        }
        private void LoadDataIntoDataGrid() /* Зареждане на информацията от базата от данни към DataGrid-a */
        {
            query = classCheck
                ? "SELECT username as 'Потребител', mark as 'Оценка', exam as 'Тест', date as 'Дата' FROM results WHERE exam = 'Електричен ток'"
                : "SELECT username as 'Потребител', mark as 'Оценка', exam as 'Тест', date as 'Дата' FROM results WHERE exam = 'Електромагнитни явления'";
            DBConnection.conn.Open();

            myCommand = new MySqlCommand(query, DBConnection.conn);
            myReader = myCommand.ExecuteReader();
            dtRecords.Clear();
            dtRecords.Load(myReader);

            DataGrid.DataSource = dtRecords;

            DBConnection.conn.Close();
        }
        private void LoadDataForSection() /* Зареждане на информацията от базата от данни към DataGrid-a за съответния Exam */
        {
            DBConnection.conn.Open();
            myCommand = new MySqlCommand(query, DBConnection.conn);
            myReader = myCommand.ExecuteReader();
            dtRecords.Clear();
            dtRecords.Load(myReader);

            DataGrid.DataSource = dtRecords;

            DBConnection.conn.Close();
        }
        private void CheckClass() /* Проверка на класа който е избрал клиента */
        {
            if (classCheck)
            {
                SelectDataButton1.Text = "Част 1. Електричен ток";
                SelectDataButton2.Text = "Част 2. Механично движение";
                SelectDataButton1.Location = new Point(364, 42);
                SelectDataButton2.Location = new Point(595, 42);
                SelectDataButton3.Visible = false;
            }
            else
            {
                SelectDataButton3.Visible = true;
                SelectDataButton1.Text = "Част 1. Електромагнитни явления";
                SelectDataButton2.Text = "Част 2. Светлина";
                SelectDataButton3.Text = "Част 3. От атома до Космоса";
                SelectDataButton1.Location = new Point(260, 42);
                SelectDataButton2.Location = new Point(481, 42);
                SelectDataButton3.Location = new Point(703, 42);
            }
        }
        private void ReturnButton_Click(object sender, System.EventArgs e)
        {
            RankingsHeaderPage headerPage = new RankingsHeaderPage();
            ShowControl.showControl(headerPage, MainPanel);
            headerPage.Show();
        } /* Бутон за връщане към RankingsHeader Page */
        private void SectionClick(object sender, System.EventArgs e) /* Евент при натискане на съответния бутон за съответния Exam */
        {
            GradientButton senderObject = (GradientButton)sender;
            if (senderObject == SelectDataButton1)
            {
                ButtonColorsChange("SelectDataButton1");
                query = classCheck
                    ? "SELECT username as 'Потребител', mark as 'Оценка', exam as 'Тест', date as 'Дата' FROM results WHERE exam = 'Електричен ток'"
                    : "SELECT username as 'Потребител', mark as 'Оценка', exam as 'Тест', date as 'Дата' FROM results WHERE exam = 'Електромагнитни явления'";
                LoadDataForSection();
            }
            else if (senderObject == SelectDataButton2)
            {
                ButtonColorsChange("SelectDataButton2");
                query = classCheck
                    ? "SELECT username as 'Потребител', mark as 'Оценка', exam as 'Тест', date as 'Дата' FROM results WHERE exam = 'Механично движение'"
                    : "SELECT username as 'Потребител', mark as 'Оценка', exam as 'Тест', date as 'Дата' FROM results WHERE exam = 'Светлина'";
                LoadDataForSection();
            }
            else if (senderObject == SelectDataButton3)
            {
                ButtonColorsChange("SelectDataButton3");
                query = "SELECT username as 'Потребител', mark as 'Оценка', exam as 'Тест', date as 'Дата' FROM results WHERE exam = 'От атома до Космоса'";
                LoadDataForSection();
            }
        }
        private string ButtonColorsChange(string button)
        {
            if (button == "SelectDataButton1")
            {
                SelectDataButton1.FillColor = ColorTranslator.FromHtml("#009FFF");
                SelectDataButton1.FillColor2 = ColorTranslator.FromHtml("#009FFF");

                SelectDataButton2.FillColor = Color.Transparent;
                SelectDataButton2.FillColor2 = Color.Transparent;
                SelectDataButton3.FillColor = Color.Transparent;
                SelectDataButton3.FillColor2 = Color.Transparent;
            }
            else if (button == "SelectDataButton2")
            {
                SelectDataButton2.FillColor = ColorTranslator.FromHtml("#009FFF");
                SelectDataButton2.FillColor2 = ColorTranslator.FromHtml("#009FFF");

                SelectDataButton1.FillColor = Color.Transparent;
                SelectDataButton1.FillColor2 = Color.Transparent;
                SelectDataButton3.FillColor = Color.Transparent;
                SelectDataButton3.FillColor2 = Color.Transparent;
            }
            else if (button == "SelectDataButton3")
            {
                SelectDataButton3.FillColor = ColorTranslator.FromHtml("#009FFF");
                SelectDataButton3.FillColor2 = ColorTranslator.FromHtml("#009FFF");

                SelectDataButton1.FillColor = Color.Transparent;
                SelectDataButton1.FillColor2 = Color.Transparent;
                SelectDataButton2.FillColor = Color.Transparent;
                SelectDataButton2.FillColor2 = Color.Transparent;
            }
            return button;
        } /* Функция за промяната на цвета на самият бутон */
    }
}
