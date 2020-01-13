namespace Kalender2
{
    partial class make_account
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
            this.nutzerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.create = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstname_create_label = new System.Windows.Forms.Label();
            this.lastname_create_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.passwd_crate_label = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Email_create_label = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.psswd_create_validate = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nutzerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(130, 134);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(151, 40);
            this.create.TabIndex = 0;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 1;
            // 
            // firstname_create_label
            // 
            this.firstname_create_label.AutoSize = true;
            this.firstname_create_label.Location = new System.Drawing.Point(6, 7);
            this.firstname_create_label.Name = "firstname_create_label";
            this.firstname_create_label.Size = new System.Drawing.Size(58, 13);
            this.firstname_create_label.TabIndex = 2;
            this.firstname_create_label.Text = "First name:";
            // 
            // lastname_create_label
            // 
            this.lastname_create_label.AutoSize = true;
            this.lastname_create_label.Location = new System.Drawing.Point(6, 33);
            this.lastname_create_label.Name = "lastname_create_label";
            this.lastname_create_label.Size = new System.Drawing.Size(59, 13);
            this.lastname_create_label.TabIndex = 4;
            this.lastname_create_label.Text = "Last name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 20);
            this.textBox2.TabIndex = 3;
            // 
            // passwd_crate_label
            // 
            this.passwd_crate_label.AutoSize = true;
            this.passwd_crate_label.Location = new System.Drawing.Point(6, 85);
            this.passwd_crate_label.Name = "passwd_crate_label";
            this.passwd_crate_label.Size = new System.Drawing.Size(56, 13);
            this.passwd_crate_label.TabIndex = 8;
            this.passwd_crate_label.Text = "Password:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(275, 20);
            this.textBox3.TabIndex = 7;
            // 
            // Email_create_label
            // 
            this.Email_create_label.AutoSize = true;
            this.Email_create_label.Location = new System.Drawing.Point(6, 59);
            this.Email_create_label.Name = "Email_create_label";
            this.Email_create_label.Size = new System.Drawing.Size(39, 13);
            this.Email_create_label.TabIndex = 6;
            this.Email_create_label.Text = "E-Mail:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(106, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(275, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // psswd_create_validate
            // 
            this.psswd_create_validate.AutoSize = true;
            this.psswd_create_validate.Location = new System.Drawing.Point(6, 111);
            this.psswd_create_validate.Name = "psswd_create_validate";
            this.psswd_create_validate.Size = new System.Drawing.Size(94, 13);
            this.psswd_create_validate.TabIndex = 10;
            this.psswd_create_validate.Text = "reenter_password:";
            this.psswd_create_validate.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(106, 108);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(275, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // make_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(390, 190);
            this.Controls.Add(this.psswd_create_validate);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.passwd_crate_label);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Email_create_label);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lastname_create_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.firstname_create_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.create);
            this.Name = "make_account";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.make_account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nutzerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.BindingSource nutzerBindingSource;
     
        
        
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label firstname_create_label;
        private System.Windows.Forms.Label lastname_create_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label passwd_crate_label;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Email_create_label;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label psswd_create_validate;
        private System.Windows.Forms.TextBox textBox5;
    }
}