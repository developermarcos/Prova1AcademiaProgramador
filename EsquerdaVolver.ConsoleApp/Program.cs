using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeParametros;
            string instrucoes;
            char ladoAtual;
            while (true)
            {
                Console.Write("Informe a quantiadde de parametros a ser passada para o recruta: ");
                quantidadeParametros = Convert.ToInt32(Console.ReadLine());
                if(quantidadeParametros == 0)
                    break;
                Console.Write("Informe as intruções sem nenhum espaçamento entre elas: ");
                instrucoes = Console.ReadLine().ToUpper();
                ladoAtual = 'N';
                for (int i = 0; i < instrucoes.Length; i++)
                {
                    if(instrucoes[i] == 'E')
                    {
                        switch (ladoAtual)
                        {
                            case 'N':
                                ladoAtual = 'O';
                                break;
                            case 'O':
                                ladoAtual = 'S';
                                break;
                            case 'S':
                                ladoAtual = 'L';
                                break;
                            case 'L':
                                ladoAtual = 'N';
                                break;
                        }
                    }
                    else if(instrucoes[i] == 'D')
                    {
                        switch (ladoAtual)
                        {
                            case 'N':
                                ladoAtual = 'l';
                                break;
                            case 'l':
                                ladoAtual = 'S';
                                break;
                            case 'S':
                                ladoAtual = 'O';
                                break;
                            case 'O':
                                ladoAtual = 'N';
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Existe algum parametro incorreto, vamos começar novamente");
                    }
                }
                Console.WriteLine("Lado atual: {0}", ladoAtual.ToString().ToUpper());
                Console.ReadKey();
            }
        }
    }
}
