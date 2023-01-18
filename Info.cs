using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming
{
    public class Info
    {
        public int SentQuan { get; set; }
        public int SymbQuan { get; set; }
        public int WordsQuan { get; set; }
        public int InterrSentQuan { get; set; }
        public int ExclaSentQuan { get; set; }

        public Info()
        {
            SentQuan = 0;
            SymbQuan = 0;
            WordsQuan = 0;
            InterrSentQuan = 0;
            ExclaSentQuan = 0;
        }

        public Info(int sentQuan, int symbQuan, int wordsQuan, int interrSentQuan, int exclaSentQuan)
        {
            SentQuan = sentQuan;
            SymbQuan = symbQuan;
            WordsQuan = wordsQuan;
            InterrSentQuan = interrSentQuan;
            ExclaSentQuan = exclaSentQuan;
        }
    }
}
