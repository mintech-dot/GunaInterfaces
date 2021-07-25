namespace Login
{
    partial class MarketLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketLogin));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PasswordText = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComponyName = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.LoginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UsernameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.Close = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-69, -84);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(507, 548);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // PasswordText
            // 
            this.PasswordText.Animated = true;
            this.PasswordText.AutoRoundedCorners = true;
            this.PasswordText.BorderRadius = 15;
            this.PasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordText.DefaultText = "";
            this.PasswordText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordText.DisabledState.Parent = this.PasswordText;
            this.PasswordText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordText.FocusedState.Parent = this.PasswordText;
            this.PasswordText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordText.ForeColor = System.Drawing.Color.Black;
            this.PasswordText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordText.HoverState.Parent = this.PasswordText;
            this.PasswordText.Location = new System.Drawing.Point(496, 227);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '\0';
            this.PasswordText.PlaceholderText = "";
            this.PasswordText.SelectedText = "";
            this.PasswordText.ShadowDecoration.Parent = this.PasswordText;
            this.PasswordText.Size = new System.Drawing.Size(315, 32);
            this.PasswordText.TabIndex = 17;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // ComponyName
            // 
            this.ComponyName.AutoSize = true;
            this.ComponyName.Location = new System.Drawing.Point(455, 355);
            this.ComponyName.Name = "ComponyName";
            this.ComponyName.Size = new System.Drawing.Size(105, 13);
            this.ComponyName.TabIndex = 16;
            this.ComponyName.Text = "DotNet Solutions DZ";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(746, 355);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(97, 13);
            this.PhoneNumber.TabIndex = 15;
            this.PhoneNumber.Text = "+213 674 75 94 80";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.Location = new System.Drawing.Point(492, 194);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(84, 20);
            this.password.TabIndex = 14;
            this.password.Text = "Password*";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username.Location = new System.Drawing.Point(492, 107);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(89, 20);
            this.username.TabIndex = 13;
            this.username.Text = "Username*";
            // 
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.AutoRoundedCorners = true;
            this.LoginButton.BorderRadius = 15;
            this.LoginButton.CheckedState.Parent = this.LoginButton;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.CustomImages.Parent = this.LoginButton;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.DisabledState.Parent = this.LoginButton;
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LoginButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoverState.Parent = this.LoginButton;
            this.LoginButton.IndicateFocus = true;
            this.LoginButton.Location = new System.Drawing.Point(583, 291);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.ShadowDecoration.Parent = this.LoginButton;
            this.LoginButton.Size = new System.Drawing.Size(141, 32);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.Text = "Login";
            // 
            // UsernameText
            // 
            this.UsernameText.Animated = true;
            this.UsernameText.AutoRoundedCorners = true;
            this.UsernameText.BorderRadius = 15;
            this.UsernameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameText.DefaultText = "";
            this.UsernameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameText.DisabledState.Parent = this.UsernameText;
            this.UsernameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameText.FocusedState.Parent = this.UsernameText;
            this.UsernameText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UsernameText.ForeColor = System.Drawing.Color.Black;
            this.UsernameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameText.HoverState.Parent = this.UsernameText;
            this.UsernameText.Location = new System.Drawing.Point(496, 140);
            this.UsernameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.PasswordChar = '\0';
            this.UsernameText.PlaceholderText = "";
            this.UsernameText.SelectedText = "";
            this.UsernameText.ShadowDecoration.Parent = this.UsernameText;
            this.UsernameText.Size = new System.Drawing.Size(315, 32);
            this.UsernameText.TabIndex = 11;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FillColor = System.Drawing.Color.White;
            this.Close.HoverState.Parent = this.Close;
            this.Close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.Close.Location = new System.Drawing.Point(820, 2);
            this.Close.Name = "Close";
            this.Close.ShadowDecoration.Parent = this.Close;
            this.Close.Size = new System.Drawing.Size(45, 29);
            this.Close.TabIndex = 18;
            // 
            // MarketLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 377);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.ComponyName);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarketLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarketLogin";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox PasswordText;
        private System.Windows.Forms.Label ComponyName;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private Guna.UI2.WinForms.Guna2GradientButton LoginButton;
        private Guna.UI2.WinForms.Guna2TextBox UsernameText;
        private Guna.UI2.WinForms.Guna2ControlBox Close;
    }
}