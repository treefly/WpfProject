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

namespace _8._3._3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //为主窗体添加对Button.Click事件的侦听
            this.AddHandler(Button.ClickEvent,new RoutedEventHandler(this.Button_Click));
        }

        //路由器事件处理
        private void Button_Click(object sender,RoutedEventArgs e)
        {
            string strOrigialSource = string.Format("VisualTree start point:{0},type is {1}",(e.OriginalSource as FrameworkElement).Name,e.OriginalSource.GetType().Name);

            string strSource = string.Format("LogicalTree start point:{0},type is {1}",(e.Source as FrameworkElement).Name,e.Source,e.Source.GetType().Name);

            MessageBox.Show(strOrigialSource+"\r\n"+strSource);
        }
    }
}
