using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplik
{
    internal class Kitaplar
    {

        int id;
        string kitapAdi;
        string yazar;
        string sayfaSayısı;
        string tür;
        DateTime basimTarih;
        bool cilt;

       

        public int Id { get => id; set => id = value; }
        public string KitapAdı { get => kitapAdi; set => kitapAdi = value; }
        public string Yazar { get => yazar; set => yazar = value; }
        public string SayfaSayısı { get => sayfaSayısı; set => sayfaSayısı = value; }
        public string Tür { get => tür; set => tür = value; }
        public DateTime BasimTarih { get => basimTarih; set => basimTarih = value; }
        public bool Cilt { get => cilt; set => cilt = value; }

        public Kitaplar(int id, string kitapAdı, string yazar, string sayfaSayısı, string tür, DateTime basimTarih, bool cilt)
        {
            this.id = id;
            this.kitapAdi = kitapAdı;
            this.yazar = yazar;
            this.sayfaSayısı = sayfaSayısı;
            this.tür = tür;
            this.basimTarih = basimTarih;
            this.cilt = cilt;
        }

    }
}
