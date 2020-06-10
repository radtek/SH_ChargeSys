namespace ChargeSys.Main.Forms
{
    partial class PrintSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintSettingForm));
            this.pointFiller = new CI.UIComponents.Filler.EntityFiller();
            this.flatField32 = new CI.Controls.FlatField();
            this.flatField31 = new CI.Controls.FlatField();
            this.flatField30 = new CI.Controls.FlatField();
            this.flatField29 = new CI.Controls.FlatField();
            this.flatField27 = new CI.Controls.FlatField();
            this.flatField28 = new CI.Controls.FlatField();
            this.flatField25 = new CI.Controls.FlatField();
            this.flatField26 = new CI.Controls.FlatField();
            this.flatField23 = new CI.Controls.FlatField();
            this.flatField24 = new CI.Controls.FlatField();
            this.flatField21 = new CI.Controls.FlatField();
            this.flatField22 = new CI.Controls.FlatField();
            this.flatField19 = new CI.Controls.FlatField();
            this.flatField20 = new CI.Controls.FlatField();
            this.flatField17 = new CI.Controls.FlatField();
            this.flatField18 = new CI.Controls.FlatField();
            this.flatField15 = new CI.Controls.FlatField();
            this.flatField16 = new CI.Controls.FlatField();
            this.flatField13 = new CI.Controls.FlatField();
            this.flatField14 = new CI.Controls.FlatField();
            this.flatField11 = new CI.Controls.FlatField();
            this.flatField12 = new CI.Controls.FlatField();
            this.flatField34 = new CI.Controls.FlatField();
            this.flatField9 = new CI.Controls.FlatField();
            this.flatField33 = new CI.Controls.FlatField();
            this.flatField10 = new CI.Controls.FlatField();
            this.flatField7 = new CI.Controls.FlatField();
            this.flatField8 = new CI.Controls.FlatField();
            this.flatField6 = new CI.Controls.FlatField();
            this.flatField5 = new CI.Controls.FlatField();
            this.pointValidator = new CI.UIComponents.Validate.Validator();
            this.btnSave = new EASkins.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // flatField32
            // 
            this.flatField32.BackColor = System.Drawing.Color.Transparent;
            this.flatField32.Caption = "X_二维码  ";
            this.flatField32.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField32.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField32, new CI.UIComponents.Filler.TextEntry("Y_QRCode", ""));
            this.flatField32.Location = new System.Drawing.Point(306, 556);
            this.flatField32.Name = "flatField32";
            this.flatField32.Size = new System.Drawing.Size(237, 25);
            this.flatField32.TabIndex = 58;
            this.pointValidator.SetTaget(this.flatField32, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField31
            // 
            this.flatField31.BackColor = System.Drawing.Color.Transparent;
            this.flatField31.Caption = "X_二维码  ";
            this.flatField31.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField31.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField31, new CI.UIComponents.Filler.TextEntry("X_QRCode", ""));
            this.flatField31.Location = new System.Drawing.Point(41, 556);
            this.flatField31.Name = "flatField31";
            this.flatField31.Size = new System.Drawing.Size(237, 25);
            this.flatField31.TabIndex = 57;
            this.pointValidator.SetTaget(this.flatField31, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField30
            // 
            this.flatField30.BackColor = System.Drawing.Color.Transparent;
            this.flatField30.Caption = "X_整备质量";
            this.flatField30.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField30.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField30, new CI.UIComponents.Filler.TextEntry("Y_KerbWeight", ""));
            this.flatField30.Location = new System.Drawing.Point(306, 522);
            this.flatField30.Name = "flatField30";
            this.flatField30.Size = new System.Drawing.Size(237, 25);
            this.flatField30.TabIndex = 56;
            this.pointValidator.SetTaget(this.flatField30, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField29
            // 
            this.flatField29.BackColor = System.Drawing.Color.Transparent;
            this.flatField29.Caption = "X_整备质量";
            this.flatField29.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField29.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField29, new CI.UIComponents.Filler.TextEntry("X_KerbWeight", ""));
            this.flatField29.Location = new System.Drawing.Point(41, 522);
            this.flatField29.Name = "flatField29";
            this.flatField29.Size = new System.Drawing.Size(237, 25);
            this.flatField29.TabIndex = 55;
            this.pointValidator.SetTaget(this.flatField29, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField27
            // 
            this.flatField27.BackColor = System.Drawing.Color.Transparent;
            this.flatField27.Caption = "Y_总质量  ";
            this.flatField27.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField27.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField27, new CI.UIComponents.Filler.TextEntry("Y_Weight", ""));
            this.flatField27.Location = new System.Drawing.Point(306, 488);
            this.flatField27.Name = "flatField27";
            this.flatField27.Size = new System.Drawing.Size(237, 25);
            this.flatField27.TabIndex = 54;
            this.pointValidator.SetTaget(this.flatField27, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField28
            // 
            this.flatField28.BackColor = System.Drawing.Color.Transparent;
            this.flatField28.Caption = "X_总质量  ";
            this.flatField28.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField28.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField28, new CI.UIComponents.Filler.TextEntry("X_Weight", ""));
            this.flatField28.Location = new System.Drawing.Point(41, 488);
            this.flatField28.Name = "flatField28";
            this.flatField28.Size = new System.Drawing.Size(237, 25);
            this.flatField28.TabIndex = 53;
            this.pointValidator.SetTaget(this.flatField28, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField25
            // 
            this.flatField25.BackColor = System.Drawing.Color.Transparent;
            this.flatField25.Caption = "Y_出厂日期";
            this.flatField25.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField25.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField25, new CI.UIComponents.Filler.TextEntry("Y_MakeDate", ""));
            this.flatField25.Location = new System.Drawing.Point(306, 454);
            this.flatField25.Name = "flatField25";
            this.flatField25.Size = new System.Drawing.Size(237, 25);
            this.flatField25.TabIndex = 52;
            this.pointValidator.SetTaget(this.flatField25, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField26
            // 
            this.flatField26.BackColor = System.Drawing.Color.Transparent;
            this.flatField26.Caption = "X_出厂日期";
            this.flatField26.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField26.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField26, new CI.UIComponents.Filler.TextEntry("X_MakeDate", ""));
            this.flatField26.Location = new System.Drawing.Point(41, 454);
            this.flatField26.Name = "flatField26";
            this.flatField26.Size = new System.Drawing.Size(237, 25);
            this.flatField26.TabIndex = 51;
            this.pointValidator.SetTaget(this.flatField26, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField23
            // 
            this.flatField23.BackColor = System.Drawing.Color.Transparent;
            this.flatField23.Caption = "Y_初登记期";
            this.flatField23.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField23.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField23, new CI.UIComponents.Filler.TextEntry("Y_RegisterDate", ""));
            this.flatField23.Location = new System.Drawing.Point(306, 420);
            this.flatField23.Name = "flatField23";
            this.flatField23.Size = new System.Drawing.Size(237, 25);
            this.flatField23.TabIndex = 50;
            this.pointValidator.SetTaget(this.flatField23, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField24
            // 
            this.flatField24.BackColor = System.Drawing.Color.Transparent;
            this.flatField24.Caption = "X_初登记期";
            this.flatField24.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField24.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField24, new CI.UIComponents.Filler.TextEntry("X_RegisterDate", ""));
            this.flatField24.Location = new System.Drawing.Point(41, 420);
            this.flatField24.Name = "flatField24";
            this.flatField24.Size = new System.Drawing.Size(237, 25);
            this.flatField24.TabIndex = 49;
            this.pointValidator.SetTaget(this.flatField24, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField21
            // 
            this.flatField21.BackColor = System.Drawing.Color.Transparent;
            this.flatField21.Caption = "Y_型号    ";
            this.flatField21.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField21.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField21, new CI.UIComponents.Filler.TextEntry("Y_CarMold", ""));
            this.flatField21.Location = new System.Drawing.Point(306, 386);
            this.flatField21.Name = "flatField21";
            this.flatField21.Size = new System.Drawing.Size(237, 25);
            this.flatField21.TabIndex = 48;
            this.pointValidator.SetTaget(this.flatField21, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField22
            // 
            this.flatField22.BackColor = System.Drawing.Color.Transparent;
            this.flatField22.Caption = "X_型号    ";
            this.flatField22.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField22.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField22, new CI.UIComponents.Filler.TextEntry("X_CarMold", ""));
            this.flatField22.Location = new System.Drawing.Point(41, 386);
            this.flatField22.Name = "flatField22";
            this.flatField22.Size = new System.Drawing.Size(237, 25);
            this.flatField22.TabIndex = 47;
            this.pointValidator.SetTaget(this.flatField22, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField19
            // 
            this.flatField19.BackColor = System.Drawing.Color.Transparent;
            this.flatField19.Caption = "Y_品牌    ";
            this.flatField19.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField19.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField19, new CI.UIComponents.Filler.TextEntry("Y_CarBrand", ""));
            this.flatField19.Location = new System.Drawing.Point(306, 352);
            this.flatField19.Name = "flatField19";
            this.flatField19.Size = new System.Drawing.Size(237, 25);
            this.flatField19.TabIndex = 46;
            this.pointValidator.SetTaget(this.flatField19, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField20
            // 
            this.flatField20.BackColor = System.Drawing.Color.Transparent;
            this.flatField20.Caption = "X_品牌    ";
            this.flatField20.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField20.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField20, new CI.UIComponents.Filler.TextEntry("X_CarBrand", ""));
            this.flatField20.Location = new System.Drawing.Point(41, 352);
            this.flatField20.Name = "flatField20";
            this.flatField20.Size = new System.Drawing.Size(237, 25);
            this.flatField20.TabIndex = 45;
            this.pointValidator.SetTaget(this.flatField20, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField17
            // 
            this.flatField17.BackColor = System.Drawing.Color.Transparent;
            this.flatField17.Caption = "Y_车辆类型";
            this.flatField17.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField17.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField17, new CI.UIComponents.Filler.TextEntry("Y_CarType", ""));
            this.flatField17.Location = new System.Drawing.Point(306, 318);
            this.flatField17.Name = "flatField17";
            this.flatField17.Size = new System.Drawing.Size(237, 25);
            this.flatField17.TabIndex = 44;
            this.pointValidator.SetTaget(this.flatField17, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField18
            // 
            this.flatField18.BackColor = System.Drawing.Color.Transparent;
            this.flatField18.Caption = "X_车辆类型";
            this.flatField18.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField18.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField18, new CI.UIComponents.Filler.TextEntry("X_CarType", ""));
            this.flatField18.Location = new System.Drawing.Point(41, 318);
            this.flatField18.Name = "flatField18";
            this.flatField18.Size = new System.Drawing.Size(237, 25);
            this.flatField18.TabIndex = 43;
            this.pointValidator.SetTaget(this.flatField18, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField15
            // 
            this.flatField15.BackColor = System.Drawing.Color.Transparent;
            this.flatField15.Caption = "Y_颜色    ";
            this.flatField15.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField15.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField15, new CI.UIComponents.Filler.TextEntry("Y_PlateColor", ""));
            this.flatField15.Location = new System.Drawing.Point(306, 284);
            this.flatField15.Name = "flatField15";
            this.flatField15.Size = new System.Drawing.Size(237, 25);
            this.flatField15.TabIndex = 42;
            this.pointValidator.SetTaget(this.flatField15, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField16
            // 
            this.flatField16.BackColor = System.Drawing.Color.Transparent;
            this.flatField16.Caption = "X_颜色    ";
            this.flatField16.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField16.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField16, new CI.UIComponents.Filler.TextEntry("X_PlateColor", ""));
            this.flatField16.Location = new System.Drawing.Point(41, 284);
            this.flatField16.Name = "flatField16";
            this.flatField16.Size = new System.Drawing.Size(237, 25);
            this.flatField16.TabIndex = 41;
            this.pointValidator.SetTaget(this.flatField16, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField13
            // 
            this.flatField13.BackColor = System.Drawing.Color.Transparent;
            this.flatField13.Caption = "Y_号牌种类";
            this.flatField13.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField13.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField13, new CI.UIComponents.Filler.TextEntry("Y_PlateType", ""));
            this.flatField13.Location = new System.Drawing.Point(306, 250);
            this.flatField13.Name = "flatField13";
            this.flatField13.Size = new System.Drawing.Size(237, 25);
            this.flatField13.TabIndex = 40;
            this.pointValidator.SetTaget(this.flatField13, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField14
            // 
            this.flatField14.BackColor = System.Drawing.Color.Transparent;
            this.flatField14.Caption = "X_号牌种类";
            this.flatField14.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField14.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField14, new CI.UIComponents.Filler.TextEntry("X_PlateType", ""));
            this.flatField14.Location = new System.Drawing.Point(41, 250);
            this.flatField14.Name = "flatField14";
            this.flatField14.Size = new System.Drawing.Size(237, 25);
            this.flatField14.TabIndex = 39;
            this.pointValidator.SetTaget(this.flatField14, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField11
            // 
            this.flatField11.BackColor = System.Drawing.Color.Transparent;
            this.flatField11.Caption = "Y_机动车所有人";
            this.flatField11.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField11.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField11, new CI.UIComponents.Filler.TextEntry("Y_Owner", ""));
            this.flatField11.Location = new System.Drawing.Point(306, 216);
            this.flatField11.Name = "flatField11";
            this.flatField11.Size = new System.Drawing.Size(237, 25);
            this.flatField11.TabIndex = 38;
            this.pointValidator.SetTaget(this.flatField11, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField12
            // 
            this.flatField12.BackColor = System.Drawing.Color.Transparent;
            this.flatField12.Caption = "X_机动车所有人";
            this.flatField12.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField12.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField12, new CI.UIComponents.Filler.TextEntry("X_Owner", ""));
            this.flatField12.Location = new System.Drawing.Point(41, 216);
            this.flatField12.Name = "flatField12";
            this.flatField12.Size = new System.Drawing.Size(237, 25);
            this.flatField12.TabIndex = 37;
            this.pointValidator.SetTaget(this.flatField12, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // flatField34
            // 
            this.flatField34.BackColor = System.Drawing.Color.Transparent;
            this.flatField34.Caption = "Y_号牌号码";
            this.flatField34.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField34.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField34, new CI.UIComponents.Filler.TextEntry("Y_PlateNo", ""));
            this.flatField34.Location = new System.Drawing.Point(306, 182);
            this.flatField34.Name = "flatField34";
            this.flatField34.Size = new System.Drawing.Size(237, 25);
            this.flatField34.TabIndex = 36;
            // 
            // flatField9
            // 
            this.flatField9.BackColor = System.Drawing.Color.Transparent;
            this.flatField9.Caption = "Y_日      ";
            this.flatField9.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField9.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField9, new CI.UIComponents.Filler.TextEntry("Y_Day", ""));
            this.flatField9.Location = new System.Drawing.Point(306, 148);
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
            this.flatField33.Caption = "X_号牌号码";
            this.flatField33.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField33.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField33, new CI.UIComponents.Filler.TextEntry("X_PlateNo", ""));
            this.flatField33.Location = new System.Drawing.Point(41, 182);
            this.flatField33.Name = "flatField33";
            this.flatField33.Size = new System.Drawing.Size(237, 25);
            this.flatField33.TabIndex = 34;
            // 
            // flatField10
            // 
            this.flatField10.BackColor = System.Drawing.Color.Transparent;
            this.flatField10.Caption = "X_日      ";
            this.flatField10.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField10.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField10, new CI.UIComponents.Filler.TextEntry("X_Day", ""));
            this.flatField10.Location = new System.Drawing.Point(41, 148);
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
            this.flatField7.Caption = "Y_月      ";
            this.flatField7.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField7.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField7, new CI.UIComponents.Filler.TextEntry("Y_Month", ""));
            this.flatField7.Location = new System.Drawing.Point(306, 114);
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
            this.flatField8.Caption = "X_月      ";
            this.flatField8.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField8.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField8, new CI.UIComponents.Filler.TextEntry("X_Month", ""));
            this.flatField8.Location = new System.Drawing.Point(41, 114);
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
            this.flatField6.Caption = "Y_年      ";
            this.flatField6.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField6.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField6, new CI.UIComponents.Filler.TextEntry("Y_Year", ""));
            this.flatField6.Location = new System.Drawing.Point(306, 80);
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
            this.flatField5.Caption = "X_年      ";
            this.flatField5.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField5.CaptionWidth = 0;
            this.pointFiller.SetEntityField(this.flatField5, new CI.UIComponents.Filler.TextEntry("X_Year", ""));
            this.flatField5.Location = new System.Drawing.Point(41, 80);
            this.flatField5.Name = "flatField5";
            this.flatField5.Size = new System.Drawing.Size(237, 25);
            this.flatField5.TabIndex = 29;
            this.pointValidator.SetTaget(this.flatField5, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", ""))),
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("必须是整数！", "^[0-9]*$")))}));
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Depth = 0;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.Location = new System.Drawing.Point(457, 587);
            this.btnSave.MouseState = EASkins.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSavePoint_Click);
            // 
            // PrintSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 692);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.flatField32);
            this.Controls.Add(this.flatField31);
            this.Controls.Add(this.flatField30);
            this.Controls.Add(this.flatField29);
            this.Controls.Add(this.flatField27);
            this.Controls.Add(this.flatField28);
            this.Controls.Add(this.flatField25);
            this.Controls.Add(this.flatField26);
            this.Controls.Add(this.flatField23);
            this.Controls.Add(this.flatField24);
            this.Controls.Add(this.flatField21);
            this.Controls.Add(this.flatField22);
            this.Controls.Add(this.flatField19);
            this.Controls.Add(this.flatField20);
            this.Controls.Add(this.flatField17);
            this.Controls.Add(this.flatField18);
            this.Controls.Add(this.flatField15);
            this.Controls.Add(this.flatField16);
            this.Controls.Add(this.flatField13);
            this.Controls.Add(this.flatField14);
            this.Controls.Add(this.flatField11);
            this.Controls.Add(this.flatField12);
            this.Controls.Add(this.flatField34);
            this.Controls.Add(this.flatField9);
            this.Controls.Add(this.flatField33);
            this.Controls.Add(this.flatField10);
            this.Controls.Add(this.flatField7);
            this.Controls.Add(this.flatField8);
            this.Controls.Add(this.flatField6);
            this.Controls.Add(this.flatField5);
            this.Name = "PrintSettingForm";
            this.Text = "PrintSettingForm";
            this.Controls.SetChildIndex(this.flatField5, 0);
            this.Controls.SetChildIndex(this.flatField6, 0);
            this.Controls.SetChildIndex(this.flatField8, 0);
            this.Controls.SetChildIndex(this.flatField7, 0);
            this.Controls.SetChildIndex(this.flatField10, 0);
            this.Controls.SetChildIndex(this.flatField33, 0);
            this.Controls.SetChildIndex(this.flatField9, 0);
            this.Controls.SetChildIndex(this.flatField34, 0);
            this.Controls.SetChildIndex(this.flatField12, 0);
            this.Controls.SetChildIndex(this.flatField11, 0);
            this.Controls.SetChildIndex(this.flatField14, 0);
            this.Controls.SetChildIndex(this.flatField13, 0);
            this.Controls.SetChildIndex(this.flatField16, 0);
            this.Controls.SetChildIndex(this.flatField15, 0);
            this.Controls.SetChildIndex(this.flatField18, 0);
            this.Controls.SetChildIndex(this.flatField17, 0);
            this.Controls.SetChildIndex(this.flatField20, 0);
            this.Controls.SetChildIndex(this.flatField19, 0);
            this.Controls.SetChildIndex(this.flatField22, 0);
            this.Controls.SetChildIndex(this.flatField21, 0);
            this.Controls.SetChildIndex(this.flatField24, 0);
            this.Controls.SetChildIndex(this.flatField23, 0);
            this.Controls.SetChildIndex(this.flatField26, 0);
            this.Controls.SetChildIndex(this.flatField25, 0);
            this.Controls.SetChildIndex(this.flatField28, 0);
            this.Controls.SetChildIndex(this.flatField27, 0);
            this.Controls.SetChildIndex(this.flatField29, 0);
            this.Controls.SetChildIndex(this.flatField30, 0);
            this.Controls.SetChildIndex(this.flatField31, 0);
            this.Controls.SetChildIndex(this.flatField32, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CI.UIComponents.Filler.EntityFiller pointFiller;
        private CI.UIComponents.Validate.Validator pointValidator;
        private CI.Controls.FlatField flatField32;
        private CI.Controls.FlatField flatField31;
        private CI.Controls.FlatField flatField30;
        private CI.Controls.FlatField flatField29;
        private CI.Controls.FlatField flatField27;
        private CI.Controls.FlatField flatField28;
        private CI.Controls.FlatField flatField25;
        private CI.Controls.FlatField flatField26;
        private CI.Controls.FlatField flatField23;
        private CI.Controls.FlatField flatField24;
        private CI.Controls.FlatField flatField21;
        private CI.Controls.FlatField flatField22;
        private CI.Controls.FlatField flatField19;
        private CI.Controls.FlatField flatField20;
        private CI.Controls.FlatField flatField17;
        private CI.Controls.FlatField flatField18;
        private CI.Controls.FlatField flatField15;
        private CI.Controls.FlatField flatField16;
        private CI.Controls.FlatField flatField13;
        private CI.Controls.FlatField flatField14;
        private CI.Controls.FlatField flatField11;
        private CI.Controls.FlatField flatField12;
        private CI.Controls.FlatField flatField34;
        private CI.Controls.FlatField flatField9;
        private CI.Controls.FlatField flatField33;
        private CI.Controls.FlatField flatField10;
        private CI.Controls.FlatField flatField7;
        private CI.Controls.FlatField flatField8;
        private CI.Controls.FlatField flatField6;
        private CI.Controls.FlatField flatField5;
        private EASkins.Controls.MaterialRaisedButton btnSave;
    }
}