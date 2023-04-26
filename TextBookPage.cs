using System;
using System.Drawing;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Self_Learn
{
    public partial class TextBookPage : UserControl
    {
        /* Променливи */

        private int lessonNumber = 1;
        private string currentSection = "";

        /* Променливи */
        public TextBookPage() /* Начало на програмата */
        {
            InitializeComponent();
            Program.Connection();
            CheckClass();
        }
        private void FormulaButton_Click(object sender, EventArgs e) /* Бутон за изпълняването на формулата за дадения урок */
        {
            LabelResult.Font = new Font("Calibri", (float)20.25, FontStyle.Bold);

            string headerTitle = HeaderTitle.Text;
            string typeOfTheFormula;

            string firstBox = Q1Box.Text, secondBox = Q2Box.Text, thirdBox = RBox.Text;

            if (Q1Box.Visible && Q2Box.Visible && RBox.Visible)
            {
                if ((!int.TryParse(firstBox, out int _) && !int.TryParse(secondBox, out int _) && !int.TryParse(thirdBox, out int _)) || !int.TryParse(firstBox, out int _) || !int.TryParse(secondBox, out int _) || !int.TryParse(thirdBox, out int _))
                {
                    MessageBox.Show("Моля проверете дали едно от полетата по-горе е празно или дали сте въвели само числа, а не букви.", "SelfLearn");
                }
                else
                {
                    if (headerTitle == "Закон на Кулон")
                    {
                        typeOfTheFormula = "Закон на Кулон";
                        FormulaFunction(typeOfTheFormula);
                    }
                    else if (headerTitle == "Източници на напрежение")
                    {
                        typeOfTheFormula = "Закон на Ом за цялата верига";
                        FormulaFunction(typeOfTheFormula);
                    }
                    else if (headerTitle == "Звук")
                    {
                        typeOfTheFormula = "Звук";
                        FormulaFunction(typeOfTheFormula);
                    }
                }
            }
            else if (!Q2Box.Visible && !RBox.Visible)
            {
                if (!int.TryParse(firstBox, out int _))
                {
                    MessageBox.Show("Моля проверете дали едно от полетата по-горе е празно или дали сте въвели само числа, а не букви.", "SelfLearn");
                }
                else
                {
                    if (headerTitle == "Хармонично трептене")
                    {
                        typeOfTheFormula = "Връзка между период и честота";
                        FormulaFunction(typeOfTheFormula);
                    }
                }
            }
            else if (!RBox.Visible)
            {
                if ((!int.TryParse(firstBox, out int _) && !int.TryParse(secondBox, out int _)) || !int.TryParse(firstBox, out int _) || !int.TryParse(secondBox, out int _))
                {
                    MessageBox.Show("Моля проверете дали едно от полетата по-горе е празно или дали сте въвели само числа, а не букви.", "SelfLearn");
                }
                else
                {
                    if (headerTitle == "Кондензатори")
                    {
                        typeOfTheFormula = "Кондензатори";
                        FormulaFunction(typeOfTheFormula);
                    }
                    else if (headerTitle == "Свързване на консуматори")
                    {
                        typeOfTheFormula = "Закон на Ом";
                        FormulaFunction(typeOfTheFormula);
                    }
                    else if (headerTitle == "Прости трептящи системи")
                    {
                        typeOfTheFormula = "Прости трептящи системи";
                        FormulaFunction(typeOfTheFormula);
                    }
                }
            }

            while (LabelResult.Width > 300)
            {
                LabelResult.Font = new Font(LabelResult.Font.FontFamily, LabelResult.Font.Size - 0.5f, LabelResult.Font.Style);
            }
        }
        private void SectionFromTheBook1_Click(object sender, EventArgs e) /* Бутон за избиране на раздел 1 за съответния клас */
        {
            lessonNumber = 1;
            switch (SectionFromTheBook1.Text)
            {
                case "Част 1. Електромагнитни явления":
                    SwitchLessons(SectionFromTheBook1.Text, "Закон на Кулон");
                    currentSection = SectionFromTheBook1.Text;
                    break;
                case "Част 1. Електричен ток":
                    //TO DO
                    SwitchLessons(SectionFromTheBook1.Text, "Свързване на консуматори");
                    currentSection = SectionFromTheBook1.Text;
                    break;
            }
        }
        private void SectionFromTheBook2_Click(object sender, EventArgs e) /* Бутон за избиране на раздел 2 за съответния клас */
        {
            lessonNumber = 1;
            switch (SectionFromTheBook2.Text)
            {
                case "Част 2. Светлина":
                    SwitchLessons(SectionFromTheBook2.Text, "Отражение и пречупване на светлината");
                    currentSection = SectionFromTheBook2.Text;
                    break;
                case "Част 2. Механично движение":
                    SwitchLessons(SectionFromTheBook2.Text, "Хармонично трептене");
                    currentSection = SectionFromTheBook2.Text;
                    break;
            }
        }
        private void SectionFromTheBook3_Click(object sender, EventArgs e) /* Бутон за избиране на раздел 3 за съответния клас */
        {
            lessonNumber = 1;
            SwitchLessons(SectionFromTheBook3.Text, "Атоми");
            currentSection = SectionFromTheBook3.Text;
        }
        private void NextLessonButton_Click(object sender, EventArgs e) /* Бутон за преминаване към следващ урок за съответния раздел */
        {
            lessonNumber++;
            NextPreviousLesson();
        }
        private void PreviousLessonButton_Click(object sender, EventArgs e)
        {
            lessonNumber--;
            NextPreviousLesson();
        } /* Бутон за връщане към предишен урок за съответния раздел */
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            TextBookHeaderPage headerPage = new TextBookHeaderPage();
            ShowControl.showControl(headerPage, MainPanel);
            headerPage.Show();
        } /* Бутон за връщане към TextBookHeaderPage UserControl */
        private void SwitchLessons(string section, string lesson) /* Функция за промяната на всеки Label, PictureBox, Button и т.н за съответния урок */
        {
            Q1Box.Text = "";
            Q2Box.Text = "";
            RBox.Text = "";
            switch (section)
            {
                case "Част 1. Електромагнитни явления":
                    switch (lesson)
                    {
                        case "Закон на Кулон":
                            ChangePositions("Кулон");
                            break;
                        case "Кондензатори":
                            ChangePositions("Кондензатори");
                            break;
                        case "Трансформатори. Пренасяне на електроенергия":
                            ChangePositions("Трансформатори");
                            break;
                    }
                    break;
                case "Част 2. Светлина":
                    switch (lesson)
                    {
                        case "Отражение и пречупване на светлината":
                            ChangePositions("Отражение и пречупване на светлината");
                            break;
                        case "Дисперсия на светлината":
                            ChangePositions("Дисперсия");
                            break;
                        case "Интерференция":
                            ChangePositions("Интерференция");
                            break;
                    }
                    break;
                case "Част 3. От атома до Космоса":
                    switch (lesson)
                    {
                        case "Атоми":
                            ChangePositions("Атоми");
                            break;
                        case "Лазери":
                            ChangePositions("Лазери");
                            break;
                        case "Звезди":
                            ChangePositions("Звезди");
                            break;
                    }
                    break;
                case "Част 1. Електричен ток":
                    switch (lesson)
                    {
                        case "Свързване на консуматори":
                            ChangePositions("Свързване на консуматори");
                            break;
                        case "Източници на напрежение":
                            ChangePositions("Източници на напрежение");
                            break;
                        case "Полупроводникови устройства":
                            ChangePositions("Полупроводникови устройства");
                            break;
                    }
                    break;
                case "Част 2. Механично движение":
                    switch (lesson)
                    {
                        case "Хармонично трептене":
                            ChangePositions("Хармонично трептене");
                            break;
                        case "Прости трептящи системи":
                            ChangePositions("Прости трептящи системи");
                            break;
                        case "Звук":
                            ChangePositions("Звук");
                            break;
                    }
                    break;
            }
        }
        private void NextPreviousLesson() /* Функция за премиване/връщане към следващ/предишен урок */
        {
            Q1Box.Text = "";
            Q2Box.Text = "";
            RBox.Text = "";
            switch (currentSection)
            {
                case "Част 1. Електромагнитни явления":
                    if (lessonNumber <= 1)
                    {
                        lessonNumber = 1;
                        SwitchLessons("Част 1. Електромагнитни явления", "Закон на Кулон");
                    }
                    if (lessonNumber == 2)
                    {
                        SwitchLessons("Част 1. Електромагнитни явления", "Кондензатори");
                    }
                    else if (lessonNumber >= 3)
                    {
                        lessonNumber = 3;
                        SwitchLessons("Част 1. Електромагнитни явления", "Трансформатори. Пренасяне на електроенергия");
                    }
                    break;
                case "Част 2. Светлина":
                    if (lessonNumber <= 1)
                    {
                        lessonNumber = 1;
                        SwitchLessons("Част 2. Светлина", "Отражение и пречупване на светлината");
                    }
                    if (lessonNumber == 2)
                    {
                        SwitchLessons("Част 2. Светлина", "Дисперсия на светлината");
                    }
                    else if (lessonNumber >= 3)
                    {
                        lessonNumber = 3;
                        SwitchLessons("Част 2. Светлина", "Интерференция");
                    }
                    break;
                case "Част 3. От атома до Космоса":
                    if (lessonNumber <= 1)
                    {
                        lessonNumber = 1;
                        SwitchLessons("Част 3. От атома до Космоса", "Атоми");
                    }
                    if (lessonNumber == 2)
                    {
                        SwitchLessons("Част 3. От атома до Космоса", "Лазери");
                    }
                    else if (lessonNumber >= 3)
                    {
                        lessonNumber = 3;
                        SwitchLessons("Част 3. От атома до Космоса", "Звезди");
                    }
                    break;
                case "Част 1. Електричен ток":
                    if (lessonNumber <= 1)
                    {
                        lessonNumber = 1;
                        SwitchLessons("Част 1. Електричен ток", "Свързване на консуматори");
                    }
                    if (lessonNumber == 2)
                    {
                        SwitchLessons("Част 1. Електричен ток", "Източници на напрежение");
                    }
                    else if (lessonNumber >= 3)
                    {
                        lessonNumber = 3;
                        SwitchLessons("Част 1. Електричен ток", "Полупроводникови устройства");
                    }
                    break;
                case "Част 2. Механично движение":
                    if (lessonNumber <= 1)
                    {
                        lessonNumber = 1;
                        SwitchLessons("Част 2. Механично движение", "Хармонично трептене");
                    }
                    if (lessonNumber == 2)
                    {
                        SwitchLessons("Част 2. Механично движение", "Прости трептящи системи");
                    }
                    else if (lessonNumber >= 3)
                    {
                        lessonNumber = 3;
                        SwitchLessons("Част 2. Механично движение", "Звук");
                    }
                    break;
            }
        }
        private void FormulaFunction(string type) /* Функция за изчисленията на формулите */
        {
            string result = "";
            double formula, firstN, secondN, thirdN;
            switch (type)
            {
                // Закон на Кулон
                case "Закон на Кулон": // Формулата работи напълно
                    double k = (double)(9 * Math.Pow(10, 9));
                    firstN = double.Parse(Q1Box.Text);
                    secondN = double.Parse(Q2Box.Text);
                    thirdN = double.Parse(RBox.Text);
                    double kulonFormula = (k * firstN * secondN / thirdN * thirdN);
                    result = $"Отговора е: {kulonFormula:f2} N";
                    break;
                case "Кондензатори": // Формулата работи напълно
                    firstN = double.Parse(Q1Box.Text);
                    secondN = double.Parse(Q2Box.Text);
                    formula = firstN / secondN;
                    result = $"Отговора е: {formula:f2} F";
                    break;
                case "Закон на Ом": // Формулата работи напълно
                    firstN = double.Parse(Q1Box.Text);
                    secondN = double.Parse(Q2Box.Text);
                    switch (SelectFormulaBox.Text)
                    {
                        case "ток [I]":
                            formula = firstN / secondN;
                            result = $"Отговора е: I = {formula:f2} A";
                            break;
                        case "напрежение [U]":
                            formula = firstN * secondN;
                            result = $"Отговора е: U = {formula:f2} V";
                            break;
                        case "съпротивление [R]":
                            formula = firstN / secondN;
                            result = $"Отговора е: R = {formula:f2} Ω";
                            break;
                        default:
                            break;
                    }
                    break;
                case "Закон на Ом за цялата верига": // Формулата работи напълно    
                    firstN = double.Parse(Q1Box.Text);
                    secondN = double.Parse(Q2Box.Text);
                    thirdN = double.Parse(RBox.Text);
                    formula = firstN / (secondN + thirdN);
                    result = $"Отговора е: I = {formula:f2} A";
                    break;
                case "Връзка между период и честота": // Формулата работи напълно
                    firstN = double.Parse(Q1Box.Text);
                    formula = 1 / firstN;
                    switch (SelectFormulaBox.Text)
                    {
                        case "честота [v]":
                            result = $"Отговора е: T = {formula:f2} s";
                            break;
                        case "период [T]":
                            result = $"Отговора е: v = {formula:f2} Hz";
                            break;
                    }
                    break;
                case "Прости трептящи системи": // Формулата работи напълно
                    firstN = double.Parse(Q1Box.Text);
                    secondN = double.Parse(Q2Box.Text);
                    formula = (2 * Math.PI) * Math.Sqrt(firstN / secondN);
                    result = $"Отговора е: T = {formula:f2} s";
                    break;
                case "Звук": // Формулата работи напълно
                    firstN = double.Parse(Q1Box.Text);
                    secondN = double.Parse(Q2Box.Text);
                    thirdN = double.Parse(RBox.Text);
                    formula = firstN * secondN * thirdN;
                    result = $"Отговора е: E = {formula:f2} J";
                    break;
            }
            LabelResult.Show();
            LabelResult.Text = result;
        }
        private void CheckClass() /* Функция за проверка на класа */
        {
            bool classCheck = TextBookHeaderPage.classCheck;
            if (classCheck)
            {
                SectionFromTheBook1.Text = "Част 1. Електричен ток";
                SectionFromTheBook2.Text = "Част 2. Механично движение";
                SectionFromTheBook1.Location = new Point(432, 75);
                SectionFromTheBook2.Location = new Point(649, 75);
                SectionFromTheBook3.Visible = false;
                currentSection = "Част 1. Електричен ток";
                SwitchLessons(SectionFromTheBook1.Text, "Свързване на консуматори");
            }
            else
            {
                SectionFromTheBook3.Visible = true;
                SectionFromTheBook1.Text = "Част 1. Електромагнитни явления";
                SectionFromTheBook2.Text = "Част 2. Светлина";
                SectionFromTheBook3.Text = "Част 3. От атома до Космоса";
                SectionFromTheBook1.Location = new Point(278, 75);
                SectionFromTheBook2.Location = new Point(499, 75);
                SectionFromTheBook3.Location = new Point(721, 75);
                currentSection = "Част 1. Електромагнитни явления";
                SwitchLessons(SectionFromTheBook1.Text, "Закон на Кулон");
            }
        }
        private void SelectFormulaBox_SelectedIndexChanged(object sender, EventArgs e) /* Евент при промяна на даден индекс в ComboBox-a*/
        {
            Q1Box.Text = "";
            Q2Box.Text = "";
            RBox.Text = "";
            switch (SelectFormulaBox.Text)
            {
                case "ток [I]":
                    Q1Box.PlaceholderText = "Въведи напрежение [U]";
                    Q2Box.PlaceholderText = "Въведи съпротивление [R]";
                    break;
                case "напрежение [U]":
                    Q1Box.PlaceholderText = "Въведи ток [I]";
                    Q2Box.PlaceholderText = "Въведи съпротивление [R]";
                    break;
                case "съпротивление [R]":
                    Q1Box.PlaceholderText = "Въведи напрежение [U]";
                    Q2Box.PlaceholderText = "Въведи ток [I]";
                    break;
                case "честота [v]":
                    Q1Box.PlaceholderText = "Въведи честота [v]";
                    break;
                case "период [T]":
                    Q1Box.PlaceholderText = "Въведи период [T]";
                    break;
                case "математично":
                    Q1Box.PlaceholderText = "Въведи дължина [l]";
                    Q2Box.PlaceholderText = "Въведи земно ускорение [g]";
                    break;
                case "пружинно":
                    Q1Box.PlaceholderText = "Въведи маса [m]";
                    Q2Box.PlaceholderText = "Въведи коефицент [k]";
                    break;
                default:
                    Q1Box.PlaceholderText = "Въведи напрежение [U]";
                    Q2Box.PlaceholderText = "Въведи съпротивление [R]";
                    break;
            }
        }
        private void ChangePositions(string lesson) /* Функция за промяната на всеки Label, PictureBox, Button и т.н за съответния урок */
        {
            switch (lesson)
            {
                case "Кулон":

                    // Hide objects

                    LabelResult.Hide();
                    Paragraph3.Hide();
                    PictureBox5.Hide();
                    PictureBox4.Visible = false;
                    HeaderParagraph4.Hide();

                    // Show objects

                    Q1Box.Show();
                    Q2Box.Show();
                    FormulaButton.Show();
                    PictureBox3.Show();
                    RBox.Visible = true;

                    // Size of the objects

                    PictureBox1.Size = new Size(158, 192);
                    PictureBox2.Size = new Size(159, 192);
                    PictureBox3.Size = new Size(327, 224);

                    // Locations of the objects

                    Q1Box.Location = new Point(606, 244);
                    Q2Box.Location = new Point(606, 310);
                    PictureBox1.Location = new Point(419, 201);
                    PictureBox3.Location = new Point(847, 222);
                    FormulaButton.Location = new Point(606, 441);
                    HeaderParagraph3.Location = new Point(565, 201);
                    HeaderParagraph3.BringToFront();
                    HeaderTitle.Location = new Point(489, 149);
                    LabelResult.Location = new Point(869, 452);

                    // Texts of the labels

                    Q1Box.PlaceholderText = "Въведете големината на заряда [q1]";
                    Q2Box.PlaceholderText = "Въведете големината на заряда [q2]";
                    RBox.PlaceholderText = "Въведете радиуса [r]";
                    HeaderTitle.Text = "Закон на Кулон";
                    HeaderParagraph1.Text = "Устройство на Кулоновата везна";
                    HeaderParagraph2.Text = "Закон на Кулон";
                    HeaderParagraph3.Text = "Закон за електростатично взаимодействие";
                    Paragraph1.Text = "Везната на Кулон работи чрез електрически заряд и преобразува получената сила във въртящ момент, което позволява лесно и точно измерване. Торсионното равновесие на Кулон работи, като зарежда две метални топки, една от които е фиксирана, а другата е прикрепена към края на игла, а иглата е прикрепена към нишка, като тя е прикрепена към торсионния микрометър.";
                    Paragraph2.Text = "Законът на Кулон е закон от електростатиката. Той определя силата на взаимодействие между два точкови заряда. Според закона на Кулон силата на взаимодействие между два точкови заряда е обратнопропорционална на квадрата на разстоянието между тях и правопропорционална на произведението от големината на техните заряди.";
                    // Background Images

                    PictureBox1.BackgroundImage = Properties.Resources.CoulombImage1;
                    PictureBox2.BackgroundImage = Properties.Resources.Kulon;
                    PictureBox3.BackgroundImage = Properties.Resources.CoulombImage2;
                    break;
                case "Кондензатори":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox3.Hide();
                    Paragraph3.Hide();
                    PictureBox5.Hide();
                    RBox.Visible = false;
                    HeaderParagraph4.Hide();

                    // Show objects

                    Q1Box.Show();
                    Q2Box.Show();
                    FormulaButton.Show();
                    PictureBox1.SendToBack();

                    // The locations of the objects

                    Q1Box.Location = new Point(810, 244);
                    Q2Box.Location = new Point(810, 310);
                    FormulaButton.Location = new Point(810, 377);
                    HeaderParagraph3.Location = new Point(810, 201);
                    HeaderTitle.Location = new Point(489, 149);
                    PictureBox4.Location = new Point(580, 452);
                    PictureBox1.Location = new Point(395, 201);

                    // The size of the objects

                    PictureBox1.Size = new Size(444, 224);
                    PictureBox2.Size = new Size(159, 192);

                    // The texts of the labels

                    Q1Box.PlaceholderText = "Въведете заряда [q]";
                    Q2Box.PlaceholderText = "Въведете напрежение [U]";
                    HeaderTitle.Text = "Кондензатори";
                    HeaderParagraph1.Text = "Капацитет на кондензатор";
                    HeaderParagraph2.Text = "Видове кондензатори";
                    HeaderParagraph3.Text = "Капацитет на кондензатор";
                    Paragraph1.Text = "Кондензаторът е съставен от два изолирани един от друг проводника, наречени електроди, като се зареждат с равни по големина и противоположни по знак електрични заряди q и -q. Отношението на заряда q на кондензатора и напрежението U между двата му електрода се нарича капацитет C на кондензатора.";
                    Paragraph2.Text = "За електротехниката и електрониката се произвеждат кондензатори с различни размери и капацитет. Електролитните кондензатори се състоят от метално фолио, потопено в електролит. Върху фолиото е нанесен слой от метален оксид, който е диелектрик. Капацитетът е голям, защото диелектричният слой, разделящ двата електрода, е много тънък.";

                    // Background Images

                    PictureBox1.BackgroundImage = Properties.Resources.Kondenzatori; //Kondenzatori
                    PictureBox2.BackgroundImage = Properties.Resources.elektroliten_kondenzator; //Elektroliten kondenzator
                    PictureBox4.BackgroundImage = Properties.Resources.KapacitetFormula; //KapacitetFormula
                    PictureBox4.Visible = true;
                    break;
                case "Трансформатори":
                    // Hide objects

                    LabelResult.Hide();
                    Q1Box.Hide();
                    Q2Box.Hide();
                    RBox.Visible = false;
                    FormulaButton.Hide();
                    Paragraph3.Hide();
                    HeaderParagraph4.Hide();

                    // Show objects

                    PictureBox3.Show();
                    PictureBox4.Show();
                    PictureBox5.Show();

                    // The locations of the objects

                    PictureBox1.Location = new Point(376, 201);
                    PictureBox3.Location = new Point(850, 235);
                    PictureBox4.Location = new Point(850, 335);
                    PictureBox5.Location = new Point(850, 445);
                    HeaderTitle.Location = new Point(215, 149);
                    HeaderParagraph3.Location = new Point(910, 201);

                    // The size of the objects

                    PictureBox1.Size = new Size(414, 269);
                    PictureBox2.Size = new Size(341, 209);
                    PictureBox3.Size = new Size(215, 107);
                    PictureBox4.Size = new Size(215, 107);
                    PictureBox5.Size = new Size(215, 95);

                    // The texts of the labels

                    HeaderTitle.Text = "Трансформатори. Пренасяне на електроенергия";
                    HeaderParagraph1.Text = "Трансформатори";
                    HeaderParagraph2.Text = "Закон на Фарадей";
                    HeaderParagraph3.Text = "Формули";
                    Paragraph1.Text = "Устройството, с което се увеличават или намаляват амплитудата и ефективната стойност на променливо напрежение, без да се изменя неговата честота, се нарича трансформатор. Той се състои от затворена феромагнитна сърцевина, на която се надянати две намотки с различен брой навитки.";
                    Paragraph2.Text = "В намотка се индуцира ток, ако броят на индукционните линии на магнитното поле, обхванати от намотката, се изменя с течение на времето. Индуцираният ток и индуцираното електродвижещо напрежение са правопропорционални на бързината, с която става това изменение.";

                    // Background Images

                    PictureBox1.BackgroundImage = Properties.Resources.Трансформатори;
                    PictureBox2.BackgroundImage = Properties.Resources.ZakonNaFaradei;
                    PictureBox3.BackgroundImage = Properties.Resources.Prenasqne_Na_Moshtnost;
                    PictureBox4.BackgroundImage = Properties.Resources.Vruzka_mejdu_tokovete;
                    PictureBox5.BackgroundImage = Properties.Resources.Formula_na_Transformatora;
                    break;
                case "Отражение и пречупване на светлината":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox5.Hide();
                    PictureBox4.Hide();
                    Q1Box.Hide();
                    Q2Box.Hide();
                    FormulaButton.Hide();
                    RBox.Visible = false;
                    HeaderParagraph4.Hide();

                    // Show objects

                    PictureBox3.Show();
                    Paragraph3.Show();
                    Paragraph3.SendToBack();

                    // The size of the objects

                    PictureBox1.Size = new Size(200, 200);
                    PictureBox2.Size = new Size(350, 210);
                    PictureBox3.Size = new Size(299, 128);
                    Paragraph3.Size = new Size(379, 194);

                    // The locations of the objects

                    PictureBox1.Location = new Point(420, 201);
                    PictureBox2.Location = new Point(420, 423);
                    PictureBox3.Location = new Point(810, 425);
                    HeaderParagraph3.Location = new Point(729, 201);
                    HeaderTitle.Location = new Point(215, 149);
                    Paragraph3.Location = new Point(716, 244);

                    // The texts of the labels

                    HeaderTitle.Text = "Отражение и пречупване на светлината";
                    HeaderParagraph1.Text = "Отражение на светлината";
                    HeaderParagraph2.Text = "Пречупване на светлината";
                    HeaderParagraph3.Text = "Пълно вътрешно отражение";
                    Paragraph1.Text = "Отражението на светлината е явление, при което на границата на две среди тя се връща обратно в първата, от където идва. Явлението се нарича огледално отражение, ако повърхността е гладка. Типичен пример за огледално отражение е отражението от огледало. Когато отражателната повърхност не е равна, светлинните лъчи се разпръскват в различни посоки, като това явление е известно като дифузно отражение.";
                    Paragraph2.Text = " Светлината се пречупва при преминаване на границата на две среди с различна оптична плътност. Тя навлиза във втората среда и променя посоката си на разпространение. Ъгълът на падане α (алфа) е по-голям или по-малък от ъгъла на пречупване β (бета) в зависимост от това, дали светлината преминава от оптично по-рядка в оптично по-плътна среда или обратно.";
                    Paragraph3.Text = "Явлението, при което светлината се разпространява в среда с показател на пречупване n1 и изцяло се отразява от границата с друга среда с по-малък показател на пречупване, се нарича пълно вътрешно отражение.";

                    // Background Images

                    PictureBox1.BackgroundImage = Properties.Resources.Отражение_на_светлината;
                    PictureBox2.BackgroundImage = Properties.Resources.Пречупване_на_светлината;
                    PictureBox3.BackgroundImage = Properties.Resources.GranichenUgul;

                    break;
                case "Дисперсия":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox5.Hide();
                    PictureBox4.Hide();
                    Q1Box.Hide();
                    Q2Box.Hide();
                    Paragraph3.Hide();
                    FormulaButton.Hide();
                    HeaderParagraph4.Hide();
                    RBox.Visible = false;

                    // Show objects

                    PictureBox3.Show();
                    HeaderParagraph2.BringToFront();
                    PictureBox1.BringToFront();

                    // The size of the objects

                    PictureBox1.Size = new Size(350, 224);
                    PictureBox2.Size = new Size(350, 210);
                    PictureBox3.Size = new Size(216, 330);

                    // The locations of the objects

                    PictureBox1.Location = new Point(400, 201);
                    PictureBox2.Location = new Point(400, 423);
                    PictureBox3.Location = new Point(853, 229);
                    HeaderParagraph3.Location = new Point(800, 190);
                    HeaderTitle.Location = new Point(400, 149);
                    HeaderParagraph2.Location = new Point(32, 400);
                    Paragraph2.Location = new Point(32, 450);

                    // The texts of the labels

                    HeaderTitle.Text = "Дисперсия на светлината";
                    HeaderParagraph1.Text = "Какво е дисперсия?";
                    HeaderParagraph2.Text = "Небесна дъга";
                    HeaderParagraph3.Text = "Разлагането на светлината";
                    Paragraph1.Text = "Зависимостта на показателя на пречупване\n от дължината на вълната n се нарича дисперсия. В по-широк смисъл под дисперсия на светлината се разбира разлагането на светлината, обусловено\n от зависимостта на показателя на пречупване от дължината на светлинните вълни.";
                    Paragraph2.Text = "Дъгата е оптично и метеорологично явление,\n свързано с появата в небето на почти непрекъснат спектър на светлината,\nкогато лъчите на слънцето падат върху миниатюрни капки вода в земната атмосфера.\nТя представлява многоцветна част от окръжност,\nс червения цвят от външната страна и виолетовия цвят от вътрешната.";

                    // Background Images

                    PictureBox1.BackgroundImage = Properties.Resources.Дисперсия_на_светлината;
                    PictureBox2.BackgroundImage = Properties.Resources.Небесна_дъга;
                    PictureBox3.BackgroundImage = Properties.Resources.Разлагане_на_светлината;
                    break;
                case "Интерференция":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox3.Hide();
                    Q1Box.Hide();
                    Q2Box.Hide();
                    Paragraph3.Hide();
                    FormulaButton.Hide();
                    HeaderParagraph4.Hide();
                    RBox.Visible = false;

                    // Show objects

                    PictureBox4.Show();
                    PictureBox5.Show();
                    HeaderParagraph2.BringToFront();
                    PictureBox1.BringToFront();

                    // The size of the objects

                    PictureBox1.Size = new Size(350, 224);
                    PictureBox2.Size = new Size(350, 210);
                    PictureBox4.Size = new Size(215, 120);
                    PictureBox5.Size = new Size(215, 120);

                    // The locations of the objects

                    PictureBox1.Location = new Point(400, 201);
                    PictureBox2.Location = new Point(400, 423);
                    PictureBox4.Location = new Point(850, 250);
                    PictureBox5.Location = new Point(850, 400);
                    HeaderParagraph3.Location = new Point(775, 190);
                    HeaderTitle.Location = new Point(400, 149);
                    HeaderParagraph2.Location = new Point(32, 400);
                    Paragraph2.Location = new Point(32, 450);

                    // The texts of the labels

                    HeaderTitle.Text = "Интерференция";
                    HeaderParagraph1.Text = "Какво е Интерференция?";
                    HeaderParagraph2.Text = "Опита на Юнг";
                    HeaderParagraph3.Text = "Условия за възникване на интерфе-\nренчни максимуми и минимуми";
                    Paragraph1.Text = "Явлението, при което в резултат на наслагането на две или повече вълни се получава увеличение на амплитудата на резултантната вълна в едни области и намаление в други, се нарича интерференция.";
                    Paragraph2.Text = "Опитът на Юнг е представен схематично на снимката отдясно. Сноп от слънчева светлина преминава през цветен филтър, за да се отдели светлина с определена дължина на вълната, която след това осветява тесен процеп S0 в непрозрачен екран. Интерференчната картина се наблюдава върху екрана E, като е съставена от редуващи се светли и тъмни ивици.";

                    // Background Images

                    PictureBox1.BackgroundImage = Properties.Resources.Interferentsia;
                    PictureBox2.BackgroundImage = Properties.Resources.Opit_na_Ung;
                    PictureBox4.BackgroundImage = Properties.Resources.Uslovie_za_maksimum;
                    PictureBox5.BackgroundImage = Properties.Resources.Uslovie_za_minimum;
                    break;
                case "Атоми":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox4.Hide();
                    PictureBox5.Hide();
                    Q1Box.Hide();
                    FormulaButton.Hide();
                    Q2Box.Hide();
                    RBox.Visible = false;

                    // Show objects
                    HeaderParagraph2.BringToFront();
                    PictureBox1.BringToFront();
                    PictureBox3.Show();
                    Paragraph3.Show();

                    // The size of the objects

                    PictureBox1.Size = new Size(137, 224);
                    PictureBox2.Size = new Size(350, 210);
                    PictureBox3.Size = new Size(230, 140);
                    Paragraph3.Size = new Size(401, 151);

                    // The locations of the objects

                    PictureBox1.Location = new Point(410, 201);
                    PictureBox2.Location = new Point(400, 423);
                    PictureBox3.Location = new Point(850, 400);
                    HeaderParagraph2.Location = new Point(32, 400);
                    HeaderTitle.Location = new Point(489, 149);
                    Paragraph2.Location = new Point(32, 450);
                    LabelResult.Location = new Point(560, 370);
                    Paragraph3.Location = new Point(775, 250);
                    HeaderParagraph3.Location = new Point(775, 201);

                    // The texts of the labels

                    HeaderTitle.Text = "Атоми";
                    HeaderParagraph1.Text = "Атом на водорода";
                    HeaderParagraph2.Text = "Спектър на водородния атом";
                    HeaderParagraph3.Text = "Класификация на спектрите";
                    Paragraph1.Text = "Електронът се движи около ядрото по орбити с определен радиус, на които има точно определена енергия. Основното състояние на атома е, че електронът се намира в състояние с най-малка енергия,а възбуденото състояние са състоянията, при които енергията е по-голяма. Енергията на електрона в атома се квантува.";
                    Paragraph2.Text = "Спектърът на излъчване на водорода е линеен, защото излъчва светлина със строго определена дължина на вълната. Водородният атом е най-елементарният и има 1 протон и 1 електрон. Също така, разредените газове могат както да излъчват, така и да поглъщат светлина.";
                    Paragraph3.Text = "Спектъра на излъчване е емисионен спектър. Той се получава в резултат на собственото излъчване на обекта, а спектъра на поглъщане е абсорбционен спектър, който се получава, като светлината от топлинния източник преминава през облак от по-хладен газ. Облакът поглъща част от светлината, а останалата част я пропуска. На спектъра се виждат черни линии на цветен фон, като положението им показва кои дължини на вълната са погълнати.";
                    // Background Images

                    PictureBox1.BackgroundImage = Properties.Resources.OsnovnoSustoqnie;
                    PictureBox2.BackgroundImage = Properties.Resources.Atomi;
                    PictureBox3.BackgroundImage = Properties.Resources.RidbergFormula;
                    break;
                case "Лазери":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox4.Hide();
                    PictureBox5.Hide();
                    Q1Box.Hide();
                    Q2Box.Hide();
                    FormulaButton.Hide();
                    RBox.Visible = false;
                    HeaderParagraph4.Hide();

                    // Show objects
                    HeaderParagraph2.BringToFront();
                    PictureBox1.BringToFront();
                    PictureBox3.Show();
                    Paragraph3.Show();
                    Paragraph3.BringToFront();

                    // The size of the objects

                    PictureBox1.Size = new Size(350, 210);
                    PictureBox2.Size = new Size(350, 210);
                    PictureBox3.Size = new Size(408, 292);
                    Paragraph3.Size = new Size(436, 80);

                    // The locations of the objects

                    PictureBox1.Location = new Point(390, 201);
                    PictureBox2.Location = new Point(400, 423);
                    PictureBox3.Location = new Point(750, 209);
                    HeaderParagraph3.Location = new Point(805, 201);
                    HeaderParagraph2.Location = new Point(32, 400);
                    HeaderTitle.Location = new Point(489, 149);
                    Paragraph2.Location = new Point(32, 450);
                    Paragraph3.Location = new Point(745, 482);

                    // The texts of the labels

                    HeaderTitle.Text = "Лазери";
                    HeaderParagraph1.Text = "Как действа лазерът?";
                    HeaderParagraph2.Text = "Условие за работата на лазерите";
                    HeaderParagraph3.Text = "Устройство на лазера";
                    Paragraph1.Text = "Устройството за възбуждане внася енергия в активната среда и привежда атомите във възбудено състояние. Някои от възбудените атоми извършват спонтанно излъчване, при което се излъчват фотони и след отразяването в огледало тези фотони предизвикват стимулирано излъчване на атоми във възбудено състояние.";
                    Paragraph2.Text = "- активна среда - в средата е създадена инверсна населеност.\n- атомите трябва да са в продължително възбудено състояние, за да може стимулираното излъчване да се извършва преди спонтанното излъчване.\n- трябва да има многократно преминаване на фотоните през активната среда, за да се предизвика стимулирано и излъчване на по-голям брой възбудени атоми.";
                    Paragraph3.Text = "резонатор - 2 успоредни огледала - едното изцяло отразява светлината, а другото е полупрозрачно, защото част от светлината преминава през него и така се формира лазерният сноп.";
                    // Background Images

                    PictureBox1.BackgroundImage = Properties.Resources.Stimulirano_spontanno_poglushtane;
                    PictureBox2.BackgroundImage = Properties.Resources.Principna_shema;
                    PictureBox3.BackgroundImage = Properties.Resources.Lazer;
                    break;
                case "Звезди":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox4.Hide();
                    PictureBox5.Hide();
                    Q1Box.Hide();
                    Q2Box.Hide();
                    FormulaButton.Hide();
                    RBox.Visible = false;
                    HeaderParagraph4.Hide();

                    // Show objects
                    HeaderParagraph2.BringToFront();
                    PictureBox1.BringToFront();
                    PictureBox3.Show();
                    Paragraph3.Show();
                    Paragraph1.BringToFront();
                    Paragraph3.BringToFront();

                    // The size of the objects

                    PictureBox1.Size = new Size(178, 257);
                    PictureBox2.Size = new Size(148, 218);
                    PictureBox3.Size = new Size(335, 195);
                    Paragraph1.Size = new Size(357, 168);
                    Paragraph3.Size = new Size(394, 158);

                    // The locations of the objects

                    PictureBox1.Location = new Point(420, 201);
                    PictureBox2.Location = new Point(420, 415);
                    PictureBox3.Location = new Point(740, 364);
                    HeaderParagraph3.Location = new Point(710, 201);
                    HeaderParagraph2.Location = new Point(32, 420);
                    HeaderTitle.Location = new Point(489, 149);
                    Paragraph2.Location = new Point(32, 480);
                    Paragraph3.Location = new Point(710, 250);

                    // The texts of the labels

                    HeaderTitle.Text = "Звезди";
                    HeaderParagraph1.Text = "Какво са звездите?";
                    HeaderParagraph2.Text = "Реакции на термоядрен синтез";
                    HeaderParagraph3.Text = "Диаграма спектър-светимост";
                    Paragraph1.Text = "Звездите са гигантски горещи кълба от йонизирани газове, подобни на нашето Слънце, които са мощен източник на електромагнитно излъчване. Звездите в нощното небе блещукат поради многобройните отражения и пречупвания на светлината при преминаването ѝ през земната атмосфера. Според астрономите, познатата вселена съдържа поне 70 секстилиона звезди. Най-близката до Земята звезда е Слънцето.";
                    Paragraph2.Text = "Енергията, която се отделя при термоядрения синтез, се пренася от ядрото към повърхността на звездата, а след това се излъчва в космическото пространство. Масовият дефект е разликата между сумата от масите на свободните протони и неутрони и масата на ядрото. Масовият дефект се освобождава под формата на енергия. Също така масата на хелия е по-малка от масата на четирите ядра на водорода.";
                    Paragraph3.Text = "Зависимостта на светимостта на звездите от тяхната температура е прието да се нарича диаграма спектър-светимост, защото ефективната температура се определя, като се анализира спектерът на звездата. Мястото на зездите върху диаграмата зависи от тяхната маса и възраст. По време на своето развитие звездите променят положението си върху диаграмата, т.е тя има еволюционен смисъл.";
                    // Background Images

                    PictureBox1.BackgroundImage = Properties.Resources.Zvezdi;
                    PictureBox2.BackgroundImage = Properties.Resources.Protonen_cikul;
                    PictureBox3.BackgroundImage = Properties.Resources.Spektur_svetimost;
                    break;
                case "Свързване на консуматори":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox4.Hide();
                    PictureBox5.Hide();
                    PictureBox3.Hide();
                    Paragraph3.Hide();
                    RBox.Visible = false;
                    HeaderParagraph4.Hide();

                    // Show objects
                    HeaderParagraph2.BringToFront();
                    PictureBox1.BringToFront();
                    Paragraph1.BringToFront();
                    Q1Box.Show();
                    Q2Box.Show();
                    FormulaButton.Show();
                    SelectFormulaBox.Show();
                    SelectFormulaBox.Items.Clear();
                    SelectFormulaBox.Items.Insert(0, "Изберете");
                    SelectFormulaBox.SelectedIndex = 0;
                    SelectFormulaBox.Items.Add("ток [I]");
                    SelectFormulaBox.Items.Add("напрежение [U]");
                    SelectFormulaBox.Items.Add("съпротивление [R]");


                    // The size of the objects

                    PictureBox1.Size = new Size(310, 210);
                    PictureBox2.Size = new Size(366, 160);
                    Paragraph1.Size = new Size(357, 168);

                    // The locations of the objects

                    PictureBox2.Location = new Point(400, 460);
                    HeaderParagraph3.Location = new Point(860, 201);
                    HeaderParagraph2.Location = new Point(32, 420);
                    HeaderTitle.Location = new Point(489, 149);
                    Paragraph2.Location = new Point(32, 480);

                    Q1Box.Location = new Point(800, 299);
                    Q2Box.Location = new Point(800, 354);
                    FormulaButton.Location = new Point(800, 409);
                    SelectFormulaBox.Location = new Point(840, 244);
                    LabelResult.Location = new Point(840, 485);


                    // The texts of the labels

                    Q1Box.PlaceholderText = "Въведи напрежение [U]";
                    Q2Box.PlaceholderText = "Въведи съпротивление [R]";

                    HeaderTitle.Text = "Свързване на консуматори";
                    HeaderParagraph1.Text = "Закон на Ом";
                    HeaderParagraph2.Text = "Последователно и успоредно свързване";
                    HeaderParagraph3.Text = "Закон на Ом";
                    Paragraph1.Text = "Законът на Ом е физичен закон, определящ зависимостта между напрежението, тока и съпротивлението на проводника в електрическа верига. Същността на закона е проста: създаваният от напрежението ток е обратно пропорционален на съпротивлението, което той трябва да преодолява, и е право пропорционален на пораждащото го напрежение.";
                    Paragraph2.Text = "Последователното свързване се използва, когато е необходим уред, работещ при ниско напрежение, да бъде захранван от източник с по-високо напрежение. При успоредното свързане, консуматорите имат общо начало и общ край. Консуматорите работят при едно и също напрежение, като ако има повреда на един от консуматорите не влияе на работата на останалите.";

                    // Background Images
                    PictureBox1.BackgroundImage = Properties.Resources.Zakon_na_Om;
                    PictureBox2.BackgroundImage = Properties.Resources.Posledovatelno_usporedno_svurzvane;
                    break;
                case "Източници на напрежение":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox4.Hide();
                    PictureBox5.Hide();
                    PictureBox3.Hide();
                    SelectFormulaBox.Hide();
                    Paragraph3.Hide();
                    HeaderParagraph4.Hide();

                    // Show objects
                    HeaderParagraph2.BringToFront();
                    PictureBox1.BringToFront();
                    Paragraph1.BringToFront();
                    Q1Box.Show();
                    Q2Box.Show();
                    FormulaButton.Show();
                    RBox.Visible = true;

                    // The size of the objects

                    PictureBox1.Size = new Size(310, 210);
                    PictureBox2.Size = new Size(366, 160);
                    Paragraph1.Size = new Size(357, 168);

                    // The locations of the objects

                    HeaderTitle.Location = new Point(489, 149);
                    HeaderParagraph2.Location = new Point(32, 420);
                    HeaderParagraph3.Location = new Point(800, 201);
                    Paragraph2.Location = new Point(32, 480);
                    LabelResult.Location = new Point(840, 500);

                    Q1Box.Location = new Point(800, 244);
                    Q2Box.Location = new Point(800, 309);
                    RBox.Location = new Point(800, 376);
                    FormulaButton.Location = new Point(800, 440);
                    PictureBox2.Location = new Point(385, 460);


                    // The texts of the labels

                    Q1Box.PlaceholderText = "Въведи ЕДН [ε]";
                    Q2Box.PlaceholderText = "Въведи съпротивление [R]";
                    RBox.PlaceholderText = "Въведи вътрешно съпротивление [r]";

                    HeaderTitle.Text = "Източници на напрежение";
                    HeaderParagraph1.Text = "Вътрешно съпротивление на източник";
                    HeaderParagraph2.Text = "Закон на Ом за цялата верига";
                    HeaderParagraph3.Text = "Закон на Ом за цялата верига";
                    Paragraph1.Text = "При протичане на електричен ток топлина се отделя не само в консуматорите, но и в източниците. Това показва, че източниците също имат електрично съпротивление. То се нарича вътрешно съпротивление на източника и се бележи с r. Максималният ток, който може да се черпи от един източник, се определя от неговото вътрешно съпротивление.";
                    Paragraph2.Text = "Законът на Ом се прилага също и към цялата верига, но в малко видоизменена форма: I = E / (R + r). Токът в електрическа верига е равен на отношението на ЕДН ε на източника към пълното съпротивление R + r на веригата.";

                    // Background Images
                    PictureBox1.BackgroundImage = Properties.Resources.Vutreshno_suprotivlenie;
                    PictureBox2.BackgroundImage = Properties.Resources.Zakon_za_cqlata_veriga;
                    break;
                case "Полупроводникови устройства":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox4.Hide();
                    PictureBox5.Hide();
                    Q1Box.Hide();
                    Q2Box.Hide();
                    RBox.Hide();
                    FormulaButton.Hide();
                    SelectFormulaBox.Hide();
                    HeaderParagraph4.Hide();

                    // Show objects
                    Paragraph3.Show();
                    PictureBox3.Show();
                    NextLessonButton.BringToFront();

                    // The size of the objects

                    PictureBox1.Size = new Size(310, 210);
                    PictureBox2.Size = new Size(310, 210);
                    Paragraph1.Size = new Size(357, 168);
                    Paragraph3.Size = new Size(394, 171);

                    // The locations of the objects

                    PictureBox1.Location = new Point(425, 220);
                    PictureBox2.Location = new Point(425, 420);
                    PictureBox3.Location = new Point(830, 363);
                    HeaderParagraph3.Location = new Point(900, 201);
                    HeaderParagraph2.Location = new Point(32, 420);
                    HeaderTitle.Location = new Point(400, 149);
                    Paragraph2.Location = new Point(32, 480);
                    Paragraph3.Location = new Point(764, 235);

                    // The texts of the labels

                    HeaderTitle.Text = "Полупроводникови устройства";
                    HeaderParagraph1.Text = "Термистори и фоторезистори";
                    HeaderParagraph2.Text = "Полупроводникови диоди";
                    HeaderParagraph3.Text = "P–n-преход";
                    Paragraph1.Text = "Съпротивлението на полупроводниците намалява при нагряване, което се дължи на увеличаването на броя на токовите носители. Фоторезисторите се изготвят от полупроводници с голямо съпротивление. На тъмно съпротивлението на фоторезистора е няколко мегаома. При осветяване съпротивлението рязко намалява. Измервайки съпротивлението на фоторезистор, може например лесно да определим къде е по-светло, а къде – по-тъмно.";
                    Paragraph2.Text = "Повечето полупроводникови диоди представляват силициев кристал с p–n-преход и два електрода, свързани съответно към p- и n-областта. За предпазване от външни влияния кристалът се поставя в капсула. Свойството на диодите да пропускат ток само в една посока, намира голямо приложение в електрониката.";
                    Paragraph3.Text = "P–n-преход се нарича границата между полупроводник от n-тип и полупроводник от p-тип.  P–n-преходи се получават, като в един полупроводников кристал (Si, Ge и др.) чрез подходящо легиране се създават две съседни области: едната от n-тип (съдържа донори), а другата от p-тип (съдържа акцептори). P–n-преходите са основните структури в повечето електронни полупроводникови устройства: диоди, светодиоди, транзистори и интегрални схеми.";

                    // Background Images
                    PictureBox1.BackgroundImage = Properties.Resources.Termistor;
                    PictureBox2.BackgroundImage = Properties.Resources.Poluprovodnikov_diod;
                    PictureBox3.BackgroundImage = Properties.Resources.P_n_prehod;
                    break;
                case "Хармонично трептене":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox4.Hide();
                    PictureBox5.Hide();
                    Q2Box.Hide();
                    RBox.Hide();
                    HeaderParagraph4.Hide();
                    Paragraph3.Hide();
                    PictureBox3.Hide();


                    // Show objects

                    Q1Box.Show();
                    FormulaButton.Show();
                    SelectFormulaBox.Show();
                    SelectFormulaBox.Items.Clear();
                    SelectFormulaBox.Items.Insert(0, "Изберете");
                    SelectFormulaBox.SelectedIndex = 0;
                    SelectFormulaBox.Items.Add("честота [v]");
                    SelectFormulaBox.Items.Add("период [T]");

                    // The size of the objects

                    PictureBox1.Size = new Size(292, 172);
                    PictureBox2.Size = new Size(292, 172);
                    Paragraph1.Size = new Size(357, 168);
                    Paragraph2.Size = new Size(372, 164);

                    // The locations of the objects
                    PictureBox1.Location = new Point(440, 240);
                    PictureBox2.Location = new Point(440, 460);
                    HeaderParagraph2.Location = new Point(32, 420);
                    HeaderParagraph3.Location = new Point(775, 201);
                    Paragraph2.Location = new Point(32, 460);
                    Q1Box.Location = new Point(847, 299);
                    FormulaButton.Location = new Point(847, 354);
                    SelectFormulaBox.Location = new Point(890, 244); //375

                    // The texts of the labels
                    Q1Box.PlaceholderText = "Въведи честота [v]";

                    HeaderTitle.Text = "Хармонично трептене";
                    HeaderParagraph1.Text = "Хармонично трептене и периодични движения";
                    HeaderParagraph2.Text = "Характеристики на хармоничното трептене";
                    HeaderParagraph3.Text = "Връзка между период и честота";
                    Paragraph1.Text = "Всяко трептене, при което отклонението x от равновесното положение като функция на времето t се изразява графично с вълнообразна линия. Амплитудата A, периодът T и честотата v не се изменят с времето.\nПериодичните движения са движения, протичащи по един и същи начин, повтаряйки се през равни интервали от време.";
                    Paragraph2.Text = "равновесно положение - положението, в което махалото се връща и остава неподвижно. (т. O).\n отклонение x (m) - разстоянието между равновесното положението на тялото и кое да е друго негово положение.\nАмплитуда A (m) - максималното отклонение на тялото от равновесното му положение.\nПериод T (s) - времето, за което тялото извършва едно пълно трептене.";

                    // Background Images
                    PictureBox1.BackgroundImage = Properties.Resources.Harmonichno_treptene;
                    PictureBox2.BackgroundImage = Properties.Resources.Grafika_harmonichno_treptene;
                    break;
                case "Прости трептящи системи":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox4.Hide();
                    PictureBox5.Hide();
                    RBox.Hide();
                    HeaderParagraph4.Hide();
                    Paragraph3.Hide();
                    PictureBox3.Hide();


                    // Show objects

                    Q1Box.Show();
                    Q2Box.Show();
                    FormulaButton.Show();
                    SelectFormulaBox.Show();
                    SelectFormulaBox.Items.Clear();
                    SelectFormulaBox.Items.Insert(0, "Изберете");
                    SelectFormulaBox.SelectedIndex = 0;
                    SelectFormulaBox.Items.Add("пружинно");
                    SelectFormulaBox.Items.Add("математично");

                    // The size of the objects

                    PictureBox1.Size = new Size(292, 172);
                    PictureBox2.Size = new Size(292, 172);
                    Paragraph1.Size = new Size(357, 168);
                    Paragraph2.Size = new Size(372, 164);

                    // The locations of the objects
                    PictureBox1.Location = new Point(440, 240);
                    PictureBox2.Location = new Point(440, 460);
                    HeaderParagraph2.Location = new Point(32, 420);
                    HeaderParagraph3.Location = new Point(825, 201);
                    Paragraph2.Location = new Point(32, 460);

                    SelectFormulaBox.Location = new Point(870, 275); //difference 55
                    Q1Box.Location = new Point(835, 330);
                    Q2Box.Location = new Point(835, 385);
                    FormulaButton.Location = new Point(835, 440);

                    // The texts of the labels
                    Q1Box.PlaceholderText = "Въведи маса [m]";
                    Q2Box.PlaceholderText = "Въведи коефицент [k]";

                    HeaderTitle.Text = "Прости трептящи системи";
                    HeaderParagraph1.Text = "Пружинно махало";
                    HeaderParagraph2.Text = "Математично махало";
                    HeaderParagraph3.Text = "Период на пружинно и\nматематично махало";
                    Paragraph1.Text = "Пружинно махало е масивно тяло, окачено на неподвижно закрепена пружина, чиято маса е много по-малка от тази на тялото. Амплитудата се определя от това колко ще отклоним топчето от равновесното положение в началния момент, а не от самата трептяща система. Периодът T се определя единствено от масатата m на окаченото тяло и от коефициента на еластичност на пружината k.";
                    Paragraph2.Text = "Математичното махало е тънка, неразтеглива нишка, на която е окачено малко тежко топче, чийто радиус е много по-малък от дължината на нишката. Земното ускорение g е ~= 9,8 m/s².";

                    // Background Images
                    PictureBox1.BackgroundImage = Properties.Resources.Prujinno_mahalo;
                    PictureBox2.BackgroundImage = Properties.Resources.Matematichno_mahalo;
                    break;
                case "Звук":
                    // Hide objects

                    LabelResult.Hide();
                    PictureBox4.Hide();
                    PictureBox5.Hide();
                    HeaderParagraph4.Hide();
                    Paragraph3.Hide();
                    PictureBox3.Hide();

                    SelectFormulaBox.Hide();


                    // Show objects

                    Q1Box.Show();
                    Q2Box.Show();
                    RBox.Visible = true;
                    FormulaButton.Show();

                    // The size of the objects

                    PictureBox1.Size = new Size(292, 172);
                    PictureBox2.Size = new Size(292, 172);
                    Paragraph1.Size = new Size(357, 168);
                    Paragraph2.Size = new Size(372, 191);

                    // The locations of the objects
                    PictureBox1.Location = new Point(440, 240);
                    PictureBox2.Location = new Point(440, 460);
                    HeaderTitle.Location = new Point(550, 149);
                    HeaderParagraph2.Location = new Point(32, 420);
                    HeaderParagraph3.Location = new Point(825, 201);
                    Paragraph2.Location = new Point(32, 455);

                    Q1Box.Location = new Point(835, 255);
                    Q2Box.Location = new Point(835, 310);
                    RBox.Location = new Point(835, 365);
                    FormulaButton.Location = new Point(835, 420);

                    // The texts of the labels
                    Q1Box.PlaceholderText = "Въведи интензитет [I]";
                    Q2Box.PlaceholderText = "Въведи площ [S]";
                    RBox.PlaceholderText = "Въведи време [t]";

                    HeaderTitle.Text = "Звук";
                    HeaderParagraph1.Text = "Характеристики на звука";
                    HeaderParagraph2.Text = "Шум";
                    HeaderParagraph3.Text = "Интензитет на звука";
                    Paragraph1.Text = "Звука е механична вълна с честота от 20 до 20 000 Hz, която предизвиква слухово усещане в нашето ухо. Скоростта на звука u зависи от свойствата на средата, в която се разпространяват звуковите вълни. Звуковите вълни пренасят енергия. Енергията E, която вълната пренася за единица време (t = 1 s) през единица площ (S = 1 m²), разположена перпендикулярно на посоката на разпространение на вълната, се нарича интензитет на звука I.";
                    Paragraph2.Text = "За човека шумът е неприятен за възприемане звук. За разлика от чистия тон графиката на шума е непериодична. Шумът е съставен от голям брой звукови вълни с различни честоти и амплитуди. Шумът забавя реакциите на човека, понижава вниманието и увеличава грешките при изпълнение на различни задачи. Продължителен шум с ниво на интензитета над 90 dB може да предизвика намаление на слуха, а много силен шум (над 140 dB) може да спука тъпанчето на ухото.";


                    // Background Images
                    PictureBox1.BackgroundImage = Properties.Resources.Zvuk;
                    PictureBox2.BackgroundImage = Properties.Resources.Shum;
                    break;
            }
        }
    }
}