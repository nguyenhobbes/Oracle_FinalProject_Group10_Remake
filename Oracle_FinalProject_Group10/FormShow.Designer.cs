namespace Oracle_FinalProject_Group10
{
    partial class FormShow
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
            this.buttonReturn = new System.Windows.Forms.Button();
            this.ShowCBB = new System.Windows.Forms.ComboBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            labelType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelType.Location = new System.Drawing.Point(75, 9);
            labelType.Name = "labelType";
            labelType.Size = new System.Drawing.Size(77, 32);
            labelType.TabIndex = 3;
            labelType.Text = "Type";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(724, 383);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(170, 55);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "Return to Main Menu";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // ShowCBB
            // 
            this.ShowCBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCBB.FormattingEnabled = true;
            this.ShowCBB.Items.AddRange(new object[] {
            "USER",
            "ROLE",
            "USER PRIVILEGES",
            "TABLE NHANVIEN PRIVILEGES",
            "COLUMN NHANVIEN PRIVILEGES",
            "TABLE DEAN PRIVILEGES",
            "COLUMN DEAN PRIVILEGES",
            "TABLE PHONGBAN PRIVILEGES",
            "COLUMN PHONGBAN PRIVILEGES",
            "TABLE PHANCONG PRIVILEGES",
            "COLUMN PHANCONG PRIVILEGES",
            "ROLE PRIVILEGES"});
            this.ShowCBB.Location = new System.Drawing.Point(81, 44);
            this.ShowCBB.Name = "ShowCBB";
            this.ShowCBB.Size = new System.Drawing.Size(499, 33);
            this.ShowCBB.TabIndex = 2;
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(642, 44);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(96, 37);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 264);
            this.dataGridView1.TabIndex = 5;
            // 
            // FormShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(labelType);
            this.Controls.Add(this.ShowCBB);
            this.Controls.Add(this.buttonReturn);
            this.Name = "FormShow";
            this.Text = "FormShow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormShow_FormClosing);
            this.Load += new System.EventHandler(this.FormShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ComboBox ShowCBB;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}