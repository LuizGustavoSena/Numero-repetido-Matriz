using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 2];

            leituraMatriz(matriz);

            escritaMatriz(matriz);

            buscaMatriz(matriz);

            Console.ReadKey();
        }

        static void leituraMatriz(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int y = 0; y < mat.GetLength(1); y++)
                {
                    Console.Write(" [" + i + "] [" + y + "] =");
                    mat[i, y] = int.Parse(Console.ReadLine());
                }
        }

        static void escritaMatriz(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int y = 0; y < mat.GetLength(1); y++)
                {
                    Console.Write("\t " + mat[i, y]);
                }
                Console.WriteLine("");
            }
        }

        static void buscaMatriz(int[,] mat)
        {
            bool encontra = false;
            int c;
            
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int y = 0; y < mat.GetLength(1); y++)
                    for (int l = i; l < mat.GetLength(0); l++) 
                    {
                        if (i == l) 
                            c = y + 1;
                        else
                            c = 0; 

                        for (; c < mat.GetLength(1); c++)
                            if (mat[i, y] == mat[l, c] && (i != l || y != c)) {
                                Console.WriteLine("Valor " + mat[i, y] + " => matriz[" + i + "] [" + y + "] matriz[" + l + "][" + c + "]");
                                encontra = true;
                            }
                    }

            if (!encontra)
                Console.WriteLine("Número não repete");
        }
    }
}
