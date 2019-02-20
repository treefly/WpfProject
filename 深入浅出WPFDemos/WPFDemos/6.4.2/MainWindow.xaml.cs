using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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


namespace _6._4._2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //种类
        public enum Category
        {
            Bomber,
            Fighter
        }

        //状态
        public enum State
        {
            Available,
            Locked,
            Unknown
        }

        //飞机
        public class Plane
        {
            public Category Category { get; set; }
            public string Name { get; set; }
            public State State { get; set; }
        }

        private void buttonLoad_Click(object sender, RoutedEventArgs e)
        {
            List<Plane> planeList = new List<Plane>()
            {
                new Plane() {Category=Category.Bomber,Name="B-1",State=State.Unknown },
                new Plane() {Category=Category.Bomber,Name="B-2",State=State.Unknown },
                new Plane() {Category=Category.Fighter,Name="F-22",State=State.Unknown },
                new Plane() {Category=Category.Fighter,Name="Su-47",State=State.Unknown },
                new Plane() {Category=Category.Bomber,Name="B-52",State=State.Unknown },
                new Plane() {Category=Category.Fighter,Name="J-10",State=State.Unknown }
            };
            this.listBox1.ItemsSource = planeList;
        }

        //Save按钮Click事件处理器
        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Plane p in listBox1.Items)
            {
                sb.AppendLine(string.Format("Category={0},Name={1},State={2}",p.Category,p.Name,p.State));
            }

            File.WriteAllText(@"D:/PlaneList.txt",sb.ToString());
        }
    }
}
