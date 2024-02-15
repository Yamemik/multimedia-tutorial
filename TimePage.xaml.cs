using System.Windows;
using System.Windows.Controls;

namespace MultimediaTutorial
{
    public partial class TimePage : Page
    {
        public TimePage()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            ManagerFrame.MainFrame.Navigate(new ExPage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ManagerFrame.MainFrame.GoBack();
        }
    }
}
