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

namespace Obyvi
{
    /// <summary>
    /// Логика взаимодействия для Glavnoe.xaml
    /// </summary>
    public partial class Glavnoe : Page
    {
        public Glavnoe()
        {
            InitializeComponent();
            
            var currentGlazki = Lopatkin41Entities.GetContext().Product.ToList();
            ObyviGlavnoeListView.ItemsSource = currentGlazki;
        }
    }
}
