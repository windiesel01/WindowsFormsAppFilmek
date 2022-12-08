using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFilmek
{
    public partial class FormUpdateFilm : Form
    {
        Database database = new Database();
        public FormUpdateFilm()
        {
            InitializeComponent();
        }

        private void FormUpdateFilm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.form_Nyito.listBox_filmek.Text + " adatainak a módositása");
            Filmek ellenorzes = (Filmek)Program.form_Nyito.listBox_filmek.SelectedItem;
            textBox_id.Text = Convert.ToString(ellenorzes.Id);
            textBox_cim.Text = Convert.ToString(ellenorzes.Cim);
            textBox_megjelenes.Text = Convert.ToString(ellenorzes.Megjelenes);
            textBox_hossz.Text = Convert.ToString(ellenorzes.Hossz);
            numericUpDown_ertekeles.Value = Convert.ToDecimal(ellenorzes.Ertekeles);
            textBox_kategoria.Text = Convert.ToString(ellenorzes.Kategoria);
        }
        private bool HianyzoAdat()
        {
            if (string.IsNullOrEmpty(textBox_cim.Text))
            {
                MessageBox.Show("Nem adtál meg cím-et!");
                textBox_cim.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_megjelenes.Text))
            {
                MessageBox.Show("Nem adtál megjelenési dátumot!");
                textBox_megjelenes.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_hossz.Text))
            {
                MessageBox.Show("Nem adtál meg film hosszt!");
                textBox_hossz.Focus();
                return true;
            }
            if (numericUpDown_ertekeles.Value <= 0)
            {
                MessageBox.Show("Nem adtál meg értékelést!");
                numericUpDown_ertekeles.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_kategoria.Text))
            {
                MessageBox.Show("Nem adtál meg kategóriát!");
                textBox_kategoria.Focus();
                return true;
            }
            return false;
        }

        private void button_modositas_Click(object sender, EventArgs e)
        {
            if (HianyzoAdat())
            {
                return;
            }
            Filmek updateFilmek = new Filmek(1, textBox_cim.Text, Convert.ToInt32(textBox_megjelenes.Text), textBox_hossz.Text, Convert.ToDouble(numericUpDown_ertekeles.Value), textBox_kategoria.Text);
            if (database.updateFilmek(updateFilmek))
            {
                MessageBox.Show("Sikeresen módosítottad az adatokat!");
                textBox_id.Text = "";
                textBox_cim.Text = "";
                textBox_hossz.Text = "";
                numericUpDown_ertekeles.Value = numericUpDown_ertekeles.Minimum;
                textBox_kategoria.Text = "";
            }
            else
            {
                MessageBox.Show("Nem sikerült módosítani az adatokat!");
            }
            Program.form_Nyito.filmekUpdate();
            Close();
        }
    }
}
