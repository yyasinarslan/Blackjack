namespace Blackjack
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabbahis = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.taboyun = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabbilgi = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxbhs = new System.Windows.Forms.GroupBox();
            this.buton600 = new System.Windows.Forms.Button();
            this.buton400 = new System.Windows.Forms.Button();
            this.buton300 = new System.Windows.Forms.Button();
            this.buton500 = new System.Windows.Forms.Button();
            this.buton200 = new System.Windows.Forms.Button();
            this.buton100 = new System.Windows.Forms.Button();
            this.butonart = new System.Windows.Forms.Button();
            this.labelbhs = new System.Windows.Forms.Label();
            this.butonaz = new System.Windows.Forms.Button();
            this.groupBoxkisayol = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxbilgi = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelbilgiwho = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelbilgibhs = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabbahis.SuspendLayout();
            this.taboyun.SuspendLayout();
            this.groupBoxbhs.SuspendLayout();
            this.groupBoxkisayol.SuspendLayout();
            this.groupBoxbilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabbilgi);
            this.tabControl1.Controls.Add(this.tabbahis);
            this.tabControl1.Controls.Add(this.taboyun);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 712);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabbahis
            // 
            this.tabbahis.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabbahis.Controls.Add(this.label1);
            this.tabbahis.Controls.Add(this.groupBoxbhs);
            this.tabbahis.Controls.Add(this.textBox1);
            this.tabbahis.Controls.Add(this.label3);
            this.tabbahis.Controls.Add(this.label2);
            this.tabbahis.Location = new System.Drawing.Point(4, 38);
            this.tabbahis.Name = "tabbahis";
            this.tabbahis.Padding = new System.Windows.Forms.Padding(3);
            this.tabbahis.Size = new System.Drawing.Size(1030, 670);
            this.tabbahis.TabIndex = 0;
            this.tabbahis.Text = "Bahis";
            this.tabbahis.Click += new System.EventHandler(this.tabbahis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(365, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bahis Kutusu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // taboyun
            // 
            this.taboyun.BackColor = System.Drawing.Color.Green;
            this.taboyun.Controls.Add(this.groupBoxbilgi);
            this.taboyun.Location = new System.Drawing.Point(4, 38);
            this.taboyun.Name = "taboyun";
            this.taboyun.Padding = new System.Windows.Forms.Padding(3);
            this.taboyun.Size = new System.Drawing.Size(1030, 670);
            this.taboyun.TabIndex = 1;
            this.taboyun.Text = "21";
            this.taboyun.Click += new System.EventHandler(this.taboyun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabbilgi
            // 
            this.tabbilgi.BackColor = System.Drawing.Color.DarkSalmon;
            this.tabbilgi.Location = new System.Drawing.Point(4, 38);
            this.tabbilgi.Name = "tabbilgi";
            this.tabbilgi.Size = new System.Drawing.Size(1030, 670);
            this.tabbilgi.TabIndex = 2;
            this.tabbilgi.Text = "Bilgilendirme";
            this.tabbilgi.Click += new System.EventHandler(this.tabbilgi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(200, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 38);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxbhs
            // 
            this.groupBoxbhs.Controls.Add(this.button2);
            this.groupBoxbhs.Controls.Add(this.groupBoxkisayol);
            this.groupBoxbhs.Controls.Add(this.butonart);
            this.groupBoxbhs.Controls.Add(this.labelbhs);
            this.groupBoxbhs.Controls.Add(this.butonaz);
            this.groupBoxbhs.Location = new System.Drawing.Point(70, 166);
            this.groupBoxbhs.Name = "groupBoxbhs";
            this.groupBoxbhs.Size = new System.Drawing.Size(432, 482);
            this.groupBoxbhs.TabIndex = 4;
            this.groupBoxbhs.TabStop = false;
            this.groupBoxbhs.Text = "Bahis Miktarı";
            this.groupBoxbhs.Visible = false;
            this.groupBoxbhs.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buton600
            // 
            this.buton600.BackColor = System.Drawing.SystemColors.Info;
            this.buton600.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton600.ForeColor = System.Drawing.Color.Chocolate;
            this.buton600.Location = new System.Drawing.Point(111, 145);
            this.buton600.Name = "buton600";
            this.buton600.Size = new System.Drawing.Size(78, 54);
            this.buton600.TabIndex = 20;
            this.buton600.Text = "600";
            this.buton600.UseVisualStyleBackColor = false;
            this.buton600.Click += new System.EventHandler(this.buton600_Click);
            // 
            // buton400
            // 
            this.buton400.BackColor = System.Drawing.SystemColors.Info;
            this.buton400.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton400.ForeColor = System.Drawing.Color.Chocolate;
            this.buton400.Location = new System.Drawing.Point(111, 25);
            this.buton400.Name = "buton400";
            this.buton400.Size = new System.Drawing.Size(78, 54);
            this.buton400.TabIndex = 19;
            this.buton400.Text = "400";
            this.buton400.UseVisualStyleBackColor = false;
            this.buton400.Click += new System.EventHandler(this.buton400_Click);
            // 
            // buton300
            // 
            this.buton300.BackColor = System.Drawing.SystemColors.Info;
            this.buton300.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton300.ForeColor = System.Drawing.Color.Chocolate;
            this.buton300.Location = new System.Drawing.Point(27, 145);
            this.buton300.Name = "buton300";
            this.buton300.Size = new System.Drawing.Size(78, 54);
            this.buton300.TabIndex = 18;
            this.buton300.Text = "300";
            this.buton300.UseVisualStyleBackColor = false;
            this.buton300.Click += new System.EventHandler(this.buton300_Click);
            // 
            // buton500
            // 
            this.buton500.BackColor = System.Drawing.SystemColors.Info;
            this.buton500.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton500.ForeColor = System.Drawing.Color.Chocolate;
            this.buton500.Location = new System.Drawing.Point(111, 85);
            this.buton500.Name = "buton500";
            this.buton500.Size = new System.Drawing.Size(78, 54);
            this.buton500.TabIndex = 17;
            this.buton500.Text = "500";
            this.buton500.UseVisualStyleBackColor = false;
            this.buton500.Click += new System.EventHandler(this.buton500_Click);
            // 
            // buton200
            // 
            this.buton200.BackColor = System.Drawing.SystemColors.Info;
            this.buton200.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton200.ForeColor = System.Drawing.Color.Chocolate;
            this.buton200.Location = new System.Drawing.Point(27, 85);
            this.buton200.Name = "buton200";
            this.buton200.Size = new System.Drawing.Size(78, 54);
            this.buton200.TabIndex = 16;
            this.buton200.Text = "200";
            this.buton200.UseVisualStyleBackColor = false;
            this.buton200.Click += new System.EventHandler(this.buton200_Click);
            // 
            // buton100
            // 
            this.buton100.BackColor = System.Drawing.SystemColors.Info;
            this.buton100.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton100.ForeColor = System.Drawing.Color.Chocolate;
            this.buton100.Location = new System.Drawing.Point(27, 25);
            this.buton100.Name = "buton100";
            this.buton100.Size = new System.Drawing.Size(78, 54);
            this.buton100.TabIndex = 15;
            this.buton100.Text = "100";
            this.buton100.UseVisualStyleBackColor = false;
            this.buton100.Click += new System.EventHandler(this.buton100_Click);
            // 
            // butonart
            // 
            this.butonart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonart.ForeColor = System.Drawing.Color.Chocolate;
            this.butonart.Location = new System.Drawing.Point(305, 62);
            this.butonart.Name = "butonart";
            this.butonart.Size = new System.Drawing.Size(105, 86);
            this.butonart.TabIndex = 12;
            this.butonart.Text = "+10";
            this.butonart.UseVisualStyleBackColor = true;
            this.butonart.Click += new System.EventHandler(this.butonart_Click);
            // 
            // labelbhs
            // 
            this.labelbhs.AutoSize = true;
            this.labelbhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbhs.Location = new System.Drawing.Point(171, 84);
            this.labelbhs.Name = "labelbhs";
            this.labelbhs.Size = new System.Drawing.Size(36, 39);
            this.labelbhs.TabIndex = 14;
            this.labelbhs.Text = "0";
            this.labelbhs.Click += new System.EventHandler(this.labelbhs_Click);
            // 
            // butonaz
            // 
            this.butonaz.Enabled = false;
            this.butonaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.butonaz.ForeColor = System.Drawing.Color.Chocolate;
            this.butonaz.Location = new System.Drawing.Point(28, 62);
            this.butonaz.Name = "butonaz";
            this.butonaz.Size = new System.Drawing.Size(105, 86);
            this.butonaz.TabIndex = 13;
            this.butonaz.Text = "-10";
            this.butonaz.UseVisualStyleBackColor = true;
            this.butonaz.Click += new System.EventHandler(this.butonaz_Click);
            // 
            // groupBoxkisayol
            // 
            this.groupBoxkisayol.Controls.Add(this.buton100);
            this.groupBoxkisayol.Controls.Add(this.buton600);
            this.groupBoxkisayol.Controls.Add(this.buton200);
            this.groupBoxkisayol.Controls.Add(this.buton400);
            this.groupBoxkisayol.Controls.Add(this.buton500);
            this.groupBoxkisayol.Controls.Add(this.buton300);
            this.groupBoxkisayol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxkisayol.Location = new System.Drawing.Point(28, 173);
            this.groupBoxkisayol.Name = "groupBoxkisayol";
            this.groupBoxkisayol.Size = new System.Drawing.Size(212, 211);
            this.groupBoxkisayol.TabIndex = 21;
            this.groupBoxkisayol.TabStop = false;
            this.groupBoxkisayol.Text = "Kısayollar";
            this.groupBoxkisayol.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Chocolate;
            this.button2.Location = new System.Drawing.Point(167, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 44);
            this.button2.TabIndex = 22;
            this.button2.Text = "Bahis Miktarını Kaydet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(461, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bahis Kutusu Kapanmıştır.";
            this.label1.Visible = false;
            // 
            // groupBoxbilgi
            // 
            this.groupBoxbilgi.Controls.Add(this.labelbilgibhs);
            this.groupBoxbilgi.Controls.Add(this.label6);
            this.groupBoxbilgi.Controls.Add(this.labelbilgiwho);
            this.groupBoxbilgi.Controls.Add(this.label4);
            this.groupBoxbilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxbilgi.Location = new System.Drawing.Point(3, 6);
            this.groupBoxbilgi.Name = "groupBoxbilgi";
            this.groupBoxbilgi.Size = new System.Drawing.Size(326, 97);
            this.groupBoxbilgi.TabIndex = 0;
            this.groupBoxbilgi.TabStop = false;
            this.groupBoxbilgi.Text = "Bilgiler";
            this.groupBoxbilgi.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ad Soyad:";
            // 
            // labelbilgiwho
            // 
            this.labelbilgiwho.AutoSize = true;
            this.labelbilgiwho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbilgiwho.Location = new System.Drawing.Point(96, 30);
            this.labelbilgiwho.Name = "labelbilgiwho";
            this.labelbilgiwho.Size = new System.Drawing.Size(39, 20);
            this.labelbilgiwho.TabIndex = 4;
            this.labelbilgiwho.Text = "who";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bahis Miktarı:";
            // 
            // labelbilgibhs
            // 
            this.labelbilgibhs.AutoSize = true;
            this.labelbilgibhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelbilgibhs.Location = new System.Drawing.Point(124, 66);
            this.labelbilgibhs.Name = "labelbilgibhs";
            this.labelbilgibhs.Size = new System.Drawing.Size(18, 20);
            this.labelbilgibhs.TabIndex = 6;
            this.labelbilgibhs.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1038, 712);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabbahis.ResumeLayout(false);
            this.tabbahis.PerformLayout();
            this.taboyun.ResumeLayout(false);
            this.groupBoxbhs.ResumeLayout(false);
            this.groupBoxbhs.PerformLayout();
            this.groupBoxkisayol.ResumeLayout(false);
            this.groupBoxbilgi.ResumeLayout(false);
            this.groupBoxbilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabbahis;
        private System.Windows.Forms.TabPage taboyun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabbilgi;
        private System.Windows.Forms.GroupBox groupBoxbhs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxkisayol;
        private System.Windows.Forms.Button buton100;
        private System.Windows.Forms.Button buton600;
        private System.Windows.Forms.Button buton200;
        private System.Windows.Forms.Button buton400;
        private System.Windows.Forms.Button buton500;
        private System.Windows.Forms.Button buton300;
        private System.Windows.Forms.Button butonart;
        private System.Windows.Forms.Label labelbhs;
        private System.Windows.Forms.Button butonaz;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxbilgi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelbilgibhs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelbilgiwho;
    }
}

