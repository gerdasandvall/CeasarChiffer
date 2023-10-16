
namespace gerdasCeasarChiffer
{
    class Program
    {
        //Mainmetod
        static void Main(string[] args)
        {
                Console.ForegroundColor = ConsoleColor.Blue;
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine (@"
   ____ U _____ u    _      ____       _       ____           ____   _   _               _____   _____ U _____ u   ____     
U /""___|\| ___""|/U  /""\  u / __""| uU  /""\  uU |  _""\ u     U /""___| |'| |'|     ___     |"" ___| |"" ___|\| ___""|/U |  _""\ u  
\| | u   |  _|""   \/ _ \/ <\___ \/  \/ _ \/  \| |_) |/     \| | u  /| |_| |\   |_""_|   U| |_  uU| |_  u |  _|""   \| |_) |/  
 | |/__  | |___   / ___ \  u___) |  / ___ \   |  _ <        | |/__ U|  _  |u    | |    \|  _|/ \|  _|/  | |___    |  _ <    
  \____| |_____| /_/   \_\ |____/>>/_/   \_\  |_| \_\        \____| |_| |_|   U/| |\u   |_|     |_|     |_____|   |_| \_\   
 _// \\  <<   >>  \\    >>  )(  (__)\\    >>  //   \\_      _// \\  //   \\.-,_|___|_,-.)(\\,-  )(\\,-  <<   >>   //   \\_  
(__)(__)(__) (__)(__)  (__)(__)    (__)  (__)(__)  (__)    (__)(__)(_"") (""_)\_)-' '-(_/(__)(_/ (__)(_/ (__) (__) (__)  (__) 
");
                Console.WriteLine("LOADING...");
                Console.ReadKey();
                int nKey = Random.Shared.Next(0, 195); //slumpar fram nyckeln
                Console.WriteLine ("Skriv in datan du vill kryptera:");
                string userInput = Console.ReadLine(); //läser in användardata
                char[] charArray = userInput.ToCharArray();
                int[] decryptedNumbers = new int[charArray.Length]; //dekrypterade nummer för respektive tecken
                int[] encryptedNumbers = new int[charArray.Length]; //krypterade nummer för respektive tecken
                char[] decryptedChars = new char[charArray.Length]; //dekrypterade tecken
                char[] encryptedChars = new char[charArray.Length]; //krypterade tecken

                Console.WriteLine ("Krypterad data:");
                for (int i = 0; i < charArray.Length; i++)
                {
                    int j = (int)charArray[i] + nKey; //räknar fram ny position
                    encryptedNumbers[i] = j; //sätter numret för position i array
                    encryptedChars[i] = (char)j; //sätter tecknet för denna position
                    Console.Write(encryptedChars[i]); //skriver ut tecken
                }
                Console.WriteLine ("");
            Console.WriteLine ("Den ursprungliga datan:");

                for (int i = 0; i < charArray.Length; i++) //skriver ut originaldata, dekrypterar mha nyckeln
                {
                    int j = (int)encryptedNumbers[i] - nKey; //räknar fram originaltecknets position
                    decryptedNumbers[i] = j;  //sätter numret för position i array
                    decryptedChars[i] = (char)j; //sätter tecknet för denna position
                    Console.Write(decryptedChars[i]); //skriver ut tecknet
                }
                     Console.ReadKey();
                Console.Clear();
            }

        }
    }
}