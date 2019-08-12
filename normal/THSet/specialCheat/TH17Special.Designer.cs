namespace THSet.specialCheat {
    partial class TH17Special {
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.editText1 = new THSet.EditText();
            this.editText2 = new THSet.EditText();
            this.editText3 = new THSet.EditText();
            this.editText4 = new THSet.EditText();
            this.SuspendLayout();
            // 
            // editText1
            // 
            this.editText1.Location = new System.Drawing.Point(4, 4);
            this.editText1.Name = "editText1";
            this.editText1.number = 0;
            this.editText1.Size = new System.Drawing.Size(170, 34);
            this.editText1.TabIndex = 0;
            this.editText1.TabStop = false;
            // 
            // editText2
            // 
            this.editText2.Location = new System.Drawing.Point(4, 44);
            this.editText2.Name = "editText2";
            this.editText2.number = 0;
            this.editText2.Size = new System.Drawing.Size(170, 34);
            this.editText2.TabIndex = 1;
            this.editText2.TabStop = false;
            // 
            // editText3
            // 
            this.editText3.Location = new System.Drawing.Point(4, 84);
            this.editText3.Name = "editText3";
            this.editText3.number = 0;
            this.editText3.Size = new System.Drawing.Size(170, 34);
            this.editText3.TabIndex = 2;
            this.editText3.TabStop = false;
            // 
            // editText4
            // 
            this.editText4.Location = new System.Drawing.Point(4, 124);
            this.editText4.Name = "editText4";
            this.editText4.number = 0;
            this.editText4.Size = new System.Drawing.Size(170, 34);
            this.editText4.TabIndex = 3;
            this.editText4.TabStop = false;
            // 
            // TH17Special
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editText4);
            this.Controls.Add(this.editText3);
            this.Controls.Add(this.editText2);
            this.Controls.Add(this.editText1);
            this.Name = "TH17Special";
            this.Size = new System.Drawing.Size(170, 167);
            this.ResumeLayout(false);

        }

        #endregion

        private EditText editText1;
        private EditText editText2;
        private EditText editText3;
        private EditText editText4;
    }
}
