using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain
{
    //Ребро графа
    public class Edge
    {
        public Edge(Vertex connectedTo, int weight )
        {
            if (connectedTo == null)
                throw new ArgumentNullException($"Связь не может иметь значение {connectedTo}");

            Connected = connectedTo;
            Weight = weight;
        }
        public Vertex? Connected { get; set; }
        public int Weight { get; set; }
        
    }
}
