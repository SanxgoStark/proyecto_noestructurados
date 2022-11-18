using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace proyecto_noestructurados.Clases
{
    public class Registros
    {
        public ObjectId Id { get; set; }
        public int doble_carta { get; set; }
        public int carta { get; set; }
        public int oficio { get; set; }
        public int total_blanco_negro { get; set; }
        public int total_todo_color { get; set; }
        public double residuos_xpagina { get; set; }
    }
}
