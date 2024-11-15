namespace DesafioPOO.Models
public  class Nokia : Smartphone
    {
    public Nokia(string numero, string modelo, int memoria) : base(numero, modelo, memoria)
    {
    }

  
    public override void InstalarAplicativo(string nomeApp)
        {
          Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no smartphone Android.");
        }
    }
