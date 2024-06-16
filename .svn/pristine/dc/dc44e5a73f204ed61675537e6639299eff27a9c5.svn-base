using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    /// <summary>
	/// Класът група е основен примитив, който е наследник на базовия Shape и е съставен от други примитиви.
	/// </summary>
	[Serializable]
    public class GroupShape : Shape
    {
        //public Point[] Vertices { get; set; }
        public static int GroupCounter = 1;

        private List<Shape> subshapes = new List<Shape>();
        /// <summary>
        /// Списък от съставните прмитиви на групата.
        /// </summary>
        public List<Shape> Subshapes
        {
            get { return this.subshapes; }
            set { this.subshapes = value; }
        }

        /// <summary>
        /// Промяна на локацията на всички примитиви в групата.
        /// </summary>
        public override PointF Location
        {
            get { return Rectangle.Location; }
            set 
            { 
                foreach (Shape subShape in this.subshapes)
                {
                    //float xDiff = value.X - this.Location.X;
                    //float yDiff = value.Y - this.Location.Y;
                    subShape.Location = new PointF(subShape.Location.X - Location.X + value.X, subShape.Location.Y - Location.Y + value.Y);
                    //subShape.Location = new PointF(subShape.Location.X + xDiff, subShape.Location.Y + yDiff);
                    
                }
                base.Location = value;
            }
        }

        /// <summary>
        /// Промяна на основния цвят на запълване на всички примитиви в групата.
        /// </summary>
        public override Color FillColor
        {
            get { return this.fillColor; }
            set 
            { 
                this.fillColor = value;
                foreach (Shape subShape in this.subshapes)
                {
                    subShape.FillColor = value;
                }
            }
        }

        /// <summary>
        /// Промяна на основния цвят на границата на всички примитиви в групата.
        /// </summary>
        public override Color BorderColor
        {
            get { return borderColor; }
            set 
            { 
                borderColor = value; 
                foreach(Shape subShape in this.subshapes)
                {
                    subShape.BorderColor = value;
                }
            }
        }

        /// <summary>
        /// Промяна на вторичния цвят на запълване на всички примитиви в групата.
        /// </summary>
        public override Color SecondaryColor
        {
            get { return secondaryColor; }
            set 
            { 
                secondaryColor = value;
                foreach (Shape subShape in this.subshapes)
                {
                    subShape.SecondaryColor = value;
                }
            }
        }

        /// <summary>
        /// Промяна на вторичния цвят на границата на всички примитиви в групата.
        /// </summary>
        public override Color SecondaryBorderColor 
        {
            get { return secondaryBorderColor; }
            set
            {
                secondaryBorderColor = value;
                foreach (Shape subShape in this.subshapes)
                {
                    subShape.SecondaryBorderColor = value;
                }
            }
        }

        /// <summary>
        /// Промяна на наситеността на запълващия цвят на всички примитиви в групата.
        /// </summary>
        public override int FillColorOpacity
        {
            get { return fillColorOpacity; }
            set 
            { 
                fillColorOpacity = value;
                foreach (Shape subShape in this.subshapes)
                {
                    subShape.FillColorOpacity = value;
                }
            }
        }

        /// <summary>
        /// Промяна на матрицата на всички примитиви в групата.
        /// </summary>
        public override Matrix Matrix
        {
            get { return matrix; }
            set 
            { 
                this.matrix = value; 
                foreach(Shape subShape in this.subshapes)
                {
                    subShape.RotationPoint = new PointF((Rectangle.X + Rectangle.Width / 2), (Rectangle.Y + Rectangle.Height / 2));
                    subShape.Matrix = value;
                }
            }
        }

        /// <summary>
        /// Промяна на наситеността на граничния цвят на всички примитиви в групата.
        /// </summary>
        public override int BorderColorOpacity
        {
            get { return borderColorOpacity; }
            set 
            { 
                borderColorOpacity = value; 
                foreach(Shape subShape in this.subshapes)
                {
                    subShape.BorderColorOpacity = value;
                }
            }
        }

        /// <summary>
        /// Промяна на типа на четката на всички примитиви в групата.
        /// </summary>
        public override string BrushType
        {
            get { return brushType; }
            set 
            { 
                brushType = value; 
                foreach( Shape subShape in this.subshapes)
                {
                    subShape.BrushType = value;
                }
            }
        }

        /// <summary>
        /// Промяна на радиуса на границата на всички примитиви в групата.
        /// </summary>
        public override float BorderRadius
        {
            get { return borderRadius; }
            set 
            { 
                borderRadius = value; 
                foreach(Shape subShape in this.subshapes)
                {
                    subShape.BorderRadius = value;
                }
            }
        }

        /// <summary>
        /// Промяна на завъртането на всички примитиви в групата.
        /// </summary>
        public override float Rotation
        {
            get { return rotation; }
            set
            {
                rotation = value;
                foreach(Shape subShape in this.subshapes)
                {
                    subShape.Rotation = value + subShape.RotationDiff;
                }
            }
        }


        #region Constructor

        public GroupShape(RectangleF rect) : base(rect)
        {
            IsGroup = true;
            this.Name = $"Group{GroupCounter++}";
            //RotationPoint = new PointF((Rectangle.X + Rectangle.Width / 2), (Rectangle.Y + Rectangle.Height / 2));
        }

        public GroupShape(RectangleShape rectangle) : base(rectangle)
        {
            IsGroup = true;
            this.Name = $"Group{GroupCounter++}";
            //RotationPoint = new PointF((Rectangle.X + Rectangle.Width / 2), (Rectangle.Y + Rectangle.Height / 2));
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
            foreach (Shape shape in subshapes)
            {
                if (shape.Contains(point))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Копира текущия примитив като създава и връща
        /// нова фигура от същия тип с характеристики
        /// като на оригиналната.
        /// </summary>
        public override Shape CopySelf()
        {
            GroupShape copy = new GroupShape(new RectangleF(Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height));
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
            //copy.Subshapes = Subshapes;
            foreach (Shape shape in subshapes)
            {
                copy.Subshapes.Add(shape.CopySelf());
            }

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

            foreach (Shape shape in subshapes)
            {
                //shape.Rotation = shape.Rotation + Rotation;
                shape.DrawSelf(grfx);
            }

            if (IsSelected) DrawOutline(grfx);

            grfx.Restore(state);//
        }

    }
}
