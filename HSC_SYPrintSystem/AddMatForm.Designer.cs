namespace HSC_SYPrintSystem
{
    partial class AddMatForm
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
            this.panelAdd = new System.Windows.Forms.Panel();
            this.materialValidateBox = new System.Windows.Forms.TextBox();
            this.MatResetBtn = new System.Windows.Forms.Button();
            this.MatSaveBtn = new System.Windows.Forms.Button();
            this.matJHSpeci = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.matSpeci = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.oldMatDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.matDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oldMaterialTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTB = new System.Windows.Forms.TextBox();
            this.materialLB = new System.Windows.Forms.Label();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.White;
            this.panelAdd.Controls.Add(this.materialValidateBox);
            this.panelAdd.Controls.Add(this.MatResetBtn);
            this.panelAdd.Controls.Add(this.MatSaveBtn);
            this.panelAdd.Controls.Add(this.matJHSpeci);
            this.panelAdd.Controls.Add(this.label6);
            this.panelAdd.Controls.Add(this.matSpeci);
            this.panelAdd.Controls.Add(this.label5);
            this.panelAdd.Controls.Add(this.oldMatDesc);
            this.panelAdd.Controls.Add(this.label4);
            this.panelAdd.Controls.Add(this.matDesc);
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.oldMaterialTB);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Controls.Add(this.materialTB);
            this.panelAdd.Controls.Add(this.materialLB);
            this.panelAdd.Font = new System.Drawing.Font("宋体", 12F);
            this.panelAdd.Location = new System.Drawing.Point(2, 1);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(701, 457);
            this.panelAdd.TabIndex = 0;
            // 
            // materialValidateBox
            // 
            this.materialValidateBox.BackColor = System.Drawing.Color.White;
            this.materialValidateBox.ForeColor = System.Drawing.Color.Red;
            this.materialValidateBox.Location = new System.Drawing.Point(125, 47);
            this.materialValidateBox.Name = "materialValidateBox";
            this.materialValidateBox.ReadOnly = true;
            this.materialValidateBox.Size = new System.Drawing.Size(214, 26);
            this.materialValidateBox.TabIndex = 64;
            this.materialValidateBox.Visible = false;
            // 
            // MatResetBtn
            // 
            this.MatResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MatResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatResetBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.MatResetBtn.ForeColor = System.Drawing.Color.White;
            this.MatResetBtn.Location = new System.Drawing.Point(264, 278);
            this.MatResetBtn.Name = "MatResetBtn";
            this.MatResetBtn.Size = new System.Drawing.Size(75, 51);
            this.MatResetBtn.TabIndex = 63;
            this.MatResetBtn.Text = "重置";
            this.MatResetBtn.UseVisualStyleBackColor = false;
            this.MatResetBtn.Click += new System.EventHandler(this.MatResetBtn_Click);
            // 
            // MatSaveBtn
            // 
            this.MatSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MatSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatSaveBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.MatSaveBtn.ForeColor = System.Drawing.Color.White;
            this.MatSaveBtn.Location = new System.Drawing.Point(145, 278);
            this.MatSaveBtn.Name = "MatSaveBtn";
            this.MatSaveBtn.Size = new System.Drawing.Size(75, 51);
            this.MatSaveBtn.TabIndex = 62;
            this.MatSaveBtn.Text = "保存";
            this.MatSaveBtn.UseVisualStyleBackColor = false;
            this.MatSaveBtn.Click += new System.EventHandler(this.MatSaveBtn_Click);
            // 
            // matJHSpeci
            // 
            this.matJHSpeci.Location = new System.Drawing.Point(463, 136);
            this.matJHSpeci.Name = "matJHSpeci";
            this.matJHSpeci.Size = new System.Drawing.Size(219, 26);
            this.matJHSpeci.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "聚合产品规格：";
            // 
            // matSpeci
            // 
            this.matSpeci.Location = new System.Drawing.Point(125, 136);
            this.matSpeci.Name = "matSpeci";
            this.matSpeci.Size = new System.Drawing.Size(214, 26);
            this.matSpeci.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "标签品种规格：";
            // 
            // oldMatDesc
            // 
            this.oldMatDesc.Location = new System.Drawing.Point(463, 81);
            this.oldMatDesc.Name = "oldMatDesc";
            this.oldMatDesc.Size = new System.Drawing.Size(219, 26);
            this.oldMatDesc.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "旧物料描述：";
            // 
            // matDesc
            // 
            this.matDesc.Location = new System.Drawing.Point(125, 81);
            this.matDesc.Name = "matDesc";
            this.matDesc.Size = new System.Drawing.Size(214, 26);
            this.matDesc.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "物料描述：";
            // 
            // oldMaterialTB
            // 
            this.oldMaterialTB.Location = new System.Drawing.Point(463, 25);
            this.oldMaterialTB.Name = "oldMaterialTB";
            this.oldMaterialTB.Size = new System.Drawing.Size(219, 26);
            this.oldMaterialTB.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "旧物料号：";
            // 
            // materialTB
            // 
            this.materialTB.Location = new System.Drawing.Point(125, 25);
            this.materialTB.Name = "materialTB";
            this.materialTB.Size = new System.Drawing.Size(214, 26);
            this.materialTB.TabIndex = 33;
            this.materialTB.Validating += new System.ComponentModel.CancelEventHandler(this.materialTB_Validating);
            // 
            // materialLB
            // 
            this.materialLB.AutoSize = true;
            this.materialLB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.materialLB.Location = new System.Drawing.Point(54, 28);
            this.materialLB.Name = "materialLB";
            this.materialLB.Size = new System.Drawing.Size(76, 16);
            this.materialLB.TabIndex = 32;
            this.materialLB.Text = "物料号：";
            // 
            // AddMatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 457);
            this.Controls.Add(this.panelAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddMatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增物料";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddMatForm_FormClosed);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button MatResetBtn;
        private System.Windows.Forms.Button MatSaveBtn;
        private System.Windows.Forms.TextBox matJHSpeci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox matSpeci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox oldMatDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox matDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldMaterialTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox materialTB;
        private System.Windows.Forms.Label materialLB;
        private System.Windows.Forms.TextBox materialValidateBox;
    }
}