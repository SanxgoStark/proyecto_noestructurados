using RDotNet;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_noestructurados
{
    public partial class Form1 : Form
    {
        Clases.Conexion Connection;
        public Form1()
        {
            InitializeComponent();
            Connection = new Clases.Conexion();
            Connection.genaraciongrap();
            pictureBox2.Image = Image.FromFile(@"C:\\Users\\uriel\\source\\proyecto_noestructurados\\imagenes\\myplott.png");
            pictureBox1.Image = Image.FromFile(@"C:\\Users\\uriel\\source\\proyecto_noestructurados\\imagenes\\myplotp.png");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_doble_Click(object sender, EventArgs e)
        {
            var titulo = "Consumo de hojas tamaño Doble Carta por mes";

            var valor_a = Connection.graf_doble_carta("agosto");
            var valor_b = Connection.graf_doble_carta("septiembre");
            var valor_c = Connection.graf_doble_carta("octubre");

            REngine engine = REngine.GetInstance();
            var x = engine.Evaluate("x <- c(" + valor_a + "," + valor_b + "," + valor_c + ")").AsNumeric();
            engine.Evaluate("barplot(x, main='" + titulo + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))");
        }

            private void btn_carta_Click(object sender, EventArgs e)
        {
            var titulo = "Consumo de hojas tamaño Carta por mes";

            var valor_a = Connection.graf_carta("agosto");
            var valor_b = Connection.graf_carta("septiembre");
            var valor_c = Connection.graf_carta("octubre");

            REngine engine = REngine.GetInstance();
            var x = engine.Evaluate("x <- c(" + valor_a + "," + valor_b + "," + valor_c + ")").AsNumeric();
            engine.Evaluate("barplot(x, main='" + titulo + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))");
        }

        private void btn_oficio_Click(object sender, EventArgs e)
        {
            var titulo = "Consumo de hojas tamaño Oficio por mes";

            var valor_a = Connection.graf_oficio("agosto");
            var valor_b = Connection.graf_oficio("septiembre");
            var valor_c = Connection.graf_oficio("octubre");

            REngine engine = REngine.GetInstance();
            var x = engine.Evaluate("x <- c(" + valor_a + "," + valor_b + "," + valor_c + ")").AsNumeric();
            engine.Evaluate("barplot(x, main='" + titulo + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))");
        }

        private void btn_BlancoNegro_Click(object sender, EventArgs e)
        {
            var titulo = "Consumo de toner negro por mes";

            var valor_a = Connection.graf_BlancoNegro("agosto");
            var valor_b = Connection.graf_BlancoNegro("septiembre");
            var valor_c = Connection.graf_BlancoNegro("octubre");

            REngine engine = REngine.GetInstance();
            var x = engine.Evaluate("x <- c(" + valor_a + "," + valor_b + "," + valor_c + ")").AsNumeric();
            engine.Evaluate("barplot(x, main='" + titulo + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))");
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            var titulo = "Consumo de toner de color por mes";

            var valor_a = Connection.graf_TodoColor("agosto");
            var valor_b = Connection.graf_TodoColor("septiembre");
            var valor_c = Connection.graf_TodoColor("octubre");

            REngine engine = REngine.GetInstance();
            var x = engine.Evaluate("x <- c(" + valor_a + "," + valor_b + "," + valor_c + ")").AsNumeric();
            engine.Evaluate("barplot(x, main='" + titulo + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))");
        }

        private void btn_ventana_Click(object sender, EventArgs e)
        {
            Form2 ventanaInformativa = new Form2();
            ventanaInformativa.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
