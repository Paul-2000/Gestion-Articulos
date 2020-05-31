using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticulosNegocio
    {
        public List<Articulos> Listar()
        {
            List<Articulos> listado = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "data source=DESKTOP-VMO2M2L\\SQLEXPRESS01; initial catalog=CATALOGO_DB; Integrated security=sspi;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio from ARTICULOS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.ID = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.IDMarca = (int)lector["IDMarca"];
                    aux.IDCategoria = (int)lector["IDCategoria"];
                    aux.ImagURL = (string)lector["ImagenURL"];
                    aux.Precio = (decimal)lector["Precio"];

                    listado.Add(aux);
                }
                
                return listado;
            }
            catch (SqlException ex2)
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

        public void AgregarArt(Articulos nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            try
            {
                //'"+ nuevo.Codigo +"'
                conexion.ConnectionString = "data source=DESKTOP-VMO2M2L\\SQLEXPRESS01; initial catalog=CATALOGO_DB; Integrated security=sspi;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) Values(@Codigo, @Nombre, @Descripcion, @Marca, @Categoria, @ImagenUrl, @Precio)";
                //comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Codigo", nuevo.Codigo);
                comando.Parameters.AddWithValue("@Nombre", nuevo.Nombre.ToString());
                comando.Parameters.AddWithValue("@Descripcion", nuevo.Descripcion.ToString());
                comando.Parameters.AddWithValue("@Marca", nuevo.Marca.ID.ToString());
                comando.Parameters.AddWithValue("@Categoria", nuevo.Categoria.ID.ToString());
                comando.Parameters.AddWithValue("@ImagenUrl", nuevo.ImagURL.ToString());
                comando.Parameters.AddWithValue("@Precio", nuevo.Precio);
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw new NoMeGustaException("No me gusta lo que estás haciendo con la Base de Datos...");
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}

