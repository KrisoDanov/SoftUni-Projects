using System;
using System.Collections.Generic;
using System.Text;

namespace BoxData
{
   public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public double Lenght
        {
            get { return this.lenght; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }
                lenght = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }
        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }
        public double LateralSurfaceArea()
        {
            return (2 * lenght * height) + (2 * width * height);
        }

        public double SurfaceArea()
        {
            return (2 * lenght * width) + (2 * lenght * height) + (2 * width * height);
        }
        public double Volume()
        {
            return lenght * width * height;
        }
    }
}
