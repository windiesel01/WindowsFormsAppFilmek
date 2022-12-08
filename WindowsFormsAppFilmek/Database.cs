using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppFilmek
{
    internal class Database
    {
        static public MySqlCommand cmd;
        static public MySqlConnection connection;
        public Database(string server = "localhost", string user = "root", string password = "", string db = "filmek")
        {
            MySqlConnectionStringBuilder builder= new MySqlConnectionStringBuilder();
            builder.Server= server;
            builder.UserID= user;
            builder.Password= password;
            builder.Database= db;
            connection = new MySqlConnection(builder.ConnectionString);
            if (Kapcsolat())
            {
                cmd = connection.CreateCommand();
            }
        }

        public List<Filmek> getAllFilm()
        {
            List<Filmek> list = new List<Filmek>();
            cmd.CommandText = "SELECT * FROM `filmek`;";
            Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Filmek film = new Filmek(dr.GetInt32("id"),dr.GetString("cim"),dr.GetInt32("megjelenes"),dr.GetString("hossz"),dr.GetDouble("ertekeles"),dr.GetString("kategoria"));
                    list.Add(film);
                }
            }
            Close();
            return list;
        }

        private void Open() {

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void Close()
        {

            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        private bool Kapcsolat()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        internal bool insertFilm(Filmek insertFilm)
        {
            cmd.CommandText = "INSERT INTO `filmek`(`id`, `cim`, `megjelenes`, `hossz`, `ertekeles`, `kategoria`) VALUES (null, @cim,@megjelenes,@hossz,@ertekeles,@kategoria)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cim", insertFilm.Cim);
            cmd.Parameters.AddWithValue("@megjelenes", insertFilm.Megjelenes);
            cmd.Parameters.AddWithValue("@hossz", insertFilm.Hossz);
            cmd.Parameters.AddWithValue("@ertekeles", insertFilm.Ertekeles);
            cmd.Parameters.AddWithValue("@kategoria", insertFilm.Kategoria);
            Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                Close();
                return true;
            }
            else
            {
                Close();
                return false;
            }
        }

        internal bool updateFilmek(Filmek updateFilmek)
        {
            cmd.CommandText = "UPDATE `filmek` SET `cim`= @cim,`megjelenes`= @megjelenes,`hossz`= @hossz,`ertekeles`= @ertekeles,`kategoria`= @kategoria WHERE `id`= @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", Program.updateFilm.textBox_id.Text);
            cmd.Parameters.AddWithValue("@cim", Program.updateFilm.textBox_cim.Text);
            cmd.Parameters.AddWithValue("@megjelenes", Program.updateFilm.textBox_megjelenes.Text);
            cmd.Parameters.AddWithValue("@hossz", Program.updateFilm.textBox_hossz.Text);
            cmd.Parameters.AddWithValue("@ertekeles", Program.updateFilm.numericUpDown_ertekeles.Value);
            cmd.Parameters.AddWithValue("@kategoria", Program.updateFilm.textBox_kategoria.Text);
            
            Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                Close();
                return true;
            }
            else
            {
                Close();
                return false;
            }
        }

        internal bool deleteFilmek(Filmek deleteFilmek) 
        {
            cmd.CommandText = "DELETE FROM `filmek` WHERE `id` = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", Program.deleteFilm.textBox_id.Text);
            Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                Close();
                return true;
            }
            else
            {
                Close();
                return false;
            }
        }
    }
}


