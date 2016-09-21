using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LemonadeStand
{
    public class FileWriter
    {
        public void WriteScore(string name, string money, int day)
        {
            using (StreamWriter outputFile = new StreamWriter("dayLog.txt", true))
            {

                outputFile.WriteLine(";{0} : {1} : Day {2}", money, name, day);
            }
        }

    }
}
