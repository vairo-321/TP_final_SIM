
namespace FinalSIM.Formularios
{
    partial class Frm_Info
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_fila = new System.Windows.Forms.Label();
            this.lbl_tamBuff = new System.Windows.Forms.Label();
            this.lbl_tamPaq = new System.Windows.Forms.Label();
            this.lbl_cantPaque = new System.Windows.Forms.Label();
            this.lbl_capBuff = new System.Windows.Forms.Label();
            this.lbl_media = new System.Windows.Forms.Label();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_media);
            this.groupBox1.Controls.Add(this.lbl_capBuff);
            this.groupBox1.Controls.Add(this.lbl_fila);
            this.groupBox1.Controls.Add(this.lbl_tamBuff);
            this.groupBox1.Controls.Add(this.lbl_tamPaq);
            this.groupBox1.Controls.Add(this.lbl_cantPaque);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(414, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la simulación ";
            // 
            // lbl_fila
            // 
            this.lbl_fila.AutoSize = true;
            this.lbl_fila.Location = new System.Drawing.Point(23, 57);
            this.lbl_fila.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_fila.Name = "lbl_fila";
            this.lbl_fila.Size = new System.Drawing.Size(125, 18);
            this.lbl_fila.TabIndex = 12;
            this.lbl_fila.Text = "Filas simuladas";
            // 
            // lbl_tamBuff
            // 
            this.lbl_tamBuff.AutoSize = true;
            this.lbl_tamBuff.Location = new System.Drawing.Point(23, 116);
            this.lbl_tamBuff.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_tamBuff.Name = "lbl_tamBuff";
            this.lbl_tamBuff.Size = new System.Drawing.Size(186, 18);
            this.lbl_tamBuff.TabIndex = 11;
            this.lbl_tamBuff.Text = "Tamaño del buffer (MB)";
            // 
            // lbl_tamPaq
            // 
            this.lbl_tamPaq.AutoSize = true;
            this.lbl_tamPaq.Location = new System.Drawing.Point(23, 143);
            this.lbl_tamPaq.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_tamPaq.Name = "lbl_tamPaq";
            this.lbl_tamPaq.Size = new System.Drawing.Size(232, 18);
            this.lbl_tamPaq.TabIndex = 10;
            this.lbl_tamPaq.Text = "Tamaño de los paquetes (KB)";
            // 
            // lbl_cantPaque
            // 
            this.lbl_cantPaque.AutoSize = true;
            this.lbl_cantPaque.Location = new System.Drawing.Point(23, 86);
            this.lbl_cantPaque.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_cantPaque.Name = "lbl_cantPaque";
            this.lbl_cantPaque.Size = new System.Drawing.Size(256, 18);
            this.lbl_cantPaque.TabIndex = 9;
            this.lbl_cantPaque.Text = "Cantidad de paquetes por minuto";
            // 
            // lbl_capBuff
            // 
            this.lbl_capBuff.AutoSize = true;
            this.lbl_capBuff.Location = new System.Drawing.Point(23, 174);
            this.lbl_capBuff.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_capBuff.Name = "lbl_capBuff";
            this.lbl_capBuff.Size = new System.Drawing.Size(319, 18);
            this.lbl_capBuff.TabIndex = 13;
            this.lbl_capBuff.Text = "Capacidad maxima de paquetes en Buffer";
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Location = new System.Drawing.Point(23, 205);
            this.lbl_media.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(53, 18);
            this.lbl_media.TabIndex = 14;
            this.lbl_media.Text = "media";
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.Location = new System.Drawing.Point(466, 25);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(52, 18);
            this.lbl_fin.TabIndex = 1;
            this.lbl_fin.Text = "label1";
            // 
            // Frm_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1071, 276);
            this.Controls.Add(this.lbl_fin);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Info";
            this.Text = "Frm_Info";
            this.Load += new System.EventHandler(this.Frm_Info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_fila;
        private System.Windows.Forms.Label lbl_tamBuff;
        private System.Windows.Forms.Label lbl_tamPaq;
        private System.Windows.Forms.Label lbl_cantPaque;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.Label lbl_capBuff;
        private System.Windows.Forms.Label lbl_fin;
    }
}