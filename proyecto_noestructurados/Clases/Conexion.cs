using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using RDotNet;
using System.Windows.Forms;
using System.Collections;

namespace proyecto_noestructurados.Clases
{
    public class Conexion
    {
        static String servidor = "127.0.0.1";
        static String puerto = "27017";

        public static MongoClient cliente = new MongoClient("mongodb://" + servidor + ":" + puerto);

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

        public void creaimagen()
        {
            REngine engine;
            string fileName = "C:\\Users\\gunss\\source\\repos\\proyecto_noestructurados\\imagenes\\myplot.png";
            
            var titulo = "Consumo de toner por mes";
            var valor_a = this.graf_consumo_toner("agosto");
            var valor_b = this.graf_consumo_toner("septiembre");
            var valor_c = this.graf_consumo_toner("octubre");

            //init the R engine            
            REngine.SetEnvironmentVariables();
            engine = REngine.GetInstance();
            engine.Initialize();

            CharacterVector fileNameVector = engine.CreateCharacterVector(new[] { fileName });
            engine.SetSymbol("fileName", fileNameVector);

            // creacion del plot y exportacion
            try
            {
                var x = engine.Evaluate("x <- c(" + valor_a + "," + valor_b + "," + valor_c + ")").AsNumeric();
                engine.Evaluate("png(filename=fileName, width=6, height=6, units='in', res=100)");
                engine.Evaluate("barplot(x, main='" + titulo + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))");
                engine.Evaluate("dev.off()");
            }
            catch
            {
            }

            //clean up
            engine.Dispose();

            //output
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit");
            //Console.ReadKey();
        }

        public double graf_consumo_toner(string mes)
        {
            var client = new MongoClient();
            var bd = client.GetDatabase("Proyecto");
            var collection = bd.GetCollection<Registros>(mes);

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

            return resultado;
        }

        public int graf_doble_carta(string mes)
        {
            var client = new MongoClient();
            var bd = client.GetDatabase("Proyecto");
            var collection = bd.GetCollection<Registros>(mes);

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

            return resultado;
        }

        public int graf_carta(string mes)
        {
            var client = new MongoClient();
            var bd = client.GetDatabase("Proyecto");
            var collection = bd.GetCollection<Registros>(mes);

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

            return resultado;
        }

        public int graf_oficio(string mes)
        {
            var client = new MongoClient();
            var bd = client.GetDatabase("Proyecto");
            var collection = bd.GetCollection<Registros>(mes);

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

            return resultado;
        }

        public int graf_BlancoNegro(string mes)
        {
            var client = new MongoClient();
            var bd = client.GetDatabase("Proyecto");
            var collection = bd.GetCollection<Registros>(mes);

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

            return resultado;
        }

        public int graf_TodoColor(string mes)
        {
            var client = new MongoClient();
            var bd = client.GetDatabase("Proyecto");
            var collection = bd.GetCollection<Registros>(mes);

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

            return resultado;
        }
    }
}
