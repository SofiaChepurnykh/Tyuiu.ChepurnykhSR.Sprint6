using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChepurnykhSR.Sprint6.Task6.V19.Lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string[] temp;
                while ((line = reader.ReadLine()) != null)
                {
                    temp = line.Split(' ');
                    foreach (string item in temp)
                    {
                        if (item.Contains('l')) resStr += item + " ";
                    }

                }
            }
            return resStr;
        }
    }
}
