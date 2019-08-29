namespace Hesapla
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
            this.components = new System.ComponentModel.Container();
            this.topla = new System.Windows.Forms.Button();
            this.cikar = new System.Windows.Forms.Button();
            this.bol = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sayi1 = new System.Windows.Forms.TextBox();
            this.esittir = new System.Windows.Forms.Button();
            this.sifirla = new System.Windows.Forms.Button();
            this.eksi_koy = new System.Windows.Forms.Button();
            this.yuzde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topla
            // 
            this.topla.Location = new System.Drawing.Point(212, 61);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(75, 23);
            this.topla.TabIndex = 0;
            this.topla.Text = "+";
            this.topla.UseVisualStyleBackColor = true;
            this.topla.Click += new System.EventHandler(this.Topla_Click);
            // 
            // cikar
            // 
            this.cikar.Location = new System.Drawing.Point(212, 102);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(75, 23);
            this.cikar.TabIndex = 1;
            this.cikar.Text = "-";
            this.cikar.UseVisualStyleBackColor = true;
            this.cikar.Click += new System.EventHandler(this.Cikar_Click);
            // 
            // bol
            // 
            this.bol.Location = new System.Drawing.Point(313, 61);
            this.bol.Name = "bol";
            this.bol.Size = new System.Drawing.Size(75, 23);
            this.bol.TabIndex = 2;
            this.bol.Text = "/";
            this.bol.UseVisualStyleBackColor = true;
            this.bol.Click += new System.EventHandler(this.Bol_Click);
            // 
            // carp
            // 
            this.carp.Location = new System.Drawing.Point(313, 102);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(75, 23);
            this.carp.TabIndex = 3;
            this.carp.Text = "*";
            this.carp.UseVisualStyleBackColor = true;
            this.carp.Click += new System.EventHandler(this.Carp_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sayi1
            // 
            this.sayi1.Location = new System.Drawing.Point(32, 24);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(131, 20);
            this.sayi1.TabIndex = 5;
            // 
            // esittir
            // 
            this.esittir.Location = new System.Drawing.Point(212, 152);
            this.esittir.Name = "esittir";
            this.esittir.Size = new System.Drawing.Size(176, 23);
            this.esittir.TabIndex = 7;
            this.esittir.Text = "=";
            this.esittir.UseVisualStyleBackColor = true;
            this.esittir.Click += new System.EventHandler(this.Esittir_Click);
            // 
            // sifirla
            // 
            this.sifirla.Location = new System.Drawing.Point(32, 62);
            this.sifirla.Name = "sifirla";
            this.sifirla.Size = new System.Drawing.Size(131, 23);
            this.sifirla.TabIndex = 8;
            this.sifirla.Text = "C";
            this.sifirla.UseVisualStyleBackColor = true;
            this.sifirla.Click += new System.EventHandler(this.Sifirla_Click);
            // 
            // eksi_koy
            // 
            this.eksi_koy.Location = new System.Drawing.Point(212, 20);
            this.eksi_koy.Name = "eksi_koy";
            this.eksi_koy.Size = new System.Drawing.Size(75, 23);
            this.eksi_koy.TabIndex = 9;
            this.eksi_koy.Text = "+/-";
            this.eksi_koy.UseVisualStyleBackColor = true;
            this.eksi_koy.Click += new System.EventHandler(this.Eksi_koy_Click);
            // 
            // yuzde
            // 
            this.yuzde.Location = new System.Drawing.Point(313, 21);
            this.yuzde.Name = "yuzde";
            this.yuzde.Size = new System.Drawing.Size(75, 23);
            this.yuzde.TabIndex = 10;
            this.yuzde.Text = "%";
            this.yuzde.UseVisualStyleBackColor = true;
            this.yuzde.Click += new System.EventHandler(this.Yuzde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 235);
            this.Controls.Add(this.yuzde);
            this.Controls.Add(this.eksi_koy);
            this.Controls.Add(this.sifirla);
            this.Controls.Add(this.esittir);
            this.Controls.Add(this.sayi1);
            this.Controls.Add(this.carp);
            this.Controls.Add(this.bol);
            this.Controls.Add(this.cikar);
            this.Controls.Add(this.topla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.Button cikar;
        private System.Windows.Forms.Button bol;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox sayi1;
        private System.Windows.Forms.Button esittir;
        private System.Windows.Forms.Button sifirla;
        private System.Windows.Forms.Button eksi_koy;
        private System.Windows.Forms.Button yuzde;
    }
}

