using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinBaseDatosAEO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {


            try
            {
                LogicaAppBdAEO.conexion objConexion;  // Se hace referencia a un objeto de tipo conexion (clase)
                objConexion = new LogicaAppBdAEO.conexion(); // Se crea la instancia (objeto MiConexion) de la clase conexion. 
                string SenSQL1;
                string SenSQL2;
                LogicaAppBdAEO.Cliente objCliente;
                objCliente = new LogicaAppBdAEO.Cliente();  
                objCliente.EscribirCedula(tbCedula.Text);
                objCliente.EscribirApellido(tbApellidos.Text);
                objCliente.EscribirNombre(tbNombres.Text);
                objCliente.TelefonoCliente = tbTelefono.Text;
                objCliente.DireccionCliente = tbDireccion.Text;
                objCliente.crearcl();
                SenSQL1 = objCliente.LeerCadenaComado();
                //SenSQL1=@"Insert into Persona (CodPersona,Nombres, Apellidos) VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
                //SenSQL2 = @"Insert into Auditoria (cedula,fecha_modificacion) VALUES ('" + tbxcc.Text + "','" + DateTime.Now.ToString() + "')"; // ok
                objConexion.SetSentencia1(SenSQL1);
                //objConexion.SetSentencia2(SenSQL2);

                lblResultado.Text = " Se creo nuevo cliente " + objConexion.EjecutarSQL1();// mostramos mensaje
                                                                                    // lblmsj.Text = " Se creo nuevo cliente " + MiConexion.EjecutarSQL2();// mostramos mensaje
                tbCedula.Enabled=false;
                btnGrabar.Enabled=false;
            
            }
            catch (Exception es)
            {
                lblResultado.Text = "Hubo el siguiente error " + es.Message;
            }


        }

        private void lblConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaAppBdAEO.conexion objConexion;  // Se hace referencia a un objeto de tipo conexion (clase)
                objConexion = new LogicaAppBdAEO.conexion(); // Se crea la instancia (objeto MiConexion) de la clase conexion. 
                string SenSQL1;
                string SenSQL2;
                LogicaAppBdAEO.Cliente objCliente;
                objCliente = new LogicaAppBdAEO.Cliente();
                objCliente.EscribirCedula(tbCedula.Text);
               
                SenSQL1 = objCliente.ConsultarCliente(); ;
                //SenSQL1=@"Insert into Persona (CodPersona,Nombres, Apellidos) VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
                //SenSQL2 = @"Insert into Auditoria (cedula,fecha_modificacion) VALUES ('" + tbxcc.Text + "','" + DateTime.Now.ToString() + "')"; // ok
                objConexion.SetSentencia1(SenSQL1);
                //objConexion.SetSentencia2(SenSQL2);

                lblResultado.Text = " Se Muestran Resultados de la consulta para cedula:" + tbCedula.Text;


                System.Data.DataSet miDS;
                miDS = new System.Data.DataSet();
                miDS = objConexion.Consultar();

                int seleccionados;
                seleccionados = miDS.Tables["Tabla"].Rows.Count;

                if (seleccionados == 0)
                {
                    tbCedula.Text = " No se encuentran Datos";
                    tbNombres.Text = " ";
                    tbApellidos.Text = " ";
                    tbDireccion.Text = " ";
                    tbTelefono.Text = " ";
                }
                else
                {

                    tbCedula.Text = miDS.Tables["Tabla"].Rows[0]["CedulaCliente"].ToString();
                    tbNombres.Text = miDS.Tables["Tabla"].Rows[0]["NombresCliente"].ToString(); ;
                    tbApellidos.Text = miDS.Tables["Tabla"].Rows[0]["ApellidosCliente"].ToString(); ;
                    tbDireccion.Text = miDS.Tables["Tabla"].Rows[0]["DireccionCliente"].ToString(); ;
                    tbTelefono.Text = miDS.Tables["Tabla"].Rows[0]["TelefonoCliente"].ToString(); ;

                }
                    
                                                                                           // lblmsj.Text = " Se creo nuevo cliente " + MiConexion.EjecutarSQL2();// mostramos mensaje
            }
            catch (Exception es)
            {
                lblResultado.Text = "Hubo el siguiente error " + es.Message;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void btnConsultarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaAppBdAEO.conexion objConexion;  // Se hace referencia a un objeto de tipo conexion (clase)
                objConexion = new LogicaAppBdAEO.conexion(); // Se crea la instancia (objeto MiConexion) de la clase conexion. 
                string SenSQL1;
                string SenSQL2;
                LogicaAppBdAEO.Cliente objCliente;
                objCliente = new LogicaAppBdAEO.Cliente();
               
                SenSQL1 = objCliente.ConsultarTodosLosClientes();
                //SenSQL1=@"Insert into Persona (CodPersona,Nombres, Apellidos) VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
                //SenSQL2 = @"Insert into Auditoria (cedula,fecha_modificacion) VALUES ('" + tbxcc.Text + "','" + DateTime.Now.ToString() + "')"; // ok
                objConexion.SetSentencia1(SenSQL1);
                //objConexion.SetSentencia2(SenSQL2);

                lblResultado.Text = " Se Muestran Todos Los Clientes";


                System.Data.DataSet miDS;
                miDS = new System.Data.DataSet();
                miDS = objConexion.Consultar();

                int seleccionados;
                seleccionados = miDS.Tables["Tabla"].Rows.Count;

                if (seleccionados == 0)
                {
                    lblCedula.Text = " No se encuentran Datos";
                    lblNombres.Text = " ";
                    lblApellidos.Text = " ";
                    lblDireccion.Text = " ";
                    lblTelefono.Text = " ";
                }
                else
                {

                    dataGridView1.DataSource = miDS.Tables["Tabla"];
                    //				dataGrid1.Show();

                }

                // lblmsj.Text = " Se creo nuevo cliente " + MiConexion.EjecutarSQL2();// mostramos mensaje
            }
            catch (Exception es)
            {
                lblResultado.Text = "Hubo el siguiente error " + es.Message;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaAppBdAEO.conexion objConexion;  // Se hace referencia a un objeto de tipo conexion (clase)
                objConexion = new LogicaAppBdAEO.conexion(); // Se crea la instancia (objeto MiConexion) de la clase conexion. 
                string SenSQL1;
                string SenSQL2;
                LogicaAppBdAEO.Cliente objCliente;
                objCliente = new LogicaAppBdAEO.Cliente();
                objCliente.EscribirCedula(tbCedula.Text);

                SenSQL1 = objCliente.BorrarCliente(); ;
                //SenSQL1=@"Insert into Persona (CodPersona,Nombres, Apellidos) VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
                //SenSQL2 = @"Insert into Auditoria (cedula,fecha_modificacion) VALUES ('" + tbxcc.Text + "','" + DateTime.Now.ToString() + "')"; // ok
                objConexion.SetSentencia1(SenSQL1);
                //objConexion.SetSentencia2(SenSQL2);
                objConexion.EjecutarSQL1();
                lblResultado.Text = " Se Borró el Cliente con cedula:" + tbCedula.Text +" "+ objConexion.EjecutarSQL1(); ;


               
                // lblmsj.Text = " Se creo nuevo cliente " + MiConexion.EjecutarSQL2();// mostramos mensaje
            }
            catch (Exception es)
            {
                lblResultado.Text = "Hubo el siguiente error " + es.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nro_identificacion = "";
            if (tbCedula.Text != "")
            {
                nro_identificacion = tbCedula.Text;

                SqlConnection conexionSQL = new SqlConnection("Data Source = GESETIC; Initial Catalog = Ventas; Persist Security Info = True; User ID = SA; Password=ALVARO");
                SqlCommand cmd = new SqlCommand("Listar_Cliente_X_Cedula", conexionSQL);
                cmd.CommandType = CommandType.StoredProcedure;
                conexionSQL.Open();
                cmd.Parameters.AddWithValue("@Nro_identificacion", nro_identificacion);

                SqlDataAdapter objRes;
                objRes = new SqlDataAdapter(cmd);
                System.Data.DataSet datos;
                datos = new System.Data.DataSet();
                objRes.Fill(datos, "Tabla");
                dataGridView1.DataSource = datos.Tables["Tabla"];
                conexionSQL.Close();
                string mensaje = "Todo OK";
            }
            else
            {
                MessageBox.Show("Digite un doc de identidad");
            }
            
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            andresito.WsPrueba gato; // refencia
            gato = new andresito.WsPrueba(); // instancia
            //gato.Sumar(1, 3);
            label1.Text = "Suma con WS=" + gato.Sumar(1, 5);

        }
    }
}
