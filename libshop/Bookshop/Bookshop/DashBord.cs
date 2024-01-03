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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bookshop
{
    public partial class DashBord : Form
    {
        public DashBord()
        {
            InitializeComponent();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //连接数据库
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24891\Documents\WhiteBookDb.mdf;Integrated Security=True;Connect Timeout=30");
        
      
        
        
        
        //退出
        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
        //书籍管理
        private void label1_Click(object sender, EventArgs e)
        {
            Books obj = new Books();
            obj.Show();
            this.Hide();
        }
        //用户管理
        private void label6_Click(object sender, EventArgs e)
        {
            Users obj = new Users();
            obj.Show();
            this.Hide();
        }
        //账户管理
        private void label5_Click(object sender, EventArgs e)
        {
            DashBord obj = new DashBord();
            obj.Show();
            this.Hide();
        }

        private void DashBord_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT SUM(BQty) AS TotalStock FROM Booktbl", conn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            BooksLib.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT SUM(Amount) AS TotalStock FROM OrderTbl", conn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            AmountLib.Text = dt2.Rows[0][0].ToString();

            SqlDataAdapter sda3 = new SqlDataAdapter("SELECT Count(*) FROM AdminTable", conn);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            users.Text = dt3.Rows[0][0].ToString();
            conn.Close();
        }
    }
}
