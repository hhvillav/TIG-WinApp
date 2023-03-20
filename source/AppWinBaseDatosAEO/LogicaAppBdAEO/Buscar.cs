using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAppBdAEO
{
    public class Buscar
    {
        private string mensaje;
        private string tabla;
        private string campoclave;
        private string CodRetorno;
        private string NomRetorno;
        private string filtro;

        public string Filtro
        {
            get { return filtro; }
            set { filtro = value; }
        }


        

        private string datobusqueda;
        //private string 

        System.Data.OleDb.OleDbConnection conn;
        System.Data.OleDb.OleDbTransaction miTran;


        public void EscribirTabla(String pnombreTabla) 
        {
            this.tabla = pnombreTabla;
        }

        public void EscribirCampoClave(String pcampoclave) 
        {
            this.campoclave = pcampoclave;
        }

        public void EscribirDatoBusqueda(String pdatobusqueda)
        {
            this.datobusqueda=pdatobusqueda; 
        }
        
        public string LeerCampClave()
        {
            return this.campoclave;
        }

        public string LeerTabla()
        {
            return this.tabla;
        }

        public string LeerDatBusq()
        {
            return this.datobusqueda;
        }
        public  Buscar()
        {
            conn = new System.Data.OleDb.OleDbConnection();
            //conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ProgramacionObjetos27Abril2015\AplicacionConConsultasyRetorno\AppCompletaBD27AbrilConsultas\SoluionClienteYJC\persistenciaYJC\BDcliente.accdb";
            conn.ConnectionString = @"Provider=SQLNCLI11;Data Source=GESETIC;User ID=sa;Password=ALVARO;Initial Catalog=Ventas;Persist Security Info=False;";
        }
        
        public System.Data.DataSet BuscarTodos()
        {
        try
			{
                String sentenciaSQL1 ;
            sentenciaSQL1 = "SELECT * FROM " + this.tabla;
				conn.Open();
				System.Data.OleDb.OleDbDataAdapter objRes;
				objRes = new System.Data.OleDb.OleDbDataAdapter(sentenciaSQL1, conn);
				System.Data.DataSet datos;
				datos = new System.Data.DataSet();
				objRes.Fill(datos, "Tabla");
				mensaje="Se devolvio DataSet. Todo OK";
				return datos;
			}

			catch (Exception MiExc)
			{
                System.Data.DataSet datos2;
				datos2 = new System.Data.DataSet();
				mensaje= "Se presento el Siguiente Error " + MiExc.Message;
				return datos2;				
			}

			finally
			{
				conn.Close();
			}
        }


        public System.Data.DataSet BuscarxCedulaTodos()
        {
            try
            {
                String sentenciaSQL1;
                //String sentenciaSQL = "SELECT * FROM " + this.tabla + " WHERE Cedula = '"+this.Filtro+"'";
                String sentenciaSQL = "SELECT * FROM " + this.tabla + " WHERE Cedula LIKE '%" + this.Filtro + "%'";
                conn.Open();
                System.Data.OleDb.OleDbDataAdapter objRes;
                objRes = new System.Data.OleDb.OleDbDataAdapter(sentenciaSQL, conn);
                System.Data.DataSet datos;
                datos = new System.Data.DataSet();
                objRes.Fill(datos, "Tabla");
                mensaje = "Se devolvio DataSet. Todo OK";
                return datos;
            }

            catch (Exception MiExc)
            {
                System.Data.DataSet datos2;
                datos2 = new System.Data.DataSet();
                mensaje = "Se presento el Siguiente Error " + MiExc.Message;
                return datos2;
            }

            finally
            {
                conn.Close();
            }
        }

        public System.Data.DataSet BuscarCC()
        {
            try
            {
                String sentenciaSQL1;
                sentenciaSQL1 = "SELECT * FROM " + this.tabla + " WHERE(" + this.campoclave + ")";
                conn.Open();
                System.Data.OleDb.OleDbDataAdapter objRes;
                objRes = new System.Data.OleDb.OleDbDataAdapter(sentenciaSQL1, conn);
                System.Data.DataSet datos;
                datos = new System.Data.DataSet();
                objRes.Fill(datos, "Tabla");
                mensaje = "Se devolvio DataSet. Todo OK";
                return datos;
            }

            catch (Exception MiExc)
            {
                System.Data.DataSet datos2;
                datos2 = new System.Data.DataSet();
                mensaje = "Se presento el Siguiente Error " + MiExc.Message;
                return datos2;
            }

            finally
            {
                conn.Close();
            }
        }
    

      public System.Data.DataSet BuscarPorCampoClave()
    {
        try
			{
                String sentenciaSQL1 ;
                sentenciaSQL1 = "SELECT * FROM " + this.tabla + " WHERE " + this.campoclave + " = '" + this.datobusqueda+"'";
				conn.Open();
				System.Data.OleDb.OleDbDataAdapter objRes;
				objRes = new System.Data.OleDb.OleDbDataAdapter(sentenciaSQL1, conn);
				System.Data.DataSet datos;
				datos = new System.Data.DataSet();
				objRes.Fill(datos, "Tabla");
				mensaje="Se devolvio DataSet. Todo OK";
				return datos;
			}

			catch (Exception MiExc)
			{
                System.Data.DataSet datos2;
				datos2 = new System.Data.DataSet();
				mensaje= "Se presento el Siguiente Error " + MiExc.Message;
				return datos2;				
			}

			finally
			{
				conn.Close();
			}
        }

     
    }
}
