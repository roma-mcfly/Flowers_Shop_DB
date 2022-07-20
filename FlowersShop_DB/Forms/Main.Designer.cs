namespace FlowersShop_DB
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.alltbBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.photoPb = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.rightArrow = new System.Windows.Forms.PictureBox();
            this.leftArrow = new System.Windows.Forms.PictureBox();
            this.namelb = new System.Windows.Forms.Label();
            this.termlb = new System.Windows.Forms.Label();
            this.availabilityPb = new System.Windows.Forms.PictureBox();
            this.flowersDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorlb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // alltbBtn
            // 
            this.alltbBtn.BackColor = System.Drawing.Color.LightGray;
            this.alltbBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alltbBtn.Location = new System.Drawing.Point(28, 474);
            this.alltbBtn.Name = "alltbBtn";
            this.alltbBtn.Size = new System.Drawing.Size(281, 44);
            this.alltbBtn.TabIndex = 1;
            this.alltbBtn.Text = "Отображение всех таблиц";
            this.alltbBtn.UseVisualStyleBackColor = false;
            this.alltbBtn.Click += new System.EventHandler(this.alltbBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Цветочный магазин \"Ромашка\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(329, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название вида:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(329, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цвет:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(329, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Срок реализации:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(329, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Доступность:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(33, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Фото*";
            // 
            // photoPb
            // 
            this.photoPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photoPb.Location = new System.Drawing.Point(37, 107);
            this.photoPb.Name = "photoPb";
            this.photoPb.Size = new System.Drawing.Size(263, 320);
            this.photoPb.TabIndex = 4;
            this.photoPb.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(1274, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rightArrow
            // 
            this.rightArrow.BackColor = System.Drawing.Color.Transparent;
            this.rightArrow.Image = ((System.Drawing.Image)(resources.GetObject("rightArrow.Image")));
            this.rightArrow.Location = new System.Drawing.Point(385, 405);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(32, 32);
            this.rightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightArrow.TabIndex = 11;
            this.rightArrow.TabStop = false;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // leftArrow
            // 
            this.leftArrow.BackColor = System.Drawing.Color.Transparent;
            this.leftArrow.Image = ((System.Drawing.Image)(resources.GetObject("leftArrow.Image")));
            this.leftArrow.Location = new System.Drawing.Point(333, 405);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(32, 32);
            this.leftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftArrow.TabIndex = 12;
            this.leftArrow.TabStop = false;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // namelb
            // 
            this.namelb.AutoSize = true;
            this.namelb.BackColor = System.Drawing.Color.Transparent;
            this.namelb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namelb.Location = new System.Drawing.Point(494, 107);
            this.namelb.Name = "namelb";
            this.namelb.Size = new System.Drawing.Size(27, 19);
            this.namelb.TabIndex = 13;
            this.namelb.Text = "---";
            // 
            // termlb
            // 
            this.termlb.AutoSize = true;
            this.termlb.BackColor = System.Drawing.Color.Transparent;
            this.termlb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.termlb.Location = new System.Drawing.Point(494, 199);
            this.termlb.Name = "termlb";
            this.termlb.Size = new System.Drawing.Size(27, 19);
            this.termlb.TabIndex = 15;
            this.termlb.Text = "---";
            // 
            // availabilityPb
            // 
            this.availabilityPb.BackColor = System.Drawing.Color.Transparent;
            this.availabilityPb.Image = ((System.Drawing.Image)(resources.GetObject("availabilityPb.Image")));
            this.availabilityPb.Location = new System.Drawing.Point(466, 236);
            this.availabilityPb.Name = "availabilityPb";
            this.availabilityPb.Size = new System.Drawing.Size(32, 32);
            this.availabilityPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.availabilityPb.TabIndex = 16;
            this.availabilityPb.TabStop = false;
            // 
            // flowersDGV
            // 
            this.flowersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flowersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column10});
            this.flowersDGV.Location = new System.Drawing.Point(623, 107);
            this.flowersDGV.Name = "flowersDGV";
            this.flowersDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowersDGV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.flowersDGV.RowTemplate.Height = 24;
            this.flowersDGV.Size = new System.Drawing.Size(676, 330);
            this.flowersDGV.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Цветок";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Вид";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Доступность";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Кол-во";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // colorlb
            // 
            this.colorlb.AutoSize = true;
            this.colorlb.BackColor = System.Drawing.Color.Transparent;
            this.colorlb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorlb.Location = new System.Drawing.Point(494, 152);
            this.colorlb.Name = "colorlb";
            this.colorlb.Size = new System.Drawing.Size(27, 19);
            this.colorlb.TabIndex = 19;
            this.colorlb.Text = "---";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(28, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 339);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1322, 542);
            this.Controls.Add(this.colorlb);
            this.Controls.Add(this.flowersDGV);
            this.Controls.Add(this.availabilityPb);
            this.Controls.Add(this.termlb);
            this.Controls.Add(this.namelb);
            this.Controls.Add(this.leftArrow);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.photoPb);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.alltbBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.photoPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button alltbBtn;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox photoPb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox rightArrow;
        private System.Windows.Forms.PictureBox leftArrow;
        private System.Windows.Forms.Label namelb;
        private System.Windows.Forms.Label termlb;
        private System.Windows.Forms.PictureBox availabilityPb;
        private System.Windows.Forms.DataGridView flowersDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label colorlb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

