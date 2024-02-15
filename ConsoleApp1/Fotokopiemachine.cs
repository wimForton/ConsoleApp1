using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Firma.Materiaal.Fotokopiemachine;

namespace Firma.Materiaal;
public delegate void Onderhoudsbeurt(Fotokopiemachine machine);
public class Fotokopiemachine
{
    public event Onderhoudsbeurt? OnderhoudNodig;
    //het event OnderhoudNodig veroorzaken
    private const int AantalBlzTussen2OnderhoudsBeurten = 10;
    public void Fotokopieer(int aantalBlz)
    {
        for (int blz = 1; blz <= aantalBlz; blz++)
        {
            Console.WriteLine($"FotokopieMachine {SerieNr} kopieert " +
            $"blz. {blz} van {aantalBlz}");
            if (++AantalGekopieerdeBlz % AantalBlzTussen2OnderhoudsBeurten == 0)
                if (OnderhoudNodig != null)
        OnderhoudNodig(this);
        }
    }
    public class KostPerBlzException : Exception
    {
        public decimal VerkeerdeKost { get; set; }
        public KostPerBlzException(string message, decimal verkeerdeKost)
        : base(message)
        {
            VerkeerdeKost = verkeerdeKost;
        }
    }
    public class AantalGekopieerdeBlzException : Exception
    {
        public int VerkeerdAantalBlz { get; set; }
        public AantalGekopieerdeBlzException(string message,
        int verkeerdAantalBlz)
        : base(message)
        {
            VerkeerdAantalBlz = verkeerdAantalBlz;
        }
    }
    public string SerieNr { get; init; }
    public Fotokopiemachine(string serieNr, int aantalGekopieerdeBlz,
    decimal kostPerBlz)
    {
        SerieNr = serieNr;
        AantalGekopieerdeBlz = aantalGekopieerdeBlz;
        KostPerBlz = kostPerBlz;
    }
    public bool Menselijk => false;
    public decimal BerekenKostprijs() => AantalGekopieerdeBlz * KostPerBlz;
    private int aantalGekopieerdeBlz;
    public int AantalGekopieerdeBlz
    {
        get { return aantalGekopieerdeBlz; }
        set
        {
            if (value < 0)throw new AantalGekopieerdeBlzException("Aantal blz. < 0!", value);
            aantalGekopieerdeBlz = value;
        }
    }

    private decimal kostPerBlz;
    public decimal KostPerBlz
    {
        get { return kostPerBlz; }
        set
        {
            if (value <= 0)
                throw new KostPerBlzException("Kost per blz. <=0!", value);
            kostPerBlz = value;
        }
    }
}

