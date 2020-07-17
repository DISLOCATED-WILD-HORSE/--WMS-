namespace HSC_SYPrintSystem
{
    partial class UpdateMatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.matdesc = new System.Windows.Forms.Label();
            this.matdescTB = new System.Windows.Forms.TextBox();
            this.matold = new System.Windows.Forms.Label();
            this.matoldTB = new System.Windows.Forms.TextBox();
            this.matolddesc = new System.Windows.Forms.Label();
            this.matolddescTB = new System.Windows.Forms.TextBox();
            this.spec = new System.Windows.Forms.Label();
            this.specTB = new System.Windows.Forms.TextBox();
            this.matSaveBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_JHSPEC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matdesc
            // 
            this.matdesc.AutoSize = true;
            this.matdesc.Location = new System.Drawing.Point(35, 28);
            this.matdesc.Name = "matdesc";
            this.matdesc.Size = new System.Drawing.Size(88, 16);
            this.matdesc.TabIndex = 0;
            this.matdesc.Text = "物料描述：";
            // 
            // matdescTB
            // 
            this.matdescTB.Location = new System.Drawing.Point(129, 25);
            this.matdescTB.Name = "matdescTB";
            this.matdescTB.Size = new System.Drawing.Size(203, 26);
            this.matdescTB.TabIndex = 1;
            // 
            // matold
            // 
            this.matold.AutoSize = true;
            this.matold.Location = new System.Drawing.Point(375, 28);
            this.matold.Name = "matold";
            this.matold.Size = new System.Drawing.Size(88, 16);
            this.matold.TabIndex = 2;
            this.matold.Text = "旧物料号：";
            // 
            // matoldTB
            // 
            this.matoldTB.Location = new System.Drawing.Point(469, 25);
            this.matoldTB.Name = "matoldTB";
            this.matoldTB.Size = new System.Drawing.Size(203, 26);
            this.matoldTB.TabIndex = 3;
            // 
            // matolddesc
            // 
            this.matolddesc.AutoSize = true;
            this.matolddesc.Location = new System.Drawing.Point(19, 85);
            this.matolddesc.Name = "matolddesc";
            this.matolddesc.Size = new System.Drawing.Size(104, 16);
            this.matolddesc.TabIndex = 4;
            this.matolddesc.Text = "旧物料描述：";
            // 
            // matolddescTB
            // 
            this.matolddescTB.Location = new System.Drawing.Point(129, 82);
            this.matolddescTB.Name = "matolddescTB";
            this.matolddescTB.Size = new System.Drawing.Size(203, 26);
            this.matolddescTB.TabIndex = 5;
            // 
            // spec
            // 
            this.spec.AutoSize = true;
            this.spec.Location = new System.Drawing.Point(343, 85);
            this.spec.Name = "spec";
            this.spec.Size = new System.Drawing.Size(120, 16);
            this.spec.TabIndex = 6;
            this.spec.Text = "标签品种规格：";
            // 
            // specTB
            // 
            this.specTB.Location = new System.Drawing.Point(469, 82);
            this.specTB.Name = "specTB";
            this.specTB.Size = new System.Drawing.Size(203, 26);
            this.specTB.TabIndex = 7;
            // 
            // matSaveBTN
            // 
            this.matSaveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.matSaveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matSaveBTN.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matSaveBTN.ForeColor = System.Drawing.Color.White;
            this.matSaveBTN.Location = new System.Drawing.Point(579, 348);
            this.matSaveBTN.Name = "matSaveBTN";
            this.matSaveBTN.Size = new System.Drawing.Size(75, 51);
            this.matSaveBTN.TabIndex = 24;
            this.matSaveBTN.Text = "保存";
            this.matSaveBTN.UseVisualStyleBackColor = false;
            this.matSaveBTN.Click += new System.EventHandler(this.matSaveBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "聚合产品规格：";
            // 
            // txt_JHSPEC
            // 
            this.txt_JHSPEC.Location = new System.Drawing.Point(129, 149);
            this.txt_JHSPEC.Name = "txt_JHSPEC";
            this.txt_JHSPEC.Size = new System.Drawing.Size(203, 26);
            this.txt_JHSPEC.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.matSaveBTN);
            this.panel1.Controls.Add(this.matdesc);
            this.panel1.Controls.Add(this.matdescTB);
            this.panel1.Controls.Add(this.matold);
            this.panel1.Controls.Add(this.matoldTB);
            this.panel1.Controls.Add(this.specTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.spec);
            this.panel1.Controls.Add(this.txt_JHSPEC);
            this.panel1.Controls.Add(this.matolddescTB);
            this.panel1.Controls.Add(this.matolddesc);
            this.panel1.Font = new System.Drawing.Font("宋体", 12F);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 453);
            this.panel1.TabIndex = 27;
            // 
            // UpdateMatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 457);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "UpdateMatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑物料数据";
            this.Load += new System.EventHandler(this.UpdateMatForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label matdesc;
        private System.Windows.Forms.TextBox matdescTB;
        private System.Windows.Forms.Label matold;
        private System.Windows.Forms.TextBox matoldTB;
        private System.Windows.Forms.Label matolddesc;
        private System.Windows.Forms.TextBox matolddescTB;
        private System.Windows.Forms.Label spec;
        private System.Windows.Forms.TextBox specTB;
        private System.Windows.Forms.Button matSaveBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_JHSPEC;
        private System.Windows.Forms.Panel panel1;
    }
}