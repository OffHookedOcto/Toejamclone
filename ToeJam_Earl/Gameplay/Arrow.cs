
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ToeJamAndEarlFirstBatch
{
    public class Arrow : GraphicsComponent
    {
        public Arrow(Vector2 position, Vector2 direction)
        {

        }

        public Arrow(int length, int squareSize, ref Texture2D pixel)
        {
            _length = length;
            _squareSize = squareSize;

            _pixel = pixel;
            _pixel.SetData(new[] { Color.White });
        }

        public Arrow(Vector2 oFFSET, Texture2D pixel, int length, int squareSize)
        {
            OFFSET = oFFSET;
            _pixel = pixel;
            _length = length;
            _squareSize = squareSize;
        }

        public Arrow()
        {
        }

        Vector2 OFFSET = new Vector2(8, 8);

        public void Draw(SpriteBatch spriteBatch, Vector2 origin, Vector2 direction, Color color)
        {
            direction.Normalize();
            for (int i = 1; i <= _length; i++)
            {
                Vector2 pos = origin + (4*OFFSET) + direction * _squareSize * i;
                spriteBatch.Draw(_pixel,
                                 new Rectangle((int)pos.X, (int)pos.Y, _squareSize, _squareSize),
                                 color);
            }
        }

        public bool HasCollisionAtTarget()
        {
            bool res = false;



            return res;

        }

        public override bool Equals(object obj)
        {
            return obj is Arrow arrow &&
                   OFFSET.Equals(arrow.OFFSET) &&
                   EqualityComparer<Texture2D>.Default.Equals(_pixel, arrow._pixel) &&
                   _length == arrow._length &&
                   _squareSize == arrow._squareSize;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OFFSET, _pixel, _length, _squareSize);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            base.Draw(spriteBatch, position);
        }

        public Texture2D _pixel;
        public int _length;
        public int _squareSize;
    }
}
