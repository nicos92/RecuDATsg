using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Common.Models;
using Domain.Service;

namespace RecuDATsg.Vistas
{
    public partial class IngresoDat : UserControl
    {
        private readonly SectoresService _services = new SectoresService();
        private readonly DatService _datService = new DatService();
        private readonly NSMessageBox.NSMessageBox mensaje = new NSMessageBox.NSMessageBox();

        public IngresoDat()
        {
            InitializeComponent();
        }

        private void IngresoDat_Load(object sender, EventArgs e)
        {
            TxtArchivo.Focus();
            CargaSectores();

        }

        private async void CargaSectores()
        {
            ComBoxSectores.Items.Clear();
            string[] strings = await _services.GetSectores();
            ComBoxSectores.Items.AddRange(strings);

        }

        private async void BtnIngresar_Click(object sender, EventArgs e)
        {
            DialogResult si = mensaje.ShowDialog("Ingreso", "¿Estas de acuerdo hacer el ingreso?", NSMessageBox.Iconos.Question, NSMessageBox.Botones.AceptarCancelar);
            MessageBox.Show(si.ToString());
            if (si == DialogResult.Yes)
            {
                string archivo = TxtArchivo.Text;
                string sector = ComBoxSectores.Text;
                string cartelerror = TxtCartelError.Text;
                string observacion = TxtObservacion.Text;
                DatModel datModel = new DatModel(archivo, sector, cartelerror, observacion);
                bool result = await _datService.InsertDat(datModel);

                if (result)
                {
                    mensaje.ShowDialog("Ingreso", "El archivo fue ingresado correctamente", NSMessageBox.Iconos.Check, NSMessageBox.Botones.Aceptar);
                    LimpiarTxts();
                }
            }


        }

        private void LimpiarTxts()
        {
            TxtArchivo.Text = string.Empty;
            TxtCartelError.Text = string.Empty;
            TxtObservacion.Text = string.Empty;
            ComBoxSectores.Text = string.Empty;
        }

        private void BtnIngresar_EnabledChanged(object sender, EventArgs e)
        {
            if (BtnIngresar.Enabled)
            {
                BtnIngresar.BackGroudColor = Ayudas._colores.Primary;
            }
            else { BtnIngresar.BackGroudColor = Ayudas._colores.Secondary; }
        }

        private void HabilitarBtnIngresar()
        {
            //ComBoxSectores.Items.Contains(ComBoxSectores.Text)
            BtnIngresar.Enabled = TxtArchivo.Text.Length > 0 && ComBoxSectores.Items.Contains(ComBoxSectores.Text) && TxtCartelError.Text.Length > 0 && TxtObservacion.Text.Length > 0;
        }

        private void TxtArchivo__TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnIngresar();
        }

        private void TxtObservacion__TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnIngresar();

        }

        private void TxtCartelError__TextChanged(object sender, EventArgs e)
        {
            HabilitarBtnIngresar();

        }

        private void ComBoxSectores_TextChanged(object sender, EventArgs e)
        {
            ValidarComBoxTXT();
            HabilitarBtnIngresar();


        }

        private void ValidarComBoxTXT()
        {
            bool validacion = ComBoxSectores.Items.Contains(ComBoxSectores.Text);
            string menj = "Debes elegir una opcion de la lista del Combo";
            if (!validacion)
            {
                ErrorSector.SetError(ComBoxSectores, menj);
                ErrorSector.SetError(BtnIngresar, menj);
            }
            else { ErrorSector.Clear(); }
        }
    }
}
