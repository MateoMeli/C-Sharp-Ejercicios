namespace VistaForm
{
    partial class CuentaGanado
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
            this.labelEmpleados = new System.Windows.Forms.Label();
            this.labelGente = new System.Windows.Forms.Label();
            this.nudEmpleados = new System.Windows.Forms.NumericUpDown();
            this.nudGente = new System.Windows.Forms.NumericUpDown();
            this.buttonInformar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGente)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmpleados
            // 
            this.labelEmpleados.AutoSize = true;
            this.labelEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleados.Location = new System.Drawing.Point(94, 53);
            this.labelEmpleados.Name = "labelEmpleados";
            this.labelEmpleados.Size = new System.Drawing.Size(367, 76);
            this.labelEmpleados.TabIndex = 0;
            this.labelEmpleados.Text = "Empleados";
            // 
            // labelGente
            // 
            this.labelGente.AutoSize = true;
            this.labelGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGente.Location = new System.Drawing.Point(94, 205);
            this.labelGente.Name = "labelGente";
            this.labelGente.Size = new System.Drawing.Size(215, 76);
            this.labelGente.TabIndex = 1;
            this.labelGente.Text = "Gente";
            // 
            // nudEmpleados
            // 
            this.nudEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEmpleados.Location = new System.Drawing.Point(566, 53);
            this.nudEmpleados.Name = "nudEmpleados";
            this.nudEmpleados.ReadOnly = true;
            this.nudEmpleados.Size = new System.Drawing.Size(190, 83);
            this.nudEmpleados.TabIndex = 2;
            this.nudEmpleados.ValueChanged += new System.EventHandler(this.NudEpleados_ValueChanged);
            // 
            // nudGente
            // 
            this.nudGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGente.Location = new System.Drawing.Point(566, 198);
            this.nudGente.Name = "nudGente";
            this.nudGente.ReadOnly = true;
            this.nudGente.Size = new System.Drawing.Size(190, 83);
            this.nudGente.TabIndex = 3;
            this.nudGente.ValueChanged += new System.EventHandler(this.NudGente_ValueChanged);
            // 
            // buttonInformar
            // 
            this.buttonInformar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInformar.Location = new System.Drawing.Point(566, 337);
            this.buttonInformar.Name = "buttonInformar";
            this.buttonInformar.Size = new System.Drawing.Size(190, 101);
            this.buttonInformar.TabIndex = 4;
            this.buttonInformar.Text = "Informe";
            this.buttonInformar.UseVisualStyleBackColor = true;
            this.buttonInformar.Click += new System.EventHandler(this.ButtonInformar_Click);
            // 
            // CuentaGanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInformar);
            this.Controls.Add(this.nudGente);
            this.Controls.Add(this.nudEmpleados);
            this.Controls.Add(this.labelGente);
            this.Controls.Add(this.labelEmpleados);
            this.Name = "CuentaGanado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Mateo Meli";
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmpleados;
        private System.Windows.Forms.Label labelGente;
        private System.Windows.Forms.NumericUpDown nudEmpleados;
        private System.Windows.Forms.NumericUpDown nudGente;
        private System.Windows.Forms.Button buttonInformar;
    }
}

