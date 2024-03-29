using System.Data.SqlTypes;

namespace stringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string newStr = "salam ,   dunya";
            //StringTrim(newStr);



            //string inputStr = "Almaz2004";
            //bool result= false;
            //Console.WriteLine(Check(inputStr));



            //string newStr = "birinci sozu ekrana cixaran task";
            //FirstWord(newStr);


            int[] arr1 = { 1, 2, 3, 4 };
            int value1 = 5;

            KohneCap(arr1); // Main içinde çağrılmalıdır.

            AddValue(ref arr1, value1);
            Console.Write("yeni:");
            KohneCap(arr1);








        }
        public static void StringTrim(string str)
        {

            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue;
                }
                else
                {
                    newStr += str[i];
                    
                }
            }
            Console.WriteLine(newStr);
        }



        public static bool Check(string str)
        {
            bool reqem = false;
            bool herfboyuk = false;
            bool herfkicik = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 48 && str[i] <= 57)
                {
                    reqem = true;
                    Console.WriteLine("en az bir reqem var");
                }
                else if (str[i] >= 65 && str[i] <= 90)
                {
                    herfboyuk = true;
                    Console.WriteLine("en az bir boyuk herf var");
                }
                else if (str[i] >= 97 && str[i] <= 122)
                {
                    herfkicik = true;
                    Console.WriteLine("en az bir icik herf var");
                }
            }
            return reqem;
        }
        public static void FirstWord(string word)
        {
            string newStr = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    newStr += word[i];
                }
                else
                {
                    break; 
                }
            }
            Console.WriteLine(newStr);
        }



        // 5ci task

        public static void AddValue(ref int[] arr, int value)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;
        }

        public static void KohneCap(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " "); 
            }
        }


    }

}

