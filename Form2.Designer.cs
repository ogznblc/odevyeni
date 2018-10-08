namespace İmageprocess
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkGetirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xKor = new System.Windows.Forms.TextBox();
            this.yKor = new System.Windows.Forms.TextBox();
            this.kaynakBox = new System.Windows.Forms.PictureBox();
            this.renkBox = new System.Windows.Forms.PictureBox();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renkBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.renkGetirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // renkGetirToolStripMenuItem
            // 
            this.renkGetirToolStripMenuItem.Name = "renkGetirToolStripMenuItem";
            this.renkGetirToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.renkGetirToolStripMenuItem.Text = "Renk Getir";
            this.renkGetirToolStripMenuItem.Click += new System.EventHandler(this.renkGetirToolStripMenuItem_Click);
            // 
            // xKor
            // 
            this.xKor.Location = new System.Drawing.Point(506, 45);
            this.xKor.Name = "xKor";
            this.xKor.Size = new System.Drawing.Size(100, 20);
            this.xKor.TabIndex = 1;
            // 
            // yKor
            // 
            this.yKor.Location = new System.Drawing.Point(506, 90);
            this.yKor.Name = "yKor";
            this.yKor.Size = new System.Drawing.Size(100, 20);
            this.yKor.TabIndex = 2;
            this.yKor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // kaynakBox
            // 
            this.kaynakBox.Location = new System.Drawing.Point(12, 27);
            this.kaynakBox.Name = "kaynakBox";
            this.kaynakBox.Size = new System.Drawing.Size(460, 480);
            this.kaynakBox.TabIndex = 3;
            this.kaynakBox.TabStop = false;
            // 
            // renkBox
            // 
            this.renkBox.Location = new System.Drawing.Point(506, 151);
            this.renkBox.Name = "renkBox";
            this.renkBox.Size = new System.Drawing.Size(100, 95);
            this.renkBox.TabIndex = 4;
            this.renkBox.TabStop = false;
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 557);
            this.Controls.Add(this.renkBox);
            this.Controls.Add(this.kaynakBox);
            this.Controls.Add(this.yKor);
            this.Controls.Add(this.xKor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Renk Getirme Formu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renkBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkGetirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox xKor;
        private System.Windows.Forms.TextBox yKor;
        private System.Windows.Forms.PictureBox kaynakBox;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.PictureBox renkBox;
    }
}