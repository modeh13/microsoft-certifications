using System;
using GameConsole.Abstractions;
using GameConsole.Classes;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var player = new PlayerCharacter();
            var playerNullable = new PlayerCharacterNullable();
            //PlayerDisplayer.Write(player);
            PlayerDisplayer.Write(playerNullable);

            var player1 = new PlayerCharacter(new DiamondSkinDefence())
            {
                Name = "Sarah"
            };

            var player2 = new PlayerCharacter(new IronBonesDefence())
            {
                Name = "Amrit"
            };

            var player3 = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Gentry"
            };

            player1.Hit(10);
            player2.Hit(10);
            player3.Hit(10);

            Console.ReadKey();
        }
    }
}