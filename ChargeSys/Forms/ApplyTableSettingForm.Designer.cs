namespace ChargeSys.Main.Forms
{
    partial class ApplyTableSettingForm
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
            this.pointFiller = new CI.UIComponents.Filler.EntityFiller();
            this.flatField34 = new CI.Controls.FlatField();
            this.flatField9 = new CI.Controls.FlatField();
            this.flatField33 = new CI.Controls.FlatField();
            this.flatField10 = new CI.Controls.FlatField();
            this.flatField7 = new CI.Controls.FlatField();
            this.flatField8 = new CI.Controls.FlatField();
            this.flatField6 = new CI.Controls.FlatField();
            this.flatField5 = new CI.Controls.FlatField();
            this.pointValidator = new CI.UIComponents.Validate.Validator();
            this.btnSavePoint = new EASkins.Ami_Button_1();
            this.flatField2 = new CI.Controls.FlatField();
            this.flatField4 = new CI.Controls.FlatField();
            this.flatField13 = new CI.Controls.FlatField();
            this.flatField14 = new CI.Controls.FlatField();
            this.flatField1 = new CI.Controls.FlatField();
            this.flatField3 = new CI.Controls.FlatField();
            this.flatField11 = new CI.Controls.FlatField();
            this.flatField12 = new CI.Controls.FlatField();
            this.flatField15 = new CI.Controls.FlatField();
            this.flatField16 = new CI.Controls.FlatField();
            this.flatField17 = new CI.Controls.FlatField();
            this.flatField18 = new CI.Controls.FlatField();
            this.flatField19 = new CI.Controls.FlatField();
            this.flatField20 = new CI.Controls.FlatField();
            this.flatField21 = new CI.Controls.FlatField();
            this.flatField22 = new CI.Controls.FlatField();
            this.flatField23 = new CI.Controls.FlatField();
            this.flatField24 = new CI.Controls.FlatField();
            this.flatField25 = new CI.Controls.FlatField();
            this.flatField26 = new CI.Controls.FlatField();
            this.flatField27 = new CI.Controls.FlatField();
            this.flatField28 = new CI.Controls.FlatField();
            this.SuspendLayout();
            // 
            // flatField34
            // 
            this.flatField34.BackColor = System.Drawing.Color.Transparent;
            this.flatField34.Caption = "Y_电话    ";
            this.flatField34.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField34.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField34, new CI.UIComponents.Filler.TextEntry("Y_Tel", ""));
            this.flatField34.Location = new System.Drawing.Point(449, 191);
            this.flatField34.Name = "flatField34";
            this.flatField34.Size = new System.Drawing.Size(237, 25);
            this.flatField34.TabIndex = 36;
            // 
            // flatField9
            // 
            this.flatField9.BackColor = System.Drawing.Color.Transparent;
            this.flatField9.Caption = "Y_手机    ";
            this.flatField9.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField9.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField9, new CI.UIComponents.Filler.TextEntry("Y_MobilePhone", ""));
            this.flatField9.Location = new System.Drawing.Point(449, 157);
            this.flatField9.Name = "flatField9";
            this.flatField9.Size = new System.Drawing.Size(237, 25);
            this.flatField9.TabIndex = 35;
            this.pointValidator.SetTaget(this.flatField9, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField33
            // 
            this.flatField33.BackColor = System.Drawing.Color.Transparent;
            this.flatField33.Caption = "X_电话    ";
            this.flatField33.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField33.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField33, new CI.UIComponents.Filler.TextEntry("X_Tel", ""));
            this.flatField33.Location = new System.Drawing.Point(184, 191);
            this.flatField33.Name = "flatField33";
            this.flatField33.Size = new System.Drawing.Size(237, 25);
            this.flatField33.TabIndex = 34;
            // 
            // flatField10
            // 
            this.flatField10.BackColor = System.Drawing.Color.Transparent;
            this.flatField10.Caption = "X_手机    ";
            this.flatField10.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField10.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField10, new CI.UIComponents.Filler.TextEntry("X_MobilePhone", ""));
            this.flatField10.Location = new System.Drawing.Point(184, 157);
            this.flatField10.Name = "flatField10";
            this.flatField10.Size = new System.Drawing.Size(237, 25);
            this.flatField10.TabIndex = 33;
            this.pointValidator.SetTaget(this.flatField10, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField7
            // 
            this.flatField7.BackColor = System.Drawing.Color.Transparent;
            this.flatField7.Caption = "Y_地址    ";
            this.flatField7.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField7.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField7, new CI.UIComponents.Filler.TextEntry("Y_Addr", ""));
            this.flatField7.Location = new System.Drawing.Point(449, 123);
            this.flatField7.Name = "flatField7";
            this.flatField7.Size = new System.Drawing.Size(237, 25);
            this.flatField7.TabIndex = 32;
            this.pointValidator.SetTaget(this.flatField7, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField8
            // 
            this.flatField8.BackColor = System.Drawing.Color.Transparent;
            this.flatField8.Caption = "X_地址    ";
            this.flatField8.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField8.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField8, new CI.UIComponents.Filler.TextEntry("X_Addr", ""));
            this.flatField8.Location = new System.Drawing.Point(184, 123);
            this.flatField8.Name = "flatField8";
            this.flatField8.Size = new System.Drawing.Size(237, 25);
            this.flatField8.TabIndex = 31;
            this.pointValidator.SetTaget(this.flatField8, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField6
            // 
            this.flatField6.BackColor = System.Drawing.Color.Transparent;
            this.flatField6.Caption = "Y_姓名    ";
            this.flatField6.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField6.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField6, new CI.UIComponents.Filler.TextEntry("Y_Owner", ""));
            this.flatField6.Location = new System.Drawing.Point(449, 89);
            this.flatField6.Name = "flatField6";
            this.flatField6.Size = new System.Drawing.Size(237, 25);
            this.flatField6.TabIndex = 30;
            this.pointValidator.SetTaget(this.flatField6, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField5
            // 
            this.flatField5.BackColor = System.Drawing.Color.Transparent;
            this.flatField5.Caption = "X_ 姓名   ";
            this.flatField5.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField5.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField5, new CI.UIComponents.Filler.TextEntry("X_Owner", ""));
            this.flatField5.Location = new System.Drawing.Point(184, 89);
            this.flatField5.Name = "flatField5";
            this.flatField5.Size = new System.Drawing.Size(237, 25);
            this.flatField5.TabIndex = 29;
            this.pointValidator.SetTaget(this.flatField5, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // btnSavePoint
            // 
            this.btnSavePoint.BackColor = System.Drawing.Color.Transparent;
            this.btnSavePoint.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSavePoint.Image = null;
            this.btnSavePoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePoint.Location = new System.Drawing.Point(580, 566);
            this.btnSavePoint.Name = "btnSavePoint";
            this.btnSavePoint.Size = new System.Drawing.Size(106, 30);
            this.btnSavePoint.TabIndex = 59;
            this.btnSavePoint.Text = "保 存";
            this.btnSavePoint.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSavePoint.Click += new System.EventHandler(this.btnSavePoint_Click);
            // 
            // flatField2
            // 
            this.flatField2.BackColor = System.Drawing.Color.Transparent;
            this.flatField2.Caption = "Y_代理人手机";
            this.flatField2.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField2.CaptionWidth = 0;
            this.flatField2.Location = new System.Drawing.Point(449, 253);
            this.flatField2.Name = "flatField2";
            this.flatField2.Size = new System.Drawing.Size(237, 25);
            this.flatField2.TabIndex = 66;
            this.pointValidator.SetTaget(this.flatField2, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField4
            // 
            this.flatField4.BackColor = System.Drawing.Color.Transparent;
            this.flatField4.Caption = "X_代理人手机";
            this.flatField4.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField4.CaptionWidth = 0;
            this.flatField4.Location = new System.Drawing.Point(184, 253);
            this.flatField4.Name = "flatField4";
            this.flatField4.Size = new System.Drawing.Size(237, 25);
            this.flatField4.TabIndex = 64;
            this.pointValidator.SetTaget(this.flatField4, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField13
            // 
            this.flatField13.BackColor = System.Drawing.Color.Transparent;
            this.flatField13.Caption = "Y_代理人姓名";
            this.flatField13.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField13.CaptionWidth = 0;
            this.flatField13.Location = new System.Drawing.Point(449, 222);
            this.flatField13.Name = "flatField13";
            this.flatField13.Size = new System.Drawing.Size(237, 25);
            this.flatField13.TabIndex = 61;
            this.pointValidator.SetTaget(this.flatField13, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField14
            // 
            this.flatField14.BackColor = System.Drawing.Color.Transparent;
            this.flatField14.Caption = "X_ 代理人姓名";
            this.flatField14.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField14.CaptionWidth = 0;
            this.flatField14.Location = new System.Drawing.Point(184, 222);
            this.flatField14.Name = "flatField14";
            this.flatField14.Size = new System.Drawing.Size(237, 25);
            this.flatField14.TabIndex = 60;
            this.pointValidator.SetTaget(this.flatField14, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField1
            // 
            this.flatField1.BackColor = System.Drawing.Color.Transparent;
            this.flatField1.Caption = "Y_号牌号码";
            this.flatField1.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField1.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField1, new CI.UIComponents.Filler.TextEntry("Y_PlateNo", ""));
            this.flatField1.Location = new System.Drawing.Point(449, 315);
            this.flatField1.Name = "flatField1";
            this.flatField1.Size = new System.Drawing.Size(237, 25);
            this.flatField1.TabIndex = 70;
            this.pointValidator.SetTaget(this.flatField1, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField3
            // 
            this.flatField3.BackColor = System.Drawing.Color.Transparent;
            this.flatField3.Caption = "X_号牌号码";
            this.flatField3.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField3.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField3, new CI.UIComponents.Filler.TextEntry("X_PlateNo", ""));
            this.flatField3.Location = new System.Drawing.Point(184, 315);
            this.flatField3.Name = "flatField3";
            this.flatField3.Size = new System.Drawing.Size(237, 25);
            this.flatField3.TabIndex = 69;
            this.pointValidator.SetTaget(this.flatField3, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField11
            // 
            this.flatField11.BackColor = System.Drawing.Color.Transparent;
            this.flatField11.Caption = "Y_号牌种类";
            this.flatField11.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField11.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField11, new CI.UIComponents.Filler.TextEntry("Y_PlateType", ""));
            this.flatField11.Location = new System.Drawing.Point(449, 284);
            this.flatField11.Name = "flatField11";
            this.flatField11.Size = new System.Drawing.Size(237, 25);
            this.flatField11.TabIndex = 68;
            this.pointValidator.SetTaget(this.flatField11, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField12
            // 
            this.flatField12.BackColor = System.Drawing.Color.Transparent;
            this.flatField12.Caption = "X_ 号牌种类";
            this.flatField12.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField12.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField12, new CI.UIComponents.Filler.TextEntry("X_PlateType", ""));
            this.flatField12.Location = new System.Drawing.Point(184, 284);
            this.flatField12.Name = "flatField12";
            this.flatField12.Size = new System.Drawing.Size(237, 25);
            this.flatField12.TabIndex = 67;
            this.pointValidator.SetTaget(this.flatField12, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField15
            // 
            this.flatField15.BackColor = System.Drawing.Color.Transparent;
            this.flatField15.Caption = "Y_日      ";
            this.flatField15.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField15.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField15, new CI.UIComponents.Filler.TextEntry("Y_Day", ""));
            this.flatField15.Location = new System.Drawing.Point(449, 414);
            this.flatField15.Name = "flatField15";
            this.flatField15.Size = new System.Drawing.Size(237, 25);
            this.flatField15.TabIndex = 76;
            this.pointValidator.SetTaget(this.flatField15, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField16
            // 
            this.flatField16.BackColor = System.Drawing.Color.Transparent;
            this.flatField16.Caption = "X_日      ";
            this.flatField16.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField16.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField16, new CI.UIComponents.Filler.TextEntry("X_Day", ""));
            this.flatField16.Location = new System.Drawing.Point(184, 414);
            this.flatField16.Name = "flatField16";
            this.flatField16.Size = new System.Drawing.Size(237, 25);
            this.flatField16.TabIndex = 75;
            this.pointValidator.SetTaget(this.flatField16, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField17
            // 
            this.flatField17.BackColor = System.Drawing.Color.Transparent;
            this.flatField17.Caption = "Y_月      ";
            this.flatField17.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField17.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField17, new CI.UIComponents.Filler.TextEntry("Y_Month", ""));
            this.flatField17.Location = new System.Drawing.Point(449, 380);
            this.flatField17.Name = "flatField17";
            this.flatField17.Size = new System.Drawing.Size(237, 25);
            this.flatField17.TabIndex = 74;
            this.pointValidator.SetTaget(this.flatField17, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField18
            // 
            this.flatField18.BackColor = System.Drawing.Color.Transparent;
            this.flatField18.Caption = "X_月      ";
            this.flatField18.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField18.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField18, new CI.UIComponents.Filler.TextEntry("X_Month", ""));
            this.flatField18.Location = new System.Drawing.Point(184, 380);
            this.flatField18.Name = "flatField18";
            this.flatField18.Size = new System.Drawing.Size(237, 25);
            this.flatField18.TabIndex = 73;
            this.pointValidator.SetTaget(this.flatField18, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField19
            // 
            this.flatField19.BackColor = System.Drawing.Color.Transparent;
            this.flatField19.Caption = "Y_年      ";
            this.flatField19.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField19.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField19, new CI.UIComponents.Filler.TextEntry("Y_Year", ""));
            this.flatField19.Location = new System.Drawing.Point(449, 346);
            this.flatField19.Name = "flatField19";
            this.flatField19.Size = new System.Drawing.Size(237, 25);
            this.flatField19.TabIndex = 72;
            this.pointValidator.SetTaget(this.flatField19, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField20
            // 
            this.flatField20.BackColor = System.Drawing.Color.Transparent;
            this.flatField20.Caption = "X_年      ";
            this.flatField20.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField20.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField20, new CI.UIComponents.Filler.TextEntry("X_Year", ""));
            this.flatField20.Location = new System.Drawing.Point(184, 346);
            this.flatField20.Name = "flatField20";
            this.flatField20.Size = new System.Drawing.Size(237, 25);
            this.flatField20.TabIndex = 71;
            this.pointValidator.SetTaget(this.flatField20, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField21
            // 
            this.flatField21.BackColor = System.Drawing.Color.Transparent;
            this.flatField21.Caption = "Y_申请类型";
            this.flatField21.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField21.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField21, new CI.UIComponents.Filler.TextEntry("Y_Apply", ""));
            this.flatField21.Location = new System.Drawing.Point(449, 445);
            this.flatField21.Name = "flatField21";
            this.flatField21.Size = new System.Drawing.Size(237, 25);
            this.flatField21.TabIndex = 78;
            this.pointValidator.SetTaget(this.flatField21, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField22
            // 
            this.flatField22.BackColor = System.Drawing.Color.Transparent;
            this.flatField22.Caption = "X_申请类型";
            this.flatField22.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField22.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField22, new CI.UIComponents.Filler.TextEntry("X_Apply", ""));
            this.flatField22.Location = new System.Drawing.Point(184, 445);
            this.flatField22.Name = "flatField22";
            this.flatField22.Size = new System.Drawing.Size(237, 25);
            this.flatField22.TabIndex = 77;
            this.pointValidator.SetTaget(this.flatField22, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField23
            // 
            this.flatField23.BackColor = System.Drawing.Color.Transparent;
            this.flatField23.Caption = "Y_票号    ";
            this.flatField23.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField23.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField23, new CI.UIComponents.Filler.TextEntry("Y_Ticket", ""));
            this.flatField23.Location = new System.Drawing.Point(449, 503);
            this.flatField23.Name = "flatField23";
            this.flatField23.Size = new System.Drawing.Size(237, 25);
            this.flatField23.TabIndex = 80;
            this.pointValidator.SetTaget(this.flatField23, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField24
            // 
            this.flatField24.BackColor = System.Drawing.Color.Transparent;
            this.flatField24.Caption = "X_票号    ";
            this.flatField24.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField24.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField24, new CI.UIComponents.Filler.TextEntry("X_Ticket", ""));
            this.flatField24.Location = new System.Drawing.Point(184, 503);
            this.flatField24.Name = "flatField24";
            this.flatField24.Size = new System.Drawing.Size(237, 25);
            this.flatField24.TabIndex = 79;
            this.pointValidator.SetTaget(this.flatField24, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField25
            // 
            this.flatField25.BackColor = System.Drawing.Color.Transparent;
            this.flatField25.Caption = "Y_申请类型(外地)";
            this.flatField25.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField25.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField25, new CI.UIComponents.Filler.TextEntry("Y_Apply1", ""));
            this.flatField25.Location = new System.Drawing.Point(449, 476);
            this.flatField25.Name = "flatField25";
            this.flatField25.Size = new System.Drawing.Size(237, 25);
            this.flatField25.TabIndex = 82;
            this.pointValidator.SetTaget(this.flatField25, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField26
            // 
            this.flatField26.BackColor = System.Drawing.Color.Transparent;
            this.flatField26.Caption = "X_申请类型(外地)";
            this.flatField26.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField26.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField26, new CI.UIComponents.Filler.TextEntry("X_Apply1", ""));
            this.flatField26.Location = new System.Drawing.Point(184, 476);
            this.flatField26.Name = "flatField26";
            this.flatField26.Size = new System.Drawing.Size(237, 25);
            this.flatField26.TabIndex = 81;
            this.pointValidator.SetTaget(this.flatField26, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField27
            // 
            this.flatField27.BackColor = System.Drawing.Color.Transparent;
            this.flatField27.Caption = "Y_邮编    ";
            this.flatField27.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField27.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField27, new CI.UIComponents.Filler.TextEntry("Y_Post", ""));
            this.flatField27.Location = new System.Drawing.Point(449, 534);
            this.flatField27.Name = "flatField27";
            this.flatField27.Size = new System.Drawing.Size(237, 25);
            this.flatField27.TabIndex = 84;
            this.pointValidator.SetTaget(this.flatField27, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField28
            // 
            this.flatField28.BackColor = System.Drawing.Color.Transparent;
            this.flatField28.Caption = "X_邮编    ";
            this.flatField28.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField28.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField28, new CI.UIComponents.Filler.TextEntry("X_Post", ""));
            this.flatField28.Location = new System.Drawing.Point(184, 534);
            this.flatField28.Name = "flatField28";
            this.flatField28.Size = new System.Drawing.Size(237, 25);
            this.flatField28.TabIndex = 83;
            this.pointValidator.SetTaget(this.flatField28, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // ApplyTableSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 692);
            this.Controls.Add(this.flatField27);
            this.Controls.Add(this.flatField28);
            this.Controls.Add(this.flatField25);
            this.Controls.Add(this.flatField26);
            this.Controls.Add(this.flatField23);
            this.Controls.Add(this.flatField24);
            this.Controls.Add(this.flatField21);
            this.Controls.Add(this.flatField22);
            this.Controls.Add(this.flatField15);
            this.Controls.Add(this.flatField16);
            this.Controls.Add(this.flatField17);
            this.Controls.Add(this.flatField18);
            this.Controls.Add(this.flatField19);
            this.Controls.Add(this.flatField20);
            this.Controls.Add(this.flatField1);
            this.Controls.Add(this.flatField3);
            this.Controls.Add(this.flatField11);
            this.Controls.Add(this.flatField12);
            this.Controls.Add(this.flatField2);
            this.Controls.Add(this.flatField4);
            this.Controls.Add(this.flatField13);
            this.Controls.Add(this.flatField14);
            this.Controls.Add(this.btnSavePoint);
            this.Controls.Add(this.flatField34);
            this.Controls.Add(this.flatField9);
            this.Controls.Add(this.flatField33);
            this.Controls.Add(this.flatField10);
            this.Controls.Add(this.flatField7);
            this.Controls.Add(this.flatField8);
            this.Controls.Add(this.flatField6);
            this.Controls.Add(this.flatField5);
            this.Name = "ApplyTableSettingForm";
            this.Text = "PrintSettingForm";
            this.Title = "申请表打印配置";
            this.Controls.SetChildIndex(this.flatField5, 0);
            this.Controls.SetChildIndex(this.flatField6, 0);
            this.Controls.SetChildIndex(this.flatField8, 0);
            this.Controls.SetChildIndex(this.flatField7, 0);
            this.Controls.SetChildIndex(this.flatField10, 0);
            this.Controls.SetChildIndex(this.flatField33, 0);
            this.Controls.SetChildIndex(this.flatField9, 0);
            this.Controls.SetChildIndex(this.flatField34, 0);
            this.Controls.SetChildIndex(this.btnSavePoint, 0);
            this.Controls.SetChildIndex(this.flatField14, 0);
            this.Controls.SetChildIndex(this.flatField13, 0);
            this.Controls.SetChildIndex(this.flatField4, 0);
            this.Controls.SetChildIndex(this.flatField2, 0);
            this.Controls.SetChildIndex(this.flatField12, 0);
            this.Controls.SetChildIndex(this.flatField11, 0);
            this.Controls.SetChildIndex(this.flatField3, 0);
            this.Controls.SetChildIndex(this.flatField1, 0);
            this.Controls.SetChildIndex(this.flatField20, 0);
            this.Controls.SetChildIndex(this.flatField19, 0);
            this.Controls.SetChildIndex(this.flatField18, 0);
            this.Controls.SetChildIndex(this.flatField17, 0);
            this.Controls.SetChildIndex(this.flatField16, 0);
            this.Controls.SetChildIndex(this.flatField15, 0);
            this.Controls.SetChildIndex(this.flatField22, 0);
            this.Controls.SetChildIndex(this.flatField21, 0);
            this.Controls.SetChildIndex(this.flatField24, 0);
            this.Controls.SetChildIndex(this.flatField23, 0);
            this.Controls.SetChildIndex(this.flatField26, 0);
            this.Controls.SetChildIndex(this.flatField25, 0);
            this.Controls.SetChildIndex(this.flatField28, 0);
            this.Controls.SetChildIndex(this.flatField27, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private CI.UIComponents.Filler.EntityFiller pointFiller;
        private CI.UIComponents.Validate.Validator pointValidator;
        private EASkins.Ami_Button_1 btnSavePoint;
        private CI.Controls.FlatField flatField34;
        private CI.Controls.FlatField flatField9;
        private CI.Controls.FlatField flatField33;
        private CI.Controls.FlatField flatField10;
        private CI.Controls.FlatField flatField7;
        private CI.Controls.FlatField flatField8;
        private CI.Controls.FlatField flatField6;
        private CI.Controls.FlatField flatField5;
        private CI.Controls.FlatField flatField2;
        private CI.Controls.FlatField flatField4;
        private CI.Controls.FlatField flatField13;
        private CI.Controls.FlatField flatField14;
        private CI.Controls.FlatField flatField1;
        private CI.Controls.FlatField flatField3;
        private CI.Controls.FlatField flatField11;
        private CI.Controls.FlatField flatField12;
        private CI.Controls.FlatField flatField15;
        private CI.Controls.FlatField flatField16;
        private CI.Controls.FlatField flatField17;
        private CI.Controls.FlatField flatField18;
        private CI.Controls.FlatField flatField19;
        private CI.Controls.FlatField flatField20;
        private CI.Controls.FlatField flatField21;
        private CI.Controls.FlatField flatField22;
        private CI.Controls.FlatField flatField23;
        private CI.Controls.FlatField flatField24;
        private CI.Controls.FlatField flatField25;
        private CI.Controls.FlatField flatField26;
        private CI.Controls.FlatField flatField27;
        private CI.Controls.FlatField flatField28;
    }
}