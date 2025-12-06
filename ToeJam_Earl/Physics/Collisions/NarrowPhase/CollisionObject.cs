using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLibrary.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public abstract class CollisionComponent : System.ComponentModel.Component
    {
        GraphicsComponent visualComponent;

        public CollisionComponent(ref Texture2D texture, ref Rectangle rect, Vector2 pos)
        {
            visualComponent = new BasicGraphicsComponent(new Sprite(texture, rect), pos, 1.0f);
        }

        public enum Type
        {
            CollisionBox,
            CollisionAABB,
            CollisionCapsule,
            CollisionSphere,
        }

        public abstract bool Visits(CollisionComponent obj1);
        public abstract bool CollidesWithCollisionBox(CollisionBox collisionBox);
        public abstract bool CollidesWithCollisionAABB(CollisionAABB collisionAABB);
        public abstract bool CollidesWithCollisionCapsule(CollisionCapsule collisionCapsule);
        public abstract bool CollidesWithCollisionSphere(CollisionSphere collisionSphere);

        public void Draw(SpriteBatch spriteBatch, Vector2 pos) => visualComponent.Draw(spriteBatch, pos);

        private class BasicGraphicsComponent : GraphicsComponent
        {
            private Sprite sprite;
            private Vector2 pos;
            private float v;

            public BasicGraphicsComponent(Sprite sprite, Vector2 pos, float v)
            {
                this.sprite = sprite;
                this.pos = pos;
                this.v = v;
            }
        }
    }

    internal class GraphicsComponent
    {

        public override void Draw(SpriteBatch spriteBatch, Vector2 position) => throw new System.NotImplementedException();
        internal void Draw(SpriteBatch spriteBatch, Vector2 pos)
        {
            throw new NotImplementedException();
        }

        internal void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }
    }
}
