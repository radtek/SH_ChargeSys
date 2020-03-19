namespace ChargeSys.Scan
{
    partial class CaptionLabel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labText = new System.Windows.Forms.Label();
            this.labCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labText
            // 
            this.labText.AutoSize = true;
            this.labText.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labText.ForeColor = System.Drawing.Color.Red;
            this.labText.Location = new System.Drawing.Point(1, 17);
            this.labText.Name = "labText";
            this.labText.Size = new System.Drawing.Size(0, 20);
            this.labText.TabIndex = 1;
            // 
            // labCaption
            // 
            this.labCaption.AutoSize = true;
            this.labCaption.Font = new System.Drawing.Font("宋体", 10F);
            this.labCaption.Location = new System.Drawing.Point(-2, 0);
            this.labCaption.Name = "labCaption";
            this.labCaption.Size = new System.Drawing.Size(63, 14);
            this.labCaption.TabIndex = 1;
            this.labCaption.Text = "Caption:";
            this.labCaption.DoubleClick += new System.EventHandler(this.labCaption_DoubleClick);
            // 
            // CaptionLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labCaption);
            this.Controls.Add(this.labText);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CaptionLabel";
            this.Size = new System.Drawing.Size(215, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labText;
        private System.Windows.Forms.Label labCaption;
    }
}
