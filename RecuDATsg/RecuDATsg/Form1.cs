using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecuDATsg.Vistas;

namespace RecuDATsg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirBuscarDat();
        }

        private void AbrirBuscarDat()
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
                AbrirBuscarDat();
            }
           
        }

        private void BtnVentanaIngresar_Click(object sender, EventArgs e)
        {
            Type tipo = PanelFill.Controls[0].GetType();
            if (tipo.Name != "IngresoDat")
            {
                AbrirIngresarDat();
            }
        }
    }
}
