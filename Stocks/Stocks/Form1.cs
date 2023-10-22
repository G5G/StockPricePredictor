using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.IO;

namespace Stocks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] tmps;
        string result = "";
        string[,] inps;
        int tmpp = 0;
        int tmp = 0;
        string apikey = "";
        bool edit = true;
        double prevstck = 0.1;
        double currntstck = 0.1;
        double chng = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tmp <= 0)
            {
                timer1.Enabled = false;
            }
            else
            {
                if (tmpp > 50)
                {
                    tmpp = 0;
                    chart1.Series["StockPricesZoomed"].Points.Clear();
                }
                double avrg = 0;
                avrg += Convert.ToDouble(inps[tmp, 1]);
                avrg += Convert.ToDouble(inps[tmp, 2]);
                avrg += Convert.ToDouble(inps[tmp, 3]);
                avrg += Convert.ToDouble(inps[tmp, 4]);//averaging the open sale, close sale, highest sale and lowest sale and merging it into a single number.
                avrg = avrg / 4.0;
                currntstck = avrg;
                chng = prevstck - currntstck;
                chng = (chng / prevstck)*100;//working out the percentage of change
                prevstck = currntstck;
                TextAnnotation txt = new TextAnnotation();
                TextAnnotation txxt = new TextAnnotation();
                if (chng > 0)// if the change is possitive(if it increased) then it will display the arrow up else it will be arrow down
                {
                    label_up.Text = (Decimal.Round(Convert.ToDecimal(chng),2).ToString())+"%";
                    pictureBox_up.Visible = true;
                    label_up.Visible = true;

                    label_down.Visible = false;
                    pictureBox_down.Visible = false;
                    txt.ForeColor = Color.LimeGreen;
                    txxt.ForeColor = Color.LimeGreen;

                }
                else
                {
                    txt.ForeColor = Color.Red;
                    txxt.ForeColor = Color.Red;
                    label_down.Text = (Decimal.Round(Convert.ToDecimal(chng),2).ToString())+"%";
                    pictureBox_up.Visible = false;
                    label_up.Visible = false;
                    pictureBox_down.Visible = true;
                    label_down.Visible = true;
                }
                

                chart1_stocks.Series["StockPrices"].Points.AddXY(inps[tmp, 0], avrg);
                chart1.Series["StockPricesZoomed"].Points.AddXY(inps[tmp, 0], avrg);
                tmp--;
                tmpp++;
                chart1.Annotations.Clear();
                chart1_stocks.Annotations.Clear();
                txt.Text = avrg.ToString();
                txxt.Text = avrg.ToString();
                txxt.SetAnchor(chart1.Series["StockPricesZoomed"].Points[chart1.Series["StockPricesZoomed"].Points.Count() - 1]);//setting the location of the mini label on the graph
                txt.SetAnchor(chart1_stocks.Series["StockPrices"].Points[chart1_stocks.Series["StockPrices"].Points.Count()-1]);
                chart1_stocks.Annotations.Add(txt);
                chart1.Annotations.Add(txxt);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["StockPricesZoomed"].Points.Clear();
            chart1_stocks.Series["StockPrices"].Points.Clear();
            if (listBox1.SelectedItem != null && !listBox1.SelectedItem.ToString().Contains("-"))
            {
                tmps = listBox1.SelectedItem.ToString().Split('#');
            }

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol="+tmps[1]+"&outputsize=full&apikey="+apikey+"&datatype=csv");//sets up a website request
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();//gets the response from the website
            StreamReader sr = new StreamReader(resp.GetResponseStream());//reads it and stores the output to sr
            result = sr.ReadToEnd().ToString();//transfers the data from sr to string result

            string[] tst = result.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);//splits each new line in the data and stores it seperated within the array
            inps = new string[tst.Count() - 1, 6]; //2D array[Different Data, Date(timestamp) + open + high +low + close + volume] <- more organised and less confusion
            for (int i = 1; i < tst.Count(); i++)
            {
                string[] timestamp = tst[i].Split(',');

                for (int x = 0; x < 6; x++)
                {
                    inps[i - 1, x] = timestamp[x];
                }
            }
            tmp = tst.Count() - 2;
            timer1.Enabled = true;

        }

        private void button2_setedit_Click(object sender, EventArgs e)
        {
            if(textBox1_apikey.Text != null && textBox1_apikey.Text != "" && edit == true)
            {
                apikey = textBox1_apikey.Text;
                edit = false;
                button2_setedit.Text = "EDIT";
                textBox1_apikey.ReadOnly = true;
                textBox1_apikey.Enabled = false;
                label1_plsapi.Text = "API KEY:";

            }
            else
            {
                label1_plsapi.Text = "PLEASE SET THE API KEY:";
                button2_setedit.Text = "SET";
                edit = true;
                textBox1_apikey.ReadOnly = false;
                textBox1_apikey.Enabled = true;
            }
        }

        private void textBox1_apikey_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (textBox1_apikey.Text != null && textBox1_apikey.Text != "" && edit == true)
                {
                    apikey = textBox1_apikey.Text;
                    edit = false;
                    button2_setedit.Text = "EDIT";
                    textBox1_apikey.ReadOnly = true;
                    textBox1_apikey.Enabled = false;
                    label1_plsapi.Text = "API KEY:";

                }
            }
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
