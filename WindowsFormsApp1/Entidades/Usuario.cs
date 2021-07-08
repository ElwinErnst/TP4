using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crucigramaForm.Entidades
{
    class Usuario
    {
        string user;
        string password;
        int puntos;
        int admin;

        public Usuario() {}

        public Usuario(string user, string password, int admin, int puntos)
        {
            this.user = user;
            this.password = password;
            this.admin = admin;
            this.puntos = puntos;
        }

        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public int Admin { get => admin; set => admin = value; }
        public int Puntos { get => puntos; set => puntos = value; }

    }
}