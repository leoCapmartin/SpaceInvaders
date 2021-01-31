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

        public static void PrintGameOver(Game game)
        {
            Console.Clear();
            
            string gameOver = "GAME OVER!";
            string wave = "WAVE : " + (game.wave-1);
            string time = "TIME : " + game.time;
            Console.SetCursorPosition(game.GetBoardWith()/2 - gameOver.Length/2, game.GetBoardHeight()/2 - 1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(gameOver);

            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.SetCursorPosition(game.GetBoardWith()/2 - wave.Length/2, game.GetBoardHeight()/2);
            Console.Write(wave);
            
            Console.SetCursorPosition(game.GetBoardWith()/2 - time.Length/2, game.GetBoardHeight()/2 + 1);
            Console.Write(time);
            
            Console.SetCursorPosition(0, game.GetBoardHeight());
        }
    }
}