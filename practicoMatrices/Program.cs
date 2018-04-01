using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicoMatrices
{
    public class menu
    {
        int op;
        string respuesta = "";
        public void getMenu()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Ingrese un numero del 1 al 12 para ir al respectivo ejercicio, 13 para salir");
                op = int.Parse(Console.ReadLine());
            }
            catch { getMenu(); }

            switch (op)
            {
                case 1:
                    ejercicio1 aa = new ejercicio1();
                    aa.inicio();
                   
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 1; }
                    else getMenu();
                    break;
                case 2:
                    ejercicio2 ab = new ejercicio2();
                    ab.inicio();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 2; }
                    else getMenu();
                    break;
                case 3:
                    Console.WriteLine("Disculpe inge no pude acabarlo a tiempo");
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 3; }
                    else getMenu();
                    break;
                case 4:
                    ejercicio4 ad = new ejercicio4();
                    ad.inicio();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 4; }
                    else getMenu();
                    break;
                case 5:
                    ejercicio5 ae = new ejercicio5();
                    ae.inicio();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 5; }
                    else getMenu();
                    break;
                case 6:
                    ejercicio6 af = new ejercicio6();
                    af.inicio();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 6; }
                    else getMenu();
                    break;
                case 7:
                    ejercicio7 ag = new ejercicio7();
                    ag.inicio();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 7; }
                    else getMenu();
                    break;
                case 8:
                    Console.WriteLine("Disculpe inge no pude acabarlo a tiempo");
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 8; }
                    else getMenu();
                    break;
                case 9:
                    ejercicio9 ai = new ejercicio9();
                    ai.inicio();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 9; }
                    else getMenu();
                    break;
                case 10:
                    Console.WriteLine("Disculpe inge no pude acabarlo a tiempo");
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 10; }
                    else getMenu();
                    break;
                case 11:
                    Console.WriteLine("Disculpe inge no pude acabarlo a tiempo");
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 11; }
                    else getMenu();
                    break;
                case 12:
                    ejercicio12 al = new ejercicio12();
                    al.inicio();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 12; }
                    else getMenu();
                    break;

                case 13:
                    break;
                default:
                    getMenu();
                    break;
            }

        }
    }
    class varGeneral
    {
        protected int[,] matrizUno,matrizDos, matrizTres;
        protected float[,] matrizDet;
        protected int a=0, b, c=0, d=0,m,n,i,j,p;
        protected float pp;
        protected float[] det,det1;
        protected string respuesta = "";
        protected void llenado(int n, int m)
        {
            Console.WriteLine("Matriz uno");
            matrizUno = new int[n, m];
            for (int i =0;i< n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Ingrese el valor para la posicion {0},{1} ", i, j);
                    matrizUno[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        protected void llenadoDos(int n,int m)
        {
            Console.Clear();
            Console.WriteLine("Matriz 2\n");

            matrizDos = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Ingrese el valor para la posicion {0},{1} ", i, j);
                    matrizDos[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        protected void llenadoTres()
        {
            Console.Write("Ingrese las  dimensiones de su matriz dos: ");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            matrizTres = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Ingrese el valor para la posicion {0},{1} ", i, j);
                    matrizTres[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        protected void mostrar(int n, int m,int[,] matriz)
        {
            Console.Clear();
            Console.WriteLine("Mostrando resultado... ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" [{0}] ", matriz[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
    class ejercicio1:varGeneral
    {
        public void inicio()
        {
            Console.Write("Ingrese las  dimensiones de su matriz: ");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            llenado(n,m);
            mostrar(n,m,matrizUno);
        }
    }
    class ejercicio2:varGeneral

    {
        public void inicio()
        {
            Console.Write("Ingrese las  dimensiones de su matriz: ");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            llenado(n,m);
            d = 1;
            for (int ed = 0; ed < n; ed++)
            {
                d = matrizUno[i, j] * d;
                i++;
                j++;
            }

            Console.WriteLine("La diagonal principal es es: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == j)
                    {
                        Console.Write("[ {0} ]", matrizUno[i, j]);
                    }
                    else Console.Write("[    ]");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("La suma de la diagonal principal es:" + d);
        }
    }

    class ejercicio4 : varGeneral
    {
        public void inicio()
        {
            Console.Write("Digite la dimension de su matriz: ");
            n = int.Parse(Console.ReadLine());
            matrizUno = new int[n, n];
            for (int i =0;i< n; i++)
            {
                for(int j =0;j< n; j++)
                {
                    if(i == j) matrizUno[i, j] = 1;

                }
            }
            mostrar(n,n,matrizUno);
        }
    }
    class ejercicio5:varGeneral
    {
        public void inicio()
        {
            Console.Write("Ingrese la dimension de su matriz: ");
            n = int.Parse(Console.ReadLine());
           
           
            llenado(n,n);
            llenadoDos(n,n);
            matrizTres = new int[n, n];
            for(int t = 0; t < n; t++)
            {
                for (int e = 0; e < n; e++)
                {
                    matrizTres[t, e] = matrizUno[t, e] + matrizDos[t, e];
                }
            }
            mostrar(n, n, matrizTres);
        }
    }
    class ejercicio6:varGeneral
    {
        public void inicio()
        {
            Console.WriteLine("Multiplicacion de matrices donde Mm x n * Mn x p = M m x p");
            Console.Write("Ingrese la dimension m de su matriz uno: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la dimension n de sus matrices: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la dimension p de su matriz dos: ");
            p = int.Parse(Console.ReadLine());

            llenado(m, n);
            llenadoDos(n, p);
            matrizTres = new int[m, p];
            for(int fl =0;fl< m; fl++)
            {
                for(int cl =0;cl< p; cl++)
                {
                    for (int aux = 0; aux < p; aux++)
                    {
                        matrizTres[fl, cl] = matrizUno[fl, aux] * matrizDos[aux, cl] + matrizTres[fl, cl];
                    }
                }
            }
            mostrar(m, p, matrizTres);
        }
    }
    class ejercicio7 : varGeneral
    {
        public void inicio()
        {
            Console.Write("Ingrese la dimension m, n de su matriz uno: ");
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            llenado(m, n);
        
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" [{0}] ", matrizUno[j, i]);
                }
                Console.WriteLine();
            }
        }
    }
   
    class ejercicio9 : varGeneral
    {
        int[] vector;
        public void inicio()
        {
            
            Console.Write("Ingrese la dimension m, n de su matriz uno: ");
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            vector = new int[n * m];
            llenado(m, n);
            //matriz a vector
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    vector[a] = matrizUno[i, j];
                    a++;
                }
            }
            burbuja();
            //vector a matriz
            for (int i = 0; i < m*n; i++)
            {
                if (c == n)
                {
                    c = 0;
                    d++;
                }
                if (d <= m)
                {

                    matrizUno[d, c] = vector[i];
                }
                c++;
            }
            mostrar(m,n,matrizUno);
        }
        private void burbuja()
        {
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        b = vector[j + 1];
                        vector[j + 1] = vector[j];
                        vector[j] = b;

                    }
                }
            }
        }
    }


    class ejercicio12 : varGeneral
    {
        public void inicio()
        {
            Console.Write("Ingrese la dimension m, n de su matriz uno: ");
            m = int.Parse(Console.ReadLine());
            matrizUno = new int[m, m];
            for (int q =0;q< m; q++)
            {
                for (int w = 0; w < m; w++)
                {
                    if(w%2 != 0)
                    {
                        matrizUno[q, w] = 0;
                    }
                    else
                    {
                        matrizUno[q, w] = 1;
                    }
                }
            }
            mostrar(m, m, matrizUno);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            menu uu = new menu();
            uu.getMenu();

            Console.ReadKey();
        }
    }
}
