using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersGuideChapter18
{
    class Color
    {
        private int Red;
        private int Green;
        private int Blue;
        private int Alpha;

        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        public int GetRed()
        {
            return Red;
        }

        public void SetRed(int red)
        {
            Red = red;
        }

        public int GetGreen()
        {
            return Green;
        }

        public void SetGreen(int green)
        {
            Green = green;
        }

        public int GetBlue()
        {
            return Blue;
        }

        public void SetBlue(int blue)
        {
            Blue = blue;
        }

        public int GetAlpha()
        {
            return Alpha;
        }

        public void SetAlpha(int alpha)
        {
            Alpha = alpha;
        }

        public int GetGrayScale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}
