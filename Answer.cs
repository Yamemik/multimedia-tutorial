using System;
using System.Collections.Generic;
using System.Text;

namespace MultimediaTutorial
{
    class Answer
    {
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }

        public Answer(string answer1, string answer2, string answer3)
        {
            this.Answer1 = answer1;
            this.Answer2 = answer2;
            this.Answer3 = answer3;
        }

    }
}
