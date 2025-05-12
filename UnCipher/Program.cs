namespace UnCipher
{
    class Program
    {
        static void Main(string[]args)
        {
            // a list is declared to hold all the inputs from the user
            List<string> inputList = new List<string>();

            Console.WriteLine("\tWELCOME TO UNCIPHER");
            Console.WriteLine("***********************************");

            //prompts the user how many inputs they would like to try
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("How many inputs would you like to try?");
            int numberOfInputs = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                // Prompts user to enter the sentences based on te number of inputs they want
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nPlease Enter Sentence{i+1}:");
                string input = Console.ReadLine().ToLower();
                inputList.Add(input);//adds sentences to list
            }


            //display the decoded sentences.
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\t THE DECODED SENTENCES:");
            Console.WriteLine("==============================================");
            foreach (var item in inputList)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"- {DecodeInput(item)}");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("==============================================");
            }
            

            Console.ReadLine();
        }

        static string DecodeInput(string code)
        {
            //creates a char array to read each positio in the sentence
            char[] words = new char[code.Length];

            //loop through the array
            for (int i = 0; i < code.Length; i++)
            {
                char c = code[i];

                //checks if lower case to make conversion
                if (char.IsLower(c))
                {
                    //Map 'a'-'z', 'b'-'y'....
                    words[i] = (char)('a' + ('z' - c));
                }
                else
                {
                    // let the other items remain unchanged
                    words[i] = c;
                }
            }

            //return the new string
            return new string (words);
        }
    }
}