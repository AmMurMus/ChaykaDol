using System.Windows;

namespace ChaykaDol
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnChildren_Click(object sender, RoutedEventArgs e) =>
            MainFrame.Navigate(new ChildrenPage());

        private void BtnGroups_Click(object sender, RoutedEventArgs e) =>
            MainFrame.Navigate(new GroupsPage());

        private void BtnRequests_Click(object sender, RoutedEventArgs e) =>
            MainFrame.Navigate(new HealthRequestsPage());

        private void BtnEvents_Click(object sender, RoutedEventArgs e) =>
            MainFrame.Navigate(new EventsPage());
    }
}