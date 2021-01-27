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

        protected void Move(Game game, Axis axis, Direction direction)
        {
            if (axis == Axis.X)
                X += (int) direction;
            else
                Y += (int) direction;
        }
        public abstract void Colide(Game game, Bullet colider);

        public abstract void Update(Game game);
    }
}