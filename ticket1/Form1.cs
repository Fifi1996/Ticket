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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }
        private void 航班信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            航班信息 a = new 航班信息();
            a.Show();
        }
        private void 订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            订单信息 a = new 订单信息();
            a.Show();
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            用户信息 a = new 用户信息();
            a.Show();
        }

        private void 退票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            航空公司信息 a =  new 航空公司信息 ();
            a.Show();

        }

        private void 退票信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            退票信息 a = new 退票信息();
            a.ShowDialog();
        }  
    }
}
