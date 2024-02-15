using System.Windows;
using System.Windows.Controls;

namespace MultimediaTutorial
{
    public partial class CurrentPage : Page
    {
        public CurrentPage()
        {
            InitializeComponent();
            new MainLogic(tbSymbol,iSymbol);
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            ManagerFrame.MainFrame.Navigate(new VideoPage());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ManagerFrame.MainFrame.GoBack();
        }

        private void btnAlph_Click(object sender, RoutedEventArgs e)
        {
            MainLogic.LoadNewQuestion();
        }
    }
}
