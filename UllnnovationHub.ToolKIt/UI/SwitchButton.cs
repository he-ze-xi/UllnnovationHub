﻿using System;
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
	
	public class SwitchButton : CheckBox
	{
		#region CheckedBackground

		public static readonly DependencyProperty CheckedBackgroundProperty =
			DependencyProperty.Register(
				"CheckedBackground",
				typeof(Brush),
				typeof(SwitchButton),
				new FrameworkPropertyMetadata());

		public Brush CheckedBackground
		{
			get => (Brush)GetValue(CheckedBackgroundProperty);
			set => SetValue(CheckedBackgroundProperty, value);
		}
		#endregion

		#region MouseOverBackground

		public static readonly DependencyProperty MouseOverBackgroundProperty =
			DependencyProperty.Register(
				"MouseOverBackground",
				typeof(Brush),
				typeof(SwitchButton),
				new FrameworkPropertyMetadata());

		public Brush MouseOverBackground
		{
			get => (Brush)GetValue(MouseOverBackgroundProperty);
			set => SetValue(MouseOverBackgroundProperty, value);
		}
		#endregion

		#region ButtonBackground

		public static readonly DependencyProperty ButtonBackgroundProperty =
			DependencyProperty.Register(
				"ButtonBackground",
				typeof(Brush),
				typeof(SwitchButton),
				new FrameworkPropertyMetadata());

		public Brush ButtonBackground
		{
			get => (Brush)GetValue(ButtonBackgroundProperty);
			set => SetValue(ButtonBackgroundProperty, value);
		}
		#endregion

		#region CornerRadius

		public static readonly DependencyProperty CornerRadiusProperty =
			DependencyProperty.Register(
				"CornerRadius",
				typeof(CornerRadius),
				typeof(SwitchButton),
				new FrameworkPropertyMetadata());

		public CornerRadius CornerRadius
		{
			get => (CornerRadius)GetValue(CornerRadiusProperty);
			set => SetValue(CornerRadiusProperty, value);
		}
		#endregion
		static SwitchButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(SwitchButton), new FrameworkPropertyMetadata(typeof(SwitchButton)));
		}
	}
}
