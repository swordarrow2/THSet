namespace THSet {
    partial class floatWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(floatWindow));
            this.groupBoxOther = new System.Windows.Forms.GroupBox();
            this.lbBulletCount = new System.Windows.Forms.Label();
            this.btnKill = new System.Windows.Forms.Button();
            this.groupBoxBoss = new System.Windows.Forms.GroupBox();
            this.lbLife = new System.Windows.Forms.Label();
            this.lbDPS = new System.Windows.Forms.Label();
            this.groupBoxSourceUse = new System.Windows.Forms.GroupBox();
            this.btnCountStart = new System.Windows.Forms.Button();
            this.lbMissCount = new System.Windows.Forms.Label();
            this.lbBombCount = new System.Windows.Forms.Label();
            this.timerMissAndBomb = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            this.timerDPS = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBoxOther.SuspendLayout();
            this.groupBoxBoss.SuspendLayout();
            this.groupBoxSourceUse.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOther
            // 
            this.groupBoxOther.Controls.Add(this.lbBulletCount);
            this.groupBoxOther.Location = new System.Drawing.Point(92, 70);
            this.groupBoxOther.Name = "groupBoxOther";
            this.groupBoxOther.Size = new System.Drawing.Size(82, 34);
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
            // 
            // btnKill
            // 
            this.btnKill.BackColor = System.Drawing.Color.Transparent;
            this.btnKill.Location = new System.Drawing.Point(92, 106);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(82, 23);
            this.btnKill.TabIndex = 21;
            this.btnKill.Text = "自爆";
            this.btnKill.UseVisualStyleBackColor = false;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click_1);
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
            // 
            // lbDPS
            // 
            this.lbDPS.AutoSize = true;
            this.lbDPS.Location = new System.Drawing.Point(7, 41);
            this.lbDPS.Name = "lbDPS";
            this.lbDPS.Size = new System.Drawing.Size(29, 12);
            this.lbDPS.TabIndex = 22;
            this.lbDPS.Text = "DPS:";
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
            // 
            // lbBombCount
            // 
            this.lbBombCount.AutoSize = true;
            this.lbBombCount.Location = new System.Drawing.Point(6, 33);
            this.lbBombCount.Name = "lbBombCount";
            this.lbBombCount.Size = new System.Drawing.Size(95, 12);
            this.lbBombCount.TabIndex = 15;
            this.lbBombCount.Text = "bomb次数:未使用";
            // 
            // timerMissAndBomb
            // 
            this.timerMissAndBomb.Enabled = true;
            this.timerMissAndBomb.Tick += new System.EventHandler(this.timerMissAndBomb_Tick);
            // 
            // timerEnemy
            // 
            this.timerEnemy.Enabled = true;
            this.timerEnemy.Tick += new System.EventHandler(this.timerEnemy_Tick);
            // 
            // timerDPS
            // 
            this.timerDPS.Enabled = true;
            this.timerDPS.Interval = 1000;
            this.timerDPS.Tick += new System.EventHandler(this.timerDPS_Tick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(12, 135);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "返回主窗体";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // floatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(187, 169);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.groupBoxOther);
            this.Controls.Add(this.groupBoxBoss);
            this.Controls.Add(this.groupBoxSourceUse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "floatWindow";
            this.Text = "发发发";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.setBG);
            this.Load += new System.EventHandler(this.frmTopMost_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmTopMost_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmTopMost_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmTopMost_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmTopMost_MouseUp);
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
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Label lbBulletCount;
        private System.Windows.Forms.GroupBox groupBoxBoss;
        private System.Windows.Forms.Label lbLife;
        private System.Windows.Forms.Label lbDPS;
        private System.Windows.Forms.GroupBox groupBoxSourceUse;
        private System.Windows.Forms.Button btnCountStart;
        private System.Windows.Forms.Label lbMissCount;
        private System.Windows.Forms.Label lbBombCount;
        private System.Windows.Forms.Timer timerMissAndBomb;
        private System.Windows.Forms.Timer timerEnemy;
        private System.Windows.Forms.Timer timerDPS;
        private System.Windows.Forms.Button btnBack;
    }
}