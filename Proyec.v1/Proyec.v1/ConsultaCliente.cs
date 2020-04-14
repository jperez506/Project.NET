using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;



namespace Proyec.v1
{
    public partial class ConsultaCliente : Form
    {

        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;


        public ConsultaCliente()
        {
            InitializeComponent();

        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {

        }

        public void consultarCliente()
        {

                establecerConexion();

                da = new SqlDataAdapter("Exec sp_ConsultaCliente", cnx);
                dt = new DataTable();
                da.Fill(dt);
                dtgCliente.DataSource = dt;

                cnx.Close();
                cnx.Dispose();
            

        }
        private bool establecerConexion()
        {  /*establecemos la conexion */
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

        private void btnTodo_Click(object sender, EventArgs e)
        {  /*bton donde llamaos los metodos que realizamos*/
            consultarCliente();
            pError.Clear();


        }

        public void consultarClienteCED()
        {
            try
            {  /* metodo para consultar cliente */

                if (txtCedula.Text.Trim() == "")
                {
                    pError.SetError(txtCedula, "Debe Ingresar una Cedula Cliente...");
                    txtCedula.Focus();
                }
                else
                {
                    pError.Clear();
                    establecerConexion();

                    da = new SqlDataAdapter(string.Format("Exec sp_ConsultaClienteCED '{0}'", txtCedula.Text), cnx);
                    dt = new DataTable();
                    da.Fill(dt);
                    dtgCliente.DataSource = dt;

                    cnx.Close();
                    cnx.Dispose();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error: "+e);
            }

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {  /*metodo para llamar la funcuon que se ocupa*/
            consultarClienteCED();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }
    }
}
