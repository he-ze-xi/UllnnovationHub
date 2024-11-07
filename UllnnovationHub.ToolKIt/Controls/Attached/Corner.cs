using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UllnnovationHub.ToolKIt.Controls.Attached
{
	/// <summary>
	/// 附加属性，用于控件的圆角
	/// </summary>
	public class Corner
	{
		#region 圆角值
		public static CornerRadius GetValue(DependencyObject obj)
		{
			return (CornerRadius)obj.GetValue(ValueProperty);
		}

		public static void SetValue(DependencyObject obj, CornerRadius value)
		{
			obj.SetValue(ValueProperty, value);
		}

		public static readonly DependencyProperty ValueProperty =
			DependencyProperty.RegisterAttached("Value", typeof(CornerRadius), typeof(Corner), new PropertyMetadata(default));
		#endregion
	}
}
