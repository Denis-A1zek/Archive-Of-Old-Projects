using Sigida.MathModeling.Application;
using Sigida.MathModeling.Domain;
using Sigida.MathModeling.Domain.Solution;
using Sigida.MathModeling.Infrastructure.Output;

//Console.OutputEncoding = System.Text.Encoding.UTF8;
//IOperationStep ouput = new OperationStepToConsole();
//Console.WriteLine("\nВариант №2");


//TASK 4
//IDecision decision = new ExplicitLossQueuingSystem(7, 8, 2);
//IOperationStep operationStep = new OperationStepToTxt(@"C:\Users\den1s\Desktop\lab4var8.txt");
//var lab = new LabaratoryWork(operationStep, decision);
//lab.Run();


//Task 7
IDecision decision = new SimulationProbability();
IOperationStep operationStep = new OperationStepToTxt(@"C:\Users\den1s\Desktop\lab7-81var6.txt");
var lab = new LabaratoryWork(operationStep, decision);
lab.Run();

//Task 2
//var graph = new Graph();

//graph.AddVertex(new Vertex("v0"));
//graph.AddVertex(new Vertex("v1"));
//graph.AddVertex(new Vertex("v2"));
//graph.AddVertex(new Vertex("v3"));
//graph.AddVertex(new Vertex("v4"));
//graph.AddVertex(new Vertex("v5"));
//graph.AddVertex(new Vertex("v6"));


//graph.AddEdge("v0", "v1", 6);
//graph.AddEdge("v0", "v2", 12);
//graph.AddEdge("v0", "v3", 16);
//graph.AddEdge("v0", "v4", 3);

//graph.AddEdge("v1", "v2", 5);
//graph.AddEdge("v1", "v5", 13);

//graph.AddEdge("v2", "v3", 5);
//graph.AddEdge("v2", "v6", 9);


//graph.AddEdge("v3", "v6", 6);

//graph.AddEdge("v4", "v5", 5);
//graph.AddEdge("v4", "v6", 15);

//graph.AddEdge("v5", "v6", 6);



//var solution = new CriticalPath(graph);
//var output = new OperationStepToTxt(@"C:\Users\den1s\Desktop\lab2var8.txt");

//var lab = new LabaratoryWork(output, solution);
//lab.Run();

//var matr = graph.GetMatrix();

//output.Append("ТАБЛИЦА С КРИТИЧЕСКИМИ ПУТЯМИ \n");

//for (int i = 0; i < solution.TableCriticalPath.GetLength(0); i++)
//{
//    output.Append($"{i +1} | ");
//    for (int j = 0; j < solution.TableCriticalPath.GetLength(1); j++)
//    {
//        output.Append($" {(solution.TableCriticalPath[i, j] == CriticalPath.MinValue ? "-∞" : solution.TableCriticalPath[i, j].ToString())}");
//    };
//    output.Append("\n");
//}

//output.Append("МАТРИЦА ДУГ\n");
//for (int i = 0; i < matr.GetLength(0); i++)
//{
//    output.Append($"{i +1} | ");
//    for (int j = 0; j < matr.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            output.Append($"{matr[i, j]} ");
//            continue;
//        }
//        output.Append($"{(matr[i, j] == 0 ? "-∞" : matr[i, j].ToString())} ");
//    }
//    output.Append("\n");
//}

//Console.ReadKey();
