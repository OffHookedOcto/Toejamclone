using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJam_Earl
{
    // A simple object in the game (like a player, enemy, or item)
    public class GameObject
    {
        protected Texture2D sprite;   
        public Vector2 _position;
        protected Rectangle sourceRect;
        public float Scale = 1.0f;

        // Default empty constructor
        public GameObject()
        { 
        }

        // Virtual methods (can be overridden in child classes if needed)
        public virtual void Update(GameTime gameTime) 
        {
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (sprite != null)
            {
                spriteBatch.Draw(sprite, _position, sourceRect, Color.White, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
            }
        }
    }

    public class Toe_Jam : GameObject
    {
        public Toe_Jam(Texture2D texture, Vector2 position, Rectangle source)
        {
            sprite = texture;
            _position = position;
            sourceRect = source;
        }
    }
    public class NPC : GameObject
    {
        public NPC(Texture2D texture, Vector2 position, Rectangle source)
        {
            sprite = texture;
            _position = position;
            sourceRect = source;
        }
    }
    public class Enemy : GameObject
    {
        public Enemy(Texture2D texture, Vector2 position, Rectangle source)
        {
            sprite = texture;
            _position = position;
            sourceRect = source;
        }
    }
    public class Item : GameObject
    {
        public Item(Texture2D texture, Vector2 position, Rectangle source)
        {
            sprite = texture;
            _position = position;
            sourceRect = source;
        }
    }
    public class Elevator : GameObject
    {
        public Elevator(Texture2D texture, Vector2 position, Rectangle source)
        {
            sprite = texture;
            _position = position;
            sourceRect = source;
        }
    }
    public class Tile : GameObject
    {
        public Tile(Texture2D texture, Vector2 position, Rectangle source)
        {
            sprite = texture;
            _position = position;
            sourceRect = source;
        }
    }
    public class UIelement : GameObject
    {
        public UIelement(Texture2D texture, Vector2 position, Rectangle source)
        {
            sprite = texture;
            _position = position;
            sourceRect = source;
        }
    }
}
