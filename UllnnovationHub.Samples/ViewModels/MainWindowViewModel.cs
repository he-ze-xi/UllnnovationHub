using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using UllnnovationHub.Samples.Models;
using UllnnovationHub.ToolKIt;
using UllnnovationHub.ToolKIt.UI;

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

		#region DataGrid控件相关
		private ObservableCollection<PersonModel> _people = new ObservableCollection<PersonModel>();
		public ObservableCollection<PersonModel> People
		{
			get { return _people; }
			set { SetProperty(ref _people, value); }
		}
		#endregion

		public ICommand Cmd_TestMessageBox01 { get; set; }

		public MainWindowViewModel()
		{
			// 初始化示例数据
			People = new ObservableCollection<PersonModel>
		{
			new PersonModel { Id = 1, Name = "张三", Age = 28, Department = "研发部", Position = "高级开发工程师" },
			new PersonModel { Id = 2, Name = "李四", Age = 32, Department = "产品部", Position = "产品经理" },
			new PersonModel { Id = 3, Name = "王五", Age = 25, Department = "设计部", Position = "UI设计师" },
			new PersonModel { Id = 4, Name = "赵六", Age = 30, Department = "研发部", Position = "架构师" },
			new PersonModel { Id = 5, Name = "钱七", Age = 27, Department = "测试部", Position = "测试工程师" },
			new PersonModel { Id = 6, Name = "孙八", Age = 35, Department = "运营部", Position = "运营总监" },
			new PersonModel { Id = 7, Name = "周九", Age = 29, Department = "市场部", Position = "市场专员" },
			new PersonModel { Id = 8, Name = "吴十", Age = 31, Department = "销售部", Position = "销售经理" },
			new PersonModel { Id = 9, Name = "郑十一", Age = 26, Department = "研发部", Position = "前端开发工程师" },
			new PersonModel { Id = 10, Name = "王十二", Age = 33, Department = "人事部", Position = "人力资源主管" }
		};

			Cmd_TestMessageBox01 = new DelegateCommand(TestMessageBox01);
		}

		private void TestMessageBox01()
		{

		}
	}
}
