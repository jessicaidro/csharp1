﻿using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - Encadenado for");

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinhas)
                    break;
            }
            Console.WriteLine();
        }

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinhas ; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinhas)
                    break;
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}