namespace WindowsFormsApp3
{
    partial class Function
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
            this.aLabel = new System.Windows.Forms.Label();
            this.aValue = new System.Windows.Forms.TextBox();
            this.xValue = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.functionImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.functionImage)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.BackColor = System.Drawing.Color.White;
            this.aLabel.ForeColor = System.Drawing.Color.Black;
            this.aLabel.Location = new System.Drawing.Point(12, 45);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(72, 16);
            this.aLabel.TabIndex = 1;
            this.aLabel.Text = "Значение A";
            // 
            // aValue
            // 
            this.aValue.BackColor = System.Drawing.Color.White;
            this.aValue.ForeColor = System.Drawing.Color.Black;
            this.aValue.Location = new System.Drawing.Point(90, 42);
            this.aValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aValue.MaxLength = 3;
            this.aValue.Name = "aValue";
            this.aValue.Size = new System.Drawing.Size(100, 21);
            this.aValue.TabIndex = 1;
            this.aValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xValue
            // 
            this.xValue.BackColor = System.Drawing.Color.White;
            this.xValue.ForeColor = System.Drawing.Color.Black;
            this.xValue.Location = new System.Drawing.Point(90, 13);
            this.xValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xValue.MaxLength = 3;
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(100, 21);
            this.xValue.TabIndex = 0;
            this.xValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.BackColor = System.Drawing.Color.White;
            this.xLabel.ForeColor = System.Drawing.Color.Black;
            this.xLabel.Location = new System.Drawing.Point(12, 16);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(72, 16);
            this.xLabel.TabIndex = 3;
            this.xLabel.Text = "Значение X";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.White;
            this.resultTextBox.Enabled = false;
            this.resultTextBox.ForeColor = System.Drawing.Color.Black;
            this.resultTextBox.Location = new System.Drawing.Point(12, 105);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(178, 21);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(45, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // functionImage
            // 
            this.functionImage.Image = global::WindowsFormsApp3.Properties.Resources.Function;
            this.functionImage.Location = new System.Drawing.Point(196, 12);
            this.functionImage.Name = "functionImage";
            this.functionImage.Size = new System.Drawing.Size(277, 114);
            this.functionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.functionImage.TabIndex = 4;
            this.functionImage.TabStop = false;
            // 
            // Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(485, 134);
            this.Controls.Add(this.functionImage);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.aValue);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Function";
            this.Text = "Function";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Function_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.functionImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox aValue;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox xValue;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox functionImage;
    }
}