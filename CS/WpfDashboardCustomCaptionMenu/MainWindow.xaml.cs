using DevExpress.DashboardCommon;
using System.Windows;

namespace WpfDashboardCustomCaptionMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Dashboard dashboard = new Dashboard();
            DashboardItemGroup group = new DashboardItemGroup();
            dashboard.Groups.Add(group);
            dashboard.Items.AddRange(
                new GridDashboardItem() { Group = group }, 
                new ChartDashboardItem() { Group = group }, 
                new TreemapDashboardItem());
            dashboardControl1.Dashboard = dashboard;
        }
    }
}
