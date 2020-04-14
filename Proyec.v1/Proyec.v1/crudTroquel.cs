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
    public partial class crudTroquel : Form
    {

        SqlConnection cnx; //Declarando el objeto no lo inicializo
        SqlCommand cmd; //Declarado
        SqlDataReader dr;
        DataTable dt; /*declaracion de un datatable para meterlo en un dataadapter y refeljarlo en un gridv*/
        SqlDataAdapter da;

        public crudTroquel()
        {
            try
            {

                InitializeComponent();


                txtEstadoT.DisplayMember = "descripEstado";
                txtEstadoT.ValueMember = "descripEstado";
                txtEstadoT.DataSource = fmPrincipal.listaEstado;
                //txtEstadoT.DataSource = FmPrinciaplModificador.listaEstado2;

                //txtEstadoT.DataSource = FmPrinciaplModificador.listaEstado2;
                
                txtEstadoT.SelectedIndex = 0;
                
   
            }
            catch (Exception e)
            {

                MessageBox.Show("Error: "+e);
            }


        }

        private void crudTroquel_Load(object sender, EventArgs e)
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
            txtCodigo.Text = "";
            txtTroquel.Text = "";
            txtCarac.Text = "";
            txtDesc.Text = "";
            txctMaterial.Text = "";
            txtEstadoT.Text = "";
            txtCodigo.Focus();

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
                dtgTroquel.DataSource = dt;
                cnx.Close();
                cnx.Dispose();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: "+e);
             
            }

        }

        void crearTroquel()
        {
            try
            {
                if (txtCodigo.Text.Trim()=="") /* validacion de campos */
                {
                    pError.SetError(txtCodigo,"Debe ingresar un Codigo...");
                    txtCodigo.Focus();
                }
                else if (txtTroquel.Text.Trim()=="")
                {
                    pError.SetError(txtTroquel,"Debe ingresar un Nombre Troquel");
                    txtTroquel.Focus();
                }
                else if (txtCarac.Text.Trim() == "")
                {
                    pError.SetError(txtCarac, "Debe ingresar un Caracteristicas");
                    txtCarac.Focus();
                }
                else if (txtDesc.Text.Trim() == "")
                {
                    pError.SetError(txtDesc, "Debe ingresar Descripcion");
                    txtDesc.Focus();
                }
                else if (txctMaterial.Text.Trim() == "")
                {
                    pError.SetError(txctMaterial, "Debe ingresar Material");
                    txctMaterial.Focus();
                }
                else if (dateOrigen.Value.ToString()== "")
                {
                    pError.SetError(dateOrigen, "Debe ingresar Fecha Origen");
                    dateOrigen.Focus();
                }
                else if (dateMantenimiento.Value.ToString() == "")
                {
                    pError.SetError(dateMantenimiento, "Debe ingresar Fecha Mantenimiento");
                    dateMantenimiento.Focus();
                }
                else if (txtEstadoT.Text.Trim() == "")
                {
                    pError.SetError(txtEstadoT, "Debe ingresar Estado");
                    txtEstadoT.Focus();
                }
                else
                {
                    pError.Clear();
                    /*METODO PARA HACER UN INSERT INTO*/
                    string agregar3 = string.Format("Exec sp_CrearTroquel '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                     txtTroquel.Text.Trim(), txtCodigo.Text.Trim(), txtDesc.Text.Trim(), txtCarac.Text.Trim(), txctMaterial.Text.Trim(),
                     dateOrigen.Value.ToString(), dateMantenimiento.Value.ToString(), txtEstadoT.SelectedValue);

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
                MessageBox.Show("Error: "+e);
                
            }
        }

        void ModificarTroquel()
        {
            try
            {

                if (txtCodigo.Text.Trim() == "") /* validacion de campos */
                {
                    pError.SetError(txtCodigo, "Debe ingresar un Codigo...");
                    txtCodigo.Focus();
                }
                else if (txtTroquel.Text.Trim() == "")
                {
                    pError.SetError(txtTroquel, "Debe ingresar un Nombre Troquel");
                    txtTroquel.Focus();
                }
                else if (txtCarac.Text.Trim() == "")
                {
                    pError.SetError(txtCarac, "Debe ingresar un Caracteristicas");
                    txtCarac.Focus();
                }
                else if (txtDesc.Text.Trim() == "")
                {
                    pError.SetError(txtDesc, "Debe ingresar Descripcion");
                    txtDesc.Focus();
                }
                else if (txctMaterial.Text.Trim() == "")
                {
                    pError.SetError(txctMaterial, "Debe ingresar Material");
                    txctMaterial.Focus();
                }
                else if (dateOrigen.Value.ToString() == "")
                {
                    pError.SetError(dateOrigen, "Debe ingresar Fecha Origen");
                    dateOrigen.Focus();
                }
                else if (dateMantenimiento.Value.ToString() == "")
                {
                    pError.SetError(dateMantenimiento, "Debe ingresar Fecha Mantenimiento");
                    dateMantenimiento.Focus();
                }
                else if (txtEstadoT.Text.Trim() == "")
                {
                    pError.SetError(txtEstadoT, "Debe ingresar Estado");
                    txtEstadoT.Focus();
                }
                else
                {
                    pError.Clear();
                    /*METODO PARA HACER UN UPDATE */
                    string agregar3 = string.Format("Exec sp_ModificarTroquel '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                    txtTroquel.Text.Trim(), txtCodigo.Text.Trim(), txtDesc.Text.Trim(), txtCarac.Text.Trim(), txctMaterial.Text.Trim(),
                    dateOrigen.Value.ToString(), dateMantenimiento.Value.ToString(), txtEstadoT.SelectedValue);

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
                if (txtCodigo.Text.Trim() == "") /* validacion de campos */
                {
                    pError.SetError(txtCodigo, "Debe ingresar un Codigo...");
                    txtCodigo.Focus();
                }
                else
                {
                    pError.Clear();
                    /*METODO PARA HACER UN ELIMINAR DELETE DROM WHERE*/
                    string agregar3 = string.Format("Exec sp_EliminarTroquel '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                    txtTroquel.Text.Trim(), txtCodigo.Text.Trim(), txtDesc.Text.Trim(), txtCarac.Text.Trim(), txctMaterial.Text.Trim(),
                    dateOrigen.Value.ToString(), dateMantenimiento.Value.ToString(), txtEstadoT.SelectedValue);

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
        {   /*BTON DE CONSULTAR Y LLAMA METODOS A USAR */
            consultarTroquel();
        }

        private void btnCrearTro_Click(object sender, EventArgs e)
        {  /*BTON DE CREAR Y LLAMA METODOS A USAR */
            crearTroquel();
            limpiarcampo();
            consultarTroquel();
           
        }

        private void btModificarTro_Click(object sender, EventArgs e)
        {  /*BTON DE MODIFICAR Y LLAMA METODOS A USAR */
            ModificarTroquel();
            limpiarcampo();
            consultarTroquel();
            
        }

        private void btnEliminarTro_Click(object sender, EventArgs e)
        {/*BTON DE ELIMINAR Y LLAMA METODOS A USAR */
            EliminarTroquel();
            limpiarcampo();
            consultarTroquel();
           
        }

        private void dateOrigen_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
