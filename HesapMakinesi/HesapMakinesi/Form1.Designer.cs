namespace HesapMakinesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ekranLabel = new System.Windows.Forms.Label();
            this.rakam0button = new System.Windows.Forms.Button();
            this.silmebutton = new System.Windows.Forms.Button();
            this.eşittirbutton = new System.Windows.Forms.Button();
            this.rakam3button = new System.Windows.Forms.Button();
            this.rakam1button = new System.Windows.Forms.Button();
            this.rakam2button = new System.Windows.Forms.Button();
            this.rakam6button = new System.Windows.Forms.Button();
            this.rakam4button = new System.Windows.Forms.Button();
            this.rakam5button = new System.Windows.Forms.Button();
            this.rakam9button = new System.Windows.Forms.Button();
            this.rakam7button = new System.Windows.Forms.Button();
            this.rakam8button = new System.Windows.Forms.Button();
            this.bölmebutton = new System.Windows.Forms.Button();
            this.çıkarmabutton = new System.Windows.Forms.Button();
            this.çarpmabutton = new System.Windows.Forms.Button();
            this.toplamabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekranLabel
            // 
            this.ekranLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekranLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekranLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ekranLabel.Location = new System.Drawing.Point(12, 18);
            this.ekranLabel.Name = "ekranLabel";
            this.ekranLabel.Size = new System.Drawing.Size(318, 112);
            this.ekranLabel.TabIndex = 0;
            this.ekranLabel.Text = "0";
            this.ekranLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ekranLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // rakam0button
            // 
            this.rakam0button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0button.Location = new System.Drawing.Point(93, 330);
            this.rakam0button.Name = "rakam0button";
            this.rakam0button.Size = new System.Drawing.Size(75, 54);
            this.rakam0button.TabIndex = 1;
            this.rakam0button.Text = "0";
            this.rakam0button.UseVisualStyleBackColor = true;
            this.rakam0button.Click += new System.EventHandler(this.rakam0button_Click);
            // 
            // silmebutton
            // 
            this.silmebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.silmebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silmebutton.Location = new System.Drawing.Point(12, 330);
            this.silmebutton.Name = "silmebutton";
            this.silmebutton.Size = new System.Drawing.Size(75, 54);
            this.silmebutton.TabIndex = 2;
            this.silmebutton.Text = "C";
            this.silmebutton.UseVisualStyleBackColor = false;
            // 
            // eşittirbutton
            // 
            this.eşittirbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eşittirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eşittirbutton.Location = new System.Drawing.Point(174, 330);
            this.eşittirbutton.Name = "eşittirbutton";
            this.eşittirbutton.Size = new System.Drawing.Size(75, 54);
            this.eşittirbutton.TabIndex = 10;
            this.eşittirbutton.Text = "=";
            this.eşittirbutton.UseVisualStyleBackColor = false;
            this.eşittirbutton.Click += new System.EventHandler(this.eşittirbutton_Click);
            // 
            // rakam3button
            // 
            this.rakam3button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3button.Location = new System.Drawing.Point(174, 270);
            this.rakam3button.Name = "rakam3button";
            this.rakam3button.Size = new System.Drawing.Size(75, 54);
            this.rakam3button.TabIndex = 13;
            this.rakam3button.Text = "3";
            this.rakam3button.UseVisualStyleBackColor = true;
            this.rakam3button.Click += new System.EventHandler(this.button4_Click);
            // 
            // rakam1button
            // 
            this.rakam1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1button.Location = new System.Drawing.Point(12, 270);
            this.rakam1button.Name = "rakam1button";
            this.rakam1button.Size = new System.Drawing.Size(75, 54);
            this.rakam1button.TabIndex = 12;
            this.rakam1button.Text = "1";
            this.rakam1button.UseVisualStyleBackColor = true;
            this.rakam1button.Click += new System.EventHandler(this.rakam1button_Click);
            // 
            // rakam2button
            // 
            this.rakam2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2button.Location = new System.Drawing.Point(93, 270);
            this.rakam2button.Name = "rakam2button";
            this.rakam2button.Size = new System.Drawing.Size(75, 54);
            this.rakam2button.TabIndex = 11;
            this.rakam2button.Text = "2";
            this.rakam2button.UseVisualStyleBackColor = true;
            this.rakam2button.Click += new System.EventHandler(this.rakam2button_Click);
            // 
            // rakam6button
            // 
            this.rakam6button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6button.Location = new System.Drawing.Point(174, 210);
            this.rakam6button.Name = "rakam6button";
            this.rakam6button.Size = new System.Drawing.Size(75, 54);
            this.rakam6button.TabIndex = 16;
            this.rakam6button.Text = "6";
            this.rakam6button.UseVisualStyleBackColor = true;
            this.rakam6button.Click += new System.EventHandler(this.rakam6button_Click);
            // 
            // rakam4button
            // 
            this.rakam4button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4button.Location = new System.Drawing.Point(12, 210);
            this.rakam4button.Name = "rakam4button";
            this.rakam4button.Size = new System.Drawing.Size(75, 54);
            this.rakam4button.TabIndex = 15;
            this.rakam4button.Text = "4";
            this.rakam4button.UseVisualStyleBackColor = true;
            this.rakam4button.Click += new System.EventHandler(this.button8_Click);
            // 
            // rakam5button
            // 
            this.rakam5button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5button.Location = new System.Drawing.Point(93, 210);
            this.rakam5button.Name = "rakam5button";
            this.rakam5button.Size = new System.Drawing.Size(75, 54);
            this.rakam5button.TabIndex = 14;
            this.rakam5button.Text = "5";
            this.rakam5button.UseVisualStyleBackColor = true;
            this.rakam5button.Click += new System.EventHandler(this.button9_Click);
            // 
            // rakam9button
            // 
            this.rakam9button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9button.Location = new System.Drawing.Point(174, 150);
            this.rakam9button.Name = "rakam9button";
            this.rakam9button.Size = new System.Drawing.Size(75, 54);
            this.rakam9button.TabIndex = 19;
            this.rakam9button.Text = "9";
            this.rakam9button.UseVisualStyleBackColor = true;
            this.rakam9button.Click += new System.EventHandler(this.rakam9button_Click);
            // 
            // rakam7button
            // 
            this.rakam7button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7button.Location = new System.Drawing.Point(12, 150);
            this.rakam7button.Name = "rakam7button";
            this.rakam7button.Size = new System.Drawing.Size(75, 54);
            this.rakam7button.TabIndex = 18;
            this.rakam7button.Text = "7";
            this.rakam7button.UseVisualStyleBackColor = true;
            this.rakam7button.Click += new System.EventHandler(this.rakam7button_Click);
            // 
            // rakam8button
            // 
            this.rakam8button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8button.Location = new System.Drawing.Point(93, 150);
            this.rakam8button.Name = "rakam8button";
            this.rakam8button.Size = new System.Drawing.Size(75, 54);
            this.rakam8button.TabIndex = 17;
            this.rakam8button.Text = "8";
            this.rakam8button.UseVisualStyleBackColor = true;
            this.rakam8button.Click += new System.EventHandler(this.rakam8button_Click);
            // 
            // bölmebutton
            // 
            this.bölmebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bölmebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bölmebutton.Location = new System.Drawing.Point(255, 330);
            this.bölmebutton.Name = "bölmebutton";
            this.bölmebutton.Size = new System.Drawing.Size(75, 54);
            this.bölmebutton.TabIndex = 22;
            this.bölmebutton.Text = "/";
            this.bölmebutton.UseVisualStyleBackColor = false;
            this.bölmebutton.Click += new System.EventHandler(this.button13_Click);
            // 
            // çıkarmabutton
            // 
            this.çıkarmabutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.çıkarmabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkarmabutton.Location = new System.Drawing.Point(255, 212);
            this.çıkarmabutton.Name = "çıkarmabutton";
            this.çıkarmabutton.Size = new System.Drawing.Size(75, 54);
            this.çıkarmabutton.TabIndex = 21;
            this.çıkarmabutton.Text = "-";
            this.çıkarmabutton.UseVisualStyleBackColor = false;
            this.çıkarmabutton.Click += new System.EventHandler(this.çıkarmabutton_Click);
            // 
            // çarpmabutton
            // 
            this.çarpmabutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.çarpmabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çarpmabutton.Location = new System.Drawing.Point(255, 272);
            this.çarpmabutton.Name = "çarpmabutton";
            this.çarpmabutton.Size = new System.Drawing.Size(75, 54);
            this.çarpmabutton.TabIndex = 20;
            this.çarpmabutton.Text = "x";
            this.çarpmabutton.UseVisualStyleBackColor = false;
            this.çarpmabutton.Click += new System.EventHandler(this.button15_Click);
            // 
            // toplamabutton
            // 
            this.toplamabutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toplamabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamabutton.Location = new System.Drawing.Point(255, 150);
            this.toplamabutton.Name = "toplamabutton";
            this.toplamabutton.Size = new System.Drawing.Size(75, 54);
            this.toplamabutton.TabIndex = 23;
            this.toplamabutton.Text = "+";
            this.toplamabutton.UseVisualStyleBackColor = false;
            this.toplamabutton.Click += new System.EventHandler(this.toplamabutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(345, 404);
            this.Controls.Add(this.toplamabutton);
            this.Controls.Add(this.bölmebutton);
            this.Controls.Add(this.çıkarmabutton);
            this.Controls.Add(this.çarpmabutton);
            this.Controls.Add(this.rakam9button);
            this.Controls.Add(this.rakam7button);
            this.Controls.Add(this.rakam8button);
            this.Controls.Add(this.rakam6button);
            this.Controls.Add(this.rakam4button);
            this.Controls.Add(this.rakam5button);
            this.Controls.Add(this.rakam3button);
            this.Controls.Add(this.rakam1button);
            this.Controls.Add(this.rakam2button);
            this.Controls.Add(this.eşittirbutton);
            this.Controls.Add(this.silmebutton);
            this.Controls.Add(this.rakam0button);
            this.Controls.Add(this.ekranLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranLabel;
        private System.Windows.Forms.Button rakam0button;
        private System.Windows.Forms.Button silmebutton;
        private System.Windows.Forms.Button eşittirbutton;
        private System.Windows.Forms.Button rakam3button;
        private System.Windows.Forms.Button rakam1button;
        private System.Windows.Forms.Button rakam2button;
        private System.Windows.Forms.Button rakam6button;
        private System.Windows.Forms.Button rakam4button;
        private System.Windows.Forms.Button rakam5button;
        private System.Windows.Forms.Button rakam9button;
        private System.Windows.Forms.Button rakam7button;
        private System.Windows.Forms.Button rakam8button;
        private System.Windows.Forms.Button bölmebutton;
        private System.Windows.Forms.Button çıkarmabutton;
        private System.Windows.Forms.Button çarpmabutton;
        private System.Windows.Forms.Button toplamabutton;
    }
}

