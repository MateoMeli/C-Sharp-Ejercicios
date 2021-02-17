using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conversor;

namespace ConversorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBinADeci_Click(object sender, EventArgs e)
        {
            NumeroBinario bin;
            NumeroDecimal deci;

            bin = new NumeroBinario(this.textBinADeci.Text);
            deci = new NumeroDecimal(Transformador.BinarioDecimal(bin.numero));
            if (bin.numero.Contains("2") || bin.numero.Contains("3") || bin.numero.Contains("4") || bin.numero.Contains("5")
                || bin.numero.Contains("6") || bin.numero.Contains("7") || bin.numero.Contains("8") || bin.numero.Contains("9"))
            {
                DialogResult s = new DialogResult();
                s = MessageBox.Show("Invalido", "Error");

            }else
            {
                this.textBoxResultadoBinADeci.Text = ((int)bin).ToString();
            }
        }

        private void buttonDeciABin_Click(object sender, EventArgs e)
        {
            NumeroBinario bin;
            NumeroDecimal deci;

            int es; 
            if(int.TryParse(this.textBoxDeciABin.Text, out es))
            {
                deci = new NumeroDecimal(es);
                this.textBoxResultadoDeciABin.Text = (string)deci;
            }
            else
            {
                DialogResult s = new DialogResult();
                s = MessageBox.Show("Invalido", "Error");
            }

        }
    }
}
