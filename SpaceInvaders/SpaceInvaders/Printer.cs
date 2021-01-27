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
            Console.Write("Wave : " + game.wave);
            
            Console.SetCursorPosition(0, game.GetBoardHeight());
            Console.Write("Lives : " + game.player.lives);
            
            string time = "Time : " + game.time;
            Console.SetCursorPosition(game.GetBoardWith()/2 - time.Length/2, game.GetBoardHeight());
            Console.Write(time);

            Console.ForegroundColor = game.player.color;
            Console.SetCursorPosition(game.player.X, game.player.Y);
            Console.Write(game.player.display);
            
            
            Console.ForegroundColor = Enemy.color;
            foreach (Enemy enemy in game.enemies)
            {
                if (enemy.Y >= 2 )
                {
                    Console.SetCursorPosition(enemy.X, enemy.Y);
                    Console.Write(enemy.display);
                }
            }
            
            Console.ForegroundColor = Bullet.color;    
            foreach (Bullet bullet in game.bullets)
            {
                Console.SetCursorPosition(bullet.X, bullet.Y);
                Console.Write(bullet.display);
            }
            
            Console.SetCursorPosition(0,game.GetBoardHeight() );
            Console.WriteLine();
        }
    }
}