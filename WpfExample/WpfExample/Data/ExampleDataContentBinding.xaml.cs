using System;
using System.Collections.Generic;
using System.ComponentModel;
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


    /*
     * Source:将源设置为对象的实例
     *
     * RelativeSource：相对于绑定目标位置的源
     *
     * ElementName 绑定一个元素的属性
     *
     */
    /// <summary>
    /// ExampleDataContentBinding.xaml 的交互逻辑
    /// </summary>
    public partial class ExampleDataContentBinding : Window
    {
        public ExampleDataContentBinding()
        {
            InitializeComponent();
        }
    }

    public class NetIncome : INotifyPropertyChanged
    {
        private int totalIncome = 5000;
        private int rent = 2000;
        private int food = 0;
        private int misc = 0;
        private int savings = 0;
        public NetIncome()
        {
            savings = totalIncome - (rent + food + misc);
        }

        public int TotalIncome
        {
            get
            {
                return totalIncome;
            }
            set
            {
                if (TotalIncome != value)
                {
                    totalIncome = value;
                    OnPropertyChanged("TotalIncome");
                }
            }
        }
        public int Rent
        {
            get
            {
                return rent;
            }
            set
            {
                if (Rent != value)
                {
                    rent = value;
                    OnPropertyChanged("Rent");
                    UpdateSavings();
                }
            }
        }
        public int Food
        {
            get
            {
                return food;
            }
            set
            {
                if (Food != value)
                {
                    food = value;
                    OnPropertyChanged("Food");
                    UpdateSavings();
                }
            }
        }
        public int Misc
        {
            get
            {
                return misc;
            }
            set
            {
                if (Misc != value)
                {
                    misc = value;
                    OnPropertyChanged("Misc");
                    UpdateSavings();
                }
            }
        }
        public int Savings
        {
            get
            {
                return savings;
            }
            set
            {
                if (Savings != value)
                {
                    savings = value;
                    OnPropertyChanged("Savings");
                    UpdateSavings();
                }
            }
        }

        private void UpdateSavings()
        {
            Savings = TotalIncome - (Rent + Misc + Food);
            if (Savings < 0)
            { }
            else if (Savings >= 0)
            { }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
