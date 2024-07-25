using SeyirDefteri.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyirDefteri.UI
{
    public partial class Form3 : Form
    {
        private List<Gonderim> gonderimler;

        public Form3(List<Gonderim> gonderimler)
        {
            InitializeComponent();
            this.gonderimler = gonderimler;
            ComboxGemileriDoldur();
            ComboboxFirmalariDoldur();
            ListViewDoldur(gonderimler);
        }

        private void cbGemiSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewFiltrele();
        }

        private void btnTarihFiltrele_Click(object sender, EventArgs e)
        {
            ListViewFiltrele();
        }
        
        private void ListViewFiltrele()
        {
            List<Gonderim> filtrelenmisGonderimler = gonderimler.ToList();


            if (cbGemiSec.SelectedIndex != -1 && cbGemiSec.SelectedItem.ToString() != "Tümü") 
            {
                string secilenGemiAdi = cbGemiSec.SelectedItem.ToString();
                filtrelenmisGonderimler = filtrelenmisGonderimler.Where(g => g.SeyirKayitları.Gemi.GemiAdi == secilenGemiAdi)
                    .ToList();
            }

            if (cbFirmaSec.SelectedIndex != -1 && cbFirmaSec.SelectedItem.ToString() != "Tümü")
            {
                string secilenFirmaAdi = cbFirmaSec.SelectedItem.ToString();
                filtrelenmisGonderimler = filtrelenmisGonderimler.Where(a => a.IlgilenenKisiler.BagliOlduguFirma.FirmaAdi == secilenFirmaAdi)
                    .ToList();
            }

            if (dtpBaslangicTarihi.Value <= dtpBitisTarihi.Value)
            {
                DateTime baslangicTarihi = dtpBaslangicTarihi.Value;
                DateTime bitisTarihi = dtpBitisTarihi.Value;
                filtrelenmisGonderimler = filtrelenmisGonderimler
                    .Where(g => g.SeyirKayitları.LimandanCikisTarihi >= baslangicTarihi && g.SeyirKayitları.LimanaVarisTarihi <= bitisTarihi)
                    .ToList();
            }
            else
            {
                MessageBox.Show("Tarihleri mantıklı giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ListViewDoldur(filtrelenmisGonderimler);
        }



        private void ComboxGemileriDoldur()
        {
            List<string> gemiAdlari = gonderimler.Select(g => g.SeyirKayitları.Gemi.GemiAdi).Distinct().ToList(); //distinct -> tekrar etmemesi için
            cbGemiSec.Items.Add("Tümü");
            cbGemiSec.Items.AddRange(gemiAdlari.ToArray());
            cbGemiSec.SelectedIndex = 0;
        }
        private void ComboboxFirmalariDoldur()
        {
            List<string> firmaAdlari = gonderimler.Select(x => x.IlgilenenKisiler.BagliOlduguFirma.FirmaAdi).Distinct().ToList();
            cbFirmaSec.Items.Add("Tümü");
            cbFirmaSec.Items.AddRange(firmaAdlari.ToArray());
            cbFirmaSec.SelectedIndex = 0;   
        }

        private void ListViewDoldur(List<Gonderim> gonderimler)
        {

            listView1.Items.Clear();


            foreach (Gonderim gonderim in gonderimler)
            {

                ListViewItem item = new ListViewItem(); // her bir satır


                item.Text = gonderim.SeyirKayitları.Gemi.GemiAdi;

                item.SubItems.Add(gonderim.SeyirKayitları.LimandanCikisTarihi.ToString("dd.MM.yyyy"));
                item.SubItems.Add(gonderim.SeyirKayitları.LimanaVarisTarihi.ToString("dd.MM.yyyy"));

                item.SubItems.Add(gonderim.IlgilenenKisiler.KisininAdi);
                item.SubItems.Add(gonderim.IlgilenenKisiler.BagliOlduguFirma.FirmaAdi);
                item.SubItems.Add(gonderim.Urunler.UrunAdi);    


                listView1.Items.Add(item);
            }

            lblSeferSayisi.Text = $"Sefer Sayısı: {gonderimler.Count}";
        }

    }
}






