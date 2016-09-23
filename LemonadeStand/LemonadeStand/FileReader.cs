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
            StreamReader fileToRead = new StreamReader(file);
            string data = fileToRead.ReadToEnd();
            return data;
        }
    }
}
