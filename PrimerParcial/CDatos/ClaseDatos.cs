using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CEntidad;
  

namespace CDatos
{
    public class ClaseDatos
    {
        SqlConnection conec = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        SqlCommand cmd;
        #region agregar
        public void agregar(ClaseEntidad habitante)
        {
            
            cmd = new SqlCommand("insertar", conec);
            cmd.CommandType = CommandType.StoredProcedure;
            conec.Open();
            cmd.Parameters.AddWithValue("@cedula",habitante.cedula);
            cmd.Parameters.AddWithValue("@nombre", habitante.Nombre);
            cmd.Parameters.AddWithValue("@manzana", habitante.Manzana);
            cmd.Parameters.AddWithValue("@edificio", habitante.Edificio);
            cmd.Parameters.AddWithValue("@apart", habitante.Apartamento);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conec.Close();
        }
        #endregion
        #region leer
        public DataTable Leer()
        {
            conec.Open();
            cmd = new SqlCommand("Cargar", conec);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            conec.Close();
            return dt;
        }
        #endregion
        #region editar
        public void editar(ClaseEntidad habitante)
        {
            cmd = new SqlCommand("actu", conec);
            cmd.CommandType = CommandType.StoredProcedure;
            conec.Open();
            cmd.Parameters.AddWithValue("@cedula", habitante.cedula);
            cmd.Parameters.AddWithValue("@nombre", habitante.Nombre);
            cmd.Parameters.AddWithValue("@manzana", habitante.Manzana);
            cmd.Parameters.AddWithValue("@edificio", habitante.Edificio);
            cmd.Parameters.AddWithValue("@apart", habitante.Apartamento);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conec.Close();
        }
        #endregion
        #region borrar+
        public void borrar(ClaseEntidad habitante)
        {
            conec.Open();

            cmd = new SqlCommand("delete from condomine where cedula='{ habitante.cedula}'", conec);
            
            cmd.ExecuteNonQuery();
            conec.Close();
        }
        #endregion
        #region cargarcombobox
        public DataTable MostrarM()
        {
            conec.Open();
            cmd = new SqlCommand("select * from Manzana", conec);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();

            adp.Fill(tb);
            conec.Close();

            return tb;
        }
        public DataTable MostrarEd()
        {
            conec.Open();
            cmd = new SqlCommand("select * from Edificio", conec);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();

            adp.Fill(tb);
            conec.Close();

            return tb; 
        }
        public DataTable MostrarA()
        {
            conec.Open();
            cmd = new SqlCommand("select * from Apartament", conec);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();

            adp.Fill(tb);
            conec.Close();

            return tb;
        }

        #endregion
        #region busqueda
        public DataTable busquedaManzana(string val)
        {
            conec.Open();
            cmd = new SqlCommand("BusquedaMan", conec);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Busque", val);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            conec.Close();
            return dt;
        }
        public DataTable busquedaEdi(string val)
        {
            conec.Open();
            cmd = new SqlCommand("BusquedaEdi", conec);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Busque", val);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            conec.Close();
            return dt;
        }
        #endregion

        #region ConfiAgregar
        public void agregarCnfM(EntidadConfi adminis)
        {
            cmd = new SqlCommand("InsMan", conec);
            cmd.CommandType = CommandType.StoredProcedure;
            conec.Open();
            cmd.Parameters.AddWithValue("@agregar", adminis.Manzana);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conec.Close();
        }
        public void agregarCnfE(EntidadConfi adminis)
        {
            cmd = new SqlCommand("InsEdi", conec);
            cmd.CommandType = CommandType.StoredProcedure;
            conec.Open();
            cmd.Parameters.AddWithValue("@agregar", adminis.Edificio);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conec.Close();
        }
        public void agregarCnfA(EntidadConfi adminis)
        {
            cmd = new SqlCommand($"InsApa", conec);
            cmd.CommandType = CommandType.StoredProcedure;
            conec.Open();
            cmd.Parameters.AddWithValue("@agregar", adminis.Apartamento);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conec.Close();
        }
        #endregion
        #region ConfiLeer
        public DataTable LeerCnf()
        {
            conec.Open();
            cmd = new SqlCommand("Select * from Manzana", conec);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            conec.Close();
            return dt;
        }
        public DataTable LeerCnfE()
        {
            conec.Open();
            cmd = new SqlCommand($"Select * from Edificio", conec);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            conec.Close();
            return dt;
        }
        public DataTable LeerCnfA()
        {
            conec.Open();
            cmd = new SqlCommand($"Select * from Apartament", conec);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            conec.Close();
            return dt;
        }
        #endregion
        #region CoonAct
        public void actualizarCnfM(EntidadConfi adminis)
        {
            cmd = new SqlCommand("actMan", conec);
            cmd.CommandType = CommandType.StoredProcedure;
            conec.Open();
            cmd.Parameters.AddWithValue("@act", adminis.Mensaje);
            cmd.Parameters.AddWithValue("@vij", adminis.Manzana);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conec.Close();
        }
        public void actualizarCnfE(EntidadConfi adminis)
        {
            cmd = new SqlCommand("actEdi", conec);
            cmd.CommandType = CommandType.StoredProcedure;
            conec.Open();
            cmd.Parameters.AddWithValue("@vij",adminis.Edificio);
            cmd.Parameters.AddWithValue("@act",adminis.Mensaje);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conec.Close();
        }
        public void actualizarCnfA(EntidadConfi adminis)
        {
            cmd = new SqlCommand("actApa", conec);
            cmd.CommandType = CommandType.StoredProcedure;
            conec.Open();
            cmd.Parameters.AddWithValue("@act",adminis.Mensaje);
            cmd.Parameters.AddWithValue("@viej",adminis.Apartamento);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conec.Close();
        }

        #endregion
    }
}
