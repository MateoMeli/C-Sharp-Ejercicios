
namespace _20210211___Pandemia___alumnos
{
    partial class SimuladorForm
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
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.lblMicroorganismo = new System.Windows.Forms.Label();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.cmbMicroorganismo = new System.Windows.Forms.ComboBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.txtEvolucion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoblacion.Location = new System.Drawing.Point(13, 13);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(151, 23);
            this.lblPoblacion.TabIndex = 0;
            this.lblPoblacion.Text = "Poblacion A Evaluar";
            // 
            // lblMicroorganismo
            // 
            this.lblMicroorganismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicroorganismo.Location = new System.Drawing.Point(13, 48);
            this.lblMicroorganismo.Name = "lblMicroorganismo";
            this.lblMicroorganismo.Size = new System.Drawing.Size(151, 23);
            this.lblMicroorganismo.TabIndex = 1;
            this.lblMicroorganismo.Text = "Microorganismo";
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoblacion.Location = new System.Drawing.Point(195, 16);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(142, 26);
            this.txtPoblacion.TabIndex = 2;
            this.txtPoblacion.Text = "10000000";
            // 
            // cmbMicroorganismo
            // 
            this.cmbMicroorganismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMicroorganismo.FormattingEnabled = true;
            this.cmbMicroorganismo.Items.AddRange(new object[] {
            "Covid19",
            "Gripe"});
            this.cmbMicroorganismo.Location = new System.Drawing.Point(195, 48);
            this.cmbMicroorganismo.Name = "cmbMicroorganismo";
            this.cmbMicroorganismo.Size = new System.Drawing.Size(142, 28);
            this.cmbMicroorganismo.TabIndex = 3;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(561, 102);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(210, 47);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txtEvolucion
            // 
            this.txtEvolucion.Location = new System.Drawing.Point(-3, 174);
            this.txtEvolucion.Name = "txtEvolucion";
            this.txtEvolucion.Size = new System.Drawing.Size(801, 279);
            this.txtEvolucion.TabIndex = 5;
            this.txtEvolucion.Text = "";
            // 
            // SimuladorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEvolucion);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.cmbMicroorganismo);
            this.Controls.Add(this.txtPoblacion);
            this.Controls.Add(this.lblMicroorganismo);
            this.Controls.Add(this.lblPoblacion);
            this.Name = "SimuladorForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimuladorForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.Label lblMicroorganismo;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.ComboBox cmbMicroorganismo;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.RichTextBox txtEvolucion;
    }
}

