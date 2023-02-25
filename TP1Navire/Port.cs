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
            if (this.EstPresent(imo))
            {
                for (int i = 0; i > this.navires.Count - 1; i++)
                {
                    if (this.navires[i].Imo == imo)
                    {
                        this.navires.RemoveAt(i);
                    }
                }
            }
            else
            {
                throw new Exception("Le navire n'est pas present dans le port");
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

        //private int RecupPosition(string imo)
        //{
        //    if (this.EstPresent(imo))
        //    {
        //        for (int i = 0; i > this.navires.Count - 1; i++)
        //        {
        //            if (this.navires[i].Imo == imo)
        //            {
        //                return i;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}

        private int RecupPosition(Navire navire)
        {
            if (this.navires.Contains(navire)) {
                int retour = this.navires.BinarySearch(navire);
                return retour;
            }
            else
            {
                return -1;
            }
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



