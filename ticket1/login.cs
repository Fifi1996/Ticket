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
    public partial class login : Form
    {
        public static string id;

        public static string Id
        {
            get { return login.id; }
            set { login.id = value; }
        }
        string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\vs项目\ticket1\ticket1\Database1.mdf;Integrated Security=True";
       //string idno = textBox_id.Text.Trim();

        public login()
        {
            InitializeComponent();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string sql = "select * from logins where idno=" + textBox_id.Text;
                login.Id = textBox_id.Text;
               // MessageBox.Show(id);
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string pwd = dr["PWD"].ToString();
                        if (textBox_pwd.Text.Trim() == pwd.Trim())
                        {
                            MessageBox.Show("欢迎进入机票预定系统！");
                            
                            Form1 a = new Form1();
                           a.ShowDialog();                     
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("用户名或密码错误！");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();  //退出程序
        }

        private void button1_Click(object sender, EventArgs e)
        {
            用户注册 a = new 用户注册();
            a.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }



}
