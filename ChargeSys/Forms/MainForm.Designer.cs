namespace ChargeSys.Main.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tvMenu = new HZH_Controls.Controls.TreeViewEx();
            this.emi_Separator1 = new EASkins.Emi_Separator();
            this.panControl = new System.Windows.Forms.Panel();
            this.labUser = new EASkins.Ami_HeaderLabel();
            this.SuspendLayout();
            // 
            // tvMenu
            // 
            this.tvMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMenu.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.tvMenu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.HideSelection = false;
            this.tvMenu.IsShowByCustomModel = true;
            this.tvMenu.IsShowTip = false;
            this.tvMenu.ItemHeight = 50;
            this.tvMenu.Location = new System.Drawing.Point(0, 62);
            this.tvMenu.LstTips = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("tvMenu.LstTips")));
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.NodeBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.tvMenu.NodeDownPic = ((System.Drawing.Image)(resources.GetObject("tvMenu.NodeDownPic")));
            this.tvMenu.NodeForeColor = System.Drawing.Color.White;
            this.tvMenu.NodeHeight = 50;
            this.tvMenu.NodeIsShowSplitLine = false;
            this.tvMenu.NodeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.tvMenu.NodeSelectedForeColor = System.Drawing.Color.White;
            this.tvMenu.NodeSplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.tvMenu.NodeUpPic = ((System.Drawing.Image)(resources.GetObject("tvMenu.NodeUpPic")));
            this.tvMenu.ParentNodeCanSelect = true;
            this.tvMenu.ShowLines = false;
            this.tvMenu.ShowPlusMinus = false;
            this.tvMenu.ShowRootLines = false;
            this.tvMenu.Size = new System.Drawing.Size(194, 637);
            this.tvMenu.TabIndex = 1;
            this.tvMenu.TipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tvMenu.TipImage = ((System.Drawing.Image)(resources.GetObject("tvMenu.TipImage")));
            // 
            // emi_Separator1
            // 
            this.emi_Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emi_Separator1.Location = new System.Drawing.Point(0, 701);
            this.emi_Separator1.Name = "emi_Separator1";
            this.emi_Separator1.Size = new System.Drawing.Size(1129, 10);
            this.emi_Separator1.TabIndex = 2;
            this.emi_Separator1.Text = "emi_Separator1";
            // 
            // panControl
            // 
            this.panControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panControl.AutoScroll = true;
            this.panControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panControl.Location = new System.Drawing.Point(194, 65);
            this.panControl.Name = "panControl";
            this.panControl.Size = new System.Drawing.Size(933, 634);
            this.panControl.TabIndex = 3;
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.BackColor = System.Drawing.Color.Transparent;
            this.labUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labUser.ForeColor = System.Drawing.Color.White;
            this.labUser.Location = new System.Drawing.Point(12, 32);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(0, 20);
            this.labUser.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 729);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.panControl);
            this.Controls.Add(this.emi_Separator1);
            this.Controls.Add(this.tvMenu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.TreeViewEx tvMenu;
        private EASkins.Emi_Separator emi_Separator1;
        private System.Windows.Forms.Panel panControl;
        private EASkins.Ami_HeaderLabel labUser;
    }
}

