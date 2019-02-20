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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _12._4._1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation daX = new DoubleAnimation();
            DoubleAnimation daY = new DoubleAnimation();

            //设置
            BounceEase be = new BounceEase();
            be.Bounces = 3;//弹跳三次
            be.Bounciness = 3;//弹跳程度，值越大反弹越低
            daY.EasingFunction = be;

            //指定终点
            Random r = new Random();
            daX.To =300;
            daY.To =300;

            //指定时长
            Duration duration = new Duration(TimeSpan.FromMilliseconds(2000));
            daX.Duration = duration;
            daY.Duration = duration;

            //动画的主体是TranslateTransform变形，而非Button
            this.tt.BeginAnimation(TranslateTransform.XProperty,daX);
            this.tt.BeginAnimation(TranslateTransform.YProperty,daY);
        }
    }
}
