namespace FlowersShop_DB.Forms
{
    partial class Requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Requests));
            this.dtv = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lb6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv
            // 
            this.dtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv.Location = new System.Drawing.Point(28, 66);
            this.dtv.Name = "dtv";
            this.dtv.RowHeadersWidth = 51;
            this.dtv.RowTemplate.Height = 24;
            this.dtv.Size = new System.Drawing.Size(760, 284);
            this.dtv.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(28, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 42);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(796, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.BackColor = System.Drawing.Color.Transparent;
            this.lb6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb6.Location = new System.Drawing.Point(25, 414);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(73, 19);
            this.lb6.TabIndex = 15;
            this.lb6.Text = "Кол-во: ";
            this.lb6.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. Вычислить сумму каждой продажи с учетом скидки.",
            "2. Название и описание цветов, проданных на сумму, которую вводит пользователь.",
            "3. Название цветов, которых продано минимальное количество.",
            "4. Название и цену цветов срок реализации которых больше, чем вводит пользователь" +
                ".",
            "5. Цветы, проданные сегодня, для которых средняя цена меньше, чем вводит пользова" +
                "тель.",
            "6. Общее количество товара, проданного за день.",
            "7. Общее количество проданных цветов на каждую дату продажи.",
            "8. Среднее значение скидки на каждую дату. Выводить только те даты, когда среднее" +
                " значение скидки > 10%.",
            "9. Названия цветов, для которых не было продаж.",
            "10. Для введенного срока реализации показать наименования и общее количество прод" +
                "анных цветов."});
            this.comboBox1.Location = new System.Drawing.Point(28, 387);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(760, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(652, 358);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(136, 22);
            this.tbValue.TabIndex = 19;
            this.tbValue.Visible = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.Location = new System.Drawing.Point(449, 359);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(186, 19);
            this.lb1.TabIndex = 20;
            this.lb1.Text = "Введите информацию:";
            this.lb1.Visible = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Silver;
            this.btnEnter.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.Location = new System.Drawing.Point(28, 450);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(204, 44);
            this.btnEnter.TabIndex = 21;
            this.btnEnter.Text = "Выполнить запрос";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtv);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Requests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requests";
            ((System.ComponentModel.ISupportInitialize)(this.dtv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtv;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnEnter;
    }
}