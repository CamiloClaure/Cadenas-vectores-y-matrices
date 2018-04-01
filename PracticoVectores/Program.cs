using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoVectores
{
    public class menu
    {
        int op;
        string respuesta = "";
        public void getMenu()
        {
            Console.Clear();
            try {
                Console.WriteLine("Ingrese un numero del 1 al 12 para ir al respectivo ejercicio, 13 para salir");
                op = int.Parse(Console.ReadLine());
            } catch { getMenu(); }
            
            switch (op)
            {
                case 1:
                    ejercicio1 aa = new ejercicio1();
                    aa.llenar();
                    aa.mostrar();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 1; }
                    else getMenu();
                    break;
                case 2:
                    ejercicio2 ab = new ejercicio2();
                    ab.llenar();
                    ab.mostrar();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 2; }
                    else getMenu();
                    break;
                case 3:
                    ejercicio3 ac = new ejercicio3();
                    ac.llenar();
                    ac.mostrar();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 3; }
                    else getMenu();
                    break;
                case 4:
                    ejercicio4 ad = new ejercicio4();
                    ad.llenar();
                    ad.mostrar();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 4; }
                    else getMenu();
                    break;
                case 5:
                    ejercicio5 ae = new ejercicio5();
                    ae.llenar();
                    ae.mostrar();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 5; }
                    else getMenu();
                    break;
                case 6:
                    ejercicio6 af = new ejercicio6();
                    af.llenar();
                    af.mostrar();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 6; }
                    else getMenu();
                    break;
                case 7:
                    ejercicio7 ag = new ejercicio7();
                    ag.llenar();
                    ag.mostrar();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 7; }
                    else getMenu();
                    break;
                case 8:
                    ejercicio8 ah = new ejercicio8();
                    ah.llenar();
                    
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 8; }
                    else getMenu();
                    break;
                case 9:
                    ejercicio9 ai = new ejercicio9();
                    ai.llenar();
                    ai.mostrar();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 9; }
                    else getMenu();
                    break;
                case 10:
                    ejercicio10 aj = new ejercicio10();
                    aj.llenar();
                    aj.mostrar();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 10; }
                    else getMenu();
                    break;
                case 11:
                    ejercicio11 ak = new ejercicio11();
                    ak.llenar();
                    ak.mostrar();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 11; }
                    else getMenu();
                    break;
                case 12:
                    ejercicio12 al = new ejercicio12();
                    al.llenar();
                    al.mostrar();
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
    public class general
    {
        protected int[] a, b, c;
        protected string[] name;
        protected int n, x, y, d, e;
        protected int bimoda, moda = 0, veces = 0;
        protected bool existe = false;
    }
    public class ejercicio1 : general
    {

        public ejercicio1()
        {

        }
        public void llenar()
        {
            Console.Write("Algoritmo de suma de vectores ");
            Console.Write("Digite los valores para sus vectores: ");
            n = int.Parse(Console.ReadLine());
            a = new int[n];
            b = new int[n];
            c = new int[n];
        Again:
           
            try
            {
                
                Console.WriteLine("\nDigite los valores para el primer vector");
              

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Valor {0}: ", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nDigite los valores para el segundo vector");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Valor {0}: ", j + 1);
                    b[j] = int.Parse(Console.ReadLine());
                }
                for (int k = 0; k < n; k++)
                {
                    c[k] = a[k] + b[k];

                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error intentelo otra vez");
                goto Again;
            }

        }
        public void mostrar()
        {
            for (int i = 0; i < n; i++) Console.WriteLine(a[i] + " + " + b[i] + " = " + c[i]);
        }
    }
    public class ejercicio2 : general
    {
        public ejercicio2()
        {

        }
        public void llenar()
        {
            int k = 0;
            try
            {
                Console.Write("Algoritmo para invertir un vector ");
                Console.Write("Digite los valores para su vector: ");
                n = int.Parse(Console.ReadLine());
                a = new int[n];

                Console.WriteLine("\nDigite los valores para el primer vector");
                for (int i = n - 1; i >= 0; i--)
                {
                    ++k;
                    Console.Write("Valor {0}: ", k);
                    a[i] = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Error intentelo otra vez");
                llenar();
            }


        }
        public void mostrar()
        {
            Console.WriteLine("El vector invertido");
            for (int i = 0; i < n; i++) Console.Write(a[i] + " ");
        }

    }
    public class ejercicio3 : general
    {
        public ejercicio3()
        {

        }
        public void llenar()
        {
            int k = 0;
            Console.Write("Algoritmo operarios y sus sueldos ");
            try
            {
                
                Console.Write("Digite los valores para sus vectores: ");
                n = int.Parse(Console.ReadLine());
                a = new int[n];
                name = new string[n];

                Console.WriteLine("\nDigite los valores para el nombre y sueldo");
                for (int i = 0; i < n; i++)
                {
                    ++k;
                    Console.Write("Nombre {0}: ", k);
                    name[i] = Console.ReadLine();
                    Console.WriteLine("Sueldo {0}: ", k);
                    a[i] = int.Parse(Console.ReadLine());

                }
            }
            catch
            {
                Console.WriteLine("Error intentelo otra vez");
                llenar();
            }

        }
        public void mostrar()
        {
            d = a[0];
            for (int j = 0; j < n; j++)
            {
                if (d <= a[j]) e = j;
            }
            Console.WriteLine("El sujeto con mayor sueldo es: " + name[e] + " y su sueldo es: " + a[e]);
        }

    }
    public class ejercicio4 : general
    {
        public ejercicio4()
        {

        }
        public void llenar()
        {
            Console.Write("Algoritmo de resta de vectores ");
            try
            {
                Console.Write("Digite los valores para sus vectores: ");
                n = int.Parse(Console.ReadLine());
                a = new int[n];
                b = new int[n];
                c = new int[n];
                Console.WriteLine("\nDigite los valores para el primer vector");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Valor {0}: ", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nDigite los valores para el segundo vector");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Valor {0}: ", j + 1);
                    b[j] = int.Parse(Console.ReadLine());
                }
                for (int k = 0; k < n; k++)
                {
                    c[k] = a[k] - b[k];

                }
            }
            catch
            {
                Console.WriteLine("Error intentelo otra vez");
                llenar();
            }

        }
        public void mostrar()
        {
            for (int i = 0; i < n; i++) Console.WriteLine(a[i] + " - " + b[i] + " = " + c[i]);
        }
    }
    public class ejercicio5 : general
    {
        public ejercicio5()
        {

        }
        public void llenar()
        {
            Console.Write("Algoritmo de moda de un vector ");
            try
            {
                Console.Write("Digite los valores para su vector: ");
                n = int.Parse(Console.ReadLine());
                a = new int[n];

                Console.WriteLine("\nDigite los valores para el primer vector");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Valor {0}: ", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                }
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (a[j] == a[k])
                        {
                            x += 1;
                            y = a[j];
                        }
                    }
                    if (veces < x)
                    {
                        moda = y;
                        veces = x;

                    }
                    else if (veces == x && moda != y)
                    {
                        bimoda = y;
                        existe = true;

                    }
                    x = 0;
                }
            }
            catch
            {
                Console.WriteLine("Error intentelo otra vez");
                llenar();
            }

        }
        public void mostrar()
        {
            // for (int i = 0; i < n; i++) Console.WriteLine(a[i] + " + " + b[i] + " = " + c[i]);
            if (existe)
            {
                Console.WriteLine("El vector es bimodal con valores: " + moda + " y " + bimoda + " y aparecen " + veces + " veces");
            }
            else Console.WriteLine("La moda es: " + moda + " y aparece " + veces + " veces");

        }

    }
    public class ejercicio6 : general
    {
        public ejercicio6() { }
        public void llenar()
        {
            Console.Write("Algoritmo de fusion de vectores ");
            try
            {
                Console.Write("Digite los valores para su vector 1 : ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Digite los valores para su vector 2: ");
                e = int.Parse(Console.ReadLine());
                a = new int[n];
                b = new int[e];
                c = new int[n + e];
                Console.WriteLine("\nDigite los valores para el primer vector");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Valor {0}: ", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nDigite los valores para el segundo vector");
                for (int j = 0; j < e; j++)
                {
                    Console.Write("Valor {0}: ", j + 1);
                    b[j] = int.Parse(Console.ReadLine());
                }
                for (int k = 0; k < (n + e); k++)
                {
                    if (k < n)
                    {
                        c[k] = a[k];
                    }
                    else c[k] = b[k - n];
                }
            }
            catch
            {
                Console.WriteLine("Error intentelo otra vez");
                llenar();
            }

        }
        public void mostrar()
        {
            for (int i = 0; i < (n + e); i++) Console.Write(c[i] + ", ");
        }
    }
    public class ejercicio7 : general
    {
        private void insercion()
        {
            int aux;
            int j;
            for (int i = 0; i < a.Length; i++)
            {
                aux = a[i];
                j = i - 1;
                while (j >= 0 && a[j] > aux)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = aux;
            }
        }
        private void shellsort()
        {
            int salto = 0;
            int sw = 0;
            int aux = 0;
            int e = 0;
            salto = a.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (a.Length - salto))
                    {
                        if (a[e - 1] > a[(e - 1) + salto])
                        {
                            aux = a[(e - 1) + salto];
                            a[(e - 1) + salto] = a[e - 1];
                            a[(e - 1)] = aux;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
        }
        private void burbuja()
        {
            int t;
            for (int i = 1; i < a.Length; i++)
                for (int b = a.Length - 1; b >= i; b--)
                {
                    if (a[b - 1] > a[b])
                    {
                        t = a[b - 1];
                        a[b - 1] = a[b];
                        a[b] = t;
                    }
                }
        }
        private void quicksort(int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = a[central];
            i = primero;
            j = ultimo;
            do
            {
                while (a[i] < pivote) i++;
                while (a[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(primero, j);
            }
            if (i < ultimo)
            {
                quicksort(i, ultimo);
            }

        }
        private void directSelection()
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                if (i != min)
                {
                    int aux = a[i];
                    a[i] = a[min];
                    a[min] = aux;
                }
            }
        }
        public void llenar()
        {
            Console.Write("Algoritmo de ordenamiento de un vector ");
            try
            {
                Console.Write("Digite los valores para sus vectores: ");
                n = int.Parse(Console.ReadLine());
                a = new int[n];

                Console.WriteLine("\nDigite los valores para el primer vector");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Valor {0}: ", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                }
                menuOrdn();
            }
            catch
            {
                Console.WriteLine("Error intentelo otra vez");
                llenar();
            }


        }
        private void menuOrdn()
        {
            Console.Clear();
            int op;
            Console.WriteLine("Por que metodo quiere ordenar? \n1. Insercion\n2. Shell sort\n3. Burbuja\n4. Quick sort\n5. Seleccion directa");
            try
            {
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        insercion();
                        break;
                    case 2:
                        shellsort();
                        break;
                    case 3:
                        burbuja();
                        break;
                    case 4:
                        quicksort(0, n - 1);
                        break;
                    case 5:
                        directSelection();
                        break;
                    default:
                        menuOrdn();
                        break;
                }

            }
            catch
            {
                Console.WriteLine("Error intentelo otra vez");
                menuOrdn();
            }
        }
        public void mostrar()
        {
            
            for (int i = 0; i < n; i++) Console.WriteLine(a[i]);
        }
    }
    public class ejercicio8 : general
    {
        public void llenar()
        {
            Console.Write("Algoritmo de busqueda de un elemento en un vector ");
            try
            {
                Console.Write("Digite los valores para sus vectores: ");
                n = int.Parse(Console.ReadLine());
                a = new int[n];

                Console.WriteLine("\nDigite los valores para el primer vector");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Valor {0}: ", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Digite el numero que desea encontrar en el arreglo: ");
                d = Convert.ToInt32(Console.ReadLine());
                insercion();
                menuBusqueda();
            }
            catch
            {
                Console.WriteLine("Error intentelo otra vez");
                llenar();
            }

        }
        private void insercion()
        {
            int aux;
            int j;
            for (int i = 0; i < a.Length; i++)
            {
                aux = a[i];
                j = i - 1;
                while (j >= 0 && a[j] > aux)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = aux;
            }
        }

        private void binaria()
        {
            int l = 0, h = n;
            int m = 0;

            while (l <= h && existe == false)
            {
                m = (l + h) / 2;
                if (a[m] == d)
                    existe = true;
                if (a[m] > d)
                    h = m - 1;
                else
                    l = m + 1;
            }
            for (int u = 0; u < n; u++)
            {
                Console.Write(a[u] + " ");
            }
            if (existe == false)
            { Console.Write("\nEl elemento {0} no esta en el arreglo", d); }
            else
            { Console.Write("\nEl elemento {0} esta en la posicion: {1}", d, m + 1 + " despues de ordenarlo"); }
        }
        private void secuencial()
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == d)
                {
                    x = i;
                    existe = true;
                }
            }
            for (int u = 0; u < n; u++)
            {
                Console.Write(a[u] + " ");
            }
            if (existe)
            {
                Console.WriteLine("El numero {0} existe en la posicion {1} ", d, (x + 1) + " despues de ordenarlo");
            }
            else Console.WriteLine("El numero {0} no existe en el arreglo ", d);
        }
        private void menuBusqueda()
        {
            Console.Clear();
            int op;
            Console.WriteLine("Por que metodo quiere ordenar? \n1. Binaria\n2. Secuencial");
            try
            {
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        binaria();
                        break;
                    case 2:
                        secuencial();
                        break;
                    case 3:

                        menuBusqueda();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Error intentelo otra vez");
                menuBusqueda();
            }
        }
    }
    public class ejercicio9 : general
        {
            public void llenar()
            {
                int act, ant1 = 0, ant2 = 1;
            Console.Write("Algoritmo de serie de Fibonacci en un vector ");
            try
                {
                    Console.Write("Digite los valores para sus vectores: ");
                    n = int.Parse(Console.ReadLine());
                    a = new int[n];
                    a[0] = 0;
                    a[1] = 1;
                    for (int i = 0; i < (n - 2); i++)
                    {
                        act = ant1 + ant2;
                        ant1 = ant2;
                        ant2 = act;
                        a[i + 2] = act;
                        
                    }
                }
                catch
                {
                    Console.WriteLine("Error intentelo otra vez");
                    llenar();
                }


            }
            public void mostrar()
            {
                Console.Write("La serie es: ");
                for (int i = 0; i < n; i++) Console.Write(a[i] + " ");
            }

        }
    public class ejercicio10 : general
        {

            public void llenar()
            {
            Console.Write("Algoritmo de numeros pares en un vector ");
            try
                {
                    Console.Write("Digite los valores para sus vectores: ");
                    n = int.Parse(Console.ReadLine());
                    a = new int[n];

                    Console.WriteLine("\nDigite los valores para el primer vector");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Valor {0}: ", i + 1);
                        a[i] = int.Parse(Console.ReadLine());
                    }
                }
                catch
                {
                    Console.WriteLine("Error intentelo otra vez");
                    llenar();
                }


            }
            private int calcular()
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[j] % 2 == 0) x++;
                }


                return x;
            }
            public void mostrar()
            {
                y = calcular();
                Console.WriteLine("La cantidad de numeros pares es " + y);
            }
        }
    public class ejercicio11 : general
        {

            public void llenar()
            {
            Console.Write("Algoritmo de numeros negativos en un vector ");
            try
                {
                    Console.Write("Digite los valores para sus vectores: ");
                    n = int.Parse(Console.ReadLine());
                    a = new int[n];

                    Console.WriteLine("\nDigite los valores para el primer vector");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Valor {0}: ", i + 1);
                        a[i] = int.Parse(Console.ReadLine());
                    }
                }
                catch
                {
                    Console.WriteLine("Error intentelo otra vez");
                    llenar();
                }


            }
            private int calcular()
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[j] < 0) x++;

                }


                return x;
            }
            public void mostrar()
            {
                y = calcular();
                Console.WriteLine("La cantidad de numeros negativos es " + y);
            }
        }
    public class ejercicio12 : general
        {

            public void llenar()
            {
            Console.Write("Algoritmo de numeros pares y negativos en un vector ");
            try
                {
                    Console.Write("Digite los valores para sus vectores: ");
                    n = int.Parse(Console.ReadLine());
                    a = new int[n];

                    Console.WriteLine("\nDigite los valores para el primer vector");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Valor {0}: ", i + 1);
                        a[i] = int.Parse(Console.ReadLine());
                    }
                }
                catch
                {
                    Console.WriteLine("Error intentelo otra vez");
                    llenar();
                }


            }
            private int calcular()
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[j] % 2 == 0 && a[j] < 0) x++;
                }


                return x;
            }
            public void mostrar()
            {
                y = calcular();
                Console.WriteLine("La cantidad de numeros pares y negativos es " + y);
            }
        }

    class Program
        {
            static void Main(string[] args)
            {

                menu x = new menu();
                x.getMenu();
               // x.mostrar();

                Console.ReadKey();
            }
        }
    
}
