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
    public partial class FormDeleteFilm : Form
    {
        Database database = new Database();
        public FormDeleteFilm()
        {
            InitializeComponent();
        }

        private void FormDeleteFilm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Program.form_Nyito.listBox_filmek.Text + " adatainak a törlése");
            Filmek ellenorzes = (Filmek)Program.form_Nyito.listBox_filmek.SelectedItem;
            textBox_id.Text = Convert.ToString(ellenorzes.Id);
            textBox_cim.Text = Convert.ToString(ellenorzes.Cim);
            textBox_megjelenes.Text = Convert.ToString(ellenorzes.Megjelenes);
            textBox_hossz.Text = Convert.ToString(ellenorzes.Hossz);
            numericUpDown_ertekeles.Value = Convert.ToDecimal(ellenorzes.Ertekeles);
            textBox_kategoria.Text = Convert.ToString(ellenorzes.Kategoria);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Filmek deleteFilmek = new Filmek(1, textBox_cim.Text, Convert.ToInt32(textBox_megjelenes.Text), textBox_hossz.Text, Convert.ToDouble(numericUpDown_ertekeles.Value), textBox_kategoria.Text);
            if (database.deleteFilmek(deleteFilmek))
            {
                MessageBox.Show("Sikeres törlés!");
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
            Close();
        }
    }
}
