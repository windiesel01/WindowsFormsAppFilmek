using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppFilmek
{
    
    public partial class Form_Nyito : Form
    {
        Database database = new Database();
        public Form_Nyito()
        {
            InitializeComponent();
        }
        public void filmekUpdate() 
        {
            listBox_filmek.Items.Clear();
            foreach (Filmek item in database.getAllFilm())
            {
                listBox_filmek.Items.Add(item);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filmekUpdate();
        }

        private void hozzáadásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.insertFilm.ShowDialog();    
        }

        private void listBox_filmek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void móositásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.formUpdateupdateFilmform.ShowDialog();
        }
    }
}
