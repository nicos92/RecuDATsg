using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;
using RecuDATsg.Vistas;

namespace RecuDATsg
{
    public partial class Form1RecuDat : Form
    {
        private readonly ColoresARGB _colores = new ColoresARGB();
        public Form1RecuDat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AbrirVentanaBuscarDat();
            MostrarVistas(new BuscarDat());
            BtnMenu_Click(sender,e);
        }

        private void AbrirVentanaBuscarDat()
        {
            PanelFill.Controls.Clear();
            UserControl VentanaBuscar = new BuscarDat();
            PanelFill.Controls.Add(VentanaBuscar);
        }

        private void AbrirIngresarDat()
        {
            PanelFill.Controls.Clear();
            UserControl VentanaIngresar = new IngresoDat();

            PanelFill.Controls.Add(VentanaIngresar);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Type tipo = PanelFill.Controls[0].GetType();
            if (tipo.Name != "BuscarDat")
            {
                //AbrirVentanaBuscarDat();
                MostrarVistas(new BuscarDat());
                CambioColorBuscar();
            }

        }

        private void CambioColorBuscar()
        {
            //BtnVentanaIngreso.BackColor = _colores.DarkBackText;
            //BtnVentanaIngreso.ForeColor = _colores.Secondary;

            //BtnVentanaBusqueda.BackColor = _colores.Blue;
            //BtnVentanaBusqueda.ForeColor = _colores.Light;
            BtnVentanaIngreso.BackColor = _colores.Dark;

            BtnVentanaBusqueda.BackColor = _colores.Primary;
        }

        private void BtnVentanaIngresar_Click(object sender, EventArgs e)
        {
            Type tipo = PanelFill.Controls[0].GetType();
            if (tipo.Name != "IngresoDat")
            {
                //AbrirIngresarDat();

                MostrarVistas(new IngresoDat());
                CambioColorIngresar();

            }
        }

        private void CambioColorIngresar()
        {
            BtnVentanaIngreso.BackColor = _colores.Purple;

            BtnVentanaBusqueda.BackColor = _colores.Dark;
        }

        private void MostrarVistas(UserControl userControl)
        {
            userControl.Size = new Size(PanelFill.Width, PanelFill.Height);
            PanelFill.Controls.Clear();
            PanelFill.Controls.Add(userControl);
            
            userControl.BringToFront();

        }



        private void BtnMenu_Click(object sender, EventArgs e)
        {
            
            int pl = 36;
            if (PanelLeft.Width == pl)
            {
                PanelLeft.Width = 128;
                BtnMenu.Text = "Menú";
                BtnVentanaBusqueda.Text = "Buscar";
                BtnVentanaIngreso.Text = "Ingresar";
                PanelFill.Controls[0].Size = new Size(PanelFill.Width, PanelFill.Height);
            }
            else
            {
                PanelLeft.Width = pl;
                BtnMenu.Text = string.Empty;
                BtnVentanaBusqueda.Text = string.Empty;
                BtnVentanaIngreso.Text = string.Empty;
                PanelFill.Controls[0].Size = new Size(PanelFill.Width, PanelFill.Height);


            }
        }

    }
}
