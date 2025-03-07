/*  1. Escreva um algoritmo que solicite ao usuário a entrada de 4 números  negativos e 2 números positivos, e que exiba o somatório desses números na tela. 
 *  Após exibir a soma, o programa deve mostrar também os números que o usuário digitou, um por linha.*/

using System;

int[] numeros = new int[6];
string numeroString = "";
bool boolValue = false;
int soma = 0;

for (int i = 0; i < numeros.Length; i++) 
{
    if (i < 4) 
    {
        Console.WriteLine($"Insira o {i + 1}º número inteiro positivo:");
        numeroString = Console.ReadLine();

        boolValue = int.TryParse(numeroString, out int numeroOut);

        if (boolValue)
        {
            if (numeroOut >= 0)
            {
                numeros[i] = numeroOut;
            }
            else
            {
                i--;
                Console.WriteLine("O número precisa ser positivo.");
            }
        }
        else
        {
            i--;
            Console.WriteLine("O valor inserido não é um número inteiro.");
        };
    }
    else
    {
        Console.WriteLine($"Insira o {i + 1}º número inteiro negativo:");
        numeroString = Console.ReadLine();

        boolValue = int.TryParse(numeroString, out int numeroOut);

        if (boolValue)
        {
            if (numeroOut < 0)
            {
                numeros[i] = numeroOut;
            }
            else
            {
                i--;
                Console.WriteLine("O número precisa ser negativo.");
            }
        }
        else
        {
            i--;
            Console.WriteLine("O valor inserido não é um número inteiro.");
        };
    }
};

for (int y = 0; y < numeros.Length; y++)
{
    Console.WriteLine($"{y + 1} valor: {numeros[y]}");
    soma += numeros[y];
};

Console.WriteLine($"A soma de todos os valores é: {soma}");
Console.ReadLine();