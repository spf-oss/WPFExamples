using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础控件样式库
{
    internal class MainWindowViewModel : NotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            this.Name = "名字";
            this.IsEnabled = true;
        }

        private string name;

		public string Name
		{
			get => name;
            set => this.SetProperty(ref name, value);
		}

		private bool isEnabled;

		public bool IsEnabled
		{
			get => isEnabled;
			set => this.SetProperty(ref isEnabled, value);
		}
	}
}
