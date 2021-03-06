﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Untitled_Mormon_game.CommandPattern;

namespace Untitled_Mormon_game
{
    class Player : GameObject
    {
        /*public float rotationVelocity = 3f;
        public float linearVelocity = 4f;
        private Vector2 direction;*/
        private Transform transform;
        public Player(Vector2 startPosition)
        {
            transform = new Transform();

            transform.Position = startPosition;

            this.speed = 100f;
            this.position.X = 200;
            this.position.Y = 300;
            InputHandler.Instance.Entity = this;
        }




        public override void LoadContent(ContentManager content)
        {
            sprites = new Texture2D[3];

            for (int i = 0; i < sprites.Length; i++)
            {
                sprites[i] = content.Load<Texture2D>(i + 1 + "WalkUP");
            }
            fps = 3;
            sprite = sprites[0];

            this.origin = new Vector2(sprite.Width / 2, sprite.Height / 2);
        }

        public override void Update(GameTime gameTime)
        {
            //inputstuff(gameTime);
            //Move(velocity);
            if (Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.S) || Keyboard.GetState().IsKeyDown(Keys.D))
            {
            Animation(gameTime);
            }
        }
        /*private void inputstuff(GameTime gameTime)
        {

            if (Keyboard.GetState().IsKeyDown(Keys.A))
                rotation -= MathHelper.ToRadians(rotationVelocity);
            else if (Keyboard.GetState().IsKeyDown(Keys.D))
                rotation += MathHelper.ToRadians(rotationVelocity);
            direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(90) - rotation), -(float)Math.Sin(MathHelper.ToRadians(90) - rotation));
            if (Keyboard.GetState().IsKeyDown(Keys.W))
                position += direction * linearVelocity;
            if (Keyboard.GetState().IsKeyDown(Keys.S))
                position -= direction * linearVelocity;
        }*/
        public void Move(Vector2 velocity)
        {
            position += ((velocity * speed) * GameWorld.DeltaTime);
        }
    }
}
