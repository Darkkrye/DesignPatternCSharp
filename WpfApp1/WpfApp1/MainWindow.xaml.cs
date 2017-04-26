using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // FourmiliereViewModel FourmiliereVM = new FourmiliereViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = App.FourmiliereVM;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            App.FourmiliereVM.AjouteFourmi();
        }

        private void BtnSuppr_Click(object sender, RoutedEventArgs e)
        {
            App.FourmiliereVM.SupprimeFourmi();
        }
    }
}
