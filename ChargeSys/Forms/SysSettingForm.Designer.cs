namespace ChargeSys.Main.Forms
{
    partial class SysSettingForm
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
            this.settingFiller = new CI.UIComponents.Filler.EntityFiller();
            this.ami_HeaderLabel3 = new EASkins.Ami_HeaderLabel();
            this.combPrinter = new System.Windows.Forms.ComboBox();
            this.flatField1 = new CI.Controls.FlatField();
            this.btnSaveSetting = new EASkins.Emi_Button_1();
            this.flatField2 = new CI.Controls.FlatField();
            this.flatField3 = new CI.Controls.FlatField();
            this.flatField4 = new CI.Controls.FlatField();
            this.flatField5 = new CI.Controls.FlatField();
            this.flatField6 = new CI.Controls.FlatField();
            this.SuspendLayout();
            // 
            // ami_HeaderLabel3
            // 
            this.ami_HeaderLabel3.AutoSize = true;
            this.ami_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ami_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ami_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ami_HeaderLabel3.Location = new System.Drawing.Point(178, 403);
            this.ami_HeaderLabel3.Name = "ami_HeaderLabel3";
            this.ami_HeaderLabel3.Size = new System.Drawing.Size(77, 20);
            this.ami_HeaderLabel3.TabIndex = 16;
            this.ami_HeaderLabel3.Text = "打印机：";
            // 
            // combPrinter
            // 
            this.combPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingFiller.SetEntityField(this.combPrinter, new CI.UIComponents.Filler.TextEntry("PrinterName", ""));
            this.combPrinter.FormattingEnabled = true;
            this.combPrinter.Location = new System.Drawing.Point(256, 403);
            this.combPrinter.Name = "combPrinter";
            this.combPrinter.Size = new System.Drawing.Size(353, 25);
            this.combPrinter.TabIndex = 15;
            // 
            // flatField1
            // 
            this.flatField1.BackColor = System.Drawing.Color.Transparent;
            this.flatField1.Caption = "Webservice: ";
            this.flatField1.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField1.CaptionLength = 12;
            this.flatField1.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField1, new CI.UIComponents.Filler.TextEntry("WebServiceUrl", ""));
            this.flatField1.Location = new System.Drawing.Point(182, 84);
            this.flatField1.Margin = new System.Windows.Forms.Padding(2);
            this.flatField1.Name = "flatField1";
            this.flatField1.Size = new System.Drawing.Size(427, 25);
            this.flatField1.TabIndex = 10;
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveSetting.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSaveSetting.Image = null;
            this.btnSaveSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveSetting.Location = new System.Drawing.Point(182, 446);
            this.btnSaveSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(80, 32);
            this.btnSaveSetting.TabIndex = 14;
            this.btnSaveSetting.Text = "保  存";
            this.btnSaveSetting.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // flatField2
            // 
            this.flatField2.BackColor = System.Drawing.Color.Transparent;
            this.flatField2.Caption = "命名空间:   ";
            this.flatField2.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField2.CaptionLength = 12;
            this.flatField2.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField2, new CI.UIComponents.Filler.TextEntry("WebNameSpace", ""));
            this.flatField2.Location = new System.Drawing.Point(182, 139);
            this.flatField2.Margin = new System.Windows.Forms.Padding(2);
            this.flatField2.Name = "flatField2";
            this.flatField2.Size = new System.Drawing.Size(427, 25);
            this.flatField2.TabIndex = 11;
            // 
            // flatField3
            // 
            this.flatField3.BackColor = System.Drawing.Color.Transparent;
            this.flatField3.Caption = "接口序列号: ";
            this.flatField3.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField3.CaptionLength = 12;
            this.flatField3.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField3, new CI.UIComponents.Filler.TextEntry("JKXLH", ""));
            this.flatField3.Location = new System.Drawing.Point(182, 194);
            this.flatField3.Margin = new System.Windows.Forms.Padding(2);
            this.flatField3.Name = "flatField3";
            this.flatField3.Size = new System.Drawing.Size(427, 25);
            this.flatField3.TabIndex = 12;
            // 
            // flatField4
            // 
            this.flatField4.BackColor = System.Drawing.Color.Transparent;
            this.flatField4.Caption = "检测站编号: ";
            this.flatField4.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField4.CaptionLength = 12;
            this.flatField4.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField4, new CI.UIComponents.Filler.TextEntry("StationNo", ""));
            this.flatField4.Location = new System.Drawing.Point(182, 249);
            this.flatField4.Margin = new System.Windows.Forms.Padding(2);
            this.flatField4.Name = "flatField4";
            this.flatField4.Size = new System.Drawing.Size(427, 25);
            this.flatField4.TabIndex = 13;
            // 
            // flatField5
            // 
            this.flatField5.BackColor = System.Drawing.Color.Transparent;
            this.flatField5.Caption = "叫号机请求地址:";
            this.flatField5.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField5.CaptionLength = 12;
            this.flatField5.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField5, new CI.UIComponents.Filler.TextEntry("CallUrl", ""));
            this.flatField5.Location = new System.Drawing.Point(182, 304);
            this.flatField5.Margin = new System.Windows.Forms.Padding(2);
            this.flatField5.Name = "flatField5";
            this.flatField5.Size = new System.Drawing.Size(427, 25);
            this.flatField5.TabIndex = 17;
            // 
            // flatField6
            // 
            this.flatField6.BackColor = System.Drawing.Color.Transparent;
            this.flatField6.Caption = "窗口:       ";
            this.flatField6.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField6.CaptionLength = 12;
            this.flatField6.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField6, new CI.UIComponents.Filler.TextEntry("WindowAddr", ""));
            this.flatField6.Location = new System.Drawing.Point(180, 359);
            this.flatField6.Margin = new System.Windows.Forms.Padding(2);
            this.flatField6.Name = "flatField6";
            this.flatField6.Size = new System.Drawing.Size(427, 25);
            this.flatField6.TabIndex = 17;
            // 
            // SysSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.flatField6);
            this.Controls.Add(this.flatField5);
            this.Controls.Add(this.ami_HeaderLabel3);
            this.Controls.Add(this.combPrinter);
            this.Controls.Add(this.flatField1);
            this.Controls.Add(this.btnSaveSetting);
            this.Controls.Add(this.flatField2);
            this.Controls.Add(this.flatField3);
            this.Controls.Add(this.flatField4);
            this.Name = "SysSettingForm";
            this.Text = "SysSettingForm";
            this.Title = "系统设置";
            this.Controls.SetChildIndex(this.flatField4, 0);
            this.Controls.SetChildIndex(this.flatField3, 0);
            this.Controls.SetChildIndex(this.flatField2, 0);
            this.Controls.SetChildIndex(this.btnSaveSetting, 0);
            this.Controls.SetChildIndex(this.flatField1, 0);
            this.Controls.SetChildIndex(this.combPrinter, 0);
            this.Controls.SetChildIndex(this.ami_HeaderLabel3, 0);
            this.Controls.SetChildIndex(this.flatField5, 0);
            this.Controls.SetChildIndex(this.flatField6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CI.UIComponents.Filler.EntityFiller settingFiller;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel3;
        private System.Windows.Forms.ComboBox combPrinter;
        private CI.Controls.FlatField flatField1;
        private EASkins.Emi_Button_1 btnSaveSetting;
        private CI.Controls.FlatField flatField2;
        private CI.Controls.FlatField flatField3;
        private CI.Controls.FlatField flatField4;
        private CI.Controls.FlatField flatField5;
        private CI.Controls.FlatField flatField6;
    }
}