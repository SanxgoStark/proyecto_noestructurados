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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"C:\\Users\\uriel\\source\\proyecto_noestructurados\\imagenes\\Informacion-4.png");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
