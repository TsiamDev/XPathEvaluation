using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Ex10
{
    public partial class Form1 : Form
    {
        string xmlPath;

        public Form1()
        {
            InitializeComponent();

            xmlPath = null;
        }

        private void OpenDialog()
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                DialogResult result = openFileDialog.ShowDialog();
                if(result == DialogResult.OK)
                {
                    //Get the path of specified file
                    xmlPath = openFileDialog.FileName;
                    filePathLabel.Text = "File Opened: " + xmlPath;
                }
            }
        }

        private void openXMLFileButton_Click(object sender, EventArgs e)
        {
            OpenDialog();
        }

        private void xPathQ_10_a_Click(object sender, EventArgs e)
        {
            if(xmlPath == null)
            {
                OpenDialog();
            }
            ExecuteXPathQuery("//Lesson/Lecture[Day = \"Monday\"]/preceding-sibling::Title");
        }

        private void xPathQ_10_b_Click(object sender, EventArgs e)
        {
            if (xmlPath == null)
            {
                OpenDialog();
            }
            ExecuteXPathQuery("//Lesson/Lecture[@Classroom = \"BA\"]/preceding-sibling::Title");
        }

        private void xPathQ_10_c_Click(object sender, EventArgs e)
        {
            if (xmlPath == null)
            {
                OpenDialog();
            }
            ExecuteXPathQuery("//Lesson/Lecture[following-sibling::Professor = \"Hatzilygeroudis\"]/child::* | //Lesson/Lecture[following-sibling::Professor = \"Hatzilygeroudis\"]/@*");
        }

        private void ExecuteXPathQuery(string xPath)
        {
            if(xmlPath != null)
            {
                XPathDocument document = new XPathDocument(xmlPath);
                XPathNavigator navigator = document.CreateNavigator();
                XPathExpression query;
                XPathNodeIterator nodes;
                object obj = navigator.Evaluate(xPath);
                if(obj != null)
                {
                    query = navigator.Compile(xPath);
                    nodes = navigator.Select(query);

                    xPathQResultsLabel.Text = "";
                    while (nodes.MoveNext())
                    {
                        //Console.WriteLine(nodes.Current.Value);
                        xPathQResultsLabel.Text += nodes.Current.Value + "\n"; 
                    }
                }
                else
                {
                    //Console.WriteLine("Error in xPath query.");
                    MessageBox.Show("Error in xPath query.");
                }
            }
            else
            {
                MessageBox.Show("xmlPath cannot be null - you must specify an xml file.");
            }
        }
    }
}
