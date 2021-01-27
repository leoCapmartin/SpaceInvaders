using System;

namespace SpaceInvaders
{
    public class PLayer : SpaceShip
    {
        public int lives = 3;
        public bool dead = false;
        public PLayer(Game game)
        {
            display = "[ || ]";
            width = 6;
            speed = 6;
            color = ConsoleColor.White;
            X = game.GetBoardWith() / 2 - width / 2;
            Y = game.GetBoardHeight() -2;
        }
        
        public override void Colide(Entity colider)
        {
            
        }

        public override void Update(Game game)
        {
            
        }
    }
}