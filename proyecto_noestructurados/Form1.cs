using RDotNet; // libreria para el maneho de r en el proyecto
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
        // constructor del Form1
        public Form1()
        {
            InitializeComponent();
            Connection = new Clases.Conexion(); // creando un nevo objeto conexion
            Connection.genaraciongrap(); // se hace llamado a la funcion para crear las graficas generales del proyecto (generacion de graficas en directorio local)
            pictureBox2.Image = Image.FromFile(@"C:\\Users\\gunss\\source\\repos\\proyecto_noestructurados\\imagenes\\myplott.png"); // se indica la ruta para que en el pictureboxn obtenga la imagen generada anteriormente
            pictureBox1.Image = Image.FromFile(@"C:\\Users\\gunss\\source\\repos\\proyecto_noestructurados\\imagenes\\myplotp.png"); // se indica la ruta para que en el pictureboxn obtenga la imagen generada anteriormente

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

        // funcion que se ejecuta al presionar el boton filtro (docle carta)
        private void btn_doble_Click(object sender, EventArgs e)
        {
            var titulo = "Consumo de hojas tamaño Doble Carta por mes"; // variable que contiene el titulo para la grafica que se desea obtener

            var valor_a = Connection.graf_doble_carta("agosto"); // variable que obtiene el conteo de paginas doble carta que se obtubiero en el mes de agosto
            var valor_b = Connection.graf_doble_carta("septiembre"); // variable que obtiene el conteo de paginas doble carta que se obtubiero en el mes de septiembre
            var valor_c = Connection.graf_doble_carta("octubre"); // variable que obtiene el conteo de paginas doble carta que se obtubiero en el mes de octubre

            REngine engine = REngine.GetInstance(); // se inicializa una instacia para el uso de r en el proyecto
            var x = engine.Evaluate("x <- c(" + valor_a + "," + valor_b + "," + valor_c + ")").AsNumeric(); // variable que contiene las variables con las cantidades de paginas doble carta para cada mes
            engine.Evaluate("barplot(x, main='" + titulo + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))"); // creacion de la grafica de barras con r
        }

        // funcion que se ejecuta al presionar el boton filtro (carta)
        private void btn_carta_Click(object sender, EventArgs e)
        {
            var titulo = "Consumo de hojas tamaño Carta por mes"; // variable que contiene el titulo para la grafica que se desea obtener

            var valor_a = Connection.graf_carta("agosto"); // variable que obtiene el conteo de paginas carta que se obtubiero en el mes de agosto
            var valor_b = Connection.graf_carta("septiembre"); // variable que obtiene el conteo de paginas carta que se obtubiero en el mes de septiembre
            var valor_c = Connection.graf_carta("octubre"); // variable que obtiene el conteo de paginas carta que se obtubiero en el mes de octubre

            REngine engine = REngine.GetInstance(); // se inicializa una instacia para el uso de r en el proyecto
            var x = engine.Evaluate("x <- c(" + valor_a + "," + valor_b + "," + valor_c + ")").AsNumeric(); // variable que contiene las variables con las cantidades de paginas doble carta para cada mes
            engine.Evaluate("barplot(x, main='" + titulo + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))"); // creacion de la grafica de barras con r
        }

        // funcion que se ejecuta al presionar el boton filtro (oficio)
        private void btn_oficio_Click(object sender, EventArgs e)
        {
            var titulo = "Consumo de hojas tamaño Oficio por mes"; // variable que contiene el titulo para la grafica que se desea obtener

            var valor_a = Connection.graf_oficio("agosto"); // variable que obtiene el conteo de paginas oficio que se obtubiero en el mes de agosto
            var valor_b = Connection.graf_oficio("septiembre"); // variable que obtiene el conteo de paginas oficio que se obtubiero en el mes de septiembre
            var valor_c = Connection.graf_oficio("octubre"); // variable que obtiene el conteo de paginas oficio que se obtubiero en el mes de octubre

            REngine engine = REngine.GetInstance(); // se inicializa una instacia para el uso de r en el proyecto
            var x = engine.Evaluate("x <- c(" + valor_a + "," + valor_b + "," + valor_c + ")").AsNumeric(); // variable que contiene las variables con las cantidades de paginas doble carta para cada mes
            engine.Evaluate("barplot(x, main='" + titulo + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))"); // creacion de la grafica de barras con r
        }

        // funcion que se ejecuta al presionar el boton filtro (blanco/negro)
        private void btn_BlancoNegro_Click(object sender, EventArgs e)
        {
            var titulo = "Consumo de toner negro por mes"; // variable que contiene el titulo para la grafica que se desea obtener

            var valor_a = Connection.graf_BlancoNegro("agosto"); // variable que obtiene el conteo de paginas blanco/negro que se obtubiero en el mes de agosto
            var valor_b = Connection.graf_BlancoNegro("septiembre"); // variable que obtiene el conteo de paginas blanco/negro que se obtubiero en el mes de septiembre
            var valor_c = Connection.graf_BlancoNegro("octubre"); // variable que obtiene el conteo de paginas blanco/negro que se obtubiero en el mes de octubre

            REngine engine = REngine.GetInstance(); // se inicializa una instacia para el uso de r en el proyecto
            var x = engine.Evaluate("x <- c(" + valor_a + "," + valor_b + "," + valor_c + ")").AsNumeric(); // variable que contiene las variables con las cantidades de paginas doble carta para cada mes
            engine.Evaluate("barplot(x, main='" + titulo + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))"); // creacion de la grafica de barras con r
        }

        // funcion que se ejecuta al presionar el boton filtro (color)
        private void btn_color_Click(object sender, EventArgs e)
        {
            var titulo = "Consumo de toner de color por mes"; // variable que contiene el titulo para la grafica que se desea obtener

            var valor_a = Connection.graf_TodoColor("agosto"); // variable que obtiene el conteo de paginas color que se obtubiero en el mes de agosto
            var valor_b = Connection.graf_TodoColor("septiembre"); // variable que obtiene el conteo de paginas color que se obtubiero en el mes de septiembre
            var valor_c = Connection.graf_TodoColor("octubre"); // variable que obtiene el conteo de paginas color que se obtubiero en el mes de octubre

            REngine engine = REngine.GetInstance(); // se inicializa una instacia para el uso de r en el proyecto
            var x = engine.Evaluate("x <- c(" + valor_a + "," + valor_b + "," + valor_c + ")").AsNumeric(); // variable que contiene las variables con las cantidades de paginas doble carta para cada mes
            engine.Evaluate("barplot(x, main='" + titulo + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))"); // creacion de la grafica de barras con r
        }

        // funcion que se ejecuta al presionar el boton filtro (informacion)
        private void btn_ventana_Click(object sender, EventArgs e)
        {
            Form2 ventanaInformativa = new Form2(); // creacion de nueva ventana (Form2)
            ventanaInformativa.Show(); // muestra de ventana (Form2)

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
