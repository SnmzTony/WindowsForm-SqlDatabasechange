namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEirsaliyeNumarasi = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.Select = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sonuç = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEirsaliyeNumarasi
            // 
            this.txtEirsaliyeNumarasi.Location = new System.Drawing.Point(136, 155);
            this.txtEirsaliyeNumarasi.Name = "txtEirsaliyeNumarasi";
            this.txtEirsaliyeNumarasi.Size = new System.Drawing.Size(286, 22);
            this.txtEirsaliyeNumarasi.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Location = new System.Drawing.Point(653, 155);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(120, 22);
            this.txtResult.TabIndex = 1;
            // 
            // Select
            // 
            this.Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Select.Location = new System.Drawing.Point(136, 197);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(117, 45);
            this.Select.TabIndex = 2;
            this.Select.Text = "Select";
            this.Select.UseVisualStyleBackColor = false;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.ForestGreen;
            this.Update.Location = new System.Drawing.Point(305, 197);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(117, 45);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(-4, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "İrsaliye Bilgisi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(630, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "İRSALİYE AKTARIM UYGULAMASI";
            // 
            // Sonuç
            // 
            this.Sonuç.AutoSize = true;
            this.Sonuç.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sonuç.Location = new System.Drawing.Point(552, 155);
            this.Sonuç.Name = "Sonuç";
            this.Sonuç.Size = new System.Drawing.Size(61, 20);
            this.Sonuç.TabIndex = 6;
            this.Sonuç.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sonuç);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtEirsaliyeNumarasi);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEirsaliyeNumarasi;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Sonuç;
    }
}

