using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecuDATsg.Vistas
{
    public partial class BuscarDat : UserControl
    {
        private readonly DatService _datService = new DatService();
        public BuscarDat()
        {
            InitializeComponent();
        }

        private void Copy_Click(object sender, EventArgs e)
        {

        }

        private void BtnRecover_Click(object sender, EventArgs e)
        {

        }



        private async void BuscarDat_Load(object sender, EventArgs e)
        {
            if (DatCache._datModels.Count == 0)
            {
                DatCache._datModels = await _datService.GetAllArchivos();
            }
            CargadeArchivotDAT(DatCache._datModels);
            TxtBuscar.Focus();
        }

        private void CargadeArchivotDAT(IEnumerable<String[]> listaString)
        {



            ListViewDAT.Items.Clear();
            foreach (string[] item in listaString)
            {

                // Simula una tarea larga
                var listvi = new ListViewItem(item);

                ListViewDAT.Items.Add(listvi);


            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var filtrados = from dat in DatCache._datModels
                            where dat[3].Contains(TxtBuscar.Text) || dat[1].Contains(TxtBuscar.Text) || dat[2].Contains(TxtBuscar.Text.ToUpper())
                            select dat;

            CargadeArchivotDAT(filtrados);
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {

            DatCache._datModels = await _datService.GetAllArchivos();

            CargadeArchivotDAT(DatCache._datModels);
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnBuscar_Click(sender, e);
            }
        }
    }
}
