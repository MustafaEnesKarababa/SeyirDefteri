using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeyirDefteri.Core
{
    public class Gonderim
    {
        public int GonderimId { get; set; }
        public SeyirKaydi SeyirKayitları { get; set; }
        public Urun Urunler { get; set; }
        public decimal  Tonaj { get; set; }
        public IlgilenenKisi IlgilenenKisiler { get; set; }
        public override string ToString()
        {
            return $"{SeyirKayitları.Gemi.GemiAdi} - {SeyirKayitları.LimandanCikisTarihi:d} - {SeyirKayitları.LimanaVarisTarihi:d} - {Urunler.UrunAdi} - {IlgilenenKisiler.BagliOlduguFirma.FirmaAdi} - {Tonaj}";
        }
    }
}
