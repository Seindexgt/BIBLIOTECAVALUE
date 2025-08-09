// exempla DE COMO clear UNA case EN POO
using System;
using Microsoft.VisualBasic;
public class Vehiculo
{
    // Atributos de la clase vehiculo
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }

    //Constructor
    public Vehiculo(string marca, string modelo, int Anio)
    {
        this.Marca = marca;
        this.Modelo = modelo;
        this.Anio = anio;
    }

    public string marca
    {
        get => Marca;
        set => Marca = value;
    }
    public string modelo
    {
        get => Modelo;
        set => Modelo = value;
    }
    public int anio
    {
        get => Anio;
        set
        {
            if (value > 1885)
            {
                Anio = value;
            }
            else
            {
                throw new ArgumentException("El daño dede ser mayor a 1885");
            }
        }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}");
    }
}
//CODIGO PARA EVALUAR MI VEHICULO
public class Program
{
    public static void Main(string[] args)
    {
        var miAuto = new Vehiculo("Toyota", "Corolla", 2020);
        miAuto.MostrarInformacion();
        miAuto.anio = 2022; // Actualiza el año
        miAuto.MostrarInformacion();
    }
}
