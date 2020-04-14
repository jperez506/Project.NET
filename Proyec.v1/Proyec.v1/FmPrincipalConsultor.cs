using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyec.v1
{
    public partial class FmPrincipalConsultor : Form
    {


        public FmPrincipalConsultor(string name)
        {
            InitializeComponent();

        }

        private void FmPrincipalConsultor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); /*es para poder salir de todo el sistema */
        }

        private void FmPrincipalConsultor_Load(object sender, EventArgs e)
        {

        }


        private void btnCrearCliente_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (Form item in Application.OpenForms)   /*carga la pagina de mantenimiento de crear clientes*/
                {
                    if (item.Name == "crudCliente")
                    {
                        return;

                    }
                }

                crudCliente objcrudCliente = new crudCliente();
                objcrudCliente.MdiParent = this;
                objcrudCliente.Show();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnConsuCliente_Click(object sender, EventArgs e)
        {
            try
            {   /*carga la pagina crear troqueles*/
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "ConsultaCliente")
                    {
                        return;

                    }
                }

                ConsultaCliente objConsultaCliente = new ConsultaCliente();
                objConsultaCliente.MdiParent = this;
                objConsultaCliente.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnConsuTroquel_Click(object sender, EventArgs e)
        {
            try
            {   /*carga la pagina crear troqueles*/
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "ConsultaTroqueles")
                    {
                        return;

                    }
                }

                ConsultaTroqueles objConsultaTroqueles = new ConsultaTroqueles();
                objConsultaTroqueles.MdiParent = this;
                objConsultaTroqueles.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
