namespace Supermarket
{
    partial class EditingProductForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingProductForm));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.buttonSaveBarcode = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.textBoxEncodeBarecode = new System.Windows.Forms.TextBox();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRevenue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1020, 31);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(940, 290);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSave.AutoSize = true;
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.ForeColor = System.Drawing.Color.Blue;
            this.buttonSave.Location = new System.Drawing.Point(631, 693);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 30);
            this.buttonSave.TabIndex = 35;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 627);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Wt";
            // 
            // textBoxWt
            // 
            this.textBoxWt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxWt.Location = new System.Drawing.Point(111, 649);
            this.textBoxWt.Name = "textBoxWt";
            this.textBoxWt.Size = new System.Drawing.Size(167, 26);
            this.textBoxWt.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 569);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPrice.Location = new System.Drawing.Point(111, 592);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(167, 26);
            this.textBoxPrice.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 512);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxName.Location = new System.Drawing.Point(111, 535);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(167, 26);
            this.textBoxName.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Barecode";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 341);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "ProductID";
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxProductID.Location = new System.Drawing.Point(111, 364);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(167, 26);
            this.textBoxProductID.TabIndex = 24;
            // 
            // buttonSaveBarcode
            // 
            this.buttonSaveBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSaveBarcode.AutoSize = true;
            this.buttonSaveBarcode.BackColor = System.Drawing.Color.White;
            this.buttonSaveBarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveBarcode.ForeColor = System.Drawing.Color.Blue;
            this.buttonSaveBarcode.Location = new System.Drawing.Point(730, 419);
            this.buttonSaveBarcode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.buttonSaveBarcode.Name = "buttonSaveBarcode";
            this.buttonSaveBarcode.Size = new System.Drawing.Size(184, 30);
            this.buttonSaveBarcode.TabIndex = 23;
            this.buttonSaveBarcode.Text = "Сохранить штрих-код";
            this.buttonSaveBarcode.UseVisualStyleBackColor = false;
            this.buttonSaveBarcode.Click += new System.EventHandler(this.ButtonSaveBarcode_Click);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEncode.AutoSize = true;
            this.buttonEncode.BackColor = System.Drawing.Color.White;
            this.buttonEncode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEncode.ForeColor = System.Drawing.Color.Green;
            this.buttonEncode.Location = new System.Drawing.Point(284, 419);
            this.buttonEncode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(184, 30);
            this.buttonEncode.TabIndex = 22;
            this.buttonEncode.Text = "Сделать штрих-код";
            this.buttonEncode.UseVisualStyleBackColor = false;
            this.buttonEncode.Click += new System.EventHandler(this.ButtonEncode_Click);
            // 
            // textBoxEncodeBarecode
            // 
            this.textBoxEncodeBarecode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEncodeBarecode.Location = new System.Drawing.Point(111, 421);
            this.textBoxEncodeBarecode.Name = "textBoxEncodeBarecode";
            this.textBoxEncodeBarecode.Size = new System.Drawing.Size(167, 26);
            this.textBoxEncodeBarecode.TabIndex = 21;
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBarcode.Location = new System.Drawing.Point(474, 369);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(250, 130);
            this.pictureBoxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBarcode.TabIndex = 20;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonInsert.AutoSize = true;
            this.buttonInsert.BackColor = System.Drawing.Color.White;
            this.buttonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsert.ForeColor = System.Drawing.Color.Green;
            this.buttonInsert.Location = new System.Drawing.Point(631, 616);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(200, 30);
            this.buttonInsert.TabIndex = 36;
            this.buttonInsert.Text = "Добавить новую запись";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.BackColor = System.Drawing.Color.White;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(631, 654);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 30);
            this.buttonDelete.TabIndex = 37;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 683);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Revenue";
            // 
            // textBoxRevenue
            // 
            this.textBoxRevenue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxRevenue.Location = new System.Drawing.Point(111, 706);
            this.textBoxRevenue.Name = "textBoxRevenue";
            this.textBoxRevenue.Size = new System.Drawing.Size(167, 26);
            this.textBoxRevenue.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 473);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Image";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(305, 496);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 44;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBoxImage_DragDrop);
            this.pictureBoxImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBoxImage_DragEnter);
            // 
            // EditingProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 744);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRevenue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxWt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.buttonSaveBarcode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.textBoxEncodeBarecode);
            this.Controls.Add(this.pictureBoxBarcode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "EditingProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование товаров";
            this.Load += new System.EventHandler(this.EditingProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.Button buttonSaveBarcode;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.TextBox textBoxEncodeBarecode;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRevenue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}