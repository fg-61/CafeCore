namespace CafeCore.Forms
{
    partial class FrmSiparisler
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
            this.tbl1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl1
            // 
            this.tbl1.ColumnCount = 2;
            this.tbl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbl1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tbl1.Controls.Add(this.label1, 0, 0);
            this.tbl1.Controls.Add(this.button1, 1, 0);
            this.tbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl1.Location = new System.Drawing.Point(0, 0);
            this.tbl1.Margin = new System.Windows.Forms.Padding(0);
            this.tbl1.Name = "tbl1";
            this.tbl1.RowCount = 2;
            this.tbl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbl1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tbl1.Size = new System.Drawing.Size(1296, 790);
            this.tbl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "masaIsmi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(1199, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 790);
            this.Controls.Add(this.tbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSiparisler";
            this.Text = "FrmSiparisler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSiparisler_Load);
            this.tbl1.ResumeLayout(false);
            this.tbl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}