using Sigida.MathModeling.Domain.Interface;
using Sigida.MathModeling.Domain.Solution.LossQueuingSystem.CallFlow.PrimitiveCallFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution.LossQueuingSystem
{
    internal class PrimitiveCallFlow : ISubtask
    {
        private double N;
        private readonly double a;
        private  IOperationStep step;

        private double e;
        private double eOld;

        public PrimitiveCallFlow(double n, double A, IOperationStep step)
        {
            N=n;
            a=A;
            this.step=step;
        }

        public void Calculate()
        {
            var primitive = new DistributionLawPrimitive(N, a, step);
            primitive.Calculate();
            eOld = primitive.MaxProb;

            var primitive1 = new DistributionLawPrimitive(N - 1, a, step);
            primitive1.Calculate();
            e = primitive1.MaxProb;
        }

        public void CreateReport()
        {
            var Y = a  *  N * (1 -  e) / (1 + a *(1 -  e));
            var A = (N * a) / (1 + a);
            var L = N * a  / (1 +  a  *  (1 - e));

            step.Append(@$"
            2) Определим числовые характеристики качества обслуживания вызовов:
            1.	Вероятность потери потока вызовов (вероятность отказа) – основная качественная характеристика СМО с потерями
                                            P_отк=Λ_(вб.)/Λ=ε(N-1,n,a)=ε({N-1},4,{a}) = {e}
            2.	Интенсивность обслуженной нагрузки
                       Υ=  (αN(1-ε(N-1,n,α)))/(1+ α(1-ε(N-1,n,a))) = {a} * {N} * (1 - {e}) / 1 + {a} * (1 - {e}) = {Math.Round(Y,4)}
            3.	Интенсивность потенциальной нагрузки
                                            A=N*a=Na/(1+a) = {N*a} / {1 + a} = {A}
            4.	Интенсивность поступающей нагрузки
                                Λ=αΝ/(1+α(1-ε(N-1,n,a))) = {N * a} / 1 + {a} * {1 - e} = {L}
            5.	Интенсивность утраченной нагрузки
                                            Λ_упр=A-Y = {A} - {Y} = {A - Y}
            6.	Интенсивность избыточная
                                             Λ_(изб.)=Λ-Y = {L} - {Y} = {L - Y}
            7.	Вероятность потери по времени (доля времени от всего времени обслуживания, когда все каналы заняты)
                                                P_t=p_n= ε({N-1},4,{a})= {eOld} 
            8.	Вероятность потери по нагрузке
                          P_н=P_откл/(1+a(1-P_откл)) = {e} / 1 + {a} * (1 - {e}) = {(e) / (1 + a *(1 - e))} = {Math.Round((e) / (1 + a *(1 - e)),4)}

            ");
        }
    }
}
