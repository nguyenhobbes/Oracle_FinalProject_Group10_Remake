namespace Oracle_FinalProject_Group10
{
    partial class FormDelete
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
            System.Windows.Forms.Label labelName;
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.UserName = new System.Windows.Forms.TextBox();
            labelType = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(103, 217);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(132, 37);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Type
            // 
            this.Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Items.AddRange(new object[] {
            "USER",
            "ROLE"});
            this.Type.Location = new System.Drawing.Point(582, 118);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 39);
            this.Type.TabIndex = 12;
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(103, 118);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(368, 38);
            this.UserName.TabIndex = 10;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelType.Location = new System.Drawing.Point(576, 70);
            labelType.Name = "labelType";
            labelType.Size = new System.Drawing.Size(77, 32);
            labelType.TabIndex = 9;
            labelType.Text = "Type";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelName.Location = new System.Drawing.Point(97, 70);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(89, 32);
            labelName.TabIndex = 8;
            labelName.Text = "Name";
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.UserName);
            this.Controls.Add(labelType);
            this.Controls.Add(labelName);
            this.Controls.Add(this.buttonReturn);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDelete_FormClosing);
            this.Load += new System.EventHandler(this.FormDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.TextBox UserName;
    }
}