namespace ChargeSys.Main.Forms
{
    partial class ChargeDefineOptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChargeDefineOptForm));
            this.entityFiller = new CI.UIComponents.Filler.EntityFiller();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.validator1 = new CI.UIComponents.Validate.Validator();
            this.label3 = new System.Windows.Forms.Label();
            this.combDefine = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new EASkins.Controls.MaterialRaisedButton();
            this.btnSave = new EASkins.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.entityFiller.SetEntityField(this.textBox7, new CI.UIComponents.Filler.TextEntry("Price", ""));
            this.textBox7.Location = new System.Drawing.Point(89, 252);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(274, 23);
            this.textBox7.TabIndex = 30;
            this.validator1.SetTaget(this.textBox7, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("", "")))}));
            // 
            // textBox3
            // 
            this.entityFiller.SetEntityField(this.textBox3, new CI.UIComponents.Filler.TextEntry("Times", ""));
            this.textBox3.Location = new System.Drawing.Point(89, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 23);
            this.textBox3.TabIndex = 31;
            this.validator1.SetTaget(this.textBox3, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(89, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "收费项目";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // combDefine
            // 
            this.combDefine.FormattingEnabled = true;
            this.combDefine.Location = new System.Drawing.Point(89, 110);
            this.combDefine.Name = "combDefine";
            this.combDefine.Size = new System.Drawing.Size(271, 25);
            this.combDefine.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(89, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "价格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(89, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "检测次数";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Depth = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnCancel.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancel.Icon")));
            this.btnCancel.Location = new System.Drawing.Point(171, 306);
            this.btnCancel.MouseState = EASkins.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(86, 36);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Depth = 0;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnSave.Icon = ((System.Drawing.Image)(resources.GetObject("btnSave.Icon")));
            this.btnSave.Location = new System.Drawing.Point(276, 306);
            this.btnSave.MouseState = EASkins.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_BtnClick);
            // 
            // ChargeDefineOptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 370);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combDefine);
            this.Controls.Add(this.label3);
            this.Name = "ChargeDefineOptForm";
            this.Text = "InputLambdaForm";
            this.Title = "收费配置";
            this.Load += new System.EventHandler(this.ValChangeOptForm_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.combDefine, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.textBox7, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CI.UIComponents.Filler.EntityFiller entityFiller;
        private CI.UIComponents.Validate.Validator validator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combDefine;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private EASkins.Controls.MaterialRaisedButton btnCancel;
        private EASkins.Controls.MaterialRaisedButton btnSave;
    }
}