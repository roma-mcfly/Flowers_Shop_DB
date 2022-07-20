namespace FlowersShop_DB.Forms
{
    partial class Question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            this.lb1 = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.valuelb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb1.Location = new System.Drawing.Point(26, 22);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(154, 19);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Вы действительно";
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.yesBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yesBtn.ForeColor = System.Drawing.Color.Black;
            this.yesBtn.Location = new System.Drawing.Point(21, 114);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(75, 36);
            this.yesBtn.TabIndex = 1;
            this.yesBtn.Text = "ДА";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.BackColor = System.Drawing.Color.Red;
            this.noBtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noBtn.ForeColor = System.Drawing.Color.Black;
            this.noBtn.Location = new System.Drawing.Point(206, 114);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(75, 36);
            this.noBtn.TabIndex = 2;
            this.noBtn.Text = "НЕТ";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb2.Location = new System.Drawing.Point(26, 41);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(186, 19);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "хотите удалить запись:";
            // 
            // valuelb
            // 
            this.valuelb.AutoSize = true;
            this.valuelb.BackColor = System.Drawing.Color.Transparent;
            this.valuelb.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valuelb.Location = new System.Drawing.Point(25, 70);
            this.valuelb.Name = "valuelb";
            this.valuelb.Size = new System.Drawing.Size(36, 26);
            this.valuelb.TabIndex = 4;
            this.valuelb.Text = "---";
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(305, 162);
            this.Controls.Add(this.valuelb);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.lb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.Load += new System.EventHandler(this.Question_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label valuelb;
    }
}