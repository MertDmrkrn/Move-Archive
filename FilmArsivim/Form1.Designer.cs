
namespace FilmArsivim
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_Tam = new System.Windows.Forms.Button();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.Btn_Hakkimiz = new System.Windows.Forms.Button();
            this.Btn_Renk = new System.Windows.Forms.Button();
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfilmad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(223, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİNEMA KOLTUK YAZILIM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.Btn_Kaydet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtlink);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtkategori);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfilmad);
            this.groupBox1.Location = new System.Drawing.Point(9, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 438);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Film";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_Tam);
            this.groupBox4.Controls.Add(this.Btn_Cikis);
            this.groupBox4.Controls.Add(this.Btn_Hakkimiz);
            this.groupBox4.Controls.Add(this.Btn_Renk);
            this.groupBox4.Location = new System.Drawing.Point(6, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 253);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // Btn_Tam
            // 
            this.Btn_Tam.Location = new System.Drawing.Point(13, 59);
            this.Btn_Tam.Name = "Btn_Tam";
            this.Btn_Tam.Size = new System.Drawing.Size(209, 37);
            this.Btn_Tam.TabIndex = 10;
            this.Btn_Tam.Text = "Tam Ekran";
            this.Btn_Tam.UseVisualStyleBackColor = true;
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.Location = new System.Drawing.Point(12, 188);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(210, 37);
            this.Btn_Cikis.TabIndex = 13;
            this.Btn_Cikis.Text = "Çıkış";
            this.Btn_Cikis.UseVisualStyleBackColor = true;
            this.Btn_Cikis.Click += new System.EventHandler(this.Btn_Cikis_Click);
            // 
            // Btn_Hakkimiz
            // 
            this.Btn_Hakkimiz.Location = new System.Drawing.Point(12, 102);
            this.Btn_Hakkimiz.Name = "Btn_Hakkimiz";
            this.Btn_Hakkimiz.Size = new System.Drawing.Size(210, 37);
            this.Btn_Hakkimiz.TabIndex = 11;
            this.Btn_Hakkimiz.Text = "Hakkımızda";
            this.Btn_Hakkimiz.UseVisualStyleBackColor = true;
            this.Btn_Hakkimiz.Click += new System.EventHandler(this.Btn_Hakkimiz_Click);
            // 
            // Btn_Renk
            // 
            this.Btn_Renk.Location = new System.Drawing.Point(12, 145);
            this.Btn_Renk.Name = "Btn_Renk";
            this.Btn_Renk.Size = new System.Drawing.Size(210, 37);
            this.Btn_Renk.TabIndex = 12;
            this.Btn_Renk.Text = "Renk Değiştir";
            this.Btn_Renk.UseVisualStyleBackColor = true;
//            this.Btn_Renk.Click += new System.EventHandler(this.Btn_Renk_Click);
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Location = new System.Drawing.Point(90, 134);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(149, 37);
            this.Btn_Kaydet.TabIndex = 9;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.UseVisualStyleBackColor = true;
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Link:";
            // 
            // txtlink
            // 
            this.txtlink.Location = new System.Drawing.Point(90, 102);
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(149, 26);
            this.txtlink.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori:";
            // 
            // txtkategori
            // 
            this.txtkategori.Location = new System.Drawing.Point(90, 66);
            this.txtkategori.Name = "txtkategori";
            this.txtkategori.Size = new System.Drawing.Size(149, 26);
            this.txtkategori.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Film Adı:";
            // 
            // txtfilmad
            // 
            this.txtfilmad.Location = new System.Drawing.Point(90, 31);
            this.txtfilmad.Name = "txtfilmad";
            this.txtfilmad.Size = new System.Drawing.Size(149, 26);
            this.txtfilmad.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(260, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 438);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Film Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(239, 413);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.webBrowser1);
            this.groupBox3.Location = new System.Drawing.Point(511, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 435);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 22);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(554, 410);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1072, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfilmad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_Cikis;
        private System.Windows.Forms.Button Btn_Renk;
        private System.Windows.Forms.Button Btn_Hakkimiz;
        private System.Windows.Forms.Button Btn_Tam;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

