using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EBİS__GİRİŞ_PANELİ
{
    public partial class Manuel_Recete_Girisi_Frm : Form
    {
        public Manuel_Recete_Girisi_Frm()
        {
            InitializeComponent();
        }

        private void GeriDön_Btn_ManuelReceteGirisi_Click(object sender, EventArgs e)
        {
            Medula_Frm MedulaFormu = new Medula_Frm(); // medula formunu çağırır
            MedulaFormu.Show(); // medula formunu gösterir
            this.Hide(); // önceki formu gizler
        }

        sqlbaglantı bgl = new sqlbaglantı();
        private void Kaydet_Btn_ManuelReceteGirisi_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_ManuelRecete (HastaTC,HastaAdıSoyadı,ReceteTarihi,TeslimAlanTC,TeslimAlanAdıSoyadı,İlacAlımTarihi,Barkodu,Adeti,Periyot,Doz,Fiyatı) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",HastaTc_MaskedTextBox_ReceteBilgileri.Text);
            komut.Parameters.AddWithValue("@p2",HastaAdıSoyadı_TextBox_ReceteBilgileri.Text);
            komut.Parameters.AddWithValue("@p3",ReceteTarihi_MaskedTextBox_ReceteBilgileri.Text);
            komut.Parameters.AddWithValue("@p4",TeslimAlanTc_MaskedTextBox_ReceteBilgileri.Text);
            komut.Parameters.AddWithValue("@p5",TeslimAlanAdıSoyadı_TextBox_ReceteBilgileri.Text);
            komut.Parameters.AddWithValue("@p6",İlacAlımTarihi_MaskedTextBox_ReceteBilgileri.Text);
            komut.Parameters.AddWithValue("@p7",BarkodBirinciKısım_TextBox_İlacBilgiler.Text);
            komut.Parameters.AddWithValue("@p8",AdetBirinciKısım_TextBox_İlacBilgiler.Text);
            komut.Parameters.AddWithValue("@p9",PeriyotBirinciKısım_TextBox_İlacBilgiler.Text);
            komut.Parameters.AddWithValue("@p10",DozBirinciKısım_TextBox_İlacBilgiler.Text);
            komut.Parameters.AddWithValue("@p11",FiyatıBirinciKısım_TextBox_İlacBilgiler.Text);
            bgl.baglanti().Close();
            komut.ExecuteNonQuery();
           
            MessageBox.Show("Reçete Kaydı Yapıldı..");
        }

        private void ReceteBilgileri_GroupBox_ManuelreceteGirisi_Enter(object sender, EventArgs e)
        {

        }

        private void İlacAlımTarihi_MaskedTextBox_ReceteBilgileri_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
