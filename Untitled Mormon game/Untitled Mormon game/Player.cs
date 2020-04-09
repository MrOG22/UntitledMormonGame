using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Untitled_Mormon_game
{
    class Player : GameObject
    {
        public float rotationVelocity = 3f;
        public float linearVelocity = 4f;
        private Vector2 direction;
        private Transform transform;
        public Player(Vector2 startPosition)
        {
            transform = new Transform();

            transform.Position = startPosition;

            this.speed = 1000f;
            this.position.X = 200;
            this.position.Y = 300;
        }




        public override void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("WalkUP1");
            this.origin = new Vector2(sprite.Width / 2, sprite.Height / 2);
        }

        public override void Update(GameTime gameTime)
        {
            inputstuff(gameTime);
            Move(gameTime);
        }
        private void inputstuff(GameTime gameTime)
        {

            if (Keyboard.GetState().IsKeyDown(Keys.A))
                rotation -= MathHelper.ToRadians(rotationVelocity);
            else if (Keyboard.GetState().IsKeyDown(Keys.D))
                rotation += MathHelper.ToRadians(rotationVelocity);
            direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(90) - rotation), -(float)Math.Sin(MathHelper.ToRadians(90) - rotation));
            if (Keyboard.GetState().IsKeyDown(Keys.W))
                position += direction * linearVelocity;
            /*if (Keyboard.GetState().IsKeyDown(Keys.S))
                position -= direction * linearVelocity;*/
        }
        public void Move(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            position += ((velocity * speed) * deltaTime);

        }
    }
}
