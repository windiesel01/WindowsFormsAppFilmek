namespace WindowsFormsAppFilmek
{
    partial class FormInsertFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsertFilm));
            this.label1 = new System.Windows.Forms.Label();
            this.button_hozzaadas = new System.Windows.Forms.Button();
            this.numericUpDown_ertekeles = new System.Windows.Forms.NumericUpDown();
            this.textBox_kategoria = new System.Windows.Forms.TextBox();
            this.textBox_hossz = new System.Windows.Forms.TextBox();
            this.textBox_megjelenes = new System.Windows.Forms.TextBox();
            this.textBox_cim = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ertekeles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film hozzáadás";
            // 
            // button_hozzaadas
            // 
            this.button_hozzaadas.BackColor = System.Drawing.Color.Black;
            this.button_hozzaadas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_hozzaadas.FlatAppearance.BorderSize = 0;
            this.button_hozzaadas.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_hozzaadas.ForeColor = System.Drawing.Color.White;
            this.button_hozzaadas.Location = new System.Drawing.Point(357, 230);
            this.button_hozzaadas.Name = "button_hozzaadas";
            this.button_hozzaadas.Size = new System.Drawing.Size(201, 52);
            this.button_hozzaadas.TabIndex = 13;
            this.button_hozzaadas.Text = "Hozzáadás";
            this.button_hozzaadas.UseVisualStyleBackColor = false;
            this.button_hozzaadas.Click += new System.EventHandler(this.button_hozzaadas_Click);
            // 
            // numericUpDown_ertekeles
            // 
            this.numericUpDown_ertekeles.DecimalPlaces = 1;
            this.numericUpDown_ertekeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_ertekeles.Location = new System.Drawing.Point(15, 254);
            this.numericUpDown_ertekeles.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_ertekeles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ertekeles.Name = "numericUpDown_ertekeles";
            this.numericUpDown_ertekeles.Size = new System.Drawing.Size(69, 29);
            this.numericUpDown_ertekeles.TabIndex = 41;
            this.numericUpDown_ertekeles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_kategoria
            // 
            this.textBox_kategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_kategoria.Location = new System.Drawing.Point(189, 253);
            this.textBox_kategoria.Name = "textBox_kategoria";
            this.textBox_kategoria.Size = new System.Drawing.Size(141, 29);
            this.textBox_kategoria.TabIndex = 39;
            // 
            // textBox_hossz
            // 
            this.textBox_hossz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_hossz.Location = new System.Drawing.Point(357, 179);
            this.textBox_hossz.Name = "textBox_hossz";
            this.textBox_hossz.Size = new System.Drawing.Size(141, 29);
            this.textBox_hossz.TabIndex = 38;
            // 
            // textBox_megjelenes
            // 
            this.textBox_megjelenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_megjelenes.Location = new System.Drawing.Point(189, 179);
            this.textBox_megjelenes.Name = "textBox_megjelenes";
            this.textBox_megjelenes.Size = new System.Drawing.Size(141, 29);
            this.textBox_megjelenes.TabIndex = 37;
            // 
            // textBox_cim
            // 
            this.textBox_cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_cim.Location = new System.Drawing.Point(15, 179);
            this.textBox_cim.Name = "textBox_cim";
            this.textBox_cim.Size = new System.Drawing.Size(141, 29);
            this.textBox_cim.TabIndex = 36;
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_id.Location = new System.Drawing.Point(15, 115);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(59, 29);
            this.textBox_id.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(184, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Kategória";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(10, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Értékelés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(352, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Hossz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(184, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Megjelenés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID";
            // 
            // FormInsertFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(578, 332);
            this.Controls.Add(this.numericUpDown_ertekeles);
            this.Controls.Add(this.textBox_kategoria);
            this.Controls.Add(this.textBox_hossz);
            this.Controls.Add(this.textBox_megjelenes);
            this.Controls.Add(this.textBox_cim);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_hozzaadas);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInsertFilm";
            this.Text = "FIlm hozzáadás";
            this.Load += new System.EventHandler(this.FormInsertFilm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ertekeles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_hozzaadas;
        public System.Windows.Forms.NumericUpDown numericUpDown_ertekeles;
        public System.Windows.Forms.TextBox textBox_kategoria;
        public System.Windows.Forms.TextBox textBox_hossz;
        public System.Windows.Forms.TextBox textBox_megjelenes;
        public System.Windows.Forms.TextBox textBox_cim;
        public System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}