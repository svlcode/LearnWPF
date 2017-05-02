using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace CommandBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CommandBinding copyBinding = new CommandBinding(ApplicationCommands.Copy);
            CommandBinding pasteBinding = new CommandBinding(ApplicationCommands.Paste);

            CommandBindings.Add(copyBinding);
            CommandBindings.Add(pasteBinding);

            copyBinding.Executed += Binding_Executed;
            pasteBinding.Executed += Binding_Executed;
        }

        private void Binding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Debug.WriteLine("Command executed");
        }
    }
}
