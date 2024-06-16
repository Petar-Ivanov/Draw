﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    /// <summary>
    /// Класът звезда е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    [Serializable]
    public class StarShape : Shape
	{
        /// <summary>
        /// Върхове на многоъгълника
        /// </summary>
        public Point[] Vertices { get; set; }

        public static int StarCounter = 1;

        #region Constructor

        public StarShape(RectangleF rect) : base(rect)
		{
            this.Name = $"Star{StarCounter++}";
        }
		
		public StarShape(RectangleShape rectangle) : base(rectangle)
		{
            this.Name = $"Star{StarCounter++}";
        }
		
		#endregion

		/// <summary>
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// В случая на правоъгълник този метод може да не бъде пренаписван, защото
		/// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		/// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		/// елемента в този случай).
		/// </summary>
		public override bool Contains(PointF point)
		{
			if (IsPointInside(point))
				// Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
				// В случая на правоъгълник - директно връщаме true
				return true;
			else
				// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
				return false;
		}

        /// <summary>
		/// Проверява за принадлежност на точка p към звездата.
        /// Използва се формулата за определяне на принадлежността на точка към многоъгълник, 
        /// чрез търсене на поне две пресичания между него и вектор.
		/// </summary>
        public bool IsPointInside(PointF p)
        {
            // Инверсия на матрицата на завъртане
            Matrix inverseMatrix = Matrix.Clone();
            inverseMatrix.Invert();

            // Трансформиране на точката чрез инверсията
            PointF[] transformedPoint = new PointF[] { p };
            inverseMatrix.TransformPoints(transformedPoint);
            PointF transformedP = transformedPoint[0];

            int intersectCount = 0;
            for (int i = 0; i < Vertices.Length; i++)
            {
                int next = (i + 1) % Vertices.Length;
                if (((Vertices[i].Y <= transformedP.Y && transformedP.Y < Vertices[next].Y) ||
                    (Vertices[next].Y <= transformedP.Y && transformedP.Y < Vertices[i].Y)) &&
                    (transformedP.X < (Vertices[next].X - Vertices[i].X) * (transformedP.Y - Vertices[i].Y) / (Vertices[next].Y - Vertices[i].Y) + Vertices[i].X))
                {
                    intersectCount++;
                }
            }
            return intersectCount % 2 == 1;
        }

        /// <summary>
        /// Копира текущия примитив като създава и връща
        /// нова фигура от същия тип с характеристики
        /// като на оригиналната.
        /// </summary>
        public override Shape CopySelf()
        {
            StarShape copy = new StarShape(new RectangleF(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height));
            copy.Name = Name;
            copy.FillColor = FillColor;
            copy.BorderColor = BorderColor;
            copy.SecondaryColor = SecondaryColor;
            copy.SecondaryBorderColor = SecondaryBorderColor;
            copy.BorderColorOpacity = BorderColorOpacity;
            copy.BorderRadius = BorderRadius;
            copy.BrushType = BrushType;
            copy.FillColorOpacity = FillColorOpacity;
            copy.IsGroup = IsGroup;
            //copy.IsSelected = IsSelected;
            copy.Matrix = Matrix;
            copy.Location = Location;
            copy.Rotation = Rotation;
            copy.RotationPoint = RotationPoint;
            copy.IsSubshape = IsSubshape;
            copy.Vertices = Vertices;

            return copy;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
		{
            var state = grfx.Save();//
            this.Matrix = new Matrix();//
            if (IsSubshape == false) this.RotationPoint = new PointF((Rectangle.X + Rectangle.Width / 2), (Rectangle.Y + Rectangle.Height / 2));
            Matrix.RotateAt(Rotation, this.RotationPoint);//

            base.DrawSelf(grfx);

            Point[] starPoints = new Point[]
            {
				new Point((int)(Rectangle.X + Rectangle.Width / 2), (int)Rectangle.Y),

                new Point((int)(Rectangle.X + Rectangle.Width * 3 / 8), (int)(Rectangle.Y + Rectangle.Height*3/8)),

                new Point((int)Rectangle.X, (int)(Rectangle.Y + Rectangle.Height*13/32)), 

                new Point((int)(Rectangle.X + Rectangle.Width * 5 / 16), (int)(Rectangle.Y + Rectangle.Height*5/8)),

                new Point((int)(Rectangle.X + Rectangle.Width * 3 / 16), (int)(Rectangle.Y + Rectangle.Height)),

                new Point((int)(Rectangle.X + Rectangle.Width / 2), (int)(Rectangle.Y + Rectangle.Height * 15 / 20)),///

                new Point((int)(Rectangle.X + Rectangle.Width * 13 / 16), (int)(Rectangle.Y + Rectangle.Height)),

                new Point((int)(Rectangle.X + Rectangle.Width * 11 / 16), (int)(Rectangle.Y + Rectangle.Height*5/8)),

                new Point((int)(Rectangle.X + Rectangle.Width), (int)(Rectangle.Y + Rectangle.Height*13/32)), 

                new Point((int)(Rectangle.X + Rectangle.Width * 5 / 8), (int)(Rectangle.Y + Rectangle.Height*3/8))

            };

            Vertices = starPoints;

            Brush brush = SetBrush();

            if (float.IsNaN(Matrix.Elements[4])) Matrix = new Matrix(1, 0, 0, 1, 0, 0);
            grfx.Transform = Matrix;//
            grfx.FillPolygon(brush, starPoints);
            grfx.DrawPolygon(new Pen(Color.FromArgb(BorderColorOpacity, BorderColor), BorderRadius), starPoints);

            if (IsSelected) DrawOutline(grfx);

            grfx.Restore(state);//
        }
	}
}