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


namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   // Güncelle
            int id = Convert.ToInt32(TxtOId.Text);
            var x = db.TBLOGRENCI.Find(id);
            x.AD = TxtOAd.Text;
            x.SOYAD = TxtOSoyad.Text;
            x.FOTO = TxtFoto.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Bilgileri Güncellenmiştir.");
        }

        private void BtnDListele_Click(object sender, EventArgs e)
        {  //Adonet Usage
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\Ozan;Initial Catalog=DbSinavOgrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("Select * From tbldersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BtnOListele_Click(object sender, EventArgs e)
        {   //EntityFramework Usage
            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Fotoğraf";
        }

        private void BtnNListele_Click(object sender, EventArgs e)
        {   // LinQ
            var query = from item in db.TBLNOTLAR
                        select new { item.NOTID, item.OGRID, item.DERSID, item.SINAV1, item.SINAV2, item.SINAV3, item.ORTALAMA, item.DURUM };

            dataGridView1.DataSource = query.ToList();

            //dataGridView1.DataSource = db.TBLNOTLAR.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLOGRENCI to = new TBLOGRENCI();
            to.AD = TxtOAd.Text;
            to.SOYAD = TxtOSoyad.Text;
            db.TBLOGRENCI.Add(to);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Ekleme İşlemi Gerçekleşmiştir.");
            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {   //Remove
            int id = Convert.ToInt32(TxtOId.Text);
            var x = db.TBLOGRENCI.Find(id);
            db.TBLOGRENCI.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci: " + id + " silinmiştir.");
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            //Procedure Usage
            dataGridView1.DataSource = db.NOTLISTESI();
        }

        private void BtnBul1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCI.Where(x => x.AD == TxtOAd.Text && x.SOYAD == TxtOSoyad.Text).ToList();
        }

        /*  private void TxtOAd_TextChanged(object sender, EventArgs e)
          {   //Linq
              string aranan = TxtOAd.Text;
              var degerler = from item in db.TBLOGRENCI where item.AD.Contains(aranan) select  item;
              dataGridView1.DataSource = degerler.ToList();
          }
        */
        private void BtnLinqEntity_Click(object sender, EventArgs e)
        {   //Linq Practice
            if (radioButton1.Checked)
            {
                List<TBLOGRENCI> listem1 = db.TBLOGRENCI.OrderBy(x => x.AD).ToList();
                dataGridView1.DataSource = listem1;
            }
            if (radioButton2.Checked)
            {
                List<TBLOGRENCI> listem1 = db.TBLOGRENCI.OrderByDescending(x => x.AD).ToList();
                dataGridView1.DataSource = listem1;
            }
            if (radioButton3.Checked)
            {
                List<TBLOGRENCI> listem1 = db.TBLOGRENCI.OrderBy(x => x.AD).Take(3).ToList();
                dataGridView1.DataSource = listem1;
            }
            if (radioButton4.Checked)
            {
                List<TBLOGRENCI> listem1 = db.TBLOGRENCI.Where(x => x.OGRID == 1).ToList();
                dataGridView1.DataSource = listem1;
            }
            if (radioButton5.Checked)
            {
                List<TBLOGRENCI> listem1 = db.TBLOGRENCI.Where(x => x.AD.Contains(TxtOAd.Text)).ToList();
                dataGridView1.DataSource = listem1;
            }
            if (radioButton6.Checked)
            {
                List<TBLOGRENCI> listem5 = db.TBLOGRENCI.Where(x => x.AD.StartsWith("O")).ToList();
                dataGridView1.DataSource = listem5;
            }
            if (radioButton8.Checked)
            {
                bool deger = db.TBLOGRENCI.Any();
                MessageBox.Show(deger.ToString(), "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            if (radioButton9.Checked)
            {
                int toplam = db.TBLOGRENCI.Count();
                MessageBox.Show(toplam.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (radioButton10.Checked)
            {
                var toplam = db.TBLNOTLAR.Sum(x => x.SINAV1);
                MessageBox.Show("Sınav1 Toplam: " + toplam.ToString());
            }
            if(radioButton11.Checked)
            {
                var ort = db.TBLNOTLAR.Average(x => x.SINAV1);
                MessageBox.Show("Sınav1 ortalama: " + ort.ToString());

            }
            if (radioButton12.Checked)
            {
               var ort = db.TBLNOTLAR.Average(x => x.SINAV1);
               var result = (from item in db.TBLNOTLAR where (item.SINAV1 > ort)
                                select new
                                {
                                    item.NOTID,
                                    OGRENCI = item.TBLOGRENCI.AD + " " + item.TBLOGRENCI.SOYAD,
                                    item.TBLDERSLER.DERSAD,
                                    item.SINAV1,
                                    item.SINAV2,
                                    item.SINAV3,
                                    item.ORTALAMA,
                                    item.DURUM

                                }
                            );
                dataGridView1.DataSource = result.ToList();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = from d1 in db.TBLNOTLAR
                        join d2 in db.TBLOGRENCI
                        on d1.OGRID equals d2.OGRID
                        join d3 in db.TBLDERSLER
                        on d1.DERSID equals d3.DERSID
                        where d1.NOTID > 1
                        select new
                        {
                            d3.DERSAD,
                            NOT_ID = d1.NOTID,
                            AD_SOYAD = d2.AD + " " + d2.SOYAD,
                            d1.SINAV1,
                            d1.SINAV2,
                            d1.SINAV3,
                        };
            dataGridView1.DataSource = query.ToList();       

        }
    }
}