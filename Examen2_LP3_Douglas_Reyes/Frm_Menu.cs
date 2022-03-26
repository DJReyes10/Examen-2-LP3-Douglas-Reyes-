using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2_LP3_Douglas_Reyes
{
    public partial class Frm_Menu : Syncfusion.Windows.Forms.Office2010Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        Frm_Prod frm_Prod = null;
        Frm_Pedidos frm_Pedidos = null; 

        private void Producto_toolStripButton_Click(object sender, EventArgs e)
        {
            if (frm_Prod == null)
            {
                frm_Prod = new Frm_Prod();
                frm_Prod.MdiParent = this;
                frm_Prod.Show();
            }
            else
            {
                frm_Prod.Activate();
            }

        }

        private void PedidotoolStripButton_Click(object sender, EventArgs e)
        {
            if (frm_Pedidos == null)
            {
                frm_Pedidos = new Frm_Pedidos();
                frm_Pedidos.MdiParent = this;
                frm_Pedidos.FormClosed += Frm_Pedidos_FormClosed;
                frm_Pedidos.Show();
            }
            else
            {
                frm_Pedidos.Activate();
            }
        }

        private void Frm_Pedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Pedidos = null;

        }
    }
}
