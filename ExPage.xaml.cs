using System.Windows;
using System.Windows.Controls;

namespace MultimediaTutorial
{
    public partial class ExPage : Page
    {
        const int countQuestions = 6;

        public string[] answers = { "works", "live", "go", "miss", "doesn’t have", "rains" };
        public string[] usersAnswers = new string[countQuestions];

        public ExPage()
        {
            InitializeComponent();

            ComboBox[] cbArr = { cb1, cb2, cb3, cb4, cb5, cb6 };

            new MainLogic(cbArr);
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            //futurePage
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ManagerFrame.MainFrame.GoBack();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            int countCorrectAnswers = 0;

            for(int i = 0; i < countQuestions; ++i)
            {
                if(answers[i] == usersAnswers[i])
                {
                    countCorrectAnswers++;
                }
            }
            MessageBox.Show("Правильных ответов " + countCorrectAnswers.ToString() + " из " + countQuestions,
                "Результат..",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void BtnФты_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("works\nlive\ngo\nmiss\ndoesn’t have\nrains");
        }

        private void Cb1_Selected(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            usersAnswers[0] = selectedItem.Content.ToString();
        }

        private void Cb2_Selected(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            usersAnswers[1] = selectedItem.Content.ToString();
        }

        private void Cb3_Selected(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            usersAnswers[2] = selectedItem.Content.ToString();
        }

        private void Cb4_Selected(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            usersAnswers[3] = selectedItem.Content.ToString();
        }

        private void Cb5_Selected(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            usersAnswers[4] = selectedItem.Content.ToString();
        }

        private void Cb6_Selected(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            usersAnswers[5] = selectedItem.Content.ToString();
        }
    }
}
