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




        }
    }
}
