using System.Collections.Generic;
using System.IO;

namespace MultimediaTutorial
{
    class AnswerDB
    {
        private List<Answer> db;
        private int index;
        public Answer CurrentAnswer
        {
            get
            {
                index++;
                return db[index % db.Count];
            }
        }
        public AnswerDB()
        {
            this.db = new List<Answer>();
            this.index = -1;
            var dataFile = File.ReadAllLines(@"..\..\Debug\ex.txt");
            foreach (var e in dataFile)
            {
                var args = e.Split('|');
                db.Add(new Answer(args[0], args[1],args[2]));
            }
        }

    }
}
