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

namespace data_templates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowModelView();
        }
    }

    public class MainWindowModelView
    {
        public Movie CurrentMovie { get; set; }

        public MainWindowModelView()
        {
            CurrentMovie = new Movie
            {
                Name = "Matrix",
                Year = 1999,
                HoursWatched = 20000,
                Cast = new List<string> { "Keanu Reeves", "Laurance Fishburne", "Carrie Moss" }
            };
        }
    }
}
