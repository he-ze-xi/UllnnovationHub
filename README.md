#UllnnovationHub
### 1.项目说明
本项目名称为UllnnovationHub，寓意为这个仓库是一个寻求和分享UI设计创新的地方。希望大家可以在这个仓库里发挥自己的构想。
本项目以提升WPF技术为主要任务，建立控件库为辅。
### 2.开发规范
1. 控件库中添加新的页面控件应选择自定义控件而不是用户控件。理由如下：自定义控件可以通过ControlTemplate对控件的外观灵活地进行定制。
2. 在自定义控件中添加属性时应尽量使用依赖属性（有些只读属性可以使用CLR属性），因为只有依赖属性才可以作为Binding的Target。

### 3.任务(截至11.11日)
1. 写一个自定义进度滑动条、一个带有图标的按钮(图标在左侧部位)。
2. Combox、GroupBox、CheckBox、ListBox、ListView、TextBox、RadioButton