namespace Weather_Application
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textbox = new Guna.UI2.WinForms.Guna2TextBox();
            temp_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            city_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            picturebox = new Guna.UI2.WinForms.Guna2PictureBox();
            weather_case_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)picturebox).BeginInit();
            SuspendLayout();
            // 
            // textbox
            // 
            textbox.BorderColor = Color.Black;
            textbox.CustomizableEdges = customizableEdges1;
            textbox.DefaultText = "";
            textbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textbox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textbox.ForeColor = Color.Black;
            textbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textbox.Location = new Point(13, 15);
            textbox.Margin = new Padding(4, 6, 4, 6);
            textbox.Name = "textbox";
            textbox.PasswordChar = '\0';
            textbox.PlaceholderForeColor = SystemColors.ControlDarkDark;
            textbox.PlaceholderText = "";
            textbox.SelectedText = "";
            textbox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            textbox.Size = new Size(306, 84);
            textbox.TabIndex = 0;
            // 
            // temp_label
            // 
            temp_label.BackColor = Color.Transparent;
            temp_label.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            temp_label.IsSelectionEnabled = false;
            temp_label.Location = new Point(114, 192);
            temp_label.Name = "temp_label";
            temp_label.Size = new Size(108, 61);
            temp_label.TabIndex = 1;
            temp_label.Text = "23 °C";
            temp_label.Click += guna2HtmlLabel1_Click;
            // 
            // city_label
            // 
            city_label.BackColor = Color.Transparent;
            city_label.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            city_label.IsSelectionEnabled = false;
            city_label.Location = new Point(89, 431);
            city_label.Name = "city_label";
            city_label.Size = new Size(172, 43);
            city_label.TabIndex = 2;
            city_label.Text = "İstanbul, TR";
            // 
            // picturebox
            // 
            picturebox.CustomizableEdges = customizableEdges3;
            picturebox.FillColor = SystemColors.Control;
            picturebox.ImageRotate = 0F;
            picturebox.Location = new Point(114, 323);
            picturebox.Name = "picturebox";
            picturebox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            picturebox.Size = new Size(92, 88);
            picturebox.TabIndex = 3;
            picturebox.TabStop = false;
            picturebox.Click += picturebox_Click;
            // 
            // weather_case_label
            // 
            weather_case_label.BackColor = Color.Transparent;
            weather_case_label.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            weather_case_label.IsSelectionEnabled = false;
            weather_case_label.Location = new Point(96, 259);
            weather_case_label.Name = "weather_case_label";
            weather_case_label.Size = new Size(144, 43);
            weather_case_label.TabIndex = 4;
            weather_case_label.Text = "az bulutlu";
            weather_case_label.Click += guna2HtmlLabel3_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(54, 108);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(225, 56);
            guna2Button1.TabIndex = 5;
            guna2Button1.Text = "Arama";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 498);
            Controls.Add(guna2Button1);
            Controls.Add(weather_case_label);
            Controls.Add(picturebox);
            Controls.Add(city_label);
            Controls.Add(temp_label);
            Controls.Add(textbox);
            Name = "Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weather Application";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picturebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel temp_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel city_label;
        private Guna.UI2.WinForms.Guna2PictureBox picturebox;
        private Guna.UI2.WinForms.Guna2HtmlLabel weather_case_label;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
