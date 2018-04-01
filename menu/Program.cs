using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
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
                Console.WriteLine("Menu para los practicos:\n1. Primeros 25 ejercicios\n2. Practico vectores\n3. Practico cadenas\n4. Practico matrices");
                op = int.Parse(Console.ReadLine());
            }
            catch { getMenu(); }

            switch (op)
            {
                case 1:
                    System.Diagnostics.Process.Start(@"E:\POO\Otro mas\bin\Debug\Otro mas\bin\Debug\Otro mas.EXE");

                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 1; }
                    else getMenu();
                    break;
                case 2:
                    System.Diagnostics.Process.Start(@"E:\POO\PracticoVectores\bin\Debug\practicoVectores.EXE");
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 2; }
                    else getMenu();
                    break;
                case 3:
                    System.Diagnostics.Process.Start(@"E:\POO\practicoCadenas\bin\Debug\practicoCadenas.EXE");

                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 3; }
                    else getMenu();
                    break;
                case 4:
                    System.Diagnostics.Process.Start(@"E:\POO\practicoMatrices\bin\Debug\practicoMatrices.EXE");

                   
                    Console.WriteLine("Desea continuar? S o N?");
                    respuesta = Console.ReadLine();
                    if (respuesta == "s" || respuesta == "S") { Console.Clear(); goto case 4; }
                    else getMenu();
                    break;
                
                case 5:
                    break;
                default:
                    getMenu();
                    break;
            }

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
