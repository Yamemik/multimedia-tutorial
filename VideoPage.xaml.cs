using System.Windows;
using System.Windows.Controls;

namespace MultimediaTutorial
{
    public partial class VideoPage : Page
    {
        public VideoPage()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            ManagerFrame.MainFrame.Navigate(new TimePage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ManagerFrame.MainFrame.GoBack();
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            meVideo.Play();
        }

        private void BtnPause_Click(object sender, RoutedEventArgs e)
        {
            meVideo.Pause();
        }

        private void meVideo_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("Fail");
        }

        private void meVideo_Opened(object sender, RoutedEventArgs e)
        {

        }
    }
}
