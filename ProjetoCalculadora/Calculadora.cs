using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{

    public class Calculadora
    {
        private ListaDeCalculos _Calculos;

        public Calculadora()
        {
            _Calculos = new ListaDeCalculos();
        }
        public int Somar(int valorA, int valorB)
        {
            int resultado = valorA + valorB;
           
            _Calculos.listaDeCalculos.Add($"{valorA} + {valorB} = {resultado}");   
            
            return resultado;
        }
        public int Subtrair(int valorA, int valorB)
        {
            int resultado = valorA - valorB;
            _Calculos.listaDeCalculos.Add($"{valorA} - {valorB} = {resultado}"); 
                
            return resultado;
        }
        public int Multiplicar(int valorA, int valorB)
        {
            int resultado = valorA * valorB;
            _Calculos.listaDeCalculos.Add($"{valorA} X {valorB} = {resultado}"); 
                    
            return resultado;
        }
        public int Dividir(int valorA, int valorB)
        {
            int resultado = valorA / valorB;
            _Calculos.listaDeCalculos.Add($"{valorA} / {valorB} = {resultado}"); 
            
            return resultado;
        }

        public string Retorna3UltimosResultados()
        {
            var resultados = "[ | ";
            var fim = 0;
            for(int i = _Calculos.listaDeCalculos.Count -1; i < _Calculos.listaDeCalculos.Count; i--)
            {

                resultados += _Calculos.listaDeCalculos[i] + " | "; 
                fim++;
                if(fim == 3) break;

            }
            resultados += " ]";
            return resultados;
        }
    }
}