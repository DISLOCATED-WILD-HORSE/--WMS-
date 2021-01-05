using HSC_Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtWorks.QRCode.Codec;

namespace HSC_Util
{
    public static class PrintHelper
    {
        public static void PrintImplementation(packageInfo printModel, string customMat, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p4 = new Pen(Color.Black, 4);//定义了一个蓝色,宽度为的画笔
            Pen p2 = new Pen(Color.Black, 2);//定义了一个蓝色,宽度为的画笔
            //g.DrawLine(p, 10, 10, 300, 10);//在画板上画直线,起始坐标为(10,10),终点坐标为(100,100)
            g.DrawRectangle(p4, 15, 20, 360, 438);//在画板上画矩形,起始坐标为(10,10),宽为,高为
            g.DrawLine(p2, 15, 113, 376, 113);//横线
            g.DrawLine(p2, 15, 168, 376, 168);//横线
            g.DrawLine(p2, 15, 226, 376, 226);//横线
            g.DrawLine(p2, 15, 284, 376, 284);//横线
            g.DrawLine(p2, 15, 334, 224, 334);//横线
            g.DrawLine(p2, 15, 390, 224, 390);//横线
            //g.DrawLine(p2, 218, 108, 218, 284);//竖线
            //g.DrawLine(p2, 126, 285, 126, 390);//竖线
            g.DrawLine(p2, 225, 285, 225, 458);//竖线

            Font Font9 = new Font("微软雅黑", 9, FontStyle.Regular);
            Font Font13 = new Font("微软雅黑", 13, FontStyle.Bold);
            Font Font15 = new Font("微软雅黑", 15, FontStyle.Bold);
            Font Font16 = new Font("微软雅黑", 16, FontStyle.Bold);
            Font Font11 = new Font("微软雅黑", 11, FontStyle.Bold);
            System.Drawing.Brush bush = new SolidBrush(Color.Black);//填充的颜色

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            Font Font19 = new Font("微软雅黑", 19, FontStyle.Bold);
            g.DrawString(string.Format("{0}", string.IsNullOrEmpty(printModel.spec) ? "尼龙粒-全消光" : printModel.spec), Font19, bush, new Rectangle(15, 20, 360, 40), sf);
            g.DrawString(string.Format("{0}", string.IsNullOrEmpty(printModel.productDesc) ? "POLYAMIDE 6 FD CHIP" : printModel.productDesc), Font19, bush, new Rectangle(15, 53, 360, 40), sf);
            g.DrawString(string.Format("执行标准 EXECUTIVE STANDARD {0}", string.IsNullOrEmpty(printModel.standard) ? "DTY FZ/T54007-2009" : printModel.standard), Font9, bush, new Rectangle(10, 81, 360, 40), sf);
            g.DrawString("批号", Font9, bush, 21, 125);
            g.DrawString("LOT.NO", Font9, bush, 19, 146);
            g.DrawString(string.Format("{0}", string.IsNullOrEmpty(printModel.newNo) ? "FNC103" : printModel.newNo), Font16, bush, 100, 126);

            g.DrawString("物料号", Font9, bush, 19, 179);
            g.DrawString("M.NO", Font9, bush, 19, 198);
            g.DrawString(string.Format("{0}", customMat ?? ""), Font16, bush, 100, 185);

            g.DrawString("批次", Font9, bush, 19, 234);
            g.DrawString("B.NO", Font9, bush, 19, 254);
            g.DrawString(string.Format("{0}", string.IsNullOrEmpty(printModel.bNo) ? "LHC1708071" : printModel.bNo), Font16, bush, 100, 238);

            g.DrawString("等级", Font9, bush, 19, 289);
            g.DrawString("GRADE", Font9, bush, 19, 309);
            g.DrawString(string.Format("{0}", string.IsNullOrEmpty(printModel.grade) ? "AA" : printModel.grade), Font16, bush, 100, 292);

            g.DrawString("净重", Font9, bush, 19, 341);
            g.DrawString("N.W", Font9, bush, 19, 361);
            g.DrawString(string.Format("{0}", string.IsNullOrEmpty(printModel.nbtWeight.ToString()) ? "820 KG" : printModel?.nbtWeight + " KG"), Font16, bush, new Rectangle(80, 345, 130, 31), sf);
            g.DrawImage(Create_ImgCode2(@"" + 1 + ";;" + printModel.mNo + ";" + printModel.bNo + ";" + printModel.grade + ";" + printModel.nbtWeight + ";" + printModel.seriesNo + ";" + printModel?.packageDate + ";" + printModel.SILONUM + ";" + printModel.PROCESSNUM + ";;", 6), new Rectangle(232, 292, 134, 130));
            g.DrawString("Made In China", Font9, bush, new Rectangle(230, 425, 130, 24), sf);

            g.DrawString("袋号", Font9, bush, 22, 396);
            g.DrawString("C.NO", Font9, bush, 55, 396);
            g.DrawString(string.Format("{0}", string.IsNullOrEmpty(printModel.pack_Ex1) ? printModel.seriesNo : printModel.pack_Ex1), Font15, bush, new Rectangle(15, 408, 210, 46), sf);
        }

        public static Bitmap Create_ImgCode2(string CodeNumber, int size)
        {
            QRCodeEncoder qrCode = new QRCodeEncoder();
            qrCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCode.QRCodeScale = size;
            qrCode.QRCodeVersion = 0;
            qrCode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            System.Drawing.Bitmap image = qrCode.Encode(CodeNumber);
            return image;
            // return Img_Conv.BitmapToBitmapImage(image);
        }
    }
}
