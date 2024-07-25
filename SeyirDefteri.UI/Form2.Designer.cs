namespace SeyirDefteri.UI
{
    partial class Form2
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
            this.cmbSeferler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIlgilenenKisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmdTonaj = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmnFirma = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtIlgilenenKisiTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lstVGonderim = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnZRaporu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pbGemiler = new System.Windows.Forms.PictureBox();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nmdTonaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGemiler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seferler:";
            // 
            // cmbSeferler
            // 
            this.cmbSeferler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeferler.FormattingEnabled = true;
            this.cmbSeferler.Location = new System.Drawing.Point(196, 48);
            this.cmbSeferler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSeferler.Name = "cmbSeferler";
            this.cmbSeferler.Size = new System.Drawing.Size(278, 24);
            this.cmbSeferler.TabIndex = 1;
            this.cmbSeferler.SelectedIndexChanged += new System.EventHandler(this.cmbSeferler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün:";
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(196, 78);
            this.txtUrun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(278, 23);
            this.txtUrun.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tonaj:";
            // 
            // txtIlgilenenKisi
            // 
            this.txtIlgilenenKisi.Location = new System.Drawing.Point(196, 171);
            this.txtIlgilenenKisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIlgilenenKisi.Name = "txtIlgilenenKisi";
            this.txtIlgilenenKisi.Size = new System.Drawing.Size(278, 23);
            this.txtIlgilenenKisi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "İlgilenen Kişi:";
            // 
            // nmdTonaj
            // 
            this.nmdTonaj.Location = new System.Drawing.Point(198, 109);
            this.nmdTonaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmdTonaj.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nmdTonaj.Name = "nmdTonaj";
            this.nmdTonaj.Size = new System.Drawing.Size(276, 23);
            this.nmdTonaj.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "İlgilenen Kişi Telefonu:";
            // 
            // cmnFirma
            // 
            this.cmnFirma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmnFirma.FormattingEnabled = true;
            this.cmnFirma.Location = new System.Drawing.Point(196, 138);
            this.cmnFirma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmnFirma.Name = "cmnFirma";
            this.cmnFirma.Size = new System.Drawing.Size(278, 24);
            this.cmnFirma.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Firma:";
            // 
            // mtxtIlgilenenKisiTelefon
            // 
            this.mtxtIlgilenenKisiTelefon.Location = new System.Drawing.Point(196, 207);
            this.mtxtIlgilenenKisiTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtIlgilenenKisiTelefon.Mask = "(999) 000-0000";
            this.mtxtIlgilenenKisiTelefon.Name = "mtxtIlgilenenKisiTelefon";
            this.mtxtIlgilenenKisiTelefon.Size = new System.Drawing.Size(278, 23);
            this.mtxtIlgilenenKisiTelefon.TabIndex = 12;
            // 
            // lstVGonderim
            // 
            this.lstVGonderim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lstVGonderim.GridLines = true;
            this.lstVGonderim.HideSelection = false;
            this.lstVGonderim.Location = new System.Drawing.Point(42, 282);
            this.lstVGonderim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstVGonderim.Name = "lstVGonderim";
            this.lstVGonderim.Size = new System.Drawing.Size(839, 190);
            this.lstVGonderim.TabIndex = 13;
            this.lstVGonderim.UseCompatibleStateImageBehavior = false;
            this.lstVGonderim.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tonaj";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ürün";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Firma";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Kişi Adı";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "İletişim";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 120;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(346, 234);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(128, 29);
            this.btnUrunEkle.TabIndex = 14;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnZRaporu
            // 
            this.btnZRaporu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnZRaporu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZRaporu.Location = new System.Drawing.Point(43, 476);
            this.btnZRaporu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZRaporu.Name = "btnZRaporu";
            this.btnZRaporu.Size = new System.Drawing.Size(838, 34);
            this.btnZRaporu.TabIndex = 15;
            this.btnZRaporu.Text = "Z Raporu";
            this.btnZRaporu.UseVisualStyleBackColor = false;
            this.btnZRaporu.Click += new System.EventHandler(this.btnZRaporu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(238, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gemi Sefer Kayıt Ekranı";
            // 
            // pbGemiler
            // 
            this.pbGemiler.Location = new System.Drawing.Point(549, 51);
            this.pbGemiler.Name = "pbGemiler";
            this.pbGemiler.Size = new System.Drawing.Size(332, 215);
            this.pbGemiler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGemiler.TabIndex = 16;
            this.pbGemiler.TabStop = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gemi Adı";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 538);
            this.Controls.Add(this.pbGemiler);
            this.Controls.Add(this.btnZRaporu);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.lstVGonderim);
            this.Controls.Add(this.mtxtIlgilenenKisiTelefon);
            this.Controls.Add(this.cmnFirma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nmdTonaj);
            this.Controls.Add(this.txtIlgilenenKisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.cmbSeferler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmdTonaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGemiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSeferler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIlgilenenKisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmdTonaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmnFirma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtIlgilenenKisiTelefon;
        private System.Windows.Forms.ListView lstVGonderim;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnZRaporu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbGemiler;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}