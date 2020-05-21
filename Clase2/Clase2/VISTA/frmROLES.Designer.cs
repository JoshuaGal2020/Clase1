namespace Clase2.VISTA
{
    partial class frmROLES
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmROLES));
            this.dtVistaRoles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtVistaRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dtVistaRoles
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtVistaRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtVistaRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtVistaRoles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtVistaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVistaRoles.GridColor = System.Drawing.SystemColors.WindowText;
            this.dtVistaRoles.Location = new System.Drawing.Point(32, 90);
            this.dtVistaRoles.Name = "dtVistaRoles";
            this.dtVistaRoles.Size = new System.Drawing.Size(519, 235);
            this.dtVistaRoles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(237, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "ROLES";
            // 
            // frmROLES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtVistaRoles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmROLES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ROLES";
            this.Load += new System.EventHandler(this.frmROLES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVistaRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtVistaRoles;
        private System.Windows.Forms.Label label1;
    }
}