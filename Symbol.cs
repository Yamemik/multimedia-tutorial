using System;
using System.Windows.Media.Imaging;

namespace MultimediaTutorial
{
    class Symbol
    {
        public BitmapImage Picture { get; set; }
        public string Symbols { get; set; }
        public Symbol(string PathBitmapImageSource, string AnswerSource)
        {
            this.Picture = new BitmapImage();
            this.Picture.BeginInit();
            this.Picture.UriSource = new Uri(PathBitmapImageSource, UriKind.Relative);
            this.Picture.EndInit();
            this.Symbols = AnswerSource;
        }

    }
}
