#UllnnovationHub
### 1.项目说明
本项目名称为UllnnovationHub，寓意为这个仓库是一个寻求和分享UI设计创新的地方。希望大家可以在这个仓库里发挥自己的构想。
本项目以提升WPF技术为主要任务，建立控件库为辅。
### 2.开发规范
1. 控件库中添加新的页面控件应选择自定义控件而不是用户控件。理由如下：自定义控件可以通过ControlTemplate对控件的外观灵活地进行定制。
2. 在自定义控件中添加属性时应尽量使用依赖属性（有些只读属性可以使用CLR属性），因为只有依赖属性才可以作为Binding的Target。WPF中创建依赖属性可以做到很复杂，而再简单也要好几行代码。在自定义控件中创建依赖属性通常包含以下几部分：
>
* 注册依赖属性并生成依赖属性标识符。依赖属性标识符为一个public static readonly DependencyProperty字段。依赖属性标识符的名称必须为“属性名+Property”。在PropertyMetadata中指定属性默认值。
* 实现属性包装器。为属性提供 CLR get 和 set 访问器，在Getter和Setter中分别调用GetValue和SetValue，除此之外Getter和Setter中不应该有其它任何自定义代码。
* 需要监视属性值变更。在PropertyMetadata中定义一个PropertyChangedCallback方法，因为这个方法是静态的，可以再实现一个同名的实例方法（可以参考ContentControl的OnContentChanged方法）。
