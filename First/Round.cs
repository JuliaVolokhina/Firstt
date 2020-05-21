using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Round
    {
        Point point = null;

        public Round(double x, double y, double r)
        {
            this.Radius = r;
            point = new Point(x, y);
        }

        public double Area()
        {
            return Math.PI * R * R;
        }

        public double Lenght()
        {

            return Math.PI * 2 * R;
        }

        public void Show()
        {
            Console.WriteLine("Center: (" + point.X + ", " + point.Y + "), radius: " + R);
        }

        public double R { get; set; }
        public double Radius
        {
            set
            {
                if (value > 0)
                {
                    this.R = value;
                }
                else
                {
                    throw new FormatException();
                }
            }
            get
            {
                return R;
            }
        }
    }
}
