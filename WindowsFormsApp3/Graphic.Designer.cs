namespace WindowsFormsApp3
{
    partial class Graphic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.functionGraphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.xnValue = new System.Windows.Forms.TextBox();
            this.xkValue = new System.Windows.Forms.TextBox();
            this.xhValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.xhLabel = new System.Windows.Forms.Label();
            this.xkLabel = new System.Windows.Forms.Label();
            this.xnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.functionGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // functionGraphic
            // 
            this.functionGraphic.BorderlineWidth = 10;
            chartArea1.Name = "ChartArea1";
            this.functionGraphic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.functionGraphic.Legends.Add(legend1);
            this.functionGraphic.Location = new System.Drawing.Point(14, 15);
            this.functionGraphic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.functionGraphic.Name = "functionGraphic";
            this.functionGraphic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.functionGraphic.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Coral};
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.functionGraphic.Series.Add(series1);
            this.functionGraphic.Size = new System.Drawing.Size(841, 352);
            this.functionGraphic.TabIndex = 0;
            this.functionGraphic.Text = "chart1";
            // 
            // xnValue
            // 
            this.xnValue.ForeColor = System.Drawing.Color.Black;
            this.xnValue.Location = new System.Drawing.Point(97, 375);
            this.xnValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xnValue.Name = "xnValue";
            this.xnValue.Size = new System.Drawing.Size(163, 21);
            this.xnValue.TabIndex = 1;
            this.xnValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xkValue
            // 
            this.xkValue.ForeColor = System.Drawing.Color.Black;
            this.xkValue.Location = new System.Drawing.Point(97, 404);
            this.xkValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xkValue.Name = "xkValue";
            this.xkValue.Size = new System.Drawing.Size(163, 21);
            this.xkValue.TabIndex = 2;
            this.xkValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xhValue
            // 
            this.xhValue.ForeColor = System.Drawing.Color.Black;
            this.xhValue.Location = new System.Drawing.Point(97, 434);
            this.xhValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xhValue.Name = "xhValue";
            this.xhValue.Size = new System.Drawing.Size(163, 21);
            this.xhValue.TabIndex = 3;
            this.xhValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(700, 427);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xhLabel
            // 
            this.xhLabel.AutoSize = true;
            this.xhLabel.BackColor = System.Drawing.Color.White;
            this.xhLabel.Location = new System.Drawing.Point(12, 437);
            this.xhLabel.Name = "xhLabel";
            this.xhLabel.Size = new System.Drawing.Size(79, 16);
            this.xhLabel.TabIndex = 6;
            this.xhLabel.Text = "Значение Xh";
            // 
            // xkLabel
            // 
            this.xkLabel.AutoSize = true;
            this.xkLabel.BackColor = System.Drawing.Color.White;
            this.xkLabel.Location = new System.Drawing.Point(14, 407);
            this.xkLabel.Name = "xkLabel";
            this.xkLabel.Size = new System.Drawing.Size(77, 16);
            this.xkLabel.TabIndex = 5;
            this.xkLabel.Text = "Значение Xk";
            // 
            // xnLabel
            // 
            this.xnLabel.AutoSize = true;
            this.xnLabel.BackColor = System.Drawing.Color.White;
            this.xnLabel.Location = new System.Drawing.Point(12, 378);
            this.xnLabel.Name = "xnLabel";
            this.xnLabel.Size = new System.Drawing.Size(79, 16);
            this.xnLabel.TabIndex = 4;
            this.xnLabel.Text = "Значение Xn";
            // 
            // Graphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(869, 465);
            this.Controls.Add(this.xhLabel);
            this.Controls.Add(this.xkLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xnLabel);
            this.Controls.Add(this.xhValue);
            this.Controls.Add(this.xkValue);
            this.Controls.Add(this.xnValue);
            this.Controls.Add(this.functionGraphic);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Graphic";
            this.Text = "Graphic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Graphic_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.functionGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart functionGraphic;
        private System.Windows.Forms.TextBox xnValue;
        private System.Windows.Forms.TextBox xkValue;
        private System.Windows.Forms.TextBox xhValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label xhLabel;
        private System.Windows.Forms.Label xkLabel;
        private System.Windows.Forms.Label xnLabel;
    }
}

