namespace Oracle_FinalProject_Group10
{
    partial class MainForm
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
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonGrant = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRevoke = new System.Windows.Forms.Button();
            this.buttonCPass = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(65, 39);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(134, 65);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "SHOW";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(320, 39);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(134, 65);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(65, 158);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(134, 65);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonGrant
            // 
            this.buttonGrant.Location = new System.Drawing.Point(320, 158);
            this.buttonGrant.Name = "buttonGrant";
            this.buttonGrant.Size = new System.Drawing.Size(134, 65);
            this.buttonGrant.TabIndex = 1;
            this.buttonGrant.Text = "GRANT";
            this.buttonGrant.UseVisualStyleBackColor = true;
            this.buttonGrant.Click += new System.EventHandler(this.buttonGrant_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(65, 283);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(134, 65);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRevoke
            // 
            this.buttonRevoke.Location = new System.Drawing.Point(320, 283);
            this.buttonRevoke.Name = "buttonRevoke";
            this.buttonRevoke.Size = new System.Drawing.Size(134, 65);
            this.buttonRevoke.TabIndex = 1;
            this.buttonRevoke.Text = "REVOKE";
            this.buttonRevoke.UseVisualStyleBackColor = true;
            this.buttonRevoke.Click += new System.EventHandler(this.buttonRevoke_Click);
            // 
            // buttonCPass
            // 
            this.buttonCPass.Location = new System.Drawing.Point(65, 402);
            this.buttonCPass.Name = "buttonCPass";
            this.buttonCPass.Size = new System.Drawing.Size(134, 65);
            this.buttonCPass.TabIndex = 0;
            this.buttonCPass.Text = "CHANGE PASS";
            this.buttonCPass.UseVisualStyleBackColor = true;
            this.buttonCPass.Click += new System.EventHandler(this.buttonCPass_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(320, 402);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(134, 65);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "LOG OUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 494);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonCPass);
            this.Controls.Add(this.buttonGrant);
            this.Controls.Add(this.buttonRevoke);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonShow);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonGrant;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRevoke;
        private System.Windows.Forms.Button buttonCPass;
        private System.Windows.Forms.Button buttonLogout;
    }
}