namespace WindowsFormsApp1
{
    partial class Quality
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.all_button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fine_button = new System.Windows.Forms.Button();
            this.error_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(19, 352);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(458, 280);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(977, 221);
            this.dataGridView1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 80;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "2022-01-08",
            "2022-01-18",
            "2022-01-19",
            "2022-01-20",
            "2022-02-10",
            "2022-02-11",
            "2022-02-17",
            "2022-02-18",
            "2022-02-23",
            "2022-02-24",
            "2022-02-25",
            "2022-03-02",
            "2022-03-03",
            "2022-03-04",
            "2022-03-07",
            "2022-03-08",
            "2022-03-17",
            "2022-03-18",
            "2022-03-21",
            "2022-03-22",
            "2022-03-23",
            "2022-03-24",
            "2022-03-25",
            "2022-04-01",
            "2022-04-04",
            "2022-04-05",
            "2022-04-06",
            "2022-04-07",
            "2022-04-08",
            "2022-04-11",
            "2022-04-12",
            "2022-04-13",
            "2022-04-14",
            "2022-04-15",
            "2022-04-18",
            "2022-04-19",
            "2022-04-29",
            "2022-05-02",
            "2022-05-03",
            "2022-05-04",
            "2022-05-09",
            "2022-05-10",
            "2022-05-11",
            "2022-05-12",
            "2022-05-13",
            "2022-05-16",
            "2022-05-17",
            "2022-05-31",
            "2022-06-03",
            "2022-06-07",
            "2022-06-08",
            "2022-06-09",
            "2022-06-10",
            "2022-06-13",
            "2022-06-14",
            "2022-06-15",
            "2022-06-16",
            "2022-06-17",
            "2022-06-20",
            "2022-06-21",
            "2022-06-22",
            "2022-06-23",
            "2022-06-24",
            "2022-06-27",
            "2022-06-28",
            "2022-06-29",
            "2022-06-30",
            "2022-07-01",
            "2022-07-04",
            "2022-07-05",
            "2022-07-06",
            "2022-07-07",
            "2022-07-08",
            "2022-07-11",
            "2022-07-25",
            "2022-07-26",
            "2022-07-27",
            "2022-07-28",
            "2022-07-29",
            "2022-08-03"});
            this.comboBox1.Location = new System.Drawing.Point(93, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 20);
            this.comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "품질확인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "날짜 선택";
            // 
            // all_button
            // 
            this.all_button.Location = new System.Drawing.Point(279, 74);
            this.all_button.Name = "all_button";
            this.all_button.Size = new System.Drawing.Size(75, 23);
            this.all_button.TabIndex = 15;
            this.all_button.Text = "전체보기";
            this.all_button.UseVisualStyleBackColor = true;
            this.all_button.Click += new System.EventHandler(this.all_button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(498, 396);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(690, 236);
            this.dataGridView2.TabIndex = 16;
            // 
            // fine_button
            // 
            this.fine_button.Location = new System.Drawing.Point(651, 367);
            this.fine_button.Name = "fine_button";
            this.fine_button.Size = new System.Drawing.Size(75, 23);
            this.fine_button.TabIndex = 17;
            this.fine_button.Text = "양품보기";
            this.fine_button.UseVisualStyleBackColor = true;
            this.fine_button.Click += new System.EventHandler(this.fine_button_Click);
            // 
            // error_button
            // 
            this.error_button.Location = new System.Drawing.Point(802, 367);
            this.error_button.Name = "error_button";
            this.error_button.Size = new System.Drawing.Size(75, 23);
            this.error_button.TabIndex = 18;
            this.error_button.Text = "불량품보기";
            this.error_button.UseVisualStyleBackColor = true;
            this.error_button.Click += new System.EventHandler(this.error_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.error_button);
            this.Controls.Add(this.fine_button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.all_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "Quality";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quality";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button all_button;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button fine_button;
        private System.Windows.Forms.Button error_button;
        private System.Windows.Forms.Button button1;
    }
}