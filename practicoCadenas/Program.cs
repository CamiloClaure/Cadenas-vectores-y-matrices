using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicoCadenas
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
                Console.WriteLine("Ingrese un numero del 1 al 9 para ir al respectivo ejercicio, 10 para salir");
                op = int.Parse(Console.ReadLine());
            }
            catch { getMenu(); }

            switch (op)
            {
                case 1:
                    ejercicio1 aa = new ejercicio1();
                    aa.inicio1();

                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 1; }
                    else getMenu();
                    break;
                case 2:
                    ejercicio2 ab = new ejercicio2();
                    ab.inicio2();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 2; }
                    else getMenu();
                    break;
                case 3:
                    ejercicio3 ac = new ejercicio3();
                    ac.inicio3();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 3; }
                    else getMenu();
                    break;
                case 4:
                    ejercicio4 ad = new ejercicio4();
                    ad.inicio4();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 4; }
                    else getMenu();
                    break;
                case 5:
                    ejercicio5 ae = new ejercicio5();
                    ae.inicio5();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 5; }
                    else getMenu();
                    break;
                case 6:
                    ejercicio6 af = new ejercicio6();
                    af.inicio6();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 6; }
                    else getMenu();
                    break;
                case 7:
                    ejercicio7 ag = new ejercicio7();
                    ag.inicio7();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 7; }
                    else getMenu();
                    break;
                case 8:
                    ejercicio8 aw = new ejercicio8();
                    aw.inicio8();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 8; }
                    else getMenu();
                    break;
                case 9:
                    ejercicio9 ai = new ejercicio9();
                    ai.inicio9();
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 9; }
                    else getMenu();
                    break;
           

                case 10:
                    break;
                default:
                    getMenu();
                    break;
            }

        }
    }
    class general
    {
        protected string a, b, c, d;
        protected int e=0, f, g, h,x,y,i,o,u,aa;
        protected char cc;
        protected string respuesta = "",dd,rr;
        protected void llenado()
        {
            Console.Write("Ingrese una cadena: ");
            a = Console.ReadLine();
        }
        
    }
    class ejercicio1:general
    {
        public void inicio1()
        {
            llenado();
            Console.WriteLine("La cantidad de caracteres que hay es: "+ a.Length);
        }
    }
    class ejercicio2 : general
    {
        public void inicio2()
        {
            llenado();
            Console.WriteLine("La cadena invertida es: ");
            for (int i = a.Length -1; i >= 0; i--)
            {
                Console.Write(" " + a[i]);

            }
        }
    }
    class ejercicio3:general
    {
        public void inicio3() {
            Console.Write("Ingrese una cadena 1: ");
            a = Console.ReadLine();
            Console.Write("Ingrese una cadena 2: ");
            b = Console.ReadLine();

            for(int i = 0; i < a.Length;i++)
            {
                if (a[i] == b[i])
                {
                    e++;
                }
            }
            if (e == a.Length)
            {
                Console.WriteLine("Cadena 1 es prefijo de cadena 2");
            }
            else Console.WriteLine("Cadena 1 no es prefijo de cadena 2");
        }
    }
    class ejercicio4 : general
    {
        public void inicio4()
        {
            do
            {
                Console.Clear();
                x = 0;
                aa = 0;
                e = 0;
                i = 0;
                o = 0;
                u = 0;
                llenado();
                for (int j = 0; j < a.Length; j++)
                {
                    switch (a[j])
                    {
                        case 'a':
                            x++;
                            aa++;
                            break;
                        case 'e':
                            x++;
                            e++;
                            break;
                        case 'i':
                            x++;
                            i++;
                            break;
                        case 'o':
                            x++;
                            o++;
                            break;
                        case 'u':
                            x++;
                            u++;
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine("La cantidad de vocales es: " + x);
                Console.WriteLine("La cantidad de vocal a es: " + aa);
                Console.WriteLine("La cantidad de vocal e es: " + e);
                Console.WriteLine("La cantidad de vocal i es: " + i);
                Console.WriteLine("La cantidad de vocal o es: " + o);
                Console.WriteLine("La cantidad de vocal u es: " + u);

                Console.WriteLine("Desea continuar?  s para continuar");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToLower();
            } while (respuesta == "s");

        }
    }
    class ejercicio5 : general
    {
        public void inicio5()
        {
            llenado();
            Console.Clear();
            try
            {
                Console.Write("Digite una posicion: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Digite una cantidad: ");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine(a.Substring(x, y));
            }
            catch
            {
                Console.WriteLine("Entrada no valida, enter para continuar");
                inicio5();
            }

            
           
        }
    }
    class ejercicio6:general
    {
        public void inicio6()
        {
            do
            {
                Console.Clear();
                x = 0;
                aa = 0;
                e = 0;
                i = 0;
                o = 0;
                u = 0;
                llenado();
                for (int j = 0; j < a.Length; j++)
                {
                    switch (a[j])
                    {
                        case 'a':
                            x++;
                            aa++;
                            break;
                        case 'e':
                            x++;
                            e++;
                            break;
                        case 'i':
                            x++;
                            i++;
                            break;
                        case 'o':
                            x++;
                            o++;
                            break;
                        case 'u':
                            x++;
                            u++;
                            break;
                        default:
                            break;
                    }
                }

                if (aa > e && aa > i && aa > o && aa > u)
                {
                    Console.WriteLine("La vocal que aparece mas es a ");
                }
                else if (e > aa && e > i && e > o && e > u)
                {
                    Console.WriteLine("La vocal que aparece mas es e ");
                }
                else if (i > e && i > aa && i > o && i > u)
                {
                    Console.WriteLine("La vocal que aparece mas es i ");
                }
                else if (o > e && o > i && o > aa && o > u)
                {
                    Console.WriteLine("La vocal que aparece mas es o ");
                }
                else if (u > e && u > i && u > o && u > aa)
                {
                    Console.WriteLine("La vocal que aparece mas es u ");
                }
                else Console.WriteLine("Las vocales son de igual cantidad");

                Console.WriteLine("Desea continuar?  s para continuar");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToLower();
            } while (respuesta == "s");
        }
    }
    class ejercicio7 : general
    {
        
        public void inicio7()
        {
            llenado();
            Console.Write("Ingrese el caracter para verificar: ");
            cc = char.Parse(Console.ReadLine());
            try
            {
                for (int j = 0; j < a.Length; i++)
                {
                    if (a[i + 1] == ' ' && a[i] == cc)
                    {
                        x++;
                    }
                }
                Console.WriteLine("La cantidad de palabras que terminan en el caracter que ingreso es: " + x);
            }
            catch (IndexOutOfRangeException)
            {
                x++;
                Console.WriteLine("La cantidad de palabras que terminan en el caracter que ingreso es: " + x);
            }
            
        }
    }
    class ejercicio8 : general
    {
        public void inicio8()
        {
            llenado();
            Console.WriteLine("La cantidad de caracteres que hay es: " + a.Length);
        }
    }
    class ejercicio9 : general
    {
        public void inicio9()
        {
            llenado();
            Console.Write("Que caracter desea reemplazar? ");
            rr = Console.ReadLine();
            Console.Write("Que desea introducir? ");
            dd = Console.ReadLine();
            b = Convert.ToString(a.Replace(rr, dd));
            Console.WriteLine(b);
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            menu x = new menu();
            x.getMenu();
            Console.ReadKey();
        }
    }
}
