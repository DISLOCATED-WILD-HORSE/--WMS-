using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSC_SYPrintSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doDownload("http://192.168.30.86:8080/SY/Release.zip", "Release.zip");
        }

        private DateTime StartTime;
        private void doDownload(string url, string fileName = "")
        {

            label1.Text = "正在下载：" + url;//label框提示下载文件
            if (fileName.Length == 0)
            {
                fileName = url.Substring(url.LastIndexOf("/") + 1);
            }
            StartTime = DateTime.Now;
            progressBar1.Value = 0;//初始化单个文件下载条
            WebClient ws = new WebClient();
            ws.DownloadProgressChanged += OnDownloadProgressChanged;
            //绑定下载事件，以便于显示当前进度
            ws.DownloadFileCompleted += OnDownloadFileCompleted;
            //绑定下载完成事件，以便于计算总进度
            ws.DownloadFileAsync(new Uri(url), Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName));
            //调用DownloadFileAsync方法下载文件
            //DownloadFileAsync有2个重载，另一个我没搞明白最后一个参数该传什么，有哪位朋友知道的，请留言告诉我谢谢
            //upapp是我一个实体类，UpdateURL存放了下载的地址（值为http://www.harde.com.cn/SoftUpdate/）
            //Path.Combine()是一个用来连接地址的方法，我将在另一日志中详细对其介绍
        }

        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //在网上看到有朋友这么来控制进度条，我觉得麻烦，毕竟有省事的为什么我要麻烦一番……

            //this.SetProcessBar(e.ProgressPercentage, (int)((nDownloadedTotal + e.BytesReceived) * 100 / total));
            progressBar1.Value = e.ProgressPercentage;
            var s = (DateTime.Now - StartTime).TotalSeconds;
            var sd = ReadableFilesize(e.BytesReceived / s);
            label1.Text = "下载速度" + sd + "/秒" + ",已下载" + ReadableFilesize(e.BytesReceived) + "/总计" + ReadableFilesize(e.TotalBytesToReceive);//一个label框，用来显示当前下载的数据
        }

        private void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("complied!");
        }

        private string ReadableFilesize(double size)
        {
            String[] units = { "B", "KB", "MB", "GB", "TB", "PB" };
            double mod = 1024.0;
            int i = 0;
            while (size >= mod)
            {
                size /= mod;
                i++;
            }
            return Math.Round(size) + units[i];
        }
    }
}
