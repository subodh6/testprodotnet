using System;


namespace DemoProject.Helpers
{
    public static class TestData
    {
       

       //Random  Value

        public static string RandomMobileNumber()
        {

            Random random = new Random();
            string mobileNumber = "";
            int i;
            for (i = 1; i < 11; i++)
            {
                mobileNumber += random.Next(1, 9).ToString();
            }
            return mobileNumber;


        }

        public static string RandomUserName()
        {
            string fName = "QA" + Randomvalues.Randomizr.RandomString(4);
            return fName;
        }

        public static string RandomPassword()
        {
            string lName = "Test" + Randomvalues.Randomizr.RandomString(4);
            return lName;
        }

       
    }
}
