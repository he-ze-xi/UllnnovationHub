# UllnnovationHub

一个寻求和分享设计灵感的开源WPF应用程序UI库(注：目前项目正在开发中)

### 1.项目概述
UllnnovationHub，旨在寻求和分享WPF UI设计灵感。它提供了众多主题的WPF原生控件和自定义控件，未来还将继续加入更多的控件样式。

### 2.开发环境
Windows 11 + Visual Studio 2022 Enterprise+ .NET 6.0

### 3.使用方法

```xaml
//引用命名空间
xmlns:UI="clr-namespace:UllnnovationHub.ToolKIt.UI;assembly=UllnnovationHub.ToolKIt" 
//使用控件
<UI:Card Margin="20"/>
//使用样式
<GroupBox Header="测试" Margin="10" Style="{StaticResource BaseGroupBoxStyle}"/>
<GroupBox Header="测试" Margin="10" Style="{StaticResource SqureShadowHeaderGroupBoxStyle}"/>
<GroupBox Header="测试" Margin="10" Style="{StaticResource RoundedShadowHeaderGroupBoxStyle}"/>

```

### 4.参考资料
因笔者抱着边学习边开发的的目的，项目部分代码参考整理自以下开发者仓库，若造成不便请联系本人：
1. https://github.com/944095635/DMSkin
2. https://github.com/DinoChan/Kino.Toolkit.Wpf
3. https://github.com/JamesnetGroup/xamldesign.wpf

### 5.致谢

如果你觉得本框架还不错的话，欢迎赞助一杯咖啡

![](https://github.com/he-ze-xi/UllnnovationHub/blob/master/ReadMe.Assests/wechat.png)

![](https://github.com/he-ze-xi/UllnnovationHub/blob/master/ReadMe.Assests/ali.png)

