using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using Entities;

namespace DataLayer
{
    public class ClientesData
    {
        public static MySqlConnection ConexionBD()
        {
            MySqlConnection conex = new MySqlConnection
            ("Server=127.0.0.1;"+ 
             "Database=fruvercapp;"+
             "Uid=root;"+
             "Pwd=;"+
             "SslMode=None");

            return conex;
        }
            public static bool GuardarCliente(Clientes_Entity cliente)
            {
                    MySqlConnection conex = ConexionBD();
                conex.Open();
                string sql = @" INSERT INTO tbclientes
                                (TipoDocumento, NumeroDocumento, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Email, Direccion, Telefono, FechaNacimiento)
                                 VALUES
                                (@TipoDocumento, @NumeroDocumento, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Email, @Direccion, @Telefono, @FechaNacimiento)";
                MySqlCommand cmd = new MySqlCommand(sql, conex);

                cmd.Parameters.AddWithValue("@TipoDocumento",cliente.tipo_documento);
                cmd.Parameters.AddWithValue("@NumeroDocumento",cliente.numero_documento);
                cmd.Parameters.AddWithValue("@PrimerNombre",cliente.primer_nombre);
                cmd.Parameters.AddWithValue("@SegundoNombre",cliente.segundo_nombre);
                cmd.Parameters.AddWithValue("@PrimerApellido",cliente.primer_apellido);
                cmd.Parameters.AddWithValue("@SegundoApellido",cliente.segundo_apellido);
                cmd.Parameters.AddWithValue("@Email",cliente.email);
                cmd.Parameters.AddWithValue("@Direccion",cliente.direccion);
                cmd.Parameters.AddWithValue("@Telefono",cliente.telefono);
                cmd.Parameters.AddWithValue("@FechaNacimiento",cliente.fecha_nacimiento);

                int NumeroFilas = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (NumeroFilas >0)
                {
                    return true;
                }
                else{
                    return false;
                    }
                }
   
        }
}

