using Biblioteca.models;

var listLibro = new List<Libro>();
//Instanciando um objeto da classe Libro 
Libro libro1 = new Libro("El señor de los anillos", "J.r. tolkien", "123sv456", 1954, "fantasia", 20000);
listLibro.Add(libro1);
Console.WriteLine(libro1);


