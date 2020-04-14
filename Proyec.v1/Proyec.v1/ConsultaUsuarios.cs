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

namespace Proyec.v1
{
    public partial class ConsultaUsuarios : Form
    {

        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;


        public ConsultaUsuarios()
        {
            InitializeComponent();
        }
        public void consultarUsuario()
        {
            try
            {  /* metodo para buscar toda la tabla de usuarios */
                establecerConexion();

                da = new SqlDataAdapter("Exec sp_ConsultaUsuario", cnx);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                cnx.Close();
                cnx.Dispose();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error: "+e);
            }


        }

        public void consultarUsuarioCED()
        {

            try  /*metodo pra consultar un usuario por su cedula */
            {
                if (txtCedula.Text.Trim()=="")
                {
                    pError.SetError(txtCedula,"Debe ingresar una Cedula Valida Usuario''");
                    txtCedula.Focus();
                }
                else
                {
                    pError.Clear();
                    establecerConexion();

                    da = new SqlDataAdapter(string.Format("Exec sp_ConsultaUsuarioCED '{0}'", txtCedula.Text), cnx);
                    establecerConexion();
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    cnx.Close();
                    cnx.Dispose();

                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error: "+e);
            }

        }
        private bool establecerConexion()
        {
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTodo_Click(object sender, EventArgs e)
        {  /*boton que se usa para llamar los metodos realizados */
            consultarUsuario();
            pError.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarUsuarioCED();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }
    }
}
