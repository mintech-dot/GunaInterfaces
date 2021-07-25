namespace Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.GIF = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UsernameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.ComponyName = new System.Windows.Forms.Label();
            this.PasswordText = new Guna.UI2.WinForms.Guna2TextBox();
            this.LogoPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Close = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.GIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // GIF
            // 
            this.GIF.BackColor = System.Drawing.Color.Transparent;
            this.GIF.Image = ((System.Drawing.Image)(resources.GetObject("GIF.Image")));
            this.GIF.ImageRotate = 0F;
            this.GIF.Location = new System.Drawing.Point(-66, -339);
            this.GIF.Name = "GIF";
            this.GIF.ShadowDecoration.Parent = this.GIF;
            this.GIF.Size = new System.Drawing.Size(509, 1051);
            this.GIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GIF.TabIndex = 0;
            this.GIF.TabStop = false;
            this.GIF.UseTransparentBackground = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 11;
            this.guna2Elipse1.TargetControl = this;
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
            this.UsernameText.Location = new System.Drawing.Point(499, 140);
            this.UsernameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.PasswordChar = '\0';
            this.UsernameText.PlaceholderText = "";
            this.UsernameText.SelectedText = "";
            this.UsernameText.ShadowDecoration.Parent = this.UsernameText;
            this.UsernameText.Size = new System.Drawing.Size(315, 32);
            this.UsernameText.TabIndex = 1;
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
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoginButton.FillColor2 = System.Drawing.Color.Firebrick;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoverState.Parent = this.LoginButton;
            this.LoginButton.IndicateFocus = true;
            this.LoginButton.Location = new System.Drawing.Point(586, 291);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.ShadowDecoration.Parent = this.LoginButton;
            this.LoginButton.Size = new System.Drawing.Size(141, 32);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username.Location = new System.Drawing.Point(495, 107);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(89, 20);
            this.username.TabIndex = 4;
            this.username.Text = "Username*";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password.Location = new System.Drawing.Point(495, 194);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(84, 20);
            this.password.TabIndex = 5;
            this.password.Text = "Password*";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(749, 355);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(97, 13);
            this.PhoneNumber.TabIndex = 7;
            this.PhoneNumber.Text = "+213 674 75 94 80";
            // 
            // ComponyName
            // 
            this.ComponyName.AutoSize = true;
            this.ComponyName.Location = new System.Drawing.Point(458, 355);
            this.ComponyName.Name = "ComponyName";
            this.ComponyName.Size = new System.Drawing.Size(105, 13);
            this.ComponyName.TabIndex = 8;
            this.ComponyName.Text = "DotNet Solutions DZ";
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
            this.PasswordText.Location = new System.Drawing.Point(499, 227);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '\0';
            this.PasswordText.PlaceholderText = "";
            this.PasswordText.SelectedText = "";
            this.PasswordText.ShadowDecoration.Parent = this.PasswordText;
            this.PasswordText.Size = new System.Drawing.Size(315, 32);
            this.PasswordText.TabIndex = 10;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // LogoPic
            // 
            this.LogoPic.BackColor = System.Drawing.Color.Transparent;
            this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
            this.LogoPic.ImageRotate = 0F;
            this.LogoPic.Location = new System.Drawing.Point(586, 12);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.ShadowDecoration.Parent = this.LogoPic;
            this.LogoPic.Size = new System.Drawing.Size(133, 74);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 11;
            this.LogoPic.TabStop = false;
            this.LogoPic.UseTransparentBackground = true;
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FillColor = System.Drawing.Color.White;
            this.Close.ForeColor = System.Drawing.Color.Firebrick;
            this.Close.HoverState.Parent = this.Close;
            this.Close.IconColor = System.Drawing.Color.Firebrick;
            this.Close.Location = new System.Drawing.Point(820, 2);
            this.Close.Name = "Close";
            this.Close.ShadowDecoration.Parent = this.Close;
            this.Close.Size = new System.Drawing.Size(45, 29);
            this.Close.TabIndex = 24;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 377);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.LogoPic);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.ComponyName);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.GIF);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.GIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox GIF;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label ComponyName;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private Guna.UI2.WinForms.Guna2GradientButton LoginButton;
        private Guna.UI2.WinForms.Guna2TextBox UsernameText;
        private Guna.UI2.WinForms.Guna2TextBox PasswordText;
        private Guna.UI2.WinForms.Guna2PictureBox LogoPic;
        private Guna.UI2.WinForms.Guna2ControlBox Close;
    }
}