Imports DevExpress.DashboardCommon
Imports System.Windows

Namespace WpfDashboardCustomCaptionMenu
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            Dim dashboard As New Dashboard()
            Dim group As New DashboardItemGroup()
            dashboard.Groups.Add(group)
            dashboard.Items.AddRange(New GridDashboardItem() With {.Group = group}, New ChartDashboardItem() With {.Group = group}, New TreemapDashboardItem())
            dashboardControl1.Dashboard = dashboard
        End Sub
    End Class
End Namespace
