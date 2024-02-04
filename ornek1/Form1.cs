using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek1
{
    using System.Data.OleDb;
    using System.IO;

    public partial class Form1 : Form

    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|vize.accdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            try
            {
                baglanti.Open();

                string sqlBolum = "SELECT COUNT(*) AS adet FROM tblDiziler";
                using (OleDbCommand cmd = new OleDbCommand(sqlBolum, baglanti))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textBox1.Text = reader["adet"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        
           
                try
                {
                    baglanti.Open();

                    string sqlBolum = "SELECT COUNT(*) AS adet FROM tblDiziler";
                    using (OleDbCommand cmd = new OleDbCommand(sqlBolum, baglanti))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox1.Text = reader["adet"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglanti.Close();
                }
            }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinzden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void toplamBölümSayısınıDosyayaYazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dosyaYolu = "C:\\Kullanıcılar\\PC\\Masaüstü\\toplam.txt";

            // Dosyayı oluştur
            File.Create(dosyaYolu);

            baglanti.Open();
            string sqlBolum = "SELECT COUNT(*) AS adet FROM tblDiziler";
            OleDbCommand cmd = new OleDbCommand(sqlBolum, baglanti);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string sayi = reader["adet"].ToString();

                // Dosyaya yaz
                File.WriteAllText(dosyaYolu, sayi);
            }
            baglanti.Close();

        }

        private void sezonSayısını1ArtırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sezon_Arttır sezon = new Sezon_Arttır();
            sezon.ShowDialog();

        }
    }
    }

