using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace MultimediaTutorial
{
    public partial class TitlePage : Page
    {
        public TitlePage()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            ManagerFrame.MainFrame.Navigate(new CurrentPage());

            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = 0;
            doubleAnimation.To = 50;
            doubleAnimation.Duration = TimeSpan.FromSeconds(6);

            tbTitle.BeginAnimation(TextBlock.FontSizeProperty,doubleAnimation);
        }
    }
}
