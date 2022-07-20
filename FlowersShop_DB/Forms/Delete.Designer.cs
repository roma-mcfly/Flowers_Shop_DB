namespace FlowersShop_DB.Forms
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.removetb = new System.Windows.Forms.TextBox();
            this.removelb = new System.Windows.Forms.Label();
            this.removeTrueBtn = new System.Windows.Forms.Button();
            this.removeFalseBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removetb
            // 
            this.removetb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removetb.Location = new System.Drawing.Point(208, 28);
            this.removetb.Name = "removetb";
            this.removetb.Size = new System.Drawing.Size(198, 27);
            this.removetb.TabIndex = 6;
            // 
            // removelb
            // 
            this.removelb.AutoSize = true;
            this.removelb.BackColor = System.Drawing.Color.Transparent;
            this.removelb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removelb.Location = new System.Drawing.Point(12, 28);
            this.removelb.Name = "removelb";
            this.removelb.Size = new System.Drawing.Size(153, 19);
            this.removelb.TabIndex = 9;
            this.removelb.Text = "Введите название:";
            // 
            // removeTrueBtn
            // 
            this.removeTrueBtn.BackColor = System.Drawing.Color.Silver;
            this.removeTrueBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeTrueBtn.Location = new System.Drawing.Point(151, 68);
            this.removeTrueBtn.Name = "removeTrueBtn";
            this.removeTrueBtn.Size = new System.Drawing.Size(125, 41);
            this.removeTrueBtn.TabIndex = 7;
            this.removeTrueBtn.Text = "Удалить";
            this.removeTrueBtn.UseVisualStyleBackColor = false;
            this.removeTrueBtn.Click += new System.EventHandler(this.removeTrueBtn_Click);
            // 
            // removeFalseBtn
            // 
            this.removeFalseBtn.BackColor = System.Drawing.Color.Silver;
            this.removeFalseBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeFalseBtn.Location = new System.Drawing.Point(282, 68);
            this.removeFalseBtn.Name = "removeFalseBtn";
            this.removeFalseBtn.Size = new System.Drawing.Size(124, 41);
            this.removeFalseBtn.TabIndex = 8;
            this.removeFalseBtn.Text = "Отмена";
            this.removeFalseBtn.UseVisualStyleBackColor = false;
            this.removeFalseBtn.Click += new System.EventHandler(this.removeFalseBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.Silver;
            this.changeBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBtn.Location = new System.Drawing.Point(15, 69);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(130, 40);
            this.changeBtn.TabIndex = 10;
            this.changeBtn.Text = "Изменить";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Visible = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 121);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.removetb);
            this.Controls.Add(this.removelb);
            this.Controls.Add(this.removeTrueBtn);
            this.Controls.Add(this.removeFalseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox removetb;
        private System.Windows.Forms.Label removelb;
        private System.Windows.Forms.Button removeTrueBtn;
        private System.Windows.Forms.Button removeFalseBtn;
        private System.Windows.Forms.Button changeBtn;
    }
}