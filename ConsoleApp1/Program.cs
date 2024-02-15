using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string[] stripHelden = { "Zeb","Asterix", "Obelix", "Idefix", "Panoramix" };
        string testString = "teststring";
        Arbeider arbeider = new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
        void test()
        {
            var deelArray = stripHelden[1..3];
            Console.WriteLine(string.Join(' ', deelArray));
            Console.WriteLine(string.Join(' ', stripHelden));
            Array.Sort(stripHelden);
            Console.WriteLine(string.Join(' ', stripHelden));
            Console.WriteLine(testString.Right(3));
            arbeider.Naam = "fred";
            arbeider.InDienst = new DateTime(2017, 1, 1);
            Console.WriteLine($"{arbeider.Naam} zijn hash is: {arbeider.getHash()} in dienst: {arbeider.InDienst.Year}");
        }
        void test2()
        {
            Console.WriteLine();
            Werknemer[] wij = new Werknemer[3];
            wij[0] = new Arbeider("Asterix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
            wij[1] = new Arbeider("Obelix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
            wij[2] = new Arbeider("Idefix", new DateTime(2023, 1, 1), Geslacht.Man, 24.79m, 3);
            //wij[1] = new Bediende("Obelix", new DateTime(1995, 2, 1), Geslacht.Man, 2400.79m);
            //wij[2] = new Manager("Idefix", new DateTime(1996, 3, 1), Geslacht.Man, 2400.79m, 7000m);
            WerknemersLijst lijst;
            lijst = Werknemer.UitgebreideWerknemersLijst;
            Console.WriteLine(lijst(wij));
            Console.WriteLine();
        }
        test();
        test2();
    }
}