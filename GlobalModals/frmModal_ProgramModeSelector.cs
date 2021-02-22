using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestão_de_Produtos.Modals
{
    public partial class frmModal_ProgramModeSelector : Form
    {
        internal byte selected;

        public frmModal_ProgramModeSelector()
        {
            InitializeComponent();
        }

        private void pnlModeMarket_Click(object sender, EventArgs e)
        {
            selected = 1;
            Close();            
        }

        private void pnlModeLogistic_Click(object sender, EventArgs e)
        {            
            selected = 2;
            Close();
        }

        private void pnlModeMarket2_Click(object sender, EventArgs e)
        {
            pnlModeMarket_Click(pnlModeMarket2, new EventArgs());
        }

        private void pnlModeLogistic2_Click(object sender, EventArgs e)
        {
            pnlModeLogistic_Click(pnlModeMarket2, new EventArgs());
        }
    }
}
