
namespace FinalSIM
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tamPaq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tamBuff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.msk_filasMax = new System.Windows.Forms.MaskedTextBox();
            this.msk_PaqueXMin = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 245);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Simular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configuracion de Parametros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de paquetes por minuto";
            // 
            // txt_tamPaq
            // 
            this.txt_tamPaq.Location = new System.Drawing.Point(300, 175);
            this.txt_tamPaq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tamPaq.Name = "txt_tamPaq";
            this.txt_tamPaq.Size = new System.Drawing.Size(66, 24);
            this.txt_tamPaq.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tamaño de paquete (KB)";
            // 
            // txt_tamBuff
            // 
            this.txt_tamBuff.Location = new System.Drawing.Point(300, 137);
            this.txt_tamBuff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tamBuff.Name = "txt_tamBuff";
            this.txt_tamBuff.Size = new System.Drawing.Size(66, 24);
            this.txt_tamBuff.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tamaño de buffer (MB)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Filas a simular";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(41, 245);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(50, 32);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_info
            // 
            this.btn_info.Location = new System.Drawing.Point(115, 246);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(37, 31);
            this.btn_info.TabIndex = 11;
            this.btn_info.Text = "info";
            this.btn_info.UseVisualStyleBackColor = true;
            // 
            // msk_filasMax
            // 
            this.msk_filasMax.Location = new System.Drawing.Point(301, 62);
            this.msk_filasMax.Mask = "999999";
            this.msk_filasMax.Name = "msk_filasMax";
            this.msk_filasMax.Size = new System.Drawing.Size(65, 24);
            this.msk_filasMax.TabIndex = 12;
            this.msk_filasMax.ValidatingType = typeof(int);
            // 
            // msk_PaqueXMin
            // 
            this.msk_PaqueXMin.Location = new System.Drawing.Point(300, 98);
            this.msk_PaqueXMin.Mask = "9999";
            this.msk_PaqueXMin.Name = "msk_PaqueXMin";
            this.msk_PaqueXMin.Size = new System.Drawing.Size(47, 24);
            this.msk_PaqueXMin.TabIndex = 13;
            this.msk_PaqueXMin.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(417, 296);
            this.Controls.Add(this.msk_PaqueXMin);
            this.Controls.Add(this.msk_filasMax);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tamBuff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tamPaq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tamPaq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tamBuff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.MaskedTextBox msk_filasMax;
        private System.Windows.Forms.MaskedTextBox msk_PaqueXMin;
    }
}

