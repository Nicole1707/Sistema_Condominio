using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CEntidad;
using CDatos;

namespace CNegocio
{
    public class ClaseNegocio
    {
        ClaseDatos ejec = new ClaseDatos();

        public void agregar(ClaseEntidad habitante)
        {
            ejec.agregar(habitante);
        }
        public DataTable Leer()
        {
            return ejec.Leer();
        }
       
        public void editar(ClaseEntidad habitante)
        {
            ejec.editar(habitante);
        }
        public void borrar(ClaseEntidad habitante)
        {
            ejec.borrar(habitante);
        }
        public DataTable MostrarM()
        {
            return ejec.MostrarM();
        }
        public DataTable MostrarEd()
        {
            return ejec.MostrarEd();
            
        }
        public DataTable MostrarApa()
        {
            return ejec.MostrarA();
        }
        public DataTable BusquedaMnz(string val)
        {
            return ejec.busquedaManzana(val);

        }
        public DataTable BusquedaEdif(string val)
        {
            return ejec.busquedaEdi(val);

        }
        public void agregarConfi(EntidadConfi adminis)
        {
            ejec.agregarCnfM(adminis);
        }
        public void agregarConfiE(EntidadConfi adminis)
        {
            ejec.agregarCnfE(adminis);
        }
        public void agregarConfiA(EntidadConfi adminis)
        {
            ejec.agregarCnfA(adminis);
        }
        public DataTable LeerConfi()
        {
            return ejec.LeerCnf();
        }
        public DataTable LeerConfiE()
        {
            return ejec.LeerCnfE();
        }
        public DataTable LeerConfiA()
        {
            return ejec.LeerCnfA();
        }
        public void ActuConfiMan(EntidadConfi adminis)
        {
            ejec.actualizarCnfM(adminis);
        }
        public void ActuConfiEdi(EntidadConfi adminis)
        {
            ejec.actualizarCnfE(adminis);
        }
        public void ActuConfiAp(EntidadConfi adminis)
        {
            ejec.actualizarCnfA(adminis);
        }

    }
}
