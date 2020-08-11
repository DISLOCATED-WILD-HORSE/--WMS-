namespace HSC_SYPrintSystem
{
    partial class UpdateMatRelationForm
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
            this.matMapingSaveBTN = new System.Windows.Forms.Button();
            this.hscMatValidateBox = new System.Windows.Forms.TextBox();
            this.materialValidateBox = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.matMapingSaveBTN);
            this.panel1.Controls.Add(this.hscMatValidateBox);
            this.panel1.Controls.Add(this.materialValidateBox);
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
            // matMapingSaveBTN
            // 
            this.matMapingSaveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.matMapingSaveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matMapingSaveBTN.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.matMapingSaveBTN.ForeColor = System.Drawing.Color.White;
            this.matMapingSaveBTN.Location = new System.Drawing.Point(581, 292);
            this.matMapingSaveBTN.Name = "matMapingSaveBTN";
            this.matMapingSaveBTN.Size = new System.Drawing.Size(75, 51);
            this.matMapingSaveBTN.TabIndex = 89;
            this.matMapingSaveBTN.Text = "保存";
            this.matMapingSaveBTN.UseVisualStyleBackColor = false;
            this.matMapingSaveBTN.Click += new System.EventHandler(this.matMapingSaveBTN_Click);
            // 
            // hscMatValidateBox
            // 
            this.hscMatValidateBox.BackColor = System.Drawing.Color.White;
            this.hscMatValidateBox.ForeColor = System.Drawing.Color.Red;
            this.hscMatValidateBox.Location = new System.Drawing.Point(464, 101);
            this.hscMatValidateBox.Name = "hscMatValidateBox";
            this.hscMatValidateBox.ReadOnly = true;
            this.hscMatValidateBox.Size = new System.Drawing.Size(192, 21);
            this.hscMatValidateBox.TabIndex = 88;
            this.hscMatValidateBox.Visible = false;
            // 
            // materialValidateBox
            // 
            this.materialValidateBox.BackColor = System.Drawing.Color.White;
            this.materialValidateBox.ForeColor = System.Drawing.Color.Red;
            this.materialValidateBox.Location = new System.Drawing.Point(129, 101);
            this.materialValidateBox.Name = "materialValidateBox";
            this.materialValidateBox.ReadOnly = true;
            this.materialValidateBox.Size = new System.Drawing.Size(192, 21);
            this.materialValidateBox.TabIndex = 87;
            this.materialValidateBox.Visible = false;
            // 
            // hscMat_ID
            // 
            this.hscMat_ID.Font = new System.Drawing.Font("宋体", 12F);
            this.hscMat_ID.Location = new System.Drawing.Point(464, 73);
            this.hscMat_ID.Name = "hscMat_ID";
            this.hscMat_ID.Size = new System.Drawing.Size(192, 26);
            this.hscMat_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(365, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "新物料号：";
            // 
            // materialTB
            // 
            this.materialTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.materialTB.Font = new System.Drawing.Font("宋体", 12F);
            this.materialTB.Location = new System.Drawing.Point(129, 73);
            this.materialTB.Name = "materialTB";
            this.materialTB.ReadOnly = true;
            this.materialTB.Size = new System.Drawing.Size(192, 26);
            this.materialTB.TabIndex = 2;
            // 
            // batchNoLB
            // 
            this.batchNoLB.AutoSize = true;
            this.batchNoLB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.batchNoLB.Location = new System.Drawing.Point(47, 76);
            this.batchNoLB.Name = "batchNoLB";
            this.batchNoLB.Size = new System.Drawing.Size(76, 16);
            this.batchNoLB.TabIndex = 83;
            this.batchNoLB.Text = "物料号：";
            // 
            // UpdateMatRelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 457);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateMatRelationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑物料关系";
            this.Load += new System.EventHandler(this.UpdateMatRelationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox hscMatValidateBox;
        private System.Windows.Forms.TextBox materialValidateBox;
        private System.Windows.Forms.TextBox hscMat_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox materialTB;
        private System.Windows.Forms.Label batchNoLB;
        private System.Windows.Forms.Button matMapingSaveBTN;
    }
}