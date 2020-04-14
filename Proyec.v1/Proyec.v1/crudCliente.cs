using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyec.v1
{
    public partial class crudCliente : Form
    {

        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        DataTable dt;  /*declaracion de un datatable para meterlo en un dataadapter y refeljarlo en un gridv*/
        SqlDataAdapter da;

        public crudCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void crudCliente_Load(object sender, EventArgs e)
        {
            limpiarcampos();
            txtCedula.Focus();


        }



        public void consultarCliente()
        {
             //metodo parahacer un select from de la tabla cliente

            establecerConexion();

            try
            {
                da = new SqlDataAdapter("Exec sp_ConsultaCliente", cnx);
                dt = new DataTable();
                da.Fill(dt);
                dtgCliente.DataSource = dt;
                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: "+e);
               
            }


        }

        void crearCliente()
        {
            try
            {   /*hacemos una valdiacion de campos vacios */
                if (txtCedula.Text.Trim() == "")
                {
                    pError.SetError(txtCedula, "Ingrese una cedula....");
                    txtCedula.Focus();
                }
                else if (txtCliente.Text.Trim()=="")
                {
                   
                    pError.SetError(txtCliente, "Ingrese una Nombre de cliente....");
                    txtCliente.Focus();
                }
                else if (txtNombreCompleto.Text.Trim()=="")
                {
                  
                    pError.SetError(txtNombreCompleto, "Ingrese una Nombre Contacto....");
                    txtNombreCompleto.Focus();
                }
                else if (txtCodigoTro.Text.Trim()=="")
                {
                   
                    pError.SetError(txtCodigoTro, "Ingrese un codigo Troquel....");
                    txtCodigoTro.Focus();
                }
                else {
                    pError.Clear();
                    /* metodo para hacer un insert into a la tabla cliente*/

                    string agregar1 = "Exec sp_CrearCliente '" + txtCliente.Text + "','" + txtNombreCompleto.Text + "'," + txtCedula.Text + ",'" + txtCodigoTro.Text + "';";

                    establecerConexion();
                    cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    cmd.CommandText = agregar1;
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    cnx.Dispose();
                }                         

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
              
            }

        }

        void modificarCliente()

        {
            try
            {  /* condicion para validar campos vacios*/
                if (txtCedula.Text.Trim() == "")
                {
                    
                    pError.SetError(txtCedula, "Ingrese una cedula....");
                    txtCedula.Focus();
                }
                else if (txtCliente.Text.Trim() == "")
                {
                    
                    pError.SetError(txtCliente, "Ingrese una Nombre de cliente....");
                    txtCliente.Focus();
                }
                else if (txtNombreCompleto.Text.Trim() == "")
                {
                  
                    pError.SetError(txtNombreCompleto, "Ingrese una Nombre Contacto....");
                    txtNombreCompleto.Focus();
                }
                else if (txtCodigoTro.Text.Trim() == "")
                {
                  
                    pError.SetError(txtCodigoTro, "Ingrese un codigo Troquel....");
                    txtCodigoTro.Focus();
                }
                else
                {
                    pError.Clear();
                    /*metodo para hacer un update a la tabla*/
                    string modificar = string.Format("Exec sp_ModificarCliente '{0}','{1}','{2}','{3}'", txtCliente.Text.Trim(), txtNombreCompleto.Text.Trim(), txtCedula.Text.Trim(), txtCodigoTro.Text.Trim());
                    establecerConexion();
                    cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    cmd.CommandText = modificar;
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    cnx.Dispose();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
              
            }

        }

        void elimnarCliente()
        {

            try   /* metodo para hacer un delete from y where de la tabla*/
            {

                if (txtCedula.Text.Trim() == "")   /*para validar campos vacios*/
                {
                  
                    pError.SetError(txtCedula, "Ingrese una cedula....");
                    txtCedula.Focus();
                }
                else {
                    pError.Clear();
                    string eliminar = string.Format("Exec sp_EliminarCliente '{0}','{1}','{2}','{3}'", txtCliente.Text.Trim(), txtNombreCompleto.Text.Trim(), txtCedula.Text.Trim(), txtCodigoTro.Text.Trim());
                    establecerConexion();
                    cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    cmd.CommandText = eliminar;
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    cnx.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
              
            }

        }

        private bool establecerConexion()
        {   /*estabelcemos coneccion a sql*/
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

        public void limpiarcampos()
        {   /*metodo para limpiar campos para luego ser llamado por eventos */
            try
            {
                //pError.Clear();
                txtCedula.Text = ("");
                txtCliente.Text = ("");
                txtCodigoTro.Text = ("");
                txtNombreCompleto.Text = ("");
                txtCedula.Focus();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: "+e);
               
            }

        }

        #region "B

        private void btnCrearCli_Click(object sender, EventArgs e)
        {  /* boton crear llamando metodos*/
            crearCliente();
            limpiarcampos();
            consultarCliente();
            
        }

        private void btnConsultarCli_Click(object sender, EventArgs e)
        {/* boton consultar llamando metodos*/
            consultarCliente();
        }

        private void btnModificarCli_Click(object sender, EventArgs e)
        {/* boton modificar llamando metodos*/
            modificarCliente();
            limpiarcampos();
            consultarCliente();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {/* boton eliminar llamando metodos*/
            elimnarCliente();
            limpiarcampos();
            consultarCliente();
           

        }
        #endregion
    }
}
