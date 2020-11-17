using System;

namespace Calculadora_Simples
{
    class Program
    {
        static void Main(string[] args)
        {

         // Perguntar a operção
         Console.WriteLine("Qual a operação deseja realizar? \nSoma, Subtracao, Mutiplicacao, Divisao ");
        string operacao = Console.ReadLine();

        // Pedir o 1° número
        Console.WriteLine("Digite o 1° número :");
        float  num1 = float.Parse( Console.ReadLine() );

        // Pedir o 2° número
         Console.WriteLine("Digite o 2° número :");
         float  num2 = float.Parse( Console.ReadLine() );
        // Fazer o cálculo
        // f = sufixo do float
        float resultado = 0f;

        // if(operacao == "Soma")
        // {
        //     resultado = num1 + num2;
        // }else if (operacao == "Subtracao" || operacao == "subtracao" )
        // {
        //     resultado = num1 - num2;
        // }
        // else if(operacao == "Multiplicacao")
        // {
        //       resultado = num1 * num2;
        // }
        // else if(operacao == "Divisao")
        // {
        //     resultado = num1 / num2;
        // }
        // else
        // {
        //     Console.WriteLine("Operação inválida");
        // }
        
        
        switch(operacao){
            case "soma":
            resultado = num1 + num2;
            break;

            case "subtracao":
            resultado = num1 - num2;
            break;

            case "multipicacao":
            resultado = num1 * num2;
            break;

            case "divisao":
            resultado = num1 / num2;
            break;

            default:
            Console.WriteLine("Operação inválida! :( ");
            break;
        }
    

        // Mostrar o resultado
        
        // Concatenação
        // Console.WriteLine("Calculo : "+ num1 +" com "+ num2 +" = " + resultado);

        // Interpolação
        Console.WriteLine($"Calculo : {num1} com {num2} = {resultado}");

        }
    }
}
