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

        public void genaraciongrap()
        {
            REngine engine;
            // consumo de toner
            string fileNamet = "C:\\Users\\gunss\\source\\repos\\proyecto_noestructurados\\imagenes\\myplott.png";
            // consumo de papel
            string fileNamep = "C:\\Users\\gunss\\source\\repos\\proyecto_noestructurados\\imagenes\\myplotp.png";

            //init the R engine            
            REngine.SetEnvironmentVariables();
            engine = REngine.GetInstance();
            engine.Initialize();

            var titulot = "Consumo de toner";
            var titulop = "Consumo de papel";

            var valor_ap = this.graf_consumo_papel("agosto");
            var valor_bp = this.graf_consumo_papel("septiembre");
            var valor_cp = this.graf_consumo_papel("octubre");

            var valor_at = this.graf_consumo_toner("agosto");
            var valor_bt = this.graf_consumo_toner("septiembre");
            var valor_ct = this.graf_consumo_toner("octubre");

            CharacterVector fileNameVectorp = engine.CreateCharacterVector(new[] { fileNamep });
            engine.SetSymbol("fileNamep", fileNameVectorp);

            CharacterVector fileNameVectort = engine.CreateCharacterVector(new[] { fileNamet });
            engine.SetSymbol("fileNamet", fileNameVectort);

            // creacion del plot y exportacion
            try
            {
                var p = engine.Evaluate("p <- c(" + valor_ap + "," + valor_bp + "," + valor_cp + ")").AsNumeric(); 
                engine.Evaluate("png(filename=fileNamep, width=6, height=6, units='in', res=100)");
                engine.Evaluate("barplot(p, main='" + titulop + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))");
                engine.Evaluate("dev.off()");

                var t = engine.Evaluate("t <- c(" + valor_at + "," + valor_bt + "," + valor_ct + ")").AsNumeric();
                engine.Evaluate("png(filename=fileNamet, width=6, height=6, units='in', res=100)");
                engine.Evaluate("barplot(t, main='" + titulot + "',xlab = 'Mes',ylab = 'Cantidad',col=c('dodgerblue','darkorange2','gold2'),horiz=FALSE,names.arg=c('agosto','sept','oct'))");
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

        public int graf_consumo_papel(string mes)
        {
            var client = new MongoClient();
            var bd = client.GetDatabase("Proyecto");
            var collection = bd.GetCollection<Registros>(mes);

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
