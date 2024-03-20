namespace HelloCSharp024
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Gawi = new System.Windows.Forms.Button();
            this.button_Bawi = new System.Windows.Forms.Button();
            this.button_Bo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button_Gawi
            // 
            this.button_Gawi.Location = new System.Drawing.Point(13, 81);
            this.button_Gawi.Name = "button_Gawi";
            this.button_Gawi.Size = new System.Drawing.Size(75, 23);
            this.button_Gawi.TabIndex = 2;
            this.button_Gawi.Text = "가위";
            this.button_Gawi.UseVisualStyleBackColor = true;
            this.button_Gawi.Click += new System.EventHandler(this.button_Gawi_Click);
            // 
            // button_Bawi
            // 
            this.button_Bawi.Location = new System.Drawing.Point(122, 81);
            this.button_Bawi.Name = "button_Bawi";
            this.button_Bawi.Size = new System.Drawing.Size(75, 23);
            this.button_Bawi.TabIndex = 3;
            this.button_Bawi.Text = "바위";
            this.button_Bawi.UseVisualStyleBackColor = true;
            this.button_Bawi.Click += new System.EventHandler(this.button_Bawi_Click);
            // 
            // button_Bo
            // 
            this.button_Bo.Location = new System.Drawing.Point(230, 81);
            this.button_Bo.Name = "button_Bo";
            this.button_Bo.Size = new System.Drawing.Size(75, 23);
            this.button_Bo.TabIndex = 4;
            this.button_Bo.Text = "보";
            this.button_Bo.UseVisualStyleBackColor = true;
            this.button_Bo.Click += new System.EventHandler(this.button_Bo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Bo);
            this.Controls.Add(this.button_Bawi);
            this.Controls.Add(this.button_Gawi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Gawi;
        private System.Windows.Forms.Button button_Bawi;
        private System.Windows.Forms.Button button_Bo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

