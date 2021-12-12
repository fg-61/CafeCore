
namespace CafeCore
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnfrmKatEkle = new System.Windows.Forms.Button();
            this.btnfrmMasaEkle = new System.Windows.Forms.Button();
            this.btnfrmMenuEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnfrmKatEkle
            // 
            this.btnfrmKatEkle.Location = new System.Drawing.Point(200, 103);
            this.btnfrmKatEkle.Name = "btnfrmKatEkle";
            this.btnfrmKatEkle.Size = new System.Drawing.Size(82, 60);
            this.btnfrmKatEkle.TabIndex = 0;
            this.btnfrmKatEkle.Text = "Kat Ekle";
            this.btnfrmKatEkle.UseVisualStyleBackColor = true;
            this.btnfrmKatEkle.Click += new System.EventHandler(this.btnfrmKatEkle_Click);
            // 
            // btnfrmMasaEkle
            // 
            this.btnfrmMasaEkle.Location = new System.Drawing.Point(299, 103);
            this.btnfrmMasaEkle.Name = "btnfrmMasaEkle";
            this.btnfrmMasaEkle.Size = new System.Drawing.Size(82, 60);
            this.btnfrmMasaEkle.TabIndex = 1;
            this.btnfrmMasaEkle.Text = "Masa Ekle";
            this.btnfrmMasaEkle.UseVisualStyleBackColor = true;
            this.btnfrmMasaEkle.Click += new System.EventHandler(this.btnfrmMasaEkle_Click);
            // 
            // btnfrmMenuEkle
            // 
            this.btnfrmMenuEkle.Location = new System.Drawing.Point(200, 169);
            this.btnfrmMenuEkle.Name = "btnfrmMenuEkle";
            this.btnfrmMenuEkle.Size = new System.Drawing.Size(181, 47);
            this.btnfrmMenuEkle.TabIndex = 2;
            this.btnfrmMenuEkle.Text = "Menu Ekle";
            this.btnfrmMenuEkle.UseVisualStyleBackColor = true;
            this.btnfrmMenuEkle.Click += new System.EventHandler(this.btnfrmMenuEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 340);
            this.Controls.Add(this.btnfrmMenuEkle);
            this.Controls.Add(this.btnfrmMasaEkle);
            this.Controls.Add(this.btnfrmKatEkle);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfrmKatEkle;
        private System.Windows.Forms.Button btnfrmMasaEkle;
        private System.Windows.Forms.Button btnfrmMenuEkle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

