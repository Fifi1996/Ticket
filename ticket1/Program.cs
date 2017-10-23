using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data .SqlClient ;

namespace ticket1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string cstr=@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\vs项目\ticket1\ticket1\Database1.mdf;Integrated Security=True";
            try
            {
                SqlConnection conn = new SqlConnection(cstr);
                conn.Open();
              //  MessageBox.Show("数据库连接成功！");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
