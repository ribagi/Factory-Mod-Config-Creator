using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Mod_Config_Creator
{
    class ConfigCreator
    {
        public void config(string fileName, string input, string output, int durab, string action)
        {
            Print print = new Print();
            FramWorkListBuilder builder = new FramWorkListBuilder();
            List<string> list = new List<string>();

            string bufferInput = input.Replace(' ', '_');
            string bufferOutput = output.Replace(' ', '_');

            string[] frameWork = {"  " + action + "_" + bufferOutput + ":",
                                    "    name: " + action + " " + output,
                                    "    inputs:",
                                    "      " + input + ":",
                                    "        material: " + bufferInput.ToUpper(),
                                    "        amount: <!AMOUNT>"};

            string[] outputWork = {"        amount: 64",
                                    "    outputs:",
                                    "      " + output + ":",
                                    "        material: " + bufferOutput.ToUpper(),
                                    "        amount: <!AMOUNTOUTPUT>",
                                    "        durability: " + durab};

            list = builder.listBuilder(frameWork, outputWork);


            print.printFile(fileName, list);
        }
    }
}
