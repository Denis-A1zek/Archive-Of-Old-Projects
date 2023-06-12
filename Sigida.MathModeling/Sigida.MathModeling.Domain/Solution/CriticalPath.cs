using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain
{
    public class CriticalPath : IDecision
    {
        private int[,] _criticalPath;
        private int[,] _matrix;
        private int _lenghtVertices;

        private Graph _graph;

        public CriticalPath(Graph graph)
        {
            _lenghtVertices = graph.Vertices.Count;
            _graph = graph;
        }

        public static readonly int MinValue = -36542;

        public int[,] TableCriticalPath => _criticalPath;

        public void Decision(IOperationStep operationStep)
        {
              var matrixZero = Matrix<int>.Diagonal(_graph.GetMatrix(InitMatrixMinValue()), 0);

            var criticalPAth = new int[matrixZero.GetLength(0), matrixZero.GetLength(1)];
            InitTable(criticalPAth, matrixZero);

            for (int iterator = 1, tableIterator = 0; iterator < matrixZero.GetLength(0) - 1; iterator++, tableIterator++)
            {

                for (int i = 0; i < matrixZero.GetLength(0); i++)
                {
                    var temp = new int[matrixZero.GetLength(0)];

                    operationStep.Append($"v{iterator +1} in {i} = {{");

                    for (int j = 0; j < matrixZero.GetLength(1); j++)
                    {
                        var first = matrixZero[i, j];
                        var second = criticalPAth[tableIterator, j];

                        operationStep.Append($" {(first <= MinValue ? "-∞" : first.ToString())}+{(second <= MinValue ? "-∞" : second.ToString())}; ");

                        temp[j] = (matrixZero[i, j]) + (criticalPAth[tableIterator, j]);
                    }

                    operationStep.Append($"}} = {temp.Max()}\n");

                    criticalPAth[iterator, i] = temp.Max();
                }
            }

            _criticalPath = criticalPAth;
            _matrix = matrixZero;
        }

        private void InitTable(int[,] matrix, int[,] matrixSerial)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[0, i] = matrixSerial[i, 6];
            }
        }

        private int[,] InitMatrixMinValue()
        {
            var matrix = new int[_graph.Vertices.Count, _graph.Vertices.Count];

            for (int i = 0; i < _graph.Vertices.Count; i++)
            {
                for (int j = 0; j < _graph.Vertices.Count; j++)
                {
                    matrix[i, j] = MinValue;
                }
            }

            return matrix;
        }
    }
}
