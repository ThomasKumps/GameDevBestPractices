using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameDevBestPractices
{
    public class ScreenManager: Manager
    {
        public Vector2 Dimensions;

        public SpriteBatch SpriteBatch;
        public ContentManager ContentManager;
        public GraphicsDevice GraphicsDevice;
        

        private static ScreenManager instance;

        private ScreenManager() { }

        public static ScreenManager Instance 
        {
            get 
            {
                if (instance == null)
                    instance = new ScreenManager();

                return instance;
            }
        }

        public override void LoadContent()
        {
            base.LoadContent();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
