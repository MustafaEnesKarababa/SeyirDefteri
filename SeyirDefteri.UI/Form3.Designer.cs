namespace SeyirDefteri.UI
{
    partial class Form3
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

            this.listView1 = new System.Windows.Forms.ListView();
            this.columnGemiAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCikisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVarisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTarihAraligi = new System.Windows.Forms.Label();
            this.btnTarihFiltrele = new System.Windows.Forms.Button();
            this.cbGemiSec = new System.Windows.Forms.ComboBox();
            this.lblGemiSec = new System.Windows.Forms.Label();
            this.lblSeferSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFirmaSec = new System.Windows.Forms.ComboBox();
            this.columnIlgiliKisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIlgılıFirma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUrun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnGemiAdi,
            this.columnCikisTarihi,
            this.columnVarisTarihi,
            this.columnIlgiliKisi,
            this.columnIlgılıFirma,
            this.columnUrun});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(760, 360);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnGemiAdi
            // 
            this.columnGemiAdi.Text = "Gemi Adı";
            this.columnGemiAdi.Width = 120;
            // 
            // columnCikisTarihi
            // 
            this.columnCikisTarihi.Text = "Çıkış Tarihi";
            this.columnCikisTarihi.Width = 120;
            // 
            // columnVarisTarihi
            // 
            this.columnVarisTarihi.Text = "Varış Tarihi";
            this.columnVarisTarihi.Width = 120;
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(200, 70);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpBaslangicTarihi.TabIndex = 1;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(410, 70);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpBitisTarihi.TabIndex = 2;
            // 
            // lblTarihAraligi
            // 
            this.lblTarihAraligi.AutoSize = true;
            this.lblTarihAraligi.Location = new System.Drawing.Point(70, 75);
            this.lblTarihAraligi.Name = "lblTarihAraligi";
            this.lblTarihAraligi.Size = new System.Drawing.Size(108, 13);
            this.lblTarihAraligi.TabIndex = 3;
            this.lblTarihAraligi.Text = "Tarihler Arasında Ara:";
            // 
            // btnTarihFiltrele
            // 
            this.btnTarihFiltrele.Location = new System.Drawing.Point(620, 67);
            this.btnTarihFiltrele.Name = "btnTarihFiltrele";
            this.btnTarihFiltrele.Size = new System.Drawing.Size(75, 23);
            this.btnTarihFiltrele.TabIndex = 4;
            this.btnTarihFiltrele.Text = "Uygula";
            this.btnTarihFiltrele.UseVisualStyleBackColor = true;
            this.btnTarihFiltrele.Click += new System.EventHandler(this.btnTarihFiltrele_Click);
            // 
            // cbGemiSec
            // 
            this.cbGemiSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGemiSec.FormattingEnabled = true;
            this.cbGemiSec.Location = new System.Drawing.Point(150, 30);
            this.cbGemiSec.Name = "cbGemiSec";
            this.cbGemiSec.Size = new System.Drawing.Size(200, 21);
            this.cbGemiSec.TabIndex = 5;
            this.cbGemiSec.SelectedIndexChanged += new System.EventHandler(this.cbGemiSec_SelectedIndexChanged);
            // 
            // lblGemiSec
            // 
            this.lblGemiSec.AutoSize = true;
            this.lblGemiSec.Location = new System.Drawing.Point(20, 33);
            this.lblGemiSec.Name = "lblGemiSec";
            this.lblGemiSec.Size = new System.Drawing.Size(56, 13);
            this.lblGemiSec.TabIndex = 6;
            this.lblGemiSec.Text = "Gemi Seç:";
            // 
            // lblSeferSayisi
            // 
            this.lblSeferSayisi.AutoSize = true;
            this.lblSeferSayisi.Location = new System.Drawing.Point(20, 480);
            this.lblSeferSayisi.Name = "lblSeferSayisi";
            this.lblSeferSayisi.Size = new System.Drawing.Size(65, 13);
            this.lblSeferSayisi.TabIndex = 7;
            this.lblSeferSayisi.Text = "Sefer Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Firma Seç:";
            // 
            // cbFirmaSec
            // 
            this.cbFirmaSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirmaSec.FormattingEnabled = true;
            this.cbFirmaSec.Location = new System.Drawing.Point(530, 30);
            this.cbFirmaSec.Name = "cbFirmaSec";
            this.cbFirmaSec.Size = new System.Drawing.Size(200, 21);
            this.cbFirmaSec.TabIndex = 8;
            // 
            // columnIlgiliKisi
            // 
            this.columnIlgiliKisi.Text = "Sorumlu Kişi";
            this.columnIlgiliKisi.Width = 104;
            // 
            // columnIlgılıFirma
            // 
            this.columnIlgılıFirma.Text = "Ürün Gönderen Firma";
            this.columnIlgılıFirma.Width = 177;
            // 
            // columnUrun
            // 
            this.columnUrun.Text = "Taşınan Ürün";
            this.columnUrun.Width = 112;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFirmaSec);
            this.Controls.Add(this.lblSeferSayisi);
            this.Controls.Add(this.lblGemiSec);
            this.Controls.Add(this.cbGemiSec);
            this.Controls.Add(this.btnTarihFiltrele);
            this.Controls.Add(this.lblTarihAraligi);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.Text = "Rapor Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnGemiAdi;
        private System.Windows.Forms.ColumnHeader columnCikisTarihi;
        private System.Windows.Forms.ColumnHeader columnVarisTarihi;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label lblTarihAraligi;
        private System.Windows.Forms.Button btnTarihFiltrele;
        private System.Windows.Forms.ComboBox cbGemiSec;
        private System.Windows.Forms.Label lblGemiSec;
        private System.Windows.Forms.Label lblSeferSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFirmaSec;
        private System.Windows.Forms.ColumnHeader columnIlgiliKisi;
        private System.Windows.Forms.ColumnHeader columnIlgılıFirma;
        private System.Windows.Forms.ColumnHeader columnUrun;
    }
}
