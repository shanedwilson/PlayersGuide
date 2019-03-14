using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersGuideChapter19
{
    public class Ball
    {
        public int Size { get; set; }
        public Color Color { get; set; }
        public int TimesThrown { get; set; }

        public Ball(int size, Color color)
        {
            Size = size;
            Color = color;
            TimesThrown = 0;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
            {
                TimesThrown++;
            }

        }

        public int GetThrown()
        {
            return TimesThrown;
        }
    }
}
