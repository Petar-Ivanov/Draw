using Draw.src.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Класът, който служи за управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Избран елемент.
		/// </summary>
		private List<Shape> selection = new List<Shape>();
		public List<Shape> Selection {
			get { return selection; }
			set { selection = value; }
		}

        /// <summary>
		/// Списък от предходни състояния на списъка
        /// от фигури (ShapeList), който се пази с 
        /// цел да може да се извърши undo операция
        /// за отмяна на направените промени.
		/// </summary>
        private List<List<Shape>> previousStates = new List<List<Shape>>();
        public List<List<Shape>> PreviousStates
        {
            get { return previousStates; }
        }

        /// <summary>
		/// Типът цвят, с който е избрано да се работи.
		/// </summary>
        private string selectedColorGroup = "fillColor";
        public string SelectedColorGroup
        {
            get { return selectedColorGroup; }
            set { selectedColorGroup = value; }
        }

        /// <summary>
		/// Пази фигурите, които са били копирани или 
        /// изрязани най-скоро.
		/// </summary>
        private List<Shape> clipboard = new List<Shape>();
        public List<Shape> Clipboard
        {
            get { return clipboard; }
            set { clipboard = value; }
        }

        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>
        private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
		
		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}

        /// <summary>
        /// Началната точка на влачещата селекция.
        /// </summary>
        public PointF draggingSelectionStart = new PointF(0, 0);
        public PointF DraggingSelectionStart
        {
            get { return draggingSelectionStart; }
            set { draggingSelectionStart = value; }
        }

        /// <summary>
		/// Крайната точка на влачещата селекция.
		/// </summary>
        public PointF draggingSelectionEnd = new PointF(0, 0);
        public PointF DraggingSelectionEnd
        {
            get { return draggingSelectionEnd; }
            set { draggingSelectionEnd = value; }
        }

        #endregion

        /// <summary>
        /// Добавя примитив - правоъгълник на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;

			ShapeList.Add(rect);
		}

        /// <summary>
        /// Добавя примитив - елипса на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomEllipse()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 200));
            ellipse.FillColor = Color.White;

            ShapeList.Add(ellipse);
        }

        /// <summary>
        /// Добавя примитив - крива на безие на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomBezier()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            BezierShape bezier = new BezierShape(new Rectangle(x, y, 100, 200));
            bezier.FillColor = Color.White;

            ShapeList.Add(bezier);
        }

        /// <summary>
        /// Добавя примитив - хоризонтална линия на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomHorizontalLine()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            HorizontalLineShape line = new HorizontalLineShape(new Rectangle(x, y, 100, 200));
            line.FillColor = Color.White;

            ShapeList.Add(line);
        }

        /// <summary>
        /// Добавя примитив - вертикална линия на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomVerticalLine()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            VerticalLineShape line = new VerticalLineShape(new Rectangle(x, y, 100, 200));
            line.FillColor = Color.White;

            ShapeList.Add(line);
        }

        /// <summary>
        /// Добавя примитив - триъгълник на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomTriangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            TriangleShape triangle = new TriangleShape(new Rectangle(x, y, 200, 200));
            triangle.FillColor = Color.White;

            ShapeList.Add(triangle);
        }

        /// <summary>
        /// Добавя примитив - звезда на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomStar()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            StarShape star = new StarShape(new Rectangle(x, y, 200, 185));
            star.FillColor = Color.White;

            ShapeList.Add(star);
        }

        /// <summary>
        /// Добавя примитив - петоъгълнк на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomPentagon()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            PentagonShape pentagon = new PentagonShape(new Rectangle(x, y, 200, 200));
            pentagon.FillColor = Color.White;

            ShapeList.Add(pentagon);
        }

        /// <summary>
        /// Добавя примитив - кръг на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomCircle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape circle = new EllipseShape(new Rectangle(x, y, 200, 200));
            circle.FillColor = Color.White;

            ShapeList.Add(circle);
        }

        /// <summary>
        /// Добавя примитив - точка на произволно място върху клиентската област.
        /// </summary>
        public void AddRandomDot()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            EllipseShape dot = new EllipseShape(new Rectangle(x, y, 5, 5));
            dot.FillColor = Color.Black;

            ShapeList.Add(dot);
        }

        /// <summary>
        /// Изрисува пунктирания правоъгълник, който обозначава областта
        /// на действие на влачещата селекция
        /// </summary>
        public void DrawDraggingSelection(Graphics grfx)
        {
            float[] dashValues = { 5, 2 };
            Pen dashPen = new Pen(Color.Red, 2);
            dashPen.DashPattern = dashValues;
            int width = (int)(draggingSelectionEnd.X - draggingSelectionStart.X);
            int height = (int)(draggingSelectionEnd.Y - draggingSelectionStart.Y);
            grfx.DrawRectangle(dashPen, draggingSelectionStart.X, draggingSelectionStart.Y, width, height);
        }

        /// <summary>
        /// Създава правоъгълник между началната и крайната точка на
        /// влачещата селекция и проверява кои примитиви се намират в 
        /// него.
        /// </summary>
        public void DraggingSelection()
        {
            int width = (int)(draggingSelectionEnd.X - draggingSelectionStart.X);
            int height = (int)(draggingSelectionEnd.Y - draggingSelectionStart.Y);
            RectangleF draggingSelection = new RectangleF(draggingSelectionStart.X, draggingSelectionStart.Y, width, height);

            foreach (Shape shape in ShapeList)
            {
                if (Selection.Contains(shape) == false && draggingSelection.Contains(shape.Location))
                {
                    shape.IsSelected = true;
                    Selection.Add(shape);
                }
            }

            draggingSelectionStart = new PointF();
            draggingSelectionEnd = new PointF();
        }

        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
                    ShapeList[i].IsSelected = true;
                    
                    return ShapeList[i];
				}
			}
			return null;
		}

        /// <summary>
        /// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
        /// </summary>
        /// <param name="p">Вектор на транслация.</param>
        public void TranslateTo(PointF p)
        {
            if (selection.Count > 0)
            {
                foreach (Shape shape in selection)
                {
                    shape.Location = new PointF(shape.Location.X + p.X - lastLocation.X, shape.Location.Y + p.Y - lastLocation.Y);
                }
                lastLocation = p;
            }
        }

        /// <summary>
        /// Групиране на селектирани фигури. Извършва се чрез 
        /// заменяне на избраните примитиви с групов който,
        /// е съставен от тях и изчислява правоъгълника
        /// който обхваща групата.
        /// </summary>
        public void GroupSelected()
        {
            if (Selection.Count < 1) return;

            float minX = float.PositiveInfinity;
            float minY = float.PositiveInfinity;
            float maxX = float.NegativeInfinity;
            float maxY = float.NegativeInfinity;

            foreach (Shape shape in Selection)
            {
                if (shape.Rectangle.X < minX) minX = shape.Rectangle.X;
                if (shape.Rectangle.Y < minY) minY = shape.Rectangle.Y;//

                float xWidth = shape.Rectangle.X + shape.Rectangle.Width;
                float yHeight = shape.Rectangle.Y + shape.Rectangle.Height;
                if (xWidth > maxX) maxX = xWidth;
                if (yHeight > maxY) maxY = yHeight;
            }

            GroupShape groupShape = new GroupShape(new RectangleF(minX, minY, (maxX - minX), (maxY - minY)));
            
            foreach (Shape shape in ShapeList.Where(x => Selection.Contains(x)))
            {
                shape.IsSelected = false;
                shape.RotationDiff = shape.Rotation - groupShape.Rotation;//
                shape.IsSubshape = true;
                groupShape.Subshapes.Add(shape);
            }

            foreach (Shape shape in Selection)
            {
                ShapeList.Remove(shape);
            }
            Selection.Clear();

            ShapeList.Add(groupShape);
        }

        /// <summary>
        /// Разгрупиране на групов примитив. Извършва се 
        /// като групата се замени с подфигурите си.
       
        /// </summary>
        public static List<Shape> UngroupShape(Shape shape)
        {
            if (shape is GroupShape)
            {
                //return ((GroupShape)shape).Subshapes;
                List<Shape> shapes = new List<Shape>();
                foreach(Shape subShape in ((GroupShape)shape).Subshapes)
                {
                    subShape.IsSubshape = false;
                    shapes.Add(subShape);
                }
                return shapes;
            }
            return null;
        }

        /// <summary>
        /// Разгрупира всички селектирани фигури, които са групи
        /// </summary>
        public void UngroupSelected()
        { 
            foreach(Shape shape in Selection)
            {
                List<Shape> subshapes = UngroupShape(shape);
                if (subshapes != null)
                {
                    ShapeList.Remove(shape);
                    foreach(Shape subshape in subshapes)
                    {
                        ShapeList.Add(subshape);
                    }
                }
            }

            Selection.Clear();
        }

        /// <summary>
        /// Пълно разгрупиране на групов примитив.
        /// Разгрупирането се повтаря за всяка подфигура, която
        /// също е група, докато не бъдат разгрупирани всички
        /// групи в йерархията.
        /// </summary>
        public void FullUngroupSelected()
        {
            for(int i = 0; ; i++)
            {
                if (i >= selection.Count) break;
                List<Shape> subshapes = UngroupShape(Selection[i]);
                if (subshapes != null)
                {
                    ShapeList.Remove(Selection[i]);
                    foreach (Shape subshape in subshapes)
                    {
                        if (subshape is GroupShape)
                        {
                            Selection.Add(subshape);
                        }
                        else
                        {
                            ShapeList.Add(subshape);
                        }
                    }
                }
            }

            Selection.Clear();
        }

        /// <summary>
        /// Преместване на примитив в ShapeList с цел
        /// да бъде визуализиран един слой нагоре.
        /// </summary>
        public void LayerMoveUp()
        {
            for (int i = ShapeList.Count - 2; i >= 0; i--)
            {
                if (Selection.Contains(ShapeList[i]))
                {
                    Shape temp = ShapeList[i];
                    ShapeList[i] = ShapeList[i + 1];
                    ShapeList[i + 1] = temp;
                }
            }
        }

        /// <summary>
        /// Преместване на примитив в ShapeList с цел
        /// да бъде визуализиран един слой надолу.
        /// </summary>
        public void LayerMoveDown()
        {
            for (int i = 1; i < ShapeList.Count ; i++)
            {
                if (Selection.Contains(ShapeList[i]))
                {
                    Shape temp = ShapeList[i];
                    ShapeList[i] = ShapeList[i - 1];
                    ShapeList[i - 1] = temp;
                }
            }
        }

        /// <summary>
        /// Сериализира списък от примитиви в бинарен формат
        /// и го записва като файл в избрана директория.
        /// </summary>
        public void ExportBinary(List<Shape> Shapes)
        {
            byte[] binaryData;

            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(ms, Shapes);
                binaryData = ms.ToArray();
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary Files (*.bin)|*.bin|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                File.WriteAllBytes(filePath, binaryData);
                MessageBox.Show("Model saved successfully.");
            }
            
        }

        /// <summary>
        /// Чете бинарен файл и го десериализира до списък
        /// от графични примитиви, след което зарежда
        /// ShapeList с импортираните фигури.
        /// </summary>
        public void ImportBinary()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary Files (*.bin)|*.bin|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                byte[] binaryData = File.ReadAllBytes(filePath);

                List<Shape> deserializedList;
                using (MemoryStream ms = new MemoryStream(binaryData))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    deserializedList = (List<Shape>)binaryFormatter.Deserialize(ms);
                }

                ShapeList.Clear();
                Selection.Clear();
                Clipboard.Clear();

                deserializedList.ForEach(x => x.IsSelected = false);
                ShapeList = deserializedList;

               MessageBox.Show("Model imported successfully.");
            }
        }

        /// <summary>
        /// Завърта всички селектирани фигури (и техните 
        /// подфигури) под даден ъгъл.
        /// </summary>
        public void Rotate(float angle)
        {
            List<Shape> ShapesToRotate = new List<Shape>();
            foreach (Shape shape in Selection)
            {
                ShapesToRotate.Add(shape);
            }

            for (int i = 0; ; i++)
            {
                if (i >= ShapesToRotate.Count) break;

                if (ShapesToRotate[i].Rotation + angle > 360) ShapesToRotate[i].Rotation = ShapesToRotate[i].Rotation + angle - 360;
                else if (ShapesToRotate[i].Rotation + angle < 360) ShapesToRotate[i].Rotation = ShapesToRotate[i].Rotation + angle + 360;
                else ShapesToRotate[i].Rotation += angle;

                if (ShapesToRotate[i] is GroupShape)
                {
                    foreach (Shape subShape in ((GroupShape)ShapesToRotate[i]).Subshapes)
                    {
                        ShapesToRotate.Add(subShape);
                    }
                }
            }
        }

        /// <summary>
        /// Проверява дали декущото състояние на ShapeList
        /// се различава от последното записано в Clipboard
        /// </summary>
        public bool IsShapeListChanged()
        {
            
            if (previousStates.Count == 0 && ShapeList.Count > 0) return true;
            else if (previousStates.Count == 0) return false;

            List<Shape> latestState = previousStates[previousStates.Count - 1];

            if (latestState.Count != ShapeList.Count) return true;

            for (int i = 0; i < ShapeList.Count; i++)
            {
                if (/*latestState[i].Name != ShapeList[i].Name ||*/ 
                    latestState[i].Location.X != ShapeList[i].Location.X ||
                    latestState[i].Location.Y != ShapeList[i].Location.Y ||
                    latestState[i].Height != ShapeList[i].Height ||
                    latestState[i].Width != ShapeList[i].Width ||
                    latestState[i].FillColor != ShapeList[i].FillColor ||
                    latestState[i].BorderColor != ShapeList[i].BorderColor ||
                    latestState[i].SecondaryColor != ShapeList[i].SecondaryColor ||
                    latestState[i].SecondaryBorderColor != ShapeList[i].SecondaryBorderColor ||
                    latestState[i].FillColorOpacity != ShapeList[i].FillColorOpacity ||
                    latestState[i].BorderColorOpacity != ShapeList[i].BorderColorOpacity ||
                    latestState[i].BorderRadius != ShapeList[i].BorderRadius ||
                    latestState[i].BrushType != ShapeList[i].BrushType ||
                    latestState[i].Rotation != ShapeList[i].Rotation
                    ) return true;
            }

            return false;
        }

        /// <summary>
        /// Добавя текущото състояние на ShapeList към
        /// Clipboard и ако броя на запазените състояния
        /// надвиши лимита, премахва най-старото записано.
        /// </summary>
        public void SaveState()
        {
            if (previousStates.Count == 10) previousStates.RemoveAt(0);
            List<Shape> newState = new List<Shape>();

            foreach (Shape shape in ShapeList)
            {
                newState.Add(shape.CopySelf());
            }

            previousStates.Add(newState);
        }

        /// <summary>
        /// Отменя последните промени като заменя текущото 
        /// състояние на ShapeList с последно добавеното в 
        /// Clipboard.
        /// </summary>
        public void Undo()
        {
            if (previousStates.Count == 0) return;

            ShapeList.Clear();

            foreach (Shape shape in previousStates[previousStates.Count - 1])
            {
                ShapeList.Add(shape.CopySelf());
            }

            previousStates.RemoveAt(previousStates.Count - 1);
        }
        
    }
}
