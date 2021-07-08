using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crucigramaForm.Entidades;
using System.Data.SQLite;

namespace crucigramaForm.Persistencia
{
    class pUsuario
    {
        public static List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Usuario GROUP BY user ORDER BY puntos DESC");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                Usuario u = new Usuario();

                u.User = obdr.GetString(0);
                u.Password = obdr.GetString(1);
                u.Admin = obdr.GetInt32(2);
                u.Puntos = obdr.GetInt32(3);
                usuarios.Add(u);
            }
            return usuarios;
        }

        public static void Save(Usuario u)
        {

            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Usuario (User, Password, Admin, Puntos) VALUES (@user, @password, @admin, @puntos)");
            cmd.Parameters.Add(new SQLiteParameter("@user", u.User));
            cmd.Parameters.Add(new SQLiteParameter("@password", u.Password));
            cmd.Parameters.Add(new SQLiteParameter("@admin", u.Admin));
            cmd.Parameters.Add(new SQLiteParameter("@puntos", u.Puntos));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static List<Usuario> GetByUser(string user, string password)
        {

            List<Usuario> usuarios = new List<Usuario>();
            Usuario u = new Usuario();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * from Usuario where user=@user and password=@password;");
            cmd.Parameters.Add(new SQLiteParameter("@user", user));
            cmd.Parameters.Add(new SQLiteParameter("@password", password));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();

            while (obdr.Read())
            {
                u.User = obdr.GetString(0);
                u.Password = obdr.GetString(1);
                u.Admin = obdr.GetInt32(2);
                u.Puntos = obdr.GetInt32(3);
                usuarios.Add(u);
            }
            return usuarios;
        }

        public static void Update(Usuario u)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Usuario SET Puntos = @puntos WHERE user = @user;");
            cmd.Parameters.Add(new SQLiteParameter("@puntos", u.Puntos));
            cmd.Parameters.Add(new SQLiteParameter("@user", u.User));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static Usuario GetUsuarioByUser(string user)
        {
            Usuario u = new Usuario();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Usuario WHERE user=@user");
            cmd.Parameters.Add(new SQLiteParameter("@user", user));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                u.User = user;
                u.Puntos = obdr.GetInt32(3);
                u.Admin = obdr.GetInt32(2);
            }
            return u;
        }
    }
}
