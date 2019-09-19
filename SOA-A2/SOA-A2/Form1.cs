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
using System.Net;

namespace SOA_A2
{
    public partial class SOAPForm : Form
    {
        public SOAPForm()
        {
            InitializeComponent();
        }

        private void CB_Services_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SOAPForm_Load(object sender, EventArgs e)
        {
            XmlDocument configDoc = new XmlDocument();
            configDoc.Load("C:\\Users\\jmilne8346\\Desktop\\SOAP-Web-Services-\\SOA-A2\\ConfigFile.xml");

            //ADD SERVICES TO COMBOBOX
            foreach(XmlNode node in configDoc.DocumentElement)
            {
                string serviceName = node.Attributes[0].InnerText;
                CB_Services.Items.Add(serviceName);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int selectedService = CB_Services.SelectedIndex;
            Object selectedItem = CB_Services.SelectedItem;




            MessageBox.Show("You have selected the " + selectedItem.ToString() + " service");
        }

        public void InvokeServiceInts(int a, int b, string service)
        {
            HttpWebRequest request = CreateWebRequest();
            XmlDocument RequestXML = new XmlDocument();


        }

        public HttpWebRequest CreateWebRequest(string URLString, string method)
        {
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(URLString);
            Req.Headers.Add(@"SOAPAction:http://tempuri.org/");

        }

    }
}
