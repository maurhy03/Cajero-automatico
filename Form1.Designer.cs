namespace WindowsFormsApplication1
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
            this.BtnRetirar = new System.Windows.Forms.Button();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblRespuesta = new System.Windows.Forms.Label();
            this.BtnFibonucci = new System.Windows.Forms.Button();
            this.BtnPrimo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LisBox1 = new System.Windows.Forms.ListBox();
            this.BtnErase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRetirar
            // 
            this.BtnRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetirar.Location = new System.Drawing.Point(166, 67);
            this.BtnRetirar.Name = "BtnRetirar";
            this.BtnRetirar.Size = new System.Drawing.Size(104, 44);
            this.BtnRetirar.TabIndex = 0;
            this.BtnRetirar.Text = "Retirar";
            this.BtnRetirar.UseVisualStyleBackColor = false;
            this.BtnRetirar.Click += new System.EventHandler(this.BtnRetirar_Click);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(12, 28);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(132, 16);
            this.LblCantidad.TabIndex = 1;
            this.LblCantidad.Text = "Cantidad a pagar:";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(155, 27);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(115, 20);
            this.TxtCantidad.TabIndex = 2;
            // 
            // LblRespuesta
            // 
            this.LblRespuesta.AutoSize = true;
            this.LblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuesta.Location = new System.Drawing.Point(299, 28);
            this.LblRespuesta.Name = "LblRespuesta";
            this.LblRespuesta.Size = new System.Drawing.Size(83, 16);
            this.LblRespuesta.TabIndex = 3;
            this.LblRespuesta.Text = "Respuesta";
            // 
            // BtnFibonucci
            // 
            this.BtnFibonucci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnFibonucci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFibonucci.Location = new System.Drawing.Point(166, 137);
            this.BtnFibonucci.Name = "BtnFibonucci";
            this.BtnFibonucci.Size = new System.Drawing.Size(104, 44);
            this.BtnFibonucci.TabIndex = 4;
            this.BtnFibonucci.Text = "Fabonucci";
            this.BtnFibonucci.UseVisualStyleBackColor = false;
            this.BtnFibonucci.Click += new System.EventHandler(this.BtnFibonucci_Click);
            // 
            // BtnPrimo
            // 
            this.BtnPrimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnPrimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrimo.Location = new System.Drawing.Point(166, 200);
            this.BtnPrimo.Name = "BtnPrimo";
            this.BtnPrimo.Size = new System.Drawing.Size(104, 44);
            this.BtnPrimo.TabIndex = 5;
            this.BtnPrimo.Text = "Imprimir";
            this.BtnPrimo.UseVisualStyleBackColor = false;
            this.BtnPrimo.Click += new System.EventHandler(this.BtnPrimo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Secuencia de:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Su numero es:";
            // 
            // LisBox1
            // 
            this.LisBox1.FormattingEnabled = true;
            this.LisBox1.Location = new System.Drawing.Point(475, 28);
            this.LisBox1.Name = "LisBox1";
            this.LisBox1.Size = new System.Drawing.Size(159, 225);
            this.LisBox1.TabIndex = 8;
            // 
            // BtnErase
            // 
            this.BtnErase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnErase.Location = new System.Drawing.Point(166, 264);
            this.BtnErase.Name = "BtnErase";
            this.BtnErase.Size = new System.Drawing.Size(104, 44);
            this.BtnErase.TabIndex = 9;
            this.BtnErase.Text = "Nuevo";
            this.BtnErase.UseVisualStyleBackColor = false;
            this.BtnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(646, 320);
            this.Controls.Add(this.BtnErase);
            this.Controls.Add(this.LisBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPrimo);
            this.Controls.Add(this.BtnFibonucci);
            this.Controls.Add(this.LblRespuesta);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.BtnRetirar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cajero Automatico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRetirar;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblRespuesta;
        private System.Windows.Forms.Button BtnFibonucci;
        private System.Windows.Forms.Button BtnPrimo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LisBox1;
        private System.Windows.Forms.Button BtnErase;
    }
}

