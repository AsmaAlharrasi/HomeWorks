namespace leet_code
{
    class Program
    {
        #region gussesnumber
        static int gussesnumber ( int n)
        {
            int i = 1;
            int j = n;
            int num = i + (i - j) / 2;
            while (i <= j)
            //for (i = 1; i <= j; i++)
            {
                if (guess(num) == -1)
                {
                    j = num - 1;
                }
                else if (guess(num) == 1)
                {
                    i = num + 1;
                }
                else return num;
            }
            return -1;

        }
        #endregion

        #region TitleToNumber
        public int TitleToNumber(string columnTitle)
        {
            int result = 0;
            foreach (char x in columnTitle)
            {
                int y = x - 'A' + 1;
                result = result * 26 + y;
            }
            return result;
        }
        #endregion

        #region ConvertToTitle
        public string ConvertToTitle(int columnNumber)
        {
            string result = "";

            while (columnNumber > 0)
            {
                int remainder = (columnNumber - 1) % 26;
                char charValue = (char)('A' + remainder);
                result = charValue + result;

                columnNumber = (columnNumber - 1) / 26;
            }

            return result;
        }
        #endregion
        static void Main()
        {
            #region reverse a string
            reverse a string 1
            string s = "hello";
            char[] stringArray = s.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);
            Console.WriteLine(reverseString);

            // reverse a string 2
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            Array.Reverse(s);
            string reverseString = new string(s);
            Console.WriteLine(reverseString);

            //intersaction of tow array
            int[] num1 = { 1, 2, 2, 1 }; int[] num2 = { 2, 2 };
            var intersection = num1.Intersect(num2);
            foreach (int result in intersection)
            {
                Console.WriteLine($" [{result}]");

            }

            #endregion

        }

    }


}
