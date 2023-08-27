using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace InstagramFollowersDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateTable();
            NetControl();
        }

        public static string guncelSurum = "1.1";

        private void NetControl()
        {
            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com.tr", 80);
                kontrol_client.Close();
                updateToolStripButton.Enabled = true;
            }
            catch (Exception e)
            {
                updateToolStripButton.Enabled = false;
            }
        }

        public void CreateTable()
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Takipçilerim";
            dataGridView1.Columns[1].Name = "Takip Ettiklerim";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public static string takipciURL = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "//takipci.html";
        public static string takipEdilenURL = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "//takipEdilen.html";

        public static int takipciSayi;
        public static int takipEdilenSayi;
        public static int max = 0;

        public static string[] takipci;
        public static string[] takipEdilen;

        public void GetCount()
        {
            if(takipciTextBox.Text.Length>0 && takipEdilenTextBox.Text.Length>0)
            {
                takipciSayi = Convert.ToInt32(takipciTextBox.Text);
                takipEdilenSayi = Convert.ToInt32(takipEdilenTextBox.Text);

                if (takipciSayi > takipEdilenSayi)
                {
                    max = takipciSayi;
                }
                else
                {
                    max = takipEdilenSayi;
                }

                takipci = new string[max + 1];
                takipEdilen = new string[max + 1];

                durumLabel.Text = "Takip Sayıları Alındı";
            }
    }

        public void GetFollowers()
        {
            Uri urlTakipci = new Uri(takipciURL);
            WebClient clientTakipci = new WebClient();
            clientTakipci.Encoding = Encoding.UTF8;
            string htmlTakipci = clientTakipci.DownloadString(urlTakipci);
            HtmlDocument dokumanTakipci = new HtmlDocument();
            dokumanTakipci.LoadHtml(htmlTakipci);
            for (int i = 1; i <= takipciSayi; i++)
            {
                HtmlNodeCollection titlesTakipci = dokumanTakipci.DocumentNode.SelectNodes("body/div[2]/div/div/div[3]/div/div/div[1]/div/div[2]/div/div/div/div/div[2]/div/div/div[3]/div[1]/div/div["+i+"]/div/div/div/div[2]/div/div/div/div/div/a/div/div/span");
                foreach (HtmlNode title in titlesTakipci)
                {
                    takipci[i] = (title.InnerText.Trim());
                }
            }

            durumLabel.Text = "Takipçi Bilgileri Alındı";
        }

        public void FollowersDownload()
        {
            StreamWriter KayitTakipci = new StreamWriter(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "//takipci.txt");
            for (int i = 1; i <= takipciSayi; i++)
            {
                KayitTakipci.WriteLine(takipci[i]);
            }
            KayitTakipci.Close();
            durumLabel.Text = "Takipçiler Kaydedildi";
        }
        public void FollowDownload()
        {
            StreamWriter KayitTakipEdilen = new StreamWriter(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "//takipEdilen.txt");
            for (int i = 1; i <= takipEdilenSayi; i++)
            {
                KayitTakipEdilen.WriteLine(takipEdilen[i]);
            }
            KayitTakipEdilen.Close();
            durumLabel.Text = "Takip Edilenler Kaydedildi";
        }

        public void GetFollow()
        {
            Uri urlTakipEdilen = new Uri(takipEdilenURL);
            WebClient clientTakipEdilen = new WebClient();
            clientTakipEdilen.Encoding = Encoding.UTF8;
            string htmlTakipEdilen = clientTakipEdilen.DownloadString(urlTakipEdilen);
            HtmlDocument dokumanTakipEdilen = new HtmlDocument();
            dokumanTakipEdilen.LoadHtml(htmlTakipEdilen);
            for (int i = 1; i <= takipEdilenSayi; i++)
            {
                HtmlNodeCollection titlesTakipEdilen = dokumanTakipEdilen.DocumentNode.SelectNodes("body/div[2]/div/div/div[3]/div/div/div[1]/div/div[2]/div/div/div/div/div[2]/div/div/div[4]/div/div/div["+i+"]/div/div/div/div[2]/div/div/div/div/div/a/div/div/span");                                                                  
                foreach (HtmlNode title in titlesTakipEdilen)
                {
                    takipEdilen[i] = (title.InnerText.Trim());
                }
            }
            durumLabel.Text = "Takip Edilen Bilgileri Alındı";
        }

        public void ToDataGrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 1; i <= max; i++)
            {
                dataGridView1.Rows.Add(takipci[i], takipEdilen[i]);
            }

            if(dataGridView1.Rows.Count>0)
            {
                kaydetButton.Enabled = true;
            }
            else
            {
                kaydetButton.Enabled = false;
            }
            durumLabel.Text = "Listeleme Tamamlandı";
            MessageBox.Show("Listeleme Tamamlandı.");
        }

        public void GetData()
        {
            GetCount();

            if(max>0)
            {
                GetFollowers();
                GetFollow();
                ToDataGrid();
            }
            else
            {
                durumLabel.Text = "İşlem Başarısız";
                MessageBox.Show("İşlem Başarısız.");
            }
        }

        private void listeleButton_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            FollowersDownload();
            FollowDownload();

            durumLabel.Text = "Kayıt Tamamlandı";
            MessageBox.Show("Kayıt Tamamlandı.");
        }

        private void reportToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://chareless.github.io/saribayirdeniz/#contact");
        }

        private void versionsToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://chareless.github.io/saribayirdeniz/instafollowers.html#version");
        }

        private void updateToolStripButton_Click(object sender, EventArgs e)
        {
            NetControl();
            Update updateForm = new Update();
            updateForm.Show();
        }

        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }
    }
}

