namespace Supermarket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonOpenCashRegisters = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonEditStorage = new System.Windows.Forms.Button();
            this.buttonEditSales = new System.Windows.Forms.Button();
            this.buttonEditCashRegister = new System.Windows.Forms.Button();
            this.buttonEditCashier = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxTotalRevenue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegectChanges = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonImportFromXML = new System.Windows.Forms.Button();
            this.buttonImportFromJSON = new System.Windows.Forms.Button();
            this.buttonFromDBToXML = new System.Windows.Forms.Button();
            this.buttonFromDBToJson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 588);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.buttonOpenCashRegisters);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(946, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кассы";
            // 
            // buttonOpenCashRegisters
            // 
            this.buttonOpenCashRegisters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOpenCashRegisters.AutoSize = true;
            this.buttonOpenCashRegisters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOpenCashRegisters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenCashRegisters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenCashRegisters.ForeColor = System.Drawing.Color.Purple;
            this.buttonOpenCashRegisters.Location = new System.Drawing.Point(311, 244);
            this.buttonOpenCashRegisters.Name = "buttonOpenCashRegisters";
            this.buttonOpenCashRegisters.Size = new System.Drawing.Size(303, 60);
            this.buttonOpenCashRegisters.TabIndex = 0;
            this.buttonOpenCashRegisters.Text = "Открыть кассы";
            this.buttonOpenCashRegisters.UseVisualStyleBackColor = false;
            this.buttonOpenCashRegisters.Click += new System.EventHandler(this.ButtonOpenCashRegisters_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.buttonEditStorage);
            this.tabPage2.Controls.Add(this.buttonEditSales);
            this.tabPage2.Controls.Add(this.buttonEditCashRegister);
            this.tabPage2.Controls.Add(this.buttonEditCashier);
            this.tabPage2.Controls.Add(this.buttonEditProduct);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(946, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактирование";
            // 
            // buttonEditStorage
            // 
            this.buttonEditStorage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEditStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditStorage.ForeColor = System.Drawing.Color.Purple;
            this.buttonEditStorage.Location = new System.Drawing.Point(322, 376);
            this.buttonEditStorage.Name = "buttonEditStorage";
            this.buttonEditStorage.Size = new System.Drawing.Size(303, 60);
            this.buttonEditStorage.TabIndex = 9;
            this.buttonEditStorage.Text = "Редактирование склада";
            this.buttonEditStorage.UseVisualStyleBackColor = false;
            this.buttonEditStorage.Click += new System.EventHandler(this.ButtonEditStorage_Click);
            // 
            // buttonEditSales
            // 
            this.buttonEditSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEditSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditSales.ForeColor = System.Drawing.Color.Purple;
            this.buttonEditSales.Location = new System.Drawing.Point(322, 310);
            this.buttonEditSales.Name = "buttonEditSales";
            this.buttonEditSales.Size = new System.Drawing.Size(303, 60);
            this.buttonEditSales.TabIndex = 8;
            this.buttonEditSales.Text = "Редактирование продаж";
            this.buttonEditSales.UseVisualStyleBackColor = false;
            this.buttonEditSales.Click += new System.EventHandler(this.ButtonEditSales_Click);
            // 
            // buttonEditCashRegister
            // 
            this.buttonEditCashRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditCashRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEditCashRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditCashRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditCashRegister.ForeColor = System.Drawing.Color.Purple;
            this.buttonEditCashRegister.Location = new System.Drawing.Point(322, 178);
            this.buttonEditCashRegister.Name = "buttonEditCashRegister";
            this.buttonEditCashRegister.Size = new System.Drawing.Size(303, 60);
            this.buttonEditCashRegister.TabIndex = 7;
            this.buttonEditCashRegister.Text = "Редактирование касс";
            this.buttonEditCashRegister.UseVisualStyleBackColor = false;
            this.buttonEditCashRegister.Click += new System.EventHandler(this.ButtonEditCashRegister_Click);
            // 
            // buttonEditCashier
            // 
            this.buttonEditCashier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEditCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditCashier.ForeColor = System.Drawing.Color.Purple;
            this.buttonEditCashier.Location = new System.Drawing.Point(322, 112);
            this.buttonEditCashier.Name = "buttonEditCashier";
            this.buttonEditCashier.Size = new System.Drawing.Size(303, 60);
            this.buttonEditCashier.TabIndex = 6;
            this.buttonEditCashier.Text = "Редактирование кассиров";
            this.buttonEditCashier.UseVisualStyleBackColor = false;
            this.buttonEditCashier.Click += new System.EventHandler(this.ButtonEditCashiers_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditProduct.ForeColor = System.Drawing.Color.Purple;
            this.buttonEditProduct.Location = new System.Drawing.Point(322, 244);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(303, 60);
            this.buttonEditProduct.TabIndex = 5;
            this.buttonEditProduct.Text = "Редактирование товаров";
            this.buttonEditProduct.UseVisualStyleBackColor = false;
            this.buttonEditProduct.Click += new System.EventHandler(this.ButtonEditProduct_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage3.Controls.Add(this.textBoxTotalRevenue);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.buttonRegectChanges);
            this.tabPage3.Controls.Add(this.buttonSave);
            this.tabPage3.Controls.Add(this.buttonImportFromXML);
            this.tabPage3.Controls.Add(this.buttonImportFromJSON);
            this.tabPage3.Controls.Add(this.buttonFromDBToXML);
            this.tabPage3.Controls.Add(this.buttonFromDBToJson);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(946, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "База данных";
            // 
            // textBoxTotalRevenue
            // 
            this.textBoxTotalRevenue.Location = new System.Drawing.Point(38, 400);
            this.textBoxTotalRevenue.Name = "textBoxTotalRevenue";
            this.textBoxTotalRevenue.Size = new System.Drawing.Size(169, 26);
            this.textBoxTotalRevenue.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(33, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Общая прибыль";
            // 
            // buttonRegectChanges
            // 
            this.buttonRegectChanges.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegectChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonRegectChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegectChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegectChanges.ForeColor = System.Drawing.Color.Red;
            this.buttonRegectChanges.Location = new System.Drawing.Point(11, 268);
            this.buttonRegectChanges.Name = "buttonRegectChanges";
            this.buttonRegectChanges.Size = new System.Drawing.Size(210, 30);
            this.buttonRegectChanges.TabIndex = 8;
            this.buttonRegectChanges.Text = "Отменить изменения";
            this.buttonRegectChanges.UseVisualStyleBackColor = false;
            this.buttonRegectChanges.Click += new System.EventHandler(this.ButtonRegectChanges_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.Green;
            this.buttonSave.Location = new System.Drawing.Point(11, 232);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(210, 30);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить изменения";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonImportFromXML
            // 
            this.buttonImportFromXML.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonImportFromXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonImportFromXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImportFromXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonImportFromXML.ForeColor = System.Drawing.Color.Purple;
            this.buttonImportFromXML.Location = new System.Drawing.Point(11, 196);
            this.buttonImportFromXML.Name = "buttonImportFromXML";
            this.buttonImportFromXML.Size = new System.Drawing.Size(210, 30);
            this.buttonImportFromXML.TabIndex = 6;
            this.buttonImportFromXML.Text = "Импорт из XML";
            this.buttonImportFromXML.UseVisualStyleBackColor = false;
            this.buttonImportFromXML.Click += new System.EventHandler(this.ButtonImportFromXML_Click);
            // 
            // buttonImportFromJSON
            // 
            this.buttonImportFromJSON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonImportFromJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonImportFromJSON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImportFromJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonImportFromJSON.ForeColor = System.Drawing.Color.Purple;
            this.buttonImportFromJSON.Location = new System.Drawing.Point(11, 124);
            this.buttonImportFromJSON.Name = "buttonImportFromJSON";
            this.buttonImportFromJSON.Size = new System.Drawing.Size(210, 30);
            this.buttonImportFromJSON.TabIndex = 5;
            this.buttonImportFromJSON.Text = "Импорт из JSON";
            this.buttonImportFromJSON.UseVisualStyleBackColor = false;
            this.buttonImportFromJSON.Click += new System.EventHandler(this.ButtonImportFromJSON_Click);
            // 
            // buttonFromDBToXML
            // 
            this.buttonFromDBToXML.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFromDBToXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonFromDBToXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFromDBToXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFromDBToXML.ForeColor = System.Drawing.Color.Purple;
            this.buttonFromDBToXML.Location = new System.Drawing.Point(11, 160);
            this.buttonFromDBToXML.Name = "buttonFromDBToXML";
            this.buttonFromDBToXML.Size = new System.Drawing.Size(210, 30);
            this.buttonFromDBToXML.TabIndex = 4;
            this.buttonFromDBToXML.Text = "Сохранить в XML";
            this.buttonFromDBToXML.UseVisualStyleBackColor = false;
            this.buttonFromDBToXML.Click += new System.EventHandler(this.ButtonFromDBToXML_Click);
            // 
            // buttonFromDBToJson
            // 
            this.buttonFromDBToJson.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFromDBToJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonFromDBToJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFromDBToJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFromDBToJson.ForeColor = System.Drawing.Color.Purple;
            this.buttonFromDBToJson.Location = new System.Drawing.Point(11, 88);
            this.buttonFromDBToJson.Name = "buttonFromDBToJson";
            this.buttonFromDBToJson.Size = new System.Drawing.Size(210, 30);
            this.buttonFromDBToJson.TabIndex = 3;
            this.buttonFromDBToJson.Text = "Сохранить в JSON";
            this.buttonFromDBToJson.UseVisualStyleBackColor = false;
            this.buttonFromDBToJson.Click += new System.EventHandler(this.ButtonFromDBToJson_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите таблицу";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(227, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(642, 543);
            this.dataGridView1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 614);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Супермаркет";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonOpenCashRegisters;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonEditCashier;
        private System.Windows.Forms.Button buttonFromDBToXML;
        private System.Windows.Forms.Button buttonFromDBToJson;
        private System.Windows.Forms.Button buttonImportFromXML;
        private System.Windows.Forms.Button buttonImportFromJSON;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRegectChanges;
        private System.Windows.Forms.Button buttonEditCashRegister;
        private System.Windows.Forms.Button buttonEditSales;
        private System.Windows.Forms.Button buttonEditStorage;
        private System.Windows.Forms.TextBox textBoxTotalRevenue;
        private System.Windows.Forms.Label label2;
    }
}

