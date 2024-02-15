using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public class Bediende : Werknemer
{
    public Bediende(string naam, DateTime indienst,
    Geslacht geslacht, decimal wedde)
    : base(naam, indienst, geslacht)
    {
        Wedde = wedde;
    }
    private decimal wedde;
    public decimal Wedde
    {
        get
        {
            return wedde;
        }
        set
        {
            if (value >= 0m)
                wedde = value;
        }
    }
    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
        $"Wedde: {Wedde}";
    }
    public void DoeOnderhoud(Firma.Materiaal.Fotokopiemachine machine)
    {
        Console.WriteLine($"{Naam} onderhoudt machine {machine.SerieNr}");
    }
}
