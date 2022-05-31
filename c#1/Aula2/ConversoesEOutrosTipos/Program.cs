using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Conversões e outros tipos");

        double salario;
        salario = 3000.15;

        int salarioInteiro = (int)salario; // casting

        long x = 2000000000;  // UTILIZAR QUANDO A QUANTIDADE BITS FOR MAIOR QUE 32 | ex: int 2000000000  seu limite vai de -2³² até 2³²
      
        short y = 1500; //  armazena até 16 bits
    
        float altura = 1.62f;

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
