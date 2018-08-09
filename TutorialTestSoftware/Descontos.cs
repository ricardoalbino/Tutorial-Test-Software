using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialTestSoftware
{
    public class Descontos
    {
        public double calcularDesconto(double ValorVenda)
        {
            double ValorDesconto = 0.0;

            if (ValorVenda == 0 || ValorVenda < 0)
            {
                throw new ArgumentException("O valor das vendas não pode ser Zero ou Negativo");
            }

            else if (ValorVenda >= 1000 && ValorVenda < 2000)
            {

                // 5% Desconto
                ValorDesconto = ValorVenda - (ValorVenda * 0.05);
            }

            else if (ValorVenda >= 2000 && ValorVenda < 5000)
            {
                // 10% Desconto
                ValorDesconto = ValorVenda - (ValorVenda * 0.01);
            }

            else if (ValorVenda >= 5000 && ValorVenda < 20000)
            {
                // 50% Desconto
                ValorDesconto = ValorVenda - (ValorVenda * 0.05);
            }
            else
            {
                ValorDesconto = ValorVenda - 0.0;
            }

            return ValorDesconto;
        }
    }
}
