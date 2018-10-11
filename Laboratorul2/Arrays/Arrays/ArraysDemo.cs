using System;

namespace Arrays
{
    public class ArraysDemo
    {
        private readonly string[] _colors;

        public ArraysDemo()
        {
            _colors = new string[4];
            _colors[0] = "Red";
            _colors[1] = "White";
            _colors[2] = "Green";
            _colors[3] = "Blue";
        }

        public string GetElementByPosition(int position)
        {
            if (position<0 || position>=_colors.Length)
            {
                throw new IndexOutOfRangeException("Pay attention!!!!");
            }
            return _colors[position];
        }

        public int ArrayLenght()
        {
            return _colors.Length;
        }
    }
}
