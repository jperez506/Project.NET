using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Proyec.v1.Entidades;


namespace Proyec.v1
{
    public partial class crudUsuarios : Form
    {
             //datos topo data sqlcliente para poder usar la base sql
        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;

        public crudUsuarios()
        {   /*  este metodo nos permite desplegar los valores de la lista que tenemos en el from principal statica que guarda los valores del combo box*/
            
            try
            {
                InitializeComponent();

                txtRol.DisplayMember = "descripU";
                txtRol.ValueMember = "descripU";
                txtRol.DataSource = fmPrincipal.listaTipoUsuario;

                txtRol.SelectedIndex = 0;
            }
            catch (Exception  e)
            {
                MessageBox.Show("Error :"+e);
                
            }

        }

        private void crudUsuarios_Load(object sender, EventArgs e)
        {   
            //no cargamos nada en el load ya que solo mediante los eventos de los botones hara algo
        }

        private bool establecerConexion()
        {            /*  metodo para establecer conexion a sql local*/
            try   
            {
                cnx = new SqlConnection("Data Source =.; Initial Catalog = BaseRJJF; Integrated Security = True");

                cnx.Open();
                if (cnx.State == ConnectionState.Open)
                {
                    return true;

                }
                else
                {
                    return false;

                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        void consultarUsuario()
        {
                 //metodo consulta que hace un selec from de la tabla de usuarios
            try
            {
                    establecerConexion();

                    da = new SqlDataAdapter("Exec sp_ConsultaUsuario", cnx);
                    dt = new DataTable();
                    da.Fill(dt);
                    dtgUsuario.DataSource = dt;
                    cnx.Close();
                    cnx.Dispose();
                         
            }
            catch (Exception e)
            {
                MessageBox.Show("Error :" + e);
                
            }

        }
        public void limpiarcampo()
        {   /*metodo que nos limpia los campos cuando es llamado */
            try
            {
                txCedula.Text = string.Empty;
                txtClave.Text = (""); ;
                txtClave.Text = ("");
                txNombreCompleto.Text = ("");
                txCedula.Focus();
                //pError.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e);
               
            }

        }
        void crearUsuario()
        {   /*  metodo para hacer insert into a la tabla en sql*/
            try
            {
                if (txCedula.Text.Trim() == "")  /* v/alidamos los campos*/
                {
                    pError.SetError(txCedula, "Debe ingresar una Cedula...");
                    txCedula.Focus();
                }
                else if (txNombreCompleto.Text.Trim() == "")
                {
                    pError.SetError(txNombreCompleto, "Debe ingresar un NOmbre Completo...");
                    txNombreCompleto.Focus();
                }
                else if (txtRol.SelectedValue.ToString() == "")
                {
                    pError.SetError(txtRol, "Debe seleccionar un Rol...");
                    txtRol.Focus();
                }
                else if (txtClave.Text.Trim() == "")
                {
                    pError.SetError(txtClave, "Debe Ingresar una clave...");
                    txtClave.Focus();
                }
                else
                {

                    pError.Clear();
                    string agregar2 = "Exec sp_CrearUsuario " + txCedula.Text + ",'" + txNombreCompleto.Text + "','" + txtRol.SelectedValue + "','" + dateMotificacion.Value.ToString() + "','" + txtClave.Text + "';";

                    establecerConexion();
                    cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    cmd.CommandText = agregar2;
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    cnx.Dispose();
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Error :" + e);
            }
        }

        void modificarUsuario()

        {   /*metodo para hacer un update a la tabla sql*/
            try
            {
                if (txCedula.Text.Trim() == "")  /**validamos los campos*/
                {
                    pError.SetError(txCedula, "Debe ingresar una Cedula...");
                    txCedula.Focus();
                }
                else if (txNombreCompleto.Text.Trim() == "")
                {
                    pError.SetError(txNombreCompleto, "Debe ingresar un NOmbre Completo...");
                    txNombreCompleto.Focus();
                }
                else if (txtRol.SelectedValue.ToString() == "")
                {
                    pError.SetError(txtRol, "Debe seleccionar un Rol...");
                    txtRol.Focus();
                }
                else if (txtClave.Text.Trim() == "")
                {
                    pError.SetError(txtClave, "Debe Ingresar una clave...");
                    txtClave.Focus();
                }
                else
                {
                    pError.Clear();
                    string modificar2 = string.Format("Exec sp_ModificarUsuario '{0}','{1}','{2}','{3}','{4}'", txCedula.Text.Trim(), txNombreCompleto.Text.Trim(), txtRol.SelectedValue, dateMotificacion.Value.ToString()
                                                       , txtClave.Text.Trim());
                    establecerConexion();
                    cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    cmd.CommandText = modificar2;
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    cnx.Dispose();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error :" + e);
                
            }

        }

        void elimnarUsuario()
        {  /*metodo para eliminar datos donde cedula sea igual a cedula */
            try
            {
                if (txCedula.Text.Trim() == "")  /**validamos los campos*/
                {
                    pError.SetError(txCedula, "Debe ingresar una Cedula...");
                    txCedula.Focus();
                }
                else
                {
                    pError.Clear();
                    string eliminar2 = string.Format("Exec sp_EliminarUsuario '{0}','{1}','{2}','{3}'", txCedula.Text.Trim(), txNombreCompleto.Text.Trim(), txtRol.SelectedValue, dateMotificacion.Value.ToString());
                    establecerConexion();
                    cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    cmd.CommandText = eliminar2;
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    cnx.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error :" + e);
                
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        { /* boton de consulta donde se llama metodo consultar*/
            consultarUsuario();



        }

        private void bntCrear_Click(object sender, EventArgs e)
        {   /*boton de crear llamamos metodos crear, consultar y limpiar*/
            crearUsuario();
            limpiarcampo();
            consultarUsuario();
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            //Boton de modificar llamamos dichos metodos
            modificarUsuario();
            limpiarcampo();
            consultarUsuario();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {              //Boton de eliminar llamamos dichos metodos
            elimnarUsuario();
            limpiarcampo();
            consultarUsuario();
           
        }

   
    }
}
