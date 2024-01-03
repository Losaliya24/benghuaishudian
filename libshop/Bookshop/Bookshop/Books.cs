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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
            //调用populate函数，使得数据库数据在一开始便被加载；
            populate();
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
        private void populate()
        {
            //打开数据库
            conn.Open();
            //查询数据库所有数据
            string querysql = "select * from Booktbl";
            //SqlDataAdapter 是 ADO.NET 中的一个类，用于从数据库中检索数据并将其填充到数据集（DataSet）中。
            //构造函数接受两个参数：
            //querysql：要执行的 SQL 查询语句。
            //conn：表示数据库连接的 SqlConnection 对象。
            SqlDataAdapter sda = new SqlDataAdapter(querysql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BTbllib.DataSource = ds.Tables[0];
            conn.Close();
        }

        //定义一个名为“筛选”的函数，供其他控件调用：
        private void Filter()
        {
            if (Bleixingtbl.SelectedItem != null)
            {
                // 构造 SQL 查询语句，通过 Bleixingtbl.SelectedItem.ToString() 获取 ComboBox 中选择的项，
                // 然后使用 WHERE 子句来筛选 Booktbl 表中 BCat 列等于所选项的记录。
                string querysql = "select * from Booktbl where BCat ='" + Bleixingtbl.SelectedItem.ToString() + "'   ";
                SqlDataAdapter sda = new SqlDataAdapter(querysql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);

                // 将 DataSet 中的第一个表格绑定到名为 BTbllib 的控件上，以在用户界面上显示数据
                BTbllib.DataSource = ds.Tables[0];
            }
            else
            {
                

                // 如果没有选择项，则重新加载所有数据
                populate();
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24891\Documents\BookShopLib.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True");

        //连接数据库
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24891\Documents\WhiteBookDb.mdf;Integrated Security=True;Connect Timeout=30");


        private void bshaixuan_Click(object sender, EventArgs e)
        {
            populate();
            Bleixingtbl.SelectedIndex = -1;
        }
        //名为重置的方法；
        private void Reset()
        {
            //让所有文本框输出为空；
            BTitile.Text = "";
            Author.Text = "";
            Bleixing.Text = "";
            Bmany.Text = "";
            Bprice.Text = "";
        }
        

        int key = 0;


        

        //数据库 文本框绑定
        private void BTbllib_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // // 从选定的行中获取数据并将其显示在相应的文本框和 ComboBox（种类下拉列表）中；
            BTitile.Text = BTbllib.SelectedRows[0].Cells[1].Value.ToString();
            Author.Text = BTbllib.SelectedRows[0].Cells[2].Value.ToString();
            Bleixing.SelectedItem = BTbllib.SelectedRows[0].Cells[3].Value.ToString();
            Bmany.Text = BTbllib.SelectedRows[0].Cells[4].Value.ToString();
            Bprice.Text = BTbllib.SelectedRows[0].Cells[5].Value.ToString();
            //if判断是否选定数据，如果选定数据则把选定的值赋给key;
            if (BTitile.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(BTbllib.SelectedRows[0].Cells[0].Value.ToString());

            }
        }
        //筛选控件
        private void Bleixingtbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
        //编辑
        private void update_Click_1(object sender, EventArgs e)
        {
            //if判断上面四个所有文本框中是否一个或多个为空；
            if (BTitile.Text == "" || Author.Text == "" || Bleixing.SelectedIndex == -1 || Bmany.Text == "" || Bprice.Text == "")
            {

                MessageBox.Show("信息缺失！！！编辑失败。");

            }
            else
            {

                //同上；
                try
                {
                    conn.Open();
                    String query = "update  Booktbl set BTitle ='" + BTitile.Text + "',BAuthor='" + Author.Text + "',BCat='" + Bleixing.SelectedItem.ToString() + "',BQty=" + Bmany.Text + ",BPrice=" + Bprice.Text + " where BId =" + key + " ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //执行数据库更新；
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("更改成功！！！");
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
        //保存
        private void save_Click_1(object sender, EventArgs e)
        {
            //if语句判断：如果文本框中有一个为空，则输出“信息缺失”；
            if (BTitile.Text == "" || Author.Text == "" || Bleixing.SelectedIndex == -1 || Bmany.Text == "" || Bprice.Text == "")
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
                    String query = "insert into Booktbl (BTitle,BAuthor,BCat,BQty,BPrice) values('" + BTitile.Text + "','" + Author.Text + "','" + Bleixing.SelectedItem.ToString() + "','" + Bmany.Text + "','" + Bprice.Text + "')";

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
        //删除
        private void delet_Click_1(object sender, EventArgs e)
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
                    String query = "delete from Booktbl where BId = " + key + "";
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
        //重置
        private void chongzhi_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
        //刷新
        private void bshaixuan_Click_1(object sender, EventArgs e)
        {
            populate();
            Bleixingtbl.SelectedIndex = -1;

        }
        //退出
        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
            conn.Close();
        }

        
    }
}
 