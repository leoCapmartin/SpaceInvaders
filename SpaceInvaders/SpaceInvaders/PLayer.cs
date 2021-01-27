using System;

namespace SpaceInvaders
{
    public class PLayer : SpaceShip
    {
        public int lives = 3;
        
        public ConsoleColor color;
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
            
        }
    }
}