using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
            t = new Thread(AsignarHora);
            t.Start();
            
        }

        public void AsignarHora()
        {
            this.lblHora.Text = DateTime.Now.ToString();
        }
    }
}
