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
    public partial class Medula_Frm : Form
    {
        public Medula_Frm()
        {
            InitializeComponent();
        }
        private void Manuel_Recete_Girisi_Btn_Medula_Click(object sender, EventArgs e)
        {
            Manuel_Recete_Girisi_Frm ManuelReceteGirisiFormu = new Manuel_Recete_Girisi_Frm(); // manuel reçete giriş formunu çağırır
            ManuelReceteGirisiFormu.Show();  // manuel reçete giriş formunu gösterir
            this.Hide();  // önceki formu gizler
        }

        private void Rapor_Görüntüleme_Btn_Medula_Click(object sender, EventArgs e)
        {
            Rapor_Görüntüleme_Frm RaporGörüntülemeFormu = new Rapor_Görüntüleme_Frm(); // rapor görüntüleme formunu çağırır
            RaporGörüntülemeFormu.Show();  // rapor görüntüleme formunu gösterir
            this.Hide();  // önceki formu gizler
        }

        private void Ürün_Görüntüleme_Btn_Medula_Click(object sender, EventArgs e)
        {
            Ürün_Görüntüleme_Frm ÜrünGörüntüleFormu = new Ürün_Görüntüleme_Frm(); // ürün görüntüleme formunu çağırır
            ÜrünGörüntüleFormu.Show();  // ürün görüntüleme formunu gösterir
            this.Hide();   // önceki formu gizler
        }

        private void GeriDön_Btn_Medula_Click(object sender, EventArgs e)
        {
            Ebis_İşlem_Paneli_Frm EbisİslemPaneliFormu = new Ebis_İşlem_Paneli_Frm(); // ebis işlem panelini çağırır
            EbisİslemPaneliFormu.Show(); // ebis işlem panelini gösterir
            this.Hide(); // önceki formu gizler
        }
    }
}
