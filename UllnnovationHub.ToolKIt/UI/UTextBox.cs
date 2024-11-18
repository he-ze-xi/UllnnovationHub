using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UllnnovationHub.ToolKIt.UI
{
	public class UTextBox : TextBox
	{
		#region Placeholder
		public string Placeholder
		{
			get { return (string)GetValue(PlaceholderProperty); }
			set { SetValue(PlaceholderProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Placeholder.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty PlaceholderProperty =
			DependencyProperty.Register("Placeholder", typeof(string), typeof(UTextBox));


		#endregion
		#region CornerRadius
		public CornerRadius CornerRadius
		{
			get { return (CornerRadius)GetValue(CornerRadiusProperty); }
			set { SetValue(CornerRadiusProperty, value); }
		}

		// Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty CornerRadiusProperty =
			DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(UTextBox), new PropertyMetadata(null));


		#endregion

		#region PlaceholderForeground
		public Brush PlaceholderForeground
		{
			get { return (Brush)GetValue(PlaceholderForegroundProperty); }
			set { SetValue(PlaceholderForegroundProperty, value); }
		}

		// Using a DependencyProperty as the backing store for PlaceholderForeground.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty PlaceholderForegroundProperty =
			DependencyProperty.Register("PlaceholderForeground", typeof(Brush), typeof(UTextBox), new FrameworkPropertyMetadata());


		#endregion

		#region FocusedForeground
		public Brush FocusedForeground
		{
			get { return (Brush)GetValue(FocusedForegroundProperty); }
			set { SetValue(FocusedForegroundProperty, value); }
		}

		// Using a DependencyProperty as the backing store for FocusedForeground.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty FocusedForegroundProperty =
			DependencyProperty.Register("FocusedForeground", typeof(Brush), typeof(UTextBox), new FrameworkPropertyMetadata());


		#endregion

		#region FocusedBorderBrush
		public Brush FocusedBorderBrush
		{
			get { return (Brush)GetValue(FocusedBorderBrushProperty); }
			set { SetValue(FocusedBorderBrushProperty, value); }
		}

		// Using a DependencyProperty as the backing store for FocusedBorderBrush.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty FocusedBorderBrushProperty =
			DependencyProperty.Register("FocusedBorderBrush", typeof(Brush), typeof(UTextBox), new FrameworkPropertyMetadata());


		#endregion

		#region FocusedBackground
		public Brush FocusedBackground
		{
			get { return (Brush)GetValue(FocusedBackgroundProperty); }
			set { SetValue(FocusedBackgroundProperty, value); }
		}

		// Using a DependencyProperty as the backing store for FocusedBackground.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty FocusedBackgroundProperty =
			DependencyProperty.Register("FocusedBackground", typeof(Brush), typeof(UTextBox), new FrameworkPropertyMetadata());


		#endregion

		static UTextBox()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(UTextBox), new FrameworkPropertyMetadata(typeof(UTextBox)));
		}
	}
}
