using System;

namespace FrequenciaNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            int quantidadeNumeros, lerNumero;

            #region entrada
            Console.Write("Informe a quantidade de numeros a ser cadastrado: ");
            quantidadeNumeros = Convert.ToInt32(Console.ReadLine());
            int[] armazenaNumeros = new int[quantidadeNumeros];
            
            int repitido = 1;
            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.Write("Informe o {0} numero: ", (i + 1).ToString());
                armazenaNumeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            #endregion
            //processamento
            #region ordena
            for (int i = 0; i < quantidadeNumeros; i++)
            {
                for (int z = 0; z < (quantidadeNumeros - 1); z++)
                {
                    if(armazenaNumeros[z] > armazenaNumeros[z+1])
                    {
                        int troca = armazenaNumeros[z];
                        armazenaNumeros[z] = armazenaNumeros[z+1];
                        armazenaNumeros[z+1] = troca;
                    }
                }
            }
            #endregion
            #region validação e impreção
            for (int i = 0; i < quantidadeNumeros; i++)
            {
                
                if (i != (quantidadeNumeros -1))
                {
                    if (armazenaNumeros[i] == armazenaNumeros[i +1])
                    {
                        repitido++;
                    }
                    else
                    {
                        Console.WriteLine("O numero {0} apareceu {1} vez(es).", armazenaNumeros[i].ToString(), repitido.ToString());
                        repitido = 1;
                    }
                }
                else
                {
                    if(repitido != 0)
                        Console.WriteLine("O numero {0} apareceu {1} vez(es).", armazenaNumeros[i].ToString(), repitido.ToString());
                    else
                        Console.WriteLine("O numero {0} apareceu 1 vez(es).", armazenaNumeros[i].ToString());
                }
            }
            #endregion

            Console.ReadKey();

        }
    }
}
