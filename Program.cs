using System;

namespace First_OOP_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Character player1 = new Character();
            player1.name = "Felipe";
            player1.age = 32;
            player1.armor = "Face-Shield";
            player1.AI = "Pure Skill";

            Character player2 = new Character();
            player2.name = "Tony Stark";
            player2.age = 35;
            player2.armor = "MK3";
            player2.AI = "Jarvis";

            Console.WriteLine();
            Console.WriteLine($" Fight  {player1.name} Vs {player2.name}");
            Console.WriteLine();
            Console.WriteLine($"Player 1 Armor: {player1.armor} || Player 2 Armor: {player2.armor}");
            Console.WriteLine();
            Console.WriteLine($"Player 1 AI: {player1.AI} || Player 2 AI: {player2.AI}");
            Console.WriteLine();
            
            
            
            Console.WriteLine("Start Fight");
            Console.WriteLine();


            Console.WriteLine("Player 1 used Attack A on Player2");
            int hpFromPlayer2 = player2.Defend(player1.AttackA());
            
            
            if (hpFromPlayer2 <=0) {
                   
                   Console.WriteLine();
                   Console.WriteLine("Player 2 is DEAD");
                }

            else { 
                   Console.WriteLine();
                   Console.WriteLine($"Player 2 HP after attack is: {player2.HP}");
                 }


        }
    }
}
