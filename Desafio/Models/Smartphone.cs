namespace DesafioPOO.Models;
using System;

public abstract class Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; set; }
    public int Memoria { get; set; }

    
    public Smartphone(string numero, string modelo, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        Memoria = memoria;
    }

    
    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    
    public abstract void InstalarAplicativo(string nomeApp);
}
