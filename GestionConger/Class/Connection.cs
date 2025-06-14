using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionConger.Gestion
{
    internal class Connection
    {
        public void connexion()
        {
            MySqlConnection conex = new MySqlConnection("database = gestioncongeannuel; server = localhost; user id = root; pwd=");
            conex.Open();
        }
    }
}
