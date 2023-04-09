namespace Oracle_FinalProject_Group10
{
    partial class FormEdit
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
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonGrant = new System.Windows.Forms.Button();
            this.buttonRevoke = new System.Windows.Forms.Button();
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
            // buttonGrant
            // 
            this.buttonGrant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGrant.Location = new System.Drawing.Point(144, 157);
            this.buttonGrant.Name = "buttonGrant";
            this.buttonGrant.Size = new System.Drawing.Size(170, 91);
            this.buttonGrant.TabIndex = 2;
            this.buttonGrant.Text = "GRANT";
            this.buttonGrant.UseVisualStyleBackColor = true;
            this.buttonGrant.Click += new System.EventHandler(this.buttonGrant_Click);
            // 
            // buttonRevoke
            // 
            this.buttonRevoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRevoke.Location = new System.Drawing.Point(495, 157);
            this.buttonRevoke.Name = "buttonRevoke";
            this.buttonRevoke.Size = new System.Drawing.Size(170, 91);
            this.buttonRevoke.TabIndex = 2;
            this.buttonRevoke.Text = "REVOKE";
            this.buttonRevoke.UseVisualStyleBackColor = true;
            this.buttonRevoke.Click += new System.EventHandler(this.buttonRevoke_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRevoke);
            this.Controls.Add(this.buttonGrant);
            this.Controls.Add(this.buttonReturn);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEdit_FormClosing);
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonGrant;
        private System.Windows.Forms.Button buttonRevoke;
    }
}