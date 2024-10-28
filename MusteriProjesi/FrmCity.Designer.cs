namespace MusteriProjesi
{
    partial class FrmCity
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSehirId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtSehirAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir ID :";
            // 
            // txtSehirId
            // 
            this.txtSehirId.Location = new System.Drawing.Point(192, 85);
            this.txtSehirId.Name = "txtSehirId";
            this.txtSehirId.Size = new System.Drawing.Size(184, 22);
            this.txtSehirId.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(520, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 429);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(183, 284);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(193, 37);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtSehirAdi
            // 
            this.txtSehirAdi.Location = new System.Drawing.Point(192, 141);
            this.txtSehirAdi.Name = "txtSehirAdi";
            this.txtSehirAdi.Size = new System.Drawing.Size(184, 22);
            this.txtSehirAdi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şehir Adı :";
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(192, 210);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(184, 22);
            this.txtUlke.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ülke :";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(183, 349);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(193, 34);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(183, 421);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(193, 35);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(183, 498);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(193, 35);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(183, 567);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(193, 35);
            this.btnAra.TabIndex = 12;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // FrmCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1572, 633);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtUlke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSehirAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSehirId);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "FrmCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "City Process Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSehirId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtSehirAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAra;
    }
}

