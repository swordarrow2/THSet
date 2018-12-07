namespace THSet {
    partial class MainForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timerMissAndBomb = new System.Windows.Forms.Timer(this.components);
            this.lockPlayer = new System.Windows.Forms.CheckBox();
            this.lockBomb = new System.Windows.Forms.CheckBox();
            this.tbSpecial1 = new System.Windows.Forms.TextBox();
            this.btnSpecial1 = new System.Windows.Forms.Button();
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
            this.label19 = new System.Windows.Forms.Label();
            this.tbMaxPoint = new System.Windows.Forms.TextBox();
            this.btnMaxPoint = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.choice = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReadSpecial3 = new System.Windows.Forms.Button();
            this.btnReadSpecial2 = new System.Windows.Forms.Button();
            this.btnReadSpecial1 = new System.Windows.Forms.Button();
            this.lbSp3 = new System.Windows.Forms.Label();
            this.lbSp2 = new System.Windows.Forms.Label();
            this.tbSpecial3 = new System.Windows.Forms.TextBox();
            this.lbSp1 = new System.Windows.Forms.Label();
            this.btnSpecial3 = new System.Windows.Forms.Button();
            this.btnSpecial2 = new System.Windows.Forms.Button();
            this.tbSpecial2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbIMaxPoint = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbISp3 = new System.Windows.Forms.Label();
            this.tbISpecial1 = new System.Windows.Forms.TextBox();
            this.lbISp2 = new System.Windows.Forms.Label();
            this.btnISpecial1 = new System.Windows.Forms.Button();
            this.tbISpecial3 = new System.Windows.Forms.TextBox();
            this.lbISp1 = new System.Windows.Forms.Label();
            this.btnISpecial3 = new System.Windows.Forms.Button();
            this.btnISpecial2 = new System.Windows.Forms.Button();
            this.tbISpecial2 = new System.Windows.Forms.TextBox();
            this.btnIMaxPoint = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbIScore = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnIScore = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbIPower = new System.Windows.Forms.TextBox();
            this.tbIPlayer = new System.Windows.Forms.TextBox();
            this.btnIPower = new System.Windows.Forms.Button();
            this.btnIPlayer = new System.Windows.Forms.Button();
            this.tbIBombFragment = new System.Windows.Forms.TextBox();
            this.btnIBomb = new System.Windows.Forms.Button();
            this.btnIBombFragment = new System.Windows.Forms.Button();
            this.tbIBomb = new System.Windows.Forms.TextBox();
            this.tbIPlayerFragment = new System.Windows.Forms.TextBox();
            this.btnIPlayerFragment = new System.Windows.Forms.Button();
            this.showBug = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.note = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbBomb = new System.Windows.Forms.Label();
            this.lbMiss = new System.Windows.Forms.Label();
            this.trackBar_FPS = new System.Windows.Forms.TrackBar();
            this.tbFPS = new System.Windows.Forms.TextBox();
            this.lbFPS = new System.Windows.Forms.Label();
            this.btnFPS = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_FPS)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMissAndBomb
            // 
            this.timerMissAndBomb.Tick += new System.EventHandler(this.timerMissAndBomb_Tick);
            // 
            // lockPlayer
            // 
            this.lockPlayer.AutoSize = true;
            this.lockPlayer.Location = new System.Drawing.Point(4, 12);
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
            this.lockBomb.Location = new System.Drawing.Point(82, 12);
            this.lockBomb.Name = "lockBomb";
            this.lockBomb.Size = new System.Drawing.Size(72, 16);
            this.lockBomb.TabIndex = 1;
            this.lockBomb.Text = "无限bomb";
            this.lockBomb.UseVisualStyleBackColor = true;
            this.lockBomb.CheckedChanged += new System.EventHandler(this.lockBomb_CheckedChanged);
            // 
            // tbSpecial1
            // 
            this.tbSpecial1.Location = new System.Drawing.Point(62, 20);
            this.tbSpecial1.Name = "tbSpecial1";
            this.tbSpecial1.Size = new System.Drawing.Size(39, 21);
            this.tbSpecial1.TabIndex = 9;
            this.tbSpecial1.Text = "0";
            this.tbSpecial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSpecial1
            // 
            this.btnSpecial1.Location = new System.Drawing.Point(107, 20);
            this.btnSpecial1.Name = "btnSpecial1";
            this.btnSpecial1.Size = new System.Drawing.Size(41, 23);
            this.btnSpecial1.TabIndex = 8;
            this.btnSpecial1.Text = "修改";
            this.btnSpecial1.UseVisualStyleBackColor = true;
            this.btnSpecial1.Click += new System.EventHandler(this.btnSpecial1_Click);
            // 
            // tbPower
            // 
            this.tbPower.Location = new System.Drawing.Point(68, 114);
            this.tbPower.Name = "tbPower";
            this.tbPower.Size = new System.Drawing.Size(88, 21);
            this.tbPower.TabIndex = 7;
            this.tbPower.Text = "0";
            this.tbPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(162, 112);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(44, 23);
            this.btnPower.TabIndex = 6;
            this.btnPower.Text = "修改";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // tbBombFragment
            // 
            this.tbBombFragment.Location = new System.Drawing.Point(68, 87);
            this.tbBombFragment.Name = "tbBombFragment";
            this.tbBombFragment.Size = new System.Drawing.Size(88, 21);
            this.tbBombFragment.TabIndex = 5;
            this.tbBombFragment.Text = "0";
            this.tbBombFragment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBombFragment
            // 
            this.btnBombFragment.Location = new System.Drawing.Point(162, 85);
            this.btnBombFragment.Name = "btnBombFragment";
            this.btnBombFragment.Size = new System.Drawing.Size(44, 23);
            this.btnBombFragment.TabIndex = 4;
            this.btnBombFragment.Text = "修改";
            this.btnBombFragment.UseVisualStyleBackColor = true;
            this.btnBombFragment.Click += new System.EventHandler(this.btnBombFragment_Click);
            // 
            // tbPlayerFragment
            // 
            this.tbPlayerFragment.Location = new System.Drawing.Point(68, 33);
            this.tbPlayerFragment.Name = "tbPlayerFragment";
            this.tbPlayerFragment.Size = new System.Drawing.Size(88, 21);
            this.tbPlayerFragment.TabIndex = 3;
            this.tbPlayerFragment.Text = "0";
            this.tbPlayerFragment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPlayerFragment
            // 
            this.btnPlayerFragment.Location = new System.Drawing.Point(162, 31);
            this.btnPlayerFragment.Name = "btnPlayerFragment";
            this.btnPlayerFragment.Size = new System.Drawing.Size(44, 23);
            this.btnPlayerFragment.TabIndex = 2;
            this.btnPlayerFragment.Text = "修改";
            this.btnPlayerFragment.UseVisualStyleBackColor = true;
            this.btnPlayerFragment.Click += new System.EventHandler(this.btnPlayerFragment_Click);
            // 
            // tbBomb
            // 
            this.tbBomb.Location = new System.Drawing.Point(68, 60);
            this.tbBomb.Name = "tbBomb";
            this.tbBomb.Size = new System.Drawing.Size(88, 21);
            this.tbBomb.TabIndex = 3;
            this.tbBomb.Text = "0";
            this.tbBomb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBomb
            // 
            this.btnBomb.Location = new System.Drawing.Point(162, 58);
            this.btnBomb.Name = "btnBomb";
            this.btnBomb.Size = new System.Drawing.Size(44, 23);
            this.btnBomb.TabIndex = 2;
            this.btnBomb.Text = "修改";
            this.btnBomb.UseVisualStyleBackColor = true;
            this.btnBomb.Click += new System.EventHandler(this.btnBomb_Click);
            // 
            // tbPlayer
            // 
            this.tbPlayer.Location = new System.Drawing.Point(68, 6);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.Size = new System.Drawing.Size(88, 21);
            this.tbPlayer.TabIndex = 1;
            this.tbPlayer.Text = "0";
            this.tbPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPlayer
            // 
            this.btnPlayer.Location = new System.Drawing.Point(162, 6);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(44, 23);
            this.btnPlayer.TabIndex = 0;
            this.btnPlayer.Text = "修改";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 171);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 19;
            this.label19.Text = "最大得点";
            // 
            // tbMaxPoint
            // 
            this.tbMaxPoint.Location = new System.Drawing.Point(68, 168);
            this.tbMaxPoint.Name = "tbMaxPoint";
            this.tbMaxPoint.Size = new System.Drawing.Size(88, 21);
            this.tbMaxPoint.TabIndex = 18;
            this.tbMaxPoint.Text = "0";
            this.tbMaxPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMaxPoint
            // 
            this.btnMaxPoint.Location = new System.Drawing.Point(162, 166);
            this.btnMaxPoint.Name = "btnMaxPoint";
            this.btnMaxPoint.Size = new System.Drawing.Size(44, 23);
            this.btnMaxPoint.TabIndex = 17;
            this.btnMaxPoint.Text = "修改";
            this.btnMaxPoint.UseVisualStyleBackColor = true;
            this.btnMaxPoint.Click += new System.EventHandler(this.btnMaxPoint_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 16;
            this.label18.Text = "得分";
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(68, 141);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(88, 21);
            this.tbScore.TabIndex = 15;
            this.tbScore.Text = "0";
            this.tbScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(162, 139);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(44, 23);
            this.btnScore.TabIndex = 14;
            this.btnScore.Text = "修改";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // choice
            // 
            this.choice.AutoSize = true;
            this.choice.Location = new System.Drawing.Point(160, 12);
            this.choice.Name = "choice";
            this.choice.Size = new System.Drawing.Size(48, 16);
            this.choice.TabIndex = 13;
            this.choice.Text = "无敌";
            this.choice.UseVisualStyleBackColor = true;
            this.choice.CheckedChanged += new System.EventHandler(this.choice_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReadSpecial3);
            this.groupBox3.Controls.Add(this.btnReadSpecial2);
            this.groupBox3.Controls.Add(this.btnReadSpecial1);
            this.groupBox3.Controls.Add(this.lbSp3);
            this.groupBox3.Controls.Add(this.tbSpecial1);
            this.groupBox3.Controls.Add(this.lbSp2);
            this.groupBox3.Controls.Add(this.btnSpecial1);
            this.groupBox3.Controls.Add(this.tbSpecial3);
            this.groupBox3.Controls.Add(this.lbSp1);
            this.groupBox3.Controls.Add(this.btnSpecial3);
            this.groupBox3.Controls.Add(this.btnSpecial2);
            this.groupBox3.Controls.Add(this.tbSpecial2);
            this.groupBox3.Location = new System.Drawing.Point(6, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 106);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "特殊值";
            // 
            // btnReadSpecial3
            // 
            this.btnReadSpecial3.Location = new System.Drawing.Point(147, 74);
            this.btnReadSpecial3.Name = "btnReadSpecial3";
            this.btnReadSpecial3.Size = new System.Drawing.Size(41, 23);
            this.btnReadSpecial3.TabIndex = 18;
            this.btnReadSpecial3.Text = "读取";
            this.btnReadSpecial3.UseVisualStyleBackColor = true;
            this.btnReadSpecial3.Click += new System.EventHandler(this.btnReadSpecial3_Click);
            // 
            // btnReadSpecial2
            // 
            this.btnReadSpecial2.Location = new System.Drawing.Point(147, 47);
            this.btnReadSpecial2.Name = "btnReadSpecial2";
            this.btnReadSpecial2.Size = new System.Drawing.Size(41, 23);
            this.btnReadSpecial2.TabIndex = 17;
            this.btnReadSpecial2.Text = "读取";
            this.btnReadSpecial2.UseVisualStyleBackColor = true;
            this.btnReadSpecial2.Click += new System.EventHandler(this.btnReadSpecial2_Click);
            // 
            // btnReadSpecial1
            // 
            this.btnReadSpecial1.Location = new System.Drawing.Point(147, 20);
            this.btnReadSpecial1.Name = "btnReadSpecial1";
            this.btnReadSpecial1.Size = new System.Drawing.Size(41, 23);
            this.btnReadSpecial1.TabIndex = 16;
            this.btnReadSpecial1.Text = "读取";
            this.btnReadSpecial1.UseVisualStyleBackColor = true;
            this.btnReadSpecial1.Click += new System.EventHandler(this.btnReadSpecial1_Click);
            // 
            // lbSp3
            // 
            this.lbSp3.AutoSize = true;
            this.lbSp3.Location = new System.Drawing.Point(6, 77);
            this.lbSp3.Name = "lbSp3";
            this.lbSp3.Size = new System.Drawing.Size(41, 12);
            this.lbSp3.TabIndex = 15;
            this.lbSp3.Text = "不可用";
            // 
            // lbSp2
            // 
            this.lbSp2.AutoSize = true;
            this.lbSp2.Location = new System.Drawing.Point(6, 50);
            this.lbSp2.Name = "lbSp2";
            this.lbSp2.Size = new System.Drawing.Size(41, 12);
            this.lbSp2.TabIndex = 15;
            this.lbSp2.Text = "不可用";
            // 
            // tbSpecial3
            // 
            this.tbSpecial3.Location = new System.Drawing.Point(62, 74);
            this.tbSpecial3.Name = "tbSpecial3";
            this.tbSpecial3.Size = new System.Drawing.Size(39, 21);
            this.tbSpecial3.TabIndex = 14;
            this.tbSpecial3.Text = "0";
            this.tbSpecial3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbSp1
            // 
            this.lbSp1.AutoSize = true;
            this.lbSp1.Location = new System.Drawing.Point(6, 23);
            this.lbSp1.Name = "lbSp1";
            this.lbSp1.Size = new System.Drawing.Size(41, 12);
            this.lbSp1.TabIndex = 12;
            this.lbSp1.Text = "不可用";
            // 
            // btnSpecial3
            // 
            this.btnSpecial3.Location = new System.Drawing.Point(107, 74);
            this.btnSpecial3.Name = "btnSpecial3";
            this.btnSpecial3.Size = new System.Drawing.Size(41, 23);
            this.btnSpecial3.TabIndex = 13;
            this.btnSpecial3.Text = "修改";
            this.btnSpecial3.UseVisualStyleBackColor = true;
            this.btnSpecial3.Click += new System.EventHandler(this.btnSpecial3_Click);
            // 
            // btnSpecial2
            // 
            this.btnSpecial2.Location = new System.Drawing.Point(107, 47);
            this.btnSpecial2.Name = "btnSpecial2";
            this.btnSpecial2.Size = new System.Drawing.Size(41, 23);
            this.btnSpecial2.TabIndex = 13;
            this.btnSpecial2.Text = "修改";
            this.btnSpecial2.UseVisualStyleBackColor = true;
            this.btnSpecial2.Click += new System.EventHandler(this.btnSpecial2_Click);
            // 
            // tbSpecial2
            // 
            this.tbSpecial2.Location = new System.Drawing.Point(62, 47);
            this.tbSpecial2.Name = "tbSpecial2";
            this.tbSpecial2.Size = new System.Drawing.Size(39, 21);
            this.tbSpecial2.TabIndex = 14;
            this.tbSpecial2.Text = "0";
            this.tbSpecial2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "灵力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bomb碎片";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bomb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "残机碎片";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "残机";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 171);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 19;
            this.label22.Text = "最大得点";
            // 
            // tbIMaxPoint
            // 
            this.tbIMaxPoint.Location = new System.Drawing.Point(68, 168);
            this.tbIMaxPoint.Name = "tbIMaxPoint";
            this.tbIMaxPoint.Size = new System.Drawing.Size(88, 21);
            this.tbIMaxPoint.TabIndex = 18;
            this.tbIMaxPoint.Text = "0";
            this.tbIMaxPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbISp3);
            this.groupBox4.Controls.Add(this.tbISpecial1);
            this.groupBox4.Controls.Add(this.lbISp2);
            this.groupBox4.Controls.Add(this.btnISpecial1);
            this.groupBox4.Controls.Add(this.tbISpecial3);
            this.groupBox4.Controls.Add(this.lbISp1);
            this.groupBox4.Controls.Add(this.btnISpecial3);
            this.groupBox4.Controls.Add(this.btnISpecial2);
            this.groupBox4.Controls.Add(this.tbISpecial2);
            this.groupBox4.Location = new System.Drawing.Point(6, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 106);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "特殊值";
            // 
            // lbISp3
            // 
            this.lbISp3.AutoSize = true;
            this.lbISp3.Location = new System.Drawing.Point(6, 77);
            this.lbISp3.Name = "lbISp3";
            this.lbISp3.Size = new System.Drawing.Size(41, 12);
            this.lbISp3.TabIndex = 15;
            this.lbISp3.Text = "不可用";
            // 
            // tbISpecial1
            // 
            this.tbISpecial1.Location = new System.Drawing.Point(62, 20);
            this.tbISpecial1.Name = "tbISpecial1";
            this.tbISpecial1.Size = new System.Drawing.Size(39, 21);
            this.tbISpecial1.TabIndex = 9;
            this.tbISpecial1.Text = "0";
            this.tbISpecial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbISp2
            // 
            this.lbISp2.AutoSize = true;
            this.lbISp2.Location = new System.Drawing.Point(6, 50);
            this.lbISp2.Name = "lbISp2";
            this.lbISp2.Size = new System.Drawing.Size(41, 12);
            this.lbISp2.TabIndex = 15;
            this.lbISp2.Text = "不可用";
            // 
            // btnISpecial1
            // 
            this.btnISpecial1.Location = new System.Drawing.Point(107, 20);
            this.btnISpecial1.Name = "btnISpecial1";
            this.btnISpecial1.Size = new System.Drawing.Size(41, 23);
            this.btnISpecial1.TabIndex = 8;
            this.btnISpecial1.Text = "修改";
            this.btnISpecial1.UseVisualStyleBackColor = true;
            this.btnISpecial1.Click += new System.EventHandler(this.btnISpecial1_Click);
            // 
            // tbISpecial3
            // 
            this.tbISpecial3.Location = new System.Drawing.Point(62, 74);
            this.tbISpecial3.Name = "tbISpecial3";
            this.tbISpecial3.Size = new System.Drawing.Size(39, 21);
            this.tbISpecial3.TabIndex = 14;
            this.tbISpecial3.Text = "0";
            this.tbISpecial3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbISp1
            // 
            this.lbISp1.AutoSize = true;
            this.lbISp1.Location = new System.Drawing.Point(6, 23);
            this.lbISp1.Name = "lbISp1";
            this.lbISp1.Size = new System.Drawing.Size(41, 12);
            this.lbISp1.TabIndex = 12;
            this.lbISp1.Text = "不可用";
            // 
            // btnISpecial3
            // 
            this.btnISpecial3.Location = new System.Drawing.Point(107, 74);
            this.btnISpecial3.Name = "btnISpecial3";
            this.btnISpecial3.Size = new System.Drawing.Size(41, 23);
            this.btnISpecial3.TabIndex = 13;
            this.btnISpecial3.Text = "修改";
            this.btnISpecial3.UseVisualStyleBackColor = true;
            this.btnISpecial3.Click += new System.EventHandler(this.btnISpecial3_Click);
            // 
            // btnISpecial2
            // 
            this.btnISpecial2.Location = new System.Drawing.Point(107, 47);
            this.btnISpecial2.Name = "btnISpecial2";
            this.btnISpecial2.Size = new System.Drawing.Size(41, 23);
            this.btnISpecial2.TabIndex = 13;
            this.btnISpecial2.Text = "修改";
            this.btnISpecial2.UseVisualStyleBackColor = true;
            this.btnISpecial2.Click += new System.EventHandler(this.btnISpecial2_Click);
            // 
            // tbISpecial2
            // 
            this.tbISpecial2.Location = new System.Drawing.Point(62, 47);
            this.tbISpecial2.Name = "tbISpecial2";
            this.tbISpecial2.Size = new System.Drawing.Size(39, 21);
            this.tbISpecial2.TabIndex = 14;
            this.tbISpecial2.Text = "0";
            this.tbISpecial2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIMaxPoint
            // 
            this.btnIMaxPoint.Location = new System.Drawing.Point(162, 166);
            this.btnIMaxPoint.Name = "btnIMaxPoint";
            this.btnIMaxPoint.Size = new System.Drawing.Size(44, 23);
            this.btnIMaxPoint.TabIndex = 17;
            this.btnIMaxPoint.Text = "修改";
            this.btnIMaxPoint.UseVisualStyleBackColor = true;
            this.btnIMaxPoint.Click += new System.EventHandler(this.btnIMaxPoint_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "灵力";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 16;
            this.label21.Text = "得分";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "Bomb碎片";
            // 
            // tbIScore
            // 
            this.tbIScore.Location = new System.Drawing.Point(68, 141);
            this.tbIScore.Name = "tbIScore";
            this.tbIScore.Size = new System.Drawing.Size(88, 21);
            this.tbIScore.TabIndex = 15;
            this.tbIScore.Text = "0";
            this.tbIScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "Bomb";
            // 
            // btnIScore
            // 
            this.btnIScore.Location = new System.Drawing.Point(162, 139);
            this.btnIScore.Name = "btnIScore";
            this.btnIScore.Size = new System.Drawing.Size(44, 23);
            this.btnIScore.TabIndex = 14;
            this.btnIScore.Text = "修改";
            this.btnIScore.UseVisualStyleBackColor = true;
            this.btnIScore.Click += new System.EventHandler(this.btnIScore_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 11;
            this.label15.Text = "残机碎片";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 10;
            this.label16.Text = "残机";
            // 
            // tbIPower
            // 
            this.tbIPower.Location = new System.Drawing.Point(68, 114);
            this.tbIPower.Name = "tbIPower";
            this.tbIPower.Size = new System.Drawing.Size(88, 21);
            this.tbIPower.TabIndex = 7;
            this.tbIPower.Text = "0";
            this.tbIPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbIPlayer
            // 
            this.tbIPlayer.Location = new System.Drawing.Point(68, 6);
            this.tbIPlayer.Name = "tbIPlayer";
            this.tbIPlayer.Size = new System.Drawing.Size(88, 21);
            this.tbIPlayer.TabIndex = 1;
            this.tbIPlayer.Text = "0";
            this.tbIPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIPower
            // 
            this.btnIPower.Location = new System.Drawing.Point(162, 112);
            this.btnIPower.Name = "btnIPower";
            this.btnIPower.Size = new System.Drawing.Size(44, 23);
            this.btnIPower.TabIndex = 6;
            this.btnIPower.Text = "修改";
            this.btnIPower.UseVisualStyleBackColor = true;
            this.btnIPower.Click += new System.EventHandler(this.btnIPower_Click);
            // 
            // btnIPlayer
            // 
            this.btnIPlayer.Location = new System.Drawing.Point(162, 6);
            this.btnIPlayer.Name = "btnIPlayer";
            this.btnIPlayer.Size = new System.Drawing.Size(44, 23);
            this.btnIPlayer.TabIndex = 0;
            this.btnIPlayer.Text = "修改";
            this.btnIPlayer.UseVisualStyleBackColor = true;
            this.btnIPlayer.Click += new System.EventHandler(this.btnIPlayer_Click);
            // 
            // tbIBombFragment
            // 
            this.tbIBombFragment.Location = new System.Drawing.Point(68, 87);
            this.tbIBombFragment.Name = "tbIBombFragment";
            this.tbIBombFragment.Size = new System.Drawing.Size(88, 21);
            this.tbIBombFragment.TabIndex = 5;
            this.tbIBombFragment.Text = "0";
            this.tbIBombFragment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIBomb
            // 
            this.btnIBomb.Location = new System.Drawing.Point(162, 58);
            this.btnIBomb.Name = "btnIBomb";
            this.btnIBomb.Size = new System.Drawing.Size(44, 23);
            this.btnIBomb.TabIndex = 2;
            this.btnIBomb.Text = "修改";
            this.btnIBomb.UseVisualStyleBackColor = true;
            this.btnIBomb.Click += new System.EventHandler(this.btnIBomb_Click);
            // 
            // btnIBombFragment
            // 
            this.btnIBombFragment.Location = new System.Drawing.Point(162, 85);
            this.btnIBombFragment.Name = "btnIBombFragment";
            this.btnIBombFragment.Size = new System.Drawing.Size(44, 23);
            this.btnIBombFragment.TabIndex = 4;
            this.btnIBombFragment.Text = "修改";
            this.btnIBombFragment.UseVisualStyleBackColor = true;
            this.btnIBombFragment.Click += new System.EventHandler(this.btnIBombFragment_Click);
            // 
            // tbIBomb
            // 
            this.tbIBomb.Location = new System.Drawing.Point(68, 60);
            this.tbIBomb.Name = "tbIBomb";
            this.tbIBomb.Size = new System.Drawing.Size(88, 21);
            this.tbIBomb.TabIndex = 3;
            this.tbIBomb.Text = "0";
            this.tbIBomb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbIPlayerFragment
            // 
            this.tbIPlayerFragment.Location = new System.Drawing.Point(68, 33);
            this.tbIPlayerFragment.Name = "tbIPlayerFragment";
            this.tbIPlayerFragment.Size = new System.Drawing.Size(88, 21);
            this.tbIPlayerFragment.TabIndex = 3;
            this.tbIPlayerFragment.Text = "0";
            this.tbIPlayerFragment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIPlayerFragment
            // 
            this.btnIPlayerFragment.Location = new System.Drawing.Point(162, 31);
            this.btnIPlayerFragment.Name = "btnIPlayerFragment";
            this.btnIPlayerFragment.Size = new System.Drawing.Size(44, 23);
            this.btnIPlayerFragment.TabIndex = 2;
            this.btnIPlayerFragment.Text = "修改";
            this.btnIPlayerFragment.UseVisualStyleBackColor = true;
            this.btnIPlayerFragment.Click += new System.EventHandler(this.btnIPlayerFragment_Click);
            // 
            // showBug
            // 
            this.showBug.Location = new System.Drawing.Point(159, 345);
            this.showBug.Name = "showBug";
            this.showBug.Size = new System.Drawing.Size(58, 23);
            this.showBug.TabIndex = 14;
            this.showBug.Text = "游戏bug";
            this.showBug.UseVisualStyleBackColor = true;
            this.showBug.Click += new System.EventHandler(this.showBug_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "关于特殊值";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(88, 345);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(64, 23);
            this.note.TabIndex = 16;
            this.note.Text = "使用说明";
            this.note.UseVisualStyleBackColor = true;
            this.note.Click += new System.EventHandler(this.note_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(220, 332);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.tbMaxPoint);
            this.tabPage1.Controls.Add(this.btnPlayerFragment);
            this.tabPage1.Controls.Add(this.btnMaxPoint);
            this.tabPage1.Controls.Add(this.tbPlayerFragment);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.tbBomb);
            this.tabPage1.Controls.Add(this.tbScore);
            this.tabPage1.Controls.Add(this.btnBombFragment);
            this.tabPage1.Controls.Add(this.btnScore);
            this.tabPage1.Controls.Add(this.btnBomb);
            this.tabPage1.Controls.Add(this.tbBombFragment);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btnPlayer);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnPower);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbPlayer);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbPower);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(212, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "即时修改";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbIMaxPoint);
            this.tabPage2.Controls.Add(this.btnIPlayerFragment);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.tbIPlayerFragment);
            this.tabPage2.Controls.Add(this.btnIMaxPoint);
            this.tabPage2.Controls.Add(this.tbIBomb);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnIBombFragment);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.btnIBomb);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tbIBombFragment);
            this.tabPage2.Controls.Add(this.tbIScore);
            this.tabPage2.Controls.Add(this.btnIPlayer);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btnIPower);
            this.tabPage2.Controls.Add(this.btnIScore);
            this.tabPage2.Controls.Add(this.tbIPlayer);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.tbIPower);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(212, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Init";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnReset);
            this.tabPage3.Controls.Add(this.lbBomb);
            this.tabPage3.Controls.Add(this.lbMiss);
            this.tabPage3.Controls.Add(this.lockBomb);
            this.tabPage3.Controls.Add(this.choice);
            this.tabPage3.Controls.Add(this.trackBar_FPS);
            this.tabPage3.Controls.Add(this.lockPlayer);
            this.tabPage3.Controls.Add(this.tbFPS);
            this.tabPage3.Controls.Add(this.lbFPS);
            this.tabPage3.Controls.Add(this.btnFPS);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(212, 306);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "其它修改";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbBomb
            // 
            this.lbBomb.AutoSize = true;
            this.lbBomb.Location = new System.Drawing.Point(116, 100);
            this.lbBomb.Name = "lbBomb";
            this.lbBomb.Size = new System.Drawing.Size(53, 12);
            this.lbBomb.TabIndex = 15;
            this.lbBomb.Text = "bomb次数";
            // 
            // lbMiss
            // 
            this.lbMiss.AutoSize = true;
            this.lbMiss.Location = new System.Drawing.Point(7, 100);
            this.lbMiss.Name = "lbMiss";
            this.lbMiss.Size = new System.Drawing.Size(53, 12);
            this.lbMiss.TabIndex = 14;
            this.lbMiss.Text = "miss次数";
            // 
            // trackBar_FPS
            // 
            this.trackBar_FPS.LargeChange = 30;
            this.trackBar_FPS.Location = new System.Drawing.Point(1, 63);
            this.trackBar_FPS.Maximum = 180;
            this.trackBar_FPS.Minimum = 60;
            this.trackBar_FPS.Name = "trackBar_FPS";
            this.trackBar_FPS.Size = new System.Drawing.Size(205, 45);
            this.trackBar_FPS.SmallChange = 5;
            this.trackBar_FPS.TabIndex = 3;
            this.trackBar_FPS.TickFrequency = 5;
            this.trackBar_FPS.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_FPS.Value = 60;
            this.trackBar_FPS.Scroll += new System.EventHandler(this.trackBar_FPS_Scroll);
            // 
            // tbFPS
            // 
            this.tbFPS.Location = new System.Drawing.Point(94, 36);
            this.tbFPS.Name = "tbFPS";
            this.tbFPS.Size = new System.Drawing.Size(49, 21);
            this.tbFPS.TabIndex = 2;
            this.tbFPS.Text = "60";
            this.tbFPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbFPS
            // 
            this.lbFPS.AutoSize = true;
            this.lbFPS.Location = new System.Drawing.Point(5, 39);
            this.lbFPS.Name = "lbFPS";
            this.lbFPS.Size = new System.Drawing.Size(83, 12);
            this.lbFPS.TabIndex = 1;
            this.lbFPS.Text = "游戏帧率(FPS)";
            // 
            // btnFPS
            // 
            this.btnFPS.Location = new System.Drawing.Point(149, 34);
            this.btnFPS.Name = "btnFPS";
            this.btnFPS.Size = new System.Drawing.Size(59, 23);
            this.btnFPS.TabIndex = 0;
            this.btnFPS.Text = "修改";
            this.btnFPS.UseVisualStyleBackColor = true;
            this.btnFPS.Click += new System.EventHandler(this.btnFPS_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(205, 23);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(231, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.note);
            this.Controls.Add(this.showBug);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_FPS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox lockPlayer;
        private System.Windows.Forms.CheckBox lockBomb;
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
        private System.Windows.Forms.TextBox tbSpecial1;
        private System.Windows.Forms.Button btnSpecial1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbSp3;
        private System.Windows.Forms.Label lbSp2;
        private System.Windows.Forms.TextBox tbSpecial3;
        private System.Windows.Forms.Label lbSp1;
        private System.Windows.Forms.Button btnSpecial3;
        private System.Windows.Forms.Button btnSpecial2;
        private System.Windows.Forms.TextBox tbSpecial2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbISp3;
        private System.Windows.Forms.TextBox tbISpecial1;
        private System.Windows.Forms.Label lbISp2;
        private System.Windows.Forms.Button btnISpecial1;
        private System.Windows.Forms.TextBox tbISpecial3;
        private System.Windows.Forms.Label lbISp1;
        private System.Windows.Forms.Button btnISpecial3;
        private System.Windows.Forms.Button btnISpecial2;
        private System.Windows.Forms.TextBox tbISpecial2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbIPower;
        private System.Windows.Forms.TextBox tbIPlayer;
        private System.Windows.Forms.Button btnIPower;
        private System.Windows.Forms.Button btnIPlayer;
        private System.Windows.Forms.TextBox tbIBombFragment;
        private System.Windows.Forms.Button btnIBomb;
        private System.Windows.Forms.Button btnIBombFragment;
        private System.Windows.Forms.TextBox tbIBomb;
        private System.Windows.Forms.TextBox tbIPlayerFragment;
        private System.Windows.Forms.Button btnIPlayerFragment;
        private System.Windows.Forms.CheckBox choice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbMaxPoint;
        private System.Windows.Forms.Button btnMaxPoint;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbIMaxPoint;
        private System.Windows.Forms.Button btnIMaxPoint;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbIScore;
        private System.Windows.Forms.Button btnIScore;
        private System.Windows.Forms.Button btnReadSpecial3;
        private System.Windows.Forms.Button btnReadSpecial2;
        private System.Windows.Forms.Button btnReadSpecial1;
        private System.Windows.Forms.Button showBug;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button note;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnFPS;
        private System.Windows.Forms.TextBox tbFPS;
        private System.Windows.Forms.Label lbFPS;
        private System.Windows.Forms.TrackBar trackBar_FPS;
        private System.Windows.Forms.Label lbBomb;
        private System.Windows.Forms.Label lbMiss;
        private System.Windows.Forms.Timer timerMissAndBomb;
        private System.Windows.Forms.Button btnReset;
    }
}

