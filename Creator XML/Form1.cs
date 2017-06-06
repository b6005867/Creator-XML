using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Creator_XML
{
    public partial class Form1 : Form
    {
        StreamReader reader;
        StreamWriter write;
        string applicationPath = Directory.GetCurrentDirectory() + "\\";


        public Form1()
        {
            InitializeComponent();
        }

        private void add_to_listboxes(string article, int quantity)
        {
            lbx_article.Items.Add(article);
            lbx_quantity.Items.Add(quantity);
        }

        private void add_line(StreamWriter write, string article, string quantity, int number)
        {
            write.Write("<Linii_comfurn><Nr>" + number.ToString() + "</Nr><Comfurn_nr>25425</Comfurn_nr><Comfurn_data>20.12.2016</Comfurn_data><Articol>" + article + "</Articol><Cantitate>" + quantity + "</Cantitate><UM>BUC</UM><Pret_unitar>5.0</Pret_unitar><Termen>22.12.2016</Termen><Conditii>Exportat din Valweb: 238853</Conditii><CONDLIVR_COD>VALWEB: 238853</CONDLIVR_COD><Perplanif></Perplanif><Varipret_cod>NORMALA</Varipret_cod><Vardisc_cod>0</Vardisc_cod><Pret_catalog>7.0</Pret_catalog><Valuta_simbol>ROL</Valuta_simbol><Discount>0</Discount></Linii_comfurn>");
        }

        private void make_file(ListBox lbx_article, ListBox lbx_quantity)
        {
            string filePath = applicationPath + "file.xml";
            
            File.Delete(filePath);
            //write = File.CreateText(filePath);
            write = File.CreateText(filePath);
            write.Write("<?xml version=\"1.0\"?>" + "<Comfurn>" + "<Version>1</Version>" + "<Copyright>2005 - ValWeb</Copyright>" + "<Id>25425</Id>" + "<Nr>25425</Nr>" + "<Data>20.12.2016</Data>");
            int numberOfItems = lbx_article.Items.Count;
            for(int x = 0; x< numberOfItems;x++)
            {
                add_line(write, lbx_article.Items[x].ToString(),lbx_quantity.Items[x].ToString(),x+1);
            }
            write.Write("</Comfurn>");
            write.Close();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            add_to_listboxes(tbx_article.Text, Convert.ToInt32(nud_quantity.Value));
            tbx_article.Text = "";
            nud_quantity.Value = 0;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            make_file(lbx_article, lbx_quantity);
        }
    }
}
