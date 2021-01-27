using System;

namespace SpaceInvaders
{
    public class Bullet : Entity
    {
        private Axis _axis;
        private Direction _direction;
        
        public Bullet(int x, int y, Axis axis, Direction direction, string rep)
        {
            X = x;
            Y = y;
            _axis = axis;
            _direction = direction;
            
            speed = 1;
            display = rep;
            width = rep.Length;
            color = ConsoleColor.Yellow;
        }

        public override void Colide(Entity colider)
        {
            //TODO
        }

        public override void Update(Game game)
        {
            //TODO
        }
    }
}