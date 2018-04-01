using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantalla/*practco de los 25*/
{   public class menu
    {
        int op;
        string respuesta = "";
        public void getMenu()
        {
            try {
                Console.Clear();
                Console.WriteLine("Ingrese un numero del 1 al 25 para ir al respectivo ejercicio, 26 para salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        fibonacci aa = new fibonacci();
                        Console.WriteLine(aa.getSerie());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 1; }
                        else getMenu();
                        break;
                    case 2:
                        ejercicio2 ab = new ejercicio2();
                        Console.WriteLine(ab.getEjercicio2());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 2; }
                        else getMenu();
                        break;
                    case 3:
                        ejercicio3 ac = new ejercicio3();
                        Console.WriteLine(ac.getEjercicio3());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 3; }
                        else getMenu();
                        break;
                    case 4:
                        ejercicio4 ad = new ejercicio4();
                        Console.WriteLine(ad.getEjercicio4());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 4; }
                        else getMenu();
                        break;
                    case 5:
                        ejercicio5 ae = new ejercicio5();
                        Console.WriteLine(ae.getEjercicio5());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 5; }
                        else getMenu();
                        break;
                    case 6:
                        ejercicio6 af = new ejercicio6();
                        Console.WriteLine(af.getEjercicio6());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 6; }
                        else getMenu();
                        break;
                    case 7:
                        ejercicio7 ag = new ejercicio7();
                        Console.WriteLine(ag.getEjercicio7());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 7; }
                        else getMenu();
                        break;
                    case 8:
                        ejercicio8 ah = new ejercicio8();
                        Console.WriteLine(ah.getEjercicio8());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 8; }
                        else getMenu();
                        break;
                    case 9:
                        ejercicio9 ai = new ejercicio9();
                        Console.WriteLine(ai.getEjercicio9());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 9; }
                        else getMenu();
                        break;
                    case 10:
                        ejercicio10 aj = new ejercicio10();
                        Console.WriteLine(aj.getEjercicio10());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 10; }
                        else getMenu();
                        break;
                    case 11:
                        ejercicio11 ak = new ejercicio11();
                        Console.WriteLine(ak.getEjercicio11());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 11; }
                        else getMenu();
                        break;
                    case 12:
                        ejercicio12 al = new ejercicio12();
                        Console.WriteLine(al.getEjercicio12());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 12; }
                        else getMenu();
                        break;
                    case 13:
                        ejercicio13 am = new ejercicio13();
                        Console.WriteLine(am.getEjercicio13());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 13; }
                        else getMenu();
                        break;
                    case 14:
                        ejercicio14 an = new ejercicio14();
                        Console.WriteLine(an.getEjercicio14());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 14; }
                        else getMenu();
                        break;
                    case 15:
                        ejercicio15 ao = new ejercicio15();
                        Console.WriteLine(ao.getEjercicio15());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 15; }
                        else getMenu();
                        break;
                    case 16:
                        ejercicio16 ap = new ejercicio16();
                        Console.WriteLine(ap.getEjercicio16());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 16; }
                        else getMenu();
                        break;
                    case 17:
                        ejercicio17 aq = new ejercicio17();
                        Console.WriteLine(aq.getEjercicio17());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 17; }
                        else getMenu();
                        break;
                    case 18:
                        ejercicio18 ar = new ejercicio18();
                        Console.WriteLine(ar.getEjercicio18());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 18; }
                        else getMenu();
                        break;
                    case 19:
                        ejercicio19 aas = new ejercicio19();
                        Console.WriteLine(aas.getEjercicio19());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 19; }
                        else getMenu();
                        break;
                    case 20:
                        ejercicio20 at = new ejercicio20();
                        Console.WriteLine(at.getEjercicio20());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 20; }
                        else getMenu();
                        break;
                    case 21:
                        ejercicio21 au = new ejercicio21();
                        Console.WriteLine(au.getEjercicio21());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 21; }
                        else getMenu();
                        break;
                    case 22:
                        ejercicio22 av = new ejercicio22();
                        Console.WriteLine(av.getEjercicio22());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 22; }
                        else getMenu();
                        break;
                    case 23:
                        ejercicio23 ax = new ejercicio23();
                        Console.WriteLine(ax.getEjercicio23());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 23; }
                        else getMenu();
                        break;
                    case 24:
                        ejercicio24 ay = new ejercicio24();
                        Console.WriteLine(ay.getEjercicio24());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 24; }
                        else getMenu();
                        break;
                    case 25:
                        ejercicio25 az = new ejercicio25();
                        Console.WriteLine(az.getEjercicio25());
                        Console.WriteLine("Desea continuar? S o N?");
                        respuesta = Console.ReadLine();
                        if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 25; }
                        else getMenu();
                        break;
                    case 26:
                        break;
                    default:
                        getMenu();
                        break;
                }
            } catch
            {
                Console.WriteLine("Entrada invalida, presione una tecla para continuar");
                Console.ReadKey();
                getMenu();

            }
            
           
        }
    }
    public class general
    {
        protected int s, b, d, e, f = 0;
        protected string var, a;
        protected int c = 1;
        protected int i = 0, j = 0;
        protected string x, y;
        protected int[] n = new int[20];
       protected bool flag;
        protected string varInicial()
        {
            Console.WriteLine("Digite el numero que desee");
            var = Console.ReadLine();
            return var;
        }
        protected void procedimientoGeneral(string a)
        {
            try { } catch { }
                b = int.Parse(a);
                c = a.Length;
                s = a.Length;
                do
                {

                    n[s] = b % 10;
                    b = b / 10;
                    s--;
                } while (s > 0);
         
        }
    }
    public class fibonacci
    {
        int ant1 = 0;
        int i = 0;
        int ant2 = 1;
        int act = 0;
        int n = 0;
        bool f;
        public fibonacci()
        {
            do {
                try
                {
                    do {
                        Console.WriteLine("Digite un valor para la serie fibonacci, solo MAYORES o igual a 3");
                        this.n = int.Parse(Console.ReadLine());
                    } while (n <=3);
                    
                    f = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("FATAL ERROR!!!");
                    f = true;
                }
            } while (f == true);
            
            
        }
        
        public string getSerie()
        {
            Console.WriteLine("0");
            Console.WriteLine("1");
           
            for (; i < (n - 2); i++)
            {
                act = ant1 + ant2;
                ant1 = ant2;
                ant2 = act;
                Console.WriteLine(act);
            }
            return "";
        }

    }
    public class ejercicio2
    {//El siguiente algoritmo muestra la serie 122333NNNN...
        int a, i, j,n;
        bool f;

        public ejercicio2()
        {
            do { try
                {
                    do
                    {
                        Console.WriteLine("Digite un valor para la serie 122333NNNN...");
                        n = int.Parse(Console.ReadLine());
                        this.a = n;
                    } while (a <= 0);
                    //
                    
                    f = false;
                } catch {
                    Console.Clear();
                    Console.WriteLine("FATAL ERROR!!!");

                    f = true;
                } } while (f == true);
           
        }
        
        public string getEjercicio2()
        {
            for (i = 1; i <= a; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
            }
            return "";
        }
    }
    public class ejercicio3 : general
    {//El siguiente algoritmo muestra el ultimo digito de un numero

        public ejercicio3()
        {
         do {
                try
                {
                    Console.WriteLine("El siguiente algoritmo muestra el ultimo digito de un numero");
                    this.a = varInicial();
                    flag = false;

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("FATAL ERROR!!!");
                    flag = true;
                }
            } while (flag == true);
           
        }
        private void setEjercicio3()
        {

        }
        public int getEjercicio3()
        {
            d = int.Parse(a);
            do
            {
                b = d % 10;
                c = b;
            } while (c > 10);
            Console.Write("El ultimo digito es: ");
            return c;
        }
    }
    public class ejercicio4 : general
    {//"El siguiente algoritmo cuenta los digitos del numero introducido"
        
        public ejercicio4()
        {
            do
            {
                try
                {
                    Console.WriteLine("El siguiente algoritmo cuenta los digitos del numero introducido");
                    this.a = varInicial();
                    flag = false;

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("FATAL ERROR!!!");
                    flag = true;
                }
            } while (flag == true);
            
        }
        private void setEjercicio4()
        {

        }
        public int getEjercicio4()
        {

            c = a.Length;
            Console.Write("La cantidad de digitos es: ");
            return c;
        }
    }
    public class ejercicio5 : general
    {//"El siguiente algoritmo verifica si todos los digitos son iguales o no"

        public ejercicio5()
        {
            do
            {
                try
                {
                    Console.WriteLine("El siguiente algoritmo verifica si todos los digitos son iguales o no");

                    this.a = varInicial();
                    flag = false;

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("FATAL ERROR!!!");
                    flag = true;
                }
            } while (flag == true);
           
        }
        private void setEjercicio5()
        {
        }
        public string getEjercicio5()
        {
            procedimientoGeneral(a);
            for (int j = 1; j < c; j++)
            {
                if (n[j] != n[j + 1]) d++;

            }
            if (d == 0)
            {
                Console.WriteLine("SON IGUALES");
            }
            else Console.WriteLine("SON DISTINTOS");
            return "";
        }
    }
    public class ejercicio6 : general
    {//El siguiente algoritmo muestra cantidad de digitos pares e impares"

        public ejercicio6()
        {
            do
            {
                try
                {
                    Console.WriteLine("El siguiente algoritmo muestra cantidad de digitos pares e impares");

                    this.a = varInicial();
                    flag = false;

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("FATAL ERROR!!!");
                    flag = true;
                }
            } while (flag == true);
           
        }
        private void setEjercicio6()
        {

        }
        public string getEjercicio6()
        {
            procedimientoGeneral(a);

            for (int j = 1; j <= c; j++)
            {
                if (n[j] % 2 == 0) d++;
                else b++;

            }


            Console.WriteLine("Contiene " + d + " digitos pares y " + b + " digitos impares");
            return "";
        }
    }
    public class ejercicio7 : general
    {
        //El siguiente algoritmo realiza la sumatoria de los digitos del numero introducido
        public ejercicio7()
        {
            do
            {
                try
                {
                    Console.WriteLine("El siguiente algoritmo realiza la sumatoria de los digitos del numero introducido");

                    this.a = varInicial();
                    flag = false;

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("FATAL ERROR!!!");
                    flag = true;
                }
            } while (flag == true);
            
        }
        private void setEjercicio7()
        {

        }
        public string getEjercicio7()
        {
            procedimientoGeneral(a);

            for (int j = 1; j <= c; j++)
            {
                d = d + n[j];
            }
            Console.WriteLine("La suma es " + d);
            return "";
        }
    }
    public class ejercicio8 : general
    {
        //"Este algoritmo requiere 8 numeros y sumara los positivos y multiplicara los negativos"
        int[] t = new int[20];
       
        public string getEjercicio8()
        {
            Console.WriteLine("Este algoritmo requiere 8 numeros y sumara los positivos y multiplicara los negativos");

            Console.WriteLine("Ingrese 8 valores");
            do
            {
                try
                {
                    for (; i < 8; i++)
                    {
                        Console.WriteLine("Ingrese valor {0}:",(i+1));
                        n[i] = int.Parse(Console.ReadLine());
                    }
                    flag = false;

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("FATAL ERROR!!!");
                    flag = true;
                }
            } while (flag == true);
            
           

            for (int j = 0; j < 8; j++)
            {
                if (n[j] >= 0)
                {
                    b = b + n[j];
                }
                else
                {
                    c = c * n[j];
                }
            }
            Console.WriteLine("La suma de los positivos es: " + b + " y la multiplicacion de los negativos es: " + c);
            return "";
        }
    }
    public class ejercicio9 : general
    {//"El siguiente algoritmo elimina los dos ultimos digitos de un numero"
        public ejercicio9() { }

        private void setEjercicio9()
        {

        }
        public string getEjercicio9()
        {
            do
            {
                try
                {
                    flag = false;

                }
                catch
                {
                    Console.WriteLine("FATAL ERROR!!!");
                    flag = true;
                }
            } while (flag == true);
            Console.WriteLine("El siguiente algoritmo elimina los dos ultimos digitos de un numero");

            Console.WriteLine("Digite el numero que desee");
        
            return "";
        }
    }
    public class ejercicio10 : general
    {//Verifica si un numero es ascendente o no
        public ejercicio10()
        {
            Console.WriteLine("El siguiente algoritmo verifica si un numero esta en orden ascendente");

            this.a = varInicial();
            do
            {
                try
                {
                Again:
                    a = Console.ReadLine();
                    b = int.Parse(a);
                    c = a.Length;
                    if (c <= 2)
                    {
                        Console.Clear();
                        Console.WriteLine("El numero tiene que ser mayor  de 2 cifras, ingrese otra vez");
                        goto Again;
                    }
                    else
                    {

                        do
                        {
                            i++;
                            b = b / 10;

                        } while (i < 2);
                        Console.WriteLine("El resutlado es: " + b);


                    }
                    flag = false;

                }
                catch
                {
                    Console.WriteLine("FATAL ERROR!!!");
                    flag = true;
                }
            } while (flag == true);
            
        }
        private void setEjercicio10()
        {

        }
        public string getEjercicio10()
        {
            procedimientoGeneral(a);
            for (int j = 1; j < c; j++) if (n[j] < n[j + 1]) d++;
            if (d == 0) return "No es ascendente";
            else return "Es ascendente";
        }
    }
    public class ejercicio11 : general
    {//muestra los numeros mayores y menores a 5
        public ejercicio11()
        {
            do
            {
                try
                {
                    flag = false;

                }
                catch
                {
                    Console.WriteLine("FATAL ERROR!!!");
                    flag = true;
                }
            } while (flag == true);
            Console.WriteLine("Este algoritmo separa los digitos menores a 5 en un numero y los mayores o iguales en otro");

            this.a = varInicial();
        }
        private void setEjercicio11()
        {

        }
        public string getEjercicio11()
        {
            procedimientoGeneral(a);

            do
            {
                i++;
                if (n[i] < 5) x = x + n[i];

                else y = y + n[i];

            } while (i < c);
            Console.WriteLine("Los digitos menores a 5 son: " + x);
            Console.WriteLine("Los digitos mayores o iguales a 5 son: " + y);
            return "";
        }
    }
    public class ejercicio12 : general
    {//compara los digitos de un numero con otro numero introducido por teclado
        public ejercicio12()
        {

        }
        private void setEjercicio12()
        {

        }
        public string getEjercicio12()
        {

            Console.WriteLine("Este algoritmo muestra cuantos digitos son iguales a un valor introducido por teclado");

            Console.WriteLine("Digite el numero que desee");
            a = Console.ReadLine();
            Console.WriteLine("Digite el numero que quiera comparar, si ingresa un numero negativo se tomara su Abs");
            e = Math.Abs( int.Parse(Console.ReadLine()));
            b = int.Parse(a);
            c = a.Length;
            do
            {
                i++;
                j = b % 10;
                b = b / 10;
                if (j == e) d++;
                else f++;

            } while (i < c);
            Console.Write("El numero contiene " + d + " digitos iguales a " + e);
            Console.WriteLine(" y " + f + " digitos diferentes a " + e);
            return "";
        }
    }
    public class ejercicio13 : general
    {//Ingrese un numero para sacerle su cuadrado y cubo
        public ejercicio13()
        {
            Console.WriteLine("Ingrese un numero para sacerle su cuadrado y cubo");

            this.a = varInicial();
        }
        private void setEjercicio13()
        {

        }
        public string getEjercicio13()
        {
            e = int.Parse(a);
            c = e * e;
            d = e * e * e;

            return "El cuadrado del numero es: " + c + " y su cubo es: " + d;
        }
    }
    public class ejercicio14
    {//Area de figuras

        public ejercicio14()
        {

        }
        private void setEjercicio14()
        {

        }
        public string getEjercicio14()
        {
            int op, a, b, r = 0;
            double A = 0;

            const double pi = 3.14;
            Console.WriteLine("Bienvenido, elija la figura a la que le quiere calcular el area\n1. Cuadrado\n2. Rectangulo\n3. triangulo\n4. Trapecio\n5. Circulo");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Seleccionó cuadrado, ingrese el valor su arista, si ingresa negativo se tomara en cuenta su Abs");
                    a = Math.Abs(int.Parse(Console.ReadLine()));
                    A = a * a;
                    Console.WriteLine("El area del cuadrado es: " + A);

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Seleccionó cuadrado, ingrese el valor su arista");
                    a = Math.Abs(int.Parse(Console.ReadLine()));
                    b = Math.Abs(int.Parse(Console.ReadLine()));
                    A = a * b;
                    Console.WriteLine("El area del rectangulo es: " + A);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Seleccionó triangulo, ingrese el valor su base y altura");
                    a = Math.Abs(int.Parse(Console.ReadLine()));
                    b = Math.Abs(int.Parse(Console.ReadLine()));
                    A = (a * b) / 2;
                    Console.WriteLine("El area del triangulo es: " + A);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Seleccionó trapecio, ingrese el valor sus dos bases y altura, respectivamente");
                    a = Math.Abs(int.Parse(Console.ReadLine()));
                    b = Math.Abs(int.Parse(Console.ReadLine()));
                    r = Math.Abs(int.Parse(Console.ReadLine()));
                    A = (((a + b)) * r) / 2;
                    Console.WriteLine("El area del trapecio es: " + A);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Seleccionó circulo, ingrese el valor su radio");
                    r = Math.Abs(int.Parse(Console.ReadLine()));
                    A = pi * r * r;
                    Console.WriteLine("El area del circulo es: " + A);
                    break;
                default:
                    Console.Clear();
                    getEjercicio14();
                    break;
            }
            return "";
        }
    }
    public class ejercicio15 : general
    {//Ingrese el numero del que quiera saber su tabla de multiplicar
        public ejercicio15()
        {
            Console.WriteLine("Ingrese el numero del que quiera saber su tabla de multiplicar");

            this.a = varInicial();
        }
        private void setEjercicio15()
        {

        }
        public string getEjercicio15()
        {
            b = int.Parse(a);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(b + "x" + i + " = " + (i * b));
            }
            return "";
        }

    }
    public class ejercicio16 : general
    {//"Este algoritmo determina el digito mayor de un numero"
        public ejercicio16()
        {
            Console.WriteLine("Este algoritmo determina el digito mayor de un numero");

            this.a = varInicial();
        }
        private void setEjercicio16(string n)
        {

        }
        public string getEjercicio16()
        {
            procedimientoGeneral(a);
            d = n[1];
            for (int j = 1; j < c; j++)
            {
                if (d <= n[j]) d = n[j];
            }
            return "El numero mayor es: " + d;
        }
    }
    public class ejercicio17 : general
    {
        public ejercicio17()
        {
            Console.WriteLine("Dado un numero y una posicion el algoritmo calcula el digito en esa posicion");

            this.a = varInicial();
            Console.WriteLine("Digite la posicion que desee ver");
            d = int.Parse(Console.ReadLine());
        }
        private void setEjercicio17(string n)
        {

        }
        public string getEjercicio17()
        {
            procedimientoGeneral(a);

            return "El digito en la posicion " + d + " es " + n[d];
        }
    }
    public class ejercicio18
    {
        float n, s = 0, a = 0;
        float pr = 0;
        public ejercicio18()
        {
            Console.WriteLine("Este algoritmo muestra el promedio de una cantidad tope N de numeros");

            Console.WriteLine("Ingrese el tope de numero que a a digitar");
            this.n = int.Parse(Console.ReadLine());
        }
        private void setEjercicio18()
        {

        }
        public string getEjercicio18()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el valor");
                a = int.Parse(Console.ReadLine());
                s = s + a;
            }
            pr = (s / n);

            Console.Write("El promedio es: " +pr);
            return "";
        }
    }
    public class ejercicio19
    {
        int n, d = 0;
        int c = 0;
        int i = 0;
        int x = 0;
        public ejercicio19()
        {

        }
        private void setEjercicio19()
        {

        }
        public string getEjercicio19()
        {
            Console.WriteLine("Muestra la cantidad de numeros pares e impares introducidos N veces");

            Console.WriteLine("Ingrese la cantidad n de valores que va a digitar");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad " + n + " de numeros");
            for (; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0) c++;
                else d++;
            }
            return "Hay " + c + " numero(s) par(es) y " + d + " numero(s) impar(es)";

        }
    }
    public class ejercicio20
    {
        int a, e, b = 9, d = 0;

        int i = 0;
        int[] n = new int[10];
        public ejercicio20()
        {

        }
        private void setEjercicio20()
        {

        }
        public string getEjercicio20()
        {
            

            Console.WriteLine("Muestra el numero mayor y menor de una lista de N elementos");
            Console.WriteLine("Ingrese la cantidad n de valores que va a digitar");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad " + a + " de numeros");
            for (; i < a; i++)
            {
                e = int.Parse(Console.ReadLine());
                if (d <= e) d = e;
                if (b >= e) b = e;
            }
            return "El numero mayor es: " + d + " y el menor es: " + b;

        }
    }
    public class ejercicio21
    {
        int n, a = 0;

        public ejercicio21()
        {

        }
        private void setEjercicio21() { }
        public string getEjercicio21()
        {
            Console.WriteLine("Este algoritmo verifica si un numero es primo o no");

            Console.WriteLine("Digite un numero");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) if (n % i == 0) a++;
            if (a == 2) return "El numero " + n + " es primo";
            else return "El numero " + n + " no es primo";

        }



    }
    public class ejercicio22
    {
        int a = 1;
        int n;
        public ejercicio22()
        {

        }
        public string getEjercicio22()
        {
            do
            {
                Console.WriteLine("Ingrese El numero del que quiera sacar factorial");
                n = int.Parse(Console.ReadLine());
            } while (n < 0 || n > 20);
            if (n == 0) return "Su factorial es 1";
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    a = a * i;
                }
                return "El factorial es: " + a;
            }


        }
    }
    public class ejercicio23
    {
        int a, b;

        public string getEjercicio23()
        {
            Console.WriteLine("Algoritmo para ordenar dos numeros de menor a mayor");
            Console.WriteLine("Ingrese un primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero numero");
            b = int.Parse(Console.ReadLine());
            if (a < b) Console.WriteLine("Su orden de menor a mayor es " + a + ", " + b);
            else if (b == a) Console.WriteLine("Son iguales " + a + ", " + b);
            else Console.WriteLine("Su orden de menor a mayor es " + b + ", " + a);
            return "";
        }
    }
    public class ejercicio24
    {
        int n, s = 0, a = 0;
        int pr = 0;
        public string getEjercicio24()
        {
            Console.WriteLine("De una lista N el algoritmo devuelve la cantidad de aprobado o reprobados");
            Console.WriteLine("Ingrese el tope de numero que a a digitar");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el valor");
                a = int.Parse(Console.ReadLine());
                if (a < 51) s++;
                else pr++;
            }
            Console.WriteLine("Hay " + s + " reprobado(s) y " + pr + " aprobado(s)");
            return "";
        }
    }
    public class ejercicio25
    {
        int op = 0;
        public string getEjercicio25()
        {
            Console.WriteLine("Algoritmo para ver el dia de la semana");
            Console.WriteLine("Bienvenido, ingrse un numero del 1 al 7");
            op = int.Parse(Console.ReadLine());
            if (op < 0)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("El numero no pertenece al rango, vuelva a intentarlo");
                    op = int.Parse(Console.ReadLine());
                } while (op <= 0);
            }
            switch (op)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("El dia es Lunes!"); return "";


                case 2:
                    Console.Clear();
                    Console.WriteLine("El dia es Martes!"); return "";

                case 3:
                    Console.Clear();
                    Console.WriteLine("El dia es Miercoles!"); return "";

                case 4:
                    Console.Clear();
                    Console.WriteLine("El dia es Jueves!"); return "";

                case 5:
                    Console.Clear();
                    Console.WriteLine("El dia es Viernes!"); return "";

                case 6:
                    Console.Clear();
                    Console.WriteLine("El dia es Sabado!"); return "";

                case 7:
                    Console.Clear();
                    Console.WriteLine("El dia es Domingo!");
                    return "";


                default:
                    Console.Clear();
                    getEjercicio25(); return "";



            }
        } }
           class Program
        {
            static void Main(string[] args)
            {
                menu g = new menu();
            g.getMenu();
            
                Console.ReadKey();

            }
        }
} 