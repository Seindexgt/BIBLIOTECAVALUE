/**
*!PROGAMA PARA EVALUAR UNA BIBLIOTECA
*/
using System;
using Microsoft.VisualBasic;

public class Libro
{
    //Atributos para la clase Libro
    public string Nombre { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Anio { get; set; }
    public int Edicion { get; set; }

    //Constructor de la clase Libro
    public Libro(string nombre, string libro, string autor, int anio, int edicion)
    {
        this.Nombre = nombre;
        this.Titulo = libro;
        this.Autor = autor;
        this.Anio = anio;
        this.Edicion = edicion;
    }
    public string nombre
    {
        get => Nombre;
        set => Nombre = value;
    }
    public string titulo
    {
        get => Titulo;
        set => Titulo = value;
    }
    public string autor
    {
        get => Autor;
        set => Autor = value;
    }
    public int anio
    {
        get => Anio;
        set => Anio = value;
    }
    public int edicion
    {
        get => Edicion;
        set => Edicion = value;
    }
}