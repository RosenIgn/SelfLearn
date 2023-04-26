using System;
using System.Windows.Forms;

namespace Self_Learn
{
    public partial class RankingsHeaderPage : UserControl
    {
        /* Променливи */

        public static bool classCheck = false;

        /* Променливи */
        public RankingsHeaderPage() /* Начало на програмата */
        {
            InitializeComponent();
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
                Rankings rankingsPage = new Rankings();
                ShowControl.showControl(rankingsPage, MainPanel);
                rankingsPage.Show();
            }
        } /* Бутон за избиране на клас */
    }
}