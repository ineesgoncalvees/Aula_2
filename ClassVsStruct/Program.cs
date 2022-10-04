using System;

namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player() {Health = 100, Armor = 100};
            Player player2 = player1;

            Console.WriteLine($"Player 1 -> Health = {player1.Health}, Armor -> {player1.Armor}");
            Console.WriteLine($"Player 2 -> Health = {player2.Health}, Armor -> {player2.Armor}");

            Console.WriteLine("");

            DupHealth(player1);

            Console.WriteLine($"Player 1 -> Health = {player1.Health}, Armor -> {player1.Armor}");
            Console.WriteLine($"Player 2 -> Health = {player2.Health}, Armor -> {player2.Armor}");

        }

        private static void DupHealth(Player player)
        {
            player.Health = player.Health *2;

            //ou player.Health *= 2;
        }
    }
}
