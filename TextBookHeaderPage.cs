using System;
using System.Windows.Forms;

namespace Self_Learn
{
    public partial class TextBookHeaderPage : UserControl
    {
        /* Променливи */

        public static bool classCheck;

        /* Променливи */
        public TextBookHeaderPage() /* Начало на програмата */
        {
            InitializeComponent();
            Program.Connection();
            SelectClassBox.Items.Add("8 и 9 клас");
            SelectClassBox.Items.Add("10 клас");
        }
        private void SelectClassButton_Click(object sender, EventArgs e)
        {
            if (SelectClassBox.Text == "")
            {
                MessageBox.Show("Не сте избрали клас, опитайте отново.", "SelfLearn");
            }
            else
            {
                if (SelectClassBox.Text == "8 и 9 клас")
                {
                    classCheck = true;
                }
                else
                {
                    classCheck = false;
                }
                TextBookPage textBook = new TextBookPage();
                ShowControl.showControl(textBook, MainPanel);
                textBook.Show();
            }
        } /* Бутон за избиране на клас */
    }
}
