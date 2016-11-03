namespace CRC_Hasher
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._columnFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnCrc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this._lbSefl = new System.Windows.Forms.Label();
            this._lbSelfValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btSaveSelf = new System.Windows.Forms.Button();
            this._lbRealSelf = new System.Windows.Forms.Label();
            this._lbRealSelfValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Посчитать CRC32";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnFile,
            this._columnCrc});
            this.dataGridView1.Location = new System.Drawing.Point(223, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(632, 442);
            this.dataGridView1.TabIndex = 1;
            // 
            // _columnFile
            // 
            this._columnFile.HeaderText = "File";
            this._columnFile.MinimumWidth = 250;
            this._columnFile.Name = "_columnFile";
            this._columnFile.ReadOnly = true;
            this._columnFile.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._columnFile.Width = 250;
            // 
            // _columnCrc
            // 
            this._columnCrc.HeaderText = "CRC32";
            this._columnCrc.Name = "_columnCrc";
            this._columnCrc.ReadOnly = true;
            this._columnCrc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сравнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _lbSefl
            // 
            this._lbSefl.AutoSize = true;
            this._lbSefl.Location = new System.Drawing.Point(14, 304);
            this._lbSefl.Name = "_lbSefl";
            this._lbSefl.Size = new System.Drawing.Size(115, 20);
            this._lbSefl.TabIndex = 3;
            this._lbSefl.Text = "Личный(XML):";
            // 
            // _lbSelfValue
            // 
            this._lbSelfValue.AutoSize = true;
            this._lbSelfValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lbSelfValue.Location = new System.Drawing.Point(125, 305);
            this._lbSelfValue.Name = "_lbSelfValue";
            this._lbSelfValue.Size = new System.Drawing.Size(83, 20);
            this._lbSelfValue.TabIndex = 4;
            this._lbSelfValue.Text = "Unknown";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRC32";
            // 
            // _btSaveSelf
            // 
            this._btSaveSelf.Location = new System.Drawing.Point(28, 368);
            this._btSaveSelf.Name = "_btSaveSelf";
            this._btSaveSelf.Size = new System.Drawing.Size(165, 54);
            this._btSaveSelf.TabIndex = 3;
            this._btSaveSelf.Text = "Сохранить текущий";
            this._btSaveSelf.UseVisualStyleBackColor = true;
            this._btSaveSelf.Click += new System.EventHandler(this._btSaveSelf_Click);
            // 
            // _lbRealSelf
            // 
            this._lbRealSelf.AutoSize = true;
            this._lbRealSelf.Location = new System.Drawing.Point(14, 336);
            this._lbRealSelf.Name = "_lbRealSelf";
            this._lbRealSelf.Size = new System.Drawing.Size(115, 20);
            this._lbRealSelf.TabIndex = 6;
            this._lbRealSelf.Text = "Личный(Real):";
            // 
            // _lbRealSelfValue
            // 
            this._lbRealSelfValue.AutoSize = true;
            this._lbRealSelfValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lbRealSelfValue.Location = new System.Drawing.Point(125, 336);
            this._lbRealSelfValue.Name = "_lbRealSelfValue";
            this._lbRealSelfValue.Size = new System.Drawing.Size(83, 20);
            this._lbRealSelfValue.TabIndex = 7;
            this._lbRealSelfValue.Text = "Unknown";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 444);
            this.Controls.Add(this._lbRealSelfValue);
            this.Controls.Add(this._lbRealSelf);
            this.Controls.Add(this._btSaveSelf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._lbSelfValue);
            this.Controls.Add(this._lbSefl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnCrc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label _lbSefl;
        private System.Windows.Forms.Label _lbSelfValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btSaveSelf;
        private System.Windows.Forms.Label _lbRealSelf;
        private System.Windows.Forms.Label _lbRealSelfValue;
    }
}

