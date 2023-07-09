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

namespace custom_commands
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

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //MessageBox.Show("command executed");
            RichTextBox rtb = sender as RichTextBox;
            rtb.Selection.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.YellowGreen);
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            RichTextBox rtb = sender as RichTextBox;
            if (rtb.Selection.IsEmpty)
                e.CanExecute = false;
            else
                e.CanExecute = true;
        }
    }
}
