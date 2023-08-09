using StepToShape.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepToShape.Shapes
{
    public class Circle : BaseShape
    {
        protected double _radius;

        public double Radius
        {
            get => this._radius;
            set
            {
                this._radius = (value < 0) ? -value : value;
                if (value.EqualsZero())
                {
                    this._radius = 1;
                }
            }
        }

        /// <summary>
        /// Радиус для предварительных вычислений с большой точностью
        /// </summary>
        protected double PreconditionRadius = 1000;

        public Circle(double radius)
        {
            this.StepCount = 30;
            this.Radius = radius;
        }

        /// <summary>
        /// Вычисляет точку для очередного шага по верхней половине окружности.
        /// Для окружности stepValue - это не координата по оси X,
        /// а угол в радианах от левого края (от 0 до pi)
        /// </summary>
        /// <param name="stepValue"></param>
        /// <returns></returns>
        protected override PointD RawPoint(double stepValue)
        {
            //var result = Math.Sqrt(Math.Pow(this.Radius, 2) - Math.Pow(stepValue, 2));
            var result = new PointD
            {
                //X = -Math.Cos(stepValue) * this.PreconditionRadius,
                //Y = Math.Sin(stepValue) * this.PreconditionRadius,
                X = -Math.Cos(stepValue) * this.Radius,
                Y = Math.Sin(stepValue) * this.Radius,
            };
            return result;
        }

        public override List<PointD> DrawToList()
        {
            var result = new List<PointD>();

            // Верхняя половина
            result.AddRange(this.DrawTop());
            // Нижняя половина
            result.AddRange(this.DrawBottom(result));

            this.MoveToScreenCenter(result);
            return result;
        }

        protected List<PointD> DrawTop()
        {
            var result = new List<PointD>();
            var oneAngle = Math.PI / this.StepCount;
            double stepValue = 0;

            for (int stepIndex = 0; stepIndex <= this.StepCount; stepIndex++)
            {
                result.Add(this.RawPoint(stepValue));
                stepValue += oneAngle;
            }
            return result;
        }

        protected List<PointD> DrawBottom(List<PointD> top)
        {
            return this.MirrorToList(top);
        }
    }
}
