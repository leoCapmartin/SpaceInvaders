using System;

namespace SpaceInvaders
{
    public class Printer
    {
        public static void printBoard(Game game)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.SetCursorPosition(0,0);
            Console.Write("Score : " + game.score);
            
            Console.SetCursorPosition(0, game.GetBoardHeight());
            Console.Write("Lives : " + game.player.lives);

            Console.ForegroundColor = game.player.color;
            Console.SetCursorPosition(game.player.X, game.player.Y);
            Console.Write(game.player.display);
            
            foreach (Enemy enemy in game.enemies)
            {
                Console.SetCursorPosition(enemy.X, enemy.Y);
                Console.ForegroundColor = enemy.color;
                Console.Write(enemy.display);
            }

            foreach (Bullet bullet in game.bullets)
            {
                Console.SetCursorPosition(bullet.X, bullet.Y);
                Console.ForegroundColor = bullet.color;
                Console.Write(bullet.display);
            }
            
            Console.SetCursorPosition(0,game.GetBoardHeight() );
            Console.WriteLine();
        }
    }
}