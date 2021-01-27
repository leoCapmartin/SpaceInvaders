using System;
using System.ComponentModel.DataAnnotations;

namespace SpaceInvaders
{
    public abstract class Entity
    {
        public int X;
        public int Y;
        public string display;
        public ConsoleColor color;
        protected int speed;
        protected int width;

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
            //TODO
        }

        public static void Spawn(Game game, int x, int y)
        {
            //TODO   
        }

        public abstract void Colide(Entity colider);
        
        public abstract void Update(Game game);
    }
}