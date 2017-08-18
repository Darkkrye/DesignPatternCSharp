using System.Collections.ObjectModel;

namespace WpfApp1
{
    public class FourmiliereViewModel
    {
        public string NomApplication { get; set; }
        public ObservableCollection<Fourmi> FourmiList { get; set; }

        public Fourmi FourmiSelect { get; set; }

        public FourmiliereViewModel()
        {
            this.NomApplication = "Fourmilière MOC 1";

            FourmiList = new ObservableCollection<Fourmi>();
            FourmiList.Add(new Fourmi("Alain"));
            FourmiList.Add(new Fourmi("Béatrice"));
            FourmiList.Add(new Fourmi("Cécile"));
            FourmiList.Add(new Fourmi("Denis"));

            for (int i = 0; i < 100; i++)
            {
                FourmiList.Add(new Fourmi("Fourmi n°" + FourmiList.Count));
            }
        }

        public void AjouteFourmi()
        {
            FourmiList.Add(new Fourmi("Fourmi n°" + FourmiList.Count));
        }

        public void SupprimeFourmi()
        {
            FourmiList.Remove(FourmiSelect);
        }
    }
}