namespace ChargeSys.Main.Forms
{
    partial class RoleOptForm
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
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("节点2");
            this.btnSave = new HZH_Controls.Controls.UCBtnExt();
            this.entityFiller = new CI.UIComponents.Filler.EntityFiller();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.validator1 = new CI.UIComponents.Validate.Validator();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvMenus = new System.Windows.Forms.TreeView();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(351, 80);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.RectColor = System.Drawing.Color.Gainsboro;
            this.btnSave.RectWidth = 1;
            this.btnSave.Size = new System.Drawing.Size(119, 46);
            this.btnSave.TabIndex = 17;
            this.btnSave.TabStop = false;
            this.btnSave.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnSave.TipsText = "";
            this.btnSave.BtnClick += new System.EventHandler(this.btnSave_BtnClick);
            // 
            // textBox7
            // 
            this.entityFiller.SetEntityField(this.textBox7, new CI.UIComponents.Filler.TextEntry("RoleName", ""));
            this.textBox7.Location = new System.Drawing.Point(43, 103);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(274, 23);
            this.textBox7.TabIndex = 26;
            this.validator1.SetTaget(this.textBox7, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("", "")))}));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(39, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "角色名称";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvMenus);
            this.panel2.Controls.Add(this.chkAll);
            this.panel2.Location = new System.Drawing.Point(5, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 362);
            this.panel2.TabIndex = 27;
            // 
            // tvMenus
            // 
            this.tvMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvMenus.Location = new System.Drawing.Point(13, 30);
            this.tvMenus.Name = "tvMenus";
            treeNode8.Name = "节点3";
            treeNode8.Text = "节点3";
            treeNode9.Name = "节点4";
            treeNode9.Text = "节点4";
            treeNode10.Name = "节点5";
            treeNode10.Text = "节点5";
            treeNode11.Name = "节点6";
            treeNode11.Text = "节点6";
            treeNode12.Name = "节点0";
            treeNode12.Text = "节点0";
            treeNode13.Name = "节点1";
            treeNode13.Text = "节点1";
            treeNode14.Name = "节点2";
            treeNode14.Text = "节点2";
            this.tvMenus.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
            this.tvMenus.Size = new System.Drawing.Size(484, 320);
            this.tvMenus.TabIndex = 2;
            this.tvMenus.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvMenus_AfterCheck);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(17, 7);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(51, 21);
            this.chkAll.TabIndex = 1;
            this.chkAll.Text = "全选";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // RoleOptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Name = "RoleOptForm";
            this.Text = "InputLambdaForm";
            this.Title = "角色配置";
            this.Load += new System.EventHandler(this.ValChangeOptForm_Load);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox7, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HZH_Controls.Controls.UCBtnExt btnSave;
        private CI.UIComponents.Filler.EntityFiller entityFiller;
        private CI.UIComponents.Validate.Validator validator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvMenus;
        private System.Windows.Forms.CheckBox chkAll;
    }
}