# UllnnovationHub

一个寻求和分享设计灵感的开源WPF应用程序UI库(注：目前项目正在开发中)

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Stars](https://img.shields.io/github/stars/jamesnet214/xamldesignwpf.svg)](https://github.com/he-ze-xi/UllnnovationHub/stargazers)

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



### 4.致谢

如果你觉得本框架还不错的话，欢迎赞助一杯咖啡

![](\README.assets\image-20241113205006149.png)

![](\README.assets\image-20241113205018657.png)
