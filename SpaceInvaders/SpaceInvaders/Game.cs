using System.Threading;
using System.Collections.Generic;

namespace SpaceInvaders
{
    public class Game
    {
        public List<Enemy> enemies;
        public PLayer player;
        public List<Bullet> bullets;
        private List<Entity> _destroyList;
        private long _frame;
        public int wave;
        public int time;

        private int _boardWidth;
        private int _boardHeight;

        public int GetBoardWith()
        {
            return _boardWidth;
        }
        
        public int GetBoardHeight()
        {
            return _boardHeight;
        }

        private void AddWave(int y)
        {
            for (int i = 0; i < _boardWidth/SpaceShip.width-4; i++)
                enemies.Add(new Enemy(this,i+2, y));
            
        }

        public Game (int x, int y)
        {
            _boardWidth = x;
            _boardHeight = y;

            enemies = new List<Enemy>();
            player = new PLayer(this);
            bullets = new List<Bullet>();
            _destroyList = new List<Entity>();

            //Console.SetWindowSize(x,y);
            Printer.printBoard(this);
        }

        private void Update()
        {
            if (_frame % 250000 == 0)
            {
                foreach (Bullet bullet in bullets)
                    bullet.Update(this);
                    
                    
                foreach (Enemy enemy in enemies)
                {
                    enemy.Update(this);
                }
            }

            player.Update(this);
            DestroyEntities();
        }

        public void Play()
        {
            wave = 1;
            while (player.lives > 0)
            {
                for (int i = 0; i < wave; i++)
                    AddWave(i+2);
                
                while (player.lives > 0 && enemies.Count > 0)
                {
                    Update();
                    if(_frame % 250000 == 0)
                    {
                        Printer.printBoard(this);
                        time++;
                    }
                    _frame++;
                }

                wave++;
            }
            
            Printer.PrintGameOver(this);
        }

        public void DestroyEntity(Entity entity)
        {
            _destroyList.Add(entity);
        }

        private void DestroyEntities()
        {
            foreach (Entity entity in _destroyList)
            {
                if (entity is Bullet)
                {
                    Bullet bullet = (Bullet) entity;
                    bullets.Remove(bullet);
                }
                else if (entity is Enemy)
                {
                    Enemy enemy = (Enemy) entity;
                    enemies.Remove(enemy);
                }
            }
            
            _destroyList.Clear();
        }
    }
}