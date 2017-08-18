using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Fourmi
    {
        public Random hasard = new Random();
        public string Nom { get; set; }
        public ObservableCollection<Etape> EtapeList { get; set; }

        public Fourmi(string nom = "Anonyme")
        {
            this.Nom = nom;
            this.EtapeList = new ObservableCollection<Etape>();
            for (int i = 0; i < hasard.Next(11); i++)
            {
                EtapeList.Add(new Etape{ NumeroTour = 1 });
            }
        }

        public override string ToString()
        {
            return "(Brouillon) " + this.Nom;
        }
    }
}
