using System;
using System.Collections.Generic;
using System.Linq; // libreria que permite trabajar de manera cómoda y rápida con colecciones de datos, como si de una base de datos se tratase
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver; // controlador para el uso de mongodb en el proyecto
using RDotNet; // libreria para el maneho de r en el proyecto
using System.Windows.Forms;
using System.Collections;

namespace proyecto_noestructurados.Clases
{
    public class Conexion
    { 
        static String servidor = "127.0.0.1"; // variable que almacena el servidor
        static String puerto = "27017"; // variable que almacena el puerto para la conexion

        public static MongoClient cliente = new MongoClient("mongodb://" + servidor + ":" + puerto); // conexion con mongo db en el servidor y perto indicado

        // funcion para establecimiento de conexion con mongodb
        private MongoClient establecerConexion()
        {
            try
            {
                List<String> NombresBasesDatos = cliente.ListDatabaseNames().ToList();

                foreach(var db in NombresBasesDatos)
                {
                    //MessageBox.Show("Se pudo conectar correctamente a la base de datos: "+ db.ToString());
                }
            }
            catch(MongoClientException e)
            {
                //MessageBox.Show("No se logró conectar a MongoDB. Error: "+e.ToString());
            }
            return cliente;
        }

        // funcion para crear graficas genrales con r y exportarlas a imagen en directorio local
        public void genaraciongrap()
        {
            REngine engine;
            // consumo de toner
            string fileNamet = "C:\\Users\\uriel\\source\\proyecto_noestructurados\\imagenes\\myplott.png"; // ruta para almacenar grafica genral de consumo de toner
            // consumo de papel
            string fileNamep = "C:\\Users\\uriel\\source\\proyecto_noestructurados\\imagenes\\myplotp.png"; // ruta para almacenar grafica genral de consumo de papel

            //init the R engine (instrucciones para uso de r)        
            REngine.SetEnvironmentVariables();
            engine = REngine.GetInstance();
            engine.Initialize();

            var titulot = "Consumo de toner"; // variable que almacenan el titulo para la grafiaca de consumo de toner
            var titulop = "Consumo de papel"; // variable que almacenan el titulo para la grafiaca de consumo de papel

            var valor_ap = this.graf_consumo_papel("agosto"); // variable que almacena la cantidad de papel consumido en el mes de agosto
            var valor_bp = this.graf_consumo_papel("septiembre"); // variable que almacena la cantidad de papel consumido en el mes de septiembre
            var valor_cp = this.graf_consumo_papel("octubre"); // variable que almacena la cantidad de papel consumido en el mes de octubre

            var valor_at = this.graf_consumo_toner("agosto"); // variable que almacena la cantidad de toner prox consumido en el mes de agosto
            var valor_bt = this.graf_consumo_toner("septiembre"); // variable que almacena la cantidad de toner prox consumido en el mes de septiembre
            var valor_ct = this.graf_consumo_toner("octubre"); // variable que almacena la cantidad de toner prox consumido en el mes de octubre

            // creacion de vectores para la creacion de las graficas
            CharacterVector fileNameVectorp = engine.CreateCharacterVector(new[] { fileNamep });
            engine.SetSymbol("fileNamep", fileNameVectorp);

            CharacterVector fileNameVectort = engine.CreateCharacterVector(new[] { fileNamet });
            engine.SetSymbol("fileNamet", fileNameVectort);

            // creacion del plot (grafica) y exportacion
            try
            {
                var p = engine.Evaluate("p <- c(" + valor_ap + "," + valor_bp + "," + valor_cp + ")").AsNumeric(); // variable que alamacena las cantidades por mes del consumo de papel
                engine.Evaluate("png(filename=fileNamep, width=6, height=6, units='in', res=100)"); // creacion de imagen
                engine.Evaluate("barplot(p, main='" + titulop + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))"); // creacion de grafica
                engine.Evaluate("dev.off()");

                var t = engine.Evaluate("t <- c(" + valor_at + "," + valor_bt + "," + valor_ct + ")").AsNumeric(); // variable que alamacena las cantidades por mes del consumo de toner
                engine.Evaluate("png(filename=fileNamet, width=6, height=6, units='in', res=100)"); // creacion de imagen
                engine.Evaluate("barplot(t, main='" + titulot + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))"); // creacion de grafica
                engine.Evaluate("dev.off()");

            }
            catch
            {
            }

            

            //output
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit");
            //Console.ReadKey();
        }

        // funcion para calcular la cantidad de toner consumido por mes
        public double graf_consumo_toner(string mes)
        {
            var client = new MongoClient(); // inicializamos el cliente de mongodb
            var bd = client.GetDatabase("Proyecto"); // se le indica la base que se quiere manejar
            var collection = bd.GetCollection<Registros>(mes); // se indica la coleccion que se va a manejar

            // se cuenta la cantidad de veces que aparece un numero en los documentos y este numero se multiplica por su numero
            var consumo_residuosxpag = collection
                .Aggregate()
                .Group(b => b.residuos_xpagina,
                ac => new {
                    id = ac.Key,
                    total = ac.Sum(b => 1)
                });

            var residuosxpag_Grupo = consumo_residuosxpag.ToList();

            double resultado = 0;
            foreach (var group in residuosxpag_Grupo)
            {
                resultado += group.id * group.total;
            }

            return resultado; // se retorna la cantidad total
        }

        // funcion para calcular la cantidad de papel consumido por mes
        public int graf_consumo_papel(string mes)
        {
            var client = new MongoClient(); // inicializamos el cliente de mongodb
            var bd = client.GetDatabase("Proyecto"); // se le indica la base que se quiere manejar
            var collection = bd.GetCollection<Registros>(mes); // se indica la coleccion que se va a manejar

            // se cuenta la cantidad de veces que aparece un numero en los documentos y este numero se multiplica por su numero
            var consumo_numpag_completas = collection
                .Aggregate()
                .Group(b => b.num_paginas_completas,
                ac => new {
                    id = ac.Key,
                    total = ac.Sum(b => 1)
                });

            var numpag_completas_Grupo = consumo_numpag_completas.ToList();

            int resultado = 0;
            foreach (var group in numpag_completas_Grupo)
            {
                resultado += group.id * group.total;
            }

            return resultado; // se retorna la cantidad total
        }

        // funcion para calcular la cantidad de paginas doble carta por mes
        public int graf_doble_carta(string mes)
        {
            var client = new MongoClient(); // inicializamos el cliente de mongodb
            var bd = client.GetDatabase("Proyecto"); // se le indica la base que se quiere manejar
            var collection = bd.GetCollection<Registros>(mes); // se indica la coleccion que se va a manejar

            // se cuenta la cantidad de veces que aparece un numero en los documentos y este numero se multiplica por su numero
            var consumo_DobleCarta = collection
                .Aggregate()
                .Group(b => b.doble_carta,
                ac => new {
                    id = ac.Key,
                    total = ac.Sum(b => 1)
                });

            var DobleCarta_Grupo = consumo_DobleCarta.ToList();

            int resultado = 0;
            foreach (var group in DobleCarta_Grupo)
            {
                resultado+= group.id*group.total;
            }

            return resultado; // se retorna la cantidad total
        }

        // funcion para calcular la cantidad de paginas carta por mes
        public int graf_carta(string mes)
        {
            var client = new MongoClient(); // inicializamos el cliente de mongodb
            var bd = client.GetDatabase("Proyecto"); // se le indica la base que se quiere manejar
            var collection = bd.GetCollection<Registros>(mes); // se indica la coleccion que se va a manejar

            // se cuenta la cantidad de veces que aparece un numero en los documentos y este numero se multiplica por su numero
            var consumoAgosto = collection
                .Aggregate()
                .Group(b => b.carta,
                ac => new {
                    id = ac.Key,
                    total = ac.Sum(b => 1)
                });

            var AgostoGrupo = consumoAgosto.ToList();

            int resultado = 0;
            foreach (var group in AgostoGrupo)
            {
                resultado += group.id * group.total;
            }

            return resultado; // se retorna la cantidad total
        }

        // funcion para calcular la cantidad de paginas oficio por mes
        public int graf_oficio(string mes)
        {
            var client = new MongoClient(); // inicializamos el cliente de mongodb
            var bd = client.GetDatabase("Proyecto"); // se le indica la base que se quiere manejar
            var collection = bd.GetCollection<Registros>(mes); // se indica la coleccion que se va a manejar

            // se cuenta la cantidad de veces que aparece un numero en los documentos y este numero se multiplica por su numero
            var consumoAgosto = collection
                .Aggregate()
                .Group(b => b.oficio,
                ac => new {
                    id = ac.Key,
                    total = ac.Sum(b => 1)
                });

            var AgostoGrupo = consumoAgosto.ToList();

            int resultado = 0;
            foreach (var group in AgostoGrupo)
            {
                resultado += group.id * group.total;
            }

            return resultado; // se retorna la cantidad total
        }

        // funcion para calcular el consumo de toner negro por mes
        public int graf_BlancoNegro(string mes)
        {
            var client = new MongoClient(); // inicializamos el cliente de mongodb
            var bd = client.GetDatabase("Proyecto"); // se le indica la base que se quiere manejar
            var collection = bd.GetCollection<Registros>(mes); // se indica la coleccion que se va a manejar

            // se cuenta la cantidad de veces que aparece un numero en los documentos y este numero se multiplica por su numero
            var consumoAgosto = collection
                .Aggregate()
                .Group(b => b.total_blanco_negro,
                ac => new {
                    id = ac.Key,
                    total = ac.Sum(b => 1)
                });

            var AgostoGrupo = consumoAgosto.ToList();

            int resultado = 0;
            foreach (var group in AgostoGrupo)
            {
                resultado += group.id * group.total;
            }

            return resultado; // se retorna la cantidad total
        }

        // funcion para calcular el consumo de toner color por mes
        public int graf_TodoColor(string mes)
        {
            var client = new MongoClient(); // inicializamos el cliente de mongodb
            var bd = client.GetDatabase("Proyecto"); // se le indica la base que se quiere manejar
            var collection = bd.GetCollection<Registros>(mes); // se indica la coleccion que se va a manejar

            // se cuenta la cantidad de veces que aparece un numero en los documentos y este numero se multiplica por su numero
            var consumoAgosto = collection  
                .Aggregate()
                .Group(b => b.total_todo_color,
                ac => new {
                    id = ac.Key,
                    total = ac.Sum(b => 1)
                });

            var AgostoGrupo = consumoAgosto.ToList();

            int resultado = 0;
            foreach (var group in AgostoGrupo)
            {
                resultado += group.id * group.total;
            }

            return resultado; // se retorna la cantidad total
        }
    }
}
