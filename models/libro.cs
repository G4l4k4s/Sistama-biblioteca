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
}