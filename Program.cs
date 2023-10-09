
namespace gerdasCeasarChiffer
{

    class Program
    {


        static void Main(string[] args)
        {

            bool isRunning = true;
            //char c = (char)144;
            //Console.WriteLine(c);
            //tribute till hanna

            while (isRunning)
            {

                int nKey = Random.Shared.Next(0, 195);
                string userInput = Console.ReadLine();
                char[] charArray = userInput.ToCharArray();


                int[] decryptedNumbers = new int[charArray.Length];
                int[] encryptedNumbers = new int[charArray.Length];

                char[] encryptedChars = new char[charArray.Length];
                char[] decryptedChars = new char[charArray.Length];

                for (int i = 0; i < charArray.Length; i++)
                {

                    int j = (int)charArray[i] + nKey;
                    encryptedNumbers[i] = j;
                    encryptedChars[i] = (char)j;
                    Console.Write(encryptedChars[i]);

                }

                Console.WriteLine(" ");
                Console.WriteLine("nyckel" + nKey);

                for (int i = 0; i < charArray.Length; i++)
                {

                    int j = (int)encryptedNumbers[i] - nKey;
                    decryptedNumbers[i] = j;
                    decryptedChars[i] = (char)j;
                    Console.Write(decryptedChars[i]);
                }




            }



        }

    }
}