using _11._2_.UserControls;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace _11._2_
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitialCarList();
        }

        //初始化ListBox
        private void InitialCarList()
        {
            List<Car> carList = new List<Car>()
            {
                new Car() {Automaker="Lamborghini",Name="Diablo",Year="1990",TopSpeed="340" },
                 new Car() {Automaker="Lamborghini",Name="Murcielago",Year="2001",TopSpeed="353" },
                  new Car() {Automaker="Lamborghini",Name="Gallardo",Year="2003",TopSpeed="325" },
                   new Car() {Automaker="Lamborghini",Name="Reventon",Year="2008",TopSpeed="356" },
            };

            //填充数据源
            this.listBoxCars.ItemsSource = carList;
        }
    }
}
