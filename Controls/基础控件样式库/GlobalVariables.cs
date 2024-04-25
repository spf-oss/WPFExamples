using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace 基础控件样式库
{
    public class GlobalVariables : DependencyObject
    {
        static GlobalVariables()
        {
            Instance = new GlobalVariables() { IsEnabled = false };
        }

        public static GlobalVariables Instance { get; set; }

        public static readonly DependencyProperty IsEnabledProperty =
            DependencyProperty.Register("IsEnabled", typeof(bool), typeof(GlobalVariables));

        public bool IsEnabled
        {
            get { return (bool)GetValue(IsEnabledProperty); }
            set { SetValue(IsEnabledProperty, value); }
        }
    }
}
