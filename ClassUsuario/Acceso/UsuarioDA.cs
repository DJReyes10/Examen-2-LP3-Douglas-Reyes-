using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassUsuario.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClassUsuario.Acceso
{
    public class UsuarioDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2_douglas_reyes; Uid=root; Pwd=Reyesalvares10@;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(string nombreUsu, string contraseña)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM usuario WHERE NombreUsu = @NombreUsu AND Contraseña = @Contraseña;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("NombreUsu", nombreUsu);
                cmd.Parameters.AddWithValue("Contraseña", contraseña);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.NombreUsu = reader[0].ToString();
                    user.Contraseña = reader[1].ToString();

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return user;
        }
    }
}
