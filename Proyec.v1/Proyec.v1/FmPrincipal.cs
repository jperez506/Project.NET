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
    public partial class fmPrincipal : Form
    {

        public static List<Entidades.TipoUsuario> listaTipoUsuario;/* lista statica que guarda valores*/
        public static List<Entidades.TipoEstado> listaEstado;

        public fmPrincipal(string nombre)
        {
            InitializeComponent();    /*aqui metemos a la lista los valores a desplegar para que luego en el loead lo cargue en este form*/
            listaTipoUsuario = new List<Entidades.TipoUsuario>();
            TipoUsuario objU = new TipoUsuario(); 
            listaTipoUsuario.Add(new TipoUsuario() {codTipo  = 1,descripU="Administrador" });
            listaTipoUsuario.Add(new TipoUsuario() { codTipo = 2, descripU = "Modificador" });
            listaTipoUsuario.Add(new TipoUsuario() { codTipo = 3, descripU = "Consultor" });

            listaEstado = new List<TipoEstado>(); /*lists estadica para estados del troquel*/
            TipoEstado objtEstado = new TipoEstado();
            listaEstado.Add(new TipoEstado() {codEstado=1,descripEstado="Bueno" });
            listaEstado.Add(new TipoEstado() { codEstado = 2, descripEstado = "Regular" });
            listaEstado.Add(new TipoEstado() { codEstado = 3, descripEstado = "Malo" });

        }

        private void fmPrincipal_Load(object sender, EventArgs e)
        {


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
            catch (Exception )
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

                crudTroquel objcrudTroquel = new crudTroquel();
                objcrudTroquel.MdiParent = this;
                objcrudTroquel.Show();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void fmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void fmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnConsuUsiario_Click(object sender, EventArgs e)
        {
            try
            {   /*carga la pagina crear troqueles*/
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Name == "ConsultaUsuarios")
                    {
                        return;

                    }
                }

                ConsultaUsuarios objConsultaUsuario = new ConsultaUsuarios();
                objConsultaUsuario.MdiParent = this;
                objConsultaUsuario.Show();
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
