﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSC_Util
{
    public partial class NForm : Form
    {
        double formWidth;//窗体原始宽度
        double formHeight;//窗体原始高度
        double scaleX;//水平缩放比例
        double scaleY;//垂直缩放比例
        Dictionary<string, string> controlInfo = new Dictionary<string, string>();

        /// <summary>
        /// 实现窗体内控件随窗体自适应
        /// </summary>
        /// <param name="CrlContainer"></param>
        protected void GetAllInitInfo(Control CrlContainer)
        {
            if (CrlContainer.Parent == this)
            {
                formWidth = Convert.ToDouble(CrlContainer.Width);
                formHeight = Convert.ToDouble(CrlContainer.Height);
            }
            foreach (Control item in CrlContainer.Controls)
            {
                if (item.Name.Trim() != "")
                    controlInfo.Add(item.Name, (item.Left + item.Width / 2) + "," + (item.Top + item.Height / 2) + "," + item.Width + "," + item.Height + "," + item.Font.Size + "," + item.Font.Bold);
                if ((item as UserControl) == null && item.Controls.Count > 0)
                    GetAllInitInfo(item);
            }
        }

        private void ControlsChangeInit(Control CrlContainer)
        {
            scaleX = (Convert.ToDouble(CrlContainer.Width) / formWidth);
            scaleY = (Convert.ToDouble(CrlContainer.Height) / formHeight);
        }
        private void ControlsChange(Control CrlContainer)
        {
            double[] pos = new double[5];//pos数组保存当前控件中心Left,Top,控件Width,控件Height,控件字体Size
            foreach (Control item in CrlContainer.Controls)
            {
                if (item.Name.Trim() != "")
                {
                    if ((item as UserControl) == null && item.Controls.Count > 0)
                        ControlsChange(item);
                    string[] strs = controlInfo[item.Name].Split(',');
                    for (int j = 0; j < 5; j++)
                    {
                        pos[j] = Convert.ToDouble(strs[j]);
                    }
                    double itemWidth = pos[2] * scaleX;
                    double itemHeight = pos[3] * scaleY;
                    item.Left = Convert.ToInt32(pos[0] * scaleX - itemWidth / 2);
                    item.Top = Convert.ToInt32(pos[1] * scaleY - itemHeight / 2);
                    item.Width = Convert.ToInt32(itemWidth);
                    item.Height = Convert.ToInt32(itemHeight);
                    try
                    {
                        #region 最大化后的字体样式
                        string name = item.GetType().FullName;
                        if ("System.Windows.Forms.DataGridView".Equals(name))
                        {
                            item.Font = new Font(item.Font.Name, float.Parse((pos[4] * Math.Min(scaleX, scaleY)).ToString()), FontStyle.Bold);
                        }
                        else if ("System.Windows.Forms.TabControl".Equals(name))
                        {
                            item.Font = new Font("微软雅黑", float.Parse((pos[4] * Math.Min(scaleX, scaleY)).ToString()), FontStyle.Bold);
                        }
                        else
                            item.Font = new Font(item.Font.Name, float.Parse((pos[4] * Math.Min(scaleX, scaleY)).ToString())); 
                        #endregion
                    }
                    catch
                    {
                    }
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (controlInfo.Count > 0)
            {
                ControlsChangeInit(this.Controls[0]);
                ControlsChange(this.Controls[0]);
            }
        }
    }
}
