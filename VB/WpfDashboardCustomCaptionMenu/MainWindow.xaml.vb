Imports DevExpress.DashboardCommon
Imports System.Windows

Namespace WpfDashboardCustomCaptionMenu

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DevExpress.Xpf.Core.ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
            Dim dashboard As DevExpress.DashboardCommon.Dashboard = New DevExpress.DashboardCommon.Dashboard()
            Dim group As DevExpress.DashboardCommon.DashboardItemGroup = New DevExpress.DashboardCommon.DashboardItemGroup()
            dashboard.Groups.Add(group)
            dashboard.Items.AddRange(New DevExpress.DashboardCommon.GridDashboardItem() With {.Group = group}, New DevExpress.DashboardCommon.ChartDashboardItem() With {.Group = group}, New DevExpress.DashboardCommon.TreemapDashboardItem())
            Me.dashboardControl1.Dashboard = dashboard
        End Sub
    End Class
End Namespace
