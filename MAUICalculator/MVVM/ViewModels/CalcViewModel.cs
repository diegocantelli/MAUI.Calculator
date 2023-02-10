using System;
using System.Windows.Input;
using PropertyChanged;

namespace MAUICalculator.MVVM.ViewModels
{
	[AddINotifyPropertyChangedInterface]
	public class CalcViewModel
	{
		public string Formula { get; set; }
		public string Result { get; set; } = "0";

		public ICommand OperationCommand =>
			new Command((number) => { Formula += number; });


	}
}

