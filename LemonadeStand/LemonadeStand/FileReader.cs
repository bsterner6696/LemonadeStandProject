using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LemonadeStand
{
    public class FileReader
    {
        public string ReadFile(string file)
        {
            StreamReader t = new StreamReader(file);
            string data = t.ReadToEnd();
            return data;
        }

        public string[] SortScores(string unsplitText)
        {
            string data = unsplitText;
            string[] splitScores;
            splitScores = data.Split(';');
            Array.Sort(splitScores);
            Array.Reverse(splitScores);
            return splitScores;
        }
    }
}
