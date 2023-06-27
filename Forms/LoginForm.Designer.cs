
namespace Restaurant_MS_POS
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.username_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.exit_button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // username_txtbox
            // 
            this.username_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_txtbox.DefaultText = "";
            this.username_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_txtbox.Location = new System.Drawing.Point(32, 256);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.PasswordChar = '\0';
            this.username_txtbox.PlaceholderText = "";
            this.username_txtbox.SelectedText = "";
            this.username_txtbox.Size = new System.Drawing.Size(200, 36);
            this.username_txtbox.TabIndex = 0;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_txtbox.DefaultText = "";
            this.password_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_txtbox.Location = new System.Drawing.Point(32, 336);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '●';
            this.password_txtbox.PlaceholderText = "";
            this.password_txtbox.SelectedText = "";
            this.password_txtbox.Size = new System.Drawing.Size(200, 36);
            this.password_txtbox.TabIndex = 1;
            this.password_txtbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // login_button
            // 
            this.login_button.AutoRoundedCorners = true;
            this.login_button.BorderRadius = 21;
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.FillColor = System.Drawing.Color.SeaGreen;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(32, 401);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(91, 45);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.AutoRoundedCorners = true;
            this.exit_button.BorderRadius = 21;
            this.exit_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exit_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exit_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exit_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exit_button.FillColor = System.Drawing.Color.DarkRed;
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Location = new System.Drawing.Point(141, 401);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(91, 45);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Exit";
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox1.Image = global::Restaurant_MS_POS.Properties.Resources.logo1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(264, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "RMS";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog1.Text = null;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 500);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox username_txtbox;
        private Guna.UI2.WinForms.Guna2TextBox password_txtbox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button login_button;
        private Guna.UI2.WinForms.Guna2Button exit_button;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
    }
}

