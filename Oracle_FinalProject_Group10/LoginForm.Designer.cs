namespace Oracle_FinalProject_Group10
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
            System.Windows.Forms.Label pw;
            System.Windows.Forms.Label sv;
            System.Windows.Forms.Label sr;
            System.Windows.Forms.Label us;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.User = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ServerIP = new System.Windows.Forms.TextBox();
            this.Service = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Dba = new System.Windows.Forms.CheckBox();
            pw = new System.Windows.Forms.Label();
            sv = new System.Windows.Forms.Label();
            sr = new System.Windows.Forms.Label();
            us = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pw
            // 
            pw.AutoSize = true;
            pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pw.Location = new System.Drawing.Point(12, 106);
            pw.Name = "pw";
            pw.Size = new System.Drawing.Size(120, 29);
            pw.TabIndex = 5;
            pw.Text = "Password";
            // 
            // sv
            // 
            sv.AutoSize = true;
            sv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sv.Location = new System.Drawing.Point(12, 203);
            sv.Name = "sv";
            sv.Size = new System.Drawing.Size(191, 29);
            sv.TabIndex = 6;
            sv.Text = "Server name / IP";
            // 
            // sr
            // 
            sr.AutoSize = true;
            sr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sr.Location = new System.Drawing.Point(12, 303);
            sr.Name = "sr";
            sr.Size = new System.Drawing.Size(94, 29);
            sr.TabIndex = 7;
            sr.Text = "Service";
            // 
            // us
            // 
            us.AutoSize = true;
            us.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            us.Location = new System.Drawing.Point(12, 14);
            us.Name = "us";
            us.Size = new System.Drawing.Size(124, 29);
            us.TabIndex = 4;
            us.Text = "Username";
            // 
            // User
            // 
            this.User.CausesValidation = false;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(12, 46);
            this.User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(329, 38);
            this.User.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(12, 138);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(329, 38);
            this.Password.TabIndex = 1;
            // 
            // ServerIP
            // 
            this.ServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIP.Location = new System.Drawing.Point(12, 235);
            this.ServerIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(329, 38);
            this.ServerIP.TabIndex = 2;
            // 
            // Service
            // 
            this.Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service.Location = new System.Drawing.Point(12, 335);
            this.Service.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(169, 38);
            this.Service.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 156);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(401, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 69);
            this.label5.TabIndex = 9;
            this.label5.Text = "Group 10";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(513, 380);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(183, 39);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dba
            // 
            this.Dba.AutoSize = true;
            this.Dba.Location = new System.Drawing.Point(257, 350);
            this.Dba.Name = "Dba";
            this.Dba.Size = new System.Drawing.Size(84, 20);
            this.Dba.TabIndex = 12;
            this.Dba.Text = "SYSDBA";
            this.Dba.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 446);
            this.Controls.Add(this.Dba);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(sr);
            this.Controls.Add(sv);
            this.Controls.Add(pw);
            this.Controls.Add(us);
            this.Controls.Add(this.Service);
            this.Controls.Add(this.ServerIP);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox ServerIP;
        private System.Windows.Forms.TextBox Service;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.CheckBox Dba;
    }
}