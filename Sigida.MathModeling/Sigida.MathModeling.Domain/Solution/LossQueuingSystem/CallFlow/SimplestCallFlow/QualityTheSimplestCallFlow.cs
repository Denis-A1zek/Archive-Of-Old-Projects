using Sigida.MathModeling.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain.Solution.LossQueuingSystem
{
    internal class QualityTheSimplestCallFlow : ISubtask
    {
        private double _gamma;
        private IOperationStep _step;
        private DistributionLaw _distLaw;
        public QualityTheSimplestCallFlow(double gamma, IOperationStep stepLogger)
        {
            _step = stepLogger;
            _gamma = gamma;
        }

        public void Calculate()
        {
            _distLaw = new DistributionLaw(_gamma, _step);

            _distLaw.Calculate();

        }

        public void CreateReport()
        {
            var Y = _gamma *(1 -  _distLaw.Probabilitys[4]);
            var L = _gamma - Y;

            _step.Append(
              @$"2) Определим числовые характеристики качества обслуживания вызовов:
              1.Вероятность потери потока вызовов(вероятность отказа) – основная качественная характеристика СМО с потерями 
                                                Dioe = pn = {_distLaw.Probabilitys[4]}
              2. Интенсивность обслуженной нагрузки
                                Y = λ(1-p_n ) = {_gamma} * (1 - {_distLaw.Probabilitys[4]}) = {Y}
              3. Интенсивность потенциальной нагрузки
                                                         A = λ = {_gamma}
              4. Интенсивность поступающей нагрузки
                                                          Λ=λ = {_gamma}
              5. Интенсивность утраченной нагрузки
                                                   Λ_утр=A-Y = {_gamma} - {Y} = {L}
              6.Интенсивность избыточная
                                                     Λ_изб=Λ-Y = {_gamma} - {Y} = {L}
              7.Вероятность потери по времени (доля времени от всего времени обслуживания, когда все каналы заняты)
                                             D_t= p_n = {_distLaw.Probabilitys[4]}
              8. Вероятность потери по нагрузке
                                             D_t=  Λ_οοσ/A=p_n= {_distLaw.Probabilitys[4]}


");
        }
    }
}
