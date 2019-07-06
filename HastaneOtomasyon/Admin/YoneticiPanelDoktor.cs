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

namespace HastaneOtomasyon
{
    public partial class YoneticiPanelDoktor : Form
    {
        public YoneticiPanelDoktor()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=HastaneOtomasyon;Integrated Security=True");
        private void YoneticiPanelDoktor_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Poliklinik", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("Ad", typeof(string));
            dt.Columns.Add("RandevuSuresi", typeof(string));
            dt.Load(oku);

            cbPoliklinik.ValueMember = "id";
            cbPoliklinik.DisplayMember = "Ad";
            cbPoliklinik.DataSource = dt;
            baglan.Close(); 
            verileriGoruntule();
        }

        private void verileriGoruntule()
        {
            baglan.Open();
            string sorgu = "select TC,Ad,Soyad,Mail,DogumTarih,Telefon,Adres from Doktor";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Doktor (Ad,Soyad,TC,Mail,Sifre,DogumTarih,Telefon,Adres) values( @Ad, @Soyad, @TC, @Mail, @Sifre, @DogumTarih, @Telefon, @Adres)";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@TC", txtTC.Text);
            komut.Parameters.AddWithValue("@Mail", txtMail.Text);
            komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            komut.Parameters.AddWithValue("@DogumTarih", dateDogumTarih.Value);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            verileriGoruntule();

            txtAd.Clear();
            txtAdres.Clear();
            txtMail.Clear();
            txtSifre.Clear();
            txtSoyad.Clear();
            txtTC.Clear();
            txtTelefon.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            kayıtSil(txtDoktorSilTc.Text);
            verileriGoruntule();
            txtDoktorSilTc.Clear();
        }

        void kayıtSil(string TC)
        {
            baglan.Open();
            string sorgu = "delete from Doktor where TC=@TC";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@TC", TC);
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select TC,Ad,Soyad,Mail,DogumTarih,Telefon,Adres from Doktor where Ad like'%" + txtAra.Text + "%'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }
         
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string sorgu = "update Doktor set TC=@TC, Ad=@Ad, Soyad=@Soyad, Mail=@Mail, DogumTarih=@DogumTarih, Telefon=@Telefon, Adres=@Adres where TC=@TC";
            SqlCommand komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@TC", txtTC.Text);
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@Mail", txtMail.Text);
            komut.Parameters.AddWithValue("@DogumTarih", dateDogumTarih.Value);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TC,Ad,Soyad,Mail,DogumTarih,Telefon,Adres
            int seciliAlan = dataGridView1.SelectedCells[0].RowIndex;
            string TC = dataGridView1.Rows[seciliAlan].Cells[0].Value.ToString();
            string Ad = dataGridView1.Rows[seciliAlan].Cells[1].Value.ToString();
            string Soyad = dataGridView1.Rows[seciliAlan].Cells[2].Value.ToString();
            string Mail = dataGridView1.Rows[seciliAlan].Cells[3].Value.ToString();
            string DogumTarih = dataGridView1.Rows[seciliAlan].Cells[4].Value.ToString();
            string Telefon = dataGridView1.Rows[seciliAlan].Cells[5].Value.ToString();
            string Adres = dataGridView1.Rows[seciliAlan].Cells[6].Value.ToString();

            txtTC.Text = TC;
            txtAd.Text = Ad;
            txtSoyad.Text = Soyad;
            txtMail.Text = Mail;
            dateDogumTarih.Text = DogumTarih;
            txtTelefon.Text = Telefon;
            txtAdres.Text = Adres;
        }
    }
}