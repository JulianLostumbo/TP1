namespace TP1_Reportes
{
    partial class Reporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OrdenPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFarmacia = new TP1_Reportes.DataSetFarmacia();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrdenPedidoTableAdapter = new TP1_Reportes.DataSetFarmaciaTableAdapters.OrdenPedidoTableAdapter();
            this.PaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFarmacia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdenPedidoBindingSource
            // 
            this.OrdenPedidoBindingSource.DataMember = "OrdenPedido";
            this.OrdenPedidoBindingSource.DataSource = this.DataSetFarmacia;
            // 
            // DataSetFarmacia
            // 
            this.DataSetFarmacia.DataSetName = "DataSetFarmacia";
            this.DataSetFarmacia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrdenPedidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP1_Reportes.ReporteFarmacia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // OrdenPedidoTableAdapter
            // 
            this.OrdenPedidoTableAdapter.ClearBeforeFill = true;
            // 
            // PaisBindingSource
            // 
            this.PaisBindingSource.DataSource = typeof(TP1_Reportes.Pais);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Paises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFarmacia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrdenPedidoBindingSource;
        private DataSetFarmacia DataSetFarmacia;
        private DataSetFarmaciaTableAdapters.OrdenPedidoTableAdapter OrdenPedidoTableAdapter;
        private System.Windows.Forms.BindingSource PaisBindingSource;
    }
}