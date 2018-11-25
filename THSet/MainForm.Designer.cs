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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSpecial3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSpecial3 = new System.Windows.Forms.Button();
            this.btnSpecial2 = new System.Windows.Forms.Button();
            this.tbSpecial2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSpecialTip = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbIMaxPoint = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbISpecial1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnISpecial1 = new System.Windows.Forms.Button();
            this.tbISpecial3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lockPlayer
            // 
            this.lockPlayer.AutoSize = true;
            this.lockPlayer.Location = new System.Drawing.Point(6, 20);
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
            this.lockBomb.Location = new System.Drawing.Point(84, 20);
            this.lockBomb.Name = "lockBomb";
            this.lockBomb.Size = new System.Drawing.Size(72, 16);
            this.lockBomb.TabIndex = 1;
            this.lockBomb.Text = "无限bomb";
            this.lockBomb.UseVisualStyleBackColor = true;
            this.lockBomb.CheckedChanged += new System.EventHandler(this.lockBomb_CheckedChanged);
            // 
            // tbSpecial1
            // 
            this.tbSpecial1.Location = new System.Drawing.Point(39, 20);
            this.tbSpecial1.Name = "tbSpecial1";
            this.tbSpecial1.Size = new System.Drawing.Size(62, 21);
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
            this.tbPower.Location = new System.Drawing.Point(68, 152);
            this.tbPower.Name = "tbPower";
            this.tbPower.Size = new System.Drawing.Size(88, 21);
            this.tbPower.TabIndex = 7;
            this.tbPower.Text = "100";
            this.tbPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(162, 150);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(44, 23);
            this.btnPower.TabIndex = 6;
            this.btnPower.Text = "修改";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // tbBombFragment
            // 
            this.tbBombFragment.Location = new System.Drawing.Point(68, 125);
            this.tbBombFragment.Name = "tbBombFragment";
            this.tbBombFragment.Size = new System.Drawing.Size(88, 21);
            this.tbBombFragment.TabIndex = 5;
            this.tbBombFragment.Text = "0";
            this.tbBombFragment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBombFragment
            // 
            this.btnBombFragment.Location = new System.Drawing.Point(162, 123);
            this.btnBombFragment.Name = "btnBombFragment";
            this.btnBombFragment.Size = new System.Drawing.Size(44, 23);
            this.btnBombFragment.TabIndex = 4;
            this.btnBombFragment.Text = "修改";
            this.btnBombFragment.UseVisualStyleBackColor = true;
            this.btnBombFragment.Click += new System.EventHandler(this.btnBombFragment_Click);
            // 
            // tbPlayerFragment
            // 
            this.tbPlayerFragment.Location = new System.Drawing.Point(68, 71);
            this.tbPlayerFragment.Name = "tbPlayerFragment";
            this.tbPlayerFragment.Size = new System.Drawing.Size(88, 21);
            this.tbPlayerFragment.TabIndex = 3;
            this.tbPlayerFragment.Text = "0";
            this.tbPlayerFragment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPlayerFragment
            // 
            this.btnPlayerFragment.Location = new System.Drawing.Point(162, 69);
            this.btnPlayerFragment.Name = "btnPlayerFragment";
            this.btnPlayerFragment.Size = new System.Drawing.Size(44, 23);
            this.btnPlayerFragment.TabIndex = 2;
            this.btnPlayerFragment.Text = "修改";
            this.btnPlayerFragment.UseVisualStyleBackColor = true;
            this.btnPlayerFragment.Click += new System.EventHandler(this.btnPlayerFragment_Click);
            // 
            // tbBomb
            // 
            this.tbBomb.Location = new System.Drawing.Point(68, 98);
            this.tbBomb.Name = "tbBomb";
            this.tbBomb.Size = new System.Drawing.Size(88, 21);
            this.tbBomb.TabIndex = 3;
            this.tbBomb.Text = "3";
            this.tbBomb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBomb
            // 
            this.btnBomb.Location = new System.Drawing.Point(162, 96);
            this.btnBomb.Name = "btnBomb";
            this.btnBomb.Size = new System.Drawing.Size(44, 23);
            this.btnBomb.TabIndex = 2;
            this.btnBomb.Text = "修改";
            this.btnBomb.UseVisualStyleBackColor = true;
            this.btnBomb.Click += new System.EventHandler(this.btnBomb_Click);
            // 
            // tbPlayer
            // 
            this.tbPlayer.Location = new System.Drawing.Point(68, 44);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.Size = new System.Drawing.Size(88, 21);
            this.tbPlayer.TabIndex = 1;
            this.tbPlayer.Text = "2";
            this.tbPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPlayer
            // 
            this.btnPlayer.Location = new System.Drawing.Point(162, 42);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(44, 23);
            this.btnPlayer.TabIndex = 0;
            this.btnPlayer.Text = "修改";
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.tbMaxPoint);
            this.groupBox2.Controls.Add(this.btnMaxPoint);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.tbScore);
            this.groupBox2.Controls.Add(this.btnScore);
            this.groupBox2.Controls.Add(this.choice);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lockBomb);
            this.groupBox2.Controls.Add(this.lockPlayer);
            this.groupBox2.Controls.Add(this.tbPower);
            this.groupBox2.Controls.Add(this.tbPlayer);
            this.groupBox2.Controls.Add(this.btnPower);
            this.groupBox2.Controls.Add(this.btnPlayer);
            this.groupBox2.Controls.Add(this.tbBombFragment);
            this.groupBox2.Controls.Add(this.btnBomb);
            this.groupBox2.Controls.Add(this.btnBombFragment);
            this.groupBox2.Controls.Add(this.tbBomb);
            this.groupBox2.Controls.Add(this.tbPlayerFragment);
            this.groupBox2.Controls.Add(this.btnPlayerFragment);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 349);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前值设置";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 209);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 19;
            this.label19.Text = "最大得点";
            // 
            // tbMaxPoint
            // 
            this.tbMaxPoint.Location = new System.Drawing.Point(68, 206);
            this.tbMaxPoint.Name = "tbMaxPoint";
            this.tbMaxPoint.Size = new System.Drawing.Size(88, 21);
            this.tbMaxPoint.TabIndex = 18;
            this.tbMaxPoint.Text = "10000";
            this.tbMaxPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMaxPoint
            // 
            this.btnMaxPoint.Location = new System.Drawing.Point(162, 204);
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
            this.label18.Location = new System.Drawing.Point(6, 182);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 16;
            this.label18.Text = "得分";
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(68, 179);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(88, 21);
            this.tbScore.TabIndex = 15;
            this.tbScore.Text = "10";
            this.tbScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(162, 177);
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
            this.choice.Location = new System.Drawing.Point(156, 19);
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
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbSpecial1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnSpecial1);
            this.groupBox3.Controls.Add(this.tbSpecial3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnSpecial3);
            this.groupBox3.Controls.Add(this.btnSpecial2);
            this.groupBox3.Controls.Add(this.tbSpecial2);
            this.groupBox3.Location = new System.Drawing.Point(8, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 106);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "值3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "值2";
            // 
            // tbSpecial3
            // 
            this.tbSpecial3.Location = new System.Drawing.Point(39, 74);
            this.tbSpecial3.Name = "tbSpecial3";
            this.tbSpecial3.Size = new System.Drawing.Size(62, 21);
            this.tbSpecial3.TabIndex = 14;
            this.tbSpecial3.Text = "0";
            this.tbSpecial3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "值1";
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
            this.tbSpecial2.Location = new System.Drawing.Point(39, 47);
            this.tbSpecial2.Name = "tbSpecial2";
            this.tbSpecial2.Size = new System.Drawing.Size(62, 21);
            this.tbSpecial2.TabIndex = 14;
            this.tbSpecial2.Text = "0";
            this.tbSpecial2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "灵力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bomb碎片";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bomb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "残机碎片";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "残机";
            // 
            // lbSpecialTip
            // 
            this.lbSpecialTip.AutoSize = true;
            this.lbSpecialTip.Location = new System.Drawing.Point(30, 370);
            this.lbSpecialTip.Name = "lbSpecialTip";
            this.lbSpecialTip.Size = new System.Drawing.Size(77, 12);
            this.lbSpecialTip.TabIndex = 16;
            this.lbSpecialTip.Text = "lbSpecialTip";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tbIMaxPoint);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnIMaxPoint);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbIScore);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnIScore);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tbIPower);
            this.groupBox1.Controls.Add(this.tbIPlayer);
            this.groupBox1.Controls.Add(this.btnIPower);
            this.groupBox1.Controls.Add(this.btnIPlayer);
            this.groupBox1.Controls.Add(this.tbIBombFragment);
            this.groupBox1.Controls.Add(this.btnIBomb);
            this.groupBox1.Controls.Add(this.btnIBombFragment);
            this.groupBox1.Controls.Add(this.tbIBomb);
            this.groupBox1.Controls.Add(this.tbIPlayerFragment);
            this.groupBox1.Controls.Add(this.btnIPlayerFragment);
            this.groupBox1.Location = new System.Drawing.Point(234, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 349);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "初始值设置";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 209);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 19;
            this.label22.Text = "最大得点";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 17;
            this.label17.Text = "THInit";
            // 
            // tbIMaxPoint
            // 
            this.tbIMaxPoint.Location = new System.Drawing.Point(68, 206);
            this.tbIMaxPoint.Name = "tbIMaxPoint";
            this.tbIMaxPoint.Size = new System.Drawing.Size(88, 21);
            this.tbIMaxPoint.TabIndex = 18;
            this.tbIMaxPoint.Text = "10000";
            this.tbIMaxPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tbISpecial1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btnISpecial1);
            this.groupBox4.Controls.Add(this.tbISpecial3);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.btnISpecial3);
            this.groupBox4.Controls.Add(this.btnISpecial2);
            this.groupBox4.Controls.Add(this.tbISpecial2);
            this.groupBox4.Location = new System.Drawing.Point(14, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 106);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "特殊值";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "值3";
            // 
            // tbISpecial1
            // 
            this.tbISpecial1.Location = new System.Drawing.Point(39, 20);
            this.tbISpecial1.Name = "tbISpecial1";
            this.tbISpecial1.Size = new System.Drawing.Size(62, 21);
            this.tbISpecial1.TabIndex = 9;
            this.tbISpecial1.Text = "0";
            this.tbISpecial1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "值2";
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
            this.tbISpecial3.Location = new System.Drawing.Point(39, 74);
            this.tbISpecial3.Name = "tbISpecial3";
            this.tbISpecial3.Size = new System.Drawing.Size(62, 21);
            this.tbISpecial3.TabIndex = 14;
            this.tbISpecial3.Text = "0";
            this.tbISpecial3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "值1";
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
            this.tbISpecial2.Location = new System.Drawing.Point(39, 47);
            this.tbISpecial2.Name = "tbISpecial2";
            this.tbISpecial2.Size = new System.Drawing.Size(62, 21);
            this.tbISpecial2.TabIndex = 14;
            this.tbISpecial2.Text = "0";
            this.tbISpecial2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIMaxPoint
            // 
            this.btnIMaxPoint.Location = new System.Drawing.Point(162, 204);
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
            this.label12.Location = new System.Drawing.Point(6, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "灵力";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 182);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 16;
            this.label21.Text = "得分";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "Bomb碎片";
            // 
            // tbIScore
            // 
            this.tbIScore.Location = new System.Drawing.Point(68, 179);
            this.tbIScore.Name = "tbIScore";
            this.tbIScore.Size = new System.Drawing.Size(88, 21);
            this.tbIScore.TabIndex = 15;
            this.tbIScore.Text = "10";
            this.tbIScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 12;
            this.label14.Text = "Bomb";
            // 
            // btnIScore
            // 
            this.btnIScore.Location = new System.Drawing.Point(162, 177);
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
            this.label15.Location = new System.Drawing.Point(6, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 11;
            this.label15.Text = "残机碎片";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 10;
            this.label16.Text = "残机";
            // 
            // tbIPower
            // 
            this.tbIPower.Location = new System.Drawing.Point(68, 147);
            this.tbIPower.Name = "tbIPower";
            this.tbIPower.Size = new System.Drawing.Size(88, 21);
            this.tbIPower.TabIndex = 7;
            this.tbIPower.Text = "100";
            this.tbIPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbIPlayer
            // 
            this.tbIPlayer.Location = new System.Drawing.Point(68, 39);
            this.tbIPlayer.Name = "tbIPlayer";
            this.tbIPlayer.Size = new System.Drawing.Size(88, 21);
            this.tbIPlayer.TabIndex = 1;
            this.tbIPlayer.Text = "2";
            this.tbIPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIPower
            // 
            this.btnIPower.Location = new System.Drawing.Point(162, 145);
            this.btnIPower.Name = "btnIPower";
            this.btnIPower.Size = new System.Drawing.Size(44, 23);
            this.btnIPower.TabIndex = 6;
            this.btnIPower.Text = "修改";
            this.btnIPower.UseVisualStyleBackColor = true;
            this.btnIPower.Click += new System.EventHandler(this.btnIPower_Click);
            // 
            // btnIPlayer
            // 
            this.btnIPlayer.Location = new System.Drawing.Point(162, 37);
            this.btnIPlayer.Name = "btnIPlayer";
            this.btnIPlayer.Size = new System.Drawing.Size(44, 23);
            this.btnIPlayer.TabIndex = 0;
            this.btnIPlayer.Text = "修改";
            this.btnIPlayer.UseVisualStyleBackColor = true;
            this.btnIPlayer.Click += new System.EventHandler(this.btnIPlayer_Click);
            // 
            // tbIBombFragment
            // 
            this.tbIBombFragment.Location = new System.Drawing.Point(68, 120);
            this.tbIBombFragment.Name = "tbIBombFragment";
            this.tbIBombFragment.Size = new System.Drawing.Size(88, 21);
            this.tbIBombFragment.TabIndex = 5;
            this.tbIBombFragment.Text = "0";
            this.tbIBombFragment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIBomb
            // 
            this.btnIBomb.Location = new System.Drawing.Point(162, 91);
            this.btnIBomb.Name = "btnIBomb";
            this.btnIBomb.Size = new System.Drawing.Size(44, 23);
            this.btnIBomb.TabIndex = 2;
            this.btnIBomb.Text = "修改";
            this.btnIBomb.UseVisualStyleBackColor = true;
            this.btnIBomb.Click += new System.EventHandler(this.btnIBomb_Click);
            // 
            // btnIBombFragment
            // 
            this.btnIBombFragment.Location = new System.Drawing.Point(162, 118);
            this.btnIBombFragment.Name = "btnIBombFragment";
            this.btnIBombFragment.Size = new System.Drawing.Size(44, 23);
            this.btnIBombFragment.TabIndex = 4;
            this.btnIBombFragment.Text = "修改";
            this.btnIBombFragment.UseVisualStyleBackColor = true;
            this.btnIBombFragment.Click += new System.EventHandler(this.btnIBombFragment_Click);
            // 
            // tbIBomb
            // 
            this.tbIBomb.Location = new System.Drawing.Point(68, 93);
            this.tbIBomb.Name = "tbIBomb";
            this.tbIBomb.Size = new System.Drawing.Size(88, 21);
            this.tbIBomb.TabIndex = 3;
            this.tbIBomb.Text = "3";
            this.tbIBomb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbIPlayerFragment
            // 
            this.tbIPlayerFragment.Location = new System.Drawing.Point(68, 66);
            this.tbIPlayerFragment.Name = "tbIPlayerFragment";
            this.tbIPlayerFragment.Size = new System.Drawing.Size(88, 21);
            this.tbIPlayerFragment.TabIndex = 3;
            this.tbIPlayerFragment.Text = "0";
            this.tbIPlayerFragment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIPlayerFragment
            // 
            this.btnIPlayerFragment.Location = new System.Drawing.Point(162, 64);
            this.btnIPlayerFragment.Name = "btnIPlayerFragment";
            this.btnIPlayerFragment.Size = new System.Drawing.Size(44, 23);
            this.btnIPlayerFragment.TabIndex = 2;
            this.btnIPlayerFragment.Text = "修改";
            this.btnIPlayerFragment.UseVisualStyleBackColor = true;
            this.btnIPlayerFragment.Click += new System.EventHandler(this.btnIPlayerFragment_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 391);
            this.Controls.Add(this.lbSpecialTip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSpecial3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSpecial3;
        private System.Windows.Forms.Button btnSpecial2;
        private System.Windows.Forms.TextBox tbSpecial2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbISpecial1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnISpecial1;
        private System.Windows.Forms.TextBox tbISpecial3;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.Label lbSpecialTip;
        private System.Windows.Forms.Label label17;
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
    }
}

