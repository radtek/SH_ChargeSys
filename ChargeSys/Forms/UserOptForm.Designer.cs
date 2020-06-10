namespace ChargeSys.Main.Forms
{
    partial class UserOptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserOptForm));
            this.entityFiller = new CI.UIComponents.Filler.EntityFiller();
            this.txtAccount = new CI.Controls.FlatField();
            this.flatField1 = new CI.Controls.FlatField();
            this.flatField3 = new CI.Controls.FlatField();
            this.flatField4 = new CI.Controls.FlatField();
            this.validator1 = new CI.UIComponents.Validate.Validator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvMenus = new System.Windows.Forms.TreeView();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnCancel = new EASkins.Controls.MaterialRaisedButton();
            this.btnSave = new EASkins.Controls.MaterialRaisedButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAccount
            // 
            this.txtAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAccount.BackColor = System.Drawing.Color.Transparent;
            this.txtAccount.Caption = "账号:     ";
            this.txtAccount.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtAccount.CaptionWidth = 0;
            this.entityFiller.SetEntityField(this.txtAccount, new CI.UIComponents.Filler.TextEntry("UserAccount", ""));
            this.txtAccount.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtAccount.Location = new System.Drawing.Point(11, 104);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(267, 31);
            this.txtAccount.TabIndex = 18;
            // 
            // flatField1
            // 
            this.flatField1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField1.BackColor = System.Drawing.Color.Transparent;
            this.flatField1.Caption = "密码:     ";
            this.flatField1.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField1.CaptionWidth = 0;
            this.entityFiller.SetEntityField(this.flatField1, new CI.UIComponents.Filler.TextEntry("UserPwd", ""));
            this.flatField1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField1.Location = new System.Drawing.Point(11, 157);
            this.flatField1.Name = "flatField1";
            this.flatField1.Size = new System.Drawing.Size(267, 31);
            this.flatField1.TabIndex = 19;
            // 
            // flatField3
            // 
            this.flatField3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField3.BackColor = System.Drawing.Color.Transparent;
            this.flatField3.Caption = "用户名:   ";
            this.flatField3.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField3.CaptionWidth = 0;
            this.entityFiller.SetEntityField(this.flatField3, new CI.UIComponents.Filler.TextEntry("UserName", ""));
            this.flatField3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField3.Location = new System.Drawing.Point(11, 214);
            this.flatField3.Name = "flatField3";
            this.flatField3.Size = new System.Drawing.Size(267, 31);
            this.flatField3.TabIndex = 20;
            // 
            // flatField4
            // 
            this.flatField4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField4.BackColor = System.Drawing.Color.Transparent;
            this.flatField4.Caption = "身份证:   ";
            this.flatField4.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField4.CaptionWidth = 0;
            this.entityFiller.SetEntityField(this.flatField4, new CI.UIComponents.Filler.TextEntry("IDCardNo", ""));
            this.flatField4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField4.Location = new System.Drawing.Point(11, 274);
            this.flatField4.Name = "flatField4";
            this.flatField4.Size = new System.Drawing.Size(267, 31);
            this.flatField4.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvMenus);
            this.panel2.Controls.Add(this.chkAll);
            this.panel2.Location = new System.Drawing.Point(324, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 452);
            this.panel2.TabIndex = 28;
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
            this.tvMenus.Size = new System.Drawing.Size(263, 410);
            this.tvMenus.TabIndex = 2;
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
            this.btnCancel.Location = new System.Drawing.Point(86, 325);
            this.btnCancel.MouseState = EASkins.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(86, 36);
            this.btnCancel.TabIndex = 56;
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
            this.btnSave.Location = new System.Drawing.Point(191, 325);
            this.btnSave.MouseState = EASkins.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_BtnClick);
            // 
            // UserOptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(624, 531);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flatField4);
            this.Controls.Add(this.flatField3);
            this.Controls.Add(this.flatField1);
            this.Controls.Add(this.txtAccount);
            this.IsShowMaskDialog = false;
            this.Name = "UserOptForm";
            this.Text = "InputLambdaForm";
            this.Title = "用户管理";
            this.Load += new System.EventHandler(this.ValChangeOptForm_Load);
            this.Controls.SetChildIndex(this.txtAccount, 0);
            this.Controls.SetChildIndex(this.flatField1, 0);
            this.Controls.SetChildIndex(this.flatField3, 0);
            this.Controls.SetChildIndex(this.flatField4, 0);
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
        private CI.Controls.FlatField txtAccount;
        private CI.Controls.FlatField flatField1;
        private CI.Controls.FlatField flatField3;
        private CI.Controls.FlatField flatField4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvMenus;
        private System.Windows.Forms.CheckBox chkAll;
        private EASkins.Controls.MaterialRaisedButton btnCancel;
        private EASkins.Controls.MaterialRaisedButton btnSave;
    }
}