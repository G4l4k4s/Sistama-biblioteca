using Biblioteca.models;


var Almacen = new List<Libro>();

Libro libro1 = new Libro("El señor de los anillos", "J.r.r. tolkien", "123sv456", 1954, "fantasia", 20000);
Libro libro2 = new Libro("El nombre del viento", "Patrick Rothfuss", "12233sv4456", 2007, "fantasia", 20000);
Libro libro3 = new Libro("Harry Potter y la piedra filosofal", "J.K. Rowling", "123sv456", 1997, "fantasia", 20000);
Libro libro4 = new Libro("Canción de hielo y fuego: Juego de tronos", "George R.R. Martin", "123sv456", 1996, "fantasia", 20000);
Libro libro5 = new Libro("La trilogía de la Ciudad Blanca", " Eva García Sáenz de Urturi", "123sv456", 2016, "fantasia", 20000);

Almacen.Add(libro1);
Almacen.Add(libro2);
Almacen.Add(libro3);
Almacen.Add(libro4);
Almacen.Add(libro5);

Console.WriteLine("que genero esta buscando");
var BusquedaGen = Console.ReadLine();

foreach (var item in Almacen)
{
    if (item.Genero == BusquedaGen)
    {
        Console.WriteLine(item.Titulo);
    }
}


