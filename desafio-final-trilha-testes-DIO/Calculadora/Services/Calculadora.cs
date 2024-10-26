using System;
using System.Collections.Generic;

namespace Calculadora.Services
{
    public class Calculadora
    {
        private List<string> _historico;

        public Calculadora()
        {
            _historico = new List<string>();
        }

        public float Somar(float num1, float num2)
        {
            float resultado = num1 + num2;
            _historico.Add($"{num1} + {num2} = {resultado}");
            return resultado;
        }

        public float Subtrair(float num1, float num2)
        {
            float resultado = num1 - num2;
            _historico.Add($"{num1} - {num2} = {resultado}");
            return resultado;
        }

        public float Dividir(float num1, float num2)
        {
            if (num2 == 0)
            {
                _historico.Add($"{num1} / {num2} = Não é possível dividir por zero.");
                return 0;
            }
            float resultado = num1 / num2;
            _historico.Add($"{num1} / {num2} = {resultado}");
            return resultado;    
        }

        public float Multiplicar(float num1, float num2)
        {
            float resultado = num1 * num2;
            _historico.Add($"{num1} * {num2} = {resultado}");
            return resultado;
        }

        public List<string> Historico()
        {
            return _historico;
        }
    }
}
