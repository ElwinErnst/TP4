using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using crucigramaForm;
using crucigramaForm.Entidades;
using crucigramaForm.Persistencia;

namespace CrucigramaForms.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void extbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Registrarse();
        }

        public void Registrarse()
        {
            Usuario u = new Usuario
            {
                User = Usertxt.Text,
                Password = Passwordtxt.Text,
                Admin = 0,
                Puntos = 0
            };

            foreach (Usuario a in pUsuario.GetAll())
            {
                if (u.User == a.User)
                {
                    if (MessageBox.Show("Ese usuario ya esta en uso! elige otro") == DialogResult.OK)
                    {
                        Usertxt.Clear();
                        Passwordtxt.Clear();
                    }
                }
            }
            if (Usertxt.Text != "" && Passwordtxt.Text != "")
            {
                pUsuario.Save(u);
                MessageBox.Show("Se ha registrado Correctamente!");
            }
            else 
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("No puede dejar campos vacios!", "Error");
            }
        }

        public void Ingresar()
        {
            Usuario u = new Usuario
            {
                User = Usertxt.Text,
                Password = Passwordtxt.Text
            };

            List<Usuario> us = pUsuario.GetByUser(u.User, u.Password);
            u.Puntos = Program.puntos;
            u.User = Program.user;
            pUsuario.Update(u);

            if (us.Count == 1)
            {
                Console.WriteLine("Usuario válido");
                Program.user = us[0].User;
                SystemSounds.Exclamation.Play();

                if (us[0].Admin == 1)
                {
                    MessageBox.Show("Bienvenido administrador","Ingreso correcto");
                    //ir al crucigrama, cargar la ventana para gestion del juego
                    Hide();
                    Main frm2 = new Main();
                    Hide();
                    frm2.ShowDialog();
                    Close();
                }

                if (us[0].Admin == 0)
                {
                    //ir al crucigrama
                    MessageBox.Show("Bienvenido "+ Program.user, "Ingreso correcto");
                    Hide();
                    Main frm2 = new Main();
                    Hide();
                    frm2.ShowDialog();
                    Close();
                }
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Usuario inválido", "Error");
            }
        }

        private void Usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
