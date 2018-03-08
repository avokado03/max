namespace WindowsFormsApp3
{
    partial class Matrix
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cellsCountLabel = new System.Windows.Forms.Label();
            this.cellsCount = new System.Windows.Forms.TextBox();
            this.rowCount = new System.Windows.Forms.TextBox();
            this.rowCountLabel = new System.Windows.Forms.Label();
            this.generationButton = new System.Windows.Forms.Button();
            this.matrixView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.countItems = new System.Windows.Forms.TextBox();
            this.countItemsLabel = new System.Windows.Forms.Label();
            this.opItems = new System.Windows.Forms.TextBox();
            this.countArrayItems = new System.Windows.Forms.TextBox();
            this.opItemsLabel = new System.Windows.Forms.Label();
            this.countArrayItemsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cellsCountLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cellsCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rowCount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rowCountLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.generationButton, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 101);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cellsCountLabel
            // 
            this.cellsCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cellsCountLabel.AutoSize = true;
            this.cellsCountLabel.BackColor = System.Drawing.Color.White;
            this.cellsCountLabel.Location = new System.Drawing.Point(294, 41);
            this.cellsCountLabel.Name = "cellsCountLabel";
            this.cellsCountLabel.Size = new System.Drawing.Size(123, 16);
            this.cellsCountLabel.TabIndex = 3;
            this.cellsCountLabel.Text = "Количество столбцов";
            // 
            // cellsCount
            // 
            this.cellsCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cellsCount.ForeColor = System.Drawing.Color.Black;
            this.cellsCount.Location = new System.Drawing.Point(256, 6);
            this.cellsCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cellsCount.Name = "cellsCount";
            this.cellsCount.Size = new System.Drawing.Size(199, 21);
            this.cellsCount.TabIndex = 2;
            this.cellsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowCount
            // 
            this.rowCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rowCount.ForeColor = System.Drawing.Color.Black;
            this.rowCount.Location = new System.Drawing.Point(19, 6);
            this.rowCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(199, 21);
            this.rowCount.TabIndex = 0;
            this.rowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rowCountLabel
            // 
            this.rowCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rowCountLabel.AutoSize = true;
            this.rowCountLabel.BackColor = System.Drawing.Color.White;
            this.rowCountLabel.Location = new System.Drawing.Point(66, 41);
            this.rowCountLabel.Name = "rowCountLabel";
            this.rowCountLabel.Size = new System.Drawing.Size(105, 16);
            this.rowCountLabel.TabIndex = 1;
            this.rowCountLabel.Text = "Количество строк";
            // 
            // generationButton
            // 
            this.generationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generationButton.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.generationButton, 2);
            this.generationButton.Location = new System.Drawing.Point(164, 70);
            this.generationButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generationButton.Name = "generationButton";
            this.generationButton.Size = new System.Drawing.Size(147, 27);
            this.generationButton.TabIndex = 4;
            this.generationButton.Text = "Генерировать";
            this.generationButton.UseVisualStyleBackColor = false;
            this.generationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // matrixView
            // 
            this.matrixView.AllowUserToAddRows = false;
            this.matrixView.AllowUserToDeleteRows = false;
            this.matrixView.AllowUserToResizeColumns = false;
            this.matrixView.AllowUserToResizeRows = false;
            this.matrixView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.matrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixView.ColumnHeadersVisible = false;
            this.matrixView.Location = new System.Drawing.Point(14, 123);
            this.matrixView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.matrixView.MultiSelect = false;
            this.matrixView.Name = "matrixView";
            this.matrixView.ReadOnly = true;
            this.matrixView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.matrixView.ShowCellErrors = false;
            this.matrixView.ShowCellToolTips = false;
            this.matrixView.ShowEditingIcon = false;
            this.matrixView.ShowRowErrors = false;
            this.matrixView.Size = new System.Drawing.Size(475, 298);
            this.matrixView.TabIndex = 1;
            this.matrixView.TabStop = false;
            this.matrixView.SelectionChanged += new System.EventHandler(this.matrixView_SelectionChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.countItems, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.countItemsLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.opItems, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.countArrayItems, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.opItemsLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.countArrayItemsLabel, 0, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 429);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(475, 233);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // countItems
            // 
            this.countItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countItems.ForeColor = System.Drawing.Color.Black;
            this.countItems.Location = new System.Drawing.Point(71, 8);
            this.countItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.countItems.Name = "countItems";
            this.countItems.ReadOnly = true;
            this.countItems.Size = new System.Drawing.Size(333, 21);
            this.countItems.TabIndex = 2;
            this.countItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countItemsLabel
            // 
            this.countItemsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countItemsLabel.AutoSize = true;
            this.countItemsLabel.BackColor = System.Drawing.Color.White;
            this.countItemsLabel.Location = new System.Drawing.Point(98, 49);
            this.countItemsLabel.Name = "countItemsLabel";
            this.countItemsLabel.Size = new System.Drawing.Size(278, 16);
            this.countItemsLabel.TabIndex = 3;
            this.countItemsLabel.Text = "Количество положительных кратных 5 элементов";
            // 
            // opItems
            // 
            this.opItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.opItems.ForeColor = System.Drawing.Color.Black;
            this.opItems.Location = new System.Drawing.Point(71, 84);
            this.opItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opItems.Name = "opItems";
            this.opItems.ReadOnly = true;
            this.opItems.Size = new System.Drawing.Size(333, 21);
            this.opItems.TabIndex = 4;
            this.opItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countArrayItems
            // 
            this.countArrayItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countArrayItems.ForeColor = System.Drawing.Color.Black;
            this.countArrayItems.Location = new System.Drawing.Point(71, 160);
            this.countArrayItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.countArrayItems.Name = "countArrayItems";
            this.countArrayItems.ReadOnly = true;
            this.countArrayItems.Size = new System.Drawing.Size(333, 21);
            this.countArrayItems.TabIndex = 5;
            this.countArrayItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // opItemsLabel
            // 
            this.opItemsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.opItemsLabel.AutoSize = true;
            this.opItemsLabel.BackColor = System.Drawing.Color.White;
            this.opItemsLabel.Location = new System.Drawing.Point(18, 117);
            this.opItemsLabel.Name = "opItemsLabel";
            this.opItemsLabel.Size = new System.Drawing.Size(439, 32);
            this.opItemsLabel.TabIndex = 7;
            this.opItemsLabel.Text = "Произведение суммы не четных на количество положительных элементов на побочной ди" +
    "агонали";
            this.opItemsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // countArrayItemsLabel
            // 
            this.countArrayItemsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countArrayItemsLabel.AutoSize = true;
            this.countArrayItemsLabel.BackColor = System.Drawing.Color.White;
            this.countArrayItemsLabel.Location = new System.Drawing.Point(27, 195);
            this.countArrayItemsLabel.Name = "countArrayItemsLabel";
            this.countArrayItemsLabel.Size = new System.Drawing.Size(421, 32);
            this.countArrayItemsLabel.TabIndex = 8;
            this.countArrayItemsLabel.Text = "Количество положительных кратных 3 элементов 1-ой строки и количество нечетных эл" +
    "ементов 2-го столбца матрицы А(6;6)\t\r\n";
            this.countArrayItemsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Matrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(501, 662);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.matrixView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Matrix";
            this.Text = "Matrix";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Matrix_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label cellsCountLabel;
        private System.Windows.Forms.TextBox cellsCount;
        private System.Windows.Forms.TextBox rowCount;
        private System.Windows.Forms.Label rowCountLabel;
        private System.Windows.Forms.Button generationButton;
        private System.Windows.Forms.DataGridView matrixView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox countItems;
        private System.Windows.Forms.Label countItemsLabel;
        private System.Windows.Forms.TextBox opItems;
        private System.Windows.Forms.TextBox countArrayItems;
        private System.Windows.Forms.Label opItemsLabel;
        private System.Windows.Forms.Label countArrayItemsLabel;
    }
}