namespace HSC_SYPrintSystem
{
    partial class UpdateBatForm
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
            this.characteristicsLB = new System.Windows.Forms.Label();
            this.txt_characteristics = new System.Windows.Forms.TextBox();
            this.siloNoLB = new System.Windows.Forms.Label();
            this.txt_siloNo = new System.Windows.Forms.TextBox();
            this.processNumberLB = new System.Windows.Forms.Label();
            this.txt_processNumber = new System.Windows.Forms.TextBox();
            this.gradeLB = new System.Windows.Forms.Label();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.changeDateLB = new System.Windows.Forms.Label();
            this.dtp_changeDate = new System.Windows.Forms.DateTimePicker();
            this.matSaveBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // characteristicsLB
            // 
            this.characteristicsLB.AutoSize = true;
            this.characteristicsLB.Location = new System.Drawing.Point(61, 28);
            this.characteristicsLB.Name = "characteristicsLB";
            this.characteristicsLB.Size = new System.Drawing.Size(88, 16);
            this.characteristicsLB.TabIndex = 3;
            this.characteristicsLB.Text = "生产特性：";
            // 
            // txt_characteristics
            // 
            this.txt_characteristics.Location = new System.Drawing.Point(142, 25);
            this.txt_characteristics.Name = "txt_characteristics";
            this.txt_characteristics.Size = new System.Drawing.Size(192, 26);
            this.txt_characteristics.TabIndex = 4;
            // 
            // siloNoLB
            // 
            this.siloNoLB.AutoSize = true;
            this.siloNoLB.Location = new System.Drawing.Point(73, 78);
            this.siloNoLB.Name = "siloNoLB";
            this.siloNoLB.Size = new System.Drawing.Size(72, 16);
            this.siloNoLB.TabIndex = 5;
            this.siloNoLB.Text = "料仓号：";
            // 
            // txt_siloNo
            // 
            this.txt_siloNo.Location = new System.Drawing.Point(142, 75);
            this.txt_siloNo.Name = "txt_siloNo";
            this.txt_siloNo.Size = new System.Drawing.Size(192, 26);
            this.txt_siloNo.TabIndex = 6;
            // 
            // processNumberLB
            // 
            this.processNumberLB.AutoSize = true;
            this.processNumberLB.Location = new System.Drawing.Point(378, 28);
            this.processNumberLB.Name = "processNumberLB";
            this.processNumberLB.Size = new System.Drawing.Size(72, 16);
            this.processNumberLB.TabIndex = 7;
            this.processNumberLB.Text = "工艺号：";
            // 
            // txt_processNumber
            // 
            this.txt_processNumber.Location = new System.Drawing.Point(451, 25);
            this.txt_processNumber.Name = "txt_processNumber";
            this.txt_processNumber.Size = new System.Drawing.Size(192, 26);
            this.txt_processNumber.TabIndex = 8;
            // 
            // gradeLB
            // 
            this.gradeLB.AutoSize = true;
            this.gradeLB.Location = new System.Drawing.Point(85, 129);
            this.gradeLB.Name = "gradeLB";
            this.gradeLB.Size = new System.Drawing.Size(56, 16);
            this.gradeLB.TabIndex = 9;
            this.gradeLB.Text = "等级：";
            // 
            // txt_grade
            // 
            this.txt_grade.Location = new System.Drawing.Point(142, 126);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(192, 26);
            this.txt_grade.TabIndex = 10;
            // 
            // changeDateLB
            // 
            this.changeDateLB.AutoSize = true;
            this.changeDateLB.Location = new System.Drawing.Point(354, 78);
            this.changeDateLB.Name = "changeDateLB";
            this.changeDateLB.Size = new System.Drawing.Size(104, 16);
            this.changeDateLB.TabIndex = 11;
            this.changeDateLB.Text = "改特性日期：";
            // 
            // dtp_changeDate
            // 
            this.dtp_changeDate.Location = new System.Drawing.Point(451, 72);
            this.dtp_changeDate.Name = "dtp_changeDate";
            this.dtp_changeDate.Size = new System.Drawing.Size(192, 26);
            this.dtp_changeDate.TabIndex = 12;
            // 
            // matSaveBTN
            // 
            this.matSaveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.matSaveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matSaveBTN.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matSaveBTN.ForeColor = System.Drawing.Color.White;
            this.matSaveBTN.Location = new System.Drawing.Point(568, 323);
            this.matSaveBTN.Name = "matSaveBTN";
            this.matSaveBTN.Size = new System.Drawing.Size(75, 51);
            this.matSaveBTN.TabIndex = 25;
            this.matSaveBTN.Text = "保存";
            this.matSaveBTN.UseVisualStyleBackColor = false;
            this.matSaveBTN.Click += new System.EventHandler(this.matSaveBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.matSaveBTN);
            this.panel1.Controls.Add(this.txt_characteristics);
            this.panel1.Controls.Add(this.siloNoLB);
            this.panel1.Controls.Add(this.characteristicsLB);
            this.panel1.Controls.Add(this.txt_siloNo);
            this.panel1.Controls.Add(this.txt_processNumber);
            this.panel1.Controls.Add(this.dtp_changeDate);
            this.panel1.Controls.Add(this.processNumberLB);
            this.panel1.Controls.Add(this.txt_grade);
            this.panel1.Controls.Add(this.changeDateLB);
            this.panel1.Controls.Add(this.gradeLB);
            this.panel1.Font = new System.Drawing.Font("宋体", 12F);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 458);
            this.panel1.TabIndex = 26;
            // 
            // UpdateBatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 457);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "UpdateBatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑批次";
            this.Load += new System.EventHandler(this.UpdateBatForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label characteristicsLB;
        private System.Windows.Forms.TextBox txt_characteristics;
        private System.Windows.Forms.Label siloNoLB;
        private System.Windows.Forms.TextBox txt_siloNo;
        private System.Windows.Forms.Label processNumberLB;
        private System.Windows.Forms.TextBox txt_processNumber;
        private System.Windows.Forms.Label gradeLB;
        private System.Windows.Forms.TextBox txt_grade;
        private System.Windows.Forms.Label changeDateLB;
        private System.Windows.Forms.DateTimePicker dtp_changeDate;
        private System.Windows.Forms.Button matSaveBTN;
        private System.Windows.Forms.Panel panel1;
    }
}