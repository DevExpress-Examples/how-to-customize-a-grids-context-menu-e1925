<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1925)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to customize a grid's context menu


<p>The following example demonstrates how to customize the context menu, which is shown for different UI elements of the DXGrid control.</p>


<h3>Description</h3>

<p>In this example, a new item is added to the context menu of a grid column. For this, it is necessary to add a corresponding bar item (e.g. <strong>BarCheckItem</strong>) to the <strong>GridViewBase.ColumnMenuCustomizations</strong> collection and specify different item properties. Also, you can insert this item into a specific position by attaching the <strong>BarItemLinkActionBase.ItemLinkIndex</strong> property to it.</p><p>In addition, this example illustrates how to remove a bar item from the context menu, which is shown for the Total Summary panel. For this, the <strong>RemoveBarItemAndLinkAction</strong> object is added to the <strong>GridViewBase.TotalSummaryMenuCustomizations</strong> collection, and the name of the bar item is specified by the corresponding property of the <strong>DefaultSummaryMenuItemNames</strong> class.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-customize-a-grids-context-menu-e1925&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-customize-a-grids-context-menu-e1925&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
