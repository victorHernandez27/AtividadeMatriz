using System;
using System.IO;

namespace AtividadeMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0, buscaLinha, buscaColuna,indice = 0;
            string nome, buscaNome;
            bool achou = false;
            String[,] matriz = new string[2, 3];

            do
            {
                Console.Clear();
                Console.WriteLine("=====MENU=====");
                Console.WriteLine("1-Adcionar Nomes\n2-Imprimir Matriz\n3-Imprimir nomes de uma Linha\n4-Imprimir nomes de uma Coluna\n5-Buscar Nome\n6-Ordenar Nomes em uma Linha\n7-Gravar Matriz\n8-Recuperar Matriz Salva\n9-sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite os nomes:");



                        for (int l = 0; l < matriz.GetLength(0); l++)
                        {
                            for (int c = 0; c < matriz.GetLength(1); c++)
                            {
                                Console.WriteLine("matriz[{0},{1}]=", l, c);
                                nome = Console.ReadLine();
                                matriz[l, c] = nome;
                            }
                        }
                        indice++;
                        Console.WriteLine("Digite qualquer tecla para sair...");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();

                        if(indice == 0)
                        {
                            Console.WriteLine("Matriz Vazia!");
                        }
                        else
                        {
                            for (int l = 0; l < matriz.GetLength(0); l++)
                            {
                                for (int c = 0; c < matriz.GetLength(1); c++)
                                {
                                    Console.Write("Matriz[{0},{1}] = {2}\t", l, c, matriz[l, c]);
                                }
                                Console.WriteLine();
                            }
                        }                       

                        Console.WriteLine("Digite qualquer tecla para sair...");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();

                        if(indice == 0)
                        {
                            Console.WriteLine("Matriz Vazia!");
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("Digite a linha {0,1,2} que se deseja saber os nomes:");
                                buscaLinha = int.Parse(Console.ReadLine());
                            } while (buscaLinha < 0 || buscaLinha > 2);

                            for (int l = buscaLinha; l == buscaLinha; l++)
                            {
                                for (int c = 0; c < matriz.GetLength(1); c++)
                                {
                                    Console.Write("Matriz[{0},{1}] = {2}\t", l, c, matriz[l, c]);
                                }
                                Console.WriteLine();
                            }
                        }                        

                        Console.WriteLine("Digite qualquer tecla para sair...");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();

                        if(indice == 0)
                        {
                            Console.WriteLine("Matriz Vazia!");
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("Digite a Coluna {0 a 10} que se deseja saber os nomes:");
                                buscaColuna = int.Parse(Console.ReadLine());
                            } while (buscaColuna < 0 || buscaColuna > 2);

                            for (int l = 0; l < matriz.GetLength(0); l++)
                            {
                                for (int c = buscaColuna; c == buscaColuna; c++)
                                {
                                    Console.Write("Matriz[{0},{1}] = {2}\t", l, c, matriz[l, c]);
                                }
                                Console.WriteLine();
                            }
                        }                      

                        Console.WriteLine("Digite qualquer tecla para sair...");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();

                        if(indice == 0)
                        {
                            Console.WriteLine("Matriz Vazia!");
                        }
                        else
                        {
                            Console.WriteLine("Nome a ser buscado:");
                            buscaNome = Console.ReadLine();

                            for (int l = 0; l < matriz.GetLength(0); l++)
                            {
                                for (int c = 0; c < matriz.GetLength(1); c++)
                                {
                                    if (buscaNome.Contains(matriz[l, c]))
                                    {
                                        Console.Write("Matriz[{0},{1}] = {2}\t", l, c, matriz[l, c]);
                                        achou = true;
                                    }
                                }
                                Console.WriteLine();
                            }

                            if (achou != true)
                            {
                                Console.WriteLine("Nome buscado não se encontra na matriz");
                            }
                        }                       

                        Console.WriteLine("Digite qualquer tecla para sair...");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();

                        if(indice == 0)
                        {
                            Console.WriteLine("Matriz Vazia!");
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("Digite a linha {0,1,2} que se deseja ordenar:");
                                buscaLinha = int.Parse(Console.ReadLine());
                            } while (buscaLinha < 0 || buscaLinha > 2);

                            for (int i = 0; i < matriz.GetLength(1) - 1; i++)
                            {
                                for (int j = i + 1; j < matriz.GetLength(1); j++)
                                {
                                    if (string.Compare(matriz[buscaLinha, i], matriz[buscaLinha, j], StringComparison.OrdinalIgnoreCase) > 0)
                                    {
                                        string auxTroca = matriz[buscaLinha, i];
                                        matriz[buscaLinha, i] = matriz[buscaLinha, j];
                                        matriz[buscaLinha, j] = auxTroca;
                                    }
                                }
                            }
                            Console.WriteLine("{0} Linha Ordenada com sucesso!", buscaLinha);
                        }           
                                              
                        Console.WriteLine("Digite qualquer tecla para sair...");
                        Console.ReadLine();

                        break;
                    case 7:
                        Console.Clear();
                        try
                        {
                            StreamWriter sw = new StreamWriter("c:\\5by5\\Matriz.txt");
                            
                            for (int l = 0; l < matriz.GetLength(0); l++)
                            {
                                for (int c = 0; c < matriz.GetLength(1); c++)
                                {
                                    sw.WriteLine(matriz[l, c]);
                                }
                            }

                            sw.Close(); 
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception: " + e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Salvando dados da Matriz.");
                        }
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();

                        string line;
                        try
                        {
                            StreamReader sr = new StreamReader("c:\\5by5\\Matriz.txt");
                            line = sr.ReadLine(); 
                            while (line != null)
                            {
                                for (int l = 0; l < matriz.GetLength(0); l++)
                                {
                                    for (int c = 0; c < matriz.GetLength(1); c++)
                                    {
                                        matriz[l, c] = line;
                                        line = sr.ReadLine();
                                    }
                                }

                            }
                            indice++;
                            sr.Close();
                            Console.WriteLine("Fim da Leitura do Arquivo");
                            Console.ReadLine();
                        }
                        catch (Exception e) 
                        {
                            Console.WriteLine("Exception: " + e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Matriz Recuperada");
                        }

                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcao invalida");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 9);
        }
    }
}
