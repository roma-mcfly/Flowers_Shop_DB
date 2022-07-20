namespace FlowersShop_DB
{
    partial class AllTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllTables));
            this.backBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.buyDGV = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.typesDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp3 = new System.Windows.Forms.TabPage();
            this.flowersDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyDGV)).BeginInit();
            this.tp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesDGV)).BeginInit();
            this.tp3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Silver;
            this.backBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(21, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(85, 40);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp1);
            this.tabControl1.Controls.Add(this.tp2);
            this.tabControl1.Controls.Add(this.tp3);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(21, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 377);
            this.tabControl1.TabIndex = 1;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.buyDGV);
            this.tp1.Location = new System.Drawing.Point(4, 28);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(935, 345);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Покупки";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // buyDGV
            // 
            this.buyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.buyDGV.Location = new System.Drawing.Point(3, 3);
            this.buyDGV.Name = "buyDGV";
            this.buyDGV.RowHeadersWidth = 51;
            this.buyDGV.RowTemplate.Height = 24;
            this.buyDGV.Size = new System.Drawing.Size(929, 342);
            this.buyDGV.TabIndex = 0;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "ID";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Цветок";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Кол-во";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Дата покупки";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Скидка";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.typesDGV);
            this.tp2.Location = new System.Drawing.Point(4, 28);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(935, 345);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Виды цветов";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // typesDGV
            // 
            this.typesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.typesDGV.Location = new System.Drawing.Point(3, 3);
            this.typesDGV.Name = "typesDGV";
            this.typesDGV.RowHeadersWidth = 51;
            this.typesDGV.RowTemplate.Height = 24;
            this.typesDGV.Size = new System.Drawing.Size(929, 342);
            this.typesDGV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название вида";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цвет";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Срок реализации";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Доступность";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Фото";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // tp3
            // 
            this.tp3.Controls.Add(this.flowersDGV);
            this.tp3.Location = new System.Drawing.Point(4, 28);
            this.tp3.Name = "tp3";
            this.tp3.Size = new System.Drawing.Size(935, 345);
            this.tp3.TabIndex = 2;
            this.tp3.Text = "Цветы";
            this.tp3.UseVisualStyleBackColor = true;
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
            this.flowersDGV.Location = new System.Drawing.Point(3, 3);
            this.flowersDGV.Name = "flowersDGV";
            this.flowersDGV.RowHeadersWidth = 51;
            this.flowersDGV.RowTemplate.Height = 24;
            this.flowersDGV.Size = new System.Drawing.Size(929, 342);
            this.flowersDGV.TabIndex = 0;
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
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Silver;
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(25, 444);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(107, 42);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(939, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Silver;
            this.removeBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeBtn.Location = new System.Drawing.Point(138, 444);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(196, 42);
            this.removeBtn.TabIndex = 5;
            this.removeBtn.Text = "Удалить/Изменить";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.BackColor = System.Drawing.Color.Silver;
            this.btnRequests.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRequests.Location = new System.Drawing.Point(340, 444);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(106, 42);
            this.btnRequests.TabIndex = 10;
            this.btnRequests.Text = "Запросы";
            this.btnRequests.UseVisualStyleBackColor = false;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // AllTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 498);
            this.Controls.Add(this.btnRequests);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Все таблицы";
            this.Load += new System.EventHandler(this.AllTables_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buyDGV)).EndInit();
            this.tp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.typesDGV)).EndInit();
            this.tp3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flowersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.DataGridView buyDGV;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.DataGridView typesDGV;
        private System.Windows.Forms.TabPage tp3;
        private System.Windows.Forms.DataGridView flowersDGV;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnRequests;
    }
}