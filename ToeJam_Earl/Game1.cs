using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;
using MonoGameLibrary.Graphics;
using System.Collections.Generic;

namespace ToeJam_Earl
{
    public class Game1 : Core
    {
        private AnimatedSprite _ToeJam0;

        private List<GameObject> gameObjects;

        private Texture2D NPC_1;
        private Texture2D Enemy_1;
        private Texture2D Items_1;
        private Texture2D Elevator_1;
        private Texture2D Tiles_1;
        private Texture2D UIelement_1;

        private Rectangle enemySourceRect = new Rectangle(8, 54, 32, 24);
        private Rectangle npcSourceRect = new Rectangle(10, 73, 59, 39);
        private Rectangle elevatorSourceRect = new Rectangle(4, 6, 32, 54);
        private Rectangle tilesSourceRect = new Rectangle(0, 0, 192, 191);
        private Rectangle itemsSourceRect = new Rectangle(72, 78, 17, 10);
        private Rectangle uiSourceRect = new Rectangle(56, 173, 32, 3);

        public Game1() : base("ToeJam and Earl Project", 1280, 720, false)
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            TextureAtlas atlas = TextureAtlas.FromFile(Content, "images/ToeJam_Transparent.xml");
            _ToeJam0 = atlas.CreateAnimatedSprite("ToeJamAnimation");
            _ToeJam0.Scale = new Vector2(4.0f, 4.0f);

            NPC_1 = Content.Load<Texture2D>("images/LawnMower_Man");
            Enemy_1 = Content.Load<Texture2D>("images/Lil_Devil");
            Items_1 = Content.Load<Texture2D>("images/items_scenery_tranparent");
            Elevator_1 = Content.Load<Texture2D>("images/Elevator");
            Tiles_1 = Content.Load<Texture2D>("images/floor_path_tiles");
            UIelement_1 = Content.Load<Texture2D>("images/HUD_Display");

            gameObjects = new List<GameObject>
            {
                new NPC(NPC_1, new Vector2(100, 200), npcSourceRect){ Scale = 3f },
                new Enemy(Enemy_1, new Vector2(200, 0), enemySourceRect){ Scale = 3f },
                new Item(Items_1, new Vector2(400, 200), itemsSourceRect){ Scale = 3f },
                new Elevator(Elevator_1, new Vector2(550, 200), elevatorSourceRect){ Scale = 3f },
                new Tile(Tiles_1, new Vector2(700, 200), tilesSourceRect){ Scale = 1f },
                new UIelement(UIelement_1, new Vector2(550, 650), uiSourceRect){ Scale = 7f }
            };
        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _ToeJam0.Update(gameTime);

            foreach (var obj in gameObjects)
                obj.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            SpriteBatch.Begin(samplerState: SamplerState.PointClamp);

            _ToeJam0.Draw(SpriteBatch, Vector2.One);

            foreach (var obj in gameObjects)
                obj.Draw(SpriteBatch);

            SpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
