using System;

namespace generateCalcCode
{
    class GenerateCode
    {
        static void Main(string[] args)
        {
            int amount = 51;
            string output = "";

            //i and j have to be set to 1 instead of 0 when creating code for division!!!!!
            for(int i = 0; i < amount; i++)
            {
                for (int j = 0; j < amount; j++)
                {
                    //add
                    //output += "if (num1 == " + i + " && num2 == " + j + ") \n{\n\treturn " + (i + j) + ";\n}";

                    //subtract
                    //output += "if (num1 == " + i + " && num2 == " + j + ") \n{\n\treturn " + (i - j) + ";\n}";

                    //multiply
                    //output += "if (num1 == " + i + " && num2 == " + j + ") \n{\n\treturn " + (i * j) + ";\n}";

                    //divide
                    //output += "if (num1 == " + i + " && num2 == " + j + ") \n{\n\treturn " + ((double)i / (double)j).ToString().Replace(",", ".") + ";\n}";
                }
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
