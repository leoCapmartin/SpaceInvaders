using System;

namespace SpaceInvaders
{
    public class Enemy : SpaceShip
    {
        public Enemy(Game game, int x, int y)
        {
            display = "[ <> ]";
            color = ConsoleColor.Red;
            width = 6;
            speed = 6;

            X = 0;
            Y = 2;


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