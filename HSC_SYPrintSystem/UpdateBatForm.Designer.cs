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
            this.gradeLB = new System.Windows.Forms.Label();
            this.productDateLB = new System.Windows.Forms.Label();
            this.dtp_productDate = new System.Windows.Forms.DateTimePicker();
            this.matSaveBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.workLineLB = new System.Windows.Forms.Label();
            this.workLineCB = new System.Windows.Forms.ComboBox();
            this.siloNoCB = new System.Windows.Forms.ComboBox();
            this.gradeCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // characteristicsLB
            // 
            this.characteristicsLB.AutoSize = true;
            this.characteristicsLB.Location = new System.Drawing.Point(378, 29);
            this.characteristicsLB.Name = "characteristicsLB";
            this.characteristicsLB.Size = new System.Drawing.Size(88, 16);
            this.characteristicsLB.TabIndex = 3;
            this.characteristicsLB.Text = "生产特性：";
            // 
            // txt_characteristics
            // 
            this.txt_characteristics.Location = new System.Drawing.Point(472, 26);
            this.txt_characteristics.Name = "txt_characteristics";
            this.txt_characteristics.Size = new System.Drawing.Size(192, 26);
            this.txt_characteristics.TabIndex = 4;
            // 
            // siloNoLB
            // 
            this.siloNoLB.AutoSize = true;
            this.siloNoLB.Location = new System.Drawing.Point(57, 97);
            this.siloNoLB.Name = "siloNoLB";
            this.siloNoLB.Size = new System.Drawing.Size(72, 16);
            this.siloNoLB.TabIndex = 5;
            this.siloNoLB.Text = "料仓号：";
            // 
            // gradeLB
            // 
            this.gradeLB.AutoSize = true;
            this.gradeLB.Location = new System.Drawing.Point(410, 97);
            this.gradeLB.Name = "gradeLB";
            this.gradeLB.Size = new System.Drawing.Size(56, 16);
            this.gradeLB.TabIndex = 9;
            this.gradeLB.Text = "等级：";
            // 
            // productDateLB
            // 
            this.productDateLB.AutoSize = true;
            this.productDateLB.Location = new System.Drawing.Point(41, 176);
            this.productDateLB.Name = "productDateLB";
            this.productDateLB.Size = new System.Drawing.Size(88, 16);
            this.productDateLB.TabIndex = 11;
            this.productDateLB.Text = "生产日期：";
            // 
            // dtp_productDate
            // 
            this.dtp_productDate.Location = new System.Drawing.Point(142, 169);
            this.dtp_productDate.Name = "dtp_productDate";
            this.dtp_productDate.Size = new System.Drawing.Size(192, 26);
            this.dtp_productDate.TabIndex = 12;
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
            this.panel1.Controls.Add(this.gradeCB);
            this.panel1.Controls.Add(this.siloNoCB);
            this.panel1.Controls.Add(this.workLineCB);
            this.panel1.Controls.Add(this.workLineLB);
            this.panel1.Controls.Add(this.matSaveBTN);
            this.panel1.Controls.Add(this.txt_characteristics);
            this.panel1.Controls.Add(this.siloNoLB);
            this.panel1.Controls.Add(this.characteristicsLB);
            this.panel1.Controls.Add(this.dtp_productDate);
            this.panel1.Controls.Add(this.productDateLB);
            this.panel1.Controls.Add(this.gradeLB);
            this.panel1.Font = new System.Drawing.Font("宋体", 12F);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 458);
            this.panel1.TabIndex = 26;
            // 
            // workLineLB
            // 
            this.workLineLB.AutoSize = true;
            this.workLineLB.Location = new System.Drawing.Point(73, 32);
            this.workLineLB.Name = "workLineLB";
            this.workLineLB.Size = new System.Drawing.Size(56, 16);
            this.workLineLB.TabIndex = 69;
            this.workLineLB.Text = "线别：";
            // 
            // workLineCB
            // 
            this.workLineCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workLineCB.FormattingEnabled = true;
            this.workLineCB.Items.AddRange(new object[] {
            "140-U010A",
            "140-U010B",
            "240-U010A",
            "240-U010B",
            "340-U010A",
            "340-U010B"});
            this.workLineCB.Location = new System.Drawing.Point(142, 29);
            this.workLineCB.Name = "workLineCB";
            this.workLineCB.Size = new System.Drawing.Size(192, 24);
            this.workLineCB.TabIndex = 70;
            // 
            // siloNoCB
            // 
            this.siloNoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siloNoCB.FormattingEnabled = true;
            this.siloNoCB.Location = new System.Drawing.Point(142, 91);
            this.siloNoCB.Name = "siloNoCB";
            this.siloNoCB.Size = new System.Drawing.Size(192, 24);
            this.siloNoCB.TabIndex = 71;
            // 
            // gradeCB
            // 
            this.gradeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeCB.FormattingEnabled = true;
            this.gradeCB.Location = new System.Drawing.Point(472, 91);
            this.gradeCB.Name = "gradeCB";
            this.gradeCB.Size = new System.Drawing.Size(192, 24);
            this.gradeCB.TabIndex = 72;
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
        private System.Windows.Forms.Label gradeLB;
        private System.Windows.Forms.Label productDateLB;
        private System.Windows.Forms.DateTimePicker dtp_productDate;
        private System.Windows.Forms.Button matSaveBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label workLineLB;
        private System.Windows.Forms.ComboBox workLineCB;
        private System.Windows.Forms.ComboBox siloNoCB;
        private System.Windows.Forms.ComboBox gradeCB;
    }
}