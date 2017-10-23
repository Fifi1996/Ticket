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
    public partial class 修改密码 : Form
    {
        public static string id;

        public static string Id
        {
            get { return login.id; }
            set { login.id = value; }
        }

        string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\vs项目\ticket1\ticket1\Database1.mdf;Integrated Security=True";
        public 修改密码()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//确认修改密码
        {
            string pwd="";
            string id = login.Id;
            try
            {
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string sql = "select * from  customer where idno='" +id+"'";
               // MessageBox.Show(sql1);
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                         pwd = dr["pwd"].ToString();                     
                    }
                 }
                conn.Close();
                if (textBox1_old.Text.Trim() == pwd.Trim())
                {
                    if (textBox2_new.Text.Trim() == textBox3_newr.Text.Trim())//判断两次密码是否相等
                    {
                        string sql1 = "update customer set pwd=N'" + textBox2_new.Text.Trim() + "'" + " where idno='" + id + "'";
                        string sql2 = "update logins set pwd=N'" + textBox2_new.Text.Trim() + "'" + " where idno='" + id + "'";
                        //  string sql1 = "update customer set pwd=N'" + textBox2_new.Text.Trim() + "'";
                      // MessageBox.Show(sql1);
                        
                            conn.Open();
                            SqlCommand cmd1 = new SqlCommand(sql1, conn);
                            cmd1.ExecuteNonQuery();
                            SqlCommand cmd2 = new SqlCommand(sql2, conn);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("密码修改成功");
                       
                    //   catch(Exception)
                    //{
                    //    MessageBox.Show("密码修改失败！");
                    //    return ;
                    //}   
                    }
                    else
                    {
                        MessageBox.Show("两次密码输入不一致！");
                        textBox1_old.Focus();
                        textBox2_new.Clear();
                        textBox3_newr.Clear();
                        return;
                    }
                        }
                        
                    }
       
              catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
         