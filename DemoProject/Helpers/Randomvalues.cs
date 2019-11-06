using System;
using System.Text;

namespace DemoProject.Helpers
{
    public class Randomvalues
    {
        public static class Randomizr
        {
            //*Note that there is a nested class here in Randomizr and also member methods.
            private static Random _random = new Random();

            public static string RandomString(int size)
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < size; i++)
                {
                    //26 letters in the alphabet, ascii + 65 for the capital letters
                    builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * _random.NextDouble() + 65))));
                }
                return builder.ToString();
            }


            // End Number should be upper limit + 1
            public static string RangeString(int startnumber, int endnumber)
            {
                System.Random randNum = new System.Random();
                int myRandomNumber = randNum.Next(startnumber, endnumber);
                return myRandomNumber.ToString();
            }
        }

    }
}
