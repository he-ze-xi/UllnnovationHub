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

		#region DateTimePicker控件相关
		private DateTime _currentDateTime=DateTime.Now;
		public DateTime CurrentDateTime
		{
			get { return _currentDateTime; }
			set { SetProperty(ref _currentDateTime, value); }
		}
		#endregion

		public MainWindowViewModel()
		{
			
		}

	}
}
