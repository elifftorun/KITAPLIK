using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kitaplar kitap;

        List<Kitaplar> kitapListesi = new List<Kitaplar>();

        private void Form1_Load(object sender, EventArgs e)
        {

          kitapListesi.Add(new Kitaplar(1,"BRONZ", "Özge Naz", "446","Roman", new DateTime(2023, 3, 20), true));
          kitapListesi.Add(new Kitaplar(2, "Karantina " , "Beyza Alkoç", "448","Roman", new DateTime(2016, 1, 1), false));
          kitapListesi.Add(new Kitaplar(3, "Sokak Nöbetçileri", "Aslı Arslan", "720","Romantik", new DateTime(2020, 10, 17), true));
          kitapListesi.Add(new Kitaplar(4, "NO:26", "Beyza Alkoç", "480","Romantik", new DateTime(2021, 4, 1), true));
          kitapListesi.Add(new Kitaplar(5, "Küçük Prens", "Antoine de Saint-Exupéry", "112","Çocuk Kitapları", new DateTime(1943, 4, 6), true));
          kitapListesi.Add(new Kitaplar(6, "İntibah", "Namık Kemal", "248","Edebi Roman", new DateTime(1876,1,1), false));

            dgvListe.DataSource = kitapListesi.ToList();

        }

        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string kitapAdı = txtKitapAdı.Text;
            string yazar = txtYazar.Text;
            string sayfaSayısı = txtSayfa.Text;
            string tür = cmbTür.Text;
            DateTime tarih = dtpTarih.Value;
            bool cilt = chkCilt.Checked;

            Kitaplar yeniKitap = new Kitaplar(id, kitapAdı, yazar, sayfaSayısı, tür, tarih, cilt);

            kitapListesi.Add(yeniKitap);
            dgvListe.DataSource= kitapListesi.ToList();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];

            Kitaplar secilen = secilenSatir.DataBoundItem as Kitaplar;



            DialogResult result = MessageBox.Show("Seçilen kitap silinsin mi?", "Kitap Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                kitapListesi.Remove(secilen);
            }

            dgvListe.DataSource = kitapListesi.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];

           Kitaplar kitaplar = secilenSatir.DataBoundItem as Kitaplar;

            int id = Convert.ToInt32(txtId.Text);
            string kitapAdi = (txtKitapAdı.Text);
            string yazar = (txtYazar.Text);
            string sayfaSayısı = (txtSayfa.Text);
            string tür = (cmbTür.Text);
            DateTime tarih = (dtpTarih.Value);
            bool cilt=(chkCilt.Checked);

            kitaplar.Id = id;
            kitaplar.KitapAdı= kitapAdi;
            kitaplar.Yazar = yazar;
            kitaplar.SayfaSayısı = sayfaSayısı;
            kitaplar.Tür = tür;
            kitaplar.BasimTarih = tarih;
            kitaplar.Cilt= cilt;

            dgvListe.DataSource = null;
            dgvListe.DataSource = kitapListesi.ToList();


        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            txtKitapAdı.Text = dgvListe.CurrentRow.Cells["kitapAdı"].Value.ToString();
            txtSayfa.Text = dgvListe.CurrentRow.Cells["sayfaSayısı"].Value.ToString();
            txtYazar.Text = dgvListe.CurrentRow.Cells["yazar"].Value.ToString();
            cmbTür.Text = dgvListe.CurrentRow.Cells["tür"].Value.ToString();
            dtpTarih.Value = (DateTime)dgvListe.CurrentRow.Cells["basimTarih"].Value;
            chkCilt.Checked = (bool)dgvListe.CurrentRow.Cells["cilt"].Value;
        }
    }
}
