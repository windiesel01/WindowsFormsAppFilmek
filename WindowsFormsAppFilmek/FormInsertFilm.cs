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
    public partial class FormInsertFilm : Form
    {
        Database database = new Database();
        public FormInsertFilm()
        {
            InitializeComponent();
        }

        private void FormInsertFilm_Load(object sender, EventArgs e)
        {

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

        private void FormInsertFilm_Load_1(object sender, EventArgs e)
        {

        }

        private void button_hozzaadas_Click(object sender, EventArgs e)
        {
            if (HianyzoAdat())
            {
                return;
            }
            Filmek insertFilmek = new Filmek(1, textBox_cim.Text, Convert.ToInt32(textBox_megjelenes.Text), textBox_hossz.Text, Convert.ToDouble(numericUpDown_ertekeles.Value), textBox_kategoria.Text);
            if (database.insertFilm(insertFilmek))
            {
                MessageBox.Show("Sikeres rögzités!");
                textBox_id.Text = "";
                textBox_cim.Text = "";
                textBox_hossz.Text = "";
                numericUpDown_ertekeles.Value = numericUpDown_ertekeles.Minimum;
                textBox_kategoria.Text = "";
            }
            else
            {
                MessageBox.Show("Sikertelen rögzités!");
            }
            Program.form_Nyito.filmekUpdate();
        }

    }
}
