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
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
        }
           //CONEXION A LA BD
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = BaseRJJF; Integrated Security = True");

        public void logear(string usuario, string contrasena) {
            //METODO PARA PODER INGRESAR AL LOGIN
            try
            {
            //    ESTE METODO EMPIEZA ABRIENDO EL LOGIN, ABRE LA CADENA DE COENXION, LUEGO HACE UN SELECT WHERE LLAME A CEDULA Y CLAVE SEAN IGUAL A LO INGRESADO POR TXT DE CAMPOS
            ////        DE C#
                con.Open();
                SqlCommand cmd = new SqlCommand("select cedula,rol, Clave from TablaUsuario where cedula= @cedula and Clave = @contrasena", con);
                cmd.Parameters.AddWithValue("@cedula", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();  /*ME METE EL SELEC EN UNA TABLA LLAMADA DT Y ESTA SE INGRESA EN EL DATAADATAPTER */
                sda.Fill(dt);

                if (dt.Rows.Count == 1) /*si si se pudo hacer un select entonces la compare la segunda columna[1] que sea igual a rol administrador o modificador o consultor y segun*/
                //    corresponde abre el menu principal que corresponda
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        new fmPrincipal(dt.Rows[0][1].ToString()).Show();
                        MessageBox.Show("Rol Administrador");
                    }
                    if (dt.Rows[0][1].ToString() == "Modificador")
                    {
                        new FmPrinciaplModificador(dt.Rows[0][1].ToString()).Show();
                        MessageBox.Show("Rol Modificador");
                    }
                    if (dt.Rows[0][1].ToString()=="Consultor")
                    {
                        new FmPrincipalConsultor(dt.Rows[0][1].ToString()).Show();
                        MessageBox.Show("Rol Consultor");
                    }

                }
                else
                {  /* si no hay ningun select entonces esta incorrecto */
                    MessageBox.Show("Usuario y/o Contrasena Incorrecta");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally {
                con.Close();  /*cerramos la conexion de bd siempre*/ 
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            logear(this.txtUsuario.Text,this.txtClave.Text);   /*llamamos el metod en el boton ingresar donde le metemos por parametros los txtbos correspondientes*/
        }

        private void FmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
