using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Factory_Mod_Config_Creator
{
    class Print
    {
        public void printFile(string fileName, List<string> list)
        {
            using (StreamWriter wt = new StreamWriter(fileName))
            {
                for (int line = 0; line < list.Count; line++)
                {
                    wt.WriteLine(list[line]);
                }
            }
        }
    }
}
