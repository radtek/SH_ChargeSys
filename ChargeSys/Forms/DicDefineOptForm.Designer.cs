namespace ChargeSys.Main.Forms
{
    partial class DicDefineOptForm
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
            this.btnSave = new HZH_Controls.Controls.UCBtnExt();
            this.entityFiller = new CI.UIComponents.Filler.EntityFiller();
            this.validator1 = new CI.UIComponents.Validate.Validator();
            this.label3 = new System.Windows.Forms.Label();
            this.combDefine = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BtnBackColor = System.Drawing.Color.Transparent;
            this.btnSave.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.BtnForeColor = System.Drawing.Color.White;
            this.btnSave.BtnText = "保 存";
            this.btnSave.ConerRadius = 10;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.EnabledMouseEffect = true;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IsRadius = true;
            this.btnSave.IsShowRect = false;
            this.btnSave.IsShowTips = false;
            this.btnSave.Location = new System.Drawing.Point(232, 306);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.RectColor = System.Drawing.Color.Gainsboro;
            this.btnSave.RectWidth = 1;
            this.btnSave.Size = new System.Drawing.Size(87, 39);
            this.btnSave.TabIndex = 17;
            this.btnSave.TabStop = false;
            this.btnSave.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnSave.TipsText = "";
            this.btnSave.BtnClick += new System.EventHandler(this.btnSave_BtnClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(48, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "类型";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // combDefine
            // 
            this.combDefine.FormattingEnabled = true;
            this.combDefine.Location = new System.Drawing.Point(48, 116);
            this.combDefine.Name = "combDefine";
            this.combDefine.Size = new System.Drawing.Size(271, 25);
            this.combDefine.TabIndex = 27;
            // 
            // textBox7
            // 
            this.entityFiller.SetEntityField(this.textBox7, new CI.UIComponents.Filler.TextEntry("ConstantName", ""));
            this.textBox7.Location = new System.Drawing.Point(48, 258);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(274, 23);
            this.textBox7.TabIndex = 30;
            this.validator1.SetTaget(this.textBox7, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("", "")))}));
            // 
            // textBox3
            // 
            this.entityFiller.SetEntityField(this.textBox3, new CI.UIComponents.Filler.TextEntry("ConstantName", ""));
            this.textBox3.Location = new System.Drawing.Point(48, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 23);
            this.textBox3.TabIndex = 31;
            this.validator1.SetTaget(this.textBox3, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(48, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "常量代码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(48, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "常量名称";
            // 
            // DicDefineOptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 370);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combDefine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Name = "DicDefineOptForm";
            this.Text = "InputLambdaForm";
            this.Title = "常量配置";
            this.Load += new System.EventHandler(this.ValChangeOptForm_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.combDefine, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.textBox7, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HZH_Controls.Controls.UCBtnExt btnSave;
        private CI.UIComponents.Filler.EntityFiller entityFiller;
        private CI.UIComponents.Validate.Validator validator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combDefine;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}