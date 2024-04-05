using ProjetoCalculadora;

var calc = new Calculadora();
calc.Somar(2,3);
calc.Multiplicar(5,3);
calc.Subtrair(10,3);
calc.Somar(7,3);
calc.Dividir(2,8);
calc.Somar(2,9);
System.Console.WriteLine(calc.Retorna3UltimosResultados());
