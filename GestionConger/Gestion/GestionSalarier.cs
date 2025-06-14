using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionConger.Class;
using MySql.Data.MySqlClient;

namespace GestionConger.Gestion
{
    internal class GestionSalarier
    {
        private string url = "database=gestioncongeannuel; server=localhost; user id = root; pwd=";
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int AnneeConge { get; set; }
        public float jours { get; set; }
        public string Etat { get; set; }
        public string NomService { get; set; }

        public void addSalarier(Personne obj)
        {
            MySqlConnection conex = new MySqlConnection("database = gestioncongeannuel; server = localhost; user id = root; pwd=");
            conex.Open();
            MySqlCommand salarier = new MySqlCommand("INSERT INTO personne(IM_per, nom_per, prenom_per, id_serv) values('" + obj.IMSalarier1 + "','" + obj.NomSalarier + "','" + obj.PrenomSalarier + "','" +obj.Id_serv+ "')", conex);
            salarier.ExecuteNonQuery();
        }
        public List<GestionSalarier> resultRecherche(string recherche)
        {
            List<GestionSalarier> list = new List<GestionSalarier>();
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            string query = "SELECT IM_per, nom_per, prenom_per, annee_cg, etat_demande, nom_serv FROM personne JOIN conge  ON personne.id_per = conge.id_per JOIN service  ON personne.id_serv = service.id_serv WHERE IM_per LIKE '" + recherche+"' or nom_per LIKE '"+recherche+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                GestionSalarier info = new GestionSalarier();

                info.Matricule = data["IM_per"].ToString();
                info.Nom = data["nom_per"].ToString();
                info.Prenom = data["prenom_per"].ToString();
                info.AnneeConge = Convert.ToInt32(data["annee_cg"]);
                info.Etat = data["etat_demande"].ToString();
                info.NomService = data["nom_serv"].ToString();

                list.Add(info);
            }

            return list;
        }

        public List<GestionSalarier> RecupererInformationPersonne()
        {
            List<GestionSalarier> list = new List<GestionSalarier>();
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            string query = " SELECT IM_per, nom_per, prenom_per, annee_cg,date_demande, nbr_jrs, etat_demande, nom_serv FROM personne JOIN conge  ON personne.id_per = conge.id_per JOIN service  ON personne.id_serv = service.id_serv ORDER BY date_demande DESC";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                GestionSalarier info = new GestionSalarier();

                info.Matricule = data["IM_per"].ToString();
                info.Nom = data["nom_per"].ToString();
                info.Prenom = data["prenom_per"].ToString();
                info.AnneeConge = Convert.ToInt32(data["annee_cg"]);
                info.jours = Convert.ToSingle(data["nbr_jrs"], CultureInfo.InvariantCulture);
                info.Etat = data["etat_demande"].ToString();
                info.NomService = data["nom_serv"].ToString();

                list.Add(info);
            }

            return list;
        }
        public List<GestionSalarier> RecupererPersonne()
        {
            List<GestionSalarier> list = new List<GestionSalarier>();
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            string query = " SELECT IM_per, nom_per, prenom_per FROM personne ORDER BY nom_per";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                GestionSalarier info = new GestionSalarier();

                info.Matricule = data["IM_per"].ToString();
                info.Nom = data["nom_per"].ToString();
                info.Prenom = data["prenom_per"].ToString();

                list.Add(info);
            }

            return list;
        }
        public List<GestionSalarier> RecupererCongeEnAttente()
        {
            List<GestionSalarier> list = new List<GestionSalarier>();
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            string query = " SELECT IM_per, nom_per, prenom_per,date_demande, annee_cg, nbr_jrs, nom_serv FROM personne JOIN conge  ON personne.id_per = conge.id_per JOIN service  ON personne.id_serv = service.id_serv WHERE etat_demande ='En Cours De Traitement.' order by date_demande DESC";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                GestionSalarier info = new GestionSalarier();

                info.Matricule = data["IM_per"].ToString();
                info.Nom = data["nom_per"].ToString();
                info.Prenom = data["prenom_per"].ToString();
                info.AnneeConge = Convert.ToInt32(data["annee_cg"]);
                info.jours = Convert.ToSingle(data["nbr_jrs"]);
                info.NomService = data["nom_serv"].ToString();

                list.Add(info);
            }

            return list;
        }
        public List<GestionSalarier> RecupererCongeAccepter()
        {
            List<GestionSalarier> list = new List<GestionSalarier>();
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            string query = " SELECT IM_per, nom_per, prenom_per, annee_cg, nom_serv FROM personne JOIN conge  ON personne.id_per = conge.id_per JOIN service  ON personne.id_serv = service.id_serv WHERE etat_demande ='Accepter'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                GestionSalarier info = new GestionSalarier();

                info.Matricule = data["IM_per"].ToString();
                info.Nom = data["nom_per"].ToString();
                info.Prenom = data["prenom_per"].ToString();
                info.AnneeConge = Convert.ToInt32(data["annee_cg"]);
                info.NomService = data["nom_serv"].ToString();

                list.Add(info);
            }

            return list;
        }
        public List<GestionSalarier> RecupererCongeSigne()
        {
            List<GestionSalarier> list = new List<GestionSalarier>();
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            string query = " SELECT IM_per, nom_per, prenom_per, annee_cg, nom_serv FROM personne JOIN conge  ON personne.id_per = conge.id_per JOIN service  ON personne.id_serv = service.id_serv WHERE etat_demande ='La démande est au Préfécture'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                GestionSalarier info = new GestionSalarier();

                info.Matricule = data["IM_per"].ToString();
                info.Nom = data["nom_per"].ToString();
                info.Prenom = data["prenom_per"].ToString();
                info.AnneeConge = Convert.ToInt32(data["annee_cg"]);
                info.NomService = data["nom_serv"].ToString();

                list.Add(info);
            }

            return list;
        }
        public List<GestionSalarier> RecupererCongeRefuser()
        {
            List<GestionSalarier> list = new List<GestionSalarier>();
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            string query = " SELECT IM_per, nom_per, prenom_per, annee_cg, nom_serv FROM personne JOIN conge  ON personne.id_per = conge.id_per JOIN service  ON personne.id_serv = service.id_serv WHERE etat_demande ='Refuser' ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                GestionSalarier info = new GestionSalarier();

                info.Matricule = data["IM_per"].ToString();
                info.Nom = data["nom_per"].ToString();
                info.Prenom = data["prenom_per"].ToString();
                info.AnneeConge = Convert.ToInt32(data["annee_cg"]);
                info.NomService = data["nom_serv"].ToString();

                list.Add(info);
            }

            return list;
        }

        public List<GestionSalarier> RecupererCongeVise()
        {
            List<GestionSalarier> list = new List<GestionSalarier>();
            MySqlConnection con = new MySqlConnection(url);
            con.Open();
            string query = " SELECT IM_per, nom_per, prenom_per, annee_cg, nom_serv FROM personne JOIN conge  ON personne.id_per = conge.id_per JOIN service  ON personne.id_serv = service.id_serv WHERE etat_demande ='Démande visé' ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                GestionSalarier info = new GestionSalarier();

                info.Matricule = data["IM_per"].ToString();
                info.Nom = data["nom_per"].ToString();
                info.Prenom = data["prenom_per"].ToString();
                info.AnneeConge = Convert.ToInt32(data["annee_cg"]);
                info.NomService = data["nom_serv"].ToString();

                list.Add(info);
            }

            return list;
        }
    }
}
