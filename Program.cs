
namespace gerdasCeasarChiffer
{
    class Program
    {
        //Mainmetod
        static void Main(string[] args)
        {

            bool isRunning = true;

            while (isRunning)
            {
                int nKey = Random.Shared.Next(0, 195); //slumpar fram nyckeln
                string userInput = Console.ReadLine(); //läser in användardata
                char[] charArray = userInput.ToCharArray();
                int[] decryptedNumbers = new int[charArray.Length]; //dekrypterade nummer för respektive tecken
                int[] encryptedNumbers = new int[charArray.Length]; //krypterade nummer för respektive tecken

                char[] decryptedChars = new char[charArray.Length]; //dekrypterade tecken
                char[] encryptedChars = new char[charArray.Length]; //krypterade tecken

                for (int i = 0; i < charArray.Length; i++)
                {
                    int j = (int)charArray[i] + nKey; //räknar fram ny position
                    encryptedNumbers[i] = j; //sätter numret för position i array
                    encryptedChars[i] = (char)j; //sätter tecknet för denna position
                    Console.Write(encryptedChars[i]); //skriver ut tecken
                }

                Console.WriteLine(" "); 
                Console.WriteLine("nyckel" + nKey); //skriver ut nyckeln
                Console.WriteLine(" ");

                for (int i = 0; i < charArray.Length; i++) //skriver ut originaldata, dekrypterar mha nyckeln
                {
                    int j = (int)encryptedNumbers[i] - nKey; //räknar fram originaltecknets position
                    decryptedNumbers[i] = j;  //sätter numret för position i array
                    decryptedChars[i] = (char)j; //sätter tecknet för denna position
                    Console.Write(decryptedChars[i]); //skriver ut tecknet
                }
            }

        }
    }
}