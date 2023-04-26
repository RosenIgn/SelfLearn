using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Self_Learn
{
    public partial class Exams : UserControl
    {
        /* Променливи */

        public static string examGrade = "";

        /* Променливи */
        public Exams()
        {
            InitializeComponent();
            Program.Connection();
            TransparentBackgrounds();
        } /* Начало на програмата */
        private void SelectClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GradeLabel1.Visible = true;
            GradeLabel2.Visible = true;
            GradeLabel3.Visible = true;
            if (ClassBox.Text == "8 и 9 клас")
            {
                VisualChange("8 и 9 клас");
            }
            else if (ClassBox.Text == "10 клас")
            {
                VisualChange("10 клас");
            }
        } /* Event при избиране на клас от ComboBox-a */
        private void TransparentBackgrounds()
        {
            Point pos1 = PointToScreen(StartExamButton1.Location);
            pos1 = PictureBox1.PointToClient(pos1);
            StartExamButton1.Parent = PictureBox1;
            StartExamButton1.Location = pos1;

            Point pos2 = PointToScreen(StartExamButton3.Location);
            pos2 = PictureBox3.PointToClient(pos2);
            StartExamButton3.Parent = PictureBox3;
            StartExamButton3.Location = pos2;

            Point pos3 = PointToScreen(StartExamButton2.Location);
            pos3 = PictureBox2.PointToClient(pos3);
            StartExamButton2.Parent = PictureBox2;
            StartExamButton2.Location = pos3;

            Label[] labels = { label2, label3, HeaderTitle1 };
            Label[] labels2 = { HeaderTitle3, label12, label13};
            Label[] labels3 = { GradeLabel2, label8, label9, HeaderTitle2 };
            for (int i = 0; i < labels.Length; i++)
            {
                Point position = PointToScreen(labels[i].Location);
                position = PictureBox1.PointToClient(position);
                labels[i].Parent = PictureBox1;
                labels[i].Location = position;
            }
            for (int i = 0; i < labels2.Length; i++)
            {
                Point position = PointToScreen(labels2[i].Location);
                position = PictureBox3.PointToClient(position);
                labels2[i].Parent = PictureBox3;
                labels2[i].Location = position;
            }
            for (int i = 0; i < labels3.Length; i++)
            {
                Point position = PointToScreen(labels3[i].Location);
                position = PictureBox2.PointToClient(position);
                labels3[i].Parent = PictureBox2;
                labels3[i].Location = position;
            }
        } /* Функция за Background-a на съответните обекти да бъде прозрачен */
        private void VisualChange(string grade)
        {
            switch (grade)
            {
                case "8 и 9 клас":
                    GradeLabel2.Visible = false;
                    PictureBox2.Visible = false;
                    StartExamButton2.Visible = false;
                    HeaderTitle2.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label12.Text = "#2";
                    GradeLabel1.Text = "8 и 9 КЛАС";
                    GradeLabel3.Text = "8 и 9 КЛАС";
                    PictureBox1.Location = new Point(269, 140);
                    PictureBox3.Location = new Point(552, 140);
                    GradeLabel1.Location = new Point(415, 531);
                    GradeLabel3.Location = new Point(690, 531);
                    TransparentGradeLabels("8 и 9 клас");
                    HeaderTitle1.Text = "Електричен ток";
                    HeaderTitle3.Text = "Механично движение";
                    examGrade = grade;
                    break;
                case "10 клас":
                    PictureBox1.Location = new Point(441, 134);
                    PictureBox3.Location = new Point(714, 158);
                    GradeLabel1.Location = new Point(587, 525);
                    GradeLabel3.Location = new Point(852, 549);
                    TransparentGradeLabels("10 клас");
                    GradeLabel2.Visible = true;
                    PictureBox2.Visible = true;
                    StartExamButton2.Visible = true;
                    HeaderTitle2.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label12.Text = "#3";
                    GradeLabel2.Text = "10 КЛАС";
                    GradeLabel1.Text = "10 КЛАС";
                    GradeLabel3.Text = "10 КЛАС";
                    HeaderTitle1.Text = "Електромагнитни явления";
                    HeaderTitle2.Text = "Светлина";
                    HeaderTitle3.Text = "От атома до Космоса";
                    examGrade = grade;
                    break;
            }
        } /* Функция за скриване и показване на съотвените обекти на самия дизайн на UserControl-a */
        private void TransparentGradeLabels(string grade)
        {
            switch(grade)
            {
                case "8 и 9 клас":
                    Point pos1 = PointToScreen(GradeLabel1.Location);
                    pos1 = PictureBox1.PointToClient(pos1);
                    GradeLabel1.Parent = PictureBox1;
                    GradeLabel1.Location = pos1;

                    Point pos2 = PointToScreen(GradeLabel3.Location);
                    pos2 = PictureBox3.PointToClient(pos2);
                    GradeLabel3.Parent = PictureBox3;
                    GradeLabel3.Location = pos2;
                    break;
                case "10 клас":
                    Point pos3 = PointToScreen(GradeLabel1.Location);
                    pos3 = PictureBox1.PointToClient(pos3);
                    GradeLabel1.Parent = PictureBox1;
                    GradeLabel1.Location = pos3;

                    Point pos4 = PointToScreen(GradeLabel3.Location);
                    pos4 = PictureBox3.PointToClient(pos4);
                    GradeLabel3.Parent = PictureBox3;
                    GradeLabel3.Location = pos4;
                    break;
            }
        } /* Функция за скриване и показване на съотвените обекти на самия дизайн на UserControl-a */
        private void StartExamButton1_Click(object sender, EventArgs e)
        {
            if (ClassBox.Text == "")
            {
                MessageBox.Show("Моля изберете вашият клас, за да започнете теста.", "SelfLearn");
            }
            else
            {
                if (ClassBox.Text == "8 и 9 клас")
                {
                    Program.Globals.exam = "Електричен ток";
                }
                else if (ClassBox.Text == "10 клас")
                {
                    Program.Globals.exam = "Електромагнитни явления";
                }
                StartExam();
            }
        } /* Бутон за започване на Exam 1 за съответния клас */
        private void StartExamButton2_Click(object sender, EventArgs e)
        {
            if (ClassBox.Text == "")
            {
                MessageBox.Show("Моля изберете вашият клас, за да започнете теста.", "SelfLearn");
            }
            else
            {
                if (ClassBox.Text == "10 клас")
                {
                    Program.Globals.exam = "Светлина";
                }
                StartExam();
            }

        } /* Бутон за започване на Exam 2 за съответния клас */
        private void StartExamButton3_Click(object sender, EventArgs e)
        {
            if (ClassBox.Text == "")
            {
                MessageBox.Show("Моля изберете вашият клас, за да започнете теста.", "SelfLearn");
            }
            else
            {
                if (ClassBox.Text == "8 и 9 клас")
                {
                    Program.Globals.exam = "Механично движение";
                }
                else if (ClassBox.Text == "10 клас")
                {
                    Program.Globals.exam = "От атома до Космоса";
                }
                StartExam();
            }
        } /* Бутон за започване на Exam 3 за съответния клас */
        private void StartExam() /* Функция за започване на Exam за съответния клас */
        {
            Quiz qu = new Quiz();
            ShowControl.showControl(qu, panel1);
            qu.Show();
            Program.Globals.isStartedExam = true;
        }
    }
}
