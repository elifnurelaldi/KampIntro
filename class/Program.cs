using System;

namespace class
{
    class Program
{
    static void Main(string[] args)
    {
        string adi = "Engin";
        int yas = 36;

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin Demiroğ";


        Console.WriteLine("Hello World!");
    }
}


class Kurs
{
    public string KursAdi { get; set; }

}
}
