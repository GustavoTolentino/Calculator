using System;

namespace calc
{
  // Simulador de Calculadora
    class Program
    {
        static void Main(string[] args)
        {

            // Perguntar a Operacao
            console.writeline("Qual operacao deseja realizar? /n Soma, Subtracao, Multiplicacao ou Divisao?");
            string operacao = console.readline();

            // Pedir o Primeiro Numero
            console.writeline("Digite o primeiro numero: ");
            float num1 = float.parse( console.readline() );

            // Pedir o Segundo Numero 
            console.writeline("Digite o segundo numero: ");
            float num2 = float.parse( console.readline() );

            // Fazer o calculo
            float resultado = 0f;

            // if(operacao == "Soma"){
            //     resultado = num1 + num2;
            // }else if(operacao == "Subtracao"){
            //     resultado = num1 - num2;
            // }else if(operacao == "Multiplicacao"){
            //     resultado = num1 * num2;
            // }else if(operacao == "Divisao"){
            //     resultado = num1 / num2;
            // }else{
            //     console.writeline("Operacao Invalida");
            // }

            // Estrutura para escolha de operacao para a calculadora
            switch(operacao){

                case "Soma":
                    resultado = num1 + num2;
                    break;

                case "Subtracao":
                    resultado = num1 - num2;
                    break;

                case "Multiplicacao":
                    resultado = num1 * num2;
                    break;

                case "Divisao":
                    resultado = num1 / num2;
                    break;

                default:
                    console.writeline("Operacao Invalida");
                    break;
            }

            // Mostrar o Resultado

            // Concatenacao
            // console.writeline("Calculo: " + num1 + "com" + num2 + "=" + resultado);

            // interpolacao
             console.writeline($"Calculo : {num1} com {num2} = {resultado} ");
        }
    }
}
