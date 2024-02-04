namespace ornek1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.özetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sezonSayısını1ArtırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toplamBölümSayısınıDosyayaYazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.özetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sezonSayısını1ArtırToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // özetToolStripMenuItem
            // 
            this.özetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplamBölümSayısınıDosyayaYazToolStripMenuItem});
            this.özetToolStripMenuItem.Name = "özetToolStripMenuItem";
            this.özetToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.özetToolStripMenuItem.Text = "Özet";
            // 
            // sezonSayısını1ArtırToolStripMenuItem
            // 
            this.sezonSayısını1ArtırToolStripMenuItem.Name = "sezonSayısını1ArtırToolStripMenuItem";
            this.sezonSayısını1ArtırToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.sezonSayısını1ArtırToolStripMenuItem.Text = "Sezon Sayısını Br Arttır";
            this.sezonSayısını1ArtırToolStripMenuItem.Click += new System.EventHandler(this.sezonSayısını1ArtırToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(89, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Platformumuzdaki Toplam Bölüm Sayısı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 203);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 62);
            this.textBox1.TabIndex = 2;
            // 
            // toplamBölümSayısınıDosyayaYazToolStripMenuItem
            // 
            this.toplamBölümSayısınıDosyayaYazToolStripMenuItem.Name = "toplamBölümSayısınıDosyayaYazToolStripMenuItem";
            this.toplamBölümSayısınıDosyayaYazToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.toplamBölümSayısınıDosyayaYazToolStripMenuItem.Text = "Toplam Bölüm Sayısını Dosyaya Yaz";
            this.toplamBölümSayısınıDosyayaYazToolStripMenuItem.Click += new System.EventHandler(this.toplamBölümSayısınıDosyayaYazToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sezonSayısını1ArtırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem özetToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem toplamBölümSayısınıDosyayaYazToolStripMenuItem;
    }
}

