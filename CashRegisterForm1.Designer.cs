namespace Supermarket
{
    partial class CashRegisterForm1
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
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.MakePurchaseButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBarcode.BackColor = System.Drawing.Color.White;
            this.pictureBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBarcode.Location = new System.Drawing.Point(68, 72);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(328, 176);
            this.pictureBoxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBarcode.TabIndex = 21;
            this.pictureBoxBarcode.TabStop = false;
            this.pictureBoxBarcode.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBoxBarcode_DragDrop);
            this.pictureBoxBarcode.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBoxBarcode_DragEnter);
            // 
            // MakePurchaseButton
            // 
            this.MakePurchaseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MakePurchaseButton.AutoSize = true;
            this.MakePurchaseButton.BackColor = System.Drawing.Color.White;
            this.MakePurchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakePurchaseButton.ForeColor = System.Drawing.Color.Purple;
            this.MakePurchaseButton.Location = new System.Drawing.Point(68, 254);
            this.MakePurchaseButton.Name = "MakePurchaseButton";
            this.MakePurchaseButton.Size = new System.Drawing.Size(161, 35);
            this.MakePurchaseButton.TabIndex = 22;
            this.MakePurchaseButton.Text = "Пробить товар";
            this.MakePurchaseButton.UseVisualStyleBackColor = false;
            this.MakePurchaseButton.Click += new System.EventHandler(this.MakePurchaseButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 344);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 28);
            this.comboBox1.TabIndex = 23;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Purple;
            this.numericUpDown1.Location = new System.Drawing.Point(336, 256);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 30);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(474, 72);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 26;
            this.pictureBoxImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(57, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Переместите штрих-код в это окно";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(162, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Выбрать кассира";
            // 
            // CashRegisterForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(838, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MakePurchaseButton);
            this.Controls.Add(this.pictureBoxBarcode);
            this.Name = "CashRegisterForm1";
            this.Text = "Касса 1";
            this.Load += new System.EventHandler(this.CashRegisterForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.Button MakePurchaseButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}