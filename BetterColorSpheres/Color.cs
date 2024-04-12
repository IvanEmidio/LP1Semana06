using System;

namespace BetterColorSpheres
{
    class Color
    {
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; } = 255;
        public byte GreyScale
        {
            get
            {
                return (byte) ((red + green + blue) /3);
            }
        }
    }
}