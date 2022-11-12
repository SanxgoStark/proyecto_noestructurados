using RDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_noestructurados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //doble carta
            
            REngine engine = REngine.GetInstance();
            var x = engine.Evaluate("x <- c(21, 62, 10)").AsNumeric();
            engine.Evaluate("barplot(x,main='Grafica doble carta',xlab = 'Mes',ylab = 'Cantidad',col=c('darkblue','red','green'),horiz=FALSE,names.arg = c('Agosto', 'Septiembre', 'Octubre'))");

        }
    }
    
}
