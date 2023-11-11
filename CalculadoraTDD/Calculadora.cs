using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraTDD
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data){
            listaHistorico = new List<string>();
            this.data = data;
        }

        public void AdicionaStringHistorico(int resultado){
            listaHistorico.Insert(0, $"Resultado: {resultado}, {data}");
        }
        public int Soma(int num1, int num2)
        {
            int resultado = num1 + num2;
            AdicionaStringHistorico(resultado);
            return resultado;
        }
        public int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            AdicionaStringHistorico(resultado);
            return resultado;
        }
        public int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            AdicionaStringHistorico(resultado);
            return resultado;
        }
        public int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            AdicionaStringHistorico(resultado);
            return resultado;
        }
        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3,listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
