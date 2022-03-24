using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string conta = "";

            int num1;//variavel para soma, numero um

            int num2;//variavel para soma, numero dois

            int num3;//variavel para subtracao, numero um

            int num4;//variavel para subtracao, numero dois

            int num5;//variavel para multiplicacao, numero um

            int num6;//variavel para multiplicacao, numero dois

            int num7;//variavel para divisao, numero um

            int num8;//variavel para divisao, numero dois

            int resultado; // variavel para o resultado

            Console.WriteLine("Qual Conta Deseja Fazer?"); // pergunta para o usuario sobre a conta
            conta = (Console.ReadLine()); // le a linha de cima e armazena em conta

            if (conta == "soma" || conta == "+")//se a string conta for uma das 'se' le as linhas abaixo
            {
                Console.WriteLine("digite o primeiro numero");//pergunta a o usuario qual numero ele deseja colocar
                num1 = int.Parse(Console.ReadLine());// le a linha de cima e armazena em conta
                Console.WriteLine("digite o segundo numero");//pergunta a o usuario qual numero ele deseja colocar
                num2 = int.Parse(Console.ReadLine());// le a linha de cima e armazena em conta
                resultado = num1 + num2;//armazena a soma do num1 e num2 em resultado
                Console.WriteLine(resultado);//mostra o resultado para o usuario
            }
                else if (conta == "subtracao" || conta == "-")
            {//se a string conta for uma das 'se' le as linhas abaixo

                Console.WriteLine("digite o primeiro numero");//pergunta a o usuario qual numero ele deseja colocar
                num3 = int.Parse(Console.ReadLine());// le a linha de cima e armazena em conta
                Console.WriteLine("digite o segundo numero");//pergunta a o usuario qual numero ele deseja colocar
                num4 = int.Parse(Console.ReadLine());// le a linha de cima e armazena em conta
                resultado = num3 - num4;//armazena a soma do num3 e num4 em resultado
                Console.WriteLine(resultado);//mostra o resultado para o usuario

            }
                     else if (conta == "multiplicacao" || conta == "*")//se a string conta for uma das 'se' le as linhas abaixo
                Console.WriteLine("digite o primeiro numero");//pergunta a o usuario qual numero ele deseja colocar
            num5 = int.Parse(Console.ReadLine());// le a linha de cima e armazena em conta
            Console.WriteLine("digite o segundo numero");//pergunta a o usuario qual numero ele deseja colocar
            num6 = int.Parse(Console.ReadLine());// le a linha de cima e armazena em conta
            resultado = num5 * num6;//armazena a soma do num5 e num6 em resultado
            Console.WriteLine(resultado);//mostra o resultado para o usuario

        } else{
      }(conta == "divisao" || conta == "/"){//se a string conta for uma das 'se' le as linhas abaixo
      Console.WriteLine("digite o primeiro numero");//pergunta a o usuario qual numero ele deseja colocar
      num7 = int.Parse(Console.ReadLine());// le a linha de cima e armazena em conta
      Console.WriteLine("digite o segundo numero");//pergunta a o usuario qual numero ele deseja colocar
      num8 = int.Parse(Console.ReadLine());// le a linha de cima e armazena em conta
      resultado = num7 / num8;//armazena a soma do num7 e num8 em resultado
            Console.WriteLine(resultado);//mostra o resultado para o usuario

                            }else 
    if(conta == "s" || conta == "S"){//se a string conta for uma das 'se' le as linhas abaixo
    Console.WriteLine("fechando o programa");//mostra uma mensagem antes de fechar o programa
    Console.ReadKey();
                            }
            }
      }
}
