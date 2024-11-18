using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows;
using System.Windows.Input;
using UllnnovationHub.ToolKIt;

namespace UllnnovationHub.Samples.ViewModels
{
	public class MainWindowViewModel : BindableBase
	{
		private string _title = "UllnnovationHub";
		public string Title
		{
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}
		public ICommand GroupBoxButton1Cmd { get; set; }

		public MainWindowViewModel()
		{
			
		}

	}
}
