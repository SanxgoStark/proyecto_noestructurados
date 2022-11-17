using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
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
