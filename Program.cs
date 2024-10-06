using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReservaVehiculos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Reserva de vehiculos");
            int opcion;
            double Descuento;
            double Reserva;
            Console.Write("Ingrese los datos del vehiculo \nModelo: ");
            string? k = Console.ReadLine();
            Console.Write("Precio: ");
            double j = Convert.ToDouble(Console.ReadLine());
            Vehiculo mivehi = new Vehiculo(k , j);

            for (int i = 0; i < 1; i++)
            {
                Console.Write("Que desea realizar?\n1-Ver datos del vehiculo \n2-ver datos adicionales \n3-Precio de vehiculo con descuento\n4-Ver precio con reserva incluida  \n5-Salir \nOpcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (opcion)
                {
                    case 1:
                        mivehi.Mostrar();
                        break;
                    case 2:
                        Console.WriteLine("De cuanto fue su porcentaje de descuento: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Descuento = Vehiculo.Descuento.Discount(mivehi.Precio, c);

                        Console.WriteLine("De cuantos dias fue la reserva: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Reserva = Vehiculo.Reserva(mivehi.Precio, a);

                        Console.WriteLine("El total de descuento es: " + Descuento + "\nEl total de la reserva es: " + Reserva);
                        break;
                    case 3:
                        Console.WriteLine("De cuanto fue su porcentaje de descuento: ");
                        double d = Convert.ToDouble(Console.ReadLine());
                        Descuento = Vehiculo.Descuento.Discount(mivehi.Precio, d);
                        Console.WriteLine($"El valor total aplicando el descuento es de: {mivehi.Precio - Descuento}");
                        break;
                    case 4:
                        Console.WriteLine("De cuantos dias fue la reserva: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Reserva = Vehiculo.Reserva(mivehi.Precio, b);
                        Console.WriteLine($"El valor total con la reserva es de {mivehi.Precio + Reserva}");
                        break;
                    case 5:
                        Console.WriteLine("Gracias por preferir nuestro servicio.");
                        break;
                    default:
                        Console.WriteLine("Esta opcion esta fuera de limite/cerrando_programa.");
                        break;
                }
                Console.Write("Desea realizar otra operacion? (1 - si / 2 - no)\nOpcion: ");
                int h = Convert.ToInt32(Console.ReadLine());
                if (h == 1)
                {
                    i--;
                    Console.WriteLine();
                }
                else if (h == 2)
                {
                    i++;
                    Console.WriteLine("Gracias por preferir nuestro servicio.");
                }


            }
            
        }
    }
}