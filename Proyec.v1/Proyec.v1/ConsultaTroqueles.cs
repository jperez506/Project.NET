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
    public partial class ConsultaTroqueles : Form
    {

        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;

        public ConsultaTroqueles()
        {
            InitializeComponent();
        }

        public void consultarTroquel()
        {

            try  /*metodo para consultar troqueles */
            {
                establecerConexion();

                da = new SqlDataAdapter("Exec sp_ConsultaTroquel", cnx);
                dt = new DataTable();
                da.Fill(dt);
                dtgTroquel.DataSource = dt;

                cnx.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error: "+e);
            }

            cnx.Dispose();
        }
        public void consultarTroquelCOD()
        {
            //metodo para consultar troquel por codigo


            try
            {
                if (txtCodigo.Text.Trim()=="")
                {
                    pError.SetError(txtCodigo,"Debe ingresar un Codigo de Troquel Valido...");
                    txtCodigo.Focus();

                }
                else
                {
                    pError.Clear();
                    establecerConexion();

                    da = new SqlDataAdapter(string.Format("Exec sp_ConsultaTroquelCOD '{0}'", txtCodigo.Text), cnx);
                    establecerConexion();
                    dt = new DataTable();
                    da.Fill(dt);
                    dtgTroquel.DataSource = dt;

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

        private void btnTodo_Click(object sender, EventArgs e)
        {  /*bton que se usa para llamar los metodos realizados*/
            consultarTroquel();
            pError.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarTroquelCOD();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }
    }
}
