namespace Kalender2
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(350, 219);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(75, 23);
            this.Login_button.TabIndex = 0;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Email
            // 
            this.Email.AcceptsReturn = true;
            this.Email.Location = new System.Drawing.Point(275, 167);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(229, 20);
            this.Email.TabIndex = 1;
            this.Email.Text = "E-Mail";
            this.Email.Enter += new System.EventHandler(this.E_Mail_focus);
            this.Email.Leave += new System.EventHandler(this.E_Mail_focus);
            // 
            // Password
            // 
            this.Password.AcceptsReturn = true;
            this.Password.Location = new System.Drawing.Point(275, 193);
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
            this.New_user.Location = new System.Drawing.Point(672, 413);
            this.New_user.Name = "New_user";
            this.New_user.Size = new System.Drawing.Size(120, 30);
            this.New_user.TabIndex = 3;
            this.New_user.Text = "Make account";
            this.New_user.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.New_user.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.New_user);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Login_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button New_user;
    }
}

