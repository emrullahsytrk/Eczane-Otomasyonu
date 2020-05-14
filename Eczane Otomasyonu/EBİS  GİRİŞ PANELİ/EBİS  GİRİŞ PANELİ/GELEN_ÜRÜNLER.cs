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
    public partial class Gelen_Ürünler_Frm : Form
    {
        public Gelen_Ürünler_Frm()
        {
            InitializeComponent();
        }

        private void GeriDön_Btn_GelenÜrünler_Click(object sender, EventArgs e)
        {
            Ebis_İşlem_Paneli_Frm EbisislemPaneliFormu = new Ebis_İşlem_Paneli_Frm(); // ebis işlem panelini çağırır
            EbisislemPaneliFormu.Show(); // ebis işlem panelini gösterir
            this.Hide(); // önceki formu gizler
        }

        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        private void Gelen_Ürünler_Frm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=EMRULLAH\\MSSQLSERVER01;Initial Catalog=Eczane_Veritabanı;Integrated Security=True");
            da = new SqlDataAdapter("SELECT FaturaNo,DepoAdı,FaturaTutarı,FaturaTarihi,SevkTarihi,KayıtTarihi FROM Tbl_GelenÜrünleri", con);
            dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            GelenÜrünListesi_DataGridView_GelenÜrünler.DataSource = dt;
        }
        private void Listele_Lbl_GelenÜrülerSorgulama_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT FaturaNo,DepoAdı,FaturaTutarı,FaturaTarihi,SevkTarihi,KayıtTarihi FROM Tbl_GelenÜrünleri Where KayıtTarihi BETWEEN @tar1 and @tar2";
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            adp.SelectCommand.Parameters.AddWithValue("@tar1",TarihAralıgı_DateTimePicker_Bas_GelenÜrünleriSorgulama.Value);
            adp.SelectCommand.Parameters.AddWithValue("@tar2", TarihAralıgı_DateTimePicker_Son_GelenÜrünleriSorgulama.Value);
            adp.Fill(dt);
            con.Close();
            GelenÜrünListesi_DataGridView_GelenÜrünler.DataSource = dt;
        }
    }
}
