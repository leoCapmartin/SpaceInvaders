using System;

namespace SpaceInvaders
{
    public class Bullet : Entity
    {
        private Axis _axis;
        public Direction direction;
        
        public static int width = 2;
        public static ConsoleColor color = ConsoleColor.Yellow;
        
        public Bullet(int x, int y, Direction dir, string rep)
        {
            X = x;
            Y = y;
            _axis = Axis.Y;
            direction = dir;
            
            display = rep;
        }


        public override void Update(Game game)
        {
            Move(game, _axis, direction);
            if (X - 2 == game.player.X && Y == game.player.Y && direction == Direction.Forward)
                game.player.Colide(game, this);
            

            foreach (Enemy enemy in game.enemies)
            {
                if (X - 2 == enemy.X && Y == enemy.Y && direction == Direction.Backward)
                    enemy.Colide(game, this);
            }

            foreach (Bullet bullet in game.bullets)
            {
                if(X == bullet.X && Y == bullet.Y && direction != bullet.direction)
                    bullet.Colide(game, this);
            }
            
            if(Y > game.GetBoardHeight() - 2 || Y < 2)
                game.DestroyEntity(this);
        }
        public override void Colide(Game game, Bullet colider)
        {
            game.DestroyEntity(colider);
        }
    }
}
