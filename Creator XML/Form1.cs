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
        ListBox lbx_codes = new ListBox();
        ListBox lbx_measurements = new ListBox();
        StreamReader readMeasurements;
        string filePath;


        public Form1()
        {
            InitializeComponent();
        }

        private string get_measurements(string code)
        {
            int stopper = 0;
            readMeasurements = File.OpenText(applicationPath + "articole.txt");
            string line = readMeasurements.ReadLine();
            while (line != null)
            {
                string[] words = line.Split('	');
                foreach (string word in words)
                {
                    if (stopper == 0)
                    {
                        if (word == code)
                        {
                            stopper = 1;
                        }
                    }
                    else
                    {
                        return word;
                    }
                }
                
                line = readMeasurements.ReadLine();
            }
            return "0";

        }

        private void read_file(string str_path)
        {
            int index = 1;
            reader = File.OpenText(str_path);
            string line = reader.ReadLine();
            line = reader.ReadLine();
            while (line != null)
            {
                string[] words = line.Split(';');
                foreach (string word in words)
                {
                        if (index % 2 != 0)
                        {
                            lbx_article.Items.Add(word);
                            //MessageBox.Show(word);
                        }
                        else
                        {
                            lbx_quantity.Items.Add(word);
                            //MessageBox.Show(word);
                        }
                        index++;
                }
                line = reader.ReadLine();
            }
        }

        private void add_line(StreamWriter write, string article, string quantity, int number, string measurement)
        {
            write.Write("<Linii_comfurn><Nr>" + number.ToString() + "</Nr><Comfurn_nr>25425</Comfurn_nr><Comfurn_data>20.12.2016</Comfurn_data><Articol>" + article + "</Articol><Cantitate>" + quantity + "</Cantitate><UM>" + measurement +"</UM><Pret_unitar>5.0</Pret_unitar><Termen>22.12.2016</Termen><Conditii>Exportat din Valweb: 238853</Conditii><CONDLIVR_COD>VALWEB: 238853</CONDLIVR_COD><Perplanif></Perplanif><Varipret_cod>NORMALA</Varipret_cod><Vardisc_cod>0</Vardisc_cod><Pret_catalog>7.0</Pret_catalog><Valuta_simbol>ROL</Valuta_simbol><Discount>0</Discount></Linii_comfurn>");
        }

        private void make_file(ListBox lbx_article, ListBox lbx_quantity)
        {
            string filePath = applicationPath + "file.xml";
            saveFileDialog1.Title = "Save File";
            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string savePath = saveFileDialog1.FileName + ".xml";

                write = File.CreateText(savePath);
                write.Write("<?xml version=\"1.0\"?>" + "<Comfurn>" + "<Version>1</Version>" + "<Copyright>2005 - ValWeb</Copyright>" + "<Id>25425</Id>" + "<Nr>25425</Nr>" + "<Data>20.12.2016</Data>");
                int numberOfItems = lbx_article.Items.Count;

                for (int x = 0; x < numberOfItems; x++)
                {
                    add_line(write, lbx_article.Items[x].ToString(), lbx_quantity.Items[x].ToString(), x + 1, get_measurements(lbx_article.Items[x].ToString()));
                }
                write.Write("</Comfurn>");
                write.Close();
            }           
        }


        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            make_file(lbx_article, lbx_quantity);
        }

        private void btn_selectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                lbl_filePath.Text = filePath;
                btn_save.Enabled = true;
                read_file(lbl_filePath.Text);
            }
        }

    }
}
