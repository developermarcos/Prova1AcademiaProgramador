using System;

namespace ALendaDeFlaviusJosephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadePessoas, quantidadePulos, posicaoAtual = 0;
            string lerTela, quantidadePessoasEPulos;
            
            while (true)
            {
                Console.WriteLine("Tecle ENTER para continuar ou digite (sair) para fechar o software:");
                lerTela = Console.ReadLine().ToUpper();
                if(lerTela =="SAIR")
                    break;
                
                while (true)
                {
                    Console.WriteLine("Informe a quantidade de pessoas no circulo e posterior a isso o numero de salto entra essas pessoas");
                    Console.Write("Informe os numeros separados por 1 espaço:");
                    quantidadePessoasEPulos =Console.ReadLine();
                    quantidadePessoas = Convert.ToInt32(quantidadePessoasEPulos.Split(' ')[0]);
                    string[] mortos = new string[quantidadePessoas];
                    quantidadePulos = Convert.ToInt32(quantidadePessoasEPulos.Split(' ')[1]);
                    while (true)
                    {
                        posicaoAtual = quantidadePulos;
                        if(posicaoAtual >= quantidadePulos)
                        {
                            for (int i = 0; i < quantidadePessoas; i++)
                            {
                                if (mortos[i] == "mortos" || mortos[i+1] == "mortos")
                                {
                                    posicaoAtual++;
                                    break;
                                }
                                else
                                {
                                    mortos[i+1] = "mortos";
                                    posicaoAtual+ = 2;
                                    break;
                                }
                            }
                            mortos[posicaoAtual] = "mortos";
                        }
                        else
                        {
                            int inicio = posicaoAtual - quantidadePulos;
                            posicaoAtual = inicio;
                            mortos[posicaoAtual] = "mortos";
                        }
                    }
                    
                }
            }
        }
    }
}
