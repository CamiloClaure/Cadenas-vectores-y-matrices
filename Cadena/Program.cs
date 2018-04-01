using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadena
{class general
    {
        protected string respuesta = "";
         protected string nombre1, nombre2;
       protected int edad1, edad2,x=0,y,a,b,c,e,i,o,u,d;
        protected int[] letras = new int[5];
    }
    class puntos: general
    {
        public void pts()
        {
            do
            {
                Console.Clear();
                x = 0;
                Console.WriteLine("Digite su cadena");
                nombre1 = Console.ReadLine();
                y = nombre1.Length;
                for(int j =0;j<y;j++)
                {
                    switch (nombre1[j])
                    {
                        case 'a':
                            x++;
                            a++;
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

                Console.WriteLine("La cantidad de vocales es: "+  x);
                Console.WriteLine("La cantidad de vocal a es: " + a);
                Console.WriteLine("La cantidad de vocal e es: " + e);
                Console.WriteLine("La cantidad de vocal i es: " + i);
                Console.WriteLine("La cantidad de vocal o es: " + o);
                Console.WriteLine("La cantidad de vocal u es: " + u);
                if (a > e && a > i && a > o && a > u)
                {
                    Console.WriteLine("La vocal que aparece mas es a ");
                }
                else if (e > a && e > i && e > o && e > u)
                {
                    Console.WriteLine("La vocal que aparece mas es e ");
                }
                else if (i > e && i > a && i > o && i > u)
                {
                    Console.WriteLine("La vocal que aparece mas es i ");
                }
                else if (o > e && o > i && o > a && o > u)
                {
                    Console.WriteLine("La vocal que aparece mas es o ");
                }
                else if (u > e && u > i && u > o && u > a)
                {
                    Console.WriteLine("La vocal que aparece mas es u ");
                }
                else Console.WriteLine("Son de igual cantidad");
                Console.WriteLine("La cantidad de caracteres es: " + nombre1.Length);

                Console.WriteLine("Desea continuar?  s para continuar");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToLower();
            } while (respuesta == "s");
        }
      
    }
    class cadenaVector:general
    {
        public void vector()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Digite su cadena");
                nombre1 = Console.ReadLine();
               
                for(int i = 0; i< nombre1.Length; i++)
                {
                    Console.Write(nombre1[i]+" ");
                }
                Console.WriteLine(" y su longitud es: " + nombre1.Length);
                Console.WriteLine("\nDesea continuar?  s para continuar");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToLower();
            } while (respuesta == "s");
        }
    }
    class qwe
    {
        string respuesta = "";
        string nombre1, nombre2;
        int edad1, edad2;

        public void qwert()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Digite su nombre 1");
                nombre1 = Console.ReadLine();
                Console.WriteLine("Digite su edad 1");
                edad1 = int.Parse(Console.ReadLine());
        
                Console.WriteLine("Digite su nombre 2");
                nombre2 = Console.ReadLine();
                Console.WriteLine("Digite su edad 1");
                edad2 = int.Parse(Console.ReadLine());
              
                if (edad1 == edad2)
                {
                    Console.WriteLine("Son de igual edad");
                }
                else if(edad1<edad2)
                {
                    Console.WriteLine(nombre2 + " es mayor que "+nombre1);
                }
                else
                {
                    Console.WriteLine(nombre1 + " es mayor que " + nombre2);
                }

                Console.WriteLine("Desea continuar?  s para continuar");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToLower();
            } while (respuesta == "s");
        }
    }
    class nombre
    {
        string nombre1 = "";
        string nombre2 = "";
        string respuesta = "";
        public void pedir()
        {
            do {
                Console.Clear();
                Console.WriteLine("Digite su nombre 1");
                nombre1 = Console.ReadLine();
                nombre1 = nombre1.ToLower();
                Console.WriteLine("Digite su nombre 2");
                nombre2 = Console.ReadLine();
                nombre2 = nombre1.ToLower();
                if (nombre1 == nombre2)
                {
                    Console.WriteLine("Son iguales");
                }
                else {
                    Console.WriteLine("No son inguales"); }

                Console.WriteLine("Desea continuar?  s para continuar");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToLower();
            } while (respuesta == "s");

        }
    }
    class caracateres
    {
        string s1 = "universidad";
        string s2 = "emi";
        string s3 = "";
        public void chara()
        {
            s1 += s2;
            s3 = Convert.ToString(s1.Length);
            Console.WriteLine(s3);
            Console.WriteLine(s1);
            s1 = s1.Substring(10, 4);
            Console.WriteLine(s1);

            s3 = Convert.ToString(s1.IndexOf("i", 0  ));
            Console.WriteLine(s3);

            s3 = Convert.ToString(s2.ToUpper());
            Console.WriteLine(s3);

            s3 = Convert.ToString(s2.ToLower());
            Console.WriteLine(s3);

            s3 = Convert.ToString(s2.Replace("i", "i2017"));
            Console.WriteLine(s3);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            puntos x = new puntos();
            x.pts();
            Console.ReadKey();

        }
    }
}
