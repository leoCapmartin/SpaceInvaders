using System;
using System.ComponentModel.DataAnnotations;

namespace SpaceInvaders
{
    public abstract class Entity
    {
        public int X;
        public int Y;
        public string display;

        public enum Axis
        {
            X, Y
        }

        public enum Direction
        {
            Forward = 1,
            Backward = -1
        }

        protected void Move(Game game, Axis axis, Direction direction, int width)
        {
            if (axis == Axis.X)
            {
                if (X + (int) direction * (width*2) <= game.GetBoardWith() && X + (int) direction * width >= 0)
                    X += (int) direction * width;
            }
            else
                Y += (int) direction;
        }
        public abstract void Colide(Game game, Bullet colider);

        public abstract void Update(Game game);
    }
}