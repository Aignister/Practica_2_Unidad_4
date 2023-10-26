using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2_Unidad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        public void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }
        */
        public void CallCrudLibrosProcedure(string opc)
        {
            using (DataClasses1DataContext contex = new DataClasses1DataContext())
            {
                switch (opc)
                {
                    case "Ingresar":

                        break;
                    case "Eliminar":

                        break;
                    case "Modificar":

                        break;
                    case "Buscar":

                        break;
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string opc = "Ingresar";
            CallCrudLibrosProcedure(opc);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string opc = "Eliminar";
            CallCrudLibrosProcedure(opc);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string opc = "Modificar";
            CallCrudLibrosProcedure(opc);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string opc = "Buscar";
            CallCrudLibrosProcedure(opc);
        }
    }
}
