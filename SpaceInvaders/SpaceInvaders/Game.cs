using System;
using System.Collections.Generic;

namespace SpaceInvaders
{
    public class Game
    {
        public List<Enemy> enemies;
        public PLayer player;
        public List<Bullet> bullets;
        public int score;

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

        private void AddWave()
        {
            for (int i = 0; i < 50; i++)
            {
                
            }
        }

        public Game (int x, int y)
        {
            _boardWidth = x;
            _boardHeight = y;

            enemies = new List<Enemy>();
            player = new PLayer(this);
            bullets = new List<Bullet>();
            
            //Console.SetWindowSize(x,y);
            Printer.printBoard(this);
        }

        public void Play()
        {
            while (!player.dead)
            {
                foreach (Bullet bullet in bullets)
                    bullet.Update(this);
                
                player.Update(this);
                
                foreach (Enemy enemy in enemies)
                    enemy.Update(this);
                
                
            }
        }

        public void DestroyEntity()
        {
            //TODO
        }
    }
}