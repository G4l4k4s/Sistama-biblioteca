using System;
namespace Biblioteca.models;


internal class Program
{
    private static void Main(string[] args)
    {
        var biblioteca1 = new Biblioteca();
        // var Almacen = new List<Libro>();

        Libro libro1 = new Libro("El señor de los anillos", "J.r.r. tolkien", "123sv456", 1954, "terror", 20000);
        Libro libro2 = new Libro("El nombre del viento", "Patrick Rothfuss", "12233sv4456", 2007, "fantasia", 20000);
        Libro libro3 = new Libro("El nombre del viento2", "Patrick Rothfuss", "12233sv4456", 2007, "fantasia", 20000);
        Libro libro4 = new Libro("Harry Potter y la piedra filosofal", "J.K. Rowling", "5555", 1997, "fantasia", 20000);
        Libro libro5 = new Libro("Canción de hielo y fuego: Juego de tronos", "George R.R. Martin", "123sv123456", 1996, "fantasia", 20000);
        Libro libro6 = new Libro("La trilogía de la Ciudad Blanca", " Eva García Sáenz de Urturi", "123sv452982w26", 2016, "fantasia", 20000);
        Libro libro7 = new Libro("La trilogía de la Ciudad Blanca2", " Eva García Sáenz de Urturi", "123sv452ffs226", 2036, "fantasia", 20000);
        Libro libro8 = new Libro("asd","qweqwd","99897hgfhh",2083,"fantasia",200000);

        biblioteca1.Almacen.Add(libro1);
        biblioteca1.Almacen.Add(libro2);
        biblioteca1.Almacen.Add(libro3);
        biblioteca1.Almacen.Add(libro4);
        biblioteca1.Almacen.Add(libro5);
        biblioteca1.Almacen.Add(libro6);
        biblioteca1.Almacen.Add(libro7);
        biblioteca1.Almacen.Add(libro8);


        string Opcion ;
        do
        {
            Console.Clear();
            Console.WriteLine(".1 Ver libros");
            Console.WriteLine(".2 Agregar libro");
            Console.WriteLine(".3 Eliminar libro");
            Console.WriteLine(".4 Buscarpor genero");
            Console.WriteLine(".5 Buscar por autor");
            Console.WriteLine(".6 Buscar por año");
            Console.WriteLine(".7 Ordenar por años");
            Console.WriteLine(".8 Ver deatalles d eun libro");
            Console.WriteLine(".9 Salir del programa");
            Opcion = Console.ReadLine();
           
            switch (Opcion)
            {

                case "1":
                    biblioteca1.VerAlmacen();
                    break;

                case "2":
                    biblioteca1.AgregarLibro();
                    break;

                case "3":
                    biblioteca1.EliminarLibro();
                break;

                case "4":
                    biblioteca1.BuscarPorGenero();
                    break;

                case "5":
                    biblioteca1.BuscarPorAutor();
                break;

                case "6":
                    biblioteca1.BuscarPorRangoAños();
                break;

                case "7":
                    biblioteca1.OrdenarPorAñoPublicacion();
                break;

                case "8":
                    biblioteca1.verDetalles();
                break;

                case "9":
                    Console.Clear();
                    Console.WriteLine("Hasta luego");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        } while (Opcion !="9");
    }
}