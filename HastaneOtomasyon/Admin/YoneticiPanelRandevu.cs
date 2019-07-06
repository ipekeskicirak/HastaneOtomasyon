using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.Admin
{
    public partial class YoneticiPanelRandevu : Form
    {
        string RandevuSuresi = "";
        public YoneticiPanelRandevu()
        {
            InitializeComponent();
        }
        string randevuSuresi = "";
        List<DateTime> Randevular = new List<DateTime>();
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=HastaneOtomasyon;Integrated Security=True");
        private void YoneticiPanelRandevu_Load(object sender, EventArgs e)
        {
            //------------------Hasta getirme---------------
            baglan.Open();
            SqlCommand komutHasta = new SqlCommand("select id, Ad+' '+Soyad as AdSoyad from Hasta", baglan);
            SqlDataReader okuH = komutHasta.ExecuteReader();
            DataTable dtH = new DataTable();
            dtH.Columns.Add("id", typeof(string));
            dtH.Columns.Add("AdSoyad", typeof(string));

            dtH.Load(okuH);

            cbHasta.ValueMember = "id";
            cbHasta.DisplayMember = "AdSoyad";
            cbHasta.DataSource = dtH;
            baglan.Close();

            //------------------Poliklinik getirme---------------
            baglan.Open();
            SqlCommand komutPoliklinik = new SqlCommand("select * from Poliklinik", baglan);
            SqlDataReader okuP = komutPoliklinik.ExecuteReader();
            DataTable dtP = new DataTable();
            dtP.Columns.Add("id", typeof(string));
            dtP.Columns.Add("Ad", typeof(string));
            dtP.Columns.Add("RandevuSuresi", typeof(string)); 
            dtP.Load(okuP);

            cbPoliklinik.ValueMember = "id";
            cbPoliklinik.DisplayMember = "Ad";
            cbPoliklinik.DataSource = dtP;  
            baglan.Close();

            baglan.Open();
            List<string> saatCb = new List<string>();
            SqlCommand komutSaat = new SqlCommand("select Saat from Saat", baglan);
            SqlDataReader okuS = komutSaat.ExecuteReader();
            DataTable st = new DataTable(); 
            //saatCb.Add(okuS.ToString());
            st.Columns.Add("Saat", typeof(string));
            st.Load(okuS);
            cbSaat.ValueMember = "Saat";
            cbSaat.DisplayMember = "Saat";
            cbSaat.DataSource = st;

            baglan.Close();
            
            


            verileriGoruntule();
        }

        private void verileriGoruntule()
        {
            
            string sorgu = "select id,HastaID,DoktorID,PoliklinikID,Tarih,Saat,Guncelleme from Randevu";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void cbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDoktor.DataSource = null;
            //cbDoktor.Items.Clear();
            cbDoktor.ResetText();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            SqlCommand komutDoktor = new SqlCommand("select id, Ad+' '+Soyad as AdSoyad from Doktor where PoliklinikID=@id", baglan);
            var id = cbPoliklinik.SelectedValue;
            //var id = cbPoliklinik.ValueMember[Convert.ToInt32(SeciliAlan)].ToString();
            komutDoktor.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            SqlDataReader okuD = komutDoktor.ExecuteReader();
            DataTable dtD = new DataTable();
            dtD.Columns.Add("id", typeof(string));
            dtD.Columns.Add("AdSoyad", typeof(string));

            dtD.Load(okuD);
            cbDoktor.ValueMember = "id";
            cbDoktor.DisplayMember = "AdSoyad";
            cbDoktor.DataSource = dtD;

            SqlCommand sorgu = new SqlCommand("select RandevuSuresi from Poliklinik where id=@id", baglan);
            sorgu.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            RandevuSuresi = sorgu.ExecuteScalar().ToString();
            baglan.Close(); 
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Randevu (HastaID,DoktorID,PoliklinikID,Tarih,Saat) values(@HastaID,@DoktorID,@PoliklinikID,@Tarih,@Saat)";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@HastaID", Convert.ToInt32(cbHasta.SelectedValue));
            komut.Parameters.AddWithValue("@DoktorID", Convert.ToInt32(cbDoktor.SelectedValue));
            komut.Parameters.AddWithValue("@PoliklinikID", Convert.ToInt32(cbPoliklinik.SelectedValue));
            komut.Parameters.AddWithValue("@Tarih", dateTarih.Value);
            komut.Parameters.AddWithValue("@Saat", cbSaat.SelectedValue);
            
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            verileriGoruntule(); 
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            YoneticiPanel yoneticiPanelForm = new YoneticiPanel();
            yoneticiPanelForm.Show();
            this.Close();

        }
    }
}
