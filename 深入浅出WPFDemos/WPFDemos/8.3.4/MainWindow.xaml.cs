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

namespace _8._3._4
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //为外层Grid添加路由事件侦听器
            //this.gridMain.AddHandler(Student.NameChangedEvent,new 
            //    RoutedEventHandler(this.StudentNameChangedHandler));

            Student.AddNameChangedHandler(this.gridMain,new RoutedEventHandler(this.StudentNameChangedHandler));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student() { Id = 101, Name = "Tim" };
            stu.Name = "Tom";
            //准备事件消息并发送路由事件
            RoutedEventArgs arg = new RoutedEventArgs(Student.NameChangedEvent,stu);
            this.button1.RaiseEvent(arg);
        }

        //Grid捕捉到NameChangedEvent后的处理器
        private void StudentNameChangedHandler(object sender,RoutedEventArgs e)
        {
            MessageBox.Show((e.OriginalSource as Student).Id.ToString());
        }
    }
}
