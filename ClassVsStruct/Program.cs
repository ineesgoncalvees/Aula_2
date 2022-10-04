using System;

namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player() {Health = 100, Armor = 100};
            Player p2 = p1;

            Console.WriteLine($"Player 1 -> Health = {player1.Health}, Armor -> {player1.Armor}");

            Console.WriteLine($"Player 2 -> Health = {player2.Health}, Armor -> {player.Armor}");

        }
    }
}
