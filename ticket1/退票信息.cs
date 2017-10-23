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
    public partial class 退票信息 : Form
    {
        public 退票信息()
        {
            InitializeComponent();
        }
        string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\vs项目\ticket1\ticket1\Database1.mdf;Integrated Security=True";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 退票信息_Load(object sender, EventArgs e)
        {

            try
            {
                string sql = "select * from orders";
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//退票
        {          
            try
            {
                SqlConnection conn = new SqlConnection(str);
                conn.Open();              
                string sql = "delete from orders where orno='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
              //  string sql1 = string.Format("insert into returns(orno,fno,date,price,idno,tel)values ('{0}',N'{1}',N'{2}',N'{3}',N'{4}','{5}')", dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(), tel);
               // MessageBox.Show(sql);
                MessageBox.Show("退票成功");
                string sql2 = "update ticket set yupiao=yupiao+1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2= new SqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select * from orders", conn);
                sda.Fill(ds);  //填充数据集
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
