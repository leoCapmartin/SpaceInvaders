using System;

namespace SpaceInvaders
{
    public class Enemy : SpaceShip
    {
        private int _randomChanceToShoot = 50;
        private Random _rnd = new Random();
        
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
            int chanceToShoot = _rnd.Next(_randomChanceToShoot);
            if(chanceToShoot == 0)
                Shoot(game, this);
        }
    }
}