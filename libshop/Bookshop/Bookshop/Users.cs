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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            //调用populate函数，使得数据库数据在一开始便被加载；
            populate();
        }





        //建立数据库连接
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24891\Documents\WhiteBookDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Reset()
        {
            //让所有文本框输出为空；
            UnameTb.Text = "";
            PhoneTb.Text = "";
            PassTb.Text = "";
            AddTb.Text = "";
            Bleixingtbl.SelectedIndex = -1;
        }

        private void populate()
        {
            //打开数据库
            conn.Open();
            //查询数据库所有数据
            string querysql = "select * from AdminTable";
            //SqlDataAdapter 是 ADO.NET 中的一个类，用于从数据库中检索数据并将其填充到数据集（DataSet）中。
            //构造函数接受两个参数：
            //querysql：要执行的 SQL 查询语句。
            //conn：表示数据库连接的 SqlConnection 对象。
            SqlDataAdapter sda = new SqlDataAdapter(querysql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        //保存按钮（添加）
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //if语句判断：如果文本框中有一个为空，则输出“信息缺失”；
            if (UnameTb.Text == "" || PhoneTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || Bleixingtbl.SelectedIndex == -1)
            {

                MessageBox.Show("信息缺失！！！");

            }
            else
            {
                //用try语句
                try
                {
                    conn.Open();
                    //使用sql构造插入语句，将用户输入的信息插入到 Booktbl 表中。
                    String query = "insert into AdminTable  values('" + UnameTb.Text + "','" + PhoneTb.Text + "','" + AddTb.Text + "','" + PassTb.Text + "','"+Bleixingtbl.SelectedItem.ToString()+"')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    //使用 SqlCommand 对象执行插入操作
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("成功！！！");
                    conn.Close();
                    //调用 populate() 方法刷新显示数据。
                    //调用 Reset() 方法重置输入框。
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }


        //退出按钮
        private void label7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //重置按钮
        private void RestBtn_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 从选定的行中获取数据并将其显示在相应的文本框和 ComboBox（种类下拉列表）中；
            UnameTb.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            AddTb.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
            PassTb.Text = UserDGV.SelectedRows[0].Cells[4].Value.ToString();
            Bleixingtbl.SelectedItem = UserDGV.SelectedRows[0].Cells[5].Value.ToString();
            //if判断是否选定数据，如果选定数据则把选定的值赋给key;
            if (UnameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UserDGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }
        //删除按钮

        private void button4_Click(object sender, EventArgs e)
        {
            //key为空，没有选定数据，数据为空，返回“删除失败”；
            if (key == 0)
            {

                MessageBox.Show("信息缺失！！！删除失败。");

            }
            else
            //不为空，则删除选定的数据；
            {
                try
                {
                    conn.Open();
                    String query = "delete from AdminTable where UId = " + key + "";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除成功！！！");
                    conn.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if语句判断：如果文本框中有一个为空，则输出“信息缺失”；
            if (UnameTb.Text == "" || PhoneTb.Text == "" || AddTb.Text == "" || PassTb.Text == "" || Bleixingtbl.SelectedIndex == -1)
            {

                MessageBox.Show("信息缺失！！！");

            }
            else
            {
                //用try语句
                try
                {
                    conn.Open();
                    //使用sql构造插入语句，将用户输入的信息插入到 Booktbl 表中。
                    String query = "update  AdminTable set UName ='" + UnameTb.Text + "',UPhone='" + PhoneTb.Text + "',UAdd='" + AddTb.Text + "',UPassword='" + PassTb.Text + "',UserRole='" + Bleixingtbl.SelectedItem.ToString() +"'  where UId =" + key + " ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    //使用 SqlCommand 对象执行插入操作
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("成功！！！");
                    conn.Close();
                    //调用 populate() 方法刷新显示数据。
                    //调用 Reset() 方法重置输入框。
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
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

        
    }
}

