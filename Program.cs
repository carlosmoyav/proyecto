using System;

namespace CarlosMoya3B
{
    class Program
    {
        static void Main(string[] args)
        {

            //EJERCICIO 1
            /*
            long num;
            string result;
            Console.WriteLine("ingrese un numero");
            //num = int.Parse(Console.ReadLine());
            result = Console.ReadLine();
            num = long.Parse(result);
            do
            {
                Console.WriteLine("ingrese otro numero y para finalizar escriba SALIR");
                result = Console.ReadLine();
                if(result != "SALIR")
                {
                    if (num > long.Parse(result))
                    {

                    }
                    else
                    {
                        num = long.Parse(result);
                    };

                }

            } while (result!= "SALIR");
            Console.WriteLine("El numero mayor es "+ num);
            */

            /*

            //EJERCICIO 2
            
            int longitud;
            Console.WriteLine("ingrese numero para crear el cuadrado");

            longitud = int.Parse(Console.ReadLine());
            for (int i = 0; i < longitud; i++)
            {
                if (i == 0 || i == longitud - 1)
                {
                    for (int o = 0; o < longitud; o++)
                    {
                        Console.Write("* ");

                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write("*");
                    for (int o = 0; o < ((longitud * 2) - 3); o++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
            }

            */

            /*

            //EJERCICIO 3

            int cantidad, precio, total = 0;
            Console.WriteLine("ingrese cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese precio del producto");
            precio = int.Parse(Console.ReadLine());
            total = total + (cantidad * precio);
            do
            {
                Console.WriteLine("ingrese la cantidad vendida");
                cantidad = int.Parse(Console.ReadLine());
                if (cantidad != 0)
                {
                    Console.WriteLine("ingrese precio del producto");
                    precio = int.Parse(Console.ReadLine());
                    total = total + (cantidad * precio);

                }

            } while (cantidad != 0);
            Console.WriteLine("El total es " + total);
            
            */

            //EJERCICIO 4

            /*

            int horas, extra, total;
            string bucle;
            do
            {
                Console.WriteLine("Introduzca numero de horas trabajadas");
                horas = int.Parse(Console.ReadLine());
                if (horas > 35)
                {
                    extra = (horas - 35);
                    total = (35 * 15) + (extra * 22);
                }
                else
                {
                    total = (horas * 15);
                }
                Console.WriteLine("El salario total es " + total);
                Console.WriteLine("Para calcular otro  salario escriba OK");
                bucle = Console.ReadLine();

            } while (bucle == "OK");

            */

            /*
            //EJERCICIO 5


            int num;
            Console.WriteLine("Ïngrese un numero para generar el triangulo");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int altura = 1; altura <= num; altura++)
            {
                for (int espacio = 1; espacio <= num-altura; espacio++)
                {
                    Console.Write(" ");
                }
                for (int i = 1; i < (altura * 2); i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            */

            //EJERCICIO 6
            /*

            int num;
            Console.WriteLine("Ingrese un numero para generar el rombo");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int altura = 1; altura <= num; altura++)
            {
                for (int espacio = 1; espacio <= num - altura; espacio++)
                {
                    Console.Write(" ");
                }
                for (int i = 1; i < (altura * 2); i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int altura = num - 1; altura > 0; altura--)
            {
                for (int espacio = 1; espacio <= num - altura; espacio++)
                {
                    Console.Write(" ");
                }
                for (int i = 1; i < (altura * 2); i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            */

            /*
            //EJERCICIO 7

            int x = 100;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i + "  " + x);
                --x;
            }


            */

            /*
            //EJERCICIO 8
            int num, segundo, tercero;
            Console.WriteLine("Ingrese un numero positivo");
            num = int.Parse(Console.ReadLine());
            segundo = num;
            do
            {
                segundo = segundo - 2;
            } while (segundo>0);
            tercero = num;
            do
            {
                tercero = tercero - 3;
            } while (tercero > 0);

            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + "  ");
                if (segundo <= num)
                {
                    Console.Write(segundo + "  ");
                    segundo = segundo + 2;
                }
                if (tercero <= num)
                {
                    Console.Write(tercero + "\n");
                    tercero = tercero + 3;
                }
                else
                {
                    Console.Write("\n");
                }
            }

            */

            //EJERCICIO 9

            
            int mult;
            for (int x = 1; x < 16; x++)
            {
                Console.WriteLine("\nTabla del :" + x);
                for (int y = 0; y < 13; y++)
                {
                    mult = x * y;
                    Console.WriteLine(x + "*" + y + "=" + mult);
                }
            }

            

            /*
            //EJERCICIO 10

            int num;
            Boolean condicion = true;

            do
            {

                Console.WriteLine("Elija que opcion quiere realizar");
                Console.WriteLine("1)Salir");
                Console.WriteLine("2)Sumatoria");
                Console.WriteLine("3)Factorial");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        condicion = false;
                        break;
                    case 2:
                        new Program().Sumatorio();
                        break;
                    case 3:
                        new Program().Factorial();
                        break;


                }

            } while (condicion);

        }

        public void Sumatorio()
        {
            int num, suma = 0;
            Console.Write("Escriba un numero para realizar la sumatoria: ");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    suma = suma + i;

                }
                Console.WriteLine("El total es: " + suma);
            }
        }

        public void Factorial()
        {
            int num, factorial = 1;
            Console.WriteLine("Escriba un numero para realizar el factorial");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El resultado es: " + factorial);

              */
        }
    }
}
