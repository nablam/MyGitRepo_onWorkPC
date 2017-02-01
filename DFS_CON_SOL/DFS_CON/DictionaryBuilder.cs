using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DFS_CON
{
   public class DictionaryBuilder
    {
        string _localDictionaryPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"ProjFolder\EnglishWordList1_69903.txt");
        StreamReader _READER;
        HashSet<string> _myDic;
        int _wordCount;

        public DictionaryBuilder() {
            _wordCount = 0;
            _myDic = new HashSet<string>();
            using (_READER = new System.IO.StreamReader(_localDictionaryPath, true))
            {
                while (!_READER.EndOfStream)
                {
                    string word = _READER.ReadLine();
                    _myDic.Add(word);
                    _wordCount++;
                }
                Console.WriteLine("added " +_wordCount+" words to dictionary");
            }
        }

        public bool ContainsWord(string s) {
            if (_myDic.Contains(s)) return true;
            else
                return false;
        }
        //StartsWith
        public bool ContainsWordStartWith(string s)
        {
            var v = _myDic.Select(e => e).Where(e => e.StartsWith(s)).FirstOrDefault();
            if (v != null) { Console.WriteLine("there is a word starting with "+ s); return true; }
            else
            { Console.WriteLine("nothing starts with" + s); return false; }


        }

    }
}
