namespace ChargeSys.Main.Controls
{
    partial class UCCharge
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
            this.txtPlateNo = new CI.Controls.FlatField();
            this.materialListView1 = new EASkins.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settingFiller = new CI.UIComponents.Filler.EntityFiller();
            this.btnSave = new EASkins.Controls.MaterialRaisedButton();
            this.flatField1 = new CI.Controls.FlatField();
            this.flatField2 = new CI.Controls.FlatField();
            this.flatField3 = new CI.Controls.FlatField();
            this.flatField4 = new CI.Controls.FlatField();
            this.flatField5 = new CI.Controls.FlatField();
            this.SuspendLayout();
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.BackColor = System.Drawing.Color.Transparent;
            this.txtPlateNo.Caption = "号牌号码: ";
            this.txtPlateNo.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPlateNo.CaptionWidth = 0;
            this.txtPlateNo.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPlateNo.Location = new System.Drawing.Point(46, 25);
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Size = new System.Drawing.Size(300, 28);
            this.txtPlateNo.TabIndex = 10;
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(46, 139);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = EASkins.MouseState.OUT;
            this.materialListView1.MultiSelect = false;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(846, 330);
            this.materialListView1.TabIndex = 11;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "号牌号码";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "检验项目";
            this.columnHeader2.Width = 101;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "检测次数";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "价格";
            this.columnHeader4.Width = 154;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(837, 25);
            this.btnSave.MouseState = EASkins.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flatField1
            // 
            this.flatField1.BackColor = System.Drawing.Color.Transparent;
            this.flatField1.Caption = "检验流水号:";
            this.flatField1.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField1.CaptionWidth = 0;
            this.flatField1.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField1.Location = new System.Drawing.Point(387, 25);
            this.flatField1.Name = "flatField1";
            this.flatField1.Size = new System.Drawing.Size(300, 28);
            this.flatField1.TabIndex = 10;
            // 
            // flatField2
            // 
            this.flatField2.BackColor = System.Drawing.Color.Transparent;
            this.flatField2.Caption = "车辆类型: ";
            this.flatField2.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField2.CaptionWidth = 0;
            this.flatField2.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField2.Location = new System.Drawing.Point(46, 59);
            this.flatField2.Name = "flatField2";
            this.flatField2.Size = new System.Drawing.Size(300, 28);
            this.flatField2.TabIndex = 10;
            // 
            // flatField3
            // 
            this.flatField3.BackColor = System.Drawing.Color.Transparent;
            this.flatField3.Caption = "引车员:   ";
            this.flatField3.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField3.CaptionWidth = 0;
            this.flatField3.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField3.Location = new System.Drawing.Point(387, 59);
            this.flatField3.Name = "flatField3";
            this.flatField3.Size = new System.Drawing.Size(300, 28);
            this.flatField3.TabIndex = 10;
            // 
            // flatField4
            // 
            this.flatField4.BackColor = System.Drawing.Color.Transparent;
            this.flatField4.Caption = "检测时间: ";
            this.flatField4.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField4.CaptionWidth = 0;
            this.flatField4.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField4.Location = new System.Drawing.Point(46, 93);
            this.flatField4.Name = "flatField4";
            this.flatField4.Size = new System.Drawing.Size(300, 28);
            this.flatField4.TabIndex = 10;
            // 
            // flatField5
            // 
            this.flatField5.BackColor = System.Drawing.Color.Transparent;
            this.flatField5.Caption = "金额:     ";
            this.flatField5.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField5.CaptionWidth = 0;
            this.flatField5.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField5.Location = new System.Drawing.Point(387, 93);
            this.flatField5.Name = "flatField5";
            this.flatField5.Size = new System.Drawing.Size(179, 28);
            this.flatField5.TabIndex = 10;
            this.flatField5.Text = "0";
            this.flatField5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UCCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.flatField5);
            this.Controls.Add(this.flatField4);
            this.Controls.Add(this.flatField3);
            this.Controls.Add(this.flatField2);
            this.Controls.Add(this.flatField1);
            this.Controls.Add(this.txtPlateNo);
            this.Name = "UCCharge";
            this.Size = new System.Drawing.Size(930, 563);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CI.Controls.FlatField txtPlateNo;
        private EASkins.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private CI.UIComponents.Filler.EntityFiller settingFiller;
        private EASkins.Controls.MaterialRaisedButton btnSave;
        private CI.Controls.FlatField flatField1;
        private CI.Controls.FlatField flatField2;
        private CI.Controls.FlatField flatField3;
        private CI.Controls.FlatField flatField4;
        private CI.Controls.FlatField flatField5;
    }
}
