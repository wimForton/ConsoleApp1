using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Firma.Materiaal.Fotokopiemachine;

namespace Firma.Materiaal;

internal class Fotokopiemachine
{
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

