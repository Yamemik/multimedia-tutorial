using System;
using System.Windows;

namespace MultimediaTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ManagerFrame.MainFrame = mainFrame;
            ManagerFrame.MainFrame.Navigate(new TitlePage());
        }

        private void MainFrameContentRendered(object sender, EventArgs e)
        {
            if (mainFrame.CanGoBack) btnBack.Visibility = Visibility.Visible;
            else btnBack.Visibility = Visibility.Hidden;

            if (mainFrame.CanGoForward) btnForward.Visibility = Visibility.Visible;
            else btnForward.Visibility = Visibility.Hidden;
        }

        private void BtnBackClick(object sender, RoutedEventArgs e)
        {
            ManagerFrame.MainFrame.GoBack();
        }

        private void BtnForwardClick(object sender, RoutedEventArgs e)
        {
            ManagerFrame.MainFrame.GoForward();
        }

        private void BtnExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
