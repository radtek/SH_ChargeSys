namespace ChargeSys.Main
{
    partial class WaitForm
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
            this.components = new System.ComponentModel.Container();
            this.emi_ProgressIndicator1 = new EASkins.Emi_ProgressIndicator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ami_HeaderLabel1 = new EASkins.Ami_HeaderLabel();
            this.labTips = new EASkins.Ami_HeaderLabel();
            this.SuspendLayout();
            // 
            // emi_ProgressIndicator1
            // 
            this.emi_ProgressIndicator1.Location = new System.Drawing.Point(0, 0);
            this.emi_ProgressIndicator1.MinimumSize = new System.Drawing.Size(80, 80);
            this.emi_ProgressIndicator1.Name = "emi_ProgressIndicator1";
            this.emi_ProgressIndicator1.P_AnimationColor = System.Drawing.Color.Red;
            this.emi_ProgressIndicator1.P_AnimationSpeed = 100;
            this.emi_ProgressIndicator1.P_BaseColor = System.Drawing.Color.DarkGray;
            this.emi_ProgressIndicator1.Size = new System.Drawing.Size(176, 176);
            this.emi_ProgressIndicator1.TabIndex = 1;
            this.emi_ProgressIndicator1.Text = "emi_ProgressIndicator1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ami_HeaderLabel1
            // 
            this.ami_HeaderLabel1.AutoSize = true;
            this.ami_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ami_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ami_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ami_HeaderLabel1.Location = new System.Drawing.Point(38, 76);
            this.ami_HeaderLabel1.Name = "ami_HeaderLabel1";
            this.ami_HeaderLabel1.Size = new System.Drawing.Size(105, 20);
            this.ami_HeaderLabel1.TabIndex = 2;
            this.ami_HeaderLabel1.Text = "正在执行……";
            // 
            // labTips
            // 
            this.labTips.AutoSize = true;
            this.labTips.BackColor = System.Drawing.Color.Transparent;
            this.labTips.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labTips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labTips.Location = new System.Drawing.Point(38, 76);
            this.labTips.Name = "labTips";
            this.labTips.Size = new System.Drawing.Size(105, 20);
            this.labTips.TabIndex = 2;
            this.labTips.Text = "正在执行……";
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(176, 176);
            this.Controls.Add(this.labTips);
            this.Controls.Add(this.ami_HeaderLabel1);
            this.Controls.Add(this.emi_ProgressIndicator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaitForm";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Shown += new System.EventHandler(this.WaitForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EASkins.Emi_ProgressIndicator emi_ProgressIndicator1;
        private System.Windows.Forms.Timer timer1;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel1;
        private EASkins.Ami_HeaderLabel labTips;
    }
}