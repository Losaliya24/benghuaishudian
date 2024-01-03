using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class Slpash : Form
    {
        public Slpash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 在窗体加载时启动计时器
            timer1.Start();
        }

        //设置一个值 以用来储存计时器的时间刻 把0作为计时器的初始值；
        int startick = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //让计时器的值自加1；
            startick +=1 ;
            //获取进度条控件的属性值Value 使其等于时间刻；
            Myprogress.Value = startick;
            //获取标签PerccentageLbi的文本属性text使其输出时间刻并附带单位“%”；
            PercentageLbi.Text =startick + "%";
            //用if语句 是当且仅当进度条的值（即计时刻的值 =100时）：
            //充值计时刻 =0； 计时器停止； 
            if (Myprogress.Value == 100) {
                startick = 0;
                timer1.Stop();
                //创建一个新的 Login 对象；
                Login login = new Login();
                //调用login 并显示登录窗口；
                login.Show();
                //弹出登录页面的同时，隐藏加载页面； 
                this.Hide();
            }
        }

        

        
    }
}
