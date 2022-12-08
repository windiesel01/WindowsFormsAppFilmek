namespace WindowsFormsAppFilmek
{
    partial class FormDeleteFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteFilm));
            this.button_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Black;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_delete.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(364, 225);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(201, 52);
            this.button_delete.TabIndex = 27;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 55);
            this.label1.TabIndex = 15;
            this.label1.Text = "Film törlése";
            // 
            // numericUpDown_ertekeles
            // 
            this.numericUpDown_ertekeles.DecimalPlaces = 1;
            this.numericUpDown_ertekeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_ertekeles.Location = new System.Drawing.Point(22, 249);
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
            this.numericUpDown_ertekeles.TabIndex = 42;
            this.numericUpDown_ertekeles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_kategoria
            // 
            this.textBox_kategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_kategoria.Location = new System.Drawing.Point(196, 248);
            this.textBox_kategoria.Name = "textBox_kategoria";
            this.textBox_kategoria.Size = new System.Drawing.Size(141, 29);
            this.textBox_kategoria.TabIndex = 40;
            // 
            // textBox_hossz
            // 
            this.textBox_hossz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_hossz.Location = new System.Drawing.Point(364, 174);
            this.textBox_hossz.Name = "textBox_hossz";
            this.textBox_hossz.Size = new System.Drawing.Size(141, 29);
            this.textBox_hossz.TabIndex = 39;
            // 
            // textBox_megjelenes
            // 
            this.textBox_megjelenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_megjelenes.Location = new System.Drawing.Point(196, 174);
            this.textBox_megjelenes.Name = "textBox_megjelenes";
            this.textBox_megjelenes.Size = new System.Drawing.Size(141, 29);
            this.textBox_megjelenes.TabIndex = 38;
            // 
            // textBox_cim
            // 
            this.textBox_cim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_cim.Location = new System.Drawing.Point(22, 174);
            this.textBox_cim.Name = "textBox_cim";
            this.textBox_cim.Size = new System.Drawing.Size(141, 29);
            this.textBox_cim.TabIndex = 37;
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_id.Location = new System.Drawing.Point(22, 110);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(59, 29);
            this.textBox_id.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(191, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Kategória";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 34;
            this.label6.Text = "Értékelés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(359, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "Hossz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(191, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Megjelenés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Cim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID";
            // 
            // FormDeleteFilm
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
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDeleteFilm";
            this.Text = "FormDeleteFilm";
            this.Load += new System.EventHandler(this.FormDeleteFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ertekeles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label1;
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