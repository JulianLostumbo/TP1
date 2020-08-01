using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Reportes
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void ReporteFarmacia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.tp2_netDataSet.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'DataSetFarmacia.OrdenPedido' Puede moverla o quitarla según sea necesario.
            this.OrdenPedidoTableAdapter.Fill(this.DataSetFarmacia.OrdenPedido);
            // TODO: esta línea de código carga datos en la tabla 'DataSetPaises.Pais' Puede moverla o quitarla según sea necesario.
            this.PaisTableAdapter.Fill(this.DataSetPaises.Pais);
            // TODO: esta línea de código carga datos en la tabla 'DataSetFarmacia.OrdenPedido' Puede moverla o quitarla según sea necesario.
            this.OrdenPedidoTableAdapter.Fill(this.DataSetFarmacia.OrdenPedido);

            this.reportViewer1.RefreshReport();
        }
    }
}
