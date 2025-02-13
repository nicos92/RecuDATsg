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
using Common.Models;
using Domain.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecuDATsg.Vistas
{
    public partial class BuscarDat : UserControl
    {
        private List<string[]> _datModels = new List<string[]>();
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

        private void TxtBuscar__TextChanged(object sender, EventArgs e)
        {
            //_datModels = await _datService.GetAllArchivos(TxtBuscar.Text);
            //await CargadeArchivotDAT();
        }

        private  void BuscarDat_Load(object sender, EventArgs e)
        {
            TxtBuscar.Focus();  
            //await CargadeArchivotDAT();
        }

        private async Task CargadeArchivotDAT()
        {

            _datModels = await _datService.GetAllArchivos();


            ListViewDAT.Items.Clear();
            foreach (string[] item in _datModels)
            {

                // Simula una tarea larga
                var listvi = new ListViewItem(item);

                ListViewDAT.Items.Add(listvi);


            }
        }
    }
}
