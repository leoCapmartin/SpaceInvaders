﻿using System;

namespace SpaceInvaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(100, 30);
            game.Play();
        }
    }
}