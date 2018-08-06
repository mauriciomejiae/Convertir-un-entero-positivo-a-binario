using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertir_un_entero_positivo_a_binario
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, c, bin, i;  //declaración de variable tipo float
            cabeza();
            Console.Write("\n\n\n\n Bienvenido a un sencillo programa para convertir un entero positivo a binario");
            Console.Write("\n\n\n\t\tIngresa tu numero entero: ");
            x = int.Parse(Console.ReadLine()); //almacena valor en variable
            if (x <= 257)
            {
                if (x > 0)
                {
                    c = x;
                    i = 1;
                    bin = 0;
                    while (c != 1)
                    {
                        bin = bin + (c % 2) * i;
                        c = (int)(c / 2);
                        i = i * 10;
                    }
                    bin = bin + (c % 2) * i;
                    Console.Clear();
                    cabeza();
                    Console.Write("\n\n\n\tEl numero decimal {0} en binario es: {1}", x, bin);
                    Console.Write("\n\t Presione una tecla para continuar...");
                    Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                }
                else
                {
                    Console.Clear();
                    cabeza();
                    Console.Write("\n\n\n El numero ingresado es negativo ");
                    Console.Write("\n\t Presione una tecla para continuar...");
                    Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
                }
            }
            else
            {
                Console.Clear();
                cabeza();
                Console.Write("\n\n\n El numero ingresado es mayor a 257 ");
                Console.Write("\n\t Presione una tecla para continuar...");
                Console.ReadKey();//ReadKey es una funcion que lee que se oprimio una tecla.
            }
        }
        static void cabeza()//funcion para decirle al usuario que la clave debe ser de 4 digitos
        {
            Console.Clear();//Clear es la funcion para limpiar pantalla.
            Console.Write("\n       UNIVERSIDAD NACIONAL ABIERTA Y A DISTANCIA");//la funcion Write basicamente lo que hace es mostrar en la consola la cadena de caracteres.
            Console.Write("\n              Trabajo colaborativo: Fase 2");
            Console.Write("\n                       Algorítmos");
            Console.Write("\n                  Problema 9:  fase 2");
        }
    }
}
