using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain
{
    public class Vertex 
    {
        public Vertex(string name)
        {
            if(string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name не может быть NULL");

            Name = name;
            Edges = new List<Edge>();
        }
        public string Name { get; set; }
        public List<Edge> Edges { get; private set; }

        public void AddEdge(Vertex vertex, int weight)
        {
            if (vertex == null)
                throw new ArgumentNullException($"Argument is null exception {vertex}");

            Edges.Add(new Edge(vertex, weight));
        }



    }
}
