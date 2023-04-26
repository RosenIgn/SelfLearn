
namespace Self_Learn
{
    partial class Rankings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ReturnButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.SelectDataButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SelectDataButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SelectDataButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ReturnButton);
            this.MainPanel.Controls.Add(this.DataGrid);
            this.MainPanel.Controls.Add(this.Panel1);
            this.MainPanel.Controls.Add(this.SelectDataButton1);
            this.MainPanel.Controls.Add(this.SelectDataButton3);
            this.MainPanel.Controls.Add(this.SelectDataButton2);
            this.MainPanel.Controls.Add(this.PictureBox1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1174, 640);
            this.MainPanel.TabIndex = 0;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Animated = true;
            this.ReturnButton.AutoRoundedCorners = true;
            this.ReturnButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(127)))), ((int)(((byte)(129)))));
            this.ReturnButton.BorderRadius = 25;
            this.ReturnButton.CheckedState.Parent = this.ReturnButton;
            this.ReturnButton.CustomImages.Parent = this.ReturnButton;
            this.ReturnButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(252)))));
            this.ReturnButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(72)))), ((int)(((byte)(255)))));
            this.ReturnButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.HoverState.Parent = this.ReturnButton;
            this.ReturnButton.Image = global::Self_Learn.Properties.Resources.logOut;
            this.ReturnButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReturnButton.Location = new System.Drawing.Point(957, 580);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReturnButton.ShadowDecoration.Parent = this.ReturnButton;
            this.ReturnButton.Size = new System.Drawing.Size(193, 53);
            this.ReturnButton.TabIndex = 122;
            this.ReturnButton.Text = "Върни се";
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeight = 36;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid.Location = new System.Drawing.Point(104, 120);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(944, 514);
            this.DataGrid.TabIndex = 117;
            this.DataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.DataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGrid.ThemeStyle.HeaderStyle.Height = 36;
            this.DataGrid.ThemeStyle.ReadOnly = true;
            this.DataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.DataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.Panel1.Location = new System.Drawing.Point(-2, 109);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1178, 5);
            this.Panel1.TabIndex = 123;
            // 
            // SelectDataButton1
            // 
            this.SelectDataButton1.AutoRoundedCorners = true;
            this.SelectDataButton1.BorderRadius = 21;
            this.SelectDataButton1.CheckedState.Parent = this.SelectDataButton1;
            this.SelectDataButton1.CustomImages.Parent = this.SelectDataButton1;
            this.SelectDataButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.SelectDataButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.SelectDataButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectDataButton1.ForeColor = System.Drawing.Color.White;
            this.SelectDataButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.SelectDataButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.SelectDataButton1.HoverState.Parent = this.SelectDataButton1;
            this.SelectDataButton1.Location = new System.Drawing.Point(255, 49);
            this.SelectDataButton1.Name = "SelectDataButton1";
            this.SelectDataButton1.ShadowDecoration.Parent = this.SelectDataButton1;
            this.SelectDataButton1.Size = new System.Drawing.Size(215, 44);
            this.SelectDataButton1.TabIndex = 119;
            this.SelectDataButton1.Text = "Част 1. Електромагнитни явления";
            this.SelectDataButton1.Click += new System.EventHandler(this.SectionClick);
            // 
            // SelectDataButton3
            // 
            this.SelectDataButton3.AutoRoundedCorners = true;
            this.SelectDataButton3.BorderRadius = 21;
            this.SelectDataButton3.CheckedState.Parent = this.SelectDataButton3;
            this.SelectDataButton3.CustomImages.Parent = this.SelectDataButton3;
            this.SelectDataButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.SelectDataButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.SelectDataButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectDataButton3.ForeColor = System.Drawing.Color.White;
            this.SelectDataButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.SelectDataButton3.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.SelectDataButton3.HoverState.Parent = this.SelectDataButton3;
            this.SelectDataButton3.Location = new System.Drawing.Point(698, 49);
            this.SelectDataButton3.Name = "SelectDataButton3";
            this.SelectDataButton3.ShadowDecoration.Parent = this.SelectDataButton3;
            this.SelectDataButton3.Size = new System.Drawing.Size(215, 44);
            this.SelectDataButton3.TabIndex = 118;
            this.SelectDataButton3.Text = "Част 3. От атома до Космоса";
            this.SelectDataButton3.Click += new System.EventHandler(this.SectionClick);
            // 
            // SelectDataButton2
            // 
            this.SelectDataButton2.AutoRoundedCorners = true;
            this.SelectDataButton2.BorderRadius = 21;
            this.SelectDataButton2.CheckedState.Parent = this.SelectDataButton2;
            this.SelectDataButton2.CustomImages.Parent = this.SelectDataButton2;
            this.SelectDataButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.SelectDataButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.SelectDataButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectDataButton2.ForeColor = System.Drawing.Color.White;
            this.SelectDataButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.SelectDataButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.SelectDataButton2.HoverState.Parent = this.SelectDataButton2;
            this.SelectDataButton2.Location = new System.Drawing.Point(476, 49);
            this.SelectDataButton2.Name = "SelectDataButton2";
            this.SelectDataButton2.ShadowDecoration.Parent = this.SelectDataButton2;
            this.SelectDataButton2.Size = new System.Drawing.Size(215, 44);
            this.SelectDataButton2.TabIndex = 120;
            this.SelectDataButton2.Text = "Част 2. Светлина";
            this.SelectDataButton2.Click += new System.EventHandler(this.SectionClick);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.PictureBox1.BackgroundImage = global::Self_Learn.Properties.Resources.teacher;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox1.Location = new System.Drawing.Point(988, 7);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(178, 107);
            this.PictureBox1.TabIndex = 121;
            this.PictureBox1.TabStop = false;
            // 
            // Rankings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.Name = "Rankings";
            this.Size = new System.Drawing.Size(1174, 640);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private Guna.UI2.WinForms.Guna2GradientButton ReturnButton;
        private Guna.UI2.WinForms.Guna2DataGridView DataGrid;
        private System.Windows.Forms.Panel Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton SelectDataButton1;
        private Guna.UI2.WinForms.Guna2GradientButton SelectDataButton3;
        private Guna.UI2.WinForms.Guna2GradientButton SelectDataButton2;
        private System.Windows.Forms.PictureBox PictureBox1;
    }
}
