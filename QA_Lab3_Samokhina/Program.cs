using System;

namespace Programm_CSharp
{
    /// <summary>
    /// Класс, представляющий треугольник в двумерном пространстве.
    /// </summary>
    class Triangle
    {
        // Координаты вершин треугольника
        protected int _x1, _y1, _x2, _y2, _x3, _y3;

        /// <summary>
        /// Конструктор класса Triangle.
        /// </summary>
        /// <param name="x1">X-координата первой вершины.</param>
        /// <param name="y1">Y-координата первой вершины.</param>
        /// <param name="x2">X-координата второй вершины.</param>
        /// <param name="y2">Y-координата второй вершины.</param>
        /// <param name="x3">X-координата третьей вершины.</param>
        /// <param name="y3">Y-координата третьей вершины.</param>
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
            _x3 = x3;
            _y3 = y3;
        }

        /// <summary>
        /// Отображает координаты вершин треугольника.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("x1:" + _x1 + " y1:" + _y1);
            Console.WriteLine("x2:" + _x2 + " y2:" + _y2);
            Console.WriteLine("x3:" + _x3 + " y3:" + _y3);
        }

        /// <summary>
        /// Возвращает X-координату первой вершины.
        /// </summary>
        public int GetX1()
        {
            return _x1;
        }

        /// <summary>
        /// Возвращает Y-координату первой вершины.
        /// </summary>
        public int GetY1()
        {
            return _y1;
        }

        // Аналогичные методы для остальных вершин опущены для краткости.

        /// <summary>
        /// Рассчитывает и возвращает периметр треугольника.
        /// \f$ sideA = Math.Sqrt(Math.Pow(x2 - x1) + Math.Pow(y2 - y1)) \f$
        /// \f$ sideA = Math.Sqrt(Math.Pow(x2 - x1) + Math.Pow(y2 - y1)) \f$
        /// \f$ sideB = Math.Sqrt(Math.Pow(x3 - x2) + Math.Pow(y3 - y2)) \f$
        /// \f$ sideC = Math.Sqrt(Math.Pow(x3 - x1) + Math.Pow(y3 - y1)) \f$
        /// \f$ sideA + sideB + sideC \f$
        /// </summary>
        /// <returns>Периметр треугольника.</returns>
        public double GetPerimeter()
        {
            double sideA = Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));
            double sideB = Math.Sqrt(Math.Pow(_x3 - _x2, 2) + Math.Pow(_y3 - _y2, 2));
            double sideC = Math.Sqrt(Math.Pow(_x3 - _x1, 2) + Math.Pow(_y3 - _y1, 2));
            return sideA + sideB + sideC;
        }
    }

    /// <summary>
    /// Класс, представляющий треугольник в трехмерном пространстве с дополнительным параметром Z.
    /// </summary>
    class TriangleZ : Triangle
    {
        private int _z;

        /// <summary>
        /// Конструктор класса TriangleZ.
        /// </summary>
        /// <param name="x1">X-координата первой вершины.</param>
        /// <param name="y1">Y-координата первой вершины.</param>
        /// <param name="x2">X-координата второй вершины.</param>
        /// <param name="y2">Y-координата второй вершины.</param>
        /// <param name="x3">X-координата третьей вершины.</param>
        /// <param name="y3">Y-координата третьей вершины.</param>
        /// TRIANGLE:
        /// ![Image](../images/triangle.jpg)
        /// /// TRIANGLE:
        /// <img src="../images/triangle.jpg" alt="Triangle Image">
        /// <param name="z">Значение параметра Z.</param>
        public TriangleZ(int x1, int y1, int x2, int y2, int x3, int y3, int z) : base(x1, y1, x2, y2, x3, y3)
        {
            _z = z;
        }

        /// <summary>
        /// Отображает координаты вершин треугольника и значение параметра Z.
        /// </summary>
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Z:" + _z);
        }

        /// <summary>
        /// Устанавливает значение параметра Z.
        /// </summary>
        /// <param name="z">Новое значение параметра Z.</param>
        public void PutZ(int z)
        {
            _z = z;
        }

        /// <summary>
        /// Возвращает значение параметра Z.
        /// </summary>
        public int GetZ()
        {
            return _z;
        }

        /// <summary>
        /// Рассчитывает и возвращает периметр треугольника с учетом параметра Z.
        /// </summary>
        /// <returns>Периметр треугольника с учетом параметра Z.</returns>
        public new double GetPerimeter()
        {
            return base.GetPerimeter() + _z;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle ts = new Triangle(1, 1, 1, 2, 2, 2);
            Console.WriteLine("Triangle");
            ts.Display();
            Console.WriteLine("Perimeter:" + ts.GetPerimeter());

            TriangleZ tzs = new TriangleZ(1, 1, 1, 2, 2, 2, 3);
            Console.WriteLine("\nTriangle");
            tzs.Display();
            Console.WriteLine("Perimeter:" + tzs.GetPerimeter());

            Console.Read();
        }
    }
}



