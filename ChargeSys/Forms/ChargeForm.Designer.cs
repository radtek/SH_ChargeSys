namespace ChargeSys.Main.Forms
{
    partial class ChargeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChargeForm));
            this.btnTest = new EASkins.Controls.MaterialRaisedButton();
            this.btnSave = new EASkins.Controls.MaterialRaisedButton();
            this.materialListView1 = new EASkins.Controls.MaterialListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPrice = new CI.Controls.FlatField();
            this.flatField4 = new CI.Controls.FlatField();
            this.flatField3 = new CI.Controls.FlatField();
            this.flatField2 = new CI.Controls.FlatField();
            this.flatField1 = new CI.Controls.FlatField();
            this.txtPlateNo = new CI.Controls.FlatField();
            this.carFiller = new CI.UIComponents.Filler.EntityFiller();
            this.labPrice = new System.Windows.Forms.Label();
            this.btnCall = new EASkins.Controls.MaterialRaisedButton();
            this.txtOtherFee = new CI.Controls.FlatField();
            this.txtOtherFeeRemark = new CI.Controls.FlatField();
            this.chargeFiller = new CI.UIComponents.Filler.EntityFiller();
            this.btnPrint = new EASkins.Controls.MaterialRaisedButton();
            this.btnClear = new EASkins.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.AutoSize = true;
            this.btnTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTest.Depth = 0;
            this.btnTest.Icon = null;
            this.btnTest.Location = new System.Drawing.Point(772, 146);
            this.btnTest.MouseState = EASkins.MouseState.HOVER;
            this.btnTest.Name = "btnTest";
            this.btnTest.Primary = true;
            this.btnTest.Size = new System.Drawing.Size(81, 36);
            this.btnTest.TabIndex = 22;
            this.btnTest.Text = "模拟数据";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.Location = new System.Drawing.Point(510, 286);
            this.btnSave.MouseState = EASkins.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(83, 36);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(5, 185);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = EASkins.MouseState.OUT;
            this.materialListView1.MultiSelect = false;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(357, 332);
            this.materialListView1.TabIndex = 20;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
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
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.Caption = "总金额:   ";
            this.txtPrice.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrice.CaptionWidth = 0;
            this.chargeFiller.SetEntityField(this.txtPrice, new CI.UIComponents.Filler.TextEntry("Price", ""));
            this.carFiller.SetEntityField(this.txtPrice, new CI.UIComponents.Filler.TextEntry("Price", ""));
            this.txtPrice.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPrice.Location = new System.Drawing.Point(406, 141);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(179, 28);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flatField4
            // 
            this.flatField4.BackColor = System.Drawing.Color.Transparent;
            this.flatField4.Caption = "检测时间: ";
            this.flatField4.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField4.CaptionWidth = 0;
            this.chargeFiller.SetEntityField(this.flatField4, new CI.UIComponents.Filler.TextEntry("DateOfTest", ""));
            this.carFiller.SetEntityField(this.flatField4, new CI.UIComponents.Filler.TextEntry("TestDate", ""));
            this.flatField4.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField4.Location = new System.Drawing.Point(5, 141);
            this.flatField4.Name = "flatField4";
            this.flatField4.ReadOnly = true;
            this.flatField4.Size = new System.Drawing.Size(300, 28);
            this.flatField4.TabIndex = 15;
            // 
            // flatField3
            // 
            this.flatField3.BackColor = System.Drawing.Color.Transparent;
            this.flatField3.Caption = "引车员:   ";
            this.flatField3.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField3.CaptionWidth = 0;
            this.chargeFiller.SetEntityField(this.flatField3, new CI.UIComponents.Filler.TextEntry("Guider", ""));
            this.carFiller.SetEntityField(this.flatField3, new CI.UIComponents.Filler.TextEntry("Guider", ""));
            this.flatField3.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField3.Location = new System.Drawing.Point(406, 107);
            this.flatField3.Name = "flatField3";
            this.flatField3.ReadOnly = true;
            this.flatField3.Size = new System.Drawing.Size(300, 28);
            this.flatField3.TabIndex = 16;
            // 
            // flatField2
            // 
            this.flatField2.BackColor = System.Drawing.Color.Transparent;
            this.flatField2.Caption = "车辆类型: ";
            this.flatField2.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField2.CaptionWidth = 0;
            this.chargeFiller.SetEntityField(this.flatField2, new CI.UIComponents.Filler.TextEntry("VehicleType", ""));
            this.carFiller.SetEntityField(this.flatField2, new CI.UIComponents.Filler.TextEntry("CarType", ""));
            this.flatField2.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField2.Location = new System.Drawing.Point(5, 107);
            this.flatField2.Name = "flatField2";
            this.flatField2.ReadOnly = true;
            this.flatField2.Size = new System.Drawing.Size(300, 28);
            this.flatField2.TabIndex = 17;
            // 
            // flatField1
            // 
            this.flatField1.BackColor = System.Drawing.Color.Transparent;
            this.flatField1.Caption = "检验流水号:";
            this.flatField1.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField1.CaptionWidth = 0;
            this.chargeFiller.SetEntityField(this.flatField1, new CI.UIComponents.Filler.TextEntry("TestNo", ""));
            this.carFiller.SetEntityField(this.flatField1, new CI.UIComponents.Filler.TextEntry("TestNo", ""));
            this.flatField1.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField1.Location = new System.Drawing.Point(406, 73);
            this.flatField1.Name = "flatField1";
            this.flatField1.ReadOnly = true;
            this.flatField1.Size = new System.Drawing.Size(300, 28);
            this.flatField1.TabIndex = 18;
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.BackColor = System.Drawing.Color.Transparent;
            this.txtPlateNo.Caption = "号牌号码: ";
            this.txtPlateNo.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPlateNo.CaptionWidth = 0;
            this.chargeFiller.SetEntityField(this.txtPlateNo, new CI.UIComponents.Filler.TextEntry("PlateNo", ""));
            this.carFiller.SetEntityField(this.txtPlateNo, new CI.UIComponents.Filler.TextEntry("PlateNo", ""));
            this.txtPlateNo.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPlateNo.Location = new System.Drawing.Point(5, 73);
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.ReadOnly = true;
            this.txtPlateNo.Size = new System.Drawing.Size(300, 28);
            this.txtPlateNo.TabIndex = 19;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.ForeColor = System.Drawing.Color.Red;
            this.labPrice.Location = new System.Drawing.Point(602, 146);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(43, 17);
            this.labPrice.TabIndex = 23;
            this.labPrice.Text = "label1";
            // 
            // btnCall
            // 
            this.btnCall.AutoSize = true;
            this.btnCall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCall.Depth = 0;
            this.btnCall.Icon = ((System.Drawing.Image)(resources.GetObject("btnCall.Icon")));
            this.btnCall.Location = new System.Drawing.Point(406, 286);
            this.btnCall.MouseState = EASkins.MouseState.HOVER;
            this.btnCall.Name = "btnCall";
            this.btnCall.Primary = true;
            this.btnCall.Size = new System.Drawing.Size(83, 36);
            this.btnCall.TabIndex = 24;
            this.btnCall.Text = "叫 号";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // txtOtherFee
            // 
            this.txtOtherFee.BackColor = System.Drawing.Color.Transparent;
            this.txtOtherFee.Caption = "其他费用: ";
            this.txtOtherFee.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOtherFee.CaptionWidth = 0;
            this.txtOtherFee.Font = new System.Drawing.Font("宋体", 12F);
            this.txtOtherFee.Location = new System.Drawing.Point(406, 203);
            this.txtOtherFee.Name = "txtOtherFee";
            this.txtOtherFee.Size = new System.Drawing.Size(179, 28);
            this.txtOtherFee.TabIndex = 25;
            this.txtOtherFee.Text = "0";
            this.txtOtherFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOtherFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtherFee_KeyPress);
            this.txtOtherFee.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOtherFee_KeyUp);
            // 
            // txtOtherFeeRemark
            // 
            this.txtOtherFeeRemark.BackColor = System.Drawing.Color.Transparent;
            this.txtOtherFeeRemark.Caption = "其他收费备注:";
            this.txtOtherFeeRemark.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOtherFeeRemark.CaptionWidth = 0;
            this.txtOtherFeeRemark.Font = new System.Drawing.Font("宋体", 12F);
            this.txtOtherFeeRemark.Location = new System.Drawing.Point(406, 252);
            this.txtOtherFeeRemark.Name = "txtOtherFeeRemark";
            this.txtOtherFeeRemark.Size = new System.Drawing.Size(447, 28);
            this.txtOtherFeeRemark.TabIndex = 26;
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrint.Depth = 0;
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnPrint.Icon = ((System.Drawing.Image)(resources.GetObject("btnPrint.Icon")));
            this.btnPrint.Location = new System.Drawing.Point(614, 286);
            this.btnPrint.MouseState = EASkins.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Primary = true;
            this.btnPrint.Size = new System.Drawing.Size(86, 36);
            this.btnPrint.TabIndex = 52;
            this.btnPrint.Text = "打  印";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.Depth = 0;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnClear.Icon = ((System.Drawing.Image)(resources.GetObject("btnClear.Icon")));
            this.btnClear.Location = new System.Drawing.Point(721, 286);
            this.btnClear.MouseState = EASkins.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(86, 36);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "清  除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 539);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtOtherFeeRemark);
            this.Controls.Add(this.txtOtherFee);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.flatField4);
            this.Controls.Add(this.flatField3);
            this.Controls.Add(this.flatField2);
            this.Controls.Add(this.flatField1);
            this.Controls.Add(this.txtPlateNo);
            this.Name = "ChargeForm";
            this.Text = "ChargeForm";
            this.Title = "";
            this.Shown += new System.EventHandler(this.ChargeForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.ChargeForm_VisibleChanged);
            this.Controls.SetChildIndex(this.txtPlateNo, 0);
            this.Controls.SetChildIndex(this.flatField1, 0);
            this.Controls.SetChildIndex(this.flatField2, 0);
            this.Controls.SetChildIndex(this.flatField3, 0);
            this.Controls.SetChildIndex(this.flatField4, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.materialListView1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnTest, 0);
            this.Controls.SetChildIndex(this.labPrice, 0);
            this.Controls.SetChildIndex(this.btnCall, 0);
            this.Controls.SetChildIndex(this.txtOtherFee, 0);
            this.Controls.SetChildIndex(this.txtOtherFeeRemark, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EASkins.Controls.MaterialRaisedButton btnTest;
        private EASkins.Controls.MaterialRaisedButton btnSave;
        private EASkins.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private CI.Controls.FlatField txtPrice;
        private CI.Controls.FlatField flatField4;
        private CI.Controls.FlatField flatField3;
        private CI.Controls.FlatField flatField2;
        private CI.Controls.FlatField flatField1;
        private CI.Controls.FlatField txtPlateNo;
        private CI.UIComponents.Filler.EntityFiller carFiller;
        private System.Windows.Forms.Label labPrice;
        private EASkins.Controls.MaterialRaisedButton btnCall;
        private CI.Controls.FlatField txtOtherFee;
        private CI.Controls.FlatField txtOtherFeeRemark;
        private CI.UIComponents.Filler.EntityFiller chargeFiller;
        private EASkins.Controls.MaterialRaisedButton btnPrint;
        private EASkins.Controls.MaterialRaisedButton btnClear;
    }
}