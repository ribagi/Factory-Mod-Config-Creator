using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Mod_Config_Creator
{
    class FramWorkListBuilder
    {   // make this dyanicly change for more inputs

        private List<string> list = new List<string>();

        public List<string> listBuilder(string[] frameWork, string[] outputWork)
        {
            for (int i = 0; i < frameWork.Length; i++)
                list.Add(frameWork[i]);

            for (int i = 0; i < outputWork.Length; i++)
                list.Add(outputWork[i]);

            return list;
        }

        public List<string> frameWorkAdder(string[] framework)
        {
            return list;
        }

        public List<string> frameWorkRemover()
        {
            return list;
        }

        public List<string> frameWorkClear()
        {
            list.Clear();

            return list;
        }
    }
}
