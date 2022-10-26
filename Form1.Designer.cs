
namespace MultiNeuron
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FAR_learn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRR_learn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAR_test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRR_test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAR_verif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRR_verif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 78);
            this.button3.TabIndex = 12;
            this.button3.Text = "Наказать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(528, 432);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(312, 64);
            this.listBox2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 78);
            this.button2.TabIndex = 10;
            this.button2.Text = "Открыть и распознать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(528, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 299);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(494, 78);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обучить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(494, 484);
            this.listBox1.TabIndex = 7;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(861, 12);
            this.chart.Name = "chart";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Blue;
            series3.LabelForeColor = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Обучение";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Верификация";
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(586, 581);
            this.chart.TabIndex = 16;
            this.chart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "(График ошибки тестирования и верификации";
            title2.Text = "График ошибки тестирования и верификации";
            this.chart.Titles.Add(title2);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FAR_learn,
            this.FRR_learn,
            this.FAR_test,
            this.FRR_test,
            this.FAR_verif,
            this.FRR_verif});
            this.dataGridView1.Location = new System.Drawing.Point(12, 612);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1435, 97);
            this.dataGridView1.TabIndex = 17;
            // 
            // FAR_learn
            // 
            this.FAR_learn.HeaderText = "FAR_learn";
            this.FAR_learn.MinimumWidth = 8;
            this.FAR_learn.Name = "FAR_learn";
            this.FAR_learn.Width = 150;
            // 
            // FRR_learn
            // 
            this.FRR_learn.HeaderText = "FRR_learn";
            this.FRR_learn.MinimumWidth = 8;
            this.FRR_learn.Name = "FRR_learn";
            this.FRR_learn.Width = 150;
            // 
            // FAR_test
            // 
            this.FAR_test.HeaderText = "FAR_test";
            this.FAR_test.MinimumWidth = 8;
            this.FAR_test.Name = "FAR_test";
            this.FAR_test.Width = 150;
            // 
            // FRR_test
            // 
            this.FRR_test.HeaderText = "FRR_test";
            this.FRR_test.MinimumWidth = 8;
            this.FRR_test.Name = "FRR_test";
            this.FRR_test.Width = 150;
            // 
            // FAR_verif
            // 
            this.FAR_verif.HeaderText = "FAR_verif";
            this.FAR_verif.MinimumWidth = 8;
            this.FAR_verif.Name = "FAR_verif";
            this.FAR_verif.Width = 150;
            // 
            // FRR_verif
            // 
            this.FRR_verif.HeaderText = "FRR_verif";
            this.FRR_verif.MinimumWidth = 8;
            this.FRR_verif.Name = "FRR_verif";
            this.FRR_verif.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 721);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAR_learn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRR_learn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAR_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRR_test;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAR_verif;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRR_verif;
    }
}

