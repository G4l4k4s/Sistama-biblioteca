using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.models;

public class Biblioteca
{
    // Lista de libros
    private List<Libro> libros;

    // Constructor
    public Biblioteca()
    {
        libros = new List<Libro>();
    }
    // Método para agregar un libro a la biblioteca
    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    // Método para eliminar un libro de la biblioteca
    public void EliminarLibro(Libro libro)
    {
        libros.Remove(libro);
    }

    // Método para buscar libros por género
    public List<Libro> BuscarPorGenero(string genero)
    {
        return libros.Where(l => l.Genero.Equals(genero, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // Método para buscar libros por autor
    public List<Libro> BuscarPorAutor(string autor)
    {
        return libros.Where(l => l.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // Método para buscar libros por rango de años de publicación
    public List<Libro> BuscarPorRangoAños(int añoInicio, int añoFin)
    {
        return libros.Where(l => l.AñoDePublicacion >= añoInicio && l.AñoDePublicacion <= añoFin).ToList();
    }

    // Método para ordenar libros por año de publicación
    public void OrdenarPorAñoPublicacion()
    {
        libros = libros.OrderBy(l => l.AñoDePublicacion).ToList();
    }
}