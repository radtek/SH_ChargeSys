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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点2");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleOptForm));
            this.entityFiller = new CI.UIComponents.Filler.EntityFiller();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.validator1 = new CI.UIComponents.Validate.Validator();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvMenus = new System.Windows.Forms.TreeView();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnCancel = new EASkins.Controls.MaterialRaisedButton();
            this.btnSave = new EASkins.Controls.MaterialRaisedButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.entityFiller.SetEntityField(this.textBox7, new CI.UIComponents.Filler.TextEntry("RoleName", ""));
            this.textBox7.Location = new System.Drawing.Point(43, 103);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(317, 23);
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
            this.panel2.Location = new System.Drawing.Point(26, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 325);
            this.panel2.TabIndex = 27;
            // 
            // tvMenus
            // 
            this.tvMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvMenus.Location = new System.Drawing.Point(13, 30);
            this.tvMenus.Name = "tvMenus";
            treeNode1.Name = "节点3";
            treeNode1.Text = "节点3";
            treeNode2.Name = "节点4";
            treeNode2.Text = "节点4";
            treeNode3.Name = "节点5";
            treeNode3.Text = "节点5";
            treeNode4.Name = "节点6";
            treeNode4.Text = "节点6";
            treeNode5.Name = "节点0";
            treeNode5.Text = "节点0";
            treeNode6.Name = "节点1";
            treeNode6.Text = "节点1";
            treeNode7.Name = "节点2";
            treeNode7.Text = "节点2";
            this.tvMenus.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.tvMenus.Size = new System.Drawing.Size(321, 283);
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
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Depth = 0;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnCancel.Icon = ((System.Drawing.Image)(resources.GetObject("btnCancel.Icon")));
            this.btnCancel.Location = new System.Drawing.Point(167, 481);
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
            this.btnSave.Location = new System.Drawing.Point(272, 481);
            this.btnSave.MouseState = EASkins.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_BtnClick);
            // 
            // RoleOptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 529);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label3);
            this.Name = "RoleOptForm";
            this.Text = "InputLambdaForm";
            this.Title = "角色配置";
            this.Load += new System.EventHandler(this.ValChangeOptForm_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox7, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CI.UIComponents.Filler.EntityFiller entityFiller;
        private CI.UIComponents.Validate.Validator validator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvMenus;
        private System.Windows.Forms.CheckBox chkAll;
        private EASkins.Controls.MaterialRaisedButton btnCancel;
        private EASkins.Controls.MaterialRaisedButton btnSave;
    }
}