namespace htemurtas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aMenu = new System.Windows.Forms.MenuStrip();
            this.aOyun = new System.Windows.Forms.ToolStripMenuItem();
            this.aYeniOyun = new System.Windows.Forms.ToolStripMenuItem();
            this.aAynıOyun = new System.Windows.Forms.ToolStripMenuItem();
            this.aAçıkOyun = new System.Windows.Forms.ToolStripMenuItem();
            this.aÇıkış = new System.Windows.Forms.ToolStripMenuItem();
            this.aBilgi = new System.Windows.Forms.ToolStripMenuItem();
            this.aRekorlar = new System.Windows.Forms.ToolStripMenuItem();
            this.aİsimGir = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cDevam = new System.Windows.Forms.ToolStripMenuItem();
            this.cYeniOyun = new System.Windows.Forms.ToolStripMenuItem();
            this.cAynıOyun = new System.Windows.Forms.ToolStripMenuItem();
            this.cAçıkOyun = new System.Windows.Forms.ToolStripMenuItem();
            this.cÇıkış = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl = new System.Windows.Forms.Panel();
            this.Tmr = new System.Windows.Forms.Timer(this.components);
            this.ImList = new System.Windows.Forms.ImageList(this.components);
            this.aMenu.SuspendLayout();
            this.cMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // aMenu
            // 
            this.aMenu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aOyun,
            this.aBilgi,
            this.aRekorlar,
            this.aİsimGir});
            this.aMenu.Location = new System.Drawing.Point(0, 0);
            this.aMenu.Name = "aMenu";
            this.aMenu.Size = new System.Drawing.Size(548, 27);
            this.aMenu.TabIndex = 0;
            // 
            // aOyun
            // 
            this.aOyun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aYeniOyun,
            this.aAynıOyun,
            this.aAçıkOyun,
            this.aÇıkış});
            this.aOyun.Name = "aOyun";
            this.aOyun.Size = new System.Drawing.Size(57, 23);
            this.aOyun.Text = "Oyun";
            // 
            // aYeniOyun
            // 
            this.aYeniOyun.Name = "aYeniOyun";
            this.aYeniOyun.Size = new System.Drawing.Size(159, 24);
            this.aYeniOyun.Text = "Yeni Oyun";
            this.aYeniOyun.Click += new System.EventHandler(this.YeniOyun_Click);
            // 
            // aAynıOyun
            // 
            this.aAynıOyun.Name = "aAynıOyun";
            this.aAynıOyun.Size = new System.Drawing.Size(159, 24);
            this.aAynıOyun.Text = "Aynı Oyun";
            this.aAynıOyun.Click += new System.EventHandler(this.AynıOyun_Click);
            // 
            // aAçıkOyun
            // 
            this.aAçıkOyun.Name = "aAçıkOyun";
            this.aAçıkOyun.Size = new System.Drawing.Size(159, 24);
            this.aAçıkOyun.Text = "Açık Oyun";
            this.aAçıkOyun.Click += new System.EventHandler(this.AçıkOyun_Click);
            // 
            // aÇıkış
            // 
            this.aÇıkış.Name = "aÇıkış";
            this.aÇıkış.Size = new System.Drawing.Size(159, 24);
            this.aÇıkış.Text = "Çıkış";
            this.aÇıkış.Click += new System.EventHandler(this.Çıkış_Click);
            // 
            // aBilgi
            // 
            this.aBilgi.Name = "aBilgi";
            this.aBilgi.Size = new System.Drawing.Size(66, 23);
            this.aBilgi.Text = "Bilgi";
            this.aBilgi.Click += new System.EventHandler(this.Bilgi_Click);
            // 
            // aRekorlar
            // 
            this.aRekorlar.Name = "aRekorlar";
            this.aRekorlar.Size = new System.Drawing.Size(93, 23);
            this.aRekorlar.Text = "Rekorlar";
            this.aRekorlar.Click += new System.EventHandler(this.Rekorlar_Click);
            // 
            // aİsimGir
            // 
            this.aİsimGir.Name = "aİsimGir";
            this.aİsimGir.Size = new System.Drawing.Size(93, 23);
            this.aİsimGir.Text = "İsim Gir";
            this.aİsimGir.Click += new System.EventHandler(this.İsimGir_Click);
            // 
            // cMenu
            // 
            this.cMenu.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cDevam,
            this.cYeniOyun,
            this.cAynıOyun,
            this.cAçıkOyun,
            this.cÇıkış});
            this.cMenu.Name = "cMenu";
            this.cMenu.Size = new System.Drawing.Size(160, 124);
            // 
            // cDevam
            // 
            this.cDevam.Name = "cDevam";
            this.cDevam.Size = new System.Drawing.Size(159, 24);
            this.cDevam.Text = "Devam";
            // 
            // cYeniOyun
            // 
            this.cYeniOyun.Name = "cYeniOyun";
            this.cYeniOyun.Size = new System.Drawing.Size(159, 24);
            this.cYeniOyun.Text = "Yeni Oyun";
            this.cYeniOyun.Click += new System.EventHandler(this.YeniOyun_Click);
            // 
            // cAynıOyun
            // 
            this.cAynıOyun.Name = "cAynıOyun";
            this.cAynıOyun.Size = new System.Drawing.Size(159, 24);
            this.cAynıOyun.Text = "Aynı Oyun";
            this.cAynıOyun.Click += new System.EventHandler(this.AynıOyun_Click);
            // 
            // cAçıkOyun
            // 
            this.cAçıkOyun.Name = "cAçıkOyun";
            this.cAçıkOyun.Size = new System.Drawing.Size(159, 24);
            this.cAçıkOyun.Text = "Açık Oyun";
            this.cAçıkOyun.Click += new System.EventHandler(this.AçıkOyun_Click);
            // 
            // cÇıkış
            // 
            this.cÇıkış.Name = "cÇıkış";
            this.cÇıkış.Size = new System.Drawing.Size(159, 24);
            this.cÇıkış.Text = "Çıkış";
            this.cÇıkış.Click += new System.EventHandler(this.Çıkış_Click);
            // 
            // Pnl
            // 
            this.Pnl.Location = new System.Drawing.Point(40, 70);
            this.Pnl.Name = "Pnl";
            this.Pnl.Size = new System.Drawing.Size(399, 211);
            this.Pnl.TabIndex = 2;
            // 
            // Tmr
            // 
            this.Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // ImList
            // 
            this.ImList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImList.ImageStream")));
            this.ImList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImList.Images.SetKeyName(0, "Pic00.jpg");
            this.ImList.Images.SetKeyName(1, "Pic01.jpg");
            this.ImList.Images.SetKeyName(2, "Pic02.jpg");
            this.ImList.Images.SetKeyName(3, "Pic03.jpg");
            this.ImList.Images.SetKeyName(4, "Pic04.jpg");
            this.ImList.Images.SetKeyName(5, "Pic05.jpg");
            this.ImList.Images.SetKeyName(6, "Pic06.jpg");
            this.ImList.Images.SetKeyName(7, "Pic07.jpg");
            this.ImList.Images.SetKeyName(8, "Pic08.jpg");
            this.ImList.Images.SetKeyName(9, "Pic09.jpg");
            this.ImList.Images.SetKeyName(10, "Pic10.jpg");
            this.ImList.Images.SetKeyName(11, "Pic11.jpg");
            this.ImList.Images.SetKeyName(12, "Pic12.jpg");
            this.ImList.Images.SetKeyName(13, "Pic13.jpg");
            this.ImList.Images.SetKeyName(14, "Pic14.jpg");
            this.ImList.Images.SetKeyName(15, "Pic15.jpg");
            this.ImList.Images.SetKeyName(16, "Pic16.jpg");
            this.ImList.Images.SetKeyName(17, "Pic17.jpg");
            this.ImList.Images.SetKeyName(18, "Pic18.jpg");
            this.ImList.Images.SetKeyName(19, "Pic19.jpg");
            this.ImList.Images.SetKeyName(20, "Pic20.jpg");
            this.ImList.Images.SetKeyName(21, "Pic21.jpg");
            this.ImList.Images.SetKeyName(22, "Pic22.jpg");
            this.ImList.Images.SetKeyName(23, "Pic23.jpg");
            this.ImList.Images.SetKeyName(24, "Pic24.jpg");
            this.ImList.Images.SetKeyName(25, "Pic25.jpg");
            this.ImList.Images.SetKeyName(26, "Pic26.jpg");
            this.ImList.Images.SetKeyName(27, "Pic27.jpg");
            this.ImList.Images.SetKeyName(28, "Pic28.jpg");
            this.ImList.Images.SetKeyName(29, "Pic29.jpg");
            this.ImList.Images.SetKeyName(30, "Pic30.jpg");
            this.ImList.Images.SetKeyName(31, "Pic31.jpg");
            this.ImList.Images.SetKeyName(32, "Pic32.jpg");
            this.ImList.Images.SetKeyName(33, "Pic33.jpg");
            this.ImList.Images.SetKeyName(34, "Pic34.jpg");
            this.ImList.Images.SetKeyName(35, "Pic35.jpg");
            this.ImList.Images.SetKeyName(36, "Pic36.jpg");
            this.ImList.Images.SetKeyName(37, "Pic37.jpg");
            this.ImList.Images.SetKeyName(38, "Pic38.jpg");
            this.ImList.Images.SetKeyName(39, "Pic39.jpg");
            this.ImList.Images.SetKeyName(40, "Pic40.jpg");
            this.ImList.Images.SetKeyName(41, "Pic41.jpg");
            this.ImList.Images.SetKeyName(42, "Pic42.jpg");
            this.ImList.Images.SetKeyName(43, "Pic43.jpg");
            this.ImList.Images.SetKeyName(44, "Pic44.jpg");
            this.ImList.Images.SetKeyName(45, "Pic45.jpg");
            this.ImList.Images.SetKeyName(46, "Pic46.jpg");
            this.ImList.Images.SetKeyName(47, "Pic47.jpg");
            this.ImList.Images.SetKeyName(48, "Pic48.jpg");
            this.ImList.Images.SetKeyName(49, "Pic49.jpg");
            this.ImList.Images.SetKeyName(50, "Pic50.jpg");
            this.ImList.Images.SetKeyName(51, "Pic51.jpg");
            this.ImList.Images.SetKeyName(52, "Pic52.jpg");
            this.ImList.Images.SetKeyName(53, "Pic53.jpg");
            this.ImList.Images.SetKeyName(54, "Pic54.jpg");
            this.ImList.Images.SetKeyName(55, "Pic55.jpg");
            this.ImList.Images.SetKeyName(56, "Pic56.jpg");
            this.ImList.Images.SetKeyName(57, "Pic57.jpg");
            this.ImList.Images.SetKeyName(58, "Pic58.jpg");
            this.ImList.Images.SetKeyName(59, "Pic59.jpg");
            this.ImList.Images.SetKeyName(60, "Pic60.jpg");
            this.ImList.Images.SetKeyName(61, "Pic61.jpg");
            this.ImList.Images.SetKeyName(62, "Pic62.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 389);
            this.Controls.Add(this.Pnl);
            this.Controls.Add(this.aMenu);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.aMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H a s a n     T E M U R T A Ş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.aMenu.ResumeLayout(false);
            this.aMenu.PerformLayout();
            this.cMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip aMenu;
        private System.Windows.Forms.ToolStripMenuItem aOyun;
        private System.Windows.Forms.ToolStripMenuItem aYeniOyun;
        private System.Windows.Forms.ToolStripMenuItem aAynıOyun;
        private System.Windows.Forms.ToolStripMenuItem aAçıkOyun;
        private System.Windows.Forms.ToolStripMenuItem aÇıkış;
        private System.Windows.Forms.ToolStripMenuItem aBilgi;
        private System.Windows.Forms.ToolStripMenuItem aRekorlar;
        private System.Windows.Forms.ToolStripMenuItem aİsimGir;
        private System.Windows.Forms.ContextMenuStrip cMenu;
        private System.Windows.Forms.ToolStripMenuItem cDevam;
        private System.Windows.Forms.ToolStripMenuItem cYeniOyun;
        private System.Windows.Forms.ToolStripMenuItem cAynıOyun;
        private System.Windows.Forms.ToolStripMenuItem cAçıkOyun;
        private System.Windows.Forms.ToolStripMenuItem cÇıkış;
        private System.Windows.Forms.Panel Pnl;
        private System.Windows.Forms.Timer Tmr;
        private System.Windows.Forms.ImageList ImList;
    }
}

