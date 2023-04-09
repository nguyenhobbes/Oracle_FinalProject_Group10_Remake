namespace Oracle_FinalProject_Group10
{
    partial class FormGrant
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
            this.labelColumn = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonGrant = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.tableName = new System.Windows.Forms.ComboBox();
            this.columnName = new System.Windows.Forms.ComboBox();
            this.withGrant = new System.Windows.Forms.CheckBox();
            this.Privilege = new System.Windows.Forms.ComboBox();
            this.columnCheck = new System.Windows.Forms.CheckBox();
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
            labelType.Location = new System.Drawing.Point(426, 47);
            labelType.Name = "labelType";
            labelType.Size = new System.Drawing.Size(77, 32);
            labelType.TabIndex = 18;
            labelType.Text = "Type";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPass.Location = new System.Drawing.Point(86, 180);
            labelPass.Name = "labelPass";
            labelPass.Size = new System.Drawing.Size(86, 32);
            labelPass.TabIndex = 16;
            labelPass.Text = "Table";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelName.Location = new System.Drawing.Point(86, 47);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(211, 32);
            labelName.TabIndex = 17;
            labelName.Text = "Username/Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(603, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 32);
            label1.TabIndex = 27;
            label1.Text = "Privilege";
            // 
            // labelColumn
            // 
            this.labelColumn.AutoSize = true;
            this.labelColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumn.Location = new System.Drawing.Point(458, 180);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(112, 32);
            this.labelColumn.TabIndex = 23;
            this.labelColumn.Text = "Column";
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
            // buttonGrant
            // 
            this.buttonGrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrant.Location = new System.Drawing.Point(92, 380);
            this.buttonGrant.Name = "buttonGrant";
            this.buttonGrant.Size = new System.Drawing.Size(132, 37);
            this.buttonGrant.TabIndex = 22;
            this.buttonGrant.Text = "GRANT";
            this.buttonGrant.UseVisualStyleBackColor = true;
            this.buttonGrant.Click += new System.EventHandler(this.buttonGrant_Click);
            // 
            // Type
            // 
            this.Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Items.AddRange(new object[] {
            "USER",
            "ROLE"});
            this.Type.Location = new System.Drawing.Point(432, 82);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 39);
            this.Type.TabIndex = 21;
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(92, 82);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(298, 38);
            this.UserName.TabIndex = 19;
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
            this.tableName.Location = new System.Drawing.Point(92, 215);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(298, 39);
            this.tableName.TabIndex = 24;
            this.tableName.SelectedIndexChanged += new System.EventHandler(this.tableName_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.columnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnName.Location = new System.Drawing.Point(464, 215);
            this.columnName.Name = "columnName";
            this.columnName.Size = new System.Drawing.Size(298, 39);
            this.columnName.TabIndex = 25;
            // 
            // withGrant
            // 
            this.withGrant.AutoSize = true;
            this.withGrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withGrant.Location = new System.Drawing.Point(92, 314);
            this.withGrant.Name = "withGrant";
            this.withGrant.Size = new System.Drawing.Size(242, 29);
            this.withGrant.TabIndex = 26;
            this.withGrant.Text = "WITH GRANT OPTION";
            this.withGrant.UseVisualStyleBackColor = true;
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
            this.Privilege.Location = new System.Drawing.Point(609, 82);
            this.Privilege.Name = "Privilege";
            this.Privilege.Size = new System.Drawing.Size(153, 39);
            this.Privilege.TabIndex = 28;
            this.Privilege.SelectedIndexChanged += new System.EventHandler(this.Privilege_SelectedIndexChanged);
            // 
            // columnCheck
            // 
            this.columnCheck.AutoSize = true;
            this.columnCheck.Location = new System.Drawing.Point(434, 194);
            this.columnCheck.Name = "columnCheck";
            this.columnCheck.Size = new System.Drawing.Size(18, 17);
            this.columnCheck.TabIndex = 29;
            this.columnCheck.UseVisualStyleBackColor = true;
            this.columnCheck.CheckedChanged += new System.EventHandler(this.columnCheck_CheckedChanged);
            // 
            // FormGrant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.columnCheck);
            this.Controls.Add(this.Privilege);
            this.Controls.Add(label1);
            this.Controls.Add(this.withGrant);
            this.Controls.Add(this.columnName);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.labelColumn);
            this.Controls.Add(this.buttonGrant);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.UserName);
            this.Controls.Add(labelType);
            this.Controls.Add(labelPass);
            this.Controls.Add(labelName);
            this.Controls.Add(this.buttonReturn);
            this.Name = "FormGrant";
            this.Text = "FormGrant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGrant_FormClosing);
            this.Load += new System.EventHandler(this.FormGrant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonGrant;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.ComboBox tableName;
        private System.Windows.Forms.ComboBox columnName;
        private System.Windows.Forms.CheckBox withGrant;
        private System.Windows.Forms.ComboBox Privilege;
        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.CheckBox columnCheck;
    }
}