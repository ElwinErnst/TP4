using crucigramaForm;
using crucigramaForm.Entidades;
using crucigramaForm.Persistencia;
using System;
using System.Windows.Forms;

namespace CrucigramaForms.Forms
{
    public partial class Puntajes : Form
    {
        public Puntajes()
        {
            InitializeComponent();
            cargarPuntajes();
            Usuario u = pUsuario.GetUsuarioByUser(Program.user);
            if (u.Admin == 1)
            {
                button2.Enabled = true;
            }
            if (u.Admin == 0)
            {
                button2.Enabled = false;
            }
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Puntos_LocationChanged(object sender, EventArgs e)
        {
        }

        public void cargarPuntajes()
        {
            foreach (Usuario u in pUsuario.GetAll())
            {
                Puntos.Rows.Add(u.User, u.Puntos.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Puntos.Rows.Clear();
            cargarPuntajes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetPuntaje();
        }

        public void resetPuntaje()
        {
            foreach (Usuario u in pUsuario.GetAll())
            {
                u.Puntos = 0;
                pUsuario.Update(u);
            }
        }
    }
}