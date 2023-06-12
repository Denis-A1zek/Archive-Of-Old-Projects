using Sigida.MathModeling.Domain.Extension;
using Sigida.MathModeling.Domain.Interface;
using Sigida.MathModeling.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution
{
    public class SimulationProbability : IDecision
    {
        //Первое задание
        private double m1 = 8;
        private double n1 = 6;
        private double p = 0.45;

        //Второй задание значения
        private float m = 8;
        private float[] prop = new float[] { 0.17f, 0.27f, 0.32f, 0.24f };

        //Значения для третьего задания
        MyRange range = new MyRange(0, -1, 7);
        private double lambda = 4.5d;

        //Значение пятого
        private double m5 = 15;
        private double o = 7;


        private IOperationStep localStep;
        public void Decision(IOperationStep operationStep)
        {
            localStep = operationStep;

            var listTask = new List<ITask>
            {
                new BernoulliExperiment(m1,n1, p, localStep),
                new SingleEventSolve(m, prop, localStep),
                new ContinuouRandomVariables(range, lambda,m5, o, localStep),
                new TimeEstimation(6, localStep)
            };

            foreach (var task in listTask)
            {
                task.Run();
            }                  
        }        
    }
}
