using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices
{
    class variables
    {
        protected int[,] mat;
        protected string[,] mats;
        protected int fl, cl,i=0,j=0,d=0;
        protected string respuesta;
    }
    class claseMatriz:variables
    {

        public void ingresar()
        {
            Console.Clear();
                Console.Write("Ingrese cuantas filas quiere para su matriz: ");
                fl = int.Parse(Console.ReadLine());
                Console.Write("Ingrese cuantas columnas quiere para su matriz: ");
                cl = int.Parse(Console.ReadLine());
                mat = new int[fl, cl];
            mats = new string[fl, cl];
                for (int f = 0; f < fl; f++)
                {
                    for (int c = 0; c < cl; c++)
                    {
                        Console.Write("Ingrse posicion [" + (f + 1) + " ," + (c + 1) + "]: ");


                        mat[f, c] = int.Parse(Console.ReadLine());

                    }
                }
            
            }
        public void mostrar()
        {
            for(int ed=0;ed< fl; ed++)
            {
                d = mat[i, j] + d;
                i++;
                j++;
            }
            
            Console.WriteLine("La diagonal principal es es: ");
            for (int i = 0; i < fl; i++)
            {
                for (int j = 0; j < cl; j++)
                {
                    if (i == j)
                    {
                        Console.Write( "[ {0} ]",mat[i,j]);
                    }
                    else Console.Write("[    ]");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("La suma de la diagonal principal es:"+d);
            Console.WriteLine("Pulse s para continuar en el algoritmo");
            respuesta = Console.ReadLine();
            respuesta.ToLower();
            if (respuesta == "s")
            {
                ingresar();
            }
        }
    }
    class cuadradoMagic
    { 
        public void Magico()
        {
            int[,] a;
            int i = 1, j = 0, n, x = 0, y = 0, b = 0, c = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Digite su valor para el cuadrado magico pero solo impar mayor o igual a 3");
                n = int.Parse(Console.ReadLine());
                a = new int[n, n];
                i = 0;
                j = n / 2;
            } while (n < 3 || n % 2 == 0);
            
                for (int k = 0; k < n * n; k++)
                {

                    if (i < 0) i = n - 1;
                    if (j == n) j = 0;
                    if (a[i, j] == 0)
                    {
                        x += 1;
                        a[i, j] = x;
                        b = i;
                        c = j;
                    }
                    else
                    {
                        x += 1;
                        a[(b + 1), c] = x;
                        i = b + 1;
                        j = c;
                    }
                    i = i - 1;
                    j = j + 1;

                }
                for (int m = 0; m < n; m++)
                {
                    for (int o = 0; o < n; o++)
                    {
                        Console.Write(  " [{0}]   ",a[m, o]);
                    }
                    Console.WriteLine("\n");
                }
                
            

           

        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            string respuesta = "";
            cuadradoMagic x = new cuadradoMagic();
            magico:

            x.Magico();
            Console.WriteLine("Pulse s para continuar en el algoritmo");
            respuesta = Console.ReadLine().ToLower();
            if (respuesta == "s") goto magico; 
            Console.ReadKey(); 
    }
    
    }
}
