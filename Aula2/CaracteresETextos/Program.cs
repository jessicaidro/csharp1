﻿using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string cursos = @"Cursos disponiveis: 
            - Go 
            - C# 
            - Python 
            - Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
