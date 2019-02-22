namespace WindowsFormsApp1
{
    partial class MainFrm
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
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnComb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(74, 65);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(372, 23);
            this.btnSplit.TabIndex = 0;
            this.btnSplit.Text = "分割文件(将大文件分割为小文件，突破文件大小限制)";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // 
            // btnComb
            // 
            this.btnComb.Location = new System.Drawing.Point(74, 146);
            this.btnComb.Name = "btnComb";
            this.btnComb.Size = new System.Drawing.Size(372, 23);
            this.btnComb.TabIndex = 1;
            this.btnComb.Text = "组合文件(将分割的文件重新组合成大文件)";
            this.btnComb.UseVisualStyleBackColor = true;
            this.btnComb.Click += new System.EventHandler(this.BtnComb_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 252);
            this.Controls.Add(this.btnComb);
            this.Controls.Add(this.btnSplit);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大文件工具";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnComb;
    }
}

