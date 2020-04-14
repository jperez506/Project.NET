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
    public partial class crudTroquel22 : Form
    {
        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        DataTable dt; /*declaracion de un datatable para meterlo en un dataadapter y refeljarlo en un gridv*/
        SqlDataAdapter da;

        public crudTroquel22()
        {
            try
            {
                InitializeComponent();
                txtEstadoT2.DisplayMember = "descripEstado";
                txtEstadoT2.ValueMember = "descripEstado";
                //txtEstadoT.DataSource = fmPrincipal.listaEstado;
                txtEstadoT2.DataSource = FmPrinciaplModificador.listaEstado2;

                txtEstadoT2.SelectedIndex = 0;
            }
            catch (Exception e)
            {

                MessageBox.Show("Error: "+e);
            }

        }

        private void crudTroquel22_Load(object sender, EventArgs e)
        {

        }
        private bool establecerConexion()
        {  /*establecemos conexion*/
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
        public void limpiarcampo()
        {  /*METODO PARA LIMPIAR CAMPOS*/
            //pError.Clear();
            txtCodigo2.Text = "";
            txtTroquel2.Text = "";
            txtCarac2.Text = "";
            txtDesc2.Text = "";
            txctMaterial2.Text = "";
            txtEstadoT2.Text = "";
            txtCodigo2.Focus();

        }

        void consultarTroquel()
        {
            //METODO PARA HACER UN SELECT FROM DE LA TABLA
            try
            {
                establecerConexion();

                da = new SqlDataAdapter("Exec sp_ConsultaTroquel", cnx);
                dt = new DataTable();
                da.Fill(dt);
                dtgTroquel2.DataSource = dt;
                cnx.Close();
                cnx.Dispose();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);

            }

        }

        void crearTroquel()
        {
            try
            {
                if (txtCodigo2.Text.Trim() == "") /* validacion de campos */
                {
                    pError.SetError(txtCodigo2, "Debe ingresar un Codigo...");
                    txtCodigo2.Focus();
                }
                else if (txtTroquel2.Text.Trim() == "")
                {
                    pError.SetError(txtTroquel2, "Debe ingresar un Nombre Troquel");
                    txtTroquel2.Focus();
                }
                else if (txtCarac2.Text.Trim() == "")
                {
                    pError.SetError(txtCarac2, "Debe ingresar un Caracteristicas");
                    txtCarac2.Focus();
                }
                else if (txtDesc2.Text.Trim() == "")
                {
                    pError.SetError(txtDesc2, "Debe ingresar Descripcion");
                    txtDesc2.Focus();
                }
                else if (txctMaterial2.Text.Trim() == "")
                {
                    pError.SetError(txctMaterial2, "Debe ingresar Material");
                    txctMaterial2.Focus();
                }
                else if (dateOrigen2.Value.ToString() == "")
                {
                    pError.SetError(dateOrigen2, "Debe ingresar Fecha Origen");
                    dateOrigen2.Focus();
                }
                else if (dateMantenimiento2.Value.ToString() == "")
                {
                    pError.SetError(dateMantenimiento2, "Debe ingresar Fecha Mantenimiento");
                    dateMantenimiento2.Focus();
                }
                else if (txtEstadoT2.Text.Trim() == "")
                {
                    pError.SetError(txtEstadoT2, "Debe ingresar Estado");
                    txtEstadoT2.Focus();
                }
                else
                {
                    pError.Clear();
                    /*METODO PARA HACER UN INSERT INTO*/
                    string agregar3 = string.Format("Exec sp_CrearTroquel '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                     txtTroquel2.Text.Trim(), txtCodigo2.Text.Trim(), txtDesc2.Text.Trim(), txtCarac2.Text.Trim(), txctMaterial2.Text.Trim(),
                     dateOrigen2.Value.ToString(), dateMantenimiento2.Value.ToString(), txtEstadoT2.SelectedValue);

                    establecerConexion();
                    cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    cmd.CommandText = agregar3;
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

        void ModificarTroquel()
        {
            try
            {

                if (txtCodigo2.Text.Trim() == "") /* validacion de campos */
                {
                    pError.SetError(txtCodigo2, "Debe ingresar un Codigo...");
                    txtCodigo2.Focus();
                }
                else if (txtTroquel2.Text.Trim() == "")
                {
                    pError.SetError(txtTroquel2, "Debe ingresar un Nombre Troquel");
                    txtTroquel2.Focus();
                }
                else if (txtCarac2.Text.Trim() == "")
                {
                    pError.SetError(txtCarac2, "Debe ingresar un Caracteristicas");
                    txtCarac2.Focus();
                }
                else if (txtDesc2.Text.Trim() == "")
                {
                    pError.SetError(txtDesc2, "Debe ingresar Descripcion");
                    txtDesc2.Focus();
                }
                else if (txctMaterial2.Text.Trim() == "")
                {
                    pError.SetError(txctMaterial2, "Debe ingresar Material");
                    txctMaterial2.Focus();
                }
                else if (dateOrigen2.Value.ToString() == "")
                {
                    pError.SetError(dateOrigen2, "Debe ingresar Fecha Origen");
                    dateOrigen2.Focus();
                }
                else if (dateMantenimiento2.Value.ToString() == "")
                {
                    pError.SetError(dateMantenimiento2, "Debe ingresar Fecha Mantenimiento");
                    dateMantenimiento2.Focus();
                }
                else if (txtEstadoT2.Text.Trim() == "")
                {
                    pError.SetError(txtEstadoT2, "Debe ingresar Estado");
                    txtEstadoT2.Focus();
                }
                else
                {
                    pError.Clear();
                    /*METODO PARA HACER UN UPDATE */
                    string agregar3 = string.Format("Exec sp_ModificarTroquel '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                    txtTroquel2.Text.Trim(), txtCodigo2.Text.Trim(), txtDesc2.Text.Trim(), txtCarac2.Text.Trim(), txctMaterial2.Text.Trim(),
                    dateOrigen2.Value.ToString(), dateMantenimiento2.Value.ToString(), txtEstadoT2.SelectedValue);

                    establecerConexion();
                    cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    cmd.CommandText = agregar3;
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

        void EliminarTroquel()
        {
            try
            {
                if (txtCodigo2.Text.Trim() == "") /* validacion de campos */
                {
                    pError.SetError(txtCodigo2, "Debe ingresar un Codigo...");
                    txtCodigo2.Focus();
                }
                else
                {
                    pError.Clear();
                    /*METODO PARA HACER UN ELIMINAR DELETE DROM WHERE*/
                    string agregar3 = string.Format("Exec sp_EliminarTroquel '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                    txtTroquel2.Text.Trim(), txtCodigo2.Text.Trim(), txtDesc2.Text.Trim(), txtCarac2.Text.Trim(), txctMaterial2.Text.Trim(),
                    dateOrigen2.Value.ToString(), dateMantenimiento2.Value.ToString(), txtEstadoT2.SelectedValue);

                    establecerConexion();
                    cmd = new SqlCommand();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    cmd.CommandText = agregar3;
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




        private void btnConsultarTro_Click(object sender, EventArgs e)
        {
            /*BTON DE CONSULTAR Y LLAMA METODOS A USAR */
            consultarTroquel();
        }

        private void btnCrearTro_Click(object sender, EventArgs e)
        {
            /*BTON DE CREAR Y LLAMA METODOS A USAR */
            crearTroquel();
            limpiarcampo();
            consultarTroquel();
        }

        private void btModificarTro_Click(object sender, EventArgs e)
        {
            /*BTON DE MODIFICAR Y LLAMA METODOS A USAR */
            ModificarTroquel();
            limpiarcampo();
            consultarTroquel();
        }

        private void btnEliminarTro_Click(object sender, EventArgs e)
        {
            /*BTON DE ELIMINAR Y LLAMA METODOS A USAR */
            EliminarTroquel();
            limpiarcampo();
            consultarTroquel();
        }
    }
}
