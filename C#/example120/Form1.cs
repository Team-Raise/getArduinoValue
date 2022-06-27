using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace example120
{
    public partial class Form1 : Form
    {
        string Conn = "Server=158.247.211.247;Database=panel;Uid=jinhyo;Pwd=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("입력하세요!");
            }
            else
            {
                serialPort1.PortName = textBox1.Text;
                if(serialPort1.IsOpen == false)
                {
                    serialPort1.Open();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string rawdata = serialPort1.ReadLine();
            rawdata = rawdata.Replace("\n", "").Replace("\r", "");
            
            string[] data = rawdata.Split(',');

            /*label2.Text = "습도 : " + data[0] + "%";
            label3.Text = "온도 : " + data[1] + "'c";
            label4.Text = "체감온도 : " + data[2] + "'c";*/

            
            string date = DateTime.Now.ToString();

            //DB에 데이터가 insert
            using (MySqlConnection conn = new MySqlConnection(Conn))
            {
                conn.Open();
                try
                {
                    string sql = "insert into dht11(humi,temp,hic,date) values(\"" + data[0] + "\",\"" + data[1] + "\",\"" + data[2] + "\",\"" + date + "\")";
                    File.WriteAllText("sql.txt",sql);
                    MySqlCommand msc = new MySqlCommand(sql, conn);
                    msc.ExecuteNonQuery();
                }catch(Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Conn))
            {
                DataSet ds = new DataSet();
                string sql = "select * from dht11 order by date desc limit 20";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "dht11");

                listView1.Items.Clear();
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    //한레코드씩 리스트뷰에 집어넣고 있다..!
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = ds.Tables[0].Rows[i]["num"].ToString();

                    string humi = ds.Tables[0].Rows[i]["humi"].ToString();
                    string temp = ds.Tables[0].Rows[i]["temp"].ToString();
                    string hic = ds.Tables[0].Rows[i]["hic"].ToString();

                    lvi.SubItems.Add(humi);
                    lvi.SubItems.Add(temp);
                    lvi.SubItems.Add(hic);
                    lvi.SubItems.Add(ds.Tables[0].Rows[i]["date"].ToString());

                    listView1.Items.Add(lvi);

                    //한레코드씩 그래프에 출력하자!
                    chart1.Series[0].Points.AddXY(i, double.Parse(humi)); //습도
                    chart1.Series[1].Points.AddXY(i, double.Parse(temp)); //온도
                    chart1.Series[2].Points.AddXY(i, double.Parse(hic)); //체감온도
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                string path = "./output.csv";
                FileStream fs = new FileStream(path,FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                for(int i = 0;i< listView1.Items.Count; i++)
                {
                    string line = "";
                    //0 1 2 3
                    for (int j = 0; j < 4; j++) { 
                        line += listView1.Items[i].SubItems[j].Text+",";
                    }
                    //4
                    line += listView1.Items[i].SubItems[4].Text;

                    sw.WriteLine(line);
                }


                sw.Close();
                sw.Dispose();
                fs.Close();
                fs.Dispose();
            }
        }
    }
}
