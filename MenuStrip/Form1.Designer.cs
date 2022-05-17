
namespace MenuStrip
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
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniPencereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfaYapısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazdırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonrakiniBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öncekiniBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümünüSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatTarihToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tazıTipiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yakınlaştırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durumÇubuğuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözcükKaydırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yakınlaştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzaklaştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varsıyalnYakınlaştırmayıGeriYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.görünümToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.yeniPencereToolStripMenuItem,
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem,
            this.sayfaYapısıToolStripMenuItem,
            this.yazdırToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.ShowShortcutKeys = false;
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.silToolStripMenuItem,
            this.bulToolStripMenuItem,
            this.sonrakiniBulToolStripMenuItem,
            this.öncekiniBulToolStripMenuItem,
            this.değiştirToolStripMenuItem,
            this.gitToolStripMenuItem,
            this.tümünüSeçToolStripMenuItem,
            this.saatTarihToolStripMenuItem,
            this.tazıTipiToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yakınlaştırmaToolStripMenuItem,
            this.durumÇubuğuToolStripMenuItem,
            this.sözcükKaydırToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // yeniPencereToolStripMenuItem
            // 
            this.yeniPencereToolStripMenuItem.Name = "yeniPencereToolStripMenuItem";
            this.yeniPencereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniPencereToolStripMenuItem.Text = "Yeni Pencere";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "Aç";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            // 
            // sayfaYapısıToolStripMenuItem
            // 
            this.sayfaYapısıToolStripMenuItem.Name = "sayfaYapısıToolStripMenuItem";
            this.sayfaYapısıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sayfaYapısıToolStripMenuItem.Text = "Sayfa Yapısı";
            // 
            // yazdırToolStripMenuItem
            // 
            this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            this.yazdırToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yazdırToolStripMenuItem.Text = "Yazdır";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.geriAlToolStripMenuItem.Text = "Geri Al";
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // bulToolStripMenuItem
            // 
            this.bulToolStripMenuItem.Name = "bulToolStripMenuItem";
            this.bulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bulToolStripMenuItem.Text = "Bul";
            // 
            // sonrakiniBulToolStripMenuItem
            // 
            this.sonrakiniBulToolStripMenuItem.Name = "sonrakiniBulToolStripMenuItem";
            this.sonrakiniBulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sonrakiniBulToolStripMenuItem.Text = "Sonrakini Bul";
            // 
            // öncekiniBulToolStripMenuItem
            // 
            this.öncekiniBulToolStripMenuItem.Name = "öncekiniBulToolStripMenuItem";
            this.öncekiniBulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öncekiniBulToolStripMenuItem.Text = "Öncekini Bul";
            // 
            // değiştirToolStripMenuItem
            // 
            this.değiştirToolStripMenuItem.Name = "değiştirToolStripMenuItem";
            this.değiştirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.değiştirToolStripMenuItem.Text = "Değiştir";
            // 
            // gitToolStripMenuItem
            // 
            this.gitToolStripMenuItem.Name = "gitToolStripMenuItem";
            this.gitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gitToolStripMenuItem.Text = "Git";
            // 
            // tümünüSeçToolStripMenuItem
            // 
            this.tümünüSeçToolStripMenuItem.Name = "tümünüSeçToolStripMenuItem";
            this.tümünüSeçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tümünüSeçToolStripMenuItem.Text = "Tümünü Seç";
            // 
            // saatTarihToolStripMenuItem
            // 
            this.saatTarihToolStripMenuItem.Name = "saatTarihToolStripMenuItem";
            this.saatTarihToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saatTarihToolStripMenuItem.Text = "Saat/Tarih";
            // 
            // tazıTipiToolStripMenuItem
            // 
            this.tazıTipiToolStripMenuItem.Name = "tazıTipiToolStripMenuItem";
            this.tazıTipiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tazıTipiToolStripMenuItem.Text = "Tazı Tipi";
            // 
            // yakınlaştırmaToolStripMenuItem
            // 
            this.yakınlaştırmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yakınlaştırToolStripMenuItem,
            this.uzaklaştırToolStripMenuItem,
            this.varsıyalnYakınlaştırmayıGeriYükleToolStripMenuItem});
            this.yakınlaştırmaToolStripMenuItem.Name = "yakınlaştırmaToolStripMenuItem";
            this.yakınlaştırmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yakınlaştırmaToolStripMenuItem.Text = "Yakınlaştırma";
            // 
            // durumÇubuğuToolStripMenuItem
            // 
            this.durumÇubuğuToolStripMenuItem.Checked = true;
            this.durumÇubuğuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.durumÇubuğuToolStripMenuItem.Name = "durumÇubuğuToolStripMenuItem";
            this.durumÇubuğuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.durumÇubuğuToolStripMenuItem.Text = "Durum Çubuğu";
            // 
            // sözcükKaydırToolStripMenuItem
            // 
            this.sözcükKaydırToolStripMenuItem.Checked = true;
            this.sözcükKaydırToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sözcükKaydırToolStripMenuItem.Name = "sözcükKaydırToolStripMenuItem";
            this.sözcükKaydırToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sözcükKaydırToolStripMenuItem.Text = "Sözcük Kaydır";
            // 
            // yakınlaştırToolStripMenuItem
            // 
            this.yakınlaştırToolStripMenuItem.Name = "yakınlaştırToolStripMenuItem";
            this.yakınlaştırToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.yakınlaştırToolStripMenuItem.Text = "Yakınlaştır";
            // 
            // uzaklaştırToolStripMenuItem
            // 
            this.uzaklaştırToolStripMenuItem.Name = "uzaklaştırToolStripMenuItem";
            this.uzaklaştırToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.uzaklaştırToolStripMenuItem.Text = "Uzaklaştır";
            // 
            // varsıyalnYakınlaştırmayıGeriYükleToolStripMenuItem
            // 
            this.varsıyalnYakınlaştırmayıGeriYükleToolStripMenuItem.Name = "varsıyalnYakınlaştırmayıGeriYükleToolStripMenuItem";
            this.varsıyalnYakınlaştırmayıGeriYükleToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.varsıyalnYakınlaştırmayıGeriYükleToolStripMenuItem.Text = "Varsıyaln Yakınlaştırmayı Geri Yükle";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(786, 394);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniPencereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfaYapısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazdırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonrakiniBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öncekiniBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümünüSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saatTarihToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tazıTipiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yakınlaştırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yakınlaştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzaklaştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varsıyalnYakınlaştırmayıGeriYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durumÇubuğuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözcükKaydırToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

