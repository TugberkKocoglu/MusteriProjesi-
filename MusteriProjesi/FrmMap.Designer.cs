namespace MusteriProjesi
{
    partial class FrmMap
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
            this.btnSehirAc = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSehirAc
            // 
            this.btnSehirAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSehirAc.Location = new System.Drawing.Point(98, 35);
            this.btnSehirAc.Name = "btnSehirAc";
            this.btnSehirAc.Size = new System.Drawing.Size(235, 64);
            this.btnSehirAc.TabIndex = 0;
            this.btnSehirAc.Text = "Şehir İşlemleri";
            this.btnSehirAc.UseVisualStyleBackColor = true;
            this.btnSehirAc.Click += new System.EventHandler(this.btnSehirAc_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.Location = new System.Drawing.Point(98, 168);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(235, 64);
            this.btnMusteri.TabIndex = 1;
            this.btnMusteri.Text = "Müşteri İşlemleri";
            this.btnMusteri.UseVisualStyleBackColor = true;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisYap.Location = new System.Drawing.Point(98, 317);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(235, 64);
            this.btnCikisYap.TabIndex = 2;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.btnSehirAc);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayfalar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSehirAc;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnCikisYap;
    }
}