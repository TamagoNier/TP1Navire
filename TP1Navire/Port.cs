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
        }

        public string Nom { get => nom; }
        public int NbNaviresMax { get => nbNaviresMax; set => nbNaviresMax = value; }

        public void EnregistrerArrive(Navire navire)
        {
            if(this.navires.Count == this.NbNaviresMax)
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
                this.navires.RemoveAt(RecupPosition(imo));
            }
            else
            {
                throw new Exception("Le navire n'est pas present dans le port");
            }
            
        }

        public bool EstPresent(string imo)
        {
            for(int i = 0; i > this.navires.Count; i++)
            {
                if(this.navires[i].Imo == imo)
                {
                    return true;
                }
            }
            return false;
        }

        private int RecupPosition(string imo)
        {
            if (this.EstPresent(imo))
            {
                for (int i = 0; i > this.navires.Count - 1; i++)
                {
                    if (this.navires[i].Imo == imo)
                    {
                        int retour = i;
                        return retour;
                    }
                }
            }
            else
            {
                return -1;
            }
        }

        private int RecupPosition(Navire navire)
        {
            if (this.navires.Contains(navire)){
                int retour = this.navires.BinarySearch(navire);
                return retour;
            }
            else
            {
                return -1;
            }
        }
    }
}
