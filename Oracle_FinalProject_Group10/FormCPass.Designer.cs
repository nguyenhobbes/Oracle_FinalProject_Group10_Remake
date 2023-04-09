namespace Oracle_FinalProject_Group10
{
    partial class FormCPass
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
            System.Windows.Forms.Label labelType;
            System.Windows.Forms.Label labelPass;
            System.Windows.Forms.Label labelName;
            System.Windows.Forms.Label label1;
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.reEnter = new System.Windows.Forms.TextBox();
            labelType = new System.Windows.Forms.Label();
            labelPass = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelType.Location = new System.Drawing.Point(565, 25);
            labelType.Name = "labelType";
            labelType.Size = new System.Drawing.Size(77, 32);
            labelType.TabIndex = 9;
            labelType.Text = "Type";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPass.Location = new System.Drawing.Point(63, 138);
            labelPass.Name = "labelPass";
            labelPass.Size = new System.Drawing.Size(201, 32);
            labelPass.TabIndex = 7;
            labelPass.Text = "New Password";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelName.Location = new System.Drawing.Point(63, 38);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(89, 32);
            labelName.TabIndex = 8;
            labelName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(63, 236);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(255, 32);
            label1.TabIndex = 14;
            label1.Text = "Re-enter Password";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(618, 383);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(170, 55);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "Return to Main Menu";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(69, 371);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(132, 37);
            this.buttonChange.TabIndex = 13;
            this.buttonChange.Text = "CHANGE";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // Type
            // 
            this.Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Items.AddRange(new object[] {
            "USER",
            "ROLE"});
            this.Type.Location = new System.Drawing.Point(571, 73);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 39);
            this.Type.TabIndex = 12;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(69, 173);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(368, 38);
            this.Password.TabIndex = 11;
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(69, 73);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(368, 38);
            this.UserName.TabIndex = 10;
            // 
            // reEnter
            // 
            this.reEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnter.Location = new System.Drawing.Point(69, 271);
            this.reEnter.Name = "reEnter";
            this.reEnter.PasswordChar = '*';
            this.reEnter.Size = new System.Drawing.Size(368, 38);
            this.reEnter.TabIndex = 15;
            // 
            // FormCPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reEnter);
            this.Controls.Add(label1);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(labelType);
            this.Controls.Add(labelPass);
            this.Controls.Add(labelName);
            this.Controls.Add(this.buttonReturn);
            this.Name = "FormCPass";
            this.Text = "FormCPass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCPass_FormClosing);
            this.Load += new System.EventHandler(this.FormCPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox reEnter;
    }
}