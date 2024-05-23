using System.Net;

namespace PCCO104L.Encapsulation.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aso for sale:");
            Console.WriteLine("");

            Aso husky = new Aso(25.00, "Husky", "Male");
            husky.pangalan = "Allen";
            husky.Presyo = 15000.50;
            husky.Puro = "Pure Breed";
            husky.nabili = "Sold!";
            husky.Tahol();
            husky.Nabenta();
            husky.hey();
            husky.sound();

            Aso GR = new Aso(20.00, "Golden Retriever", "Female");
            GR.pangalan = "Cecillia";
            GR.Presyo = 50.5;
            GR.Puro = "Mixed Breed";
            GR.nabili = "Reserved.";
            GR.Tahol();
            GR.Nabenta();
            GR.hey();
            GR.sound();

            Aso corgi = new Aso(15.00, "Corgi", "Male");
            corgi.pangalan = "Cyrus";
            corgi.Presyo = 75000000.99;
            corgi.Puro = "Pure Breed";
            corgi.nabili = "Sale!";
            corgi.Tahol();
            corgi.Nabenta();
            corgi.hey();
            corgi.sound();
            corgi.Marco();

            Pusa munchkin = new Pusa(8.00, "Munchkin", "Male");
            munchkin.nabili = "Reserved.";
            munchkin.name();
            munchkin.sound();
            munchkin.hey();
            munchkin.Puro = "Mixed";
            munchkin.Presyo = 123.123;
            munchkin.Meow();
            munchkin.Nabenta();

            Pusa siamese = new Pusa(10.00, "Jasmin", "Female");
            siamese.nabili = "Sale!";
            siamese.name();
            siamese.sound();
            siamese.hey();
            siamese.Puro = "Pure";
            siamese.Presyo = 5050.00;
            siamese.Meow();
            siamese.Nabenta();

            Pusa toyger = new Pusa(12.00, "Tonch", "Male");
            toyger.nabili = "Sold!";
            toyger.name();
            toyger.sound();
            toyger.hey();
            toyger.Puro = "Pure";
            toyger.Presyo = 150000.99;
            toyger.Meow();
            toyger.Nabenta();
            toyger.Marco();

        }
    }
}
public class Pusa : Iselling1, Iselling2
{
    private string _Lahi { get; set; }

    private double _Bigat { get; set; }

    private string _Kasarian { get; set; }

    public string nabili { get; set; }

    public void hey()
    {
        Console.WriteLine("Hey! Hey! Hey!");
    }
    public void sound()
    {
        Console.WriteLine("Meow!");
    }
    public void name()
    {
        Console.WriteLine("Wala pa hehe ikaw na katamad ih...");
    }
    public string? Puro { get; set; }
    public double Presyo { get; set; }
    public void Method1() { }
    public void Method2() { }

    public Pusa() { }

    public Pusa(double bigat)
    {

        _Bigat = bigat;
    }

    public Pusa(double bigat, string lahi, string kasarian) : this(bigat)
    {
        _Lahi = lahi;
        _Kasarian = kasarian;
    }

    public void Meow()
    {
        Console.WriteLine($"{_Lahi} - {_Bigat} - {_Kasarian} - {Puro}");
        Console.WriteLine($"Selling price: {Presyo} pesos");
    }

    public void Nabenta()
    {
        Console.WriteLine($"Status: {nabili}");
        Console.WriteLine("");
    }

    public void Marco()
    {
        Console.WriteLine($"We have more available cats at our site! Visit www.MarcosDoggyHouse.com.ph");
        Console.WriteLine("");
        Console.WriteLine("");
    }
}

interface Iselling1
{
    string? Puro { get; set; }
    void Method1();
}

interface Iselling2 : Iselling1
{
    double Presyo { get; set; }
    void Method2();
}

public class Aso : Iselling1, Iselling2
{
    private string _Lahi { get; set; }

    private double _Bigat { get; set; }

    private string _Kasarian { get; set; }

    public string pangalan { get; set; }

    public string nabili { get; set; }

    public string? Puro { get; set; }
    public double Presyo { get; set; }
    public void Method1() { }
    public void Method2() { }

    public void hey()
    {
        Console.WriteLine("Hoy! Hoy! Hoy!");
    }

    public void sound()
    {
        Console.WriteLine("Arf!");
    }

    public Aso() { }

    public Aso(double bigat)
    {

        _Bigat = bigat;
    }

    public Aso(double bigat, string lahi, string kasarian) : this(bigat)
    {
        _Lahi = lahi;
        _Kasarian = kasarian;
    }


    public void Tahol()
    {
        Console.WriteLine($"{_Lahi} - {_Bigat} - {_Kasarian} - Name: {pangalan} - {Puro}");
        Console.WriteLine($"Selling price: {Presyo} pesos");
    }

    public void Nabenta()
    {
        Console.WriteLine($"Status: {nabili}");
        Console.WriteLine("");
    }

    public void Marco()
    {
        Console.WriteLine($"We have more available dogs at our site! Visit www.MarcosDoggyHouse.com.ph");
        Console.WriteLine("");
        Console.WriteLine("");
    }
}