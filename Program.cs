using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Timers;
using System.Linq;
using System.IO.Compression;
using System.Text;
using System.Reflection.Metadata;

namespace Menu
{
    class Program
    {
        static void Main(string[]ma)
        {
            Console.Title = "Bruger stander, alt med brugere findes her!";
            mainMenu();
        }
        static void mainMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("    Velkommen til brugerdatabasen!");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("\tIndex");
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-Søg efter bruger (S)    |");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-Opret ny bruger (O)     |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-Se hele bruger-listen(L)|");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-Info (I)                |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-Genveje:                |");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("   -   Luk =     (Q)     |");
            Console.WriteLine("   -   Menu =    (M)     |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Vælg en knap og se magien! ");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "o":
                    Console.Write("Her kan du oprette din bruger: ");
                    string userinput = "";
                    Console.Write("Her kan du oprette din bruger: ", "\t");
                    Console.WriteLine();
                    Console.WriteLine("Navn: ");
                    userinput += "" + Console.ReadLine() + "\t";
                    Console.WriteLine("Email:");
                    userinput += "" + Console.ReadLine() + "\t";
                    Console.WriteLine("Og nummer: ");
                    userinput += "" + Console.ReadLine();
                    Console.WriteLine("Opretter din bruger.. Vent venligst..");

                    using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(@"C:\Users\nann4\Desktop\Testfolder\Test.txt", true))
                    {
                        file.WriteLine("" + userinput);
                    }
                    break;

                case "s":
                    Console.WriteLine("Leder du efter en bruger?", "\tSøg her!");
                    string text = System.IO.File.ReadAllText(text = System.IO.File.ReadAllText(@"C:\Users\nann4\Desktop\Testfolder\Test.txt"));
                    string[] lines = System.IO.File.ReadAllLines(@"C:\Users\nann4\Desktop\Testfolder\Test.txt");
                    Console.WriteLine("Indtast søgeord: " + text);
                    foreach (string functionLine in lines)
                    {
                        if (functionLine == text + ("Vent lige et øjeblik..."));
                        {
                            Console.Write("Fandt det du søgte: " +text);
                        }
                    }
                    break;

                case "i":
                    Console.WriteLine("Tryk 'M' for at komme tilbage til menuen. ");
                    Console.WriteLine("tryk 'Q' for at komme tilbage til menuen. ");
                    string userInputInfo = Console.ReadLine();
                    if (userInputInfo == "i")
                    {
                        mainMenu();
                        Console.WriteLine("Info: her kan du oprette, se og hente brugere. gå tilbage til menuen.");
                    }
                    if (userInputInfo == "i")
                    {
                        Console.WriteLine("Info: her kan du oprette, se og hente brugere. gå tilbage til menuen.");
                    }
                    else if (userInputInfo != "m")
                    {
                        mainMenu();
                    }
                    else if (userInputInfo != "q")
                    {
                        Console.WriteLine("Lukker programmet.");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    break;

                case "l":
                    string[] line = System.IO.File.ReadAllLines(@"C:\Users\nann4\Desktop\Testfolder\Test.txt");
                    string texts = System.IO.File.ReadAllText(@"C:\Users\nann4\Desktop\Testfolder\Test.txt");
                    System.Console.WriteLine("Her er alle brugerne = \n");
                    break;

                case "q":
                    Console.WriteLine("Lukker programmet.");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;
                case "m":
                    Console.WriteLine("Hovedmenu.");
                    mainMenu();
                    break;

                default:
                    Console.WriteLine("Beklager, den kommando kender jeg ikke.");
                    Thread.Sleep(3000);
                    mainMenu();
                    break;

            }
        }
    }
}
    

