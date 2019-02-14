using System;

namespace SimpleCodes
{
    class Program
    {
        public void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        public void StringReverse(string str,string caseNo)
        {
            switch (caseNo)
            {
                case "1":
                    int strLeng = str.Length;
                    do
                    {
                        Console.Write(str[strLeng - 1]);
                        strLeng--;
                    } while (strLeng != 0);
                    break;
                default:
                    break;
            }
            
        }
        public static void Main(string[] args)
        {
            string ReverseType;

            Console.WriteLine("Reverse Programs");
            Console.WriteLine("0.HelloWorld\n1.Simple Reverse(String without Space)\n2.String Reverse with space");
            ReverseType = Console.ReadLine();

           
            Program p1 = new Program();

            switch (ReverseType)
            {
                case "0":
                    // The code provided will print ‘Hello World’ to the console.
                    p1.HelloWorld();
                    break;
                case "1":
                    p1.StringReverse("Aniket","1");
                    break;
                default:
                    break;
            }
            Console.WriteLine("\nPress any key to continue..");
            Console.ReadKey();
        }
    }
}
