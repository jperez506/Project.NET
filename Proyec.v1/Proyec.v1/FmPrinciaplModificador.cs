using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyec.v1.Entidades;

namespace Proyec.v1
{
    public partial class FmPrinciaplModificador : Form
    {
        public static List<Entidades.TipoEstado> listaEstado2;

        public FmPrinciaplModificador(string nombre)
        {
            InitializeComponent();

            listaEstado2 = new List<TipoEstado>(); /*lists estadica para estados del troquel*/
            TipoEstado objtEstado = new TipoEstado();
            listaEstado2.Add(new TipoEstado() { codEstado = 1, descripEstado = "Bueno" });
            listaEstado2.Add(new TipoEstado() { codEstado = 2, descripEstado = "Regular" });
            listaEstado2.Add(new TipoEstado() { codEstado = 3, descripEstado = "Malo" });
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
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

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {/*carga la pagina crear usuarios*/
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "crudUsuarios")
                    {
                        return;

                    }
                }

                crudUsuarios objcrudUsuarios = new crudUsuarios();
                objcrudUsuarios.MdiParent = this;
                objcrudUsuarios.Show();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnCrearTroquel_Click(object sender, EventArgs e)
        {
            try
            {   /*carga la pagina crear troqueles*/
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "crudTroquel")
                    {
                        return;

                    }
                }

                crudTroquel22 objcrudTroquel = new crudTroquel22();
                objcrudTroquel.MdiParent = this;
                objcrudTroquel.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FmPrinciaplModificador_Load(object sender, EventArgs e)
        {

        }

        private void FmPrinciaplModificador_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void FmPrinciaplModificador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
