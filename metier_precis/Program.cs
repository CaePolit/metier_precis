using metier_precis;
using System;

class Program
{
    public static void Main(string[] args)
    {
        string entry1 = Console.ReadLine();
        string entry2 = Console.ReadLine();
        double hauteur = Convert.ToDouble(entry1);
        int nombreEtages = Convert.ToInt32(entry2);
        Building building = new Building(nombreEtages, hauteur);
        Console.WriteLine(" max floor size: "+ building.GetFloorMaxSize());
        

    }
}