
namespace ConversorForm
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
            this.buttonBinADeci = new System.Windows.Forms.Button();
            this.buttonDeciABin = new System.Windows.Forms.Button();
            this.labelBinADeci = new System.Windows.Forms.Label();
            this.labelDeciABin = new System.Windows.Forms.Label();
            this.textBinADeci = new System.Windows.Forms.TextBox();
            this.textBoxDeciABin = new System.Windows.Forms.TextBox();
            this.textBoxResultadoBinADeci = new System.Windows.Forms.TextBox();
            this.textBoxResultadoDeciABin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBinADeci
            // 
            this.buttonBinADeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBinADeci.Location = new System.Drawing.Point(365, 72);
            this.buttonBinADeci.Name = "buttonBinADeci";
            this.buttonBinADeci.Size = new System.Drawing.Size(117, 32);
            this.buttonBinADeci.TabIndex = 0;
            this.buttonBinADeci.Text = "--->";
            this.buttonBinADeci.UseVisualStyleBackColor = true;
            this.buttonBinADeci.Click += new System.EventHandler(this.buttonBinADeci_Click);
            // 
            // buttonDeciABin
            // 
            this.buttonDeciABin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeciABin.Location = new System.Drawing.Point(365, 124);
            this.buttonDeciABin.Name = "buttonDeciABin";
            this.buttonDeciABin.Size = new System.Drawing.Size(117, 32);
            this.buttonDeciABin.TabIndex = 1;
            this.buttonDeciABin.Text = "--->";
            this.buttonDeciABin.UseVisualStyleBackColor = true;
            this.buttonDeciABin.Click += new System.EventHandler(this.buttonDeciABin_Click);
            // 
            // labelBinADeci
            // 
            this.labelBinADeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBinADeci.Location = new System.Drawing.Point(12, 72);
            this.labelBinADeci.Name = "labelBinADeci";
            this.labelBinADeci.Size = new System.Drawing.Size(152, 32);
            this.labelBinADeci.TabIndex = 2;
            this.labelBinADeci.Text = "Binario a Decimal";
            // 
            // labelDeciABin
            // 
            this.labelDeciABin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeciABin.Location = new System.Drawing.Point(12, 133);
            this.labelDeciABin.Name = "labelDeciABin";
            this.labelDeciABin.Size = new System.Drawing.Size(152, 32);
            this.labelDeciABin.TabIndex = 3;
            this.labelDeciABin.Text = "Decimal a Binario";
            // 
            // textBinADeci
            // 
            this.textBinADeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBinADeci.Location = new System.Drawing.Point(188, 72);
            this.textBinADeci.Name = "textBinADeci";
            this.textBinADeci.Size = new System.Drawing.Size(125, 30);
            this.textBinADeci.TabIndex = 4;
            // 
            // textBoxDeciABin
            // 
            this.textBoxDeciABin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeciABin.Location = new System.Drawing.Point(188, 126);
            this.textBoxDeciABin.Name = "textBoxDeciABin";
            this.textBoxDeciABin.Size = new System.Drawing.Size(125, 30);
            this.textBoxDeciABin.TabIndex = 5;
            // 
            // textBoxResultadoBinADeci
            // 
            this.textBoxResultadoBinADeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultadoBinADeci.Location = new System.Drawing.Point(551, 74);
            this.textBoxResultadoBinADeci.Name = "textBoxResultadoBinADeci";
            this.textBoxResultadoBinADeci.ReadOnly = true;
            this.textBoxResultadoBinADeci.Size = new System.Drawing.Size(131, 30);
            this.textBoxResultadoBinADeci.TabIndex = 6;
            // 
            // textBoxResultadoDeciABin
            // 
            this.textBoxResultadoDeciABin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResultadoDeciABin.Location = new System.Drawing.Point(551, 124);
            this.textBoxResultadoDeciABin.Name = "textBoxResultadoDeciABin";
            this.textBoxResultadoDeciABin.ReadOnly = true;
            this.textBoxResultadoDeciABin.Size = new System.Drawing.Size(131, 30);
            this.textBoxResultadoDeciABin.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 207);
            this.Controls.Add(this.textBoxResultadoDeciABin);
            this.Controls.Add(this.textBoxResultadoBinADeci);
            this.Controls.Add(this.textBoxDeciABin);
            this.Controls.Add(this.textBinADeci);
            this.Controls.Add(this.labelDeciABin);
            this.Controls.Add(this.labelBinADeci);
            this.Controls.Add(this.buttonDeciABin);
            this.Controls.Add(this.buttonBinADeci);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBinADeci;
        private System.Windows.Forms.Button buttonDeciABin;
        private System.Windows.Forms.Label labelBinADeci;
        private System.Windows.Forms.Label labelDeciABin;
        private System.Windows.Forms.TextBox textBinADeci;
        private System.Windows.Forms.TextBox textBoxDeciABin;
        private System.Windows.Forms.TextBox textBoxResultadoBinADeci;
        private System.Windows.Forms.TextBox textBoxResultadoDeciABin;
    }
}

