using Draw.Properties;
using Draw.src.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();

        private bool rotationSliderActive = true;
        private bool radiusDropDownActive = true;

        public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
            if (dialogProcessor.DraggingSelectionStart.X != 0 && dragSelectionButton.Checked)
            {
                Graphics grfx = e.Graphics;
                dialogProcessor.DrawDraggingSelection(grfx);
            }


            dialogProcessor.ReDraw(sender, e);
		}
		
		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
            dialogProcessor.SaveState();

			dialogProcessor.AddRandomRectangle();
			
			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
			
			viewPort.Invalidate();
		}

		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{

            if (pickUpSpeedButton.Checked)
            {
                Shape temp = dialogProcessor.ContainsPoint(e.Location);
                if (temp != null)
                {
                    if (dialogProcessor.Selection.Contains(temp) == false)
                    {
                        dialogProcessor.Selection.Add(temp);
                    }
                    else
                    {
                        dialogProcessor.Selection.Remove(temp);
                        temp.IsSelected = false;
                    }

                    if (dialogProcessor.Selection.Count > 0)
                    {
                        statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                        dialogProcessor.IsDragging = true;
                        dialogProcessor.LastLocation = e.Location;

                        SyncUI();

                    }
                }
                
                viewPort.Invalidate();

            }
            // При избиране на Drag Selection опцията и при
            // кликване с мишката се стартира влачеща селекция
            // с начални координати тези на текущия клик и финални
            // тези на следващия клик.
            else if (dragSelectionButton.Checked)
            {
                if (dialogProcessor.draggingSelectionStart.X == 0)
                {
                    dialogProcessor.draggingSelectionStart = new PointF(e.Location.X, e.Location.Y);
                }
                else
                {
                    dialogProcessor.DraggingSelection();
                }
                
            }
        }

        /// <summary>
        /// Попълване на свойствата на избрания примитив в
        /// UI компонентите с цел представяне на тази информация
        /// пред потребителя.
        /// </summary>
        void SyncUI()
        {
            if (dialogProcessor.Selection.Count == 1)
            {
                if (dialogProcessor.SelectedColorGroup == "fillColor")
                {
                    colorTypeComboBox.Enabled = true;
                    colorTypeComboBox.Text = dialogProcessor.Selection[0].BrushType;
                    int fillOpacity = (int)Math.Ceiling(((double)dialogProcessor.Selection[0].FillColorOpacity / 255 * 100));
                    if (slider1.Value != fillOpacity) slider1.Value = fillOpacity;
                    selectPrimaryColorButton.BackColor = dialogProcessor.Selection[0].FillColor;
                    selectSecondaryColorButton.BackColor = dialogProcessor.Selection[0].SecondaryColor;
                }
                else if (dialogProcessor.SelectedColorGroup == "borderColor")
                {
                    colorTypeComboBox.Enabled = false;
                    int borderOpacity = (int)Math.Ceiling(((double)dialogProcessor.Selection[0].BorderColorOpacity / 255 * 100));
                    if (slider1.Value != borderOpacity) slider1.Value = borderOpacity;

                    selectPrimaryColorButton.BackColor = dialogProcessor.Selection[0].BorderColor;
                    selectSecondaryColorButton.BackColor = dialogProcessor.Selection[0].SecondaryBorderColor;
                }

                radiusDropDownActive = false;
                borderRadiusComboBox.Text = $"{dialogProcessor.Selection[0].BorderRadius} px";
                radiusDropDownActive = true;

                int rotation = (int)dialogProcessor.Selection[0].Rotation;
                if (rotation >= -360 && rotation <= 360)
                {
                    rotationSliderActive = false;
                    slider2.Value = rotation;
                    rotationSliderActive = true;
                }
            }
            
        }

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            cursorLocationLabel.Text = $"X: {e.Location.X}, Y: {e.Location.Y}";

			if (dialogProcessor.IsDragging) {
				if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
                dialogProcessor.TranslateTo(e.Location);
				viewPort.Invalidate();
			}

            if (dragSelectionButton.Checked)
            {
                dialogProcessor.draggingSelectionEnd = new PointF(e.Location.X, e.Location.Y);
                viewPort.Invalidate();
            }
        }

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;

            if (dialogProcessor.IsShapeListChanged()) dialogProcessor.SaveState();
		}

        /// <summary>
        /// Бутон за изрисуване на елипса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawEllipseButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.AddRandomEllipse();

            statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за изрисуване на крива на безие
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawBezierButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.AddRandomBezier();

            statusBar.Items[0].Text = "Последно действие: Рисуване на Крива на Безие";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за изрисуване на хоризонтална линия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawHorizontalLineButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.AddRandomHorizontalLine();

            statusBar.Items[0].Text = "Последно действие: Рисуване на хоризонтална линия";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за изрисуване на вертикална линия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawVerticalLineButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.AddRandomVerticalLine();

            statusBar.Items[0].Text = "Последно действие: Рисуване на вертикална линия";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за изрисуване на триъгълник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawTriangleButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.AddRandomTriangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за изрисуване на звезда
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawStarButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.AddRandomStar();

            statusBar.Items[0].Text = "Последно действие: Рисуване на звезда";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за изрисуване на петоъгълник
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawPentagonButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.AddRandomPentagon();

            statusBar.Items[0].Text = "Последно действие: Рисуване на пентагон";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за изрисуване на кръг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawCircleButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.AddRandomCircle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на кръг";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за изрисуване на точка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawDotButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.AddRandomDot();

            statusBar.Items[0].Text = "Последно действие: Рисуване на точка";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за избиране на основен цвят на запълване или на границата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectPrimaryColorButton_Click(object sender, EventArgs e)
        {
            

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dialogProcessor.SaveState();

                foreach (Shape shape in dialogProcessor.Selection)
                {
                    Color pickedColor = colorDialog1.Color;
                    selectPrimaryColorButton.BackColor = pickedColor;
                    if (dialogProcessor.SelectedColorGroup == "fillColor")
                    {
                        // group shape
                        //if (shape.IsGroup)
                        //{
                        //    foreach (Shape subShape in ((GroupShape)shape).Subshapes)
                        //    {
                        //        subShape.FillColor = pickedColor;
                        //    }
                        //}
                        //
                        shape.FillColor = pickedColor;
                    }
                    else if (dialogProcessor.SelectedColorGroup == "borderColor")
                    {
                        // group shape
                        //if (shape.IsGroup)
                        //{
                        //    foreach (Shape subShape in ((GroupShape)shape).Subshapes)
                        //    {
                        //        subShape.BorderColor = pickedColor;
                        //    }
                        //}
                        //
                        shape.BorderColor = pickedColor;
                    }
                }
                statusBar.Items[0].Text = "Последно действие: Избиране основен на цвят";
                viewPort.Invalidate();
            }
        }

        /// <summary>
        /// Бутон за избиране на вторичен цвят на запълване или на границата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectSecondaryColorButton_Click(object sender, EventArgs e)
        {
            

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dialogProcessor.SaveState();

                foreach (Shape shape in dialogProcessor.Selection)
                {
                    Color pickedColor = colorDialog1.Color;
                    selectSecondaryColorButton.BackColor = pickedColor;

                    if (dialogProcessor.SelectedColorGroup == "fillColor")
                    {
                        // group shape
                        //if (shape.IsGroup)
                        //{
                        //    foreach (Shape subShape in ((GroupShape)shape).Subshapes)
                        //    {
                        //        subShape.SecondaryColor = pickedColor;
                        //    }
                        //}
                        //
                        shape.SecondaryColor = pickedColor;
                    }
                    else if (dialogProcessor.SelectedColorGroup == "borderColor")
                    {
                        // group shape
                        //if (shape.IsGroup)
                        //{
                        //    foreach (Shape subShape in ((GroupShape)shape).Subshapes)
                        //    {
                        //        subShape.SecondaryBorderColor = pickedColor;
                        //    }
                        //}
                        //
                        shape.SecondaryBorderColor = pickedColor;
                    }
                }
                statusBar.Items[0].Text = "Последно действие: Избиране на вторичен цвят";
                viewPort.Invalidate();
            }
        }

        /// <summary>
        /// Combo Box за задаване на радиус на границата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borderRadiusComboBox_TextChanged(object sender, EventArgs e)
        {
            if (radiusDropDownActive == false) return;
            dialogProcessor.SaveState();

            foreach (Shape shape in dialogProcessor.Selection)
            {
                float pickedBorderRadius = float.Parse(borderRadiusComboBox.Text.Split()[0]);
                // group shape
                //if (shape.IsGroup)
                //{
                //    foreach (Shape subShape in ((GroupShape)shape).Subshapes)
                //    {
                //        subShape.BorderRadius = pickedBorderRadius;
                //    }
                //}
                //
                shape.BorderRadius = pickedBorderRadius;
            }
            statusBar.Items[0].Text = "Последно действие: Избиране на радиус";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Combo Box за избиране на тип на четката.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            foreach (Shape shape in dialogProcessor.Selection)
            {
                string pickedBrushType = colorTypeComboBox.Text;
                // group shape
                //if (shape.IsGroup)
                //{
                //    foreach (Shape subShape in ((GroupShape)shape).Subshapes)
                //    {
                //        subShape.BrushType = pickedBrushType;
                //    }
                //}
                //
                //string pickedBrushType = colorTypeComboBox.Text;
                shape.BrushType = pickedBrushType;
            }
            statusBar.Items[0].Text = "Последно действие: Избиране на типа на четката";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Плъзгач за задаване на плътност на цвета на четката.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void slider1_ValueChanged(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            slider1Label.Text = slider1.Value.ToString() + "%";

            foreach (Shape shape in dialogProcessor.Selection)
            {
                var newValue = (int)((float)slider1.Value / 100 * 255);
                if (dialogProcessor.SelectedColorGroup == "fillColor")
                {
                    // group shape
                    //if (shape.IsGroup)
                    //{
                    //    foreach (Shape subShape in ((GroupShape)shape).Subshapes)
                    //    {
                    //        subShape.FillColorOpacity = newValue;
                    //    }
                    //}
                    //
                    shape.FillColorOpacity = newValue;
                }
                else if (dialogProcessor.SelectedColorGroup == "borderColor")
                {
                    // group shape
                    //if (shape.IsGroup)
                    //{
                    //    foreach (Shape subShape in ((GroupShape)shape).Subshapes)
                    //    {
                    //        subShape.BorderColorOpacity = newValue;
                    //    }
                    //}
                    //
                    shape.BorderColorOpacity = newValue;
                }
            }
            statusBar.Items[0].Text = "Последно действие: Избиране на плътност на цвета";
            viewPort.Invalidate();
        }

        private void viewPort_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Радио бутон за избиране на цвета на запълване като този, с който да работи интерфейса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fillColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dialogProcessor.SelectedColorGroup = "fillColor";
            SyncUI();
        }

        /// <summary>
        /// Радио бутон за избиране на цвета на границата като този, с който да работи интерфейса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borderColorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dialogProcessor.SelectedColorGroup = "borderColor";
            SyncUI();
        }

        /// <summary>
        /// Плъзгач за променяне на ъгъла на завъртане на избраните фигури.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void slider2_ValueChanged(object sender, EventArgs e)
        {
            if (rotationSliderActive == false) return;//

            dialogProcessor.SaveState();

            slider2Label.Text = slider2.Value.ToString() + "°";

            
            foreach (Shape shape in dialogProcessor.Selection)
            {
                int rotationSliderDiff = slider2.Value - (int)shape.OldRotation;
                shape.Rotation = shape.OldRotation + rotationSliderDiff;
                shape.OldRotation = shape.Rotation;
            }

            statusBar.Items[0].Text = "Последно действие: Завъртане";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за премахване на избраните фигури от модела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            foreach (Shape shape in dialogProcessor.Selection)
            {
                dialogProcessor.ShapeList.Remove(shape);
                statusBar.Items[0].Text = "Последно действие: Изтриване на фигура";
            }
            dialogProcessor.Selection.Clear();
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за увеличаване на ширината на избраните фигури.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void increaseWidthButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            List<Shape> Shapes = new List<Shape>();
            foreach (Shape shape in dialogProcessor.Selection)
            {
                Shapes.Add(shape);
            }

            for (int i = 0; ; i++)
            {
                if (i >= Shapes.Count) break;
                Shapes[i].Width += 5;
                if(Shapes[i] is GroupShape)
                {
                    foreach (Shape subShape in ((GroupShape)Shapes[i]).Subshapes)
                    {
                        Shapes.Add(subShape);
                    }
                }
            }

            statusBar.Items[0].Text = "Последно действие: Увеличаване на широчината";
            viewPort.Invalidate();

        }

        /// <summary>
        /// Бутон за намаляване на ширината на избраните фигури.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void decreaseWidthButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            List<Shape> Shapes = new List<Shape>();
            foreach (Shape shape in dialogProcessor.Selection)
            {
                Shapes.Add(shape);
            }

            for (int i = 0; ; i++)
            {
                if (i >= Shapes.Count) break;
                Shapes[i].Width -= 5;
                if (Shapes[i] is GroupShape)
                {
                    foreach (Shape subShape in ((GroupShape)Shapes[i]).Subshapes)
                    {
                        Shapes.Add(subShape);
                    }
                }
            }

            statusBar.Items[0].Text = "Последно действие: Намаляване на широчината";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за увеличаване на височината на избраните фигури.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void increaseHeightButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            List<Shape> Shapes = new List<Shape>();
            foreach (Shape shape in dialogProcessor.Selection)
            {
                Shapes.Add(shape);
            }

            for (int i = 0; ; i++)
            {
                if (i >= Shapes.Count) break;
                Shapes[i].Height += 5;
                if (Shapes[i] is GroupShape)
                {
                    foreach (Shape subShape in ((GroupShape)Shapes[i]).Subshapes)
                    {
                        Shapes.Add(subShape);
                    }
                }
            }

            statusBar.Items[0].Text = "Последно действие: Увеличаване на височината";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за намаляне на височината на избраните фигури.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void decreaseHeightButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            List<Shape> Shapes = new List<Shape>();
            foreach (Shape shape in dialogProcessor.Selection)
            {
                Shapes.Add(shape);
            }

            for (int i = 0; ; i++)
            {
                if (i >= Shapes.Count) break;
                Shapes[i].Height -= 5;
                if (Shapes[i] is GroupShape)
                {
                    foreach (Shape subShape in ((GroupShape)Shapes[i]).Subshapes)
                    {
                        Shapes.Add(subShape);
                    }
                }
            }

            statusBar.Items[0].Text = "Последно действие: Намаляване на височината";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за групиране на избраните фигури.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void groupButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.GroupSelected();

            statusBar.Items[0].Text = "Последно действие: Групиране";

            viewPort.Invalidate();
        }

        /// <summary>
        /// Клавишни комбинации за работа с модела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift)
            {
                // Клавишни комбинации за рисуване на графични примитиви ( Ctrl + R/E/C/T/P/S/D/H/V/B ).
                switch (e.KeyCode)
                {
                    case Keys.R:
                        dialogProcessor.SaveState();

                        dialogProcessor.AddRandomRectangle();
                        statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
                        break;
                    case Keys.E:
                        dialogProcessor.SaveState();

                        dialogProcessor.AddRandomEllipse();
                        statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";
                        break;
                    case Keys.C:
                        dialogProcessor.SaveState();

                        dialogProcessor.AddRandomCircle();
                        statusBar.Items[0].Text = "Последно действие: Рисуване на кръг";
                        break;
                    case Keys.T:
                        dialogProcessor.SaveState();

                        dialogProcessor.AddRandomTriangle();
                        statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";
                        break;
                    case Keys.P:
                        dialogProcessor.SaveState();

                        dialogProcessor.AddRandomPentagon();
                        statusBar.Items[0].Text = "Последно действие: Рисуване на пентагон";
                        break;
                    case Keys.S:
                        dialogProcessor.SaveState();

                        dialogProcessor.AddRandomStar();
                        statusBar.Items[0].Text = "Последно действие: Рисуване на звезда";
                        break;
                    case Keys.D:
                        dialogProcessor.SaveState();

                        dialogProcessor.AddRandomDot();
                        statusBar.Items[0].Text = "Последно действие: Рисуване на точка";
                        break;
                    case Keys.H:
                        dialogProcessor.SaveState();

                        dialogProcessor.AddRandomHorizontalLine();
                        statusBar.Items[0].Text = "Последно действие: Рисуване на хоризонтална линия";
                        break;
                    case Keys.V:
                        dialogProcessor.SaveState();

                        dialogProcessor.AddRandomVerticalLine();
                        statusBar.Items[0].Text = "Последно действие: Рисуване на вертикална линия";
                        break;
                    case Keys.B:
                        dialogProcessor.SaveState();

                        dialogProcessor.AddRandomBezier();
                        statusBar.Items[0].Text = "Последно действие: Рисуване на линия на безие";
                        break;
                }
                viewPort.Invalidate();

            }
            // Клавишна комбинация за изтриване на избраните фигури ( Ctrl+D / Delete ).
            else if((e.Control && e.KeyCode == Keys.D) || e.KeyCode == Keys.Delete)
            {
                dialogProcessor.SaveState();

                foreach (Shape shape in dialogProcessor.Selection)
                {
                    dialogProcessor.ShapeList.Remove(shape);
                    statusBar.Items[0].Text = "Последно действие: Изтриване на фигура";
                }
                dialogProcessor.Selection.Clear();
                viewPort.Invalidate();
            }
            // Клавишна комбинация за отменяне на последната промяна (Ctrl + U)
            else if (e.Control && e.KeyCode == Keys.U)
            {
                dialogProcessor.Undo();

                statusBar.Items[0].Text = "Последно действие: Отмяна";

                viewPort.Invalidate();
            }
            // Клавишна комбинация за групиране на избраните фигури ( Ctrl + G )
            else if (e.Control && e.KeyCode == Keys.G)
            {
                dialogProcessor.SaveState();

                dialogProcessor.GroupSelected();

                statusBar.Items[0].Text = "Последно действие: Групиране";

                viewPort.Invalidate();
            }
            // Клавишна комбинация за копиране на избраните фигури ( Ctrl + C )
            else if (e.Control && e.KeyCode == Keys.C)
            {
                if (dialogProcessor.Selection.Count > 0)
                {
                    dialogProcessor.Clipboard.Clear();
                    foreach (var item in dialogProcessor.Selection)
                    {
                        dialogProcessor.Clipboard.Add(item.CopySelf());
                    }

                    statusBar.Items[0].Text = "Последно действие: Копиране";
                }
            }
            // Клавишна комбинация за изрязване на избраните фигури ( Ctrl + X )
            else if (e.Control && e.KeyCode == Keys.X)
            {
                if (dialogProcessor.Selection.Count > 0)
                {
                    dialogProcessor.SaveState();

                    dialogProcessor.Clipboard.Clear();
                    foreach (var item in dialogProcessor.Selection)
                    {
                        dialogProcessor.Clipboard.Add(item.CopySelf());
                        dialogProcessor.ShapeList.Remove(item);
                    }
                    dialogProcessor.Selection.Clear();

                }
                statusBar.Items[0].Text = "Последно действие: Изрязване";
                viewPort.Invalidate();
            }
            // Клавишна комбинация за поставяне на фигурите, намиращи се в Clipboard ( Ctrl + V )
            else if (e.Control && e.KeyCode == Keys.V)
            {
                if (dialogProcessor.Clipboard.Count > 0)
                {
                    dialogProcessor.SaveState();

                    foreach (var item in dialogProcessor.Clipboard)
                    {
                        dialogProcessor.ShapeList.Add(item.CopySelf());
                    }
                }
                statusBar.Items[0].Text = "Последно действие: Поставяне";
                viewPort.Invalidate();
            }
            // Клавишна комбинация за селектиране на всички фигури на модела ( Ctrl + A)
            else if (e.Control && e.KeyCode == Keys.A)
            {
                foreach(var item in dialogProcessor.Selection)
                {
                    item.IsSelected = false;
                }
                dialogProcessor.Selection.Clear();
                foreach (var item in dialogProcessor.ShapeList)
                {
                    item.IsSelected = true;
                    dialogProcessor.Selection.Add(item);
                }
                statusBar.Items[0].Text = "Последно действие: Избиране на всички";
                viewPort.Invalidate();
            }
        }

        /// <summary>
        /// Бутон за копиране на избраните графични примитиви.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyButton_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.Selection.Count > 0)
            {
                dialogProcessor.Clipboard.Clear();
                //dialogProcessor.Clipboard = dialogProcessor.Selection;
                foreach (var item in dialogProcessor.Selection)
                {
                    dialogProcessor.Clipboard.Add(item.CopySelf());
                    //dialogProcessor.Clipboard.Add(item);
                }
                statusBar.Items[0].Text = "Последно действие: Копиране";
            }
        }

        /// <summary>
        /// Бутон за поставяне на фигурите, намиращи се в Clipboard,
        /// чрез прехвърлянето им в ShapeList.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pasteButton_Click(object sender, EventArgs e)
        {
            if (dialogProcessor.Clipboard.Count > 0)
            {
                foreach (var item in dialogProcessor.Clipboard)
                {
                    //dialogProcessor.ShapeList.Add(item);
                    dialogProcessor.ShapeList.Add(item.CopySelf());
                }
            }
            statusBar.Items[0].Text = "Последно действие: Поставяне";
            viewPort.Invalidate();
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Дефиниране на контекстно меню с два случая:
        /// 1. Когато има избрани фигути се появяват опции за манипулирането им.
        /// 2. Когато няма избрани фигури се появяват опции за добавяне / поставяне на фигури.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            contextMenuStrip1.Items.Clear();
            if (dialogProcessor.Selection.Count > 0)
            {
                contextMenuStrip1.Items.Add("Copy", Resources.copy, copyButton_Click);
                contextMenuStrip1.Items.Add("Cut", Resources.cut, cutButton_Click);
                contextMenuStrip1.Items.Add("Paste", Resources.paste, pasteButton_Click);
                contextMenuStrip1.Items.Add("Delete", null, deleteButton_Click);
                contextMenuStrip1.Items.Add("Group", Resources.link, groupButton_Click);
                contextMenuStrip1.Items.Add("Ungroup", Resources.link, ungroupButton_Click);
                contextMenuStrip1.Items.Add("Full Ungroup", Resources.link, toolStripButton1_Click);
                contextMenuStrip1.Items.Add("Rotate Left", Resources.rotate, rotateLeftButton_Click);
                contextMenuStrip1.Items.Add("Rotate Right", Resources.rotate, rotateRightButton_Click);
                contextMenuStrip1.Items.Add("Rotate 180", Resources.rotate, rotate180Button_Click);
            }
            else
            {
                contextMenuStrip1.Items.Add("Paste", Resources.paste, pasteButton_Click);
                contextMenuStrip1.Items.Add("Add Rectangle", null, DrawRectangleSpeedButtonClick);
                contextMenuStrip1.Items.Add("Add Ellipse", null, drawEllipseButton_Click);
                contextMenuStrip1.Items.Add("Add Circle", null, drawCircleButton_Click);
                contextMenuStrip1.Items.Add("Add Pentagon", null, drawPentagonButton_Click);
                contextMenuStrip1.Items.Add("Add Star", null, drawStarButton_Click);
                contextMenuStrip1.Items.Add("Add Dot", null, drawDotButton_Click);
                contextMenuStrip1.Items.Add("Add Horizontal Line", null, drawHorizontalLineButton_Click);
                contextMenuStrip1.Items.Add("Add Vertical Line", null, drawVerticalLineButton_Click);
                contextMenuStrip1.Items.Add("Add Bezier", null, drawBezierButton_Click);
            }
        }

        /// <summary>
        /// Бутон, който служи за изрязване (премахване и копиране)
        /// на избраните графични примитиви.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cutButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            if (dialogProcessor.Selection.Count > 0)
            {
                dialogProcessor.Clipboard.Clear();
                foreach (var item in dialogProcessor.Selection)
                {
                    dialogProcessor.Clipboard.Add(item.CopySelf());
                    //dialogProcessor.Clipboard.Add(item);
                    dialogProcessor.ShapeList.Remove(item);
                }
                dialogProcessor.Selection.Clear();

            }
            statusBar.Items[0].Text = "Последно действие: Изрязване";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за експортиране на всички графични примитиви на модела под формата на бинарен файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportAsBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.ExportBinary(dialogProcessor.ShapeList);
            statusBar.Items[0].Text = "Последно действие: Експортиране";
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asBinaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void asJSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void asJSONToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void fromJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Бутон за импортиране на списък от графични примитиви от избран бинарен файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.ImportBinary();
            statusBar.Items[0].Text = "Последно действие: Импортиране";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за експортиране на всички ИЗБРАНИ графични примитиви на модела под формата на бинарен файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void asJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.ExportBinary(dialogProcessor.Selection);
            statusBar.Items[0].Text = "Последно действие: Експортиране";
        }

        /// <summary>
        /// Бутон за разгрупиране на селектираните групови примитиви на подфигурите им.
        /// Ако някоя от подфигурите е група, тя не се разгрупира по-нататък.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ungroupButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.UngroupSelected();
            statusBar.Items[0].Text = "Последно действие: Разгрупиране";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за пълно разгрупиране на селектираните групови фигури, докато всички
        /// подфигури не станат прости (измежду тях да няма повече останали групи).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.FullUngroupSelected();
            statusBar.Items[0].Text = "Последно действие: Разгрупиране";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за преместване на избраните елементи на по-преден план, чрез 
        /// промяна на позицията им в ShapeList.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moveUpButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.LayerMoveUp();
            statusBar.Items[0].Text = "Последно действие: Преместване един слой нагоре";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за преместване на избраните елементи на по-заден план, чрез 
        /// промяна на позицията им в ShapeList.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moveDownButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.LayerMoveDown();
            statusBar.Items[0].Text = "Последно действие: Преместване един слой надолу";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за завъртане на избраните фигури под ъгъл от 90 градуса надясно.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.Rotate(90);
            statusBar.Items[0].Text = "Последно действие: Завъртане на 90 градуса";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за завъртане на избраните фигури под ъгъл от 90 градуса няляво.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rotateLeftButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.Rotate(-90);
            statusBar.Items[0].Text = "Последно действие: Завъртане на -90 градуса";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за завъртане на избраните фигури под ъгъл от 180 градуса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rotate180Button_Click(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.Rotate(180);
            statusBar.Items[0].Text = "Последно действие: Завъртане на 180 градуса";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за активиране на единична селекция, чрез клик на мишката 
        /// и деактивиране на влачеща селекция.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pickUpSpeedButton_Click(object sender, EventArgs e)
        {
            if (pickUpSpeedButton.Checked)
            {
                dragSelectionButton.Checked = false;
            }
        }

        /// <summary>
        /// Бутон за активиране на влачеща селекция 
        /// и деактивиране на единична селекция.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dragSelectionButton_Click(object sender, EventArgs e)
        {
            if (dragSelectionButton.Checked)
            {
                pickUpSpeedButton.Checked = false;
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Добавя подфигурите на една групова фигура като подвъзли
        /// на групата в дървото на фигурите.
        /// </summary>
        /// <param name="group"></param>
        /// <param name="node"></param>
        public void TreeAddSubShapes(GroupShape group, TreeNode node)
        {
            foreach (Shape shape in group.Subshapes)
            {
                TreeNode newNode = new TreeNode(shape.Name);
                node.Nodes.Add(newNode);
                if (shape is GroupShape)
                {
                    TreeAddSubShapes((GroupShape)shape, newNode);
                }
            }
        }

        /// <summary>
        /// 1. Обновява дървото на фигурите, като визуализира в него актуалното 
        /// състояние на модела представено като йерархия от примитиви.
        /// 2. Обновява или изчиства прозореца със свойствата на избрания графичен примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speedMenu_Click(object sender, EventArgs e)
        {
            // Визуализация на ShapeList под формата на TreeView
            shapeTree.Nodes.Clear();
            foreach (Shape shape in dialogProcessor.ShapeList)
            {
                TreeNode newNode = new TreeNode(shape.Name);
                shapeTree.Nodes.Add(newNode);
                if(shape is GroupShape)
                {
                    TreeAddSubShapes((GroupShape)shape, newNode);
                }
            }

            // При избран един графичен примитив, зарежда стойностите
            // му в прозореца със свойства на фигурата.
            if (dialogProcessor.Selection.Count == 1)
            {
                Shape selectedShape = dialogProcessor.Selection[0];
                nameTextBox.Text = selectedShape.Name;
                widthTextBox.Text = selectedShape.Width.ToString();
                heightTextBox.Text = selectedShape.Height.ToString();
                xTextBox.Text = selectedShape.Location.X.ToString();
                yTextBox.Text = selectedShape.Location.Y.ToString();
                rotationTextBox.Text = selectedShape.Rotation.ToString();
                primaryColorDropDown.Text = selectedShape.FillColor.ToString();
                secondaryColorDropDown.Text = selectedShape.SecondaryColor.ToString();
                primaryBorderColorDropDown.Text = selectedShape.BorderColor.ToString();
                secondaryBorderColorDropDown.Text = selectedShape.SecondaryBorderColor.ToString();
                if (opacityTypeDropDown.Text != "Fill" && opacityTypeDropDown.Text != "Border") opacityTypeDropDown.Text = "Fill";

                if (opacityTypeDropDown.Text == "Fill") opacityUpDown.Value = selectedShape.FillColorOpacity;
                else opacityUpDown.Value = selectedShape.BorderColorOpacity;

                borderRadiusDropDown.Text = $"{selectedShape.BorderRadius} px";
                brushTypeDropDown.Text = selectedShape.BrushType;

                tableLayoutPanel1.Enabled = true;
            }
            // Изчистване на прозореца със свойстата в случай,
            // че не е избран точно един градичен примитив.
            else
            {
                nameTextBox.Text = "";
                widthTextBox.Text = "";
                heightTextBox.Text = "";
                xTextBox.Text = "";
                yTextBox.Text = "";
                rotationTextBox.Text = "";
                primaryColorDropDown.Text = "";
                secondaryColorDropDown.Text = "";
                primaryBorderColorDropDown.Text = "";
                secondaryBorderColorDropDown.Text = "";
                opacityTypeDropDown.Text = "";
                opacityUpDown.Value = 0;
                borderRadiusDropDown.Text = "";
                brushTypeDropDown.Text = "";

                tableLayoutPanel1.Enabled = false;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// При селектиране на един възел от дървото с фигури се търси
        /// примитив със същото име и при намерен такъв той се селектира.
        /// Всички останали фигури се деселектират.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shapeTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dialogProcessor.Selection.ForEach(s => s.IsSelected = false);
            dialogProcessor.Selection.Clear();
            foreach (Shape shape in dialogProcessor.ShapeList)
            {
                if (shape.Name == shapeTree.SelectedNode.Text)
                {
                    dialogProcessor.Selection.Add(shape);
                    shape.IsSelected = true;
                    break;
                }
                
            }
            statusBar.Items[0].Text = "Последно действие: Избиране на фигура";
            viewPort.Invalidate();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Запаметява промяна в името на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (dialogProcessor.ShapeList.Select(x => x.Name).Contains(nameTextBox.Text)) return;

            dialogProcessor.SaveState();

            dialogProcessor.Selection[0].Name = nameTextBox.Text;
        }

        /// <summary>
        /// Запаметява промяна в широчината на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void widthTextBox_Leave(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.Selection[0].Width = float.Parse(widthTextBox.Text);

            viewPort.Invalidate();
        }

        /// <summary>
        /// Запаметява промяна във височината на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void heightTextBox_Leave(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.Selection[0].Height = float.Parse(heightTextBox.Text);

            viewPort.Invalidate();
        }

        /// <summary>
        /// Запаметява промяна в X координатата на позицията на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xTextBox_Leave(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.Selection[0].Location = new PointF(float.Parse(xTextBox.Text), dialogProcessor.Selection[0].Location.Y);

            viewPort.Invalidate();
        }

        /// <summary>
        /// Запаметява промяна в Y координатата на позицията на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yTextBox_Leave(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.Selection[0].Location = new PointF(dialogProcessor.Selection[0].Location.X, float.Parse(yTextBox.Text));

            viewPort.Invalidate();
        }

        /// <summary>
        /// Запаметява промяна в ъгъла на ротация на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rotationTextBox_Leave(object sender, EventArgs e)
        {
            float rotation = float.Parse(rotationTextBox.Text);
            if (rotation >= -360 && rotation <= 360)
            {
                dialogProcessor.SaveState();

                dialogProcessor.Selection[0].Rotation = rotation;
            }

            viewPort.Invalidate();

        }

        /// <summary>
        /// Запаметява промяна в основния цвят на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void primaryColorDropDown_Leave(object sender, EventArgs e)
        {
            string color = primaryColorDropDown.Text;
            if (color.Contains("]")) return;

            dialogProcessor.SaveState();

            dialogProcessor.Selection[0].FillColor = Color.FromName(color);

            viewPort.Invalidate();
        }

        /// <summary>
        /// Запаметява промяна във вторичния цвят на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void secondaryColorDropDown_Leave(object sender, EventArgs e)
        {
            string color = secondaryColorDropDown.Text;
            if (color.Contains("]")) return;

            dialogProcessor.SaveState();

            dialogProcessor.Selection[0].SecondaryColor = Color.FromName(color);

            viewPort.Invalidate();
        }

        /// <summary>
        /// Запаметява промяна в основния цвят на границата на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void primaryBorderColorDropDown_Leave(object sender, EventArgs e)
        {
            string color = primaryBorderColorDropDown.Text;
            if (color.Contains("]")) return;

            dialogProcessor.SaveState();

            dialogProcessor.Selection[0].BorderColor = Color.FromName(color);

            viewPort.Invalidate();
        }

        /// <summary>
        /// Запаметява промяна във вторичния цвят на границата на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void secondaryBorderColorDropDown_Leave(object sender, EventArgs e)
        {
            string color = secondaryBorderColorDropDown.Text;
            if (color.Contains("]")) return;

            dialogProcessor.SaveState();

            dialogProcessor.Selection[0].SecondaryBorderColor = Color.FromName(color);

            viewPort.Invalidate();
        }

        /// <summary>
        /// Запаметява промяна в наситеността на запълващия цвят или на границата на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opacityUpDown_Leave(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            if (opacityTypeDropDown.Text == "Fill")
            {
                dialogProcessor.Selection[0].FillColorOpacity = (int)opacityUpDown.Value;
            }
            else
            {
                dialogProcessor.Selection[0].BorderColorOpacity = (int)opacityUpDown.Value;
            }

            viewPort.Invalidate();
        }

        /// <summary>
        /// Запаметява промяна в избора на това с коя наситеност на избрания примитив работи програмата.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void opacityTypeDropDown_Leave(object sender, EventArgs e)
        {
            if(opacityTypeDropDown.Text == "Fill")
            {
                opacityUpDown.Value = dialogProcessor.Selection[0].FillColorOpacity;
            }
            else if (opacityTypeDropDown.Text == "Border")
            {
                opacityUpDown.Value = dialogProcessor.Selection[0].BorderColorOpacity;
            }
        }

        /// <summary>
        /// Запаметява промяна в радиуса на границата на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borderRadiusDropDown_Leave(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.Selection[0].BorderRadius = float.Parse(borderRadiusDropDown.Text.Split()[0]);

            viewPort.Invalidate();
        }

        /// <summary>
        /// Запаметява промяна в типа на четката на избрания примитив.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void brushTypeDropDown_Leave(object sender, EventArgs e)
        {
            dialogProcessor.SaveState();

            dialogProcessor.Selection[0].BrushType = brushTypeDropDown.Text;

            viewPort.Invalidate();
        }

        /// <summary>
        /// Бутон за отмяна на последната направена промяна в модела, чрез
        /// заменяне на текущото състояние с последното записано в Clipboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.Undo();
            statusBar.Items[0].Text = "Последно действие: Отмяна";
            viewPort.Invalidate();
        }

        private void stateChangeChecker_Tick(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void speedMenu_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void mainMenu_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void toolsPanel2_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void speedMenu_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void viewPort_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void toolsPanel2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void mainMenu_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void addEllipseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Бутон за селектиране на всички графични примитиви на модела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in dialogProcessor.Selection)
            {
                item.IsSelected = false;
            }
            dialogProcessor.Selection.Clear();
            foreach (var item in dialogProcessor.ShapeList)
            {
                item.IsSelected = true;
                dialogProcessor.Selection.Add(item);
            }
            statusBar.Items[0].Text = "Последно действие: Избиране на всички";
            viewPort.Invalidate();
        }

        /// <summary>
        /// Връща модела (ShapeList) на текущия прозорец, за да се
        /// използва от друг прозорец.
        /// </summary>
        /// <returns></returns>
        public List<Shape> GetFormModel()
        {
            return dialogProcessor.ShapeList;
        }

        /// <summary>
        /// Приема модел (ShapeList) и го задава като ново състояние
        /// за текущия прозорец.
        /// </summary>
        /// <param name="shapeList"></param>
        public void SetFormModel(List<Shape> shapeList)
        {
            foreach(var item in shapeList)
            {
                dialogProcessor.ShapeList.Add(item.CopySelf());
            }
        }
    }
}
