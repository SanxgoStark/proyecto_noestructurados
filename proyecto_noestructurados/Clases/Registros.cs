using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson; // uso de libreria que permite el manejo de los docuemntos con Mongo DB

namespace proyecto_noestructurados.Clases
{
    // clase que hace referencia a registros en la base de datos registros (documentos)
    public class Registros
    {
        // atributos que se desean manejar de la coleccion registros en Mongo DB
        public ObjectId Id { get; set; }
        public int doble_carta { get; set; }
        public int carta { get; set; }
        public int oficio { get; set; }
        public int total_blanco_negro { get; set; }
        public int total_todo_color { get; set; }
        public double residuos_xpagina { get; set; }
        public int num_paginas_completas { get; set; }
    }
}
