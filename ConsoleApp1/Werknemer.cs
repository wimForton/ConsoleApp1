using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firma.Materiaal;

namespace ConsoleApp1;

public enum Geslacht
{
    Man, Vrouw, X
}
public delegate string WerknemersLijst(Werknemer[] werknemers);
//public delegate void Onderhoudsbeurt(Fotokopiemachine machine);
public abstract class Werknemer: Ikost
{
    private string? naam;

    public string Naam
    {
        get
        {
            if (naam is not null)
                return naam!;
            else return "";
        }

        set
        {
            if (value != string.Empty)
                naam = value!;
        }
    }

    public Geslacht Geslacht { get; set; }
    public DateTime InDienst { get; set; }
    private static DateOnly personeelsfeest;
    public static DateOnly Personeelsfeest
    {
        set
        {
            personeelsfeest = value;
        }
        get
        {
            return personeelsfeest;
        }
    }

    private decimal salaris;
    public decimal Salaris
    {
        get
        {
            return salaris;
        }
        private set
        {
            if (value >= 0m)
                salaris = value;
        }
    }
    public Werknemer()
    {
        this.Naam = "";
        this.InDienst = new DateTime();
        this.Geslacht = Geslacht.Man;
    }
    public Werknemer(string Naam, DateTime InDienst, Geslacht Geslacht)
    {
        this.Naam = Naam;
        this.InDienst = InDienst;
        this.Geslacht = Geslacht;
    }
    public static string UitgebreideWerknemersLijst(Werknemer[] werknemers) { 
        StringBuilder sb = new StringBuilder(); 
        sb.AppendLine("Uitgebreide werknemerslijst:"); 
        foreach (Werknemer werknemer in werknemers) sb.AppendLine(werknemer.GetInfo()).AppendLine(); 
        return sb.ToString();
    }
    public decimal BerekenKostprijs()
    { throw new NotImplementedException();
    }
    public bool Menselijk => throw new NotImplementedException();
    public static string KorteWerknemersLijst(Werknemer[] werknemers) { 
        StringBuilder sb = new StringBuilder(); 
        sb.AppendLine("Verkorte werknemerslijst:"); 
        foreach (Werknemer werknemer in werknemers) 
            sb.AppendLine(werknemer.ToString()); 
        return sb.ToString();
    }
    public override string ToString()
    {
        return $"{Naam} {Geslacht}";
    }
    public string GetInfo()
    {
        return $"Naam: {Naam}\n" +
        $"Geslacht: {Geslacht}\n" +
        $"In dienst: {InDienst}\n" +
        $"Personeelsfeest: {Personeelsfeest}\n ";
    }
    public int getHash()
    {
        if (naam is not null) return naam.GetHashCode();
        else
        {
            return -1;
        }
    }

    public void DoStuff()
    {
        throw new System.NotImplementedException();
    }
}
