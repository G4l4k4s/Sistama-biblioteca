using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.models;
public class Libro : Publicacion
{   
    public string Autor {get; set;}
    public string ISBN {get; set;}
    public string Genero { get; set;}
    public int Precio {get; set;}
    public Libro (string titulo, string autor, string isbn,int añodepublicacion, string genero, int precio)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        AñoDePublicacion = añodepublicacion;
        Genero = genero;
        Precio = precio;
    }

    // Método para descripción detallada del libro
    public string DescripcionDetallada()
    {
        return $"Título: {Titulo}\n" +
               $"Autor: {Autor}\n" +
               $"ISBN: {ISBN}\n" +
               $"Año de Publicación: {AñoDePublicacion}\n" +
               $"Género: {Genero}\n" +
               $"Precio: {Precio:C}";
    }

    // Método para aplicar descuento al precio del libro


    // Método para determinar si el libro es reciente (publicado en los últimos 5 años)
    public bool EsReciente()
    {
        return (DateTime.Now.Year - AñoDePublicacion) <= 5;
    }
}