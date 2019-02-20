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

namespace _7._3
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

        public class Human : DependencyObject
        {

        }
        public class School : DependencyObject
        {
            public static int GetGrade(DependencyObject obj)
            {
                return (int)obj.GetValue(GradeProperty);
            }

            public static void SetGrade(DependencyObject obj, int value)
            {
                obj.SetValue(GradeProperty, value);
            }

            // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
            public static readonly DependencyProperty GradeProperty =
                DependencyProperty.RegisterAttached("Grade", typeof(int), typeof(School), new PropertyMetadata(0));
        }
    

        private void btn_OK_Click(object sender, RoutedEventArgs e)
        {
            Human human = new Human();
            School.SetGrade(human,6);
            int grade = School.GetGrade(human);
            MessageBox.Show(grade.ToString());
        }
    }
}
