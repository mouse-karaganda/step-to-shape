using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StepToShape.Tools
{
    public static class MathTools
    {
        /// <summary>
        /// Проверяет приближение к нулю, учитывая машинный эпсилон
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool EqualsZero(this double value)
        {
            var result = Math.Abs(value) < 10e-6;
            return result;
        }

        public static bool EqualsWith(this double self, double other)
        {
            var result = (self - other).EqualsZero();
            return result;
        }

        public static bool LessOrEquals(this double self, double other)
        {
            var result = self.EqualsWith(other) ? true : (self < other);
            return result;
        }

        public static Point ClipCenter()
        {
            var clip = Cursor.Clip;
            var result = new Point
            {
                X = clip.X + clip.Width / 2,
                Y = clip.Y + clip.Height / 2,
            };
            return result;
        }

        public static double ClipRadius()
        {
            var center = ClipCenter();
            var result = Math.Min(center.X, center.Y);
            return result;
        }

        public static Size ClipSquare()
        {
            var center = ClipCenter();
            var minValue = 2 * Math.Min(center.X, center.Y);
            var result = new Size
            {
                Width = minValue,
                Height = minValue,
            };
            return result;
        }
    }
}
