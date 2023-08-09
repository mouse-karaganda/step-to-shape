using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepToShape.Tools
{
    public class PointD
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Point Position
        {
            get
            {
                var result = new Point
                {
                    X = (int)Math.Round(this.X),
                    Y = (int)Math.Round(this.Y),
                };
                return result;
            }
        }

        public static PointD operator *(PointD self, double multiplier)
        {
            var result = new PointD
            {
                X = self.X * multiplier,
                Y = self.Y * multiplier,
            };
            return result;
        }
    }
}
