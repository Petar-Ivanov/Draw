using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    /// <summary>
    /// Класът елипса е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    [Serializable]
    public class EllipseShape : Shape
	{

        public static int EllipseCounter = 1;

        #region Constructor

        public EllipseShape(RectangleF rect) : base(rect)
		{
            this.Name = $"Ellipse{EllipseCounter++}";
        }
		
		public EllipseShape(RectangleShape rectangle) : base(rectangle)
		{
            this.Name = $"Ellipse{EllipseCounter++}";
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
        /// Проверява дали точка p се намира в границите на елипсата.
        /// Използва формулата (x-h)^2/a^2 + (y-k)^2/b^2 <= 1
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool IsPointInside(PointF p)
        {
            // Rotation matrix inversion
            Matrix inverseMatrix = Matrix.Clone();
            inverseMatrix.Invert();

            // Transforming the point by the inverse
            PointF[] transformedPoint = new PointF[] { p };
            inverseMatrix.TransformPoints(transformedPoint);
            PointF transformedP = transformedPoint[0];

            float x = transformedP.X;
            float y = transformedP.Y;

            float h = Rectangle.X + Rectangle.Width / 2;
            float k = Rectangle.Y + Rectangle.Height / 2;

            float a = Rectangle.Width / 2;
            float b = Rectangle.Height / 2;

			//(x-h)^2/a^2 + (y-k)^2/b^2 <= 1
			return (Math.Pow((x - h), 2) / Math.Pow(a,2)) + (Math.Pow((y - k), 2) / Math.Pow(b, 2)) <= 1;
        }

        /// <summary>
        /// Копира текущия примитив като създава и връща
        /// нова фигура от същия тип с характеристики
        /// като на оригиналната.
        /// </summary>
        public override Shape CopySelf()
        {
            EllipseShape copy = new EllipseShape(new RectangleF(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height));
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

            Brush brush = SetBrush();

            if (float.IsNaN(Matrix.Elements[4])) Matrix = new Matrix(1, 0, 0, 1, 0, 0);
            grfx.Transform = Matrix;//
            grfx.FillEllipse(brush,Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawEllipse(new Pen(Color.FromArgb(BorderColorOpacity, BorderColor), BorderRadius), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            if (IsSelected) DrawOutline(grfx);

            grfx.Restore(state);//

        }
	}
}
