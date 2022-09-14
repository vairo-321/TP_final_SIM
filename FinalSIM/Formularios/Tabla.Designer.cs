
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_info = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.paquetesDesc,
            this.Indice});
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(945, 496);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(112, 36);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tabla ilustrativa de la simulacion ";
            // 
            // btn_info
            // 
            this.btn_info.BackgroundImage = global::FinalSIM.Properties.Resources.infoIcon;
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info.Location = new System.Drawing.Point(888, 487);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(51, 47);
            this.btn_info.TabIndex = 1;
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImage = global::FinalSIM.Properties.Resources.UTN_FRC_logo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 55);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            this.Evento.Width = 200;
            // 
            // Reloj
            // 
            this.Reloj.HeaderText = "Reloj(\'\')";
            this.Reloj.Name = "Reloj";
            this.Reloj.ReadOnly = true;
            this.Reloj.Width = 50;
            // 
            // RNDp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RNDp.DefaultCellStyle = dataGridViewCellStyle1;
            this.RNDp.FillWeight = 25F;
            this.RNDp.HeaderText = "RNDp";
            this.RNDp.Name = "RNDp";
            this.RNDp.ReadOnly = true;
            this.RNDp.Width = 45;
            // 
            // tiempoPaquete
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tiempoPaquete.DefaultCellStyle = dataGridViewCellStyle2;
            this.tiempoPaquete.HeaderText = "TiempoP";
            this.tiempoPaquete.Name = "tiempoPaquete";
            this.tiempoPaquete.ReadOnly = true;
            this.tiempoPaquete.Width = 60;
            // 
            // proximoPaquete
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.proximoPaquete.DefaultCellStyle = dataGridViewCellStyle3;
            this.proximoPaquete.HeaderText = "ProximoP";
            this.proximoPaquete.Name = "proximoPaquete";
            this.proximoPaquete.ReadOnly = true;
            this.proximoPaquete.Width = 60;
            // 
            // RNDr
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RNDr.DefaultCellStyle = dataGridViewCellStyle4;
            this.RNDr.HeaderText = "RNDr";
            this.RNDr.Name = "RNDr";
            this.RNDr.ReadOnly = true;
            this.RNDr.Width = 45;
            // 
            // dominio
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dominio.DefaultCellStyle = dataGridViewCellStyle5;
            this.dominio.HeaderText = "Destino";
            this.dominio.Name = "dominio";
            this.dominio.ReadOnly = true;
            this.dominio.Width = 60;
            // 
            // tiempoD
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tiempoD.DefaultCellStyle = dataGridViewCellStyle6;
            this.tiempoD.HeaderText = "TiempoR";
            this.tiempoD.Name = "tiempoD";
            this.tiempoD.ReadOnly = true;
            this.tiempoD.Width = 60;
            // 
            // finRed
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.finRed.DefaultCellStyle = dataGridViewCellStyle7;
            this.finRed.HeaderText = "ProximaR";
            this.finRed.Name = "finRed";
            this.finRed.ReadOnly = true;
            this.finRed.Width = 60;
            // 
            // EstadoBuff
            // 
            this.EstadoBuff.HeaderText = "EstadoBuffer";
            this.EstadoBuff.Name = "EstadoBuff";
            this.EstadoBuff.ReadOnly = true;
            this.EstadoBuff.Width = 75;
            // 
            // ColaBuff
            // 
            this.ColaBuff.HeaderText = "ColaBuffer";
            this.ColaBuff.Name = "ColaBuff";
            this.ColaBuff.ReadOnly = true;
            this.ColaBuff.Width = 60;
            // 
            // dominio1cont
            // 
            this.dominio1cont.HeaderText = "Dominio1";
            this.dominio1cont.Name = "dominio1cont";
            this.dominio1cont.ReadOnly = true;
            this.dominio1cont.Width = 60;
            // 
            // dominio2con
            // 
            this.dominio2con.HeaderText = "Dominio2";
            this.dominio2con.Name = "dominio2con";
            this.dominio2con.ReadOnly = true;
            this.dominio2con.Width = 60;
            // 
            // paquetesDesc
            // 
            this.paquetesDesc.HeaderText = "PaqDesc";
            this.paquetesDesc.Name = "paquetesDesc";
            this.paquetesDesc.ReadOnly = true;
            this.paquetesDesc.Width = 65;
            // 
            // Indice
            // 
            this.Indice.HeaderText = "Indice";
            this.Indice.Name = "Indice";
            this.Indice.ReadOnly = true;
            this.Indice.Width = 40;
            // 
            // Frm_tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1074, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_tabla";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla";
            this.Load += new System.EventHandler(this.Frm_tabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
    }
}