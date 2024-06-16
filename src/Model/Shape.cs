using Draw.src.Model;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
	/// <summary>
	/// Базовия клас, който съдържа общите характеристики на примитивите.
	/// </summary>
	[Serializable]
    public abstract class Shape
	{
        #region Constructors


        public Shape()
		{
		}

		public Shape(RectangleF rect)
		{
			rectangle = rect;
		}

		public Shape(Shape shape)
		{
			this.Height = shape.Height;
			this.Width = shape.Width;
			this.Location = shape.Location;
			this.rectangle = shape.rectangle;

			this.FillColor = shape.FillColor;
		}
		#endregion

		#region Properties
		
		private RectangleF rectangle;
        /// <summary>
        /// Обхващащ правоъгълник на елемента.
        /// </summary>
        public virtual RectangleF Rectangle {
			get { return rectangle; }
			set { rectangle = value; }
		}

		private string name = "shape";
        /// <summary>
        /// Име на елемента.
        /// </summary>
        public string Name
		{
            get { return name; }
            set { name = value; }
        }

		/// <summary>
		/// Широчина на елемента.
		/// </summary>
		public virtual float Width {
			get { return Rectangle.Width; }
			set { rectangle.Width = value; }
		}

		/// <summary>
		/// Височина на елемента.
		/// </summary>
		public virtual float Height {
			get { return Rectangle.Height; }
			set { rectangle.Height = value; }
		}


		/// <summary>
		/// Горен ляв ъгъл на елемента.
		/// </summary>
		public virtual PointF Location {
			get { return Rectangle.Location; }
			set { rectangle.Location = value; }
		}
		
		protected Color fillColor = Color.White;
        /// <summary>
        /// Основен цвят на запълване на елемента.
        /// </summary>
        public virtual Color FillColor {
			get { return fillColor; }
			set { fillColor = value; }
		}

		protected Color borderColor = Color.Black;
        /// <summary>
        /// Основен цвят на границата на елемента.
        /// </summary>
        public virtual Color BorderColor
		{
			get { return borderColor; }
			set { borderColor = value; }
		}

		protected Color secondaryColor = Color.White;
        /// <summary>
        /// Вторичен цвят на запълване на елемента.
        /// </summary>
        public virtual Color SecondaryColor
		{
			get { return secondaryColor; }
			set { secondaryColor = value; }
		}

		protected Color secondaryBorderColor = Color.Black;
        /// <summary>
        /// Вторичен цвят на границата на елемента.
        /// </summary>
        public virtual Color SecondaryBorderColor
		{
			get { return secondaryBorderColor; }
			set { secondaryBorderColor = value; }
		}

		protected int fillColorOpacity = 255;
        /// <summary>
        /// Наситеност на цвета на зашълване на елемента.
        /// </summary>
        public virtual int FillColorOpacity
		{
			get { return fillColorOpacity; }
			set { fillColorOpacity = value; }
		}

		protected int borderColorOpacity = 255;
        /// <summary>
        /// Наситеност на цвета на границата на елемента.
        /// </summary>
        public virtual int BorderColorOpacity
		{
			get { return borderColorOpacity; }
			set { borderColorOpacity = value; }
		}
		
		protected float borderRadius = 2;
        /// <summary>
        /// Радиус на границата на елемента.
        /// </summary>
        public virtual float BorderRadius
		{
			get { return borderRadius; }
			set { borderRadius = value; }
		}

		protected string brushType = "Solid Brush";
        /// <summary>
        /// Тип на четката (Solid/Gradient).
        /// </summary>
        public virtual string BrushType
		{
			get { return brushType; }
			set { brushType = value; }
		}

        [NonSerialized]
        protected Matrix matrix = new Matrix();
        /// <summary>
        /// Матрица на елемента.
        /// </summary>
        public virtual Matrix Matrix
		{
			get { return matrix; }
			set { matrix = value; }
		}

		protected float rotation = 0;
		/// <summary>
		/// Ъгъл на ротация на елемента.
		/// </summary>
		public virtual float Rotation
		{
			get { return rotation; }
			set 
			{
				rotation = value; 
			}
		}

		private float oldRotation = 0;
		/// <summary>
		/// Ъгъл на предходната ротация.
		/// </summary>
        public virtual float OldRotation
        {
            get { return oldRotation; }
            set
            {
                oldRotation = value;
            }
        }

		protected float rotationDiff = 0;
		public virtual float RotationDiff
		{
			get { return rotationDiff; }
			set { rotationDiff = value; }
		}

        private bool isSelected = false;
		/// <summary>
		/// Свойство, показващо дали елементат е селектиран.
		/// </summary>
		public bool IsSelected
		{
			get { return isSelected; }
			set { isSelected = value; }
		}

		private bool isGroup = false;
		/// <summary>
		/// Свойство показващо дали елемента е група.
		/// </summary>
		public bool IsGroup
		{
			get { return isGroup; }
			set { isGroup = value; }
		}

		protected PointF rotationPoint = new PointF(0, 0);
		/// <summary>
		/// Център на ротация на елемента.
		/// </summary>
		public virtual PointF RotationPoint
		{
			get { return rotationPoint; }
			set { rotationPoint = value; }
		}

		private bool isSubshape = false;
		/// <summary>
		/// Свойство показващо дали елементът се съдържа в група.
		/// </summary>
		public bool IsSubshape
		{
			get { return isSubshape; }
			set { isSubshape = value; }
		}

		#endregion

		/// <summary>
		/// Проверка дали точка point принадлежи на елемента.
		/// </summary>
		/// <param name="point">Точка</param>
		/// <returns>Връща true, ако точката принадлежи на елемента и
		/// false, ако не пренадлежи</returns>
		public virtual bool Contains(PointF point)
		{
			return Rectangle.Contains(point.X, point.Y);
		}
		
		/// <summary>
		/// Визуализира елемента.
		/// </summary>
		/// <param name="grfx">Къде да бъде визуализиран елемента.</param>
		public virtual void DrawSelf(Graphics grfx)
		{
			// shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);

		}

		public virtual Shape CopySelf()
		{
			return null;
		}

		/// <summary>
		/// Огражда с пунктиран правоъгълник фигурата за да я
		/// означи като селектирана.
		/// </summary>
		/// <param name="grfx"></param>
		public void DrawOutline(Graphics grfx)
		{
            float[] dashValues = { 5, 2 };
            Pen dashPen = new Pen(Color.Red, 2);
            dashPen.DashPattern = dashValues;
            grfx.DrawRectangle(dashPen, Rectangle.X - 5, Rectangle.Y - 5, Rectangle.Width + 10, Rectangle.Height + 10);
            
        }

		/// <summary>
		/// Създава четка в зависимост от избраните типове и
		/// цветове в свойствата на елемента.
		/// </summary>
		/// <returns>Връща четка.</returns>
		public Brush SetBrush()
		{
            Color color = Color.FromArgb(FillColorOpacity, FillColor);
            Brush brush = new SolidBrush(color);

            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                new PointF(Rectangle.X, Rectangle.Y + Rectangle.Height / 2),
                new PointF(Rectangle.X + Width, Rectangle.Y + Rectangle.Height / 2),
                FillColor,
                SecondaryColor);

            SolidBrush solidBrush = new SolidBrush(color);

            if (BrushType == "Solid Brush") brush = solidBrush;
            else if (BrushType == "Gradient Brush") brush = gradientBrush;

			return brush;
        }
		
	}
}
