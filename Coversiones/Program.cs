using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont;
            int option;
            bool ok = true;
            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());
                do
                {
                    switch (option)
                    {
                        case 1:
                            Calculate("Millas", "Kilómetros", 1.60934f);
                            break;

                        case 2:
                            Calculate("Kilómetros", "Millas", 0.621371f);
                            break;

                        case 3:
                            Calculate("Yardas", "Metros", 0.9144f);
                            break;

                        case 4:
                            Calculate("Metros", "Yardas", 1.09361f);
                            break;

                        default:
                            Console.WriteLine("La opción ingresada no es valida");
                            Console.ReadLine();
                            ok = false;
                            break;
                    }
                    if (ok)
                    {
                        Console.WriteLine("Desea continuar con este tipo de conversion[S/N]");
                        cont = Console.ReadLine();
                    }
                    else cont = "N";
                }
                while (cont.ToUpper() == "S");

                Console.WriteLine("Desea continuar en el programa? [S/N]");
                cont = Console.ReadLine();
            }
            while (cont.ToUpper() == "S");

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadLine();
        }

        private static void Calculate(string origin, string destiny, float convertionFactor)
        {
            var multipleMeasuresText = "o * para ingresar múltiples valores";
            Console.WriteLine($"Elegiste la opción convertir {origin} a {destiny}");
            Console.WriteLine($"Ingrese el valor de {origin} a convertir {multipleMeasuresText}:");
            var userOption = Console.ReadLine();
            if (userOption == "*")
            {
                Console.WriteLine("Ingrese los valores a convertir separados por coma");
                var row = Console.ReadLine();
                                        


                var convertionValues = ConvertMultipleValues(row);
                Console.WriteLine($"La lista tiene {convertionValues.Count()}");

            }
            else
            {

                float originValue = float.Parse(Console.ReadLine());
                float result = originValue * convertionFactor;
                Console.WriteLine($"El valor en {destiny}  es {result}");
            }
        }

        private static List< float > ConvertMultipleValues   (string row)
        {
            var sValue = row.Split(',');
            var totalValue = sValue.Count();
            var value = new List<float>();
            for (int i = 0; i < totalValue; i++)
            {
               value.Add(float.Parse(sValue[i]));
            }

            return value;

        }

        private static void ShowMenu()
        {
        
            Console.WriteLine("Ingrese la opción a usuar");
            Console.WriteLine($"Ingrese 1 para convertir millas a kilometros");
            Console.WriteLine($"Ingrese 2 para convertir Kilometros a millas");
            Console.WriteLine($"Ingrese 3 para convertir metros a yardas");
            Console.WriteLine($"Ingrese 4 para convertir yardas a metros");
        }


    }
}
