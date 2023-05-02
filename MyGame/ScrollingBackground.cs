using GameEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
namespace MyGame
{
    class ScrollingBackground : GameObject
    {
        public readonly Sprite _sprite = new Sprite();
        public readonly Sprite _sprite1 = new Sprite();
        private const float Speed = 0.3f;
        public ScrollingBackground()
        {
            _sprite.Texture = Game.GetTexture("Resources/background.png");
            _sprite.Position = new Vector2f(0, 0);
            _sprite1.Texture = Game.GetTexture("Resources/background.png");
            _sprite1.Position = new Vector2f(800, 0);

        }
        public override void Draw()
        {
            Game.RenderWindow.Draw(_sprite);
            Game.RenderWindow.Draw(_sprite1);
        }

        public override void Update(Time elapsed)
        {

            Vector2f pos = _sprite.Position;
            Vector2f pos1 = _sprite1.Position;
            float x = pos.X;
            float x1 = pos1.X;
            int msElapsed = elapsed.AsMilliseconds();
            x -= Speed * msElapsed;
            x1 -= Speed * msElapsed;

            if (x < -800)
            {
                x = 800;
            }
            if (x1 < -800)
            {
                x1 = 800;
            }
            _sprite.Position = new Vector2f(x, pos.Y);
            _sprite1.Position = new Vector2f(x1, pos.Y);

        }
    }
}
