namespace SEIDChecksum
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_IDLength = new System.Windows.Forms.Label();
            this.button_Calc = new System.Windows.Forms.Button();
            this.textBox_IDWithChecksum = new System.Windows.Forms.TextBox();
            this.checkBox_hasChecksum = new System.Windows.Forms.CheckBox();
            this.checkBox_hasHeader = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(19, 17);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(23, 12);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.AcceptsReturn = true;
            this.textBox_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ID.Location = new System.Drawing.Point(49, 8);
            this.textBox_ID.MaxLength = 0;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(361, 21);
            this.textBox_ID.TabIndex = 1;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            this.textBox_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_KeyPress);
            // 
            // label_IDLength
            // 
            this.label_IDLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_IDLength.AutoSize = true;
            this.label_IDLength.Location = new System.Drawing.Point(416, 13);
            this.label_IDLength.Name = "label_IDLength";
            this.label_IDLength.Size = new System.Drawing.Size(23, 12);
            this.label_IDLength.TabIndex = 2;
            this.label_IDLength.Text = "(0)";
            // 
            // button_Calc
            // 
            this.button_Calc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Calc.Enabled = false;
            this.button_Calc.Location = new System.Drawing.Point(445, 74);
            this.button_Calc.Name = "button_Calc";
            this.button_Calc.Size = new System.Drawing.Size(75, 23);
            this.button_Calc.TabIndex = 3;
            this.button_Calc.Text = "计算";
            this.button_Calc.UseVisualStyleBackColor = true;
            this.button_Calc.Click += new System.EventHandler(this.button_Calc_Click);
            // 
            // textBox_IDWithChecksum
            // 
            this.textBox_IDWithChecksum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_IDWithChecksum.Location = new System.Drawing.Point(49, 45);
            this.textBox_IDWithChecksum.MaxLength = 42;
            this.textBox_IDWithChecksum.Name = "textBox_IDWithChecksum";
            this.textBox_IDWithChecksum.ReadOnly = true;
            this.textBox_IDWithChecksum.Size = new System.Drawing.Size(369, 21);
            this.textBox_IDWithChecksum.TabIndex = 4;
            // 
            // checkBox_hasChecksum
            // 
            this.checkBox_hasChecksum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_hasChecksum.AutoSize = true;
            this.checkBox_hasChecksum.Checked = true;
            this.checkBox_hasChecksum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_hasChecksum.Location = new System.Drawing.Point(445, 45);
            this.checkBox_hasChecksum.Name = "checkBox_hasChecksum";
            this.checkBox_hasChecksum.Size = new System.Drawing.Size(72, 16);
            this.checkBox_hasChecksum.TabIndex = 5;
            this.checkBox_hasChecksum.Text = "含校验位";
            this.checkBox_hasChecksum.UseVisualStyleBackColor = true;
            this.checkBox_hasChecksum.CheckedChanged += new System.EventHandler(this.checkBoxs_CheckedChanged);
            // 
            // checkBox_hasHeader
            // 
            this.checkBox_hasHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_hasHeader.AutoSize = true;
            this.checkBox_hasHeader.Checked = true;
            this.checkBox_hasHeader.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_hasHeader.Location = new System.Drawing.Point(445, 12);
            this.checkBox_hasHeader.Name = "checkBox_hasHeader";
            this.checkBox_hasHeader.Size = new System.Drawing.Size(66, 16);
            this.checkBox_hasHeader.TabIndex = 6;
            this.checkBox_hasHeader.Text = "含8位头";
            this.checkBox_hasHeader.UseVisualStyleBackColor = true;
            this.checkBox_hasHeader.CheckedChanged += new System.EventHandler(this.checkBoxs_CheckedChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 109);
            this.Controls.Add(this.checkBox_hasHeader);
            this.Controls.Add(this.checkBox_hasChecksum);
            this.Controls.Add(this.textBox_IDWithChecksum);
            this.Controls.Add(this.button_Calc);
            this.Controls.Add(this.label_IDLength);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Main";
            this.Text = "SEID校验位计算工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_IDLength;
        private System.Windows.Forms.Button button_Calc;
        private System.Windows.Forms.TextBox textBox_IDWithChecksum;
        private System.Windows.Forms.CheckBox checkBox_hasChecksum;
        private System.Windows.Forms.CheckBox checkBox_hasHeader;
    }
}

