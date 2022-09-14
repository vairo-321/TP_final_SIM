
namespace FinalSIM.Formularios
{
    partial class Frm_tabla
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoPaquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximoPaquete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finRed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoBuff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaBuff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dominio1cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dominio2con = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paquetesDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evento,
            this.Reloj,
            this.RNDp,
            this.tiempoPaquete,
            this.proximoPaquete,
            this.RNDr,
            this.dominio,
            this.tiempoD,
            this.finRed,
            this.EstadoBuff,
            this.ColaBuff,
            this.dominio1cont,
            this.dominio2con,
            this.paquetesDesc});
            this.dataGridView1.Location = new System.Drawing.Point(23, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1335, 459);
            this.dataGridView1.TabIndex = 0;
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            // 
            // Reloj
            // 
            this.Reloj.HeaderText = "Reloj(\'\')";
            this.Reloj.Name = "Reloj";
            this.Reloj.ReadOnly = true;
            // 
            // RNDp
            // 
            this.RNDp.HeaderText = "RNDpaquete";
            this.RNDp.Name = "RNDp";
            this.RNDp.ReadOnly = true;
            // 
            // tiempoPaquete
            // 
            this.tiempoPaquete.HeaderText = "tiempo";
            this.tiempoPaquete.Name = "tiempoPaquete";
            this.tiempoPaquete.ReadOnly = true;
            // 
            // proximoPaquete
            // 
            this.proximoPaquete.HeaderText = "proximoPaquete";
            this.proximoPaquete.Name = "proximoPaquete";
            this.proximoPaquete.ReadOnly = true;
            // 
            // RNDr
            // 
            this.RNDr.HeaderText = "RNDredistribucion";
            this.RNDr.Name = "RNDr";
            this.RNDr.ReadOnly = true;
            // 
            // dominio
            // 
            this.dominio.HeaderText = "dominio";
            this.dominio.Name = "dominio";
            this.dominio.ReadOnly = true;
            // 
            // tiempoD
            // 
            this.tiempoD.HeaderText = "tiempo";
            this.tiempoD.Name = "tiempoD";
            this.tiempoD.ReadOnly = true;
            // 
            // finRed
            // 
            this.finRed.HeaderText = "finRed";
            this.finRed.Name = "finRed";
            this.finRed.ReadOnly = true;
            // 
            // EstadoBuff
            // 
            this.EstadoBuff.HeaderText = "EstadoBuff";
            this.EstadoBuff.Name = "EstadoBuff";
            this.EstadoBuff.ReadOnly = true;
            // 
            // ColaBuff
            // 
            this.ColaBuff.HeaderText = "ColaBuff";
            this.ColaBuff.Name = "ColaBuff";
            this.ColaBuff.ReadOnly = true;
            // 
            // dominio1cont
            // 
            this.dominio1cont.HeaderText = "dominio1cont";
            this.dominio1cont.Name = "dominio1cont";
            this.dominio1cont.ReadOnly = true;
            // 
            // dominio2con
            // 
            this.dominio2con.HeaderText = "dominio2Cont";
            this.dominio2con.Name = "dominio2con";
            this.dominio2con.ReadOnly = true;
            // 
            // paquetesDesc
            // 
            this.paquetesDesc.HeaderText = "paquetesDes";
            this.paquetesDesc.Name = "paquetesDesc";
            this.paquetesDesc.ReadOnly = true;
            // 
            // Frm_tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 500);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_tabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla";
            this.Load += new System.EventHandler(this.Frm_tabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximoPaquete;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn finRed;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoBuff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaBuff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dominio1cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn dominio2con;
        private System.Windows.Forms.DataGridViewTextBoxColumn paquetesDesc;
    }
}