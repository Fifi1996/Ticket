using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ticket1
{
    public partial class 航班信息 : Form
    {
        public static int orno = 0;         
        string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\vs项目\ticket1\ticket1\Database1.mdf;Integrated Security=True";
        public 航班信息()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fno="";
                string chufa = comboBox1_chufa.Text.Trim();
                string mudi = comboBox1_mudi.Text.Trim();
                string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                string sql = "select * from flight where chufa=N'" + comboBox1_chufa.Text.Trim() + "'" + " and mudi=N'" + comboBox1_mudi.Text.Trim() + " '" + "and date='" + date + "'";
               // MessageBox.Show(sql);
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        fno = dr["fno"].ToString();
                    }
                }
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
              string sql1 = string.Format("select * from ticket where fno='"+fno+"'");
              // MessageBox.Show(sql1);
               SqlDataAdapter sda = new SqlDataAdapter(sql1,conn);
               sda.Fill(ds);  //填充数据集
                dataGridView1.DataSource=ds.Tables[0];
                conn.Close();
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)//购票
        {
            orno++;       
            string id = login.Id;
            try
            {    
                string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                string sql = string.Format("insert into orders(orno,fno,fclass,date,price,idno) values('{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}')",orno,dataGridView1.CurrentRow.Cells[0].Value.ToString(),dataGridView1.CurrentRow.Cells[1].Value.ToString(),date,dataGridView1.CurrentRow.Cells[2].Value.ToString(),id);
                //MessageBox.Show(sql);
              //  string sql3 = string.Format("insert into returns(reno,fno,fclass,date,price,idno) values('{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}')", orno, dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), date, dataGridView1.CurrentRow.Cells[2].Value.ToString(), id);
              // SqlCommand com = new SqlCommand();                     
              //com.CommandText = "select yupiao from ticket";
              //SqlDataReader dr = com.ExecuteReader();
              //if (dr.Read())
              //{
              //    if (String.Equals(dr[0].ToString(), "0"))
              //    //if(dr[0].ToString()=='0')
              //    {
              //        MessageBox.Show("余票以为0，不能购买！");
              //    }
              //}

                string sql2 = "update ticket set yupiao=yupiao-1";
              
                // MessageBox.Show(sql);
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
               SqlCommand cmd = new SqlCommand(sql, conn);
                 cmd.ExecuteNonQuery();
                 SqlCommand cmd2 = new SqlCommand(sql2, conn);
                 cmd2.ExecuteNonQuery();
               //  SqlCommand cmd3 = new SqlCommand(sql3, conn);
                // cmd3.ExecuteNonQuery(); 
                订单信息 a = new 订单信息();
                a.ShowDialog();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.DialogResult = DialogResult.Cancel;
        }
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
          
        }
    }
