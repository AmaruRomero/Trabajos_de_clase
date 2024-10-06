using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaVehiculos
{
    public class Vehiculo
    {
        public Vehiculo(string modelo, double precio)
        {
            Modelo = modelo;
            Precio = precio;
        }

        public string Modelo { get; set; }
            public double Precio { get; set; }
        internal class Descuento
        {
            public static double Discount(double x, double y)
            {
                return x * (y / 100);
            }
        }
        public void Mostrar()
        {
            Console.WriteLine($"El modelo del vehiculo es: {Modelo}\nY su precio es: {Precio}");
        }

        public static double Reserva(double precio, double cant_de_tmp)
        {
            return (precio * 0.01) * cant_de_tmp;
        }

    }

}

