using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace 基础控件样式库
{
    public class NotifyPropertyChanged : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void SetProperty<T>(ref T feild, T value, [CallerMemberName] string propName = "")
        {
            feild = value;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
