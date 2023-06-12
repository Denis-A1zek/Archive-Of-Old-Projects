using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain
{
    public class Graph 
    {
        private int[,] _matrix;  
        public Graph()
        {
            Vertices = new List<Vertex>();  
        }
        public List<Vertex> Vertices { get;}
        public int[,]? Matrix 
        {
            get => _matrix is null ? null: _matrix;
            private set => Matrix = _matrix;
        }
        public void AddVertex(Vertex vertex)
        {
            if (vertex == null)
                throw new ArgumentNullException("Не инициализированная вершина");

            Vertices.Add(vertex);
        }

        #region Edge add 
        public void AddEdge(Vertex from, Vertex to, int weight)
        {
            if(from == null || to == null)
                throw new ArgumentNullException("NULL вершины");

            from.AddEdge(to, weight);
        }
        public void AddEdge(string from, string to, int weight = 0)
        {
            var _from = Vertices.Find(vertex => vertex.Name == from);
            var _to = Vertices.Find(vertex => vertex.Name == to);

            if (from == null || to == null)
                throw new ArgumentException("Вершины не найдены");

            _from?.AddEdge(_to, weight);
        }
        #endregion

        public double[,] GetMatrix()
        {
            var matrix = new double[Vertices.Count,Vertices.Count];

            foreach (var vertex in  Vertices)
            {
                for (int i = 0; i < vertex.Edges.Count; i++)
                {
                    var startVertex = Vertices.FindIndex(vert => vert.Name == vertex.Name);
                    var connectedVertex = Vertices.FindIndex(vert2 => vert2.Name == vertex.Edges[i].Connected.Name);
                    
                    matrix[startVertex, connectedVertex] = vertex.Edges[i].Weight;
                }
            }

            return matrix;
        }

        public int[,] GetMatrix(int[,] matrix)
        {


            foreach (var vertex in Vertices)
            {
                for (int i = 0; i < vertex.Edges.Count; i++)
                {
                    var startVertex = Vertices.FindIndex(vert => vert.Name == vertex.Name);
                    var connectedVertex = Vertices.FindIndex(vert2 => vert2.Name == vertex.Edges[i].Connected.Name);

                    matrix[startVertex, connectedVertex] = vertex.Edges[i].Weight;
                }
            }

            return matrix;
        }

        public static Graph FromArray(double[,] matrix)
        {
            var graph = new Graph();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                graph.AddVertex(new Vertex($"v{i+1}"));

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == null)
                        continue;
                    graph.AddEdge(graph.Vertices[i], graph.Vertices[j], (int)matrix[i, j]);
                }
            }

            return graph;
        }

        //public IEnumerable<string> FindCtriticalPath()
        //{
        //    var matrixZero = Matrix<int>.Diagonal(GetMatrix(InitMatrixMinValue()), 0);

        //    var criticalPAth = new int[matrixZero.GetLength(0), matrixZero.GetLength(1)];
        //    InitTable(criticalPAth, matrixZero);

        //    for (int iterator = 1, tableIterator = 0; iterator < matrixZero.GetLength(0) - 1; iterator++, tableIterator++)
        //    {

        //        for (int i = 0; i < matrixZero.GetLength(0); i++)
        //        {
        //            var stringBuilder = new StringBuilder();
        //            var temp = new int[matrixZero.GetLength(0)];

        //            stringBuilder.Append($"v{iterator +1} in {i} = {{");

        //            for (int j = 0; j < matrixZero.GetLength(1); j++)
        //            {
        //                var first = matrixZero[i, j];
        //                var second = criticalPAth[tableIterator, j];

        //                stringBuilder.Append($" {ToInfinity(first)}+{ToInfinity(second)}; ");

        //                temp[j] = (matrixZero[i, j]) + (criticalPAth[tableIterator, j]);
        //            }

        //            stringBuilder.Append($"}} = {temp.Max()}");

        //            criticalPAth[iterator, i] = temp.Max();

        //            yield return stringBuilder.ToString();
        //        }
        //        Console.WriteLine();
        //    }

        //    _criticalPath = criticalPAth;
        //    _matrix = matrixZero;

        //}

        private void InitTable(int[,] matrix, int[,] matrixSerial)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[0,i] = matrixSerial[i,6];
            }
        }

        private int[,] InitMatrixMinValue()
        {
            var minValue = -36542;
            var matrix = new int[Vertices.Count, Vertices.Count];

            for (int i = 0; i < Vertices.Count; i++)
            {
                for (int j = 0; j < Vertices.Count; j++)
                {
                    matrix[i, j] = minValue;
                }
            }

            return matrix;
        }

        private int[,] InitMatrixPath()
        {
            var matrix = new int[Vertices.Count, Vertices.Count];

            for (int i = 0; i < Vertices.Count; i++)
            {
                for (int j = 0; j < Vertices.Count; j++)
                {
                    matrix[i, j] = int.MaxValue;
                }
            }

            return matrix;
        }
    }
}
