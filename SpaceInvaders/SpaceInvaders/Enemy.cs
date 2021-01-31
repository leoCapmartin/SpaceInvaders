using System;

namespace SpaceInvaders
{
    public class Enemy : SpaceShip
    {
        private int _randomChanceToShoot = 50;
        private Random _rnd = new Random();
        private int _move = 2;
        private bool _moveRight = true;
        
        public static ConsoleColor color = ConsoleColor.Red;
        public Enemy(Game game, int x, int y)
        {
            display = "[ <> ]";

            X = x*width;
            Y = y;
        }
        public override void Colide(Game game, Bullet colider)
        {
            game.DestroyEntity(colider);
            game.DestroyEntity(this);
        }

        public override void Update(Game game)
        {
            if (_moveRight && game.time % 4 == 0)
            {
                Move(game, Axis.X, Direction.Forward, width);
                _move++;
            }
            else if (!_moveRight && game.time % 4 == 0)
            {
                Move(game, Axis.X, Direction.Backward, width);
                _move--;
            }

            if (_move == 4)
                _moveRight = false;
            else if (_move == 0)
                _moveRight = true;

            int chanceToShoot = _rnd.Next(_randomChanceToShoot);
            if(chanceToShoot == 0)
                Shoot(game, this);
        }
    }
}