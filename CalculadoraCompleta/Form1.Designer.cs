namespace CalculadoraCompleta
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
            this.ResultadosFin = new System.Windows.Forms.TextBox();
            this.botnUno = new System.Windows.Forms.Button();
            this.botnDos = new System.Windows.Forms.Button();
            this.botnTres = new System.Windows.Forms.Button();
            this.botnSeis = new System.Windows.Forms.Button();
            this.botnCinco = new System.Windows.Forms.Button();
            this.botnCuatro = new System.Windows.Forms.Button();
            this.botnNueve = new System.Windows.Forms.Button();
            this.botnOcho = new System.Windows.Forms.Button();
            this.botnSiete = new System.Windows.Forms.Button();
            this.botnCero = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.botnDivision = new System.Windows.Forms.Button();
            this.botnSuma = new System.Windows.Forms.Button();
            this.botnMultiplicacion = new System.Windows.Forms.Button();
            this.botnResta = new System.Windows.Forms.Button();
            this.botnBorrador = new System.Windows.Forms.Button();
            this.botnEliminacion = new System.Windows.Forms.Button();
            this.botnIgual = new System.Windows.Forms.Button();
            this.lablHistorial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultadosFin
            // 
            this.ResultadosFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadosFin.Location = new System.Drawing.Point(191, 85);
            this.ResultadosFin.Name = "ResultadosFin";
            this.ResultadosFin.ReadOnly = true;
            this.ResultadosFin.Size = new System.Drawing.Size(279, 31);
            this.ResultadosFin.TabIndex = 0;
            this.ResultadosFin.Text = "0";
            this.ResultadosFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // botnUno
            // 
            this.botnUno.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnUno.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnUno.ForeColor = System.Drawing.Color.Black;
            this.botnUno.Location = new System.Drawing.Point(191, 226);
            this.botnUno.Name = "botnUno";
            this.botnUno.Size = new System.Drawing.Size(48, 29);
            this.botnUno.TabIndex = 1;
            this.botnUno.Text = "1";
            this.botnUno.UseVisualStyleBackColor = false;
            this.botnUno.Click += new System.EventHandler(this.botnUno_Click);
            // 
            // botnDos
            // 
            this.botnDos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnDos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnDos.ForeColor = System.Drawing.Color.Black;
            this.botnDos.Location = new System.Drawing.Point(254, 226);
            this.botnDos.Name = "botnDos";
            this.botnDos.Size = new System.Drawing.Size(48, 29);
            this.botnDos.TabIndex = 2;
            this.botnDos.Text = "2";
            this.botnDos.UseVisualStyleBackColor = false;
            this.botnDos.Click += new System.EventHandler(this.botnDos_Click);
            // 
            // botnTres
            // 
            this.botnTres.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnTres.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnTres.ForeColor = System.Drawing.Color.Black;
            this.botnTres.Location = new System.Drawing.Point(308, 226);
            this.botnTres.Name = "botnTres";
            this.botnTres.Size = new System.Drawing.Size(48, 29);
            this.botnTres.TabIndex = 3;
            this.botnTres.Text = "3";
            this.botnTres.UseVisualStyleBackColor = false;
            this.botnTres.Click += new System.EventHandler(this.botnTres_Click);
            // 
            // botnSeis
            // 
            this.botnSeis.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnSeis.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnSeis.ForeColor = System.Drawing.Color.Black;
            this.botnSeis.Location = new System.Drawing.Point(308, 176);
            this.botnSeis.Name = "botnSeis";
            this.botnSeis.Size = new System.Drawing.Size(48, 29);
            this.botnSeis.TabIndex = 6;
            this.botnSeis.Text = "6";
            this.botnSeis.UseVisualStyleBackColor = false;
            this.botnSeis.Click += new System.EventHandler(this.botnSeis_Click);
            // 
            // botnCinco
            // 
            this.botnCinco.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnCinco.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnCinco.ForeColor = System.Drawing.Color.Black;
            this.botnCinco.Location = new System.Drawing.Point(254, 176);
            this.botnCinco.Name = "botnCinco";
            this.botnCinco.Size = new System.Drawing.Size(48, 29);
            this.botnCinco.TabIndex = 5;
            this.botnCinco.Text = "5";
            this.botnCinco.UseVisualStyleBackColor = false;
            this.botnCinco.Click += new System.EventHandler(this.botnCinco_Click);
            // 
            // botnCuatro
            // 
            this.botnCuatro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnCuatro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnCuatro.ForeColor = System.Drawing.Color.Black;
            this.botnCuatro.Location = new System.Drawing.Point(191, 176);
            this.botnCuatro.Name = "botnCuatro";
            this.botnCuatro.Size = new System.Drawing.Size(48, 29);
            this.botnCuatro.TabIndex = 4;
            this.botnCuatro.Text = "4";
            this.botnCuatro.UseVisualStyleBackColor = false;
            this.botnCuatro.Click += new System.EventHandler(this.botnCuatro_Click);
            // 
            // botnNueve
            // 
            this.botnNueve.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnNueve.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnNueve.ForeColor = System.Drawing.Color.Black;
            this.botnNueve.Location = new System.Drawing.Point(308, 126);
            this.botnNueve.Name = "botnNueve";
            this.botnNueve.Size = new System.Drawing.Size(48, 29);
            this.botnNueve.TabIndex = 9;
            this.botnNueve.Text = "9";
            this.botnNueve.UseVisualStyleBackColor = false;
            this.botnNueve.Click += new System.EventHandler(this.botnNueve_Click);
            // 
            // botnOcho
            // 
            this.botnOcho.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnOcho.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnOcho.ForeColor = System.Drawing.Color.Black;
            this.botnOcho.Location = new System.Drawing.Point(254, 126);
            this.botnOcho.Name = "botnOcho";
            this.botnOcho.Size = new System.Drawing.Size(48, 29);
            this.botnOcho.TabIndex = 8;
            this.botnOcho.Text = "8";
            this.botnOcho.UseVisualStyleBackColor = false;
            this.botnOcho.Click += new System.EventHandler(this.botnOcho_Click);
            // 
            // botnSiete
            // 
            this.botnSiete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnSiete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnSiete.ForeColor = System.Drawing.Color.Black;
            this.botnSiete.Location = new System.Drawing.Point(191, 126);
            this.botnSiete.Name = "botnSiete";
            this.botnSiete.Size = new System.Drawing.Size(48, 29);
            this.botnSiete.TabIndex = 7;
            this.botnSiete.Text = "7";
            this.botnSiete.UseVisualStyleBackColor = false;
            this.botnSiete.Click += new System.EventHandler(this.botnSiete_Click);
            // 
            // botnCero
            // 
            this.botnCero.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnCero.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnCero.ForeColor = System.Drawing.Color.Black;
            this.botnCero.Location = new System.Drawing.Point(191, 273);
            this.botnCero.Name = "botnCero";
            this.botnCero.Size = new System.Drawing.Size(111, 29);
            this.botnCero.TabIndex = 10;
            this.botnCero.Text = "0";
            this.botnCero.UseVisualStyleBackColor = false;
            this.botnCero.Click += new System.EventHandler(this.botnCero_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(308, 273);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(48, 29);
            this.button11.TabIndex = 11;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // botnDivision
            // 
            this.botnDivision.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnDivision.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnDivision.ForeColor = System.Drawing.Color.Black;
            this.botnDivision.Location = new System.Drawing.Point(362, 126);
            this.botnDivision.Name = "botnDivision";
            this.botnDivision.Size = new System.Drawing.Size(48, 29);
            this.botnDivision.TabIndex = 12;
            this.botnDivision.Text = "/";
            this.botnDivision.UseVisualStyleBackColor = false;
            this.botnDivision.Click += new System.EventHandler(this.botnDivision_Click);
            // 
            // botnSuma
            // 
            this.botnSuma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnSuma.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnSuma.ForeColor = System.Drawing.Color.Black;
            this.botnSuma.Location = new System.Drawing.Point(362, 273);
            this.botnSuma.Name = "botnSuma";
            this.botnSuma.Size = new System.Drawing.Size(48, 29);
            this.botnSuma.TabIndex = 15;
            this.botnSuma.Text = "+";
            this.botnSuma.UseVisualStyleBackColor = false;
            this.botnSuma.Click += new System.EventHandler(this.botnSuma_Click);
            // 
            // botnMultiplicacion
            // 
            this.botnMultiplicacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnMultiplicacion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnMultiplicacion.ForeColor = System.Drawing.Color.Black;
            this.botnMultiplicacion.Location = new System.Drawing.Point(362, 176);
            this.botnMultiplicacion.Name = "botnMultiplicacion";
            this.botnMultiplicacion.Size = new System.Drawing.Size(48, 29);
            this.botnMultiplicacion.TabIndex = 14;
            this.botnMultiplicacion.Text = "*";
            this.botnMultiplicacion.UseVisualStyleBackColor = false;
            this.botnMultiplicacion.Click += new System.EventHandler(this.botnMultiplicacion_Click);
            // 
            // botnResta
            // 
            this.botnResta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnResta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnResta.ForeColor = System.Drawing.Color.Black;
            this.botnResta.Location = new System.Drawing.Point(362, 226);
            this.botnResta.Name = "botnResta";
            this.botnResta.Size = new System.Drawing.Size(48, 29);
            this.botnResta.TabIndex = 13;
            this.botnResta.Text = "-";
            this.botnResta.UseVisualStyleBackColor = false;
            this.botnResta.Click += new System.EventHandler(this.botnResta_Click);
            // 
            // botnBorrador
            // 
            this.botnBorrador.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnBorrador.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnBorrador.ForeColor = System.Drawing.Color.Black;
            this.botnBorrador.Location = new System.Drawing.Point(416, 126);
            this.botnBorrador.Name = "botnBorrador";
            this.botnBorrador.Size = new System.Drawing.Size(48, 29);
            this.botnBorrador.TabIndex = 16;
            this.botnBorrador.Text = "CE";
            this.botnBorrador.UseVisualStyleBackColor = false;
            this.botnBorrador.Click += new System.EventHandler(this.botnBorrador_Click);
            // 
            // botnEliminacion
            // 
            this.botnEliminacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnEliminacion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnEliminacion.ForeColor = System.Drawing.Color.Black;
            this.botnEliminacion.Location = new System.Drawing.Point(416, 176);
            this.botnEliminacion.Name = "botnEliminacion";
            this.botnEliminacion.Size = new System.Drawing.Size(48, 29);
            this.botnEliminacion.TabIndex = 17;
            this.botnEliminacion.Text = "C";
            this.botnEliminacion.UseVisualStyleBackColor = false;
            this.botnEliminacion.Click += new System.EventHandler(this.botnEliminacion_Click);
            // 
            // botnIgual
            // 
            this.botnIgual.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botnIgual.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnIgual.ForeColor = System.Drawing.Color.Black;
            this.botnIgual.Location = new System.Drawing.Point(416, 226);
            this.botnIgual.Name = "botnIgual";
            this.botnIgual.Size = new System.Drawing.Size(48, 76);
            this.botnIgual.TabIndex = 18;
            this.botnIgual.Text = "=";
            this.botnIgual.UseVisualStyleBackColor = false;
            this.botnIgual.Click += new System.EventHandler(this.botnIgual_Click);
            // 
            // lablHistorial
            // 
            this.lablHistorial.AutoSize = true;
            this.lablHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablHistorial.Location = new System.Drawing.Point(191, 46);
            this.lablHistorial.Name = "lablHistorial";
            this.lablHistorial.Size = new System.Drawing.Size(0, 20);
            this.lablHistorial.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.lablHistorial);
            this.Controls.Add(this.botnIgual);
            this.Controls.Add(this.botnEliminacion);
            this.Controls.Add(this.botnBorrador);
            this.Controls.Add(this.botnSuma);
            this.Controls.Add(this.botnMultiplicacion);
            this.Controls.Add(this.botnResta);
            this.Controls.Add(this.botnDivision);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.botnCero);
            this.Controls.Add(this.botnNueve);
            this.Controls.Add(this.botnOcho);
            this.Controls.Add(this.botnSiete);
            this.Controls.Add(this.botnSeis);
            this.Controls.Add(this.botnCinco);
            this.Controls.Add(this.botnCuatro);
            this.Controls.Add(this.botnTres);
            this.Controls.Add(this.botnDos);
            this.Controls.Add(this.botnUno);
            this.Controls.Add(this.ResultadosFin);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultadosFin;
        private System.Windows.Forms.Button botnUno;
        private System.Windows.Forms.Button botnDos;
        private System.Windows.Forms.Button botnTres;
        private System.Windows.Forms.Button botnSeis;
        private System.Windows.Forms.Button botnCinco;
        private System.Windows.Forms.Button botnCuatro;
        private System.Windows.Forms.Button botnNueve;
        private System.Windows.Forms.Button botnOcho;
        private System.Windows.Forms.Button botnSiete;
        private System.Windows.Forms.Button botnCero;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button botnDivision;
        private System.Windows.Forms.Button botnSuma;
        private System.Windows.Forms.Button botnMultiplicacion;
        private System.Windows.Forms.Button botnResta;
        private System.Windows.Forms.Button botnBorrador;
        private System.Windows.Forms.Button botnEliminacion;
        private System.Windows.Forms.Button botnIgual;
        private System.Windows.Forms.Label lablHistorial;
    }
}

