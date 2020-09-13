using System;

namespace generateCalcCode
{
    class GenerateCode
    {
        static void Main(string[] args)
        {
            int amount = 51;
            string output = "";

            for(int i = 1; i < amount; i++)
            {
                for (int j = 1; j < amount; j++)
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
