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
using System.Windows.Shapes;

namespace WpfExample.Data
{
    /// <summary>
    /// ExampleBindingDirection.xaml 的交互逻辑
    /// </summary>
    public partial class ExampleBindingDirection : Window
    {
        /*
         *  你使用Mode属性指定绑定的方向。 以下枚举列表显示了可供绑定更新的选项：
            TwoWay 当发生更改时的目标属性或源属性更新目标属性。
            OneWay 仅当源属性更改时，请更新目标属性。
            OneTime 仅当应用程序启动时或时，请更新目标属性DataContext发生了更改。
            OneWayToSource 目标属性更改时，请更新源属性。
            Default 默认值将导致Mode要使用的目标属性的值。
         */
        public ExampleBindingDirection()
        {
            InitializeComponent();
        }
    }
}
