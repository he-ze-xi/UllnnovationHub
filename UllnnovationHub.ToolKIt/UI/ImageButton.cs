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
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:UllnnovationHub.ToolKIt.UI"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:UllnnovationHub.ToolKIt.UI;assembly=UllnnovationHub.ToolKIt.UI"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误:
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:ImageButton/>
    ///
    /// </summary>
    public class ImageButton : Button
    {
        //边框圆角
        public CornerRadius BorderCornerRadius
        {
            get { return (CornerRadius)GetValue(BorderCornerRadiusProperty); }
            set { SetValue(BorderCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BorderCornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BorderCornerRadiusProperty =
            DependencyProperty.Register("BorderCornerRadius", typeof(CornerRadius), typeof(ImageButton), new FrameworkPropertyMetadata());

        //图片与文字排列方式
        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Orientation.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(Orientation), typeof(ImageButton), new FrameworkPropertyMetadata());

        //图片与文字间距
        public Thickness ImgTextMargin
        {
            get { return (Thickness)GetValue(ImgTextMarginProperty); }
            set { SetValue(ImgTextMarginProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImgTextMargin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImgTextMarginProperty =
            DependencyProperty.Register("ImgTextMargin", typeof(Thickness), typeof(ImageButton), new FrameworkPropertyMetadata());

        //图片路径
        public ImageSource ImgSource
        {
            get { return (ImageSource)GetValue(ImgSourceProperty); }
            set { SetValue(ImgSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImgSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImgSourceProperty =
            DependencyProperty.Register("ImgSource", typeof(ImageSource), typeof(ImageButton), new FrameworkPropertyMetadata());

        //图片宽度
        public double ImgWidth
        {
            get { return (double)GetValue(ImgWidthProperty); }
            set { SetValue(ImgWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImgWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImgWidthProperty =
            DependencyProperty.Register("ImgWidth", typeof(double), typeof(ImageButton), new FrameworkPropertyMetadata());

        //图片高度
        public double ImgHeight
        {
            get { return (double)GetValue(ImgHeightProperty); }
            set { SetValue(ImgHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImgHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImgHeightProperty =
            DependencyProperty.Register("ImgHeight", typeof(double), typeof(ImageButton), new FrameworkPropertyMetadata());

        //文字内容
        public string TextContent
        {
            get { return (string)GetValue(TextContentProperty); }
            set { SetValue(TextContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextContentProperty =
            DependencyProperty.Register("TextContent", typeof(string), typeof(ImageButton), new FrameworkPropertyMetadata());

        //鼠标悬停背景色
        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MouseOverBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(ImageButton), new FrameworkPropertyMetadata());

        //鼠标点击背景色
        public Brush MousePressedBackground
        {
            get { return (Brush)GetValue(MousePressedBackgroundProperty); }
            set { SetValue(MousePressedBackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MousePressedBackground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MousePressedBackgroundProperty =
            DependencyProperty.Register("MousePressedBackground", typeof(Brush), typeof(ImageButton), new FrameworkPropertyMetadata());


        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
        }
    }
}
