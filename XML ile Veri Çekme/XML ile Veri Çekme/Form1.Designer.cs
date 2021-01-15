namespace XML_ile_Veri_Çekme
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
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEURO = new System.Windows.Forms.Label();
            this.lblPound = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblJaponYeni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolar.Location = new System.Drawing.Point(12, 9);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(63, 25);
            this.lblDolar.TabIndex = 0;
            this.lblDolar.Text = "Dolar";
            // 
            // lblEURO
            // 
            this.lblEURO.AutoSize = true;
            this.lblEURO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEURO.Location = new System.Drawing.Point(12, 47);
            this.lblEURO.Name = "lblEURO";
            this.lblEURO.Size = new System.Drawing.Size(57, 25);
            this.lblEURO.TabIndex = 1;
            this.lblEURO.Text = "Euro";
            // 
            // lblPound
            // 
            this.lblPound.AutoSize = true;
            this.lblPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPound.Location = new System.Drawing.Point(12, 84);
            this.lblPound.Name = "lblPound";
            this.lblPound.Size = new System.Drawing.Size(88, 25);
            this.lblPound.TabIndex = 2;
            this.lblPound.Text = "POUND";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(86, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Döviz Kurları";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblJaponYeni
            // 
            this.lblJaponYeni.AutoSize = true;
            this.lblJaponYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblJaponYeni.Location = new System.Drawing.Point(12, 121);
            this.lblJaponYeni.Name = "lblJaponYeni";
            this.lblJaponYeni.Size = new System.Drawing.Size(121, 25);
            this.lblJaponYeni.TabIndex = 4;
            this.lblJaponYeni.Text = "Japon Yeni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(384, 256);
            this.Controls.Add(this.lblJaponYeni);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPound);
            this.Controls.Add(this.lblEURO);
            this.Controls.Add(this.lblDolar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "Form1";
            this.Text = "DÖVİZ KURLARI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblEURO;
        private System.Windows.Forms.Label lblPound;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblJaponYeni;
    }
}

