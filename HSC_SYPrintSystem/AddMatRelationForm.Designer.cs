namespace HSC_SYPrintSystem
{
    partial class AddMatRelationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hscMatValidateBox = new System.Windows.Forms.TextBox();
            this.materialValidateBox = new System.Windows.Forms.TextBox();
            this.BatResetBtn = new System.Windows.Forms.Button();
            this.BatSaveBtn = new System.Windows.Forms.Button();
            this.hscMat_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTB = new System.Windows.Forms.TextBox();
            this.batchNoLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.hscMatValidateBox);
            this.panel1.Controls.Add(this.materialValidateBox);
            this.panel1.Controls.Add(this.BatResetBtn);
            this.panel1.Controls.Add(this.BatSaveBtn);
            this.panel1.Controls.Add(this.hscMat_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.materialTB);
            this.panel1.Controls.Add(this.batchNoLB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 457);
            this.panel1.TabIndex = 0;
            // 
            // hscMatValidateBox
            // 
            this.hscMatValidateBox.BackColor = System.Drawing.Color.White;
            this.hscMatValidateBox.ForeColor = System.Drawing.Color.Red;
            this.hscMatValidateBox.Location = new System.Drawing.Point(466, 83);
            this.hscMatValidateBox.Name = "hscMatValidateBox";
            this.hscMatValidateBox.ReadOnly = true;
            this.hscMatValidateBox.Size = new System.Drawing.Size(192, 21);
            this.hscMatValidateBox.TabIndex = 82;
            this.hscMatValidateBox.Visible = false;
            // 
            // materialValidateBox
            // 
            this.materialValidateBox.BackColor = System.Drawing.Color.White;
            this.materialValidateBox.ForeColor = System.Drawing.Color.Red;
            this.materialValidateBox.Location = new System.Drawing.Point(131, 83);
            this.materialValidateBox.Name = "materialValidateBox";
            this.materialValidateBox.ReadOnly = true;
            this.materialValidateBox.Size = new System.Drawing.Size(192, 21);
            this.materialValidateBox.TabIndex = 81;
            this.materialValidateBox.Visible = false;
            // 
            // BatResetBtn
            // 
            this.BatResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BatResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatResetBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.BatResetBtn.ForeColor = System.Drawing.Color.White;
            this.BatResetBtn.Location = new System.Drawing.Point(248, 327);
            this.BatResetBtn.Name = "BatResetBtn";
            this.BatResetBtn.Size = new System.Drawing.Size(75, 51);
            this.BatResetBtn.TabIndex = 80;
            this.BatResetBtn.Text = "重置";
            this.BatResetBtn.UseVisualStyleBackColor = false;
            this.BatResetBtn.Click += new System.EventHandler(this.BatResetBtn_Click);
            // 
            // BatSaveBtn
            // 
            this.BatSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BatSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BatSaveBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.BatSaveBtn.ForeColor = System.Drawing.Color.White;
            this.BatSaveBtn.Location = new System.Drawing.Point(131, 327);
            this.BatSaveBtn.Name = "BatSaveBtn";
            this.BatSaveBtn.Size = new System.Drawing.Size(75, 51);
            this.BatSaveBtn.TabIndex = 79;
            this.BatSaveBtn.Text = "保存";
            this.BatSaveBtn.UseVisualStyleBackColor = false;
            this.BatSaveBtn.Click += new System.EventHandler(this.BatSaveBtn_Click);
            // 
            // hscMat_ID
            // 
            this.hscMat_ID.Font = new System.Drawing.Font("宋体", 12F);
            this.hscMat_ID.Location = new System.Drawing.Point(466, 55);
            this.hscMat_ID.Name = "hscMat_ID";
            this.hscMat_ID.Size = new System.Drawing.Size(192, 26);
            this.hscMat_ID.TabIndex = 78;
            this.hscMat_ID.Validating += new System.ComponentModel.CancelEventHandler(this.hscMat_ID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(367, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "新物料号：";
            // 
            // materialTB
            // 
            this.materialTB.Font = new System.Drawing.Font("宋体", 12F);
            this.materialTB.Location = new System.Drawing.Point(131, 55);
            this.materialTB.Name = "materialTB";
            this.materialTB.Size = new System.Drawing.Size(192, 26);
            this.materialTB.TabIndex = 76;
            this.materialTB.Validating += new System.ComponentModel.CancelEventHandler(this.materialTB_Validating);
            // 
            // batchNoLB
            // 
            this.batchNoLB.AutoSize = true;
            this.batchNoLB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.batchNoLB.Location = new System.Drawing.Point(49, 58);
            this.batchNoLB.Name = "batchNoLB";
            this.batchNoLB.Size = new System.Drawing.Size(76, 16);
            this.batchNoLB.TabIndex = 1;
            this.batchNoLB.Text = "物料号：";
            // 
            // AddMatRelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 457);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddMatRelationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增物料对应关系";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddMatRelationForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label batchNoLB;
        private System.Windows.Forms.TextBox materialTB;
        private System.Windows.Forms.TextBox hscMat_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BatResetBtn;
        private System.Windows.Forms.Button BatSaveBtn;
        private System.Windows.Forms.TextBox hscMatValidateBox;
        private System.Windows.Forms.TextBox materialValidateBox;
    }
}