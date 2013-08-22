using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml;
using System.Text;
using System.Windows.Forms;

namespace XQueryDemo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                this.textResult.Text = "";

                XPathDocument doc = new XPathDocument(new System.IO.StringReader(this.textContent.Text));
                XPathNavigator nvg = doc.CreateNavigator();
                XPathExpression xpath = nvg.Compile(this.textXPath.Text);
                if (!string.IsNullOrEmpty(this.textNS.Text) && !string.IsNullOrEmpty(this.textNSUri.Text))
                {
                    string[] names = this.textNS.Text.Split(';');
                    string[] uris = this.textNSUri.Text.Split(';');
                    if (names.Length == uris.Length)
                    {
                        XmlNamespaceManager nsMgr = new XmlNamespaceManager(nvg.NameTable);
                        for (int i = 0; i < names.Length; i++)
                        {
                            nsMgr.AddNamespace(names[i], uris[i]);
                        }
                        xpath.SetContext(nsMgr);
                    }
                    else
                        MessageBox.Show("Namespace mismatches.");
                }
                XPathNodeIterator iterator = nvg.Select(xpath);


                while (iterator.MoveNext())
                {
                    
                    this.textResult.Text += iterator.Current.Value;
                    this.textResult.Text += Environment.NewLine;
                }

                this.tabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            string file = null;

            FileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                file = dlg.FileName;

                this.textContent.Text = System.IO.File.ReadAllText(file);

                

            }
        }
    }
}
