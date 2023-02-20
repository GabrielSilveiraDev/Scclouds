// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

public class Funcoes
{

    public void FibonnaciSequencial(){

        Console.WriteLine("Digite a posição do termo que deseja encontrar na sequência de Fibonnaci");

        int posicao = int.Parse(Console.ReadLine());
        int termo = 1;
        int ultimo = 1;
        int penultimo = 1;

        if ((posicao == 1) || (posicao == 2)){
            Console.WriteLine("1");
        }

        else
        {
            for (int i = 0; i < posicao; i++){
                termo = ultimo + penultimo;
                penultimo = ultimo;
                ultimo = termo;
            }
            System.Console.WriteLine(termo);
        }     

    }
}




