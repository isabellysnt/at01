using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class AnalisadorCredito
    {
        public int Calcular(ContaBancaria conta)
        {
            int score = 1000;

            
            if (conta.Saldo > 5000)
            {
                score += 100;
            }

            
            if (conta.Saldo < 0)
            {
                score -= 200;
            }

            
            if (conta.Titular.EstadoUF == "SE")
            {
                score += 150;
            }

          
            if (conta.Titular.Nome.Length < 5)
            {
                score -= 50;
            }

           
            if (conta.Saldo == 0)
            {
                score -= 100;
            }

            
            if (conta.Titular.EstadoUF == "RJ" ||
                conta.Titular.EstadoUF == "SP")
            {
                score -= 40;
            }

           
            if (conta.Saldo > 100000)
            {
                score += 300;
            }

          
            if (conta.Titular.EstadoUF == "SC")
            {
                score += 100;
            }

           
            if (conta.Titular.EstadoUF == "BA" ||
                conta.Titular.EstadoUF == "PE" ||
                conta.Titular.EstadoUF == "AL" ||
                conta.Titular.EstadoUF == "CE" ||
                conta.Titular.EstadoUF == "MA" ||
                conta.Titular.EstadoUF == "PB" ||
                conta.Titular.EstadoUF == "PI" ||
                conta.Titular.EstadoUF == "RN" ||
                conta.Titular.EstadoUF == "SE")
            {
                score += 40;
            }

            if (conta.Saldo >= 1 && conta.Saldo <= 500)
            {
                score += 10;
            }

            return score;
        }
    }
}
