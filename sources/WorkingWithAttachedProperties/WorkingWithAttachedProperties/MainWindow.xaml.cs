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

namespace WorkingWithAttachedProperties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Working with Grid.RowProperty which is a DependencyProperty which is managed by .NET.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DemoButton_Click(object sender, RoutedEventArgs e)
        {
            int row = (int)DemoButton.GetValue(Grid.RowProperty);

            row = (row + 1) % LayoutRoot.RowDefinitions.Count;

            DemoButton.SetValue(Grid.RowProperty, row);
        }
    }
}
