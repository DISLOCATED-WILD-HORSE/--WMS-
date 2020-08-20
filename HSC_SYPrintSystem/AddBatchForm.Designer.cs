namespace HSC_SYPrintSystem
{
    partial class AddBatchForm
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
            this.batchNoLB = new System.Windows.Forms.Label();
            this.txt_batchNo = new System.Windows.Forms.TextBox();
            this.characteristicsLB = new System.Windows.Forms.Label();
            this.txt_characteristics = new System.Windows.Forms.TextBox();
            this.siloNoLB = new System.Windows.Forms.Label();
            this.gradeLB = new System.Windows.Forms.Label();
            this.productDateLB = new System.Windows.Forms.Label();
            this.dtp_productDate = new System.Windows.Forms.DateTimePicker();
            this.BatSaveBtn = new System.Windows.Forms.Button();
            this.BatResetBtn = new System.Windows.Forms.Button();
            this.batchValidateBox = new System.Windows.Forms.TextBox();
            this.productTypeLB = new System.Windows.Forms.Label();
            this.productTypeCB = new System.Windows.Forms.ComboBox();
            this.workLineLB = new System.Windows.Forms.Label();
            this.workLineCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nbtWeightCB = new System.Windows.Forms.ComboBox();
            this.gradeCB = new System.Windows.Forms.ComboBox();
            this.txt_siloNo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialValidateBox = new System.Windows.Forms.TextBox();
            this.materialTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // batchNoLB
            // 
            this.batchNoLB.AutoSize = true;
            this.batchNoLB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.batchNoLB.Location = new System.Drawing.Point(31, 25);
            this.batchNoLB.Name = "batchNoLB";
            this.batchNoLB.Size = new System.Drawing.Size(76, 16);
            this.batchNoLB.TabIndex = 0;
            this.batchNoLB.Text = "批次号：";
            // 
            // txt_batchNo
            // 
            this.txt_batchNo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_batchNo.ForeColor = System.Drawing.Color.White;
            this.txt_batchNo.Location = new System.Drawing.Point(107, 22);
            this.txt_batchNo.Name = "txt_batchNo";
            this.txt_batchNo.ReadOnly = true;
            this.txt_batchNo.Size = new System.Drawing.Size(192, 26);
            this.txt_batchNo.TabIndex = 1;
            this.txt_batchNo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_batchNo_Validating);
            // 
            // characteristicsLB
            // 
            this.characteristicsLB.AutoSize = true;
            this.characteristicsLB.Location = new System.Drawing.Point(336, 150);
            this.characteristicsLB.Name = "characteristicsLB";
            this.characteristicsLB.Size = new System.Drawing.Size(88, 16);
            this.characteristicsLB.TabIndex = 2;
            this.characteristicsLB.Text = "生产特性：";
            // 
            // txt_characteristics
            // 
            this.txt_characteristics.Location = new System.Drawing.Point(430, 147);
            this.txt_characteristics.Name = "txt_characteristics";
            this.txt_characteristics.Size = new System.Drawing.Size(192, 26);
            this.txt_characteristics.TabIndex = 3;
            // 
            // siloNoLB
            // 
            this.siloNoLB.AutoSize = true;
            this.siloNoLB.Location = new System.Drawing.Point(35, 207);
            this.siloNoLB.Name = "siloNoLB";
            this.siloNoLB.Size = new System.Drawing.Size(72, 16);
            this.siloNoLB.TabIndex = 4;
            this.siloNoLB.Text = "料仓号：";
            // 
            // gradeLB
            // 
            this.gradeLB.AutoSize = true;
            this.gradeLB.Location = new System.Drawing.Point(51, 259);
            this.gradeLB.Name = "gradeLB";
            this.gradeLB.Size = new System.Drawing.Size(56, 16);
            this.gradeLB.TabIndex = 8;
            this.gradeLB.Text = "等级：";
            // 
            // productDateLB
            // 
            this.productDateLB.AutoSize = true;
            this.productDateLB.Location = new System.Drawing.Point(19, 150);
            this.productDateLB.Name = "productDateLB";
            this.productDateLB.Size = new System.Drawing.Size(88, 16);
            this.productDateLB.TabIndex = 10;
            this.productDateLB.Text = "生产日期：";
            // 
            // dtp_productDate
            // 
            this.dtp_productDate.Location = new System.Drawing.Point(107, 143);
            this.dtp_productDate.Name = "dtp_productDate";
            this.dtp_productDate.Size = new System.Drawing.Size(192, 26);
            this.dtp_productDate.TabIndex = 11;
            // 
            // BatSaveBtn
            // 
            this.BatSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BatSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatSaveBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.BatSaveBtn.ForeColor = System.Drawing.Color.White;
            this.BatSaveBtn.Location = new System.Drawing.Point(119, 318);
            this.BatSaveBtn.Name = "BatSaveBtn";
            this.BatSaveBtn.Size = new System.Drawing.Size(75, 51);
            this.BatSaveBtn.TabIndex = 63;
            this.BatSaveBtn.Text = "保存";
            this.BatSaveBtn.UseVisualStyleBackColor = false;
            this.BatSaveBtn.Click += new System.EventHandler(this.BatSaveBtn_Click);
            // 
            // BatResetBtn
            // 
            this.BatResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BatResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatResetBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.BatResetBtn.ForeColor = System.Drawing.Color.White;
            this.BatResetBtn.Location = new System.Drawing.Point(224, 318);
            this.BatResetBtn.Name = "BatResetBtn";
            this.BatResetBtn.Size = new System.Drawing.Size(75, 51);
            this.BatResetBtn.TabIndex = 64;
            this.BatResetBtn.Text = "重置";
            this.BatResetBtn.UseVisualStyleBackColor = false;
            this.BatResetBtn.Click += new System.EventHandler(this.BatResetBtn_Click);
            // 
            // batchValidateBox
            // 
            this.batchValidateBox.BackColor = System.Drawing.Color.White;
            this.batchValidateBox.ForeColor = System.Drawing.Color.Red;
            this.batchValidateBox.Location = new System.Drawing.Point(107, 48);
            this.batchValidateBox.Name = "batchValidateBox";
            this.batchValidateBox.ReadOnly = true;
            this.batchValidateBox.Size = new System.Drawing.Size(192, 26);
            this.batchValidateBox.TabIndex = 65;
            this.batchValidateBox.Visible = false;
            // 
            // productTypeLB
            // 
            this.productTypeLB.AutoSize = true;
            this.productTypeLB.Location = new System.Drawing.Point(19, 93);
            this.productTypeLB.Name = "productTypeLB";
            this.productTypeLB.Size = new System.Drawing.Size(88, 16);
            this.productTypeLB.TabIndex = 66;
            this.productTypeLB.Text = "产品类别：";
            // 
            // productTypeCB
            // 
            this.productTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productTypeCB.FormattingEnabled = true;
            this.productTypeCB.Items.AddRange(new object[] {
            "纺丝级  H",
            "工程塑料级  P",
            "薄膜级  F"});
            this.productTypeCB.Location = new System.Drawing.Point(107, 90);
            this.productTypeCB.Name = "productTypeCB";
            this.productTypeCB.Size = new System.Drawing.Size(192, 24);
            this.productTypeCB.TabIndex = 67;
            this.productTypeCB.SelectedValueChanged += new System.EventHandler(this.productTypeCB_SelectedValueChanged);
            // 
            // workLineLB
            // 
            this.workLineLB.AutoSize = true;
            this.workLineLB.Location = new System.Drawing.Point(368, 93);
            this.workLineLB.Name = "workLineLB";
            this.workLineLB.Size = new System.Drawing.Size(56, 16);
            this.workLineLB.TabIndex = 68;
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
            this.workLineCB.Location = new System.Drawing.Point(430, 90);
            this.workLineCB.Name = "workLineCB";
            this.workLineCB.Size = new System.Drawing.Size(192, 24);
            this.workLineCB.TabIndex = 69;
            this.workLineCB.SelectedValueChanged += new System.EventHandler(this.workLineCB_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "净重：";
            // 
            // nbtWeightCB
            // 
            this.nbtWeightCB.FormattingEnabled = true;
            this.nbtWeightCB.Items.AddRange(new object[] {
            "纺丝级  H",
            "工程塑料级  P",
            "薄膜级  F"});
            this.nbtWeightCB.Location = new System.Drawing.Point(430, 204);
            this.nbtWeightCB.Name = "nbtWeightCB";
            this.nbtWeightCB.Size = new System.Drawing.Size(192, 24);
            this.nbtWeightCB.TabIndex = 71;
            // 
            // gradeCB
            // 
            this.gradeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeCB.FormattingEnabled = true;
            this.gradeCB.Location = new System.Drawing.Point(107, 256);
            this.gradeCB.Name = "gradeCB";
            this.gradeCB.Size = new System.Drawing.Size(192, 24);
            this.gradeCB.TabIndex = 72;
            // 
            // txt_siloNo
            // 
            this.txt_siloNo.FormattingEnabled = true;
            this.txt_siloNo.Items.AddRange(new object[] {
            "纺丝级  H",
            "工程塑料级  P",
            "薄膜级  F"});
            this.txt_siloNo.Location = new System.Drawing.Point(107, 204);
            this.txt_siloNo.Name = "txt_siloNo";
            this.txt_siloNo.Size = new System.Drawing.Size(192, 24);
            this.txt_siloNo.TabIndex = 73;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialValidateBox);
            this.panel1.Controls.Add(this.materialTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.productTypeCB);
            this.panel1.Controls.Add(this.BatResetBtn);
            this.panel1.Controls.Add(this.txt_batchNo);
            this.panel1.Controls.Add(this.batchValidateBox);
            this.panel1.Controls.Add(this.batchNoLB);
            this.panel1.Controls.Add(this.workLineCB);
            this.panel1.Controls.Add(this.nbtWeightCB);
            this.panel1.Controls.Add(this.workLineLB);
            this.panel1.Controls.Add(this.txt_characteristics);
            this.panel1.Controls.Add(this.txt_siloNo);
            this.panel1.Controls.Add(this.characteristicsLB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BatSaveBtn);
            this.panel1.Controls.Add(this.gradeCB);
            this.panel1.Controls.Add(this.dtp_productDate);
            this.panel1.Controls.Add(this.gradeLB);
            this.panel1.Controls.Add(this.productDateLB);
            this.panel1.Controls.Add(this.siloNoLB);
            this.panel1.Controls.Add(this.productTypeLB);
            this.panel1.Font = new System.Drawing.Font("宋体", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 457);
            this.panel1.TabIndex = 74;
            // 
            // materialValidateBox
            // 
            this.materialValidateBox.BackColor = System.Drawing.Color.White;
            this.materialValidateBox.ForeColor = System.Drawing.Color.Red;
            this.materialValidateBox.Location = new System.Drawing.Point(430, 49);
            this.materialValidateBox.Name = "materialValidateBox";
            this.materialValidateBox.ReadOnly = true;
            this.materialValidateBox.Size = new System.Drawing.Size(192, 26);
            this.materialValidateBox.TabIndex = 76;
            this.materialValidateBox.Visible = false;
            // 
            // materialTB
            // 
            this.materialTB.Location = new System.Drawing.Point(430, 22);
            this.materialTB.Name = "materialTB";
            this.materialTB.Size = new System.Drawing.Size(192, 26);
            this.materialTB.TabIndex = 75;
            this.materialTB.Validating += new System.ComponentModel.CancelEventHandler(this.materialTB_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(348, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "物料号：";
            // 
            // AddBatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 457);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddBatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增批次";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddBatchForm_FormClosed);
            this.Load += new System.EventHandler(this.AddBatchForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label batchNoLB;
        private System.Windows.Forms.TextBox txt_batchNo;
        private System.Windows.Forms.Label characteristicsLB;
        private System.Windows.Forms.TextBox txt_characteristics;
        private System.Windows.Forms.Label siloNoLB;
        private System.Windows.Forms.Label gradeLB;
        private System.Windows.Forms.Label productDateLB;
        private System.Windows.Forms.DateTimePicker dtp_productDate;
        private System.Windows.Forms.Button BatSaveBtn;
        private System.Windows.Forms.Button BatResetBtn;
        private System.Windows.Forms.TextBox batchValidateBox;
        private System.Windows.Forms.Label productTypeLB;
        private System.Windows.Forms.ComboBox productTypeCB;
        private System.Windows.Forms.Label workLineLB;
        private System.Windows.Forms.ComboBox workLineCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nbtWeightCB;
        private System.Windows.Forms.ComboBox gradeCB;
        private System.Windows.Forms.ComboBox txt_siloNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox materialTB;
        private System.Windows.Forms.TextBox materialValidateBox;
    }
}