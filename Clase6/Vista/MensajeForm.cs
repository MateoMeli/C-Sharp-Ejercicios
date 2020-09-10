using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MensajeForm : Form
    {
        public MensajeForm()
        {
            InitializeComponent();
        }

        public string Mensaje
        {
            get
            {
                return this.labelSaludo.Text;
            }
            set
            {
                this.labelSaludo.Text = value;
            }
        }
    }
}
