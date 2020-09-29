using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSC_Util
{
    public partial class ProcessForm : Form
    {
        public ProcessForm()
        {
            InitializeComponent();
        }
        public ProcessForm(string msg)
        {
            InitializeComponent();
            this.Message = msg;
        }

        private static Image m_Image = null;

        private EventHandler evtHandler = null;

        private ParameterizedThreadStart workAction = null;
        private object workActionArg = null;

        private Thread workThread = null;

        public string Message
        {
            get
            {
                return lbMessage.Text;
            }
            set
            {
                lbMessage.Text = value;
            }
        }

        public bool WorkCompleted = false;

        public Exception WorkException
        { get; private set; }

        public void SetWorkAction(ParameterizedThreadStart workAction, object arg)
        {
            this.workAction = workAction;
            this.workActionArg = arg;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (m_Image != null)
            {
                //获得当前gif动画下一步要渲染的帧。
                UpdateImage();

                //将获得的当前gif动画需要渲染的帧显示在界面上的某个位置。
                int x = (int)(panImage.ClientRectangle.Width - m_Image.Width) / 2;
                int y = 0;
                //e.Graphics.DrawImage(m_Image, new Rectangle(x, y, m_Image.Width, m_Image.Height));
                panImage.CreateGraphics().DrawImage(m_Image, new Rectangle(x, y, m_Image.Width, m_Image.Height));
            }
            if (this.WorkCompleted)
            {
                this.Close();
            }
        }

        private void ProcessForm_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(this.Owner.Left, this.Owner.Top);
                //MessageBox.Show(string.Format("X={0},Y={1}", this.Owner.Left, this.Owner.Top));
                this.Width = this.Owner.Width;
                this.Height = this.Owner.Height;
            }
            else
            {
                Rectangle screenRect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point((screenRect.Width - this.Width) / 2, (screenRect.Height - this.Height) / 2);
            }

            //为委托关联一个处理方法
            evtHandler = new EventHandler(OnImageAnimate);

            if (m_Image == null)
            {
                Assembly assy = Assembly.GetExecutingAssembly();
                //获取要加载的gif动画文件
                m_Image = Image.FromStream(assy.GetManifestResourceStream(assy.GetName().Name + ".Resources.jiazai.gif"));
            }
            //调用开始动画方法
            BeginAnimate();
        }

        private void BeginAnimate()
        {
            if (m_Image != null)
            {
                //当gif动画每隔一定时间后，都会变换一帧，那么就会触发一事件，该方法就是将当前image每变换一帧时，都会调用当前这个委托所关联的方法。
                ImageAnimator.Animate(m_Image, evtHandler);
            }
        }

        private void OnImageAnimate(Object sender, EventArgs e)
        {
            //该方法中，只是使得当前这个winform重绘，然后去调用该winform的OnPaint（）方法进行重绘)
            this.Invalidate();
        }

        private void UpdateImage()
        {
            ImageAnimator.UpdateFrames(m_Image);
        }

        private void StopAnimate()
        {
            m_Image = null;
            ImageAnimator.StopAnimate(m_Image, evtHandler);
        }

        private void ProcessForm_Shown(object sender, EventArgs e)
        {
            if (this.workAction != null)
            {
                workThread = new Thread(ExecWorkAction);
                workThread.IsBackground = true;
                workThread.Start();
            }
        }

        private void ExecWorkAction()
        {
            try
            {
                var workTask = new Task((arg) =>
                {
                    this.workAction(arg);
                },
                            this.workActionArg);

                workTask.Start();
                Task.WaitAll(workTask);
            }
            catch (Exception ex)
            {
                this.WorkException = ex;
            }
            finally
            {
                this.WorkCompleted = true;
            }

        }
    }

    public static class Common
    {

        public static void ShowProcessing(string msg, Form form, ParameterizedThreadStart work, object workArg = null)
        {
            ProcessForm processingForm = new ProcessForm(msg);
            dynamic expObj = new ExpandoObject();
            expObj.Form = processingForm;
            expObj.WorkArg = workArg;
            processingForm.SetWorkAction(work, expObj);
            processingForm.ShowDialog(form);
            if (processingForm.WorkException != null)
            {
                throw processingForm.WorkException;
            }
        }


    }
}
