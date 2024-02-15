using System.Windows.Controls;

namespace MultimediaTutorial
{
    class MainLogic
    {
        static Image image;//картинка
        static TextBlock textBlock;
        static SymbolDB data = new SymbolDB();//данные со всеми буквами
        static AnswerDB answer;
        static ComboBox[] comboBox = new ComboBox[6];

        public static void LoadNewQuestion()//загрузка нового вопроса
        {
            var q = data.CurrentSymbol;
            image.Source = q.Picture;
            textBlock.Text = q.Symbols;
        }
        public MainLogic(TextBlock tbSymbol, Image ImageView)
        {
            image = ImageView;
            textBlock = tbSymbol;
            LoadNewQuestion();
        }

        public static void LoadNewAnswer(int i)
        {
            var q = answer.CurrentAnswer;
            comboBox[i].Items.Add(q.Answer1);
            comboBox[i].Items.Add(q.Answer2);
            comboBox[i].Items.Add(q.Answer3);
        }

        public MainLogic(ComboBox[] cbAnswers)
        {
            comboBox = cbAnswers;
            answer = new AnswerDB();
            for (int i = 0; i < 6; ++i)
            {
                LoadNewAnswer(i);
            }
        }
    }
}
