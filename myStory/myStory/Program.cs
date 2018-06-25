using System;
using System.Diagnostics;

namespace myStory
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo bigTomato = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            bigTomato.Arguments = "https://cdn1.vectorstock.com/i/1000x1000/02/65/cute-cartoon-smiling-tomato-superhero-in-mask-and-vector-15790265.jpg";

            ProcessStartInfo tomatoDude = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            tomatoDude.Arguments = "https://cdn3.vectorstock.com/i/1000x1000/47/27/cartoon-character-of-superhero-tomato-with-arms-vector-18094727.jpg";

            ProcessStartInfo pow = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            pow.Arguments = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQTpLpKD2LZ8e2aJsdDN1ErPFMKfogkpXWgLjBLIe1GiCbYpu7H";

            ProcessStartInfo peasants = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            peasants.Arguments = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQ61NdeSxmSO8z7m41dw1pvtFBEDgtKP0ho3r5b0ba3M13DU2Tew";

            Console.WriteLine("The world has ran out of tomatoes....");
            Console.ReadKey();

            Console.WriteLine("Only one tomato guy is able to bring tomatoes back to life, but he's being interrupted by someone..");
            Console.ReadKey();

            Process.Start(bigTomato);

            Console.Write("That tomato guy is you [Please enter name]: ");
            string getname = Console.ReadLine();

            SuperHuman TomatoGuy = new SuperHuman(getname, 100);

            

            Console.Write("But there is one man that's able to help... my sidekick [Enter sidekick name]: ");
            string sideNickname = Console.ReadLine();

            SuperHero helpTomatoeGuy = new SuperHero(sideNickname, "Punch", "Ben", 100);

            Process.Start(tomatoDude);

            Console.Write("The bad guy who keeps interrupting {0}, His name is [Please enter name]: ", TomatoGuy._name);
            string badName = Console.ReadLine();

            SuperVillain Jon = new SuperVillain("Evil Laugh", 100, badName, 100);

            int loseHealth = Jon._healthPoints - 50;
            Console.WriteLine("{0} had enough, he punches {1}, and his health decreases from {2} to {3}", TomatoGuy._name, Jon._name, Jon._healthPoints, loseHealth);
            Console.ReadKey();

            Process.Start(pow);

            int loseMoreHealth = loseHealth - 50;
            Console.WriteLine("{0} punches {1} again and his health decreases from {2} to {3}", TomatoGuy._name, Jon._name, loseHealth, loseMoreHealth);
            Console.ReadKey();

            Console.WriteLine("The peasants rejoice over the destruction of {0}. . .", Jon._name);
            Console.ReadKey();

            Process.Start(peasants);

            Console.WriteLine("And the Tomato community lived happily ever after");
            Console.ReadKey();

        }
    }
}
