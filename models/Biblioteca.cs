using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.models;

public class Biblioteca
{
    // Lista de libros
    public List<Libro> Almacen;

    // Constructor
    public Biblioteca()
    {
        // libros = new List<Libro>();
        Almacen = new List<Libro>();

    }
    // Método para agregar un libro a la biblioteca
    public void VerAlmacen()
    {
        Console.Clear();
        Console.WriteLine("ESTOS SON LOS LIBROS EN INVENTARIO \n");
        foreach (var item in Almacen)
        {
            Console.WriteLine(item.Titulo);
        }

        Console.WriteLine("\n Fin de lista de libros en inventario");
        Console.ReadKey();
    }
    public void AgregarLibro()
    {
        Console.Clear();
        Console.WriteLine("AGREGAR LIBRO");
        Console.WriteLine("VAMOS A INGRESAR LOS DATOS DEL LIBRO");
        Console.WriteLine("Cual es el titulo del libro");
        var titulo = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Cual es el autor del libro");
        var autor = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Cual es ISBN del libro");
        var isbn = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Cual es el año de salida del libro");
        var añodepublicacion = Convert.ToInt16(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Cual es el genero del libro");
        var genero = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Cual es el precio del libro");
        var precio = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Libro guardado exitosamente");
        var newLibro = $"{titulo} , {autor} , {isbn}, {añodepublicacion} ,{genero} , {precio}";
        Libro Libro = new Libro(titulo, autor, isbn, añodepublicacion, genero, precio);
        Almacen.Add(Libro);
        Console.WriteLine(newLibro);
        Console.ReadKey();
    }

    // Método para eliminar un libro de la biblioteca
    public void EliminarLibro()
    {
        Console.Clear();
        Console.WriteLine("Escribe el isbn del libro que seas eliminar");
        var newIsbn = Console.ReadLine();
        foreach (var item in Almacen)
        {
            if (item.ISBN == newIsbn)
            {
                Almacen.Remove(item);
                Console.WriteLine("libro borrado exitosamente");
                Console.ReadKey();
                break;

            }
            else if (item.ISBN != newIsbn)
            {
                Console.WriteLine("ISBN no encontrado");
                Console.ReadKey();
                break;
            }
        }
    }

    // Método para buscar libros por género
    public void BuscarPorGenero()
    {
        Console.Clear();
        Console.WriteLine("que genero esta buscando");
        var BusquedaGen = Console.ReadLine();
        var bidisdsa = Almacen.Where(l => l.Genero.Contains(BusquedaGen)).ToList();

        foreach (var item in bidisdsa)
        {
            Console.WriteLine(item.Titulo);
        }
        Console.WriteLine("presione cualquier tecla para vovler");
        Console.ReadKey();
    }

    // Método para buscar libros por autor
    public void BuscarPorAutor()
    {
        Console.Clear();
        Console.WriteLine("Que autor estas buscando");
        Console.WriteLine("Libros escontrados del autor \n");
        var BusquedaAutor = Console.ReadLine();
        var BusquedaLINQ = Almacen.Where(l => l.Autor.Contains(BusquedaAutor)).ToList();
        foreach (var item in BusquedaLINQ)
        {
                Console.WriteLine($"\n{item.Autor}");
                Console.WriteLine(item.Titulo);
        }
        Console.WriteLine("presione cualquier tecla para vovler");
        Console.ReadKey();
    }

    // Método para buscar libros por rango de años de publicación
    public void BuscarPorRangoAños()
    {
        Console.Clear();
        Console.WriteLine("Indica el primer año que deseas filtrar");
        var año1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"\nprimero año es {año1}, cual es el segundo año a filtrar \n" );
        var año2 = Convert.ToInt64(Console.ReadLine());
        var filtroAño = Almacen.Where(l => l.AñoDePublicacion >= año1 && l.AñoDePublicacion <= año2).ToList();
        foreach (var item in filtroAño)
        {
            Console.WriteLine($"{item.Titulo},{item.AñoDePublicacion}");
        }

        Console.WriteLine("\nlista");
        Console.WriteLine("Deseas hacer algo mas preciona culaquier tecla");
        Console.ReadKey();
    }

     // Método para ordenar libros por año de publicación
    public void OrdenarPorAñoPublicacion()
    {
        Almacen = Almacen.OrderBy(l => l.AñoDePublicacion).ToList();
    }

    public void verDetalles()
    {
        Console.Clear();
        Console.WriteLine("Ingresa en ISBN del libro que deseas buscar");
        var VerDeta =Console.ReadLine();
        var listDeta = Almacen.Where(l => l.ISBN.Contains(VerDeta)).ToList();
        foreach (var item in listDeta)
        {
            Console.WriteLine($"\n Titulo: {item.Titulo}\n Autor: {item.Autor}\n ISBN: {item.ISBN}\n Año de publicacion: {item.AñoDePublicacion}\n Genero: {item.Genero}\n Precio: {item.Precio}");
        }
        Console.WriteLine("\nDeseas hacer algo mas preciona culaquier tecla");
        Console.ReadKey();
    }

}