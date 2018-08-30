# How to add custom buttons and menu elements to dashboard item captions

This example demonstrates how to apply the **CaptionCustomizationsTemplate** and **ContextMenuCustomizationsTemplate** templates to customize the caption toolbar and context menu.

![](https://github.com/DevExpress-Examples/wpf-dashboard-how-to-add-custom-caption-menu/blob/18.1.6%2B/images/wpf-dashboard-how-to-add-custom-caption-menu.png)

The following properties are used:
- [DashboardControl.TitleCustomizationsTemplate](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControlBase.TitleCustomizationsTemplate) to specify a data template to display a dashboard title;
- [DashboardControl.ItemGroupStyle](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControlBase.ItemGroupStyle) to specify a style for dashboard groups (a group is the [DashboardLayoutGroup](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardLayoutGroup) type);
- [DashboardControl.DashBoardItemStyle](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControlBase.DashBoardItemStyle) to specify a style for a dashboard item of any type;
- [DashboardControl.GridItemStyle](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControlBase.GridItemStyle) to specify a style for the [GridDashboardLayoutItem](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.GridDashboardLayoutItem) type.

In a dashboard item's custom style, the [DashboardLayoutItem.CaptionCustomizationsTemplate](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardLayoutItem.CaptionCustomizationsTemplate) property specifies a template for the dashboard item's caption toolbar. The [DashboardLayoutItem.ContextMenuCustomizationsTemplate](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardLayoutItem.ContextMenuCustomizationsTemplate) property specifies a template for the dashboard item's context menu.

In a group item's custom style, set the  [DashboardGroupItem.CaptionCustomizationsTemplate](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardGroupItem.CaptionCustomizationsTemplate) and  [DashboardGroupItem.ContextMenuCustomizationsTemplate](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardGroupItem.ContextMenuCustomizationsTemplate) properties, respectively.

The data template in a custom style uses the [InsertAction](https://docs.devexpress.com/WPF/DevExpress.Xpf.Bars.InsertAction) class to insert a button or a drop-down menu. The **InsertAction.Index** property specifies a position to insert.
