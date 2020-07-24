using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSC_Update.Progress
{
    public class ProgressManager
    {
        public ProgressManager()
        {
            exception = new BackgroundWorkerEventArgs();
            backgroundWorker = new BackgroundWorker();
            progressForm = new ProgressForm();
            progressForm.ProcessStyle = ProgressBarStyle.Continuous;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(BackActionWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackFinishedWork);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(BackWorkProgressChanged);
        }

        //后台线程操作
        private BackgroundWorker backgroundWorker;
        //进度条窗口
        private ProgressForm progressForm;
        //异常信息类
        private BackgroundWorkerEventArgs exception;
        //进度条显示文本的信息
        private string _txtInfo;
        public string txtInfo
        {
            set { _txtInfo = value; }
        }
        //后台执行的操作，参数类型为一个带int类型的委托
        public Action<Action<int>> backWork;
        //后台任务执行完后的事件
        public event EventHandler<BackgroundWorkerEventArgs> BackWorkCompleted;
        /// <summary>
        /// 开始执行
        /// </summary>
        public void Start()
        {
            backgroundWorker.RunWorkerAsync();
            progressForm.ShowDialog();
        }
        /// <summary>
        /// 报告完成百分比
        /// </summary>
        /// <param name="i"></param>
        private void ReportPercent(int i)
        {
            if (i >= 0 && i <= 100)
            {
                backgroundWorker.ReportProgress(i);
            }
        }

        /// <summary>
        /// 后台线程任务执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void BackActionWork(object sender, DoWorkEventArgs eventArgs)
        {
            try
            {
                backWork?.Invoke(this.ReportPercent);
            }
            catch (Exception e)
            {
                exception.BackGroundException = e;
            }
        }

        /// <summary>
        /// 进度的显示操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackWorkProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressForm.MessageInfo = _txtInfo + ",已完成：" + e.ProgressPercentage.ToString() + "%";
            progressForm.ProcessValue = e.ProgressPercentage;
        }

        /// <summary>
        /// 后台线程任务完成后的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackFinishedWork(object sender, RunWorkerCompletedEventArgs e)
        {
            if (progressForm.Visible == true)
            {
                progressForm.Close();
            }
            this.BackWorkCompleted?.Invoke(null, exception);
        }
    }
    /// <summary>
    /// 异常类
    /// </summary>
    public class BackgroundWorkerEventArgs : EventArgs
    {
        /// <summary>
        /// 后台程序运行时抛出的异常
        /// </summary>
        public Exception BackGroundException { get; set; }
    }
}
