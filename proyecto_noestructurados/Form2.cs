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
    // Form2 hace referencia a el form dende se encuentra la informacion 
    public partial class Form2 : Form
    {
        // constructor de el Form2
        public Form2()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"C:\\Users\\gunss\\source\\repos\\proyecto_noestructurados\\imagenes\\Informacion-4.png"); // se indica la ruta para que en el pictureboxn obtenga la imagen generada anteriormente
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
