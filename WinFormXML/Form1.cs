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

namespace WinFormXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            // xml dosyamın oluşacak yolunu proje yolu olarak belirttim
            string xmlpath = Application.StartupPath + "\\Customer.xml";
            //Yazıcı nesnemi ve formatımı oluşturdum.
            XmlTextWriter custormer = new XmlTextWriter(xmlpath, UTF8Encoding.UTF8);
            //Format düzenleme satırımı ekledim.
            custormer.Formatting = Formatting.Indented;
            // ve işlemimi başlatıyorum.
            custormer.WriteStartDocument();
            custormer.WriteStartElement("Müşteriler");
            custormer.WriteStartElement("Müşteri");
            // id tanımlamak için kullandım.
            custormer.WriteStartAttribute("ID", "1");
            // sıra geldi textboxlardan verileri almaya
            custormer.WriteElementString("isim", txt_isim.Text);
            custormer.WriteElementString("soyisim", txt_soyisim.Text);
            // tag kapama işlemimi yapıyorum
            custormer.WriteEndElement();
            custormer.WriteEndElement();
            // kapatıyorum
            custormer.Close();
            MessageBox.Show("İşleminiz tamamlanmıştır.");
            Application.Exit();



        }
    }
}
