using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuDATsg.Vistas
{
    public partial class IngresoDat : UserControl
    {
        public IngresoDat()
        {
            InitializeComponent();
        }

        private void IngresoDat_Load(object sender, EventArgs e)
        {
            TxtArchivo.Focus();
        }
    }
}
