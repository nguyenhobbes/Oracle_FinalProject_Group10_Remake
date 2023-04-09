namespace Oracle_FinalProject_Group10
{
    partial class FormRevoke
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label labelType;
            System.Windows.Forms.Label labelName;
            System.Windows.Forms.Label labelPass;
            this.buttonReturn = new System.Windows.Forms.Button();
            this.Privilege = new System.Windows.Forms.ComboBox();
            this.buttonRevoke = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.tableName = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            labelType = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            labelPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(579, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 32);
            label1.TabIndex = 39;
            label1.Text = "Privilege";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelType.Location = new System.Drawing.Point(402, 40);
            labelType.Name = "labelType";
            labelType.Size = new System.Drawing.Size(77, 32);
            labelType.TabIndex = 31;
            labelType.Text = "Type";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelName.Location = new System.Drawing.Point(62, 40);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(211, 32);
            labelName.TabIndex = 30;
            labelName.Text = "Username/Role";
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
            // Privilege
            // 
            this.Privilege.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Privilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Privilege.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "DELETE",
            "UPDATE"});
            this.Privilege.Location = new System.Drawing.Point(585, 75);
            this.Privilege.Name = "Privilege";
            this.Privilege.Size = new System.Drawing.Size(153, 39);
            this.Privilege.TabIndex = 40;
            // 
            // buttonRevoke
            // 
            this.buttonRevoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevoke.Location = new System.Drawing.Point(68, 373);
            this.buttonRevoke.Name = "buttonRevoke";
            this.buttonRevoke.Size = new System.Drawing.Size(132, 37);
            this.buttonRevoke.TabIndex = 34;
            this.buttonRevoke.Text = "REVOKE";
            this.buttonRevoke.UseVisualStyleBackColor = true;
            this.buttonRevoke.Click += new System.EventHandler(this.buttonRevoke_Click);
            // 
            // Type
            // 
            this.Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Items.AddRange(new object[] {
            "USER",
            "ROLE"});
            this.Type.Location = new System.Drawing.Point(408, 75);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 39);
            this.Type.TabIndex = 33;
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(68, 75);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(298, 38);
            this.UserName.TabIndex = 32;
            // 
            // tableName
            // 
            this.tableName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableName.Items.AddRange(new object[] {
            "NHANVIEN",
            "DEAN",
            "PHANCONG",
            "PHONGBAN"});
            this.tableName.Location = new System.Drawing.Point(68, 217);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(298, 39);
            this.tableName.TabIndex = 42;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPass.Location = new System.Drawing.Point(62, 182);
            labelPass.Name = "labelPass";
            labelPass.Size = new System.Drawing.Size(86, 32);
            labelPass.TabIndex = 41;
            labelPass.Text = "Table";
            // 
            // FormRevoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableName);
            this.Controls.Add(labelPass);
            this.Controls.Add(this.Privilege);
            this.Controls.Add(label1);
            this.Controls.Add(this.buttonRevoke);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.UserName);
            this.Controls.Add(labelType);
            this.Controls.Add(labelName);
            this.Controls.Add(this.buttonReturn);
            this.Name = "FormRevoke";
            this.Text = "FormRevoke";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRevoke_FormClosing);
            this.Load += new System.EventHandler(this.FormRevoke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ComboBox Privilege;
        private System.Windows.Forms.Button buttonRevoke;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.ComboBox tableName;
    }
}