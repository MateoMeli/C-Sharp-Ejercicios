namespace CuentaGanadoForm
{
    partial class Datos
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(56, 36);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(56, 77);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(51, 20);
            this.labelEdad.TabIndex = 1;
            this.labelEdad.Text = "Edad:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.Location = new System.Drawing.Point(56, 120);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(37, 20);
            this.labelDni.TabIndex = 2;
            this.labelDni.Text = "Dni:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(254, 36);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(141, 20);
            this.textNombre.TabIndex = 3;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(254, 77);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(141, 20);
            this.textEdad.TabIndex = 4;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(254, 120);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(141, 20);
            this.textDni.TabIndex = 5;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(254, 185);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(141, 61);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 258);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelNombre);
            this.Name = "Datos";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.datos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Button buttonAceptar;
    }
}