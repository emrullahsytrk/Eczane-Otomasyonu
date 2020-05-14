using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBİS__GİRİŞ_PANELİ
{
    public partial class Ebis_İşlem_Paneli_Frm : Form
    {
        public Ebis_İşlem_Paneli_Frm()
        {
            InitializeComponent();
        }

        private void Ürün_Satis_Btn_Click(object sender, EventArgs e)
        {
            Ürün_Satıs_Paneli_Frm  ÜrünSatısForm = new Ürün_Satıs_Paneli_Frm(); // ürün satiş panelini çağırır
            ÜrünSatısForm.Show(); // ürün satış panelini gösterir
            this.Hide(); // önceki formu gizler
        }

        private void Gelen_Ürünler_Btn_Click(object sender, EventArgs e)
        {
            Gelen_Ürünler_Frm GelenÜrünlerForm = new Gelen_Ürünler_Frm();
            GelenÜrünlerForm.Show();
            this.Hide();
        }

        private void Ürün_Satis_Listesi_Btn_Click(object sender, EventArgs e)
        {
            Ürün_Satis_Listesi_Frm ÜrünSatışListesiForm = new Ürün_Satis_Listesi_Frm();
            ÜrünSatışListesiForm.Show();
            this.Hide();
        }

        private void Ürün_Detay_Btn_Click(object sender, EventArgs e)
        {
            Ürün_Detay_Frm ÜrünDetayForm = new Ürün_Detay_Frm();
            ÜrünDetayForm.Show();
            this.Hide();
        }

        private void Online_Fatura_Btn_Click(object sender, EventArgs e)
        {
            Online_Fatura_Frm OnlineFaturaForm = new Online_Fatura_Frm();
            OnlineFaturaForm.Show();
            this.Hide();
        }

        private void Medula_Btn_Click(object sender, EventArgs e)
        {
            Medula_Frm MedulaForm = new Medula_Frm();
            MedulaForm.Show();
            this.Hide();
        }

        private void Ebis_İşlem_Paneli_Frm_Load(object sender, EventArgs e)
        {

        }
    }
}
