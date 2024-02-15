using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

internal class Arbeider : Werknemer
{

    private decimal uurloon;
    public decimal Uurloon
    {
        get

        {
            return uurloon;
        }
        set
        {
            if (value >= 0m)
            uurloon = value;
        }
    }
    private byte ploegenstelsel;
    public byte Ploegenstelsel
    {
        get
        {
            return ploegenstelsel;
        }
        set
        {
            if (value >= 1 && value <= 3)
        ploegenstelsel = value;
        }
    }
    public Arbeider(string naam, DateTime inDienst, Geslacht geslacht, decimal uurloon, byte ploegenstelsel)
        : base(naam, inDienst, geslacht)
    {
    Uurloon = uurloon;
    Ploegenstelsel = ploegenstelsel;
    }
    public override string GetInfo()
    {
        return $"{base.GetInfo()}\n" +
        $"Uurloon: {Uurloon}\n" +
        $"Ploegenstelsel: {Ploegenstelsel}";
    }
}
