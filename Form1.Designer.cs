﻿namespace TP1_Reportes
{
    partial class ReporteFarmacia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OrdenPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFarmacia = new TP1_Reportes.DataSetFarmacia();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrdenPedidoTableAdapter = new TP1_Reportes.DataSetFarmaciaTableAdapters.OrdenPedidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFarmacia)).BeginInit();
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
            // ReporteFarmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFarmacia";
            this.Text = "Farmacia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFarmacia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrdenPedidoBindingSource;
        private DataSetFarmacia DataSetFarmacia;
        private DataSetFarmaciaTableAdapters.OrdenPedidoTableAdapter OrdenPedidoTableAdapter;
    }
}

