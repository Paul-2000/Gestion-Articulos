using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> listado = new List<Categoria>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "data source=DESKTOP-VMO2M2L\\SQLEXPRESS01; initial catalog=CATALOGO_DB; Integrated security=sspi;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Descripcion from CATEGORIAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Categoria aux = new Categoria();
                    //aux.ID = (int)lector["Id"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    /*aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.IDMarca = (int)lector["IDMarca"];
                    aux.IDCategoria = (int)lector["IDCategoria"];
                    aux.ImagURL = (string)lector["ImagenURL"];
                    aux.Precio = (decimal)lector["Precio"];*/

                    listado.Add(aux);
                }

                return listado;
            }
            catch (SqlException)
            {
                //throw ex2;
                throw new NoMeGustaException("No me gusta lo que estás haciendo...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Algo no Funca!");
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
