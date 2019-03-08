namespace THSet {
    partial class FloatWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FloatWindow));
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.lbBulletCount = new System.Windows.Forms.Label();
            this.groupBoxBoss = new System.Windows.Forms.GroupBox();
            this.lbLife = new System.Windows.Forms.Label();
            this.lbDPS = new System.Windows.Forms.Label();
            this.groupBoxSourceUse = new System.Windows.Forms.GroupBox();
            this.btnCountStart = new System.Windows.Forms.Button();
            this.lbMissCount = new System.Windows.Forms.Label();
            this.lbBombCount = new System.Windows.Forms.Label();
            this.timerFloatWindow = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.sp1 = new System.Windows.Forms.Label();
            this.groupBoxOther.SuspendLayout();
            this.groupBoxBoss.SuspendLayout();
            this.groupBoxSourceUse.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.Controls.Add(this.sp1);
            this.groupBoxOther.Controls.Add(this.lbBulletCount);
            this.groupBoxOther.Location = new System.Drawing.Point(92, 70);
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.Size = new System.Drawing.Size(82, 59);
            this.groupBoxOther.TabIndex = 27;
            this.groupBoxOther.TabStop = false;
            this.groupBoxOther.Text = "其它";
            // 
            // lbBulletCount
            // 
            this.lbBulletCount.AutoSize = true;
            this.lbBulletCount.Location = new System.Drawing.Point(6, 17);
            this.lbBulletCount.Name = "lbBulletCount";
            this.lbBulletCount.Size = new System.Drawing.Size(47, 12);
            this.lbBulletCount.TabIndex = 20;
            this.lbBulletCount.Text = "子弹数:";
            this.lbBulletCount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseDown);
            this.lbBulletCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseMove);
            this.lbBulletCount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseUp);
            // 
            // groupBoxBoss
            // 
            this.groupBoxBoss.Controls.Add(this.lbLife);
            this.groupBoxBoss.Controls.Add(this.lbDPS);
            this.groupBoxBoss.Location = new System.Drawing.Point(12, 70);
            this.groupBoxBoss.Name = "groupBoxBoss";
            this.groupBoxBoss.Size = new System.Drawing.Size(74, 59);
            this.groupBoxBoss.TabIndex = 26;
            this.groupBoxBoss.TabStop = false;
            this.groupBoxBoss.Text = "Boss";
            // 
            // lbLife
            // 
            this.lbLife.AutoSize = true;
            this.lbLife.Location = new System.Drawing.Point(7, 17);
            this.lbLife.Name = "lbLife";
            this.lbLife.Size = new System.Drawing.Size(35, 12);
            this.lbLife.TabIndex = 21;
            this.lbLife.Text = "血量:";
            this.lbLife.MouseDown += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseDown);
            this.lbLife.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseMove);
            this.lbLife.MouseUp += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseUp);
            // 
            // lbDPS
            // 
            this.lbDPS.AutoSize = true;
            this.lbDPS.Location = new System.Drawing.Point(7, 41);
            this.lbDPS.Name = "lbDPS";
            this.lbDPS.Size = new System.Drawing.Size(29, 12);
            this.lbDPS.TabIndex = 22;
            this.lbDPS.Text = "DPS:";
            this.lbDPS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseDown);
            this.lbDPS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseMove);
            this.lbDPS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseUp);
            // 
            // groupBoxSourceUse
            // 
            this.groupBoxSourceUse.Controls.Add(this.btnCountStart);
            this.groupBoxSourceUse.Controls.Add(this.lbMissCount);
            this.groupBoxSourceUse.Controls.Add(this.lbBombCount);
            this.groupBoxSourceUse.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSourceUse.Name = "groupBoxSourceUse";
            this.groupBoxSourceUse.Size = new System.Drawing.Size(162, 52);
            this.groupBoxSourceUse.TabIndex = 25;
            this.groupBoxSourceUse.TabStop = false;
            this.groupBoxSourceUse.Text = "资源消耗统计";
            // 
            // btnCountStart
            // 
            this.btnCountStart.BackColor = System.Drawing.Color.Transparent;
            this.btnCountStart.Location = new System.Drawing.Point(110, 12);
            this.btnCountStart.Name = "btnCountStart";
            this.btnCountStart.Size = new System.Drawing.Size(46, 23);
            this.btnCountStart.TabIndex = 17;
            this.btnCountStart.Text = "重置";
            this.btnCountStart.UseVisualStyleBackColor = false;
            this.btnCountStart.Click += new System.EventHandler(this.btnCountStart_Click);
            // 
            // lbMissCount
            // 
            this.lbMissCount.AutoSize = true;
            this.lbMissCount.Location = new System.Drawing.Point(6, 17);
            this.lbMissCount.Name = "lbMissCount";
            this.lbMissCount.Size = new System.Drawing.Size(95, 12);
            this.lbMissCount.TabIndex = 14;
            this.lbMissCount.Text = "miss次数:未使用";
            this.lbMissCount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseDown);
            this.lbMissCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseMove);
            this.lbMissCount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseUp);
            // 
            // lbBombCount
            // 
            this.lbBombCount.AutoSize = true;
            this.lbBombCount.Location = new System.Drawing.Point(6, 33);
            this.lbBombCount.Name = "lbBombCount";
            this.lbBombCount.Size = new System.Drawing.Size(95, 12);
            this.lbBombCount.TabIndex = 15;
            this.lbBombCount.Text = "bomb次数:未使用";
            this.lbBombCount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseDown);
            this.lbBombCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseMove);
            this.lbBombCount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseUp);
            // 
            // timerFloatWindow
            // 
            this.timerFloatWindow.Enabled = true;
            this.timerFloatWindow.Tick += new System.EventHandler(this.timerFloatWindow_Tick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(12, 135);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(161, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "返回主窗体";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // sp1
            // 
            this.sp1.AutoSize = true;
            this.sp1.Location = new System.Drawing.Point(6, 41);
            this.sp1.Name = "sp1";
            this.sp1.Size = new System.Drawing.Size(17, 12);
            this.sp1.TabIndex = 21;
            this.sp1.Text = "  ";
            // 
            // FloatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(185, 167);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxOther);
            this.Controls.Add(this.groupBoxBoss);
            this.Controls.Add(this.groupBoxSourceUse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FloatWindow";
            this.Text = "发发发";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.setBG);
            this.Load += new System.EventHandler(this.floatWindow_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.floatWindow_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.floatWindow_MouseUp);
            this.groupBoxOther.ResumeLayout(false);
            this.groupBoxOther.PerformLayout();
            this.groupBoxBoss.ResumeLayout(false);
            this.groupBoxBoss.PerformLayout();
            this.groupBoxSourceUse.ResumeLayout(false);
            this.groupBoxSourceUse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOther;
        private System.Windows.Forms.Label lbBulletCount;
        private System.Windows.Forms.GroupBox groupBoxBoss;
        private System.Windows.Forms.Label lbLife;
        private System.Windows.Forms.Label lbDPS;
        private System.Windows.Forms.GroupBox groupBoxSourceUse;
        private System.Windows.Forms.Button btnCountStart;
        private System.Windows.Forms.Label lbMissCount;
        private System.Windows.Forms.Label lbBombCount;
        private System.Windows.Forms.Timer timerFloatWindow;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label sp1;
    }
}