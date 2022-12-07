using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFilmek
{
    internal static class Program
    {
        static public FormInsertFilm insertFilm = null;
        static public FormUpdateFilm updateFilm = null;
        static public Form_Nyito form_Nyito = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            insertFilm= new FormInsertFilm();
            updateFilm= new FormUpdateFilm();
            form_Nyito = new Form_Nyito();
            Application.Run(form_Nyito);
        }
    }
}
