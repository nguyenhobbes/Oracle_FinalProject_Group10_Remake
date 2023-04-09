namespace Oracle_FinalProject_Group10
{
    partial class FormAdd
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
            System.Windows.Forms.Label labelName;
            System.Windows.Forms.Label labelPass;
            System.Windows.Forms.Label labelType;
            this.buttonReturn = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.buttonADD = new System.Windows.Forms.Button();
            labelName = new System.Windows.Forms.Label();
            labelPass = new System.Windows.Forms.Label();
            labelType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelName.Location = new System.Drawing.Point(110, 74);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(89, 32);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPass.Location = new System.Drawing.Point(110, 192);
            labelPass.Name = "labelPass";
            labelPass.Size = new System.Drawing.Size(138, 32);
            labelPass.TabIndex = 1;
            labelPass.Text = "Password";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelType.Location = new System.Drawing.Point(589, 74);
            labelType.Name = "labelType";
            labelType.Size = new System.Drawing.Size(77, 32);
            labelType.TabIndex = 2;
            labelType.Text = "Type";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(618, 383);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(170, 55);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "Return to Main Menu";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(116, 122);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(368, 38);
            this.UserName.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(116, 251);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(368, 38);
            this.Password.TabIndex = 4;
            // 
            // Type
            // 
            this.Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Items.AddRange(new object[] {
            "USER",
            "ROLE"});
            this.Type.Location = new System.Drawing.Point(595, 122);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 39);
            this.Type.TabIndex = 5;
            // 
            // buttonADD
            // 
            this.buttonADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADD.Location = new System.Drawing.Point(116, 348);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(132, 37);
            this.buttonADD.TabIndex = 6;
            this.buttonADD.Text = "ADD";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(labelType);
            this.Controls.Add(labelPass);
            this.Controls.Add(labelName);
            this.Controls.Add(this.buttonReturn);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdd_FormClosing);
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Button buttonADD;
    }
}