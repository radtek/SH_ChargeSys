namespace ChargeSys.Scan
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.captionLabel1 = new ChargeSys.Scan.CaptionLabel();
            this.captionLabel12 = new ChargeSys.Scan.CaptionLabel();
            this.captionLabel2 = new ChargeSys.Scan.CaptionLabel();
            this.captionLabel11 = new ChargeSys.Scan.CaptionLabel();
            this.captionLabel3 = new ChargeSys.Scan.CaptionLabel();
            this.captionLabel10 = new ChargeSys.Scan.CaptionLabel();
            this.captionLabel4 = new ChargeSys.Scan.CaptionLabel();
            this.captionLabel9 = new ChargeSys.Scan.CaptionLabel();
            this.captionLabel5 = new ChargeSys.Scan.CaptionLabel();
            this.captionLabel8 = new ChargeSys.Scan.CaptionLabel();
            this.captionLabel6 = new ChargeSys.Scan.CaptionLabel();
            this.captionLabel7 = new ChargeSys.Scan.CaptionLabel();
            this.autoDocker1 = new ChargeSys.Scan.AutoDocker(this.components);
            this.captionLabel13 = new ChargeSys.Scan.CaptionLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.captionLabel1);
            this.panel1.Controls.Add(this.captionLabel13);
            this.panel1.Controls.Add(this.captionLabel12);
            this.panel1.Controls.Add(this.captionLabel2);
            this.panel1.Controls.Add(this.captionLabel11);
            this.panel1.Controls.Add(this.captionLabel3);
            this.panel1.Controls.Add(this.captionLabel10);
            this.panel1.Controls.Add(this.captionLabel4);
            this.panel1.Controls.Add(this.captionLabel9);
            this.panel1.Controls.Add(this.captionLabel5);
            this.panel1.Controls.Add(this.captionLabel8);
            this.panel1.Controls.Add(this.captionLabel6);
            this.panel1.Controls.Add(this.captionLabel7);
            this.panel1.Location = new System.Drawing.Point(5, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 634);
            this.panel1.TabIndex = 1;
            // 
            // captionLabel1
            // 
            this.captionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel1.Caption = "号牌号码:";
            this.captionLabel1.ForeColor = System.Drawing.Color.Black;
            this.captionLabel1.Location = new System.Drawing.Point(3, 1);
            this.captionLabel1.Name = "captionLabel1";
            this.captionLabel1.Size = new System.Drawing.Size(254, 44);
            this.captionLabel1.TabIndex = 0;
            this.captionLabel1.Tag = "hphm";
            this.captionLabel1.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // captionLabel12
            // 
            this.captionLabel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel12.Caption = "整备质量:";
            this.captionLabel12.ForeColor = System.Drawing.Color.Black;
            this.captionLabel12.Location = new System.Drawing.Point(3, 529);
            this.captionLabel12.Name = "captionLabel12";
            this.captionLabel12.Size = new System.Drawing.Size(254, 44);
            this.captionLabel12.TabIndex = 0;
            this.captionLabel12.Tag = "zbzl";
            this.captionLabel12.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // captionLabel2
            // 
            this.captionLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel2.Caption = "VIN:";
            this.captionLabel2.ForeColor = System.Drawing.Color.Black;
            this.captionLabel2.Location = new System.Drawing.Point(3, 49);
            this.captionLabel2.Name = "captionLabel2";
            this.captionLabel2.Size = new System.Drawing.Size(254, 44);
            this.captionLabel2.TabIndex = 0;
            this.captionLabel2.Tag = "clsbdh";
            this.captionLabel2.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // captionLabel11
            // 
            this.captionLabel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel11.Caption = "车主姓名:";
            this.captionLabel11.ForeColor = System.Drawing.Color.Black;
            this.captionLabel11.Location = new System.Drawing.Point(3, 481);
            this.captionLabel11.Name = "captionLabel11";
            this.captionLabel11.Size = new System.Drawing.Size(254, 44);
            this.captionLabel11.TabIndex = 0;
            this.captionLabel11.Tag = "syr";
            this.captionLabel11.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // captionLabel3
            // 
            this.captionLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel3.Caption = "车辆类型:";
            this.captionLabel3.ForeColor = System.Drawing.Color.Black;
            this.captionLabel3.Location = new System.Drawing.Point(3, 97);
            this.captionLabel3.Name = "captionLabel3";
            this.captionLabel3.Size = new System.Drawing.Size(254, 44);
            this.captionLabel3.TabIndex = 0;
            this.captionLabel3.Tag = "cllx";
            this.captionLabel3.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // captionLabel10
            // 
            this.captionLabel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel10.Caption = "功率:";
            this.captionLabel10.ForeColor = System.Drawing.Color.Black;
            this.captionLabel10.Location = new System.Drawing.Point(3, 433);
            this.captionLabel10.Name = "captionLabel10";
            this.captionLabel10.Size = new System.Drawing.Size(254, 44);
            this.captionLabel10.TabIndex = 0;
            this.captionLabel10.Tag = "gl";
            this.captionLabel10.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // captionLabel4
            // 
            this.captionLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel4.Caption = "总质量:";
            this.captionLabel4.ForeColor = System.Drawing.Color.Black;
            this.captionLabel4.Location = new System.Drawing.Point(3, 145);
            this.captionLabel4.Name = "captionLabel4";
            this.captionLabel4.Size = new System.Drawing.Size(254, 44);
            this.captionLabel4.TabIndex = 0;
            this.captionLabel4.Tag = "zzl";
            this.captionLabel4.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // captionLabel9
            // 
            this.captionLabel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel9.Caption = "型号:";
            this.captionLabel9.ForeColor = System.Drawing.Color.Black;
            this.captionLabel9.Location = new System.Drawing.Point(3, 385);
            this.captionLabel9.Name = "captionLabel9";
            this.captionLabel9.Size = new System.Drawing.Size(254, 44);
            this.captionLabel9.TabIndex = 0;
            this.captionLabel9.Tag = "clxh";
            this.captionLabel9.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // captionLabel5
            // 
            this.captionLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel5.Caption = "登记日期:";
            this.captionLabel5.ForeColor = System.Drawing.Color.Black;
            this.captionLabel5.Location = new System.Drawing.Point(3, 193);
            this.captionLabel5.Name = "captionLabel5";
            this.captionLabel5.Size = new System.Drawing.Size(254, 44);
            this.captionLabel5.TabIndex = 0;
            this.captionLabel5.Tag = "ccdjrq";
            this.captionLabel5.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // captionLabel8
            // 
            this.captionLabel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel8.Caption = "品牌:";
            this.captionLabel8.ForeColor = System.Drawing.Color.Black;
            this.captionLabel8.Location = new System.Drawing.Point(3, 337);
            this.captionLabel8.Name = "captionLabel8";
            this.captionLabel8.Size = new System.Drawing.Size(254, 44);
            this.captionLabel8.TabIndex = 0;
            this.captionLabel8.Tag = "clpp1";
            this.captionLabel8.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // captionLabel6
            // 
            this.captionLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel6.Caption = "发动机号:";
            this.captionLabel6.ForeColor = System.Drawing.Color.Black;
            this.captionLabel6.Location = new System.Drawing.Point(3, 241);
            this.captionLabel6.Name = "captionLabel6";
            this.captionLabel6.Size = new System.Drawing.Size(254, 44);
            this.captionLabel6.TabIndex = 0;
            this.captionLabel6.Tag = "fdjh";
            this.captionLabel6.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // captionLabel7
            // 
            this.captionLabel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel7.Caption = "里程表读数:";
            this.captionLabel7.ForeColor = System.Drawing.Color.Black;
            this.captionLabel7.Location = new System.Drawing.Point(3, 289);
            this.captionLabel7.Name = "captionLabel7";
            this.captionLabel7.Size = new System.Drawing.Size(254, 44);
            this.captionLabel7.TabIndex = 0;
            this.captionLabel7.Tag = "lcbds";
            this.captionLabel7.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // captionLabel13
            // 
            this.captionLabel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captionLabel13.Caption = "发动机号:";
            this.captionLabel13.ForeColor = System.Drawing.Color.Black;
            this.captionLabel13.Location = new System.Drawing.Point(3, 577);
            this.captionLabel13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.captionLabel13.Name = "captionLabel13";
            this.captionLabel13.Size = new System.Drawing.Size(254, 44);
            this.captionLabel13.TabIndex = 0;
            this.captionLabel13.Tag = "fdjh";
            this.captionLabel13.Click += new System.EventHandler(this.captionLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(280, 709);
            this.Controls.Add(this.panel1);
            this.IsShowCloseBtn = true;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = true;
            this.Text = "Form1";
            this.Title = "";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CaptionLabel captionLabel1;
        private CaptionLabel captionLabel2;
        private CaptionLabel captionLabel3;
        private CaptionLabel captionLabel4;
        private CaptionLabel captionLabel5;
        private CaptionLabel captionLabel6;
        private CaptionLabel captionLabel7;
        private CaptionLabel captionLabel8;
        private CaptionLabel captionLabel9;
        private CaptionLabel captionLabel10;
        private CaptionLabel captionLabel11;
        private CaptionLabel captionLabel12;
        private System.Windows.Forms.Panel panel1;
        private AutoDocker autoDocker1;
        private CaptionLabel captionLabel13;
    }
}

