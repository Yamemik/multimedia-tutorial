using System.Collections.Generic;
using System.IO;

namespace MultimediaTutorial
{
    class SymbolDB
    {
        private List<Symbol> db;
        private int index;
        public Symbol CurrentSymbol
        {
            get
            {
                index++;
                return db[index % db.Count];
            }
        }
        public SymbolDB()
        {
            this.db = new List<Symbol>();
            this.index = -1;
            var dataFile = File.ReadAllLines(@"..\..\Debug\Alphabet.txt");
            foreach (var e in dataFile)
            {
                var args = e.Split('|');
                db.Add(new Symbol(args[0], args[1]));
            }
        }
    }
}
