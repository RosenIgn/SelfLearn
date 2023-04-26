using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using MySql.Data.MySqlClient;

namespace Self_Learn
{
    public partial class Quiz : UserControl
    {
        /* Променливи */

        private int points = 0, questionNumber = 0, seconds = 0, minutes = 15;
        private readonly int hours = 0;
        private decimal time = 0;
        private decimal savedTime = 0;
        private bool isAnswered = false, isFinished = false, mGrowing;

        private string currentMark;
        private readonly string dateOfExam = DateTime.Now.ToString();
        private MainExams physicsExam;
        private string[] correctAnswers;
        private readonly List<string> myAnswers = new List<string>();

        private readonly string examGrade = Exams.examGrade;
        private readonly string exam = Program.Globals.exam;
        private readonly string username = Program.Globals.username;

        /* Променливи */

        public Quiz()
        {
            InitializeComponent();
            Program.Connection();


            LoadExams();
            AskQuestion(questionNumber);
            remainingTime.Start();

        } /* Зареждане на теста с въпросите и отговорите му */
        private void NextQuestionButton_Click(object sender, EventArgs e) /* Бутон за преминаване към следващ въпрос */
        {
            if (!isAnswered && !isFinished)
            {
                MessageBox.Show("Моля изберете един от отговорите!", "SelfLearn");
            }
            else
            {
                questionNumber++;
                if (questionNumber < physicsExam.Questions.Count)
                {
                    AskQuestion(questionNumber);
                    isAnswered = false;
                    ButtonColorsChange("TransparentColors");
                }
                if (questionNumber > 9)
                {
                    FinishTheExam();
                }
            }
        }
        private void PreviousQuestionButton_Click(object sender, EventArgs e) /* Бутон за връщане към предишен въпрос */
        {
            questionNumber--;
            if (questionNumber >= 0)
            {
                AskQuestion(questionNumber);
                isAnswered = false;
            }
            else
            {
                questionNumber = 0;
            }
            ButtonColorsChange("TransparentColors");
        }
        private void EndExamButton_Click(object sender, EventArgs e) /* Бутон за приключване на теста */
        {
            ReturnToExams();
        }
        private void CheckMarkButton_Click(object sender, EventArgs e) /* Бутон за проверка на оценката и точките за съответния тест */
        {
            MessageBox.Show($"Вашите точки на теста върху: {exam} са {points}т. Оценка: {currentMark}", "SelfLearn");
        }
        private void CheckAnswer(object sender, EventArgs e) /* Event за това ако си натиснал даден отговор, то да го оцветява и да добавя отговора ти в List. */
        {
            isAnswered = true;
            GradientButton senderObject = (GradientButton)sender;
            if (senderObject == AnswerButton0)
            {
                ButtonColorsChange("AnswerButton1");
            }
            else if (senderObject == AnswerButton1)
            {
                ButtonColorsChange("AnswerButton2");
            }
            else if (senderObject == AnswerButton2)
            {
                ButtonColorsChange("AnswerButton3");
            }
            else if (senderObject == AnswerButton3)
            {
                ButtonColorsChange("AnswerButton4");
            }
            myAnswers.Add(senderObject.Text);
        }
        private void AskQuestion(int qnum) /* Функция за задаване на въпрос със съответните му отговори */
        {
            bool isQuestionWith2Answers = false;
            GradientButton[] buttons =
            {
                AnswerButton0,
                AnswerButton1,
                AnswerButton2,
                AnswerButton3,
            };
            questionLabel.Text = qnum + 1 + ". " + physicsExam.Questions[qnum].QuestionLabel;
            string[] questionsWithTwoAnswers =
            {
                "Вярно ли е, че кондензаторът е съставен от две пластини (проводници), наречени електроди и между тях има изолатор (диелектрик)?",
                "Капацитетът C на плосък кондензатор е правопропорционален на площта S на електродите му и е обратнопропорционален на разстоянието d между тях.",
                "Мерната единица за капацитет на кондензатор е кулон - C.",
                "Вярно ли е, че с опита на Юнг се доказва, че светлината е вълна?",
                "Интерференцията се среща при всички видове вълни.",
                "Звездите са огромни горещи газови кълба, които светят със собствена светлина в продължение на милиарди години.",
                "Група от спектрални линии в атомните спектри, дължината на които се подчинява на обща закономерност, се нарича спектрална серия.",
                "Лазерите имат три основни свойства: монохроматичност, насоченост и голям интензитет.",
                "При инверсна населеност ще се извършват повече процеси на стимулирано излъчване.",
                "Електричното съпротивление R не зависи от тока I и напрежението U.",
                "Електродвижещото напрежение на източника е мярка за работата на електричните сили при преминаване на заряд 1C през източника.",
                "Транзисторът е полупроводников елемент, в който са създадени три области с различна примесна проводимост.",
                "При трептенето тялото многократно преминава през равновесното си положение.",
                "Периодът на математично махало не зависи от масата му.",
            };

            for (int i = 0; i < questionsWithTwoAnswers.Length; i++)
            {
                bool containsQuestion = questionLabel.Text.Contains(questionsWithTwoAnswers[i]);
                if (containsQuestion)
                {
                    AnswerButton1.Hide();
                    AnswerButton3.Hide();
                    isQuestionWith2Answers = true;
                }
            }

            if (isQuestionWith2Answers)
            {
                AnswerButton0.Text = physicsExam.Questions[qnum].Answers[0].AnswerLabel;
                AnswerButton2.Text = physicsExam.Questions[qnum].Answers[1].AnswerLabel;
            }
            else
            {
                AnswerButton1.Show();
                AnswerButton3.Show();
                string[] answerLabels = physicsExam.Questions[qnum].Answers.Select(x => x.AnswerLabel).ToArray();

                Random randomNumber = new Random();
                answerLabels = answerLabels.OrderBy(x => randomNumber.Next()).ToArray();

                for (int j = 0; j <= 3; j++)
                {
                    buttons[j].Text = answerLabels[j];
                }
            }
        }
        private void RemainingTime_Tick(object sender, EventArgs e) /* Event за това колко време ти остава, за да приключиш с теста. */
        {
            seconds--;
            time++;
            savedTime = time / 60;
            if (seconds < 0)
            {
                if (minutes > 0)
                {
                    minutes -= 1;
                    seconds += 60;
                }
            }
            textTime.Text = $"{hours.ToString().PadLeft(2, '0')}:{minutes.ToString().PadLeft(2, '0')}:{seconds.ToString().PadLeft(2, '0')}"; // 00:00:00 (hours/minutes/seconds)
            if ((seconds < 0 && minutes == 0) || isFinished)
            {
                if (isFinished)
                {
                    remainingTime.Stop();
                }
                else
                {
                    remainingTime.Stop();
                    textTime.Text = "00:00:00";
                }
                HideButtons();
                questionLabel.Hide();
                Program.Globals.isStartedExam = false;


                DBConnection.conn.Open();

                string selectQuery = "select username from results where username='" + username + "' AND exam='" + exam + "'";
                MySqlCommand myCommand = new MySqlCommand(selectQuery, DBConnection.conn);
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();
                myReader.Read();

                DBConnection.conn.Close();

                if (myReader.HasRows)
                {
                    DBConnection.conn.Open();
                    string updateQuery = $"UPDATE selfteacher.results SET mark = '{currentMark}', points = '{points}', date = '{dateOfExam}' WHERE username = '{username}' AND exam = '{exam}'";
                    MySqlCommand command = new MySqlCommand(updateQuery, DBConnection.conn);
                    command.ExecuteNonQuery();
                    DBConnection.conn.Close();
                }
                else
                {
                    DBConnection.conn.Open();
                    string insertQuery = $"INSERT INTO selfteacher.results(username,points,mark,time,date,exam) VALUES('" + username + "', + '" + points + "', '" + currentMark + "','" + savedTime + "','" + dateOfExam + "','" + exam + "') ON DUPLICATE KEY UPDATE time = '" + savedTime + "'";
                    MySqlCommand commandInsert = new MySqlCommand(insertQuery, DBConnection.conn);
                    commandInsert.ExecuteNonQuery();
                    DBConnection.conn.Close();
                }
            }
        }
        private string ButtonColorsChange(string button) /* Функция за промяна на цвета на бутоните за отговори */
        {
            if (button == "AnswerButton1")
            {
                AnswerButton0.FillColor = ColorTranslator.FromHtml("#5e94ff");
                AnswerButton0.FillColor2 = ColorTranslator.FromHtml("#5e94ff");

                AnswerButton1.FillColor = Color.Transparent;
                AnswerButton1.FillColor2 = Color.Transparent;
                AnswerButton2.FillColor = Color.Transparent;
                AnswerButton2.FillColor2 = Color.Transparent;
                AnswerButton3.FillColor = Color.Transparent;
                AnswerButton3.FillColor2 = Color.Transparent;
            }
            else if (button == "AnswerButton2")
            {
                AnswerButton1.FillColor = ColorTranslator.FromHtml("#5e94ff");
                AnswerButton1.FillColor2 = ColorTranslator.FromHtml("#5e94ff");

                AnswerButton0.FillColor = Color.Transparent;
                AnswerButton0.FillColor2 = Color.Transparent;
                AnswerButton2.FillColor = Color.Transparent;
                AnswerButton2.FillColor2 = Color.Transparent;
                AnswerButton3.FillColor = Color.Transparent;
                AnswerButton3.FillColor2 = Color.Transparent;
            }
            else if (button == "AnswerButton3")
            {
                AnswerButton2.FillColor = ColorTranslator.FromHtml("#5e94ff");
                AnswerButton2.FillColor2 = ColorTranslator.FromHtml("#5e94ff");

                AnswerButton1.FillColor = Color.Transparent;
                AnswerButton1.FillColor2 = Color.Transparent;
                AnswerButton0.FillColor = Color.Transparent;
                AnswerButton0.FillColor2 = Color.Transparent;
                AnswerButton3.FillColor = Color.Transparent;
                AnswerButton3.FillColor2 = Color.Transparent;
            }
            else if (button == "AnswerButton4")
            {
                AnswerButton3.FillColor = ColorTranslator.FromHtml("#5e94ff");
                AnswerButton3.FillColor2 = ColorTranslator.FromHtml("#5e94ff");

                AnswerButton1.FillColor = Color.Transparent;
                AnswerButton1.FillColor2 = Color.Transparent;
                AnswerButton2.FillColor = Color.Transparent;
                AnswerButton2.FillColor2 = Color.Transparent;
                AnswerButton0.FillColor = Color.Transparent;
                AnswerButton0.FillColor2 = Color.Transparent;
            }
            else if (button == "TransparentColors")
            {
                AnswerButton0.FillColor = Color.Transparent;
                AnswerButton0.FillColor2 = Color.Transparent;
                AnswerButton1.FillColor = Color.Transparent;
                AnswerButton1.FillColor2 = Color.Transparent;
                AnswerButton2.FillColor = Color.Transparent;
                AnswerButton2.FillColor2 = Color.Transparent;
                AnswerButton3.FillColor = Color.Transparent;
                AnswerButton3.FillColor2 = Color.Transparent;
            }
            return button;
        }
        private void questionLabel_SizeChanged(object sender, EventArgs e)
        {
            base.OnSizeChanged(e);
            ResizeQuestionLabel();
        } /* Event, който ни служи за Resize-a на questionLabel */
        private void questionLabel_TextChanged(object sender, EventArgs e)
        {
            base.OnTextChanged(e);
            ResizeQuestionLabel();
        } /* Event, който ни служи за Resize-a на questionLabel */
        private void questionLabel_FontChanged(object sender, EventArgs e)
        {
            base.OnFontChanged(e);
            ResizeQuestionLabel();
        } /* Event, който ни служи за Resize-a на questionLabel */
        private void HideButtons() /* Функция за скриване на бутоните при приключване на теста */
        {
            GradientButton[] buttons =
            {
                AnswerButton0,
                AnswerButton1,
                AnswerButton2,
                AnswerButton3,
                NextQuestionButton,
            };
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Hide();
            }
            CheckMarkButton.Show();
            CheckMarkButton.BringToFront();
            EndExamButton.Text = "Върни се";
        }
        private void FinishTheExam() /* Функция за приключване на теста */
        {
            List<string> savedAnswers = myAnswers.Distinct().ToList();
            for (int i = 0; i < correctAnswers.Length; i++)
            {
                for (int j = 0; j < savedAnswers.Count; j++)
                {
                    if (correctAnswers[i] == savedAnswers[j])
                    {
                        points++;
                    }
                }
            }
            Marks();

            HideButtons();
            pictureBox10.Show();
            pictureBox10.BringToFront();

            isFinished = true;
        }
        private void LoadExams() /* Функция за зареждане на съответния тест със съответните му отговори */
        {
            switch (examGrade)
            {
                case "10 клас":
                    switch (exam)
                    {
                        case "Електромагнитни явления":
                            physicsExam = new MainExams("Physics Test #1", "10 клас", new List<ExamQuestions>()
                {
                new ExamQuestions(
                    1,
                    "С Кулонова везна се измерва:",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) електричен заряд"),
                        new ExamAnswers("Б) електрична сила"),
                        new ExamAnswers("В) електричен ток"),
                        new ExamAnswers("Г) електрично напрежение")
                    }
                ),
                new ExamQuestions(
                    2,
                    "При наелектризиране на две тела чрез триене между тях се обменят:",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) йони"),
                        new ExamAnswers("Б) електрони"),
                        new ExamAnswers("В) неутрони"),
                        new ExamAnswers("Г) протони")
                    }
                ),
                new ExamQuestions(
                    3,
                    "Вярно ли е, че кондензаторът е съставен от две пластини (проводници), наречени електроди и между тях има изолатор (диелектрик)?",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) Не"),
                        new ExamAnswers("Б) Да")
                    }
                ),
                new ExamQuestions(
                    4,
                    "Коя е величината, която характеризира способността на кондензатора да съхранява електрични заряди?",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) съпротивление – R"),
                        new ExamAnswers("Б) интензитет – Е"),
                        new ExamAnswers("В) капацитет – C"),
                        new ExamAnswers("Г) спец. съпротивление")
                    }
                ),
                new ExamQuestions(
                    5,
                    "С коя от посочените величини се характеризира кондензаторът?",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) капацитет"),
                        new ExamAnswers("Б) интензитет"),
                        new ExamAnswers("В) потенциал"),
                        new ExamAnswers("Г) сила")
                    }
                ),
                new ExamQuestions(
                    6,
                    "Капацитетът C на плосък кондензатор е правопропорционален на площта S на електродите му и е обратнопропорционален на разстоянието d между тях.",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) Вярно"),
                        new ExamAnswers("А) Грешно")
                    }
                ),
                new ExamQuestions(
                    7,
                    "С коя от посочените формули можеш да изразиш ефективната стойност на тока?",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) I=U².P"),
                        new ExamAnswers("Б) I= P / U"),
                        new ExamAnswers("В) I=P+U"),
                        new ExamAnswers("Г) I=P.U")
                    }
                ),
                new ExamQuestions(
                    8,
                    "Когато във вторичната намотка на трансформатор има по-малък брой навивки, отколкото в първичната намотка трансформаторът е:",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) понижаващ"),
                        new ExamAnswers("Б) постоянен"),
                        new ExamAnswers("В) повишаващ"),
                        new ExamAnswers("Г) няма верен отговор")
                    }
                ),
                new ExamQuestions(
                    9,
                    "Мерната единица за капацитет на кондензатор е кулон - C.",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) Грешно"),
                        new ExamAnswers("Б) Вярно")
                    }
                ),
               new ExamQuestions(
                    10,
                    "Колко ще се намалят топлинните загуби в електропровод, ако същата мощност се пренася при 3 пъти по-високо напрежение?",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) 6 пъти"),
                        new ExamAnswers("Б) 18 пъти"),
                        new ExamAnswers("В) 9 пъти"),
                        new ExamAnswers("Г) 3 пъти")
                    }
                ),
                });
                            correctAnswers = new string[]
                            {
                                "Б) електрична сила",
                                "Б) електрони",
                                "Б) Да",
                                "В) капацитет – C",
                                "А) капацитет",
                                "А) Вярно",
                                "Б) I= P / U",
                                "А) понижаващ",
                                "А) Грешно",
                                "В) 9 пъти",
                            };
                            break;
                        case "Светлина":
                            physicsExam = new MainExams("Physics Test #2", "10 клас", new List<ExamQuestions>()
                            {
                            new ExamQuestions(
                                1,
                                "Ъгълът между падащия и отразения лъч е 40 градуса. На колко е равен ъгълът на падане?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) 50 градуса"),
                                    new ExamAnswers("Б) 60 градуса"),
                                    new ExamAnswers("В) 80 градуса"),
                                    new ExamAnswers("Г) 20 градуса")
                                }
                            ),
                            new ExamQuestions(
                                2,
                                "Ъгълът между падащ лъч и плоско огледало е 20^0. Колко е ъгълът на отражение?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) 20 градуса"),
                                    new ExamAnswers("Б) 70 градуса"),
                                    new ExamAnswers("В) 90 градуса"),
                                    new ExamAnswers("Г) 40 градуса")
                                }
                            ),
                            new ExamQuestions(
                                3,
                                "Кой от следните елементи се използва в спектралните прибори за разлагане на бялата светлина?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) оптично влакно"),
                                    new ExamAnswers("Б) плоско огледало"),
                                    new ExamAnswers("В) дифракционна решетка"),
                                    new ExamAnswers("Г) фотоклетка")
                                }
                            ),
                            new ExamQuestions(
                                4,
                                "От видимата светлина най-голяма дължина на вълната има:",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) оранжевата светлина"),
                                    new ExamAnswers("Б) зелената светлина"),
                                    new ExamAnswers("В) виолетовата светлина"),
                                    new ExamAnswers("Г) червената светлина")
                                }
                            ),
                            new ExamQuestions(
                                5,
                                "Вярно ли е, че с опита на Юнг се доказва, че светлината е вълна?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) Да"),
                                    new ExamAnswers("Б) Не")
                                }
                            ),
                            new ExamQuestions(
                                6,
                                "Кое от твърденията НЕ е вярно? Явлението дисперсия се наблюдава при разпространение на електромагнитни вълни във:",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) вакуум"),
                                    new ExamAnswers("Б) стъкло"),
                                    new ExamAnswers("В) вода"),
                                    new ExamAnswers("Г) диамант")
                                }
                            ),
                            new ExamQuestions(
                                7,
                                "Кой физик за първи път наблюдава интерференция на светлината?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) Александро Волта"),
                                    new ExamAnswers("Б) Шарл Кулон"),
                                    new ExamAnswers("В) Томас Юнг"),
                                    new ExamAnswers("Г) Хайнрих Херц")
                                }
                            ),
                            new ExamQuestions(
                                8,
                                "Върху мокър асфалт е разлят бензин. В бензиновите петна се наблюдават различни цветове. Кое светлинно явление има решаващо значение за оцветяването?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) поглъщането на светлина"),
                                    new ExamAnswers("Б) пречупването на светлина"),
                                    new ExamAnswers("В) интерференцията"),
                                    new ExamAnswers("Г) дисперсията")
                                }
                            ),
                            new ExamQuestions(
                                9,
                                "Явлението, при което се наблюдава усилване на вълните в едни точки и отслабване в други точки в резултат от наслагването на две или повече вълни, се нарича:",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) интерференция"),
                                    new ExamAnswers("Б) пречупване"),
                                    new ExamAnswers("В) пълно вътр. отражение"),
                                    new ExamAnswers("Г) дисперсия")
                                }
                            ),
                           new ExamQuestions(
                                10,
                                "Интерференцията се среща при всички видове вълни.",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) Вярно"),
                                    new ExamAnswers("Б) Грешно")
                                }
                            ),
                            });
                            correctAnswers = new string[]
                            {
                                "Г) 20 градуса",
                                "Б) 70 градуса",
                                "В) дифракционна решетка",
                                "Г) червената светлина",
                                "А) Да",
                                "A) вакуум",
                                "В) Томас Юнг",
                                "В) интерференцията",
                                "А) интерференция",
                                "А) Вярно",
                            };
                            break;
                        case "От атома до Космоса":
                            physicsExam = new MainExams("Physics Test #3", "10 клас", new List<ExamQuestions>()
                            {
                            new ExamQuestions(
                                1,
                                "Звездите са огромни горещи газови кълба, които светят със собствена светлина в продължение на милиарди години.",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) Грешно"),
                                    new ExamAnswers("Б) Вярно"),
                                }
                            ),
                            new ExamQuestions(
                                2,
                                "От кой спектрален клас е Слънцето?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) клас A"),
                                    new ExamAnswers("Б) клас O"),
                                    new ExamAnswers("В) клас G"),
                                    new ExamAnswers("Г) клас M")
                                }
                            ),
                            new ExamQuestions(
                                3,
                                "Основният източник на енергия в недрата на звездите са реакции на:",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) горене на водород и метан"),
                                    new ExamAnswers("Б) термоядрен синтез"),
                                    new ExamAnswers("В) алфа- и бета- разпадане"),
                                    new ExamAnswers("Г) делене на урана")
                                }
                            ),
                            new ExamQuestions(
                                4,
                                "Какъв е спектърът на излъчване на водородни атоми?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) непрекъснат"),
                                    new ExamAnswers("Б) ивичен и линеен"),
                                    new ExamAnswers("В) ивичен"),
                                    new ExamAnswers("Г) линеен")
                                }
                            ),
                            new ExamQuestions(
                                5,
                                "Група от спектрални линии в атомните спектри, дължината на които се подчинява на обща закономерност, се нарича спектрална серия.",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) Вярно"),
                                    new ExamAnswers("Б) Грешно"),
                                }
                            ),
                            new ExamQuestions(
                                6,
                                "Четири спектрални линии от спектъра на водорода, разположени във видимата област, образуват спектрална серия на:",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) Лайман"),
                                    new ExamAnswers("Б) Пашен"),
                                    new ExamAnswers("В) Брякет"),
                                    new ExamAnswers("Г) Балмер")
                                }
                            ),
                            new ExamQuestions(
                                7,
                                "Най-проста е структурата на водородния атом, който е съставен от:",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) 1 протон и 1 електрон"),
                                    new ExamAnswers("Б) 1 протон и 2 електрона"),
                                    new ExamAnswers("В) 2 протона и 1 електрон"),
                                    new ExamAnswers("Г) 2 протона и 2 електрона")
                                }
                            ),
                            new ExamQuestions(
                                8,
                                "Лазерите имат три основни свойства: монохроматичност, насоченост и голям интензитет.",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) Грешно"),
                                    new ExamAnswers("Б) Вярно")
                                }
                            ),
                            new ExamQuestions(
                                9,
                                "Атом се намира във възбудено състояние и след много кратко време електронът прескача обратно на по-ниското ниво. Как се нарича този преход?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) спонтанно поглъщане"),
                                    new ExamAnswers("Б) стимулирано излъчване"),
                                    new ExamAnswers("В) спонтанно излъчване"),
                                    new ExamAnswers("Г) стимулирано поглъщане")
                                }
                            ),
                           new ExamQuestions(
                                10,
                                "При инверсна населеност ще се извършват повече процеси на стимулирано излъчване.",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) Вярно"),
                                    new ExamAnswers("Б) Грешно")
                                }
                            ),
                            });
                            correctAnswers = new string[]
                            {
                                "Б) Вярно",
                                "В) клас G",
                                "Б) термоядрен синтез",
                                "Г) линеен",
                                "А) Вярно",
                                "Г) Балмер",
                                "А) един протон и един електрон",
                                "Б) Вярно",
                                "В) спонтанно излъчване",
                                "А) Вярно",
                            };
                            break;
                    }
                    break;
                case "8 и 9 клас":
                    switch (exam)
                    {
                        case "Електричен ток":
                            physicsExam = new MainExams("Physics Test #1", "8 и 9 клас", new List<ExamQuestions>()
                {
                new ExamQuestions(
                    1,
                    "Електричното съпротивление R не зависи от тока I и напрежението U.",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) Вярно"),
                        new ExamAnswers("Б) Грешно"),
                    }
                ),
                new ExamQuestions(
                    2,
                    "Коя величина характеризира електричните свойства на дадено вещество?",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) токът I"),
                        new ExamAnswers("Б) спец. съпротивление ρ"),
                        new ExamAnswers("В) ел. съпротивление R"),
                        new ExamAnswers("Г) напрежението U")
                    }
                ),
                new ExamQuestions(
                    3,
                    "Волтметър измерва напрежение U = 9 V върху един резистор. Колко ома е съпротивлението на резистора, ако през него протича ток I = 200 mA? Указание: 1mA = 0,001A",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) 0,045 Ω"),
                        new ExamAnswers("Б) 1,8 Ω"),
                        new ExamAnswers("В) 1800 Ω"),
                        new ExamAnswers("Г) 45 Ω"),
                    }
                ),
                new ExamQuestions(
                    4,
                    "Пресметни тока във верига с ЕДН ϵ = 12V, ако е включен консуматор със съпротивление R= 3 Ω, а вътрешното съпротивление на източника е r= 1 Ω.",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) I= 3A"),
                        new ExamAnswers("Б) I= 0,3A"),
                        new ExamAnswers("В) I= 4A"),
                        new ExamAnswers("Г) I= 6A")
                    }
                ),
                new ExamQuestions(
                    5,
                    "Електродвижещото напрежение на източника е мярка за работата на електричните сили при преминаване на заряд 1C през източника.",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) Грешно"),
                        new ExamAnswers("Б) Вярно"),
                    }
                ),
                new ExamQuestions(
                    6,
                    "Намери максималния ток, който може да протече през източник с ЕДН 220V и вътрешно съпротивление 0,5 Ω.",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) 110A"),
                        new ExamAnswers("Б) 4400A"),
                        new ExamAnswers("В) 440A"),
                        new ExamAnswers("Г) 44A")
                    }
                ),
                new ExamQuestions(
                    7,
                    "Транзисторът е полупроводников елемент, в който са създадени три области с различна примесна проводимост.",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) Вярно"),
                        new ExamAnswers("Б) Грешно"),
                    }
                ),
                new ExamQuestions(
                    8,
                    "Кои полупроводникови прибори позволиха днес да можем да носим цял компютър в джоба си?",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) транзистори"),
                        new ExamAnswers("Б) светодиоди"),
                        new ExamAnswers("В) интегрални схеми"),
                        new ExamAnswers("Г) фотодиоди")
                    }
                ),
                new ExamQuestions(
                    9,
                    "Коe от изброените полупроводникови устройства НЕ използва p-n преход?",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) термистор"),
                        new ExamAnswers("Б) диод"),
                        new ExamAnswers("В) транзистор"),
                        new ExamAnswers("Г) светодиод")
                    }
                ),
               new ExamQuestions(
                    10,
                    "Термисторите са полупроводникови прибори, чието специфично съпротивление ρ",
                    new List<ExamAnswers>()
                    {
                        new ExamAnswers("А) клони към нула"),
                        new ExamAnswers("Б) не зависи от температура"),
                        new ExamAnswers("В) има високи стойности"),
                        new ExamAnswers("Г) се влияе от температура")
                    }
                ),
                });
                            correctAnswers = new string[]
                            {
                                "А) Вярно",
                                "Б) спец. съпротивление ρ",
                                "Г) 45 Ω",
                                "А) I= 3A",
                                "Б) Вярно",
                                "В) 440A",
                                "А) Вярно",
                                "В) интегрални схеми",
                                "А) термистор",
                                "Г) се влияе от температурата",
                            };
                            break;
                        case "Механично движение":
                            physicsExam = new MainExams("Physics Test #2", "8 и 9 клас", new List<ExamQuestions>()
                            {
                            new ExamQuestions(
                                1,
                                "При трептенето тялото многократно преминава през равновесното си положение.",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) Грешно"),
                                    new ExamAnswers("Б) Вярно"),
                                }
                            ),
                            new ExamQuestions(
                                2,
                                "Кои от величините характеризират трептенето?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) честота и обем"),
                                    new ExamAnswers("Б) честота и маса"),
                                    new ExamAnswers("В) маса и амплитуда"),
                                    new ExamAnswers("Г) амплитуда и честота")
                                }
                            ),
                            new ExamQuestions(
                                3,
                                "Намери периода на трептене T на махало, което трепти с честота v = 2Hz.",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) T = 1s"),
                                    new ExamAnswers("Б) T = 2s"),
                                    new ExamAnswers("В) T = 0,5 s"),
                                    new ExamAnswers("Г) T = 0,2 s")
                                }
                            ),
                            new ExamQuestions(
                                4,
                                "Периодът на математично махало не зависи от масата му.",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) Вярно"),
                                    new ExamAnswers("Б) Грешно"),
                                }
                            ),
                            new ExamQuestions(
                                5,
                                "Периодите на две математични махала се отнасят, както 1 : 3. Как ще се отнасят дължините на махалата?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) 3 : 1"),
                                    new ExamAnswers("Б) 9 : 1"),
                                    new ExamAnswers("В) 1 : 3"),
                                    new ExamAnswers("Г) 1 : 9")
                                }
                            ),
                            new ExamQuestions(
                                6,
                                "Какъв е периодът на трептене на пружинно махало с маса  m = 0,1 kg и коефициент на еластичност на пружината k = 0,4 N/m ?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) T = 0,3 s"),
                                    new ExamAnswers("Б) T = 6,28 s"),
                                    new ExamAnswers("В) T = 3,14 s"),
                                    new ExamAnswers("Г) T = 0,6 s")
                                }
                            ),
                            new ExamQuestions(
                                7,
                                "Намери честотата на математично махало с дължина l = 10 m. Приеми земното ускорение g = 10 m/s²",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) v = 6, 28 Hz"),
                                    new ExamAnswers("Б) v ≈ 0,31 Hz"),
                                    new ExamAnswers("В) v ≈ 0, 16 Hz"),
                                    new ExamAnswers("Г) v = 3,14 Hz")
                                }
                            ),
                            new ExamQuestions(
                                8,
                                "Посочете грешния отговор. Звукът може да се разпространява в:",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) вакуум"),
                                    new ExamAnswers("Б) течности"),
                                    new ExamAnswers("В) твърди среди"),
                                    new ExamAnswers("Г) газове")
                                }
                            ),
                            new ExamQuestions(
                                9,
                                "С коя формула се изчислява интензитетът на звука?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) E = (I . s) / T"),
                                    new ExamAnswers("Б) I = E / (S . t)"),
                                    new ExamAnswers("В) E = I . s . T"),
                                    new ExamAnswers("Г) I = E . S . T")
                                }
                            ),
                           new ExamQuestions(
                                10,
                                "Преди началото на кинопрожекция нивото на интензитета на шума в залата намалява от 70dB на 20dB. Колко пъти е намалял интензитетът на шума?",
                                new List<ExamAnswers>()
                                {
                                    new ExamAnswers("А) 10⁵ пъти"),
                                    new ExamAnswers("Б) 100 пъти"),
                                    new ExamAnswers("В) 10³ пъти"),
                                    new ExamAnswers("Г) 50 пъти")
                                }
                            ),
                            });
                            correctAnswers = new string[]
                            {
                                "Б) Вярно",
                                "Г) амплитуда и честота",
                                "В) T = 0,5 s",
                                "А) Вярно",
                                "Г) 1 : 9",
                                "В) T = 3,14 s",
                                "В) v ≈ 0, 16 Hz",
                                "А) вакуум",
                                "Б) I = E / (S . t)",
                                "А) 10⁵ пъти",
                            };
                            break;
                    }
                    break;
            }
        }
        private void Marks() /* Функция за скалата на оценяване за съответните оценки */
        {
            if (points <= 3)
            {
                currentMark = "Слаб 2";
            }
            else if (points >= 4 && points <= 6)
            {
                currentMark = "Среден 3";
            }
            else if (points >= 7 && points <= 8)
            {
                currentMark = "Добър 4";
            }
            else
            {
                currentMark = points == 9 ? "Много добър 5" : "Отличен 6";
            }
        }
        private void ReturnToExams() /* Функция за връщане към UserControl-a Exams */
        {
            if (EndExamButton.Text == "Върни се")
            {
                Exams examsPage = new Exams();
                ShowControl.showControl(examsPage, MainPanel);
                examsPage.Show();
                examsPage.BringToFront();
                pictureBox10.Hide();
                pictureBox2.Hide();
                pictureBox1.Hide();
                CheckMarkButton.Hide();
            }
            else
            {
                FinishTheExam();
            }
        }
        public void ResizeQuestionLabel() /* Основната функция, която ни служи за Resize-a на questionLabel */
        {
            if (!mGrowing)
            {
                try
                {
                    mGrowing = true;
                    Size sz = new Size(this.Width, int.MaxValue);
                    sz = TextRenderer.MeasureText(questionLabel.Text, questionLabel.Font, sz, TextFormatFlags.WordBreak);
                    questionLabel.Height = sz.Height;
                }
                finally
                {
                    mGrowing = false;
                }
            }
        }
    }
}