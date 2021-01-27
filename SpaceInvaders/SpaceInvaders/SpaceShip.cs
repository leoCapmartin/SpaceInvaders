namespace SpaceInvaders
{
    public abstract class SpaceShip : Entity
    {
        public static int width = 6;
        protected void Shoot(Game game, SpaceShip shooter)
        {
            string rep;
            Direction direction;
            if (shooter is PLayer)
            {
                rep = "||";
                direction = Direction.Backward;
            }
            else
            {
                rep = "\\/";
                direction = Direction.Forward;
            }
            game.bullets.Add(new Bullet(X+2, Y, direction, rep));
        }
        
    }
}