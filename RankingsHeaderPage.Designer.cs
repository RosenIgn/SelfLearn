namespace Self_Learn
{
    partial class RankingsHeaderPage
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Paragraph1 = new System.Windows.Forms.Label();
            this.HeaderTitle = new System.Windows.Forms.Label();
            this.SelectClassButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SelectClassBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.pictureBox6);
            this.MainPanel.Controls.Add(this.Paragraph1);
            this.MainPanel.Controls.Add(this.HeaderTitle);
            this.MainPanel.Controls.Add(this.SelectClassButton);
            this.MainPanel.Controls.Add(this.SelectClassBox);
            this.MainPanel.Controls.Add(this.PictureBox1);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.pictureBox3);
            this.MainPanel.Controls.Add(this.pictureBox4);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1174, 640);
            this.MainPanel.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.pictureBox6.BackgroundImage = global::Self_Learn.Properties.Resources.HeaderLogo;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(325, 209);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(368, 201);
            this.pictureBox6.TabIndex = 93;
            this.pictureBox6.TabStop = false;
            // 
            // Paragraph1
            // 
            this.Paragraph1.BackColor = System.Drawing.Color.Transparent;
            this.Paragraph1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paragraph1.ForeColor = System.Drawing.Color.DarkGray;
            this.Paragraph1.Location = new System.Drawing.Point(850, 293);
            this.Paragraph1.Name = "Paragraph1";
            this.Paragraph1.Size = new System.Drawing.Size(319, 176);
            this.Paragraph1.TabIndex = 88;
            this.Paragraph1.Text = "Чрез класацията на SelfLearn, Вие можете да прегледате резултатите Ви от тестовет" +
    "е, които сте решили до момента, като можете и да прегледате резултатите на всичк" +
    "и други потребители в платформата.";
            // 
            // HeaderTitle
            // 
            this.HeaderTitle.AutoSize = true;
            this.HeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.HeaderTitle.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderTitle.ForeColor = System.Drawing.Color.White;
            this.HeaderTitle.Location = new System.Drawing.Point(866, 240);
            this.HeaderTitle.Name = "HeaderTitle";
            this.HeaderTitle.Size = new System.Drawing.Size(249, 28);
            this.HeaderTitle.TabIndex = 87;
            this.HeaderTitle.Text = "Класацията на SelfLearn";
            // 
            // SelectClassButton
            // 
            this.SelectClassButton.AutoRoundedCorners = true;
            this.SelectClassButton.BorderRadius = 21;
            this.SelectClassButton.CheckedState.Parent = this.SelectClassButton;
            this.SelectClassButton.CustomImages.Parent = this.SelectClassButton;
            this.SelectClassButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.SelectClassButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(72)))), ((int)(((byte)(255)))));
            this.SelectClassButton.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectClassButton.ForeColor = System.Drawing.Color.White;
            this.SelectClassButton.HoverState.Parent = this.SelectClassButton;
            this.SelectClassButton.Location = new System.Drawing.Point(896, 558);
            this.SelectClassButton.Name = "SelectClassButton";
            this.SelectClassButton.ShadowDecoration.Parent = this.SelectClassButton;
            this.SelectClassButton.Size = new System.Drawing.Size(219, 45);
            this.SelectClassButton.TabIndex = 86;
            this.SelectClassButton.Text = "Избери клас";
            this.SelectClassButton.Click += new System.EventHandler(this.SelectClassButton_Click);
            // 
            // SelectClassBox
            // 
            this.SelectClassBox.AutoRoundedCorners = true;
            this.SelectClassBox.BackColor = System.Drawing.Color.Transparent;
            this.SelectClassBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SelectClassBox.BorderRadius = 17;
            this.SelectClassBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SelectClassBox.BorderThickness = 2;
            this.SelectClassBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectClassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectClassBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.SelectClassBox.FocusedColor = System.Drawing.Color.Empty;
            this.SelectClassBox.FocusedState.Parent = this.SelectClassBox;
            this.SelectClassBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SelectClassBox.ForeColor = System.Drawing.Color.White;
            this.SelectClassBox.FormattingEnabled = true;
            this.SelectClassBox.HoverState.Parent = this.SelectClassBox;
            this.SelectClassBox.ItemHeight = 30;
            this.SelectClassBox.ItemsAppearance.Parent = this.SelectClassBox;
            this.SelectClassBox.Location = new System.Drawing.Point(896, 496);
            this.SelectClassBox.Name = "SelectClassBox";
            this.SelectClassBox.ShadowDecoration.Parent = this.SelectClassBox;
            this.SelectClassBox.Size = new System.Drawing.Size(219, 36);
            this.SelectClassBox.TabIndex = 85;
            this.SelectClassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.PictureBox1.BackgroundImage = global::Self_Learn.Properties.Resources.Rankings3;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox1.Location = new System.Drawing.Point(22, 24);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(451, 281);
            this.PictureBox1.TabIndex = 84;
            this.PictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.pictureBox2.BackgroundImage = global::Self_Learn.Properties.Resources.Rankings2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(601, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(443, 255);
            this.pictureBox2.TabIndex = 89;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.pictureBox3.BackgroundImage = global::Self_Learn.Properties.Resources.Rankings1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(-16, 283);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(489, 418);
            this.pictureBox3.TabIndex = 90;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.pictureBox4.BackgroundImage = global::Self_Learn.Properties.Resources.Rankings4;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(406, 363);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(522, 311);
            this.pictureBox4.TabIndex = 91;
            this.pictureBox4.TabStop = false;
            // 
            // RankingsHeaderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.MainPanel);
            this.Name = "RankingsHeaderPage";
            this.Size = new System.Drawing.Size(1174, 640);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label Paragraph1;
        private System.Windows.Forms.Label HeaderTitle;
        private Guna.UI2.WinForms.Guna2GradientButton SelectClassButton;
        private Guna.UI2.WinForms.Guna2ComboBox SelectClassBox;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
