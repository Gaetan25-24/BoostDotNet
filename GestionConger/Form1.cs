using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using GestionConger.FormulaireMain;
using MySql.Data.MySqlClient;

namespace GestionConger
{
    public partial class Form1 : Form
    {
        private string url = "database=gestioncongeannuel; server=localhost; user id = root; pwd=";
        public Form1()
        {
            InitializeComponent();
            txtMdp.UseSystemPasswordChar = true;
        }

        private void iconButton1_Click(object sender, EventArgs e){}
        private void iconButton2_Click(object sender, EventArgs e){}
        private void iconButton3_Click(object sender, EventArgs e){}
        private void iconButton4_Click(object sender, EventArgs e){}
        private void iconButton5_Click(object sender, EventArgs e){}
        private void iconButton6_Click(object sender, EventArgs e){}
        private void iconClose_Click(object sender, EventArgs e){}
        private void iconManakeli_Click(object sender, EventArgs e){}
        private void iconReduire_Click(object sender, EventArgs e){}
        private void iconCurrent_Click(object sender, EventArgs e){}
        private void iconClose_DragOver(object sender, DragEventArgs e){}
        private void iconClose_MouseHover(object sender, EventArgs e){}
        private void iconClose_MouseDown(object sender, MouseEventArgs e){}
        private void iconClose_MouseEnter(object sender, EventArgs e){}
        private void iconClose_MouseMove(object sender, MouseEventArgs e){}
        private void iconClose_MouseLeave(object sender, EventArgs e){}
        private void iconClose_MouseUp(object sender, MouseEventArgs e) {}
        private void iconManakeli_MouseHover(object sender, EventArgs e){}
        private void iconManakeli_MouseLeave(object sender, EventArgs e){}
        private void iconReduire_MouseHover(object sender, EventArgs e){}
        private void iconReduire_MouseLeave(object sender, EventArgs e){}
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e){}
        private void panelTitleBar_Paint(object sender, PaintEventArgs e){}
        private void btnService_Click(object sender, EventArgs e){}
        private void btnDeconnexion_Click(object sender, EventArgs e){}
        private void Form1_Load(object sender, EventArgs e){}

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbAfficheMdp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAfficheMdp.Checked)
                txtMdp.UseSystemPasswordChar = false;
            else
                txtMdp.UseSystemPasswordChar = true;
        }

        private void btnEntrer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtMdp.Text))
            {
                labelErreur.Text = "Veuillez renseigner tous les champs.";
                return;
            }
            string nom = txtNom.Text;
            string mdp = txtMdp.Text;
            MySqlConnection con = new MySqlConnection(url);
            string query = "SELECT user,pwd FROM inscription WHERE user = '" + nom + "' AND pwd = '" + mdp + "' ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string user = reader.GetString("user");
                    string pwd = reader.GetString("pwd");

                    if (nom == user && mdp == pwd)
                    {
                        FormMain main = new FormMain();
                        main.Show();
                        this.Hide();
                        return;
                    }
                }
                labelErreur.Text = "Mot de passe ou nom d'utilisateur incorrect !";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
