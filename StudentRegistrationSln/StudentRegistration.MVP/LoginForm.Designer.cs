namespace StudentRegistration.MVP
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(116, 103);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(79, 15);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(116, 160);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(79, 15);
            this.password.TabIndex = 1;
            this.password.Text = "Password:";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(210, 100);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(204, 25);
            this.txt_user.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(210, 160);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(204, 25);
            this.txt_pass.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 420);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_pass;
    }
}