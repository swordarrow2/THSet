namespace THSet {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.lockPlayer = new System.Windows.Forms.CheckBox();
            this.lockBomb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPower = new System.Windows.Forms.TextBox();
            this.btnPower = new System.Windows.Forms.Button();
            this.tbBombFragment = new System.Windows.Forms.TextBox();
            this.btnBombFragment = new System.Windows.Forms.Button();
            this.tbPlayerFragment = new System.Windows.Forms.TextBox();
            this.btnPlayerFragment = new System.Windows.Forms.Button();
            this.tbBomb = new System.Windows.Forms.TextBox();
            this.btnBomb = new System.Windows.Forms.Button();
            this.tbPlayer = new System.Windows.Forms.TextBox();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.tbSeason = new System.Windows.Forms.TextBox();
            this.btnSeason = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lockPlayer
            // 
            this.lockPlayer.AutoSize = true;
            this.lockPlayer.Location = new System.Drawing.Point(12, 12);
            this.lockPlayer.Name = "lockPlayer";
            this.lockPlayer.Size = new System.Drawing.Size(72, 16);
            this.lockPlayer.TabIndex = 0;
            this.lockPlayer.Text = "无限残机";
            this.lockPlayer.UseVisualStyleBackColor = true;
            this.lockPlayer.CheckedChanged += new System.EventHandler(this.lockPlayer_CheckedChanged);
            // 
            // lockBomb
            // 
            this.lockBomb.AutoSize = true;
            this.lockBomb.Location = new System.Drawing.Point(12, 34);
            this.lockBomb.Name = "lockBomb";
            this.lockBomb.Size = new System.Drawing.Size(72, 16);
            this.lockBomb.TabIndex = 1;
            this.lockBomb.Text = "无限bomb";
            this.lockBomb.UseVisualStyleBackColor = true;
            this.lockBomb.CheckedChanged += new System.EventHandler(this.lockBomb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "player";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "bomb";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSeason);
            this.groupBox1.Controls.Add(this.btnSeason);
            this.groupBox1.Controls.Add(this.tbPower);
            this.groupBox1.Controls.Add(this.btnPower);
            this.groupBox1.Controls.Add(this.tbBombFragment);
            this.groupBox1.Controls.Add(this.btnBombFragment);
            this.groupBox1.Controls.Add(this.tbPlayerFragment);
            this.groupBox1.Controls.Add(this.btnPlayerFragment);
            this.groupBox1.Controls.Add(this.tbBomb);
            this.groupBox1.Controls.Add(this.btnBomb);
            this.groupBox1.Controls.Add(this.tbPlayer);
            this.groupBox1.Controls.Add(this.btnPlayer);
            this.groupBox1.Location = new System.Drawing.Point(258, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 207);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbPower
            // 
            this.tbPower.Location = new System.Drawing.Point(7, 142);
            this.tbPower.Name = "tbPower";
            this.tbPower.Size = new System.Drawing.Size(100, 21);
            this.tbPower.TabIndex = 7;
            this.tbPower.Text = "100";
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(113, 142);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(75, 23);
            this.btnPower.TabIndex = 6;
            this.btnPower.Text = "灵力";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // tbBombFragment
            // 
            this.tbBombFragment.Location = new System.Drawing.Point(7, 115);
            this.tbBombFragment.Name = "tbBombFragment";
            this.tbBombFragment.Size = new System.Drawing.Size(100, 21);
            this.tbBombFragment.TabIndex = 5;
            this.tbBombFragment.Text = "0";
            // 
            // btnBombFragment
            // 
            this.btnBombFragment.Location = new System.Drawing.Point(113, 115);
            this.btnBombFragment.Name = "btnBombFragment";
            this.btnBombFragment.Size = new System.Drawing.Size(75, 23);
            this.btnBombFragment.TabIndex = 4;
            this.btnBombFragment.Text = "bomb碎片";
            this.btnBombFragment.UseVisualStyleBackColor = true;
            this.btnBombFragment.Click += new System.EventHandler(this.btnBombFragment_Click);
            // 
            // tbPlayerFragment
            // 
            this.tbPlayerFragment.Location = new System.Drawing.Point(7, 61);
            this.tbPlayerFragment.Name = "tbPlayerFragment";
            this.tbPlayerFragment.Size = new System.Drawing.Size(100, 21);
            this.tbPlayerFragment.TabIndex = 3;
            this.tbPlayerFragment.Text = "0";
            // 
            // btnPlayerFragment
            // 
            this.btnPlayerFragment.Location = new System.Drawing.Point(113, 61);
            this.btnPlayerFragment.Name = "btnPlayerFragment";
            this.btnPlayerFragment.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerFragment.TabIndex = 2;
            this.btnPlayerFragment.Text = "残机碎片";
            this.btnPlayerFragment.UseVisualStyleBackColor = true;
            this.btnPlayerFragment.Click += new System.EventHandler(this.btnPlayerFragment_Click);
            // 
            // tbBomb
            // 
            this.tbBomb.Location = new System.Drawing.Point(7, 88);
            this.tbBomb.Name = "tbBomb";
            this.tbBomb.Size = new System.Drawing.Size(100, 21);
            this.tbBomb.TabIndex = 3;
            this.tbBomb.Text = "3";
            // 
            // btnBomb
            // 
            this.btnBomb.Location = new System.Drawing.Point(113, 88);
            this.btnBomb.Name = "btnBomb";
            this.btnBomb.Size = new System.Drawing.Size(75, 23);
            this.btnBomb.TabIndex = 2;
            this.btnBomb.Text = "bomb";
            this.btnBomb.UseVisualStyleBackColor = true;
            this.btnBomb.Click += new System.EventHandler(this.btnBomb_Click);
            // 
            // tbPlayer
            // 
            this.tbPlayer.Location = new System.Drawing.Point(7, 34);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.Size = new System.Drawing.Size(100, 21);
            this.tbPlayer.TabIndex = 1;
            this.tbPlayer.Text = "2";
            // 
            // btnPlayer
            // 
            this.btnPlayer.Location = new System.Drawing.Point(113, 34);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnPlayer.TabIndex = 0;
            this.btnPlayer.Text = "残机";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // tbSeason
            // 
            this.tbSeason.Location = new System.Drawing.Point(6, 169);
            this.tbSeason.Name = "tbSeason";
            this.tbSeason.Size = new System.Drawing.Size(100, 21);
            this.tbSeason.TabIndex = 9;
            this.tbSeason.Text = "1140";
            // 
            // btnSeason
            // 
            this.btnSeason.Location = new System.Drawing.Point(112, 169);
            this.btnSeason.Name = "btnSeason";
            this.btnSeason.Size = new System.Drawing.Size(75, 23);
            this.btnSeason.TabIndex = 8;
            this.btnSeason.Text = "季节槽";
            this.btnSeason.UseVisualStyleBackColor = true;
            this.btnSeason.Click += new System.EventHandler(this.btnSeason_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lockBomb);
            this.Controls.Add(this.lockPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox lockPlayer;
        private System.Windows.Forms.CheckBox lockBomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBombFragment;
        private System.Windows.Forms.Button btnBombFragment;
        private System.Windows.Forms.TextBox tbPlayerFragment;
        private System.Windows.Forms.Button btnPlayerFragment;
        private System.Windows.Forms.TextBox tbBomb;
        private System.Windows.Forms.Button btnBomb;
        private System.Windows.Forms.TextBox tbPlayer;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.TextBox tbPower;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.TextBox tbSeason;
        private System.Windows.Forms.Button btnSeason;
    }
}

