using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bookshop
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            populate();
        }



        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\24891\Documents\WhiteBookDb.mdf;Integrated Security=True;Connect Timeout=30");
        
        int key = 0, Stock = 0;


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
            BTbllibDGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void UpdateOeder()
        {
            int newQty = Stock - Convert.ToInt32(QtyTb.Text);
            try
            {
                conn.Open();
                String query = "update  Booktbl set BQty=" + newQty + " where BId =" + key + " ";
                SqlCommand cmd = new SqlCommand(query, conn);
                //执行数据库更新；
                cmd.ExecuteNonQuery();
                MessageBox.Show("添加购物车成功！！！");
                conn.Close();
                populate();
                rest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        //添加购物车
        int n = 0, GrdTotal = 0;
        private void AddtoBillBtn_Click(object sender, EventArgs e)
        {

            if (QtyTb.Text == "") {
                MessageBox.Show("请填写数据");

            } else if (Convert.ToInt32(QtyTb.Text) > Stock)
            {
                MessageBox.Show("库存不足");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = BTitile.Text;
                newRow.Cells[2].Value = PriceTb.Text;
                newRow.Cells[3].Value = QtyTb.Text;
                newRow.Cells[4].Value = total;
                BillDGV.Rows.Add(newRow);
                n++;
                UpdateOeder();
                GrdTotal = GrdTotal + total;
                label5.Text = "$" + GrdTotal.ToString();
                rest();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTbllibDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitile.Text = BTbllibDGV.SelectedRows[0].Cells[1].Value.ToString();
            PriceTb.Text = BTbllibDGV.SelectedRows[0].Cells[5].Value.ToString();
            //QtyTb.Text = BTbllibDGV.SelectedRows[0].Cells[4].Value.ToString();

            //if判断是否选定数据，如果选定数据则把选定的值赋给key;
            if (BTitile.Text == "")
            {
                key = 0;
                Stock = 0;
            }
            else
            {
                key = Convert.ToInt32(BTbllibDGV.SelectedRows[0].Cells[0].Value.ToString());
                Stock = Convert.ToInt32(BTbllibDGV.SelectedRows[0].Cells[4].Value.ToString());
            }
        }

        private void rest()
        {
            BTitile.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";
        }
        //结算
        private void jiesuan_Click(object sender, EventArgs e)
        {
           
            if (BillDGV.Rows[0].Cells[0].Value == null)
            {

                MessageBox.Show("信息缺失！！！");

            }
            else
            {
                //打印
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
                //用try语句
                try
                {
                    conn.Open();
                    //使用sql构造插入语句，将用户输入的信息插入到 Booktbl 表中。
                    String query = "insert into OrderTbl (UName,Amount)  values('" + CatUsername.Text + "','"+ GrdTotal + "' )";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    //使用 SqlCommand 对象执行插入操作
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("成功！！！");
                    conn.Close();
                    
                    //调用 populate() 方法刷新显示数据。
                    //调用 Reset() 方法重置输入框。
                    //populate();
                    //rest();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                GrdTotal = 0;
            }
            label5.Text = "";
            //UpdateOeder();
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;

        

        private void label9_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            CatUsername.Text = Login.UrserName;
        }

        //重置
        private void RestBtn_Click(object sender, EventArgs e)
        {
            rest();
        }

        string prodnanme;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try {
            //打印标头；并设置 字体，字号，字重，字体颜色，打印字的左上角的X坐标；    
            e.Graphics.DrawString("小白书店", new Font("思源黑体", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("编号 产品 价格 数量 总计", new Font("思源黑体", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
               //抓取购物车信息；
                prodid = Convert.ToInt32(row.Cells["Column7"].Value);
                prodnanme = "" + row.Cells["Column8"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column9"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column10"].Value);
                tottal = Convert.ToInt32(row.Cells["Column11"].Value);
                //打印信息
                e.Graphics.DrawString("" + prodid, new Font("思源黑体", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodnanme, new Font("思源黑体", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("思源黑体", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("思源黑体", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("思源黑体", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos = pos + 20;
            }
            //订单总额和尾头；
            e.Graphics.DrawString("订单总额:  $" + GrdTotal, new Font("思源黑体", 12, FontStyle.Bold), Brushes.Crimson, new Point(60, pos + 50));
            e.Graphics.DrawString("*******小白书店*******", new Font("思源黑体", 10, FontStyle.Bold), Brushes.Crimson, new Point(40, pos + 85));
            BillDGV.Rows.Clear();
            BillDGV.Refresh();
           //重置打印的y坐标位置；
            pos = 100;
           //结算价重置；
            //GrdTotal = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "打印错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
}

        }

       



        
    }
    

