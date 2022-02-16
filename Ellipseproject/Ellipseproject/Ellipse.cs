using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellipseproject
{
    public class Figure
    {
        public point Centre;
        public int HorizontalRadius { get; set; }
        public int VerticalRadius { get; set; }
        public Figure
            (
            point Centre,
            int Horizontalradius,
            int Verticalradius
            )
        {
            if (Horizontalradius <= 0)
            {
                throw new ArgumentException("Горизонтальный радиус введён неверно");
            }
            if (Verticalradius <= 0)
            {
                throw new ArgumentException("Вертикальный радиус введён неверно");
            }

            Centre = Centre;
            HorizontalRadius = Horizontalradius;
            VerticalRadius = Verticalradius;

        }
        public double Square()
        {
            return Math.Round(Math.PI * HorizontalRadius * VerticalRadius);
        }
        public double Lenght()
        {
            return Math.Round(Math.PI * (HorizontalRadius + VerticalRadius));
        }
    }
}
