using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersGuideChapter18
{
    class Ball
    {
        private int Size;
        private Color color;
        private int TimesThrown;

        public Ball(int size, Color color, int timesThrown)
        {
            Size = size;
            this.color = color;
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
