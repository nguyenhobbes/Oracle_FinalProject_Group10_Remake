namespace Oracle_FinalProject_Group10
{
    partial class NhanVien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.ShowCBB = new System.Windows.Forms.ComboBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            labelType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(854, 243);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonShow
            // 
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.Location = new System.Drawing.Point(588, 71);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(96, 37);
            this.buttonShow.TabIndex = 9;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelType.Location = new System.Drawing.Point(21, 36);
            labelType.Name = "labelType";
            labelType.Size = new System.Drawing.Size(77, 32);
            labelType.TabIndex = 8;
            labelType.Text = "Type";
            // 
            // ShowCBB
            // 
            this.ShowCBB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCBB.FormattingEnabled = true;
            this.ShowCBB.Items.AddRange(new object[] {
            "TABLE NHANVIEN",
            "TABLE PHANCONG"});
            this.ShowCBB.Location = new System.Drawing.Point(27, 71);
            this.ShowCBB.Name = "ShowCBB";
            this.ShowCBB.Size = new System.Drawing.Size(499, 33);
            this.ShowCBB.TabIndex = 7;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(711, 429);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(170, 55);
            this.buttonReturn.TabIndex = 10;
            this.buttonReturn.Text = "Return to Main Menu";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 510);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(labelType);
            this.Controls.Add(this.ShowCBB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhanVien_FormClosing);
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.ComboBox ShowCBB;
        private System.Windows.Forms.Button buttonReturn;
    }
}