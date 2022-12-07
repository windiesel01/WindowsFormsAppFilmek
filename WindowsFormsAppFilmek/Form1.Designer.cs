namespace WindowsFormsAppFilmek
{
    partial class Form_Nyito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Nyito));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hozzáadásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.móositásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_filmek = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hozzáadásToolStripMenuItem,
            this.móositásToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hozzáadásToolStripMenuItem
            // 
            this.hozzáadásToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hozzáadásToolStripMenuItem.Name = "hozzáadásToolStripMenuItem";
            this.hozzáadásToolStripMenuItem.Size = new System.Drawing.Size(104, 25);
            this.hozzáadásToolStripMenuItem.Text = "Hozzáadás";
            this.hozzáadásToolStripMenuItem.Click += new System.EventHandler(this.hozzáadásToolStripMenuItem_Click);
            // 
            // móositásToolStripMenuItem
            // 
            this.móositásToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.móositásToolStripMenuItem.Name = "móositásToolStripMenuItem";
            this.móositásToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.móositásToolStripMenuItem.Text = "Módositás";
            this.móositásToolStripMenuItem.Click += new System.EventHandler(this.móositásToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.törlésToolStripMenuItem.Text = "Törlés";
            // 
            // listBox_filmek
            // 
            this.listBox_filmek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_filmek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_filmek.FormattingEnabled = true;
            this.listBox_filmek.ItemHeight = 25;
            this.listBox_filmek.Location = new System.Drawing.Point(0, 29);
            this.listBox_filmek.Name = "listBox_filmek";
            this.listBox_filmek.Size = new System.Drawing.Size(694, 421);
            this.listBox_filmek.TabIndex = 1;
            this.listBox_filmek.SelectedIndexChanged += new System.EventHandler(this.listBox_filmek_SelectedIndexChanged);
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.listBox_filmek);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Nyito";
            this.Text = "Filmek adatbázis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hozzáadásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem móositásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        public System.Windows.Forms.ListBox listBox_filmek;
    }
}

