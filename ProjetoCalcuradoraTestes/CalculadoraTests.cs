using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using ProjetoCalculadora;
using Xunit;

namespace ProjetoCalcuradoraTestes
{
    public class CalculadoraTests
    {
        private readonly Calculadora _Calculadora;
        public CalculadoraTests()
        {
            _Calculadora = new Calculadora();
        }
        
        [Fact]
        public void Receber2Valores_valorAeValorB_SomaRetorne6()
        {
            // Arrange
            int valorA = 3;
            int valorb = 3;

            // Act
            int resultado = _Calculadora.Somar(valorA, valorb);
            
            // Assert
            Assert.Equal(6, resultado);

        }
        [Fact]
        public void Receber2Valores_valorAeValorB_SubtraiRetorne7()
        {
            // Arrange
            int valorA = 10;
            int valorb = 3;

            // Act
            int resultado = _Calculadora.Subtrair(valorA, valorb);
            
            // Assert
            Assert.Equal(7, resultado);

        }
        [Fact]
        public void Receber2Valores_valorAeValorB_MultiplicaRetorne9()
        {
            // Arrange
            int valorA = 3;
            int valorb = 3;

            // Act
            int resultado = _Calculadora.Multiplicar(valorA, valorb);
            
            // Assert
            Assert.Equal(9, resultado);

        }
        [Fact]
        public void Receber2Valores_valorAeValorB_DivideRetorne6()
        {
            // Arrange
            int valorA = 12;
            int valorb = 2;

            // Act
            int resultado = _Calculadora.Dividir(valorA, valorb);
            
            // Assert
            Assert.Equal(6, resultado);

        }

          
    }
}