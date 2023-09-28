using System;

class Program
{
    public static void Main(string[] args)
    {
        string valorDigitado;
    
        MeuObjeto objeto = new MeuObjeto();
        Console.WriteLine("Programa para cálculo de equações de segundo grau.\nPara começar, digite os 3 valores.\n");

        for (int i = 0; i <= 2; i++)
        {
            Console.WriteLine($"{i + 1}º valor: ");
            do
            {
              valorDigitado = Console.ReadLine();
            } while (!objeto.InserirValor(valorDigitado, i));
        }

        if (objeto.delta < 0)
        {
            Console.WriteLine("\nNão há solução para os valores inseridos. O resultado de Delta foi: " + objeto.delta.ToString("N2"));
        }
        else
        {
            Console.WriteLine("\nO valor de Delta dos valores inseridos foi: " + objeto.delta.ToString("N2"));
            if (objeto.delta > 0)
            {
                Console.WriteLine($"\nA equação de segundo grau dos valores inseridos tem dois resultados para 'X'.\nResultado da equação com soma da raiz de Delta: {objeto.equacaoSegundoGrauSoma}\nResultado da equação com subtração da raiz de Delta: {objeto.equacaoSegundoGrauSubtracao}");
            }
            else {
              Console.WriteLine($"\nA equação de segundo grau dos valores inseridos tem um resultado para 'X'.\nResultado da equação com a raiz de Delta: {objeto.equacaoSegundoGrauSoma}");
            }
        }
    }
}