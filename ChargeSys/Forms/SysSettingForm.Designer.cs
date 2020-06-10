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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysSettingForm));
            this.settingFiller = new CI.UIComponents.Filler.EntityFiller();
            this.combPrinter = new System.Windows.Forms.ComboBox();
            this.flatField1 = new CI.Controls.FlatField();
            this.flatField5 = new CI.Controls.FlatField();
            this.flatField6 = new CI.Controls.FlatField();
            this.ami_HeaderLabel3 = new EASkins.Ami_HeaderLabel();
            this.btnSave = new EASkins.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // combPrinter
            // 
            this.combPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingFiller.SetEntityField(this.combPrinter, new CI.UIComponents.Filler.TextEntry("PrinterName", ""));
            this.combPrinter.FormattingEnabled = true;
            this.combPrinter.Location = new System.Drawing.Point(256, 246);
            this.combPrinter.Name = "combPrinter";
            this.combPrinter.Size = new System.Drawing.Size(353, 25);
            this.combPrinter.TabIndex = 15;
            // 
            // flatField1
            // 
            this.flatField1.BackColor = System.Drawing.Color.Transparent;
            this.flatField1.Caption = "API服务地址:";
            this.flatField1.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField1.CaptionLength = 12;
            this.flatField1.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField1, new CI.UIComponents.Filler.TextEntry("ApiUrl", ""));
            this.flatField1.Location = new System.Drawing.Point(182, 84);
            this.flatField1.Margin = new System.Windows.Forms.Padding(2);
            this.flatField1.Name = "flatField1";
            this.flatField1.Size = new System.Drawing.Size(427, 25);
            this.flatField1.TabIndex = 10;
            // 
            // flatField5
            // 
            this.flatField5.BackColor = System.Drawing.Color.Transparent;
            this.flatField5.Caption = "叫号机请求地址:";
            this.flatField5.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField5.CaptionLength = 12;
            this.flatField5.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField5, new CI.UIComponents.Filler.TextEntry("CallUrl", ""));
            this.flatField5.Location = new System.Drawing.Point(182, 138);
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
            this.flatField6.Location = new System.Drawing.Point(180, 192);
            this.flatField6.Margin = new System.Windows.Forms.Padding(2);
            this.flatField6.Name = "flatField6";
            this.flatField6.Size = new System.Drawing.Size(427, 25);
            this.flatField6.TabIndex = 17;
            // 
            // ami_HeaderLabel3
            // 
            this.ami_HeaderLabel3.AutoSize = true;
            this.ami_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ami_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ami_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ami_HeaderLabel3.Location = new System.Drawing.Point(171, 249);
            this.ami_HeaderLabel3.Name = "ami_HeaderLabel3";
            this.ami_HeaderLabel3.Size = new System.Drawing.Size(77, 20);
            this.ami_HeaderLabel3.TabIndex = 16;
            this.ami_HeaderLabel3.Text = "打印机：";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Depth = 0;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.Location = new System.Drawing.Point(523, 319);
            this.btnSave.MouseState = EASkins.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // SysSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BorderStyleSize = 1;
            this.BorderStyleType = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.flatField6);
            this.Controls.Add(this.flatField5);
            this.Controls.Add(this.ami_HeaderLabel3);
            this.Controls.Add(this.combPrinter);
            this.Controls.Add(this.flatField1);
            this.IsShowMaskDialog = false;
            this.Name = "SysSettingForm";
            this.Text = "SysSettingForm";
            this.Title = "系统设置";
            this.Controls.SetChildIndex(this.flatField1, 0);
            this.Controls.SetChildIndex(this.combPrinter, 0);
            this.Controls.SetChildIndex(this.ami_HeaderLabel3, 0);
            this.Controls.SetChildIndex(this.flatField5, 0);
            this.Controls.SetChildIndex(this.flatField6, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CI.UIComponents.Filler.EntityFiller settingFiller;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel3;
        private System.Windows.Forms.ComboBox combPrinter;
        private CI.Controls.FlatField flatField1;
        private CI.Controls.FlatField flatField5;
        private CI.Controls.FlatField flatField6;
        private EASkins.Controls.MaterialRaisedButton btnSave;
    }
}