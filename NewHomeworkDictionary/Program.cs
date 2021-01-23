using System;

namespace NewHomeworkDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                MyDictionary<string, int> myDictionary = new MyDictionary<string, int> { };
                myDictionary.Add("Onur", 25);
                myDictionary.Add("Berk", 30);

                for (int i = 0; i < myDictionary.keys.Length; i++)
                {
                    Console.WriteLine(myDictionary.keys[i].ToString() + " : " + myDictionary.values[i].ToString());
                }

                Console.ReadLine();
            }
        }
    }
}
