namespace SeyirDefteri.UI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGemi = new System.Windows.Forms.ComboBox();
            this.dtpLimanCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpLimanVarisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmnCikisLimani = new System.Windows.Forms.ComboBox();
            this.cmnUgradigiLimani = new System.Windows.Forms.ComboBox();
            this.cmnVarisLimani = new System.Windows.Forms.ComboBox();
            this.lstSeyirDefteri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGec = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limandan Çıkış Tarihi";
            // 
            // cmbGemi
            // 
            this.cmbGemi.FormattingEnabled = true;
            this.cmbGemi.Location = new System.Drawing.Point(219, 115);
            this.cmbGemi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGemi.Name = "cmbGemi";
            this.cmbGemi.Size = new System.Drawing.Size(402, 21);
            this.cmbGemi.TabIndex = 1;
            // 
            // dtpLimanCikisTarihi
            // 
            this.dtpLimanCikisTarihi.Location = new System.Drawing.Point(219, 50);
            this.dtpLimanCikisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpLimanCikisTarihi.Name = "dtpLimanCikisTarihi";
            this.dtpLimanCikisTarihi.Size = new System.Drawing.Size(400, 20);
            this.dtpLimanCikisTarihi.TabIndex = 2;
            // 
            // dtpLimanVarisTarihi
            // 
            this.dtpLimanVarisTarihi.Location = new System.Drawing.Point(219, 80);
            this.dtpLimanVarisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpLimanVarisTarihi.Name = "dtpLimanVarisTarihi";
            this.dtpLimanVarisTarihi.Size = new System.Drawing.Size(400, 20);
            this.dtpLimanVarisTarihi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Limana Varış Tarihi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gemi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Çıkış Limanı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Uğradığı Limanı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Varış Limanı";
            // 
            // cmnCikisLimani
            // 
            this.cmnCikisLimani.FormattingEnabled = true;
            this.cmnCikisLimani.Location = new System.Drawing.Point(219, 149);
            this.cmnCikisLimani.Margin = new System.Windows.Forms.Padding(2);
            this.cmnCikisLimani.Name = "cmnCikisLimani";
            this.cmnCikisLimani.Size = new System.Drawing.Size(402, 21);
            this.cmnCikisLimani.TabIndex = 9;
            // 
            // cmnUgradigiLimani
            // 
            this.cmnUgradigiLimani.FormattingEnabled = true;
            this.cmnUgradigiLimani.Location = new System.Drawing.Point(219, 180);
            this.cmnUgradigiLimani.Margin = new System.Windows.Forms.Padding(2);
            this.cmnUgradigiLimani.Name = "cmnUgradigiLimani";
            this.cmnUgradigiLimani.Size = new System.Drawing.Size(402, 21);
            this.cmnUgradigiLimani.TabIndex = 10;
            // 
            // cmnVarisLimani
            // 
            this.cmnVarisLimani.FormattingEnabled = true;
            this.cmnVarisLimani.Location = new System.Drawing.Point(219, 219);
            this.cmnVarisLimani.Margin = new System.Windows.Forms.Padding(2);
            this.cmnVarisLimani.Name = "cmnVarisLimani";
            this.cmnVarisLimani.Size = new System.Drawing.Size(402, 21);
            this.cmnVarisLimani.TabIndex = 11;
            // 
            // lstSeyirDefteri
            // 
            this.lstSeyirDefteri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstSeyirDefteri.HideSelection = false;
            this.lstSeyirDefteri.Location = new System.Drawing.Point(63, 291);
            this.lstSeyirDefteri.Name = "lstSeyirDefteri";
            this.lstSeyirDefteri.Size = new System.Drawing.Size(558, 210);
            this.lstSeyirDefteri.TabIndex = 12;
            this.lstSeyirDefteri.UseCompatibleStateImageBehavior = false;
            this.lstSeyirDefteri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Limandan Çıkış Tarihi";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Limana Varış Tarihi";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gemi";
            this.columnHeader4.Width = 71;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Çıkış Limanı";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Uğradığı Liman";
            this.columnHeader6.Width = 87;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Varış Limanı";
            this.columnHeader7.Width = 167;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(546, 255);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 30);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Seyir Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGec
            // 
            this.btnGec.Location = new System.Drawing.Point(63, 519);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(558, 30);
            this.btnGec.TabIndex = 14;
            this.btnGec.Text = ">>>>>>>>>>";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Seyir Defteri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 561);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGec);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSeyirDefteri);
            this.Controls.Add(this.cmnVarisLimani);
            this.Controls.Add(this.cmnUgradigiLimani);
            this.Controls.Add(this.cmnCikisLimani);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpLimanVarisTarihi);
            this.Controls.Add(this.dtpLimanCikisTarihi);
            this.Controls.Add(this.cmbGemi);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGemi;
        private System.Windows.Forms.DateTimePicker dtpLimanCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtpLimanVarisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmnCikisLimani;
        private System.Windows.Forms.ComboBox cmnUgradigiLimani;
        private System.Windows.Forms.ComboBox cmnVarisLimani;
        private System.Windows.Forms.ListView lstSeyirDefteri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

