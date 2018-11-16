using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace WpfExample.Data
{
    /// <summary>
    /// ExampleBindingCollection.xaml 的交互逻辑
    /// </summary>
    public partial class ExampleBindingCollection : Window
    {
        public  ObservableCollection<Person> _persons = new ObservableCollection<Person>()
        {
            new Person {FirstName = "1", LastName = "2", HomeTown = "3"},
            new Person {FirstName = "4", LastName = "5", HomeTown = "6"},
            new Person {FirstName = "7", LastName = "8", HomeTown = "9"},
            new Person {FirstName = "10", LastName = "11", HomeTown = "12"},
        };
        public ExampleBindingCollection()
        {
            InitializeComponent();
        }
      
    }
}
