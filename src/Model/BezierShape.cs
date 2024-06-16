﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    /// <summary>
    /// Класът крива на безие е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    [Serializable]
    public class BezierShape : Shape
	{
        /// <summary>
        /// Върхове на многоъгълника
        /// </summary>
        public PointF[] Vertices { get; set; }

        public static int BezierCounter = 1;


        #region Constructor


        public BezierShape(RectangleF rect) : base(rect)
		{
            this.Name = $"Bezier{BezierCounter++}";
		}
		
		public BezierShape(RectangleShape rectangle) : base(rectangle)
		{
            this.Name = $"Bezier{BezierCounter++}";
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
		/// Проверява за принадлежност на точка p към кривата на безие.
        /// Кривата се представя като многоъгълник и се използва 
        /// формулата за определяне на принадлежността на точка към многоъгълник, 
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
            BezierShape copy = new BezierShape(new RectangleF(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height));
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

            if (float.IsNaN(Matrix.Elements[4])) Matrix = new Matrix(1, 0, 0, 1, 0, 0);
            grfx.Transform = Matrix;//
            grfx.DrawBezier(
                new Pen(Color.FromArgb(BorderColorOpacity, BorderColor), BorderRadius),
                new PointF(Location.X, Location.Y),
                new PointF(Location.X + Width, Location.Y),
                new PointF(Location.X, Location.Y + Height),
                new PointF(Location.X + Width, Location.Y + Height)
                );


            PointF[] bezierPoints = new PointF[]
            {
                new PointF(Location.X, Location.Y),
                new PointF(Location.X + Width, Location.Y),
                new PointF(Location.X, Location.Y + Height),
                new PointF(Location.X + Width, Location.Y + Height)
            };

            Vertices = bezierPoints;

            if (IsSelected) DrawOutline(grfx);

            grfx.Restore(state);//
        }
	}
}
