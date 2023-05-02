﻿using GameEngine;
using SFML.System;
using static System.Formats.Asn1.AsnWriter;

namespace MyGame
{
    class GameScene : Scene
    {
        private int _score;
        private int _lives = 3;
        public GameScene()
        {

            ScrollingBackground scrollingBackground = new ScrollingBackground();
            AddGameObject(scrollingBackground); 
            
            Ship ship = new Ship();
            AddGameObject(ship);
            ChocolateChipCookieSpawner meteorSpawner = new ChocolateChipCookieSpawner();
            AddGameObject(meteorSpawner);

            Score score = new Score(new Vector2f(10.0f, 10.0f));
            AddGameObject(score);

            


        }
        // Get the current score
        public int GetScore()
        {
            return _score;
        }
        // Increase the score
        public void IncreaseScore()
        {
            ++_score;
        }
        public int GetLives()
        {
            return _lives;
        }
        // Decrease the number of lives
        public void DecreaseLives()
        {
            --_lives;
            if (_lives == 0)
            {
                GameOverScene gameOverScene = new GameOverScene(_score);
                Game.SetScene(gameOverScene);
            }
        }
    }
}