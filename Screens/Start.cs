using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using System;
using Android.App;
using Android.OS;
using System.IO;

namespace Xaria.Screens
{
    /// <summary>
    /// The start screen class
    /// </summary>
    /// <seealso cref="Xaria.Screen" />
    class Start : Screen
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Start" /> class.
        /// </summary>
        /// <param name="Content">The content.</param>
        public Start(ContentManager Content)
        {
            Texture2D startTexture = Content.Load<Texture2D>("Buttons/start");
            Buttons.Add(new Button(startTexture, new Vector2((Game1.screenSize.X - startTexture.Width) / 3f, 2*(Game1.screenSize.Y - startTexture.Height) / 3f), StartGame));

            Texture2D start1Texture = Content.Load<Texture2D>("Buttons/start1");
            Buttons.Add(new Button(start1Texture, new Vector2(startTexture.Width + (Game1.screenSize.X - start1Texture.Width) / 3f + 10, 2 * (Game1.screenSize.Y - start1Texture.Height) / 3f), StartGame));

        }
        void PauseGame()
        {
           
        } 

        /// <summary>
        /// Starts the game.
        /// </summary>
        void StartGame()
        {
            
            Game1.state = GameState.Playing;
            this.Start();
        }
    }

    class Endless : Screen
    {
        public Endless(ContentManager Content)
        {
            //error
            //Texture2D startTexture = Content.Load<Texture2D>("Endless");
           // Buttons.Add(new Button(startTexture, new Vector2(2 * (Game1.screenSize.X - startTexture.Width) / 3f, 2 * (Game1.screenSize.Y - startTexture.Height) / 3f), EndlessGame));
        }

        void EndlessGame()
        {
            Game1.state = GameState.Playing;
            //Game1.player.Health = Player.STARTING_HEALTH;
           // Game1.level = new Level(1);
        }
    }
}