using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;               //Xml import

namespace XML_ile_Veri_Çekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string GunlukDovizKuru = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(GunlukDovizKuru);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolar.Text = string.Format("USD     {0} [{1}]", USD, tarih.ToShortDateString());


            string EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEURO.Text = string.Format("EURO   {0} [{1}]", EURO, tarih.ToShortDateString());



            string POUND = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
            lblPound.Text = string.Format("POUND {0} [{1}]", POUND, tarih.ToShortDateString());

            string JaponYeni = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/BanknoteSelling").InnerXml;
            lblJaponYeni.Text = string.Format("JaponYeni {0} [{1}]", JaponYeni, tarih.ToShortDateString());




        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
