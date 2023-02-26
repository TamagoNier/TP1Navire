using System;
using System.Collections.Generic;
using System.Text;

namespace TP1Navire
{
    class Port
    {
        private string nom;
        private int nbNaviresMax;
        private List<Navire> navires;

        public Port(string nom)
        {
            this.nom = nom;
            this.nbNaviresMax = 5;
            this.navires = new List<Navire>();

        }

        public string Nom { get => nom; }
        public int NbNaviresMax { get => nbNaviresMax; set => nbNaviresMax = value; }
        internal List<Navire> Navires { get => navires; set => navires = value; }

        public void EnregistrerArrive(Navire navire)
        {
            if (this.navires.Count == this.NbNaviresMax)
            {
                throw new Exception("Ajout Impossible, le port est complet");
            }
            else
            {
                this.navires.Add(navire);
            }
        }

        public void EnregistrerDepart(string imo)
        {
            if (EstPresent(imo))
            {
                int indice = RecupPosition(imo);
                if (indice != -1)
                {
                    this.navires.RemoveAt(indice);
                }
                else
                {
                    throw new Exception("Le port ne contient pas de bateau comportant cet IMO");
                }

            }
        }

        public bool EstPresent(string imo)
        {
            foreach (Navire navire in this.navires)
            {
                if (navire.Imo == imo)
                {
                    return true;
                }
            }
            return false;
        }

        public int RecupPosition(string imo)
        {
            for (int i = 0; i < this.navires.Count; i++)
            {
                if (this.navires[i].Imo == imo)
                {
                    return i;
                }
            }
            return -1;
        }

        public int RecupPosition(Navire navire)
        {
            if (this.navires.Contains(navire))
            {
                return this.navires.IndexOf(navire);
            }
            else
            {
                return -1;
            }
        }
        public void TestRecupPosition()
        {
            Navire test1 = new Navire("IMO1564879", "SS Test1");
            Navire test2 = new Navire("IMO1564880", "SS Test2");
            Navire test3 = new Navire("IMO1564881", "SS Test3");
            Navire test4 = new Navire("IMO1564882", "SS Test4");

            this.EnregistrerArrive(test1);
            this.EnregistrerArrive(test2);
            this.EnregistrerArrive(test3);

            Console.WriteLine("Indice du SS Test1 (" + test1.Imo + ") : " + this.RecupPosition(test1.Imo));
            Console.WriteLine("Indice du SS Test2 (" + test3.Imo + ") : " + this.RecupPosition(test3.Imo));
            Console.WriteLine("Indice du SS Test4 (" + test4.Imo + ") : " + this.RecupPosition(test4.Imo));
        }

        public void TesteRecupPositV2()
        {
            Navire depardieux = new Navire("IMO1564879", "SS Depardieux");
            Navire astier = new Navire("IMO1564880", "SS Astier");
            Navire chabat = new Navire("IMO1564881", "SS Chabat");
            Navire darmon = new Navire("IMO1564882", "SS Darmon");

            this.EnregistrerArrive(depardieux);
            this.EnregistrerArrive(astier);
            this.EnregistrerArrive(chabat);
            this.EnregistrerArrive(darmon);

            Console.WriteLine("Indice du SS Astier (" + astier.Imo +") : " + this. RecupPosition(astier));
            Console.WriteLine("Indice du SS Darmon (" + depardieux.Imo + ") : " + this.RecupPosition(depardieux));
        }
    }
}



