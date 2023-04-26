
namespace Self_Learn
{
    partial class Quiz
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.remainingTime = new System.Windows.Forms.Timer(this.components);
            this.questionLabel = new System.Windows.Forms.Label();
            this.NextQuestionButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AnswerButton0 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AnswerButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AnswerButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AnswerButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.CheckMarkButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PreviousQuestionButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.EndExamButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.textTime = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // remainingTime
            // 
            this.remainingTime.Interval = 1000;
            this.remainingTime.Tick += new System.EventHandler(this.RemainingTime_Tick);
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.questionLabel.Location = new System.Drawing.Point(42, 247);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(1121, 65);
            this.questionLabel.TabIndex = 44;
            this.questionLabel.Text = "Въпрос";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.questionLabel.FontChanged += new System.EventHandler(this.questionLabel_FontChanged);
            this.questionLabel.SizeChanged += new System.EventHandler(this.questionLabel_SizeChanged);
            this.questionLabel.TextChanged += new System.EventHandler(this.questionLabel_TextChanged);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Animated = true;
            this.NextQuestionButton.AutoRoundedCorners = true;
            this.NextQuestionButton.BackColor = System.Drawing.Color.Transparent;
            this.NextQuestionButton.BorderRadius = 31;
            this.NextQuestionButton.CheckedState.Parent = this.NextQuestionButton;
            this.NextQuestionButton.CustomImages.Parent = this.NextQuestionButton;
            this.NextQuestionButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(17)))), ((int)(((byte)(203)))));
            this.NextQuestionButton.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextQuestionButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NextQuestionButton.HoverState.Parent = this.NextQuestionButton;
            this.NextQuestionButton.Location = new System.Drawing.Point(486, 466);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.ShadowDecoration.Parent = this.NextQuestionButton;
            this.NextQuestionButton.Size = new System.Drawing.Size(259, 64);
            this.NextQuestionButton.TabIndex = 45;
            this.NextQuestionButton.Text = "Следващ въпрос";
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // AnswerButton0
            // 
            this.AnswerButton0.Animated = true;
            this.AnswerButton0.AutoRoundedCorners = true;
            this.AnswerButton0.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AnswerButton0.BorderRadius = 21;
            this.AnswerButton0.BorderThickness = 3;
            this.AnswerButton0.CheckedState.Parent = this.AnswerButton0;
            this.AnswerButton0.CustomImages.Parent = this.AnswerButton0;
            this.AnswerButton0.FillColor = System.Drawing.Color.Transparent;
            this.AnswerButton0.FillColor2 = System.Drawing.Color.Transparent;
            this.AnswerButton0.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerButton0.ForeColor = System.Drawing.Color.White;
            this.AnswerButton0.HoverState.Parent = this.AnswerButton0;
            this.AnswerButton0.Location = new System.Drawing.Point(334, 326);
            this.AnswerButton0.Name = "AnswerButton0";
            this.AnswerButton0.ShadowDecoration.Parent = this.AnswerButton0;
            this.AnswerButton0.Size = new System.Drawing.Size(295, 45);
            this.AnswerButton0.TabIndex = 53;
            this.AnswerButton0.Tag = "1";
            this.AnswerButton0.Text = "Отговор №1";
            this.AnswerButton0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AnswerButton0.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // AnswerButton1
            // 
            this.AnswerButton1.Animated = true;
            this.AnswerButton1.AutoRoundedCorners = true;
            this.AnswerButton1.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AnswerButton1.BorderRadius = 21;
            this.AnswerButton1.BorderThickness = 3;
            this.AnswerButton1.CheckedState.Parent = this.AnswerButton1;
            this.AnswerButton1.CustomImages.Parent = this.AnswerButton1;
            this.AnswerButton1.FillColor = System.Drawing.Color.Transparent;
            this.AnswerButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.AnswerButton1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerButton1.ForeColor = System.Drawing.Color.White;
            this.AnswerButton1.HoverState.Parent = this.AnswerButton1;
            this.AnswerButton1.Location = new System.Drawing.Point(334, 400);
            this.AnswerButton1.Name = "AnswerButton1";
            this.AnswerButton1.ShadowDecoration.Parent = this.AnswerButton1;
            this.AnswerButton1.Size = new System.Drawing.Size(295, 45);
            this.AnswerButton1.TabIndex = 54;
            this.AnswerButton1.Tag = "2";
            this.AnswerButton1.Text = "Отговор №2";
            this.AnswerButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AnswerButton1.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // AnswerButton2
            // 
            this.AnswerButton2.Animated = true;
            this.AnswerButton2.AutoRoundedCorners = true;
            this.AnswerButton2.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AnswerButton2.BorderRadius = 21;
            this.AnswerButton2.BorderThickness = 3;
            this.AnswerButton2.CheckedState.Parent = this.AnswerButton2;
            this.AnswerButton2.CustomImages.Parent = this.AnswerButton2;
            this.AnswerButton2.FillColor = System.Drawing.Color.Transparent;
            this.AnswerButton2.FillColor2 = System.Drawing.Color.Transparent;
            this.AnswerButton2.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerButton2.ForeColor = System.Drawing.Color.White;
            this.AnswerButton2.HoverState.Parent = this.AnswerButton2;
            this.AnswerButton2.Location = new System.Drawing.Point(682, 326);
            this.AnswerButton2.Name = "AnswerButton2";
            this.AnswerButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AnswerButton2.ShadowDecoration.Parent = this.AnswerButton2;
            this.AnswerButton2.Size = new System.Drawing.Size(295, 45);
            this.AnswerButton2.TabIndex = 55;
            this.AnswerButton2.Tag = "3";
            this.AnswerButton2.Text = "Отговор №3";
            this.AnswerButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AnswerButton2.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // AnswerButton3
            // 
            this.AnswerButton3.Animated = true;
            this.AnswerButton3.AutoRoundedCorners = true;
            this.AnswerButton3.BackColor = System.Drawing.Color.Transparent;
            this.AnswerButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AnswerButton3.BorderRadius = 21;
            this.AnswerButton3.BorderThickness = 3;
            this.AnswerButton3.CheckedState.Parent = this.AnswerButton3;
            this.AnswerButton3.CustomImages.Parent = this.AnswerButton3;
            this.AnswerButton3.FillColor = System.Drawing.Color.Transparent;
            this.AnswerButton3.FillColor2 = System.Drawing.Color.Transparent;
            this.AnswerButton3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerButton3.ForeColor = System.Drawing.Color.White;
            this.AnswerButton3.HoverState.Parent = this.AnswerButton3;
            this.AnswerButton3.Location = new System.Drawing.Point(682, 400);
            this.AnswerButton3.Name = "AnswerButton3";
            this.AnswerButton3.ShadowDecoration.Parent = this.AnswerButton3;
            this.AnswerButton3.Size = new System.Drawing.Size(295, 45);
            this.AnswerButton3.TabIndex = 56;
            this.AnswerButton3.Tag = "4";
            this.AnswerButton3.Text = "Отговор №4";
            this.AnswerButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AnswerButton3.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // CheckMarkButton
            // 
            this.CheckMarkButton.Animated = true;
            this.CheckMarkButton.AutoRoundedCorners = true;
            this.CheckMarkButton.BackColor = System.Drawing.Color.Transparent;
            this.CheckMarkButton.BorderRadius = 31;
            this.CheckMarkButton.CheckedState.Parent = this.CheckMarkButton;
            this.CheckMarkButton.CustomImages.Parent = this.CheckMarkButton;
            this.CheckMarkButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(17)))), ((int)(((byte)(203)))));
            this.CheckMarkButton.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckMarkButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CheckMarkButton.HoverState.Parent = this.CheckMarkButton;
            this.CheckMarkButton.Location = new System.Drawing.Point(486, 296);
            this.CheckMarkButton.Name = "CheckMarkButton";
            this.CheckMarkButton.ShadowDecoration.Parent = this.CheckMarkButton;
            this.CheckMarkButton.Size = new System.Drawing.Size(259, 64);
            this.CheckMarkButton.TabIndex = 61;
            this.CheckMarkButton.Text = "Провери оценката си";
            this.CheckMarkButton.Visible = false;
            this.CheckMarkButton.Click += new System.EventHandler(this.CheckMarkButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.questionLabel);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.PreviousQuestionButton);
            this.MainPanel.Controls.Add(this.pictureBox7);
            this.MainPanel.Controls.Add(this.pictureBox6);
            this.MainPanel.Controls.Add(this.pictureBox5);
            this.MainPanel.Controls.Add(this.pictureBox4);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.pictureBox3);
            this.MainPanel.Controls.Add(this.EndExamButton);
            this.MainPanel.Controls.Add(this.logo);
            this.MainPanel.Controls.Add(this.textTime);
            this.MainPanel.Controls.Add(this.pictureBox8);
            this.MainPanel.Controls.Add(this.pictureBox9);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1174, 640);
            this.MainPanel.TabIndex = 62;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Self_Learn.Properties.Resources.quizPicture2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(27, 357);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(263, 237);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // PreviousQuestionButton
            // 
            this.PreviousQuestionButton.Animated = true;
            this.PreviousQuestionButton.AutoRoundedCorners = true;
            this.PreviousQuestionButton.BackColor = System.Drawing.Color.Transparent;
            this.PreviousQuestionButton.BorderRadius = 31;
            this.PreviousQuestionButton.CheckedState.Parent = this.PreviousQuestionButton;
            this.PreviousQuestionButton.CustomImages.Parent = this.PreviousQuestionButton;
            this.PreviousQuestionButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(17)))), ((int)(((byte)(203)))));
            this.PreviousQuestionButton.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousQuestionButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PreviousQuestionButton.HoverState.Parent = this.PreviousQuestionButton;
            this.PreviousQuestionButton.Location = new System.Drawing.Point(486, 546);
            this.PreviousQuestionButton.Name = "PreviousQuestionButton";
            this.PreviousQuestionButton.ShadowDecoration.Parent = this.PreviousQuestionButton;
            this.PreviousQuestionButton.Size = new System.Drawing.Size(259, 64);
            this.PreviousQuestionButton.TabIndex = 63;
            this.PreviousQuestionButton.Text = "Предишен въпрос";
            this.PreviousQuestionButton.Click += new System.EventHandler(this.PreviousQuestionButton_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(279, 31);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(83, 69);
            this.pictureBox7.TabIndex = 74;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(649, 50);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(105, 92);
            this.pictureBox6.TabIndex = 72;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Self_Learn.Properties.Resources.textBookHeaderPage;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(1037, 152);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(105, 92);
            this.pictureBox5.TabIndex = 73;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(842, 129);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(105, 92);
            this.pictureBox4.TabIndex = 71;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Self_Learn.Properties.Resources.quizPicture1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(899, 451);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 180);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Self_Learn.Properties.Resources.textBookHeaderPage;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(63, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 92);
            this.pictureBox3.TabIndex = 70;
            this.pictureBox3.TabStop = false;
            // 
            // EndExamButton
            // 
            this.EndExamButton.AutoRoundedCorners = true;
            this.EndExamButton.BackColor = System.Drawing.Color.Transparent;
            this.EndExamButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(127)))), ((int)(((byte)(129)))));
            this.EndExamButton.BorderRadius = 21;
            this.EndExamButton.CheckedState.Parent = this.EndExamButton;
            this.EndExamButton.CustomImages.Parent = this.EndExamButton;
            this.EndExamButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(17)))), ((int)(((byte)(203)))));
            this.EndExamButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndExamButton.ForeColor = System.Drawing.Color.White;
            this.EndExamButton.HoverState.Parent = this.EndExamButton;
            this.EndExamButton.Image = global::Self_Learn.Properties.Resources.logOut;
            this.EndExamButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EndExamButton.Location = new System.Drawing.Point(970, 78);
            this.EndExamButton.Name = "EndExamButton";
            this.EndExamButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EndExamButton.ShadowDecoration.Parent = this.EndExamButton;
            this.EndExamButton.Size = new System.Drawing.Size(193, 45);
            this.EndExamButton.TabIndex = 77;
            this.EndExamButton.Text = "Приключи теста";
            this.EndExamButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EndExamButton.Click += new System.EventHandler(this.EndExamButton_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::Self_Learn.Properties.Resources.timerIcon;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(970, 25);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(45, 45);
            this.logo.TabIndex = 69;
            this.logo.TabStop = false;
            // 
            // textTime
            // 
            this.textTime.AutoSize = true;
            this.textTime.BackColor = System.Drawing.Color.Transparent;
            this.textTime.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTime.ForeColor = System.Drawing.Color.DarkGray;
            this.textTime.Location = new System.Drawing.Point(1011, 31);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(131, 39);
            this.textTime.TabIndex = 68;
            this.textTime.Text = "00:00:00";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(223, 152);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(83, 69);
            this.pictureBox8.TabIndex = 75;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::Self_Learn.Properties.Resources.textBookHeaderPage;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(472, 115);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(105, 92);
            this.pictureBox9.TabIndex = 76;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::Self_Learn.Properties.Resources.FinishedExam;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Location = new System.Drawing.Point(388, 305);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(436, 322);
            this.pictureBox10.TabIndex = 60;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Visible = false;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.AnswerButton1);
            this.Controls.Add(this.AnswerButton2);
            this.Controls.Add(this.AnswerButton3);
            this.Controls.Add(this.AnswerButton0);
            this.Controls.Add(this.CheckMarkButton);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.pictureBox10);
            this.Name = "Quiz";
            this.Size = new System.Drawing.Size(1174, 640);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer remainingTime;
        private System.Windows.Forms.Label questionLabel;
        private Guna.UI2.WinForms.Guna2GradientButton NextQuestionButton;
        private Guna.UI2.WinForms.Guna2GradientButton AnswerButton0;
        private Guna.UI2.WinForms.Guna2GradientButton AnswerButton1;
        private Guna.UI2.WinForms.Guna2GradientButton AnswerButton2;
        private Guna.UI2.WinForms.Guna2GradientButton AnswerButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private Guna.UI2.WinForms.Guna2GradientButton CheckMarkButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2GradientButton EndExamButton;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label textTime;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private Guna.UI2.WinForms.Guna2GradientButton PreviousQuestionButton;
    }
}
