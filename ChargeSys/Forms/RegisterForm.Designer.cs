namespace ChargeSys.Main.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.carFiller = new CI.UIComponents.Filler.EntityFiller();
            this.txtCarType = new CI.Controls.FlatField();
            this.flatField46 = new CI.Controls.FlatField();
            this.flatField45 = new CI.Controls.FlatField();
            this.flatField40 = new CI.Controls.FlatField();
            this.flatField39 = new CI.Controls.FlatField();
            this.flatField35 = new CI.Controls.FlatField();
            this.flatField48 = new CI.Controls.FlatField();
            this.flatField47 = new CI.Controls.FlatField();
            this.flatField38 = new CI.Controls.FlatField();
            this.txtMakeDate = new CI.Controls.FlatField();
            this.txtWeight = new CI.Controls.FlatField();
            this.txtVIN = new CI.Controls.FlatField();
            this.txtPlateNo = new CI.Controls.FlatField();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.txtQueryVIN = new EASkins.Controls.MaterialSingleLineTextField();
            this.ami_HeaderLabel2 = new EASkins.Ami_HeaderLabel();
            this.combQueryPlateType = new EASkins.Emi_ComboBox();
            this.flatField43 = new CI.Controls.FlatField();
            this.txtAddress = new CI.Controls.FlatField();
            this.flatField44 = new CI.Controls.FlatField();
            this.flatField42 = new CI.Controls.FlatField();
            this.flatField37 = new CI.Controls.FlatField();
            this.flatField36 = new CI.Controls.FlatField();
            this.emi_Separator1 = new EASkins.Emi_Separator();
            this.txtQueryPlateNo = new EASkins.Controls.MaterialSingleLineTextField();
            this.combQueryAera = new EASkins.Emi_ComboBox();
            this.btnPrint = new EASkins.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new EASkins.Controls.MaterialRaisedButton();
            this.ami_HeaderLabel1 = new EASkins.Ami_HeaderLabel();
            this.combType = new EASkins.Emi_ComboBox();
            this.btnReadIDCard = new EASkins.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarType
            // 
            this.txtCarType.BackColor = System.Drawing.Color.Transparent;
            this.txtCarType.Caption = "车辆类型: ";
            this.txtCarType.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCarType.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.txtCarType, new CI.UIComponents.Filler.TextEntry("cllx", ""));
            this.txtCarType.Font = new System.Drawing.Font("宋体", 12F);
            this.txtCarType.Location = new System.Drawing.Point(12, 189);
            this.txtCarType.Name = "txtCarType";
            this.txtCarType.Size = new System.Drawing.Size(237, 28);
            this.txtCarType.TabIndex = 45;
            // 
            // flatField46
            // 
            this.flatField46.BackColor = System.Drawing.Color.Transparent;
            this.flatField46.Caption = "型号:     ";
            this.flatField46.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField46.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.flatField46, new CI.UIComponents.Filler.TextEntry("clxh", ""));
            this.flatField46.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField46.Location = new System.Drawing.Point(324, 374);
            this.flatField46.Name = "flatField46";
            this.flatField46.Size = new System.Drawing.Size(237, 28);
            this.flatField46.TabIndex = 41;
            // 
            // flatField45
            // 
            this.flatField45.BackColor = System.Drawing.Color.Transparent;
            this.flatField45.Caption = "品牌:     ";
            this.flatField45.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField45.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.flatField45, new CI.UIComponents.Filler.TextEntry("clpp1", ""));
            this.flatField45.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField45.Location = new System.Drawing.Point(12, 374);
            this.flatField45.Name = "flatField45";
            this.flatField45.Size = new System.Drawing.Size(237, 28);
            this.flatField45.TabIndex = 39;
            // 
            // flatField40
            // 
            this.flatField40.BackColor = System.Drawing.Color.Transparent;
            this.flatField40.Caption = "车主/单位:";
            this.flatField40.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField40.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.flatField40, new CI.UIComponents.Filler.TextEntry("syr", ""));
            this.flatField40.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField40.Location = new System.Drawing.Point(13, 519);
            this.flatField40.Name = "flatField40";
            this.flatField40.Size = new System.Drawing.Size(548, 28);
            this.flatField40.TabIndex = 37;
            // 
            // flatField39
            // 
            this.flatField39.BackColor = System.Drawing.Color.Transparent;
            this.flatField39.Caption = "里程表读数:";
            this.flatField39.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField39.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.flatField39, new CI.UIComponents.Filler.TextEntry("lcbds", ""));
            this.flatField39.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField39.Location = new System.Drawing.Point(323, 263);
            this.flatField39.Name = "flatField39";
            this.flatField39.Size = new System.Drawing.Size(237, 28);
            this.flatField39.TabIndex = 35;
            // 
            // flatField35
            // 
            this.flatField35.BackColor = System.Drawing.Color.Transparent;
            this.flatField35.Caption = "发动机号: ";
            this.flatField35.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField35.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.flatField35, new CI.UIComponents.Filler.TextEntry("fdjh", ""));
            this.flatField35.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField35.Location = new System.Drawing.Point(12, 263);
            this.flatField35.Name = "flatField35";
            this.flatField35.Size = new System.Drawing.Size(237, 28);
            this.flatField35.TabIndex = 34;
            // 
            // flatField48
            // 
            this.flatField48.BackColor = System.Drawing.Color.Transparent;
            this.flatField48.Caption = "功率:     ";
            this.flatField48.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField48.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.flatField48, new CI.UIComponents.Filler.TextEntry("gl", ""));
            this.flatField48.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField48.Location = new System.Drawing.Point(13, 411);
            this.flatField48.Name = "flatField48";
            this.flatField48.Size = new System.Drawing.Size(237, 28);
            this.flatField48.TabIndex = 33;
            // 
            // flatField47
            // 
            this.flatField47.BackColor = System.Drawing.Color.Transparent;
            this.flatField47.Caption = "整备质量: ";
            this.flatField47.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField47.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.flatField47, new CI.UIComponents.Filler.TextEntry("zbzl", ""));
            this.flatField47.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField47.Location = new System.Drawing.Point(323, 411);
            this.flatField47.Name = "flatField47";
            this.flatField47.Size = new System.Drawing.Size(237, 28);
            this.flatField47.TabIndex = 32;
            // 
            // flatField38
            // 
            this.flatField38.BackColor = System.Drawing.Color.Transparent;
            this.flatField38.Caption = "出厂日期: ";
            this.flatField38.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField38.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.flatField38, new CI.UIComponents.Filler.TextEntry("ccrq", ""));
            this.flatField38.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField38.Location = new System.Drawing.Point(324, 226);
            this.flatField38.Name = "flatField38";
            this.flatField38.Size = new System.Drawing.Size(237, 28);
            this.flatField38.TabIndex = 31;
            // 
            // txtMakeDate
            // 
            this.txtMakeDate.BackColor = System.Drawing.Color.Transparent;
            this.txtMakeDate.Caption = "登记日期: ";
            this.txtMakeDate.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMakeDate.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.txtMakeDate, new CI.UIComponents.Filler.TextEntry("ccdjrq", ""));
            this.txtMakeDate.Font = new System.Drawing.Font("宋体", 12F);
            this.txtMakeDate.Location = new System.Drawing.Point(12, 226);
            this.txtMakeDate.Name = "txtMakeDate";
            this.txtMakeDate.Size = new System.Drawing.Size(237, 28);
            this.txtMakeDate.TabIndex = 30;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.Transparent;
            this.txtWeight.Caption = "总质量:   ";
            this.txtWeight.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWeight.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.txtWeight, new CI.UIComponents.Filler.TextEntry("zzl", ""));
            this.txtWeight.Font = new System.Drawing.Font("宋体", 12F);
            this.txtWeight.Location = new System.Drawing.Point(323, 189);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(237, 28);
            this.txtWeight.TabIndex = 29;
            // 
            // txtVIN
            // 
            this.txtVIN.BackColor = System.Drawing.Color.Transparent;
            this.txtVIN.Caption = "VIN:      ";
            this.txtVIN.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtVIN.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.txtVIN, new CI.UIComponents.Filler.TextEntry("clsbdh", ""));
            this.txtVIN.Font = new System.Drawing.Font("宋体", 12F);
            this.txtVIN.Location = new System.Drawing.Point(323, 152);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(237, 28);
            this.txtVIN.TabIndex = 28;
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.BackColor = System.Drawing.Color.Transparent;
            this.txtPlateNo.Caption = "号牌号码: ";
            this.txtPlateNo.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPlateNo.CaptionWidth = 0;
            this.carFiller.SetEntityField(this.txtPlateNo, new CI.UIComponents.Filler.TextEntry("hphm", ""));
            this.txtPlateNo.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPlateNo.Location = new System.Drawing.Point(12, 152);
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Size = new System.Drawing.Size(237, 28);
            this.txtPlateNo.TabIndex = 27;
            // 
            // picQRCode
            // 
            this.picQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picQRCode.Location = new System.Drawing.Point(577, 265);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(307, 282);
            this.picQRCode.TabIndex = 49;
            this.picQRCode.TabStop = false;
            // 
            // txtQueryVIN
            // 
            this.txtQueryVIN.Depth = 0;
            this.txtQueryVIN.Hint = "VIN";
            this.txtQueryVIN.Location = new System.Drawing.Point(103, 104);
            this.txtQueryVIN.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueryVIN.MaxLength = 32767;
            this.txtQueryVIN.MouseState = EASkins.MouseState.HOVER;
            this.txtQueryVIN.Name = "txtQueryVIN";
            this.txtQueryVIN.PasswordChar = '\0';
            this.txtQueryVIN.SelectedText = "";
            this.txtQueryVIN.SelectionLength = 0;
            this.txtQueryVIN.SelectionStart = 0;
            this.txtQueryVIN.Size = new System.Drawing.Size(198, 23);
            this.txtQueryVIN.TabIndex = 48;
            this.txtQueryVIN.TabStop = false;
            this.txtQueryVIN.UseSystemPasswordChar = false;
            // 
            // ami_HeaderLabel2
            // 
            this.ami_HeaderLabel2.AutoSize = true;
            this.ami_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ami_HeaderLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ami_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ami_HeaderLabel2.Location = new System.Drawing.Point(344, 73);
            this.ami_HeaderLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ami_HeaderLabel2.Name = "ami_HeaderLabel2";
            this.ami_HeaderLabel2.Size = new System.Drawing.Size(65, 12);
            this.ami_HeaderLabel2.TabIndex = 47;
            this.ami_HeaderLabel2.Text = "号牌种类：";
            // 
            // combQueryPlateType
            // 
            this.combQueryPlateType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combQueryPlateType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combQueryPlateType.DropDownHeight = 170;
            this.combQueryPlateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combQueryPlateType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combQueryPlateType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combQueryPlateType.FormattingEnabled = true;
            this.combQueryPlateType.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.combQueryPlateType.IntegralHeight = false;
            this.combQueryPlateType.ItemHeight = 20;
            this.combQueryPlateType.Items.AddRange(new object[] {
            "小型汽车",
            "大型汽车",
            "警用汽车",
            "使馆汽车",
            "领馆汽车",
            "境外汽车",
            "外籍汽车",
            "教练汽车",
            "试验汽车",
            "农用运输车",
            "拖拉机",
            "挂车",
            "临时入境汽车",
            "临时行驶车",
            "两、三轮摩托车",
            "轻便摩托车",
            "使馆摩托车",
            "领馆摩托车",
            "境外摩托车",
            "外籍摩托车",
            "教练摩托车",
            "试验摩托车",
            "临时入境摩托车",
            "警用摩托"});
            this.combQueryPlateType.Location = new System.Drawing.Point(419, 66);
            this.combQueryPlateType.Margin = new System.Windows.Forms.Padding(2);
            this.combQueryPlateType.MaxDropDownItems = 10;
            this.combQueryPlateType.Name = "combQueryPlateType";
            this.combQueryPlateType.Size = new System.Drawing.Size(129, 26);
            this.combQueryPlateType.StartIndex = 0;
            this.combQueryPlateType.TabIndex = 46;
            // 
            // flatField43
            // 
            this.flatField43.BackColor = System.Drawing.Color.Transparent;
            this.flatField43.Caption = "额定转速: ";
            this.flatField43.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField43.CaptionWidth = 0;
            this.flatField43.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField43.Location = new System.Drawing.Point(324, 300);
            this.flatField43.Name = "flatField43";
            this.flatField43.Size = new System.Drawing.Size(237, 28);
            this.flatField43.TabIndex = 43;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.Caption = "联系地址: ";
            this.txtAddress.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddress.CaptionWidth = 0;
            this.txtAddress.Font = new System.Drawing.Font("宋体", 12F);
            this.txtAddress.Location = new System.Drawing.Point(13, 485);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(548, 28);
            this.txtAddress.TabIndex = 42;
            // 
            // flatField44
            // 
            this.flatField44.BackColor = System.Drawing.Color.Transparent;
            this.flatField44.Caption = "排量:     ";
            this.flatField44.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField44.CaptionWidth = 0;
            this.flatField44.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField44.Location = new System.Drawing.Point(323, 337);
            this.flatField44.Name = "flatField44";
            this.flatField44.Size = new System.Drawing.Size(237, 28);
            this.flatField44.TabIndex = 40;
            // 
            // flatField42
            // 
            this.flatField42.BackColor = System.Drawing.Color.Transparent;
            this.flatField42.Caption = "发动机型号:";
            this.flatField42.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField42.CaptionWidth = 0;
            this.flatField42.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField42.Location = new System.Drawing.Point(12, 337);
            this.flatField42.Name = "flatField42";
            this.flatField42.Size = new System.Drawing.Size(237, 28);
            this.flatField42.TabIndex = 38;
            // 
            // flatField37
            // 
            this.flatField37.BackColor = System.Drawing.Color.Transparent;
            this.flatField37.Caption = "联系电话: ";
            this.flatField37.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField37.CaptionWidth = 0;
            this.flatField37.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField37.Location = new System.Drawing.Point(12, 300);
            this.flatField37.Name = "flatField37";
            this.flatField37.Size = new System.Drawing.Size(237, 28);
            this.flatField37.TabIndex = 44;
            // 
            // flatField36
            // 
            this.flatField36.BackColor = System.Drawing.Color.Transparent;
            this.flatField36.Caption = "车辆生产企业:";
            this.flatField36.CaptionFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField36.CaptionWidth = 0;
            this.flatField36.Font = new System.Drawing.Font("宋体", 12F);
            this.flatField36.Location = new System.Drawing.Point(12, 448);
            this.flatField36.Name = "flatField36";
            this.flatField36.Size = new System.Drawing.Size(457, 28);
            this.flatField36.TabIndex = 36;
            // 
            // emi_Separator1
            // 
            this.emi_Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emi_Separator1.Location = new System.Drawing.Point(2, 132);
            this.emi_Separator1.Name = "emi_Separator1";
            this.emi_Separator1.Size = new System.Drawing.Size(895, 10);
            this.emi_Separator1.TabIndex = 26;
            this.emi_Separator1.Text = "emi_Separator1";
            // 
            // txtQueryPlateNo
            // 
            this.txtQueryPlateNo.Depth = 0;
            this.txtQueryPlateNo.Hint = "号牌号码";
            this.txtQueryPlateNo.Location = new System.Drawing.Point(103, 69);
            this.txtQueryPlateNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueryPlateNo.MaxLength = 32767;
            this.txtQueryPlateNo.MouseState = EASkins.MouseState.HOVER;
            this.txtQueryPlateNo.Name = "txtQueryPlateNo";
            this.txtQueryPlateNo.PasswordChar = '\0';
            this.txtQueryPlateNo.SelectedText = "";
            this.txtQueryPlateNo.SelectionLength = 0;
            this.txtQueryPlateNo.SelectionStart = 0;
            this.txtQueryPlateNo.Size = new System.Drawing.Size(198, 23);
            this.txtQueryPlateNo.TabIndex = 24;
            this.txtQueryPlateNo.TabStop = false;
            this.txtQueryPlateNo.UseSystemPasswordChar = false;
            // 
            // combQueryAera
            // 
            this.combQueryAera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combQueryAera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combQueryAera.DropDownHeight = 100;
            this.combQueryAera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combQueryAera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combQueryAera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combQueryAera.FormattingEnabled = true;
            this.combQueryAera.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.combQueryAera.IntegralHeight = false;
            this.combQueryAera.ItemHeight = 20;
            this.combQueryAera.Items.AddRange(new object[] {
            "京",
            "",
            "辽",
            "冀",
            "津",
            "贵",
            "黑",
            "吉",
            "蒙",
            "新",
            "川",
            "云",
            "沪",
            "渝",
            "甘",
            "青",
            "陕",
            "宁",
            "豫",
            "晋",
            "皖",
            "鄂",
            "湘",
            "苏",
            "黔",
            "滇",
            "桂",
            "藏",
            "浙",
            "赣",
            "粤",
            "闽",
            "台",
            "琼",
            "港",
            "澳",
            "鲁",
            "内"});
            this.combQueryAera.Location = new System.Drawing.Point(24, 66);
            this.combQueryAera.Margin = new System.Windows.Forms.Padding(2);
            this.combQueryAera.Name = "combQueryAera";
            this.combQueryAera.Size = new System.Drawing.Size(71, 26);
            this.combQueryAera.StartIndex = 0;
            this.combQueryAera.TabIndex = 25;
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = true;
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrint.Depth = 0;
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnPrint.Icon = ((System.Drawing.Image)(resources.GetObject("btnPrint.Icon")));
            this.btnPrint.Location = new System.Drawing.Point(673, 63);
            this.btnPrint.MouseState = EASkins.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Primary = true;
            this.btnPrint.Size = new System.Drawing.Size(86, 36);
            this.btnPrint.TabIndex = 51;
            this.btnPrint.Text = "打  印";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton1.Icon")));
            this.materialRaisedButton1.Location = new System.Drawing.Point(576, 63);
            this.materialRaisedButton1.MouseState = EASkins.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(86, 36);
            this.materialRaisedButton1.TabIndex = 52;
            this.materialRaisedButton1.Text = "查  询";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ami_HeaderLabel1
            // 
            this.ami_HeaderLabel1.AutoSize = true;
            this.ami_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ami_HeaderLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ami_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ami_HeaderLabel1.Location = new System.Drawing.Point(597, 159);
            this.ami_HeaderLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ami_HeaderLabel1.Name = "ami_HeaderLabel1";
            this.ami_HeaderLabel1.Size = new System.Drawing.Size(65, 12);
            this.ami_HeaderLabel1.TabIndex = 54;
            this.ami_HeaderLabel1.Text = "业务类型：";
            // 
            // combType
            // 
            this.combType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combType.DropDownHeight = 170;
            this.combType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combType.FormattingEnabled = true;
            this.combType.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.combType.IntegralHeight = false;
            this.combType.ItemHeight = 20;
            this.combType.Items.AddRange(new object[] {
            "普通车",
            "网约车"});
            this.combType.Location = new System.Drawing.Point(673, 152);
            this.combType.Margin = new System.Windows.Forms.Padding(2);
            this.combType.MaxDropDownItems = 10;
            this.combType.Name = "combType";
            this.combType.Size = new System.Drawing.Size(129, 26);
            this.combType.StartIndex = 0;
            this.combType.TabIndex = 53;
            // 
            // btnReadIDCard
            // 
            this.btnReadIDCard.AutoSize = true;
            this.btnReadIDCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReadIDCard.Depth = 0;
            this.btnReadIDCard.Icon = ((System.Drawing.Image)(resources.GetObject("btnReadIDCard.Icon")));
            this.btnReadIDCard.Location = new System.Drawing.Point(475, 440);
            this.btnReadIDCard.MouseState = EASkins.MouseState.HOVER;
            this.btnReadIDCard.Name = "btnReadIDCard";
            this.btnReadIDCard.Primary = true;
            this.btnReadIDCard.Size = new System.Drawing.Size(86, 36);
            this.btnReadIDCard.TabIndex = 55;
            this.btnReadIDCard.Text = "读  卡";
            this.btnReadIDCard.UseVisualStyleBackColor = true;
            this.btnReadIDCard.Click += new System.EventHandler(this.btnReadIDCard_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 573);
            this.Controls.Add(this.btnReadIDCard);
            this.Controls.Add(this.ami_HeaderLabel1);
            this.Controls.Add(this.combType);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.txtQueryVIN);
            this.Controls.Add(this.ami_HeaderLabel2);
            this.Controls.Add(this.combQueryPlateType);
            this.Controls.Add(this.txtCarType);
            this.Controls.Add(this.flatField43);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.flatField46);
            this.Controls.Add(this.flatField44);
            this.Controls.Add(this.flatField45);
            this.Controls.Add(this.flatField42);
            this.Controls.Add(this.flatField37);
            this.Controls.Add(this.flatField40);
            this.Controls.Add(this.flatField36);
            this.Controls.Add(this.flatField39);
            this.Controls.Add(this.flatField35);
            this.Controls.Add(this.flatField48);
            this.Controls.Add(this.flatField47);
            this.Controls.Add(this.flatField38);
            this.Controls.Add(this.txtMakeDate);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.txtPlateNo);
            this.Controls.Add(this.emi_Separator1);
            this.Controls.Add(this.txtQueryPlateNo);
            this.Controls.Add(this.combQueryAera);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Title = "登记";
            this.Controls.SetChildIndex(this.combQueryAera, 0);
            this.Controls.SetChildIndex(this.txtQueryPlateNo, 0);
            this.Controls.SetChildIndex(this.emi_Separator1, 0);
            this.Controls.SetChildIndex(this.txtPlateNo, 0);
            this.Controls.SetChildIndex(this.txtVIN, 0);
            this.Controls.SetChildIndex(this.txtWeight, 0);
            this.Controls.SetChildIndex(this.txtMakeDate, 0);
            this.Controls.SetChildIndex(this.flatField38, 0);
            this.Controls.SetChildIndex(this.flatField47, 0);
            this.Controls.SetChildIndex(this.flatField48, 0);
            this.Controls.SetChildIndex(this.flatField35, 0);
            this.Controls.SetChildIndex(this.flatField39, 0);
            this.Controls.SetChildIndex(this.flatField36, 0);
            this.Controls.SetChildIndex(this.flatField40, 0);
            this.Controls.SetChildIndex(this.flatField37, 0);
            this.Controls.SetChildIndex(this.flatField42, 0);
            this.Controls.SetChildIndex(this.flatField45, 0);
            this.Controls.SetChildIndex(this.flatField44, 0);
            this.Controls.SetChildIndex(this.flatField46, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.flatField43, 0);
            this.Controls.SetChildIndex(this.txtCarType, 0);
            this.Controls.SetChildIndex(this.combQueryPlateType, 0);
            this.Controls.SetChildIndex(this.ami_HeaderLabel2, 0);
            this.Controls.SetChildIndex(this.txtQueryVIN, 0);
            this.Controls.SetChildIndex(this.picQRCode, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.materialRaisedButton1, 0);
            this.Controls.SetChildIndex(this.combType, 0);
            this.Controls.SetChildIndex(this.ami_HeaderLabel1, 0);
            this.Controls.SetChildIndex(this.btnReadIDCard, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CI.UIComponents.Filler.EntityFiller carFiller;
        private System.Windows.Forms.PictureBox picQRCode;
        private EASkins.Controls.MaterialSingleLineTextField txtQueryVIN;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel2;
        private EASkins.Emi_ComboBox combQueryPlateType;
        private CI.Controls.FlatField txtCarType;
        private CI.Controls.FlatField flatField43;
        private CI.Controls.FlatField txtAddress;
        private CI.Controls.FlatField flatField46;
        private CI.Controls.FlatField flatField44;
        private CI.Controls.FlatField flatField45;
        private CI.Controls.FlatField flatField42;
        private CI.Controls.FlatField flatField37;
        private CI.Controls.FlatField flatField40;
        private CI.Controls.FlatField flatField36;
        private CI.Controls.FlatField flatField39;
        private CI.Controls.FlatField flatField35;
        private CI.Controls.FlatField flatField48;
        private CI.Controls.FlatField flatField47;
        private CI.Controls.FlatField flatField38;
        private CI.Controls.FlatField txtMakeDate;
        private CI.Controls.FlatField txtWeight;
        private CI.Controls.FlatField txtVIN;
        private CI.Controls.FlatField txtPlateNo;
        private EASkins.Emi_Separator emi_Separator1;
        private EASkins.Controls.MaterialSingleLineTextField txtQueryPlateNo;
        private EASkins.Emi_ComboBox combQueryAera;
        private EASkins.Controls.MaterialRaisedButton btnPrint;
        private EASkins.Controls.MaterialRaisedButton materialRaisedButton1;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel1;
        private EASkins.Emi_ComboBox combType;
        private EASkins.Controls.MaterialRaisedButton btnReadIDCard;
    }
}