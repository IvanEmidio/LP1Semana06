using System;

namespace ColorSpheres
{
    class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }
        public byte GetGrey()
        {
            return (byte) ((red + green + blue) /3);
        }
        public byte GetRed()
        {
            return red;
        }
        public byte GetGreen()
        {
            return green;
        }
        public byte GetBlue()
        {
            return blue;
        }
        public byte GetAlpha()
        {
            return alpha;
        }
        public void SetRed(byte input)
        {
            red = input;
        }
        public void SetGreen(byte input)
        {
            green = input;
        }
        public void SetBlue(byte input)
        {
            blue = input;
        }
        public void SetAlpha(byte input)
        {
            alpha = input;
        }
    }
}