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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrdenPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFarmacia = new TP1_Reportes.DataSetFarmacia();
            this.PaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPaises = new TP1_Reportes.DataSetPaises();
            this.OrdenPedidoTableAdapter = new TP1_Reportes.DataSetFarmaciaTableAdapters.OrdenPedidoTableAdapter();
            this.PaisTableAdapter = new TP1_Reportes.DataSetPaisesTableAdapters.PaisTableAdapter();
            this.tp2_netDataSet = new TP1_Reportes.tp2_netDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new TP1_Reportes.tp2_netDataSetTableAdapters.usuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFarmacia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // PaisBindingSource
            // 
            this.PaisBindingSource.DataMember = "Pais";
            this.PaisBindingSource.DataSource = this.DataSetPaises;
            // 
            // DataSetPaises
            // 
            this.DataSetPaises.DataSetName = "DataSetPaises";
            this.DataSetPaises.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrdenPedidoTableAdapter
            // 
            this.OrdenPedidoTableAdapter.ClearBeforeFill = true;
            // 
            // PaisTableAdapter
            // 
            this.PaisTableAdapter.ClearBeforeFill = true;
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.ReporteFarmacia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFarmacia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrdenPedidoBindingSource;
        private DataSetFarmacia DataSetFarmacia;
        private DataSetFarmaciaTableAdapters.OrdenPedidoTableAdapter OrdenPedidoTableAdapter;
        private System.Windows.Forms.BindingSource PaisBindingSource;
        private DataSetPaises DataSetPaises;
        private DataSetPaisesTableAdapters.PaisTableAdapter PaisTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private tp2_netDataSet tp2_netDataSet;
        private tp2_netDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
    }
}