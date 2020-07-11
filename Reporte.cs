using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TP1_Reportes
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Paises_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFarmacia.OrdenPedido' Puede moverla o quitarla según sea necesario.
            this.OrdenPedidoTableAdapter.Fill(this.DataSetFarmacia.OrdenPedido);
            // TODO: esta línea de código carga datos en la tabla 'DataSetFarmacia.OrdenPedido' Puede moverla o quitarla según sea necesario.
            this.OrdenPedidoTableAdapter.Fill(this.DataSetFarmacia.OrdenPedido);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            string strconn = "Data Source=.;Initial Catalog=Paises;Integrated Security=True";
            MySqlConnection conn = new MySqlConnection(strconn);
            try
            {
                conn.Open();
                string sql="select PaisCodigo, PaisNombre, PaisContinente, PaisIndependencia, PaisPoblacion, PaisExpectativaDeVida from Pais";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<Pais> listaPaises = new List<Pais>();
                while (rdr.Read())
                {
                    Pais pais = new Pais();
                    pais.Codigo = rdr[0].ToString();
                    pais.Nombre = rdr[1].ToString();
                    pais.Continente = rdr[2].ToString();
                    pais.Independencia = rdr[3].ToString();
                    pais.Poblacion = Convert.ToInt32(rdr[4]);
                    pais.ExpectativaVida = Convert.ToDouble(rdr[5]);
                    listaPaises.Add(pais);
                    pais = null;
                }
                rdr.Close();
                ReportDataSource rds = new ReportDataSource("ReportePaises", listaPaises);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP1_Reportes.ReportePaises.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
            
        }
    }
}
