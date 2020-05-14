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
    public partial class Ebis_Giris_Paneli_Frm : Form
    {
        public Ebis_Giris_Paneli_Frm()
        {
            InitializeComponent();
        }

        sqlbaglantı bgl = new sqlbaglantı(); //  sqlbaglantı sınıfından türetilen bgl nesne ile clasın içindeki metoda ulaşılmasını sağlar

        private void Kullanici_Giris_Btn_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand ("Select * From Tbl_KullanıcıGirisi Where KullanıcıTC=@p1 and KullanıcıSifre=@p2", bgl.baglanti()); // veritabanındaki Tbl_KullanıcıGirisi tablosundan KullanıcıTC=@p1 ve KullanıcıSifre=@p2 şartlarını sağlıyorsa veritabanından bu verileri çeker.

            komut.Parameters.AddWithValue("@p1",Kullanici_Adİ_MaskedTextBox_GirisPaneli.Text); // @p1 parametresine Kullanici_Adİ_MaskedTextBox_GirisPanelinde gelen değeri verir.
            komut.Parameters.AddWithValue("@p2",Kullanici_Sife_TxtBx_GirisPanel.Text); // @p2 parametresine  Kullanici_Sife_TxtBx_GirisPanelinden gelen değeri verir
            SqlDataReader oku = komut.ExecuteReader(); // komuttan gelen verileri okumayı sağlar

            if(oku.Read())
            {
              Ebis_İşlem_Paneli_Frm EbisİslemForm = new Ebis_İşlem_Paneli_Frm(); // ebis işlem panelini çağırır
              EbisİslemForm.Show(); // ebis işlem panelini gösterir
              this.Hide(); // önceki formu gizler
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı TC Veya Şifre Girdiniz..."); // kullanıcıya hata mesajı verir
                Kullanici_Adİ_MaskedTextBox_GirisPaneli.Clear(); // hatalı girilen kullanıcı tc kısmını temizler
                Kullanici_Sife_TxtBx_GirisPanel.Clear(); // hatalı girilen şifre kısmını temizler
            }
            bgl.baglanti().Close(); // baglantıyı kapatır
            
        }
    }
}
