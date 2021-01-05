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
            this.BatSaveBtn = new System.Windows.Forms.Button();
            this.BatResetBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddBatNoTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gradeCB = new System.Windows.Forms.ComboBox();
            this.gradeLB = new System.Windows.Forms.Label();
            this.materialValidateBox = new System.Windows.Forms.TextBox();
            this.materialTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productTypeCB = new System.Windows.Forms.ComboBox();
            this.txt_batchNo = new System.Windows.Forms.TextBox();
            this.batchValidateBox = new System.Windows.Forms.TextBox();
            this.batchNoLB = new System.Windows.Forms.Label();
            this.workLineCB = new System.Windows.Forms.ComboBox();
            this.nbtWeightCB = new System.Windows.Forms.ComboBox();
            this.workLineLB = new System.Windows.Forms.Label();
            this.txt_characteristics = new System.Windows.Forms.TextBox();
            this.txt_siloNo = new System.Windows.Forms.ComboBox();
            this.characteristicsLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_productDate = new System.Windows.Forms.DateTimePicker();
            this.productDateLB = new System.Windows.Forms.Label();
            this.siloNoLB = new System.Windows.Forms.Label();
            this.productTypeLB = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtp_bNoCrDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_grade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.matTbValidate = new System.Windows.Forms.TextBox();
            this.matTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pdTypeCB = new System.Windows.Forms.ComboBox();
            this.txt_bNo = new System.Windows.Forms.TextBox();
            this.txt_bNoValidate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wkLineCB = new System.Windows.Forms.ComboBox();
            this.txt_nbt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_characteristicsByChange = new System.Windows.Forms.TextBox();
            this.txt_siloNum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_pdDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.AddBatNoTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BatSaveBtn
            // 
            this.BatSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BatSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatSaveBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.BatSaveBtn.ForeColor = System.Drawing.Color.White;
            this.BatSaveBtn.Location = new System.Drawing.Point(462, 360);
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
            this.BatResetBtn.Location = new System.Drawing.Point(579, 360);
            this.BatResetBtn.Name = "BatResetBtn";
            this.BatResetBtn.Size = new System.Drawing.Size(75, 51);
            this.BatResetBtn.TabIndex = 64;
            this.BatResetBtn.Text = "重置";
            this.BatResetBtn.UseVisualStyleBackColor = false;
            this.BatResetBtn.Click += new System.EventHandler(this.BatResetBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.AddBatNoTabControl);
            this.panel1.Controls.Add(this.BatResetBtn);
            this.panel1.Controls.Add(this.BatSaveBtn);
            this.panel1.Font = new System.Drawing.Font("宋体", 12F);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 457);
            this.panel1.TabIndex = 74;
            // 
            // AddBatNoTabControl
            // 
            this.AddBatNoTabControl.Controls.Add(this.tabPage1);
            this.AddBatNoTabControl.Controls.Add(this.tabPage2);
            this.AddBatNoTabControl.Location = new System.Drawing.Point(3, 3);
            this.AddBatNoTabControl.Name = "AddBatNoTabControl";
            this.AddBatNoTabControl.SelectedIndex = 0;
            this.AddBatNoTabControl.Size = new System.Drawing.Size(698, 309);
            this.AddBatNoTabControl.TabIndex = 77;
            this.AddBatNoTabControl.Tag = "";
            this.AddBatNoTabControl.SelectedIndexChanged += new System.EventHandler(this.AddBatNoTabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gradeCB);
            this.tabPage1.Controls.Add(this.gradeLB);
            this.tabPage1.Controls.Add(this.materialValidateBox);
            this.tabPage1.Controls.Add(this.materialTB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.productTypeCB);
            this.tabPage1.Controls.Add(this.txt_batchNo);
            this.tabPage1.Controls.Add(this.batchValidateBox);
            this.tabPage1.Controls.Add(this.batchNoLB);
            this.tabPage1.Controls.Add(this.workLineCB);
            this.tabPage1.Controls.Add(this.nbtWeightCB);
            this.tabPage1.Controls.Add(this.workLineLB);
            this.tabPage1.Controls.Add(this.txt_characteristics);
            this.tabPage1.Controls.Add(this.txt_siloNo);
            this.tabPage1.Controls.Add(this.characteristicsLB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtp_productDate);
            this.tabPage1.Controls.Add(this.productDateLB);
            this.tabPage1.Controls.Add(this.siloNoLB);
            this.tabPage1.Controls.Add(this.productTypeLB);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "新建批次";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gradeCB
            // 
            this.gradeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradeCB.FormattingEnabled = true;
            this.gradeCB.Location = new System.Drawing.Point(125, 233);
            this.gradeCB.Name = "gradeCB";
            this.gradeCB.Size = new System.Drawing.Size(192, 24);
            this.gradeCB.TabIndex = 96;
            // 
            // gradeLB
            // 
            this.gradeLB.AutoSize = true;
            this.gradeLB.Location = new System.Drawing.Point(69, 236);
            this.gradeLB.Name = "gradeLB";
            this.gradeLB.Size = new System.Drawing.Size(56, 16);
            this.gradeLB.TabIndex = 95;
            this.gradeLB.Text = "等级：";
            // 
            // materialValidateBox
            // 
            this.materialValidateBox.BackColor = System.Drawing.Color.White;
            this.materialValidateBox.ForeColor = System.Drawing.Color.Red;
            this.materialValidateBox.Location = new System.Drawing.Point(449, 35);
            this.materialValidateBox.Name = "materialValidateBox";
            this.materialValidateBox.ReadOnly = true;
            this.materialValidateBox.Size = new System.Drawing.Size(192, 26);
            this.materialValidateBox.TabIndex = 94;
            this.materialValidateBox.Visible = false;
            // 
            // materialTB
            // 
            this.materialTB.Location = new System.Drawing.Point(449, 8);
            this.materialTB.Name = "materialTB";
            this.materialTB.Size = new System.Drawing.Size(192, 26);
            this.materialTB.TabIndex = 93;
            this.materialTB.Validating += new System.ComponentModel.CancelEventHandler(this.materialTB_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(367, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 92;
            this.label1.Text = "物料号：";
            // 
            // productTypeCB
            // 
            this.productTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productTypeCB.FormattingEnabled = true;
            this.productTypeCB.Items.AddRange(new object[] {
            "纺丝级  H",
            "工程塑料级  P",
            "薄膜级  F"});
            this.productTypeCB.Location = new System.Drawing.Point(126, 76);
            this.productTypeCB.Name = "productTypeCB";
            this.productTypeCB.Size = new System.Drawing.Size(192, 24);
            this.productTypeCB.TabIndex = 86;
            this.productTypeCB.SelectedValueChanged += new System.EventHandler(this.productTypeCB_SelectedValueChanged);
            // 
            // txt_batchNo
            // 
            this.txt_batchNo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_batchNo.ForeColor = System.Drawing.Color.White;
            this.txt_batchNo.Location = new System.Drawing.Point(126, 8);
            this.txt_batchNo.Name = "txt_batchNo";
            this.txt_batchNo.ReadOnly = true;
            this.txt_batchNo.Size = new System.Drawing.Size(192, 26);
            this.txt_batchNo.TabIndex = 78;
            this.txt_batchNo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_batchNo_Validating);
            // 
            // batchValidateBox
            // 
            this.batchValidateBox.BackColor = System.Drawing.Color.White;
            this.batchValidateBox.ForeColor = System.Drawing.Color.Red;
            this.batchValidateBox.Location = new System.Drawing.Point(126, 34);
            this.batchValidateBox.Name = "batchValidateBox";
            this.batchValidateBox.ReadOnly = true;
            this.batchValidateBox.Size = new System.Drawing.Size(192, 26);
            this.batchValidateBox.TabIndex = 84;
            this.batchValidateBox.Visible = false;
            // 
            // batchNoLB
            // 
            this.batchNoLB.AutoSize = true;
            this.batchNoLB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.batchNoLB.Location = new System.Drawing.Point(50, 11);
            this.batchNoLB.Name = "batchNoLB";
            this.batchNoLB.Size = new System.Drawing.Size(76, 16);
            this.batchNoLB.TabIndex = 77;
            this.batchNoLB.Text = "批次号：";
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
            this.workLineCB.Location = new System.Drawing.Point(449, 76);
            this.workLineCB.Name = "workLineCB";
            this.workLineCB.Size = new System.Drawing.Size(192, 24);
            this.workLineCB.TabIndex = 88;
            this.workLineCB.SelectedValueChanged += new System.EventHandler(this.workLineCB_SelectedValueChanged);
            // 
            // nbtWeightCB
            // 
            this.nbtWeightCB.FormattingEnabled = true;
            this.nbtWeightCB.Items.AddRange(new object[] {
            "纺丝级  H",
            "工程塑料级  P",
            "薄膜级  F"});
            this.nbtWeightCB.Location = new System.Drawing.Point(449, 190);
            this.nbtWeightCB.Name = "nbtWeightCB";
            this.nbtWeightCB.Size = new System.Drawing.Size(192, 24);
            this.nbtWeightCB.TabIndex = 90;
            // 
            // workLineLB
            // 
            this.workLineLB.AutoSize = true;
            this.workLineLB.Location = new System.Drawing.Point(387, 79);
            this.workLineLB.Name = "workLineLB";
            this.workLineLB.Size = new System.Drawing.Size(56, 16);
            this.workLineLB.TabIndex = 87;
            this.workLineLB.Text = "线别：";
            // 
            // txt_characteristics
            // 
            this.txt_characteristics.Location = new System.Drawing.Point(449, 133);
            this.txt_characteristics.Name = "txt_characteristics";
            this.txt_characteristics.Size = new System.Drawing.Size(192, 26);
            this.txt_characteristics.TabIndex = 80;
            // 
            // txt_siloNo
            // 
            this.txt_siloNo.FormattingEnabled = true;
            this.txt_siloNo.Items.AddRange(new object[] {
            "纺丝级  H",
            "工程塑料级  P",
            "薄膜级  F"});
            this.txt_siloNo.Location = new System.Drawing.Point(126, 190);
            this.txt_siloNo.Name = "txt_siloNo";
            this.txt_siloNo.Size = new System.Drawing.Size(192, 24);
            this.txt_siloNo.TabIndex = 91;
            // 
            // characteristicsLB
            // 
            this.characteristicsLB.AutoSize = true;
            this.characteristicsLB.Location = new System.Drawing.Point(355, 136);
            this.characteristicsLB.Name = "characteristicsLB";
            this.characteristicsLB.Size = new System.Drawing.Size(88, 16);
            this.characteristicsLB.TabIndex = 79;
            this.characteristicsLB.Text = "生产特性：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "净重：";
            // 
            // dtp_productDate
            // 
            this.dtp_productDate.Location = new System.Drawing.Point(126, 129);
            this.dtp_productDate.Name = "dtp_productDate";
            this.dtp_productDate.Size = new System.Drawing.Size(192, 26);
            this.dtp_productDate.TabIndex = 83;
            // 
            // productDateLB
            // 
            this.productDateLB.AutoSize = true;
            this.productDateLB.Location = new System.Drawing.Point(38, 136);
            this.productDateLB.Name = "productDateLB";
            this.productDateLB.Size = new System.Drawing.Size(88, 16);
            this.productDateLB.TabIndex = 82;
            this.productDateLB.Text = "生产日期：";
            // 
            // siloNoLB
            // 
            this.siloNoLB.AutoSize = true;
            this.siloNoLB.Location = new System.Drawing.Point(54, 193);
            this.siloNoLB.Name = "siloNoLB";
            this.siloNoLB.Size = new System.Drawing.Size(72, 16);
            this.siloNoLB.TabIndex = 81;
            this.siloNoLB.Text = "料仓号：";
            // 
            // productTypeLB
            // 
            this.productTypeLB.AutoSize = true;
            this.productTypeLB.Location = new System.Drawing.Point(38, 79);
            this.productTypeLB.Name = "productTypeLB";
            this.productTypeLB.Size = new System.Drawing.Size(88, 16);
            this.productTypeLB.TabIndex = 85;
            this.productTypeLB.Text = "产品类别：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtp_bNoCrDate);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txt_grade);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.matTbValidate);
            this.tabPage2.Controls.Add(this.matTb);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.pdTypeCB);
            this.tabPage2.Controls.Add(this.txt_bNo);
            this.tabPage2.Controls.Add(this.txt_bNoValidate);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.wkLineCB);
            this.tabPage2.Controls.Add(this.txt_nbt);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_characteristicsByChange);
            this.tabPage2.Controls.Add(this.txt_siloNum);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dtp_pdDate);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(690, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "改包装批次";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtp_bNoCrDate
            // 
            this.dtp_bNoCrDate.Location = new System.Drawing.Point(455, 233);
            this.dtp_bNoCrDate.Name = "dtp_bNoCrDate";
            this.dtp_bNoCrDate.Size = new System.Drawing.Size(192, 26);
            this.dtp_bNoCrDate.TabIndex = 118;
            this.dtp_bNoCrDate.ValueChanged += new System.EventHandler(this.dtp_bNoCrDate_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 16);
            this.label12.TabIndex = 117;
            this.label12.Text = "批次创建日期：";
            // 
            // txt_grade
            // 
            this.txt_grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_grade.FormattingEnabled = true;
            this.txt_grade.Location = new System.Drawing.Point(131, 236);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.Size = new System.Drawing.Size(192, 24);
            this.txt_grade.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 115;
            this.label3.Text = "等级：";
            // 
            // matTbValidate
            // 
            this.matTbValidate.BackColor = System.Drawing.Color.White;
            this.matTbValidate.ForeColor = System.Drawing.Color.Red;
            this.matTbValidate.Location = new System.Drawing.Point(455, 38);
            this.matTbValidate.Name = "matTbValidate";
            this.matTbValidate.ReadOnly = true;
            this.matTbValidate.Size = new System.Drawing.Size(192, 26);
            this.matTbValidate.TabIndex = 114;
            this.matTbValidate.Visible = false;
            // 
            // matTb
            // 
            this.matTb.Location = new System.Drawing.Point(455, 11);
            this.matTb.Name = "matTb";
            this.matTb.Size = new System.Drawing.Size(192, 26);
            this.matTb.TabIndex = 113;
            this.matTb.Validating += new System.ComponentModel.CancelEventHandler(this.matTb_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(373, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 112;
            this.label4.Text = "物料号：";
            // 
            // pdTypeCB
            // 
            this.pdTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pdTypeCB.FormattingEnabled = true;
            this.pdTypeCB.Items.AddRange(new object[] {
            "纺丝级  H",
            "工程塑料级  P",
            "薄膜级  F"});
            this.pdTypeCB.Location = new System.Drawing.Point(132, 79);
            this.pdTypeCB.Name = "pdTypeCB";
            this.pdTypeCB.Size = new System.Drawing.Size(192, 24);
            this.pdTypeCB.TabIndex = 106;
            this.pdTypeCB.SelectedValueChanged += new System.EventHandler(this.pdTypeCB_SelectedValueChanged);
            // 
            // txt_bNo
            // 
            this.txt_bNo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_bNo.ForeColor = System.Drawing.Color.White;
            this.txt_bNo.Location = new System.Drawing.Point(132, 11);
            this.txt_bNo.Name = "txt_bNo";
            this.txt_bNo.ReadOnly = true;
            this.txt_bNo.Size = new System.Drawing.Size(192, 26);
            this.txt_bNo.TabIndex = 98;
            this.txt_bNo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_bNo_Validating);
            // 
            // txt_bNoValidate
            // 
            this.txt_bNoValidate.BackColor = System.Drawing.Color.White;
            this.txt_bNoValidate.ForeColor = System.Drawing.Color.Red;
            this.txt_bNoValidate.Location = new System.Drawing.Point(132, 37);
            this.txt_bNoValidate.Name = "txt_bNoValidate";
            this.txt_bNoValidate.ReadOnly = true;
            this.txt_bNoValidate.Size = new System.Drawing.Size(192, 26);
            this.txt_bNoValidate.TabIndex = 104;
            this.txt_bNoValidate.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(56, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 97;
            this.label5.Text = "批次号：";
            // 
            // wkLineCB
            // 
            this.wkLineCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wkLineCB.FormattingEnabled = true;
            this.wkLineCB.Items.AddRange(new object[] {
            "140-U010A",
            "140-U010B",
            "240-U010A",
            "240-U010B",
            "340-U010A",
            "340-U010B"});
            this.wkLineCB.Location = new System.Drawing.Point(455, 79);
            this.wkLineCB.Name = "wkLineCB";
            this.wkLineCB.Size = new System.Drawing.Size(192, 24);
            this.wkLineCB.TabIndex = 108;
            this.wkLineCB.SelectedValueChanged += new System.EventHandler(this.wkLineCB_SelectedValueChanged);
            // 
            // txt_nbt
            // 
            this.txt_nbt.FormattingEnabled = true;
            this.txt_nbt.Items.AddRange(new object[] {
            "纺丝级  H",
            "工程塑料级  P",
            "薄膜级  F"});
            this.txt_nbt.Location = new System.Drawing.Point(455, 193);
            this.txt_nbt.Name = "txt_nbt";
            this.txt_nbt.Size = new System.Drawing.Size(192, 24);
            this.txt_nbt.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 107;
            this.label6.Text = "线别：";
            // 
            // txt_characteristicsByChange
            // 
            this.txt_characteristicsByChange.Location = new System.Drawing.Point(455, 136);
            this.txt_characteristicsByChange.Name = "txt_characteristicsByChange";
            this.txt_characteristicsByChange.Size = new System.Drawing.Size(192, 26);
            this.txt_characteristicsByChange.TabIndex = 100;
            // 
            // txt_siloNum
            // 
            this.txt_siloNum.FormattingEnabled = true;
            this.txt_siloNum.Items.AddRange(new object[] {
            "纺丝级  H",
            "工程塑料级  P",
            "薄膜级  F"});
            this.txt_siloNum.Location = new System.Drawing.Point(132, 193);
            this.txt_siloNum.Name = "txt_siloNum";
            this.txt_siloNum.Size = new System.Drawing.Size(192, 24);
            this.txt_siloNum.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 99;
            this.label7.Text = "生产特性：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 109;
            this.label8.Text = "净重：";
            // 
            // dtp_pdDate
            // 
            this.dtp_pdDate.Location = new System.Drawing.Point(132, 132);
            this.dtp_pdDate.Name = "dtp_pdDate";
            this.dtp_pdDate.Size = new System.Drawing.Size(192, 26);
            this.dtp_pdDate.TabIndex = 103;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 102;
            this.label9.Text = "生产日期：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 101;
            this.label10.Text = "料仓号：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 105;
            this.label11.Text = "产品类别：";
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
            this.AddBatNoTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BatSaveBtn;
        private System.Windows.Forms.Button BatResetBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl AddBatNoTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox gradeCB;
        private System.Windows.Forms.Label gradeLB;
        private System.Windows.Forms.TextBox materialValidateBox;
        private System.Windows.Forms.TextBox materialTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productTypeCB;
        private System.Windows.Forms.TextBox txt_batchNo;
        private System.Windows.Forms.TextBox batchValidateBox;
        private System.Windows.Forms.Label batchNoLB;
        private System.Windows.Forms.ComboBox workLineCB;
        private System.Windows.Forms.ComboBox nbtWeightCB;
        private System.Windows.Forms.Label workLineLB;
        private System.Windows.Forms.TextBox txt_characteristics;
        private System.Windows.Forms.ComboBox txt_siloNo;
        private System.Windows.Forms.Label characteristicsLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_productDate;
        private System.Windows.Forms.Label productDateLB;
        private System.Windows.Forms.Label siloNoLB;
        private System.Windows.Forms.Label productTypeLB;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtp_bNoCrDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txt_grade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox matTbValidate;
        private System.Windows.Forms.TextBox matTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pdTypeCB;
        private System.Windows.Forms.TextBox txt_bNo;
        private System.Windows.Forms.TextBox txt_bNoValidate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox wkLineCB;
        private System.Windows.Forms.ComboBox txt_nbt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_characteristicsByChange;
        private System.Windows.Forms.ComboBox txt_siloNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_pdDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}