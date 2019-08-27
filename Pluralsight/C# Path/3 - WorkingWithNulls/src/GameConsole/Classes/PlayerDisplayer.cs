using System;

namespace GameConsole.Classes
{
    class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            Console.WriteLine(player.Name);

            // Magic number value that represents a null value in "ValueType".
            if(player.DaysSinceLastLogin == -1)
            {
                Console.WriteLine($"No value for {nameof(player.DaysSinceLastLogin)}");
            }
            else 
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }

            if(player.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine($"No value for {nameof(player.DateOfBirth)}");
            }
            else 
            {
                Console.WriteLine(player.DateOfBirth);
            }
        }

        public static void Write(PlayerCharacterNullable player)
        {
            // string.IsNullOrWhiteSpace checks if string has a null value or whitespace or empty.
            if(string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null or all whitespace.");
            }
            else 
            {
                Console.WriteLine(player.Name);
            }

            // Magic number value that represents a null value in "ValueType".
            if(player.DaysSinceLastLogin == null || !player.DaysSinceLastLogin.HasValue)
            {
                Console.WriteLine($"No value for {nameof(player.DaysSinceLastLogin)}");
            }
            else 
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            }

            if(player.DateOfBirth == null)
            {
                Console.WriteLine($"No value for {nameof(player.DateOfBirth)}");
            }
            else 
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if(player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status in unknown.");
            }
            else if (player.IsNoob.GetValueOrDefault())
            {
                Console.WriteLine("Player is newbie.");
            }
            else 
            {
                Console.WriteLine("Player is experienced.");
            }
        }
    }
}