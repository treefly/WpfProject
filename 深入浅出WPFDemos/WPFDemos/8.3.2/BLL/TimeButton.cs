using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace _8._3._2.BLL
{

    class TimeButton : Button
    {
        //声明和注册路由事件
        public static readonly RoutedEvent ReportTimeEvent =
            EventManager.RegisterRoutedEvent("ReportTime", RoutingStrategy.Bubble, typeof(EventHandler<ReportTimeEventArgs>), typeof(TimeButton));

        //CLR事件包装器
        public event RoutedEventHandler ReportTime
        {
            add { this.AddHandler(ReportTimeEvent, value); }
            remove { this.RemoveHandler(ReportTimeEvent, value); }
        }

        //激发路由事件，借用Click事件的激发方法
        protected override void OnClick()
        {
            //保证Button原有功能的正常使用、Click事件能被激发
            base.OnClick();

            ReportTimeEventArgs args = new ReportTimeEventArgs(ReportTimeEvent, this);
            args.ClickTime = DateTime.Now;
            this.RaiseEvent(args);
        }
    }
    //用于承载时间消息的事件参数
    class ReportTimeEventArgs : RoutedEventArgs
    {
        public ReportTimeEventArgs(RoutedEvent routedEvent, object source) : base(routedEvent, source) { }
        public DateTime ClickTime { get; set; }
    }
}
