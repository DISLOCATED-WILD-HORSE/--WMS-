using HSC_Update.Progress;
using SharpCompress.Common;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace HSC_Update
{
    public class UpdateHelper
    {
        /// <summary>
        /// 检查服务端版本
        /// </summary>
        public static bool CheckServerEdition()
        {
            string url = ConfigHelper.GetContextNode("serviceUrl", ConfigHelper.XmlConfig());
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            var ConfigClient = ConfigHelper.GetClientConfig();
            var ConfigServer = ConfigHelper.GetServerConfig();
            if (ConfigClient == null || ConfigServer == null)
            {
                MessageBox.Show("获取升级文件发生异常，已结束本次更新！");
                return false;
            }
            //静默更新开启就开始更新
            if (ConfigServer.IsSilentUpgrade)
            {
                #region 验证
                //比较版本号
                if (ConfigClient.Version == ConfigServer.Version)
                {
                    MessageBox.Show("目前程序已是最新版本,不用更新！");
                    Process p = Process.Start(path + Const.ProgramName);
                    return false;
                }
                if (int.Parse(ConfigClient.Version.Replace(".", "")) > int.Parse(ConfigServer.Version.Replace(".", "")))
                {
                    MessageBox.Show("目前服务端版本可能已经发生异常,请联系管理人员！");
                    return false;
                }
                #endregion
                //下载之前文件夹存在则删除
                if (Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "temp")))
                {
                    Directory.Delete(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "temp"), true);
                }

                ProgressManager pm = new ProgressManager();
                pm.backWork = DoWithProcess;
                pm.txtInfo = "正在下载中";
                pm.BackWorkCompleted += new EventHandler<BackgroundWorkerEventArgs>(process_BackgroundWorkerCompleted);
                pm.Start();

                
            }
            Application.Exit();
            Process proc = Process.Start(path + Const.ProgramName);
            if (proc != null)
            {
                proc.WaitForExit();
            }
            return true;
        }

        public static void KillAll(string processName)
        {
            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    if (process.ProcessName.StartsWith(processName))
                    {
                        process.Kill();
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        public static bool StartDownFile(string url, string path, string fileName)
        {
            string tempPath = path + @"\temp";
            System.IO.Directory.CreateDirectory(tempPath);  //创建临时文件目录
            string tempFile = tempPath + @"\" + System.IO.Path.GetFileName(path) + ".temp"; //临时文件
            if (System.IO.File.Exists(tempFile))
            {
                System.IO.File.Delete(tempFile);    //存在则删除
            }
            
            using (FileStream fs = new FileStream(tempFile, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                // 设置参数
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //发送请求并获取相应回应数据
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                Stream responseStream = response.GetResponseStream();
                //创建本地文件写入流
                //Stream stream = new FileStream(tempFile, FileMode.Create);
                //byte[] bArr = new byte[1024];
                WebClient wbc = new WebClient();
                byte[] buffer = wbc.DownloadData(url);
                //string res = Encoding.ASCII.GetString(buffer);
                int size = responseStream.Read(buffer, 0, (int)buffer.Length);
                while (size > 0)
                {
                    fs.Write(buffer, 0, size);
                    size = responseStream.Read(buffer, 0, (int)buffer.Length);
                }
                fs.Close();
                responseStream.Close();
                System.IO.File.Move(tempFile, tempPath + @"\" + fileName);
                return true;
            }
        }

        public static bool DownConfigFile(string url, string allPath)
        {
            using (FileStream fs = new FileStream(allPath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite))
            {
                // 设置参数
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //发送请求并获取相应回应数据
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                Stream responseStream = response.GetResponseStream();
                //创建本地文件写入流
                //Stream stream = new FileStream(tempFile, FileMode.Create);
                byte[] bArr = new byte[1024];
                int size = responseStream.Read(bArr, 0, (int)bArr.Length);
                while (size > 0)
                {
                    fs.Write(bArr, 0, size);
                    size = responseStream.Read(bArr, 0, (int)bArr.Length);
                }
                fs.Close();
                responseStream.Close();
                return true;
            }
        }

        /// <summary>
        /// 复制文件夹下的所有文件
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>
        public static void copyDirectory(string sourceDirName, string destDirName)
        {
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            if (destDirName[destDirName.Length - 1] != Path.DirectorySeparatorChar)
                destDirName = destDirName + Path.DirectorySeparatorChar;

            string[] files = Directory.GetFiles(sourceDirName);
            foreach (string file in files)
            {
                File.Copy(file, destDirName + Path.GetFileName(file), true);
            }
            string[] dirs = Directory.GetDirectories(sourceDirName);
            foreach (string dir in dirs)
            {
                copyDirectory(dir, destDirName + Path.GetFileName(dir));
            }
        }
        public static void StartUnzipFile(string surl, string durl)
        {
            using (Stream stream = File.OpenRead(surl))
            {
                var reader = ReaderFactory.Open(stream);
                while (reader.MoveToNextEntry())
                {
                    if (!reader.Entry.IsDirectory)
                    {
                        //不解压更新程序和SharpCompress库
                        if (!reader.Entry.Key.Contains(Assembly.GetExecutingAssembly().GetName().Name) && !reader.Entry.Key.Contains("SharpCompress")
                            && !reader.Entry.Key.Contains("log4net.dll") && !reader.Entry.Key.Contains("localConfig.xml"))
                        {
                            reader.WriteEntryToDirectory(durl, new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
                        }
                    } 
                }
            }
        }

        private static void process_BackgroundWorkerCompleted(object sender, BackgroundWorkerEventArgs e)
        {
            if (e.BackGroundException == null)
            {
                MessageBox.Show("更新完成，" + ConfigHelper.GetServerConfig().Msg);
            }
            else
            {
                MessageBox.Show("异常:" + e.BackGroundException.Message);
            }
        }

        private static void DoWithProcess(Action<int> percent)
        {
            string url = ConfigHelper.GetContextNode("serviceUrl", ConfigHelper.XmlConfig());
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            int i = 0;
            foreach (string fileName in ConfigHelper.GetServerConfig().Files)
            {
                Thread.Sleep(500);
                //下载文件失败
                if (!StartDownFile(url + fileName, path, fileName))
                {
                    MessageBox.Show("升级程序下载失败，重试无效请联系管理人员！");
                    return;
                }
                copyDirectory(path + "temp", path);
                //解压文件
                StartUnzipFile(path + Path.DirectorySeparatorChar + fileName, path);
                i++;
                percent(i);
            }
            //下载XML配置文件
            DownConfigFile(url + Const.FileName, path + Path.DirectorySeparatorChar + Const.FileName);
            i = 100;
            
            percent(i);
            Thread.Sleep(500);
            //for (int i = 0; i <= 100; i++)
            //{
            //    Thread.Sleep(50);
            //    percent(i);
            //}
        }
    }
}
