
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
            this.txt_cantPaq = new System.Windows.Forms.TextBox();
            this.txt_tamPaq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tamBuff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maxSim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de paquetes por minuto";
            // 
            // txt_cantPaq
            // 
            this.txt_cantPaq.Location = new System.Drawing.Point(242, 126);
            this.txt_cantPaq.Name = "txt_cantPaq";
            this.txt_cantPaq.Size = new System.Drawing.Size(100, 20);
            this.txt_cantPaq.TabIndex = 3;
            // 
            // txt_tamPaq
            // 
            this.txt_tamPaq.Location = new System.Drawing.Point(242, 190);
            this.txt_tamPaq.Name = "txt_tamPaq";
            this.txt_tamPaq.Size = new System.Drawing.Size(100, 20);
            this.txt_tamPaq.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tamaño de paquete KB";
            // 
            // txt_tamBuff
            // 
            this.txt_tamBuff.Location = new System.Drawing.Point(242, 154);
            this.txt_tamBuff.Name = "txt_tamBuff";
            this.txt_tamBuff.Size = new System.Drawing.Size(100, 20);
            this.txt_tamBuff.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tamaño de buffer (mb)";
            // 
            // txt_maxSim
            // 
            this.txt_maxSim.Location = new System.Drawing.Point(242, 100);
            this.txt_maxSim.Name = "txt_maxSim";
            this.txt_maxSim.Size = new System.Drawing.Size(100, 20);
            this.txt_maxSim.TabIndex = 9;
            this.txt_maxSim.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "cantidad de simulacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 297);
            this.Controls.Add(this.txt_maxSim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tamBuff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tamPaq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cantPaq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cantPaq;
        private System.Windows.Forms.TextBox txt_tamPaq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tamBuff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maxSim;
        private System.Windows.Forms.Label label5;
    }
}

