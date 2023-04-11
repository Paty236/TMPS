using System;

class Program
{
    static void Main(string[] args)
    {
        // Obținem obiectul de la fabrică
        IBaseClass obj = Factory.GetObject();

        // Apelam metoda de imprimare pe obiect
        obj.Print();

        // Clonam obiectul și apelați metoda de imprimare pe clonă
        IBaseClass objClone = obj.Clone();
        objClone.Print();

        // Așteptam ca utilizatorul să apese o tastă pentru a închide fereastra
        Console.ReadKey();
    }
}
