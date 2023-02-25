using System;

namespace TP1Navire
{
    class Program
    {
        static void Main(string[] args)
        {
            TesterInstanciations();

            Console.ReadKey();
        }

        private static void TesterInstanciations()
        {
            //Declaration de l'objet unNavire de la classe Navire
            Navire unNavire;

            //Instantiation de l'objet
            unNavire = new Navire("IMO9427639", "Copper Spirit", "Hydrocarbures", 156827);

            //Declaration et instantiation de d'un autre objet de la classe Navire
            Navire unAutreNavire = new Navire("IMO9839272", "MSC Isabella", "Porte-conteneurs", 197500);

            //??
            unAutreNavire = new Navire("IMO8715871", "MSC PILAR");

            Console.WriteLine("Fin de la Methode");
        }
    }
}
