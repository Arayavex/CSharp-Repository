using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimiento
{
    class Comm
    {
        public static SqlConnection RetornaAcceso()
        {
            SqlConnection con = new SqlConnection
                ("Server=tcp:grupodbserver.database.windows.net,1433;Initial Catalog=grupodb;Persist Security Info=False;User ID=admin2020;Password=Ulacit123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            return con;
        }



        public static String IngresarPais(String idPais1, String Descripcion)
        {
            if (idPais1 != "" && Descripcion != "")
            {
                SqlConnection conx = new SqlConnection();
                conx = RetornaAcceso();
                using (SqlCommand cmd = new SqlCommand("insert into Pais(ID_Pais,Descripcion_Pais) values(@idPais,@DescripcionPais)", conx))
                    try
                    {
                        cmd.Parameters.AddWithValue("@IdPais", idPais1);
                        cmd.Parameters.AddWithValue("@DescripcionPais", Descripcion);
                        cmd.Connection = conx;
                        conx.Open();
                        cmd.ExecuteNonQuery();
                        conx.Close();
                        return "Dato creado";
                    }
                    catch
                    {
                        return ("Este valor de ID ya existe en Pais!");
                    }

            }
            else
            {
                return "Datos no detectados, por favor ingresar";
            }
        }

        public static DataSet GetDataPais()
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Pais", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static String ModificarPais(String idPais1, String Descripcion)
        {
            if (idPais1 != "" && Descripcion != "")
            {
                SqlConnection conx = new SqlConnection();
                conx = RetornaAcceso();
                using (SqlCommand cmd = new SqlCommand("update Pais set Descripcion_Pais=@DescripcionPais,ID_Pais=@IdPais where ID_Pais=@IdPais OR Descripcion_Pais=@DescripcionPais", conx))
                    try
                    {
                        cmd.Parameters.AddWithValue("@IdPais", idPais1);
                        cmd.Parameters.AddWithValue("@DescripcionPais", Descripcion);
                        cmd.Connection = conx;
                        conx.Open();
                        cmd.ExecuteNonQuery();
                        conx.Close();
                        return "Dato actualizado";
                    }
                    catch
                    {
                        return ("Este valor de ID ya existe en Pais!");
                    }

            }
            else
            {
                return "Datos no detectados, por favor ingresar";
            }
        }


        public static String EliminarPais(String idPais1)
        {
            if (idPais1 != "")
            {
                SqlConnection conx = new SqlConnection();
                conx = RetornaAcceso();
                using (SqlCommand cmd = new SqlCommand("delete Pais where ID_Pais=@IdPais", conx))

                {
                    cmd.Parameters.AddWithValue("@IdPais", idPais1);
                    cmd.Connection = conx;
                    conx.Open();
                    cmd.ExecuteNonQuery();
                    conx.Close();
                    return "Dato eliminado";
                }

            }
            else
            {
                return "Datos no detectados, por favor ingresar";
            }



        }

        public static String IngresoProducto(String idProducto1, String Cantidad1, String Precio1, String Marca1, String Descrp1, String idTipoProducto1)
        {
            if (idProducto1 != "" && Cantidad1 != "" && Precio1 != "" && Marca1 != "" && Descrp1 != "" && idTipoProducto1 != "")
            {
                SqlConnection conx = new SqlConnection();
                conx = RetornaAcceso();
                using (SqlCommand cmd = new SqlCommand("insert into Producto(Id_Producto,Cantidad,Precio,Marca,Descrp,Id_Tipo_TipoProducto) values(@idProducto,@CantidadP,@PrecioP,@MarcaP,@DescrpP,@idTipoProducto)", conx))
                    try
                    {
                        cmd.Parameters.AddWithValue("@idProducto", idProducto1);
                        cmd.Parameters.AddWithValue("@CantidadP", Cantidad1);
                        cmd.Parameters.AddWithValue("@PrecioP", Precio1);
                        cmd.Parameters.AddWithValue("@MarcaP", Marca1);
                        cmd.Parameters.AddWithValue("@DescrpP", Descrp1);
                        cmd.Parameters.AddWithValue("@idTipoProducto", idTipoProducto1);
                        cmd.Connection = conx;
                        conx.Open();
                        cmd.ExecuteNonQuery();
                        conx.Close();
                        return "Dato creado";
                    }
                    catch
                    {
                        return ("Este valor de ID ya existe en Producto!");
                    }

            }
            else
            {
                return "Datos no detectados, por favor ingresar";
            }
        }

        public static DataSet GetDataProductos()
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Producto", conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public static String ModificarProducto(String idProducto1, String Descrp1)
        {
            if (idProducto1 != "" && Descrp1 != "")
            {
                SqlConnection conx = new SqlConnection();
                conx = RetornaAcceso();
                using (SqlCommand cmd = new SqlCommand("update Producto set Descrp=@DescrpP,Id_Producto=@idProducto where Id_Producto=@idProducto OR Descrp=@DescrpP", conx))
                    try
                    {
                        cmd.Parameters.AddWithValue("@idProducto", idProducto1);
                        cmd.Parameters.AddWithValue("@DescrpP", Descrp1);
                        cmd.Connection = conx;
                        conx.Open();
                        cmd.ExecuteNonQuery();
                        conx.Close();
                        return "Dato actualizado";
                    }
                    catch
                    {
                        return ("Este valor de ID ya existe en Producto!");
                    }

            }
            else
            {
                return "Datos no detectados, por favor ingresar";
            }
        }


        public static String EliminarProducto(String idProducto1)
        {
            if (idProducto1 != "")
            {
                SqlConnection conx = new SqlConnection();
                conx = RetornaAcceso();
                using (SqlCommand cmd = new SqlCommand("delete Producto where Id_Producto=@idProducto", conx))
                    { 
                        cmd.Parameters.AddWithValue("@idProducto", idProducto1);
                        cmd.Connection = conx;
                        conx.Open();
                        cmd.ExecuteNonQuery();
                        conx.Close();
                        return "Dato eliminado";
                    }
            }
            else
            {
                return "Datos no detectados, por favor ingresar";
            }
        }

        public static DataTable cargaComboGeografia()
        {
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT ID_Tipo_Geografia, Descripcion FROM tipo_geografia", RetornaAcceso()))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                /*cbx_TipoGeografia.DisplayMember = "name";
                cbx_TipoGeografia.DataSource = dt;*/
                RetornaAcceso().Close();
                return dt;
            }
        }

        public static DataSet GetDataGeografia(String tipoGeograf, String IDPais)
        {
            SqlConnection conx = new SqlConnection();
            conx = RetornaAcceso();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Geografia where ID_Tipo_Geografia = " + tipoGeograf + " AND ID_Pais = " + IDPais, conx);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


    }

}

