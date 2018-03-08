namespace WindowsFormsApp3
{
    partial class StandartArray
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
            this.arrayLenght = new System.Windows.Forms.TextBox();
            this.arrayLenghtLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.arrayItemsList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.averageItems = new System.Windows.Forms.TextBox();
            this.averageItemsLabel = new System.Windows.Forms.Label();
            this.maxAbsIndexItem = new System.Windows.Forms.TextBox();
            this.maxItem = new System.Windows.Forms.TextBox();
            this.maxAbsIndexItemLabel = new System.Windows.Forms.Label();
            this.maxItemLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.arrayLenght, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.arrayLenghtLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // arrayLenght
            // 
            this.arrayLenght.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrayLenght.ForeColor = System.Drawing.Color.Black;
            this.arrayLenght.Location = new System.Drawing.Point(4, 6);
            this.arrayLenght.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arrayLenght.Name = "arrayLenght";
            this.arrayLenght.Size = new System.Drawing.Size(333, 21);
            this.arrayLenght.TabIndex = 0;
            this.arrayLenght.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // arrayLenghtLabel
            // 
            this.arrayLenghtLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.arrayLenghtLabel.AutoSize = true;
            this.arrayLenghtLabel.BackColor = System.Drawing.Color.White;
            this.arrayLenghtLabel.Location = new System.Drawing.Point(85, 41);
            this.arrayLenghtLabel.Name = "arrayLenghtLabel";
            this.arrayLenghtLabel.Size = new System.Drawing.Size(170, 16);
            this.arrayLenghtLabel.TabIndex = 1;
            this.arrayLenghtLabel.Text = "Размер линейного массива";
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(100, 70);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(141, 26);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Сгенерировать";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // arrayItemsList
            // 
            this.arrayItemsList.ForeColor = System.Drawing.Color.Black;
            this.arrayItemsList.FormattingEnabled = true;
            this.arrayItemsList.ItemHeight = 16;
            this.arrayItemsList.Location = new System.Drawing.Point(14, 122);
            this.arrayItemsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arrayItemsList.Name = "arrayItemsList";
            this.arrayItemsList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.arrayItemsList.Size = new System.Drawing.Size(340, 132);
            this.arrayItemsList.TabIndex = 1;
            this.arrayItemsList.UseTabStops = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.averageItems, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.averageItemsLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.maxAbsIndexItem, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.maxItem, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.maxAbsIndexItemLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.maxItemLabel, 0, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 262);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 233);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // averageItems
            // 
            this.averageItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.averageItems.ForeColor = System.Drawing.Color.Black;
            this.averageItems.Location = new System.Drawing.Point(4, 8);
            this.averageItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.averageItems.Name = "averageItems";
            this.averageItems.ReadOnly = true;
            this.averageItems.Size = new System.Drawing.Size(333, 21);
            this.averageItems.TabIndex = 2;
            this.averageItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // averageItemsLabel
            // 
            this.averageItemsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.averageItemsLabel.AutoSize = true;
            this.averageItemsLabel.BackColor = System.Drawing.Color.White;
            this.averageItemsLabel.Location = new System.Drawing.Point(55, 49);
            this.averageItemsLabel.Name = "averageItemsLabel";
            this.averageItemsLabel.Size = new System.Drawing.Size(230, 16);
            this.averageItemsLabel.TabIndex = 3;
            this.averageItemsLabel.Text = "Среднее геометрическое четных чисел";
            // 
            // maxAbsIndexItem
            // 
            this.maxAbsIndexItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxAbsIndexItem.ForeColor = System.Drawing.Color.Black;
            this.maxAbsIndexItem.Location = new System.Drawing.Point(4, 84);
            this.maxAbsIndexItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maxAbsIndexItem.Name = "maxAbsIndexItem";
            this.maxAbsIndexItem.ReadOnly = true;
            this.maxAbsIndexItem.Size = new System.Drawing.Size(333, 21);
            this.maxAbsIndexItem.TabIndex = 4;
            this.maxAbsIndexItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxItem
            // 
            this.maxItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxItem.ForeColor = System.Drawing.Color.Black;
            this.maxItem.Location = new System.Drawing.Point(4, 160);
            this.maxItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maxItem.Name = "maxItem";
            this.maxItem.ReadOnly = true;
            this.maxItem.Size = new System.Drawing.Size(333, 21);
            this.maxItem.TabIndex = 5;
            this.maxItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxAbsIndexItemLabel
            // 
            this.maxAbsIndexItemLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxAbsIndexItemLabel.AutoSize = true;
            this.maxAbsIndexItemLabel.BackColor = System.Drawing.Color.White;
            this.maxAbsIndexItemLabel.Location = new System.Drawing.Point(45, 125);
            this.maxAbsIndexItemLabel.Name = "maxAbsIndexItemLabel";
            this.maxAbsIndexItemLabel.Size = new System.Drawing.Size(250, 16);
            this.maxAbsIndexItemLabel.TabIndex = 7;
            this.maxAbsIndexItemLabel.Text = "Номер наибольшего по модулю элемента";
            // 
            // maxItemLabel
            // 
            this.maxItemLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxItemLabel.AutoSize = true;
            this.maxItemLabel.BackColor = System.Drawing.Color.White;
            this.maxItemLabel.Location = new System.Drawing.Point(76, 203);
            this.maxItemLabel.Name = "maxItemLabel";
            this.maxItemLabel.Size = new System.Drawing.Size(188, 16);
            this.maxItemLabel.TabIndex = 8;
            this.maxItemLabel.Text = "Максимальный четный элемент";
            // 
            // StandartArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(369, 496);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.arrayItemsList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StandartArray";
            this.Text = "Array";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StandartArray_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox arrayLenght;
        private System.Windows.Forms.Label arrayLenghtLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox arrayItemsList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox averageItems;
        private System.Windows.Forms.Label averageItemsLabel;
        private System.Windows.Forms.TextBox maxAbsIndexItem;
        private System.Windows.Forms.TextBox maxItem;
        private System.Windows.Forms.Label maxAbsIndexItemLabel;
        private System.Windows.Forms.Label maxItemLabel;
    }
}