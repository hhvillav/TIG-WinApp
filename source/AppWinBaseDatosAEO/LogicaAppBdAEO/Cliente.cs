using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAppBdAEO
{
    public class Cliente
    {
        private string cedulaCliente;
        private string nombreCliente;
        private string apellidoCliente;
        private string direccionCliente;
        private string telefonoCliente;

        private string cadenacomando;        

        public void EscribirCedula(string ced)
        {
            this.cedulaCliente = ced;
        }
        public string LeerCedula()
        {
            return this.cedulaCliente;
        }

        public void EscribirNombre(string nom)
        {
            this.nombreCliente = nom;
        }
        public string LeerNombre()
        {
            return this.nombreCliente;
        }

        public void EscribirApellido(string Apll)
        {
            this.apellidoCliente = Apll;
        }
        public string LeerApellido()
        {
            return this.apellidoCliente;
        }
        // encapsulado mediante propiedades
        public string DireccionCliente
        {
            get => direccionCliente;
            set => direccionCliente = value;
        }
        public string TelefonoCliente
        {
            get => telefonoCliente;
            set => telefonoCliente = value;
        }
        
        public void crearcl()
        {
            string insertarcadenacl;
            insertarcadenacl="INSERT INTO Clientes (CedulaCliente,NombresCliente,ApellidosCliente, DireccionCliente, TelefonoCliente) VALUES('"+this.cedulaCliente+"','"+this.nombreCliente+"','"+this.apellidoCliente+ "','" + this.direccionCliente + "','" + this.telefonoCliente + "')";
            cadenacomando = insertarcadenacl;
        }

        public void modificarcadenacl()
        {
            string modificarcadenacll;
            modificarcadenacll = @"UPDATE Clientes  SET NombresCliente='" + this.nombreCliente + "', ApellidosCliente='" + this.apellidoCliente + "', direccionCliente='" + this.DireccionCliente + "', telefonoCliente='" + this.TelefonoCliente + "' WHERE cedula='" + this.cedulaCliente + "' ";
            cadenacomando = modificarcadenacll;
        }

        public  void seleccionarcadenacl()
        {
            string seleccadenacl;
            seleccadenacl="SELECT * FROM Clientes WHERE CedulaCliente='"+this.cedulaCliente+"'";
            cadenacomando = seleccadenacl;

        }

        public string ConsultarCliente()
        {

            return @"SELECT * FROM Clientes WHERE (CedulaCliente LIKE'" + this.cedulaCliente + "')";

        }
        public string BorrarCliente()
        {

            return @"DELETE  FROM Clientes WHERE (CedulaCliente LIKE'" + this.cedulaCliente + "')";

        }
        public string ConsultarTodosLosClientes()
        {

            return @"SELECT * FROM Clientes";

        }
        public void borrarcadenacl()
        {
            string borrarcadcl;
            borrarcadcl="DELETE FROM Clientes WHERE CedulaCliente='"+this.cedulaCliente+"'";
            cadenacomando = borrarcadcl;
        }

        public string LeerCadenaComado()
        {
            return this.cadenacomando;
        }
    }
}
