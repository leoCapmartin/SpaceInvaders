using System;

namespace SpaceInvaders
{
    public class PLayer : SpaceShip
    {
        public int lives = 3;
        public ConsoleColor color;

        private int _nextTimeToShoot = 0;
        public PLayer(Game game)
        {
            display = "[ || ]";
            color = ConsoleColor.White;
            X = (game.GetBoardWith() / 12) * width;
            Y = game.GetBoardHeight() -2;
        }

        public override void Colide(Game game, Bullet colider)
        {
            lives--;
            game.DestroyEntity(colider);
        }

        public override void Update(Game game)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Spacebar && _nextTimeToShoot == 0)
                {
                    Shoot(game, this);
                    _nextTimeToShoot = 1000000;
                }
                else if(key == ConsoleKey.Q || key == ConsoleKey.LeftArrow)
                    Move(game, Axis.X, Direction.Backward, width);
                else if(key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                    Move(game, Axis.X, Direction.Forward, width);
            }
            if(_nextTimeToShoot > 0)
                _nextTimeToShoot --;
        }
    }
}