using StepToShape.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepToShape.Shapes
{
    public abstract class BaseShape
    {
        public int StepCount { get; set; } = 10;

        /// <summary>
        /// Вычисляет точку для очередного шага.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        protected abstract PointD RawPoint(double stepValue);

        public abstract List<PointD> DrawToList();

        /// <summary>
        /// Отражает путь: по вертикали зеркально,
        /// по горизонтали - в обратном порядке
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        protected List<PointD> MirrorToList(List<PointD> path)
        {
            var result = new List<PointD>();
            if (path == null)
            {
                return result;
            }

            // Пропускаем первую и последнюю точку, потому что они совпадают
            for (int index = path.Count - 1; index > 1; index--)
            {
                var currentPoint = path[index - 1];
                var newPoint = new PointD
                {
                    X = currentPoint.X,
                    Y = -currentPoint.Y,
                };
                result.Add(newPoint);
            }
            return result;
        }

        /// <summary>
        /// Переводит арифметические координаты
        /// в координаты от центра экрана
        /// </summary>
        /// <param name="draw"></param>
        protected void MoveToScreenCenter(List<PointD> list)
        {
            var center = MathTools.ClipCenter();
            foreach (var item in list)
            {
                item.X = center.X + item.X;
                item.Y = center.Y - item.Y;
            }
        }
    }
}
