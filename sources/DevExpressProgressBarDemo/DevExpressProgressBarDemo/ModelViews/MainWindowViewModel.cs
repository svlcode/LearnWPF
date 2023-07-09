using System.Collections.Generic;
using DevExpressProgressBarDemo.Model;

namespace DevExpressProgressBarDemo.ModelViews
{
    public class MainWindowViewModel
    {
        public List<Customer> Customers { get; set; }

        public MainWindowViewModel()
        {
            Customers = Customer.GetCustomers();
        } 
    }
}