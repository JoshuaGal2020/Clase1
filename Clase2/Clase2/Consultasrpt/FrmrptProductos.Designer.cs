namespace Clase2.Consultasrpt
{
    partial class FrmrptProductos
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
            this.crproductos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crproductos
            // 
            this.crproductos.ActiveViewIndex = 0;
            this.crproductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crproductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crproductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crproductos.Location = new System.Drawing.Point(0, 0);
            this.crproductos.Name = "crproductos";
            this.crproductos.ReportSource = "C:\\Users\\patty\\Documents\\GitHub\\Clase1\\Clase2\\Clase2\\Reportes\\rptProductos.rpt";
            this.crproductos.Size = new System.Drawing.Size(800, 450);
            this.crproductos.TabIndex = 0;
            this.crproductos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmrptProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crproductos);
            this.Name = "FrmrptProductos";
            this.Text = "FrmrptProductos";
            this.Load += new System.EventHandler(this.FrmrptProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crproductos;
    }
}