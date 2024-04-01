using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaJson
{
    internal class Notas
    {

        string nombre;
        List<int> notas;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<int> Notes{ get => notas; set => notas = value; }
    }
}
