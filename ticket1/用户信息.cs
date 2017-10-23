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
    public partial class 用户信息 : Form
    {
        public 用户信息()
        {
            InitializeComponent();
        }
        string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\vs项目\ticket1\ticket1\Database1.mdf;Integrated Security=True";
        private void 用户信息_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)//查看用户信息
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            修改密码 a = new 修改密码();
            a.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)//显示信息
        {
            try
            {
                
                string sql = "select * from customer where idno='"+textBox1.Text.Trim()+"'";


                //  MessageBox.Show(sql);
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(ds);  //填充数据集
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)//注销用户
        {
            try
            {

                string sql = "delete from customer where idno='" + textBox1.Text.Trim() + "'";
                string sql1 = "delete from logins where idno='" + textBox1.Text.Trim() + "'";
                // MessageBox.Show(sql);
                // MessageBox.Show(sql1);
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd1= new SqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("用户已注销");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
