namespace Kalender2
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_button = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.New_user = new System.Windows.Forms.Button();
            this.Email_text = new System.Windows.Forms.Label();
            this.Passwd_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Location = new System.Drawing.Point(73, 82);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(84, 88);
            this.Login_button.TabIndex = 0;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Email
            // 
            this.Email.AcceptsReturn = true;
            this.Email.Location = new System.Drawing.Point(5, 20);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(229, 20);
            this.Email.TabIndex = 1;
            this.Email.Text = "E_Mail";
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            this.Email.Enter += new System.EventHandler(this.E_Mail_focus);
            this.Email.Leave += new System.EventHandler(this.E_Mail_focus);
            // 
            // Password
            // 
            this.Password.AcceptsReturn = true;
            this.Password.Location = new System.Drawing.Point(5, 56);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(228, 20);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            this.Password.TextChanged += new System.EventHandler(this.Password_secret);
            this.Password.Enter += new System.EventHandler(this.Password_field_focus);
            this.Password.Leave += new System.EventHandler(this.Password_field_focus);
            // 
            // New_user
            // 
            this.New_user.Location = new System.Drawing.Point(73, 176);
            this.New_user.Name = "New_user";
            this.New_user.Size = new System.Drawing.Size(84, 30);
            this.New_user.TabIndex = 3;
            this.New_user.Text = "Make account";
            this.New_user.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.New_user.UseVisualStyleBackColor = true;
            this.New_user.Click += new System.EventHandler(this.New_user_Click);
            // 
            // Email_text
            // 
            this.Email_text.AutoSize = true;
            this.Email_text.Location = new System.Drawing.Point(2, 4);
            this.Email_text.Name = "Email_text";
            this.Email_text.Size = new System.Drawing.Size(39, 13);
            this.Email_text.TabIndex = 4;
            this.Email_text.Text = "E-Mail:";
            this.Email_text.Click += new System.EventHandler(this.Email_text_Click);
            // 
            // Passwd_label
            // 
            this.Passwd_label.AutoSize = true;
            this.Passwd_label.Location = new System.Drawing.Point(2, 43);
            this.Passwd_label.Name = "Passwd_label";
            this.Passwd_label.Size = new System.Drawing.Size(56, 13);
            this.Passwd_label.TabIndex = 5;
            this.Passwd_label.Text = "Password:";
            this.Passwd_label.Click += new System.EventHandler(this.Passwd_label_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 212);
            this.Controls.Add(this.Passwd_label);
            this.Controls.Add(this.Email_text);
            this.Controls.Add(this.New_user);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Login_button);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button New_user;
        private System.Windows.Forms.Label Email_text;
        private System.Windows.Forms.Label Passwd_label;
    }
}

