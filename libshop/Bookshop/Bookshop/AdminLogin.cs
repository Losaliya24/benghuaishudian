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

namespace Bookshop
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        //连接数据库
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24891\Documents\WhiteBookDb.mdf;Integrated Security=True;Connect Timeout=30");

        

        //管理员登录
        private void llogin_Click(object sender, EventArgs e)
        {
            string username = Uname.Text;
            string password = Upasswd.Text;
            try
            {
                //用sql语句 查询 管理员账户名单表 并获取 账户名 ，密码，以及 权限状态 （UserRole）
                string query = "SELECT * FROM AdminTable WHERE UName = @UName AND UPassword = @UPassword";

                
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))//执行查询操作；
                    {
                        cmd.Parameters.AddWithValue("@UName", username);
                        cmd.Parameters.AddWithValue("@UPassword", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                    //SqlDataReader 是 ADO.NET 中用于从数据库读取数据的类。
                    //它提供了一种逐行读取查询结果集的方式，
                    //是一种轻量级、高性能的数据读取方式。
                    //ExecuteReader() 方法返回一个 SqlDataReader 对象，
                    //该对象允许你按行读取查询的结果。
                    {
                        if (reader.Read())
                            {
                                // 用户存在，获取用户角色
                                string userRole = reader["UserRole"].ToString();

                                // 判断用户角色
                                if (userRole == "是")
                                {
                                    // 是管理员，执行管理员登录操作
                                    MessageBox.Show("管理员登录成功");
                                    // 执行管理员界面操作
                                    Books obj = new Books();
                                    obj.Show();
                                    this.Close();
                                }
                                else
                                {
                                   
                                    MessageBox.Show("请返回普通用户界面");
                                    
                                }
                            }
                            else
                            {
                                // 用户不存在或密码错误
                                MessageBox.Show("用户名或密码错误");
                            }
                        }
                    }
                }
            
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Ulogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

 
    }
}
