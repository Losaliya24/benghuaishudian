using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bookshop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //连接数据库
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24891\Documents\WhiteBookDb.mdf;Integrated Security=True;Connect Timeout=30");




        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //登录
        public static string UrserName = "";
        private void llogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTable where UName ='" + Uname.Text+"' and UPassword = '"+Upasswd.Text+"' ",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            

            if (dt.Rows[0][0].ToString() == "1")
            {
                UrserName = Uname.Text;
                Billing obj = new Billing();
                obj.Show();
                this.Hide();
              conn.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误"); 
            }
            conn.Close();
        }

        private void Ulogin_Click(object sender, EventArgs e)
        {
            AdminLogin obj = new AdminLogin();
            obj.Show();
            this.Hide();
        }
    }
    }

