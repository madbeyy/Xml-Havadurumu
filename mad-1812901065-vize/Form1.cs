using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace mad_1812901065_vize
{
    public partial class Form1 : Form
    {


        string hava_durumu_link = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void Hava1_Click(object sender, EventArgs e)
        {
            XmlDocument mad1 = new XmlDocument();
            mad1.Load(hava_durumu_link);
            XmlElement dem1 = mad1.DocumentElement;
            XmlNodeList alı = dem1.SelectNodes("sehirler");
            XmlNodeList alı2 = dem1.SelectNodes("Kemo");

            foreach (XmlNode item in alı)
            {

                string sehir = item["ili"].InnerText;
                string Durum = item["Durum"].InnerText;
                string Maks_sicaklik = item["Mak"].InnerText;


                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();


                row.Cells[0].Value = sehir;
                row.Cells[1].Value = Durum;
                row.Cells[2].Value = Maks_sicaklik;
                dataGridView1.Rows.Add(row);



            }

            foreach (XmlNode item2 in alı2)
            {

                string tarih = item2["PeryotBaslama"].InnerText;
               
                DataGridViewRow row2 = (DataGridViewRow)dataGridView2.Rows[0].Clone();

                row2.Cells[0].Value = tarih;

                dataGridView2.Rows.Add(row2);





            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            XmlDocument mad2 = new XmlDocument();
            mad2.Load(hava_durumu_link);
            XmlElement dem2 = mad2.DocumentElement;
            XmlNodeList alı3 = dem2.SelectNodes("Kemo");

            foreach (XmlNode item3 in alı3)
            {

                string tarih2 = item3["PeryotBaslama"].InnerText;

                DataGridViewRow row3 = (DataGridViewRow)dataGridView2.Rows[0].Clone();

                row3.Cells[0].Value = tarih2;

                dataGridView2.Rows.Add(row3);

            }


        }
    }
}
