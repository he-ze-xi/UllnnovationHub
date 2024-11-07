using Prism.Mvvm;

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

		public MainWindowViewModel()
		{

		}
	}
}
