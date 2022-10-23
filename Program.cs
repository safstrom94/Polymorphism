using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Ellips ellips = new Ellips();
            Parallellogram parallellogram = new Parallellogram();
            Rektangel rektangel = new Rektangel();
            Fyrkant fyrkant = new Fyrkant();
            Cirkel cirkel = new Cirkel();
            Console.WriteLine("Area cirkel :" + cirkel.Area());
            Console.WriteLine("Area fyrkant :" + fyrkant.Area());
            Console.WriteLine("Area rektamgel :" + rektangel.Area());

        }
    }
}
//går även att få ut Ellips och Parallellogram men det frågas inte efter i upggiften så är lite förvirad men hoppas det här är tillräckligt annars gör jag gärna om med en bettre förklaring.