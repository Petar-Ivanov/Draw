namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentagonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ungroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cursorLocationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.dragSelectionButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawEllipseButton = new System.Windows.Forms.ToolStripButton();
            this.drawCircleButton = new System.Windows.Forms.ToolStripButton();
            this.drawTriangleButton = new System.Windows.Forms.ToolStripButton();
            this.drawPentagonButton = new System.Windows.Forms.ToolStripButton();
            this.drawStarButton = new System.Windows.Forms.ToolStripButton();
            this.drawDotButton = new System.Windows.Forms.ToolStripButton();
            this.drawHorizontalLineButton = new System.Windows.Forms.ToolStripButton();
            this.drawVerticalLineButton = new System.Windows.Forms.ToolStripButton();
            this.drawBezierButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectPrimaryColorButton = new System.Windows.Forms.ToolStripButton();
            this.selectSecondaryColorButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupButton = new System.Windows.Forms.ToolStripButton();
            this.ungroupButton = new System.Windows.Forms.ToolStripButton();
            this.fullUngroupButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.borderRadiusComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.colorTypeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.rotateRightButton = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateLeftButton = new System.Windows.Forms.ToolStripMenuItem();
            this.rotate180Button = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.slider1 = new System.Windows.Forms.TrackBar();
            this.slider1Label = new System.Windows.Forms.Label();
            this.opacityPanel = new System.Windows.Forms.Panel();
            this.fillColorRadioButton = new System.Windows.Forms.RadioButton();
            this.borderColorRadioButton = new System.Windows.Forms.RadioButton();
            this.colorGroupSelectionPanel = new System.Windows.Forms.GroupBox();
            this.toolsPanel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.decreaseHeightButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.increaseHeightButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.decreaseWidthButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.increaseWidthButton = new System.Windows.Forms.Button();
            this.rotationPanel = new System.Windows.Forms.Panel();
            this.slider2Label = new System.Windows.Forms.Label();
            this.slider2 = new System.Windows.Forms.TrackBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.borderRadiusDropDown = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.opacityUpDown = new System.Windows.Forms.NumericUpDown();
            this.opacityTypeDropDown = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.secondaryBorderColorDropDown = new System.Windows.Forms.ComboBox();
            this.primaryBorderColorDropDown = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.secondaryColorDropDown = new System.Windows.Forms.ComboBox();
            this.primaryColorDropDown = new System.Windows.Forms.ComboBox();
            this.rotationTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.brushTypeDropDown = new System.Windows.Forms.ComboBox();
            this.shapeTree = new System.Windows.Forms.TreeView();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider1)).BeginInit();
            this.opacityPanel.SuspendLayout();
            this.colorGroupSelectionPanel.SuspendLayout();
            this.toolsPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rotationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider2)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityUpDown)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1028, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.MouseHover += new System.EventHandler(this.mainMenu_MouseHover);
            this.mainMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainMenu_MouseUp);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsBinaryToolStripMenuItem,
            this.asJSONToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportAsBinaryToolStripMenuItem
            // 
            this.exportAsBinaryToolStripMenuItem.Name = "exportAsBinaryToolStripMenuItem";
            this.exportAsBinaryToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportAsBinaryToolStripMenuItem.Text = "Export All";
            this.exportAsBinaryToolStripMenuItem.Click += new System.EventHandler(this.exportAsBinaryToolStripMenuItem_Click);
            // 
            // asJSONToolStripMenuItem
            // 
            this.asJSONToolStripMenuItem.Name = "asJSONToolStripMenuItem";
            this.asJSONToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.asJSONToolStripMenuItem.Text = "Export Selected";
            this.asJSONToolStripMenuItem.Click += new System.EventHandler(this.asJSONToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.iOToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // iOToolStripMenuItem
            // 
            this.iOToolStripMenuItem.Name = "iOToolStripMenuItem";
            this.iOToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.iOToolStripMenuItem.Text = "Paste";
            this.iOToolStripMenuItem.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRectangleToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.groupSelectedToolStripMenuItem,
            this.ungroupToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // addRectangleToolStripMenuItem
            // 
            this.addRectangleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.ciToolStripMenuItem,
            this.triangleToolStripMenuItem,
            this.pentagonToolStripMenuItem,
            this.starToolStripMenuItem,
            this.dotToolStripMenuItem,
            this.horizontalLineToolStripMenuItem,
            this.verticalLineToolStripMenuItem,
            this.bezierToolStripMenuItem});
            this.addRectangleToolStripMenuItem.Name = "addRectangleToolStripMenuItem";
            this.addRectangleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addRectangleToolStripMenuItem.Text = "Add";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.drawEllipseButton_Click);
            // 
            // ciToolStripMenuItem
            // 
            this.ciToolStripMenuItem.Name = "ciToolStripMenuItem";
            this.ciToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ciToolStripMenuItem.Text = "Circle";
            this.ciToolStripMenuItem.Click += new System.EventHandler(this.drawCircleButton_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.drawTriangleButton_Click);
            // 
            // pentagonToolStripMenuItem
            // 
            this.pentagonToolStripMenuItem.Name = "pentagonToolStripMenuItem";
            this.pentagonToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.pentagonToolStripMenuItem.Text = "Pentagon";
            this.pentagonToolStripMenuItem.Click += new System.EventHandler(this.drawPentagonButton_Click);
            // 
            // starToolStripMenuItem
            // 
            this.starToolStripMenuItem.Name = "starToolStripMenuItem";
            this.starToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.starToolStripMenuItem.Text = "Star";
            this.starToolStripMenuItem.Click += new System.EventHandler(this.drawStarButton_Click);
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.dotToolStripMenuItem.Text = "Dot";
            this.dotToolStripMenuItem.Click += new System.EventHandler(this.drawDotButton_Click);
            // 
            // horizontalLineToolStripMenuItem
            // 
            this.horizontalLineToolStripMenuItem.Name = "horizontalLineToolStripMenuItem";
            this.horizontalLineToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.horizontalLineToolStripMenuItem.Text = "Horizontal Line";
            this.horizontalLineToolStripMenuItem.Click += new System.EventHandler(this.drawHorizontalLineButton_Click);
            // 
            // verticalLineToolStripMenuItem
            // 
            this.verticalLineToolStripMenuItem.Name = "verticalLineToolStripMenuItem";
            this.verticalLineToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.verticalLineToolStripMenuItem.Text = "Vertical Line";
            this.verticalLineToolStripMenuItem.Click += new System.EventHandler(this.drawVerticalLineButton_Click);
            // 
            // bezierToolStripMenuItem
            // 
            this.bezierToolStripMenuItem.Name = "bezierToolStripMenuItem";
            this.bezierToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bezierToolStripMenuItem.Text = "Bezier Curve";
            this.bezierToolStripMenuItem.Click += new System.EventHandler(this.drawBezierButton_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // groupSelectedToolStripMenuItem
            // 
            this.groupSelectedToolStripMenuItem.Name = "groupSelectedToolStripMenuItem";
            this.groupSelectedToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.groupSelectedToolStripMenuItem.Text = "Group Selected";
            this.groupSelectedToolStripMenuItem.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // ungroupToolStripMenuItem
            // 
            this.ungroupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onceToolStripMenuItem,
            this.fullToolStripMenuItem});
            this.ungroupToolStripMenuItem.Name = "ungroupToolStripMenuItem";
            this.ungroupToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ungroupToolStripMenuItem.Text = "Ungroup";
            // 
            // onceToolStripMenuItem
            // 
            this.onceToolStripMenuItem.Name = "onceToolStripMenuItem";
            this.onceToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.onceToolStripMenuItem.Text = "One Level";
            this.onceToolStripMenuItem.Click += new System.EventHandler(this.ungroupButton_Click);
            // 
            // fullToolStripMenuItem
            // 
            this.fullToolStripMenuItem.Name = "fullToolStripMenuItem";
            this.fullToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.fullToolStripMenuItem.Text = "Full";
            this.fullToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel,
            this.cursorLocationLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 714);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1028, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // cursorLocationLabel
            // 
            this.cursorLocationLabel.Name = "cursorLocationLabel";
            this.cursorLocationLabel.Size = new System.Drawing.Size(51, 17);
            this.cursorLocationLabel.Text = "X: 0, Y: 0";
            // 
            // speedMenu
            // 
            this.speedMenu.BackColor = System.Drawing.SystemColors.Control;
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.dragSelectionButton,
            this.drawRectangleSpeedButton,
            this.drawEllipseButton,
            this.drawCircleButton,
            this.drawTriangleButton,
            this.drawPentagonButton,
            this.drawStarButton,
            this.drawDotButton,
            this.drawHorizontalLineButton,
            this.drawVerticalLineButton,
            this.drawBezierButton,
            this.toolStripSeparator1,
            this.selectPrimaryColorButton,
            this.selectSecondaryColorButton,
            this.toolStripSeparator2,
            this.groupButton,
            this.ungroupButton,
            this.fullUngroupButton,
            this.toolStripSeparator3,
            this.borderRadiusComboBox,
            this.colorTypeComboBox,
            this.copyButton,
            this.pasteButton,
            this.cutButton,
            this.deleteButton,
            this.toolStripSplitButton1});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(1028, 25);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            this.speedMenu.Click += new System.EventHandler(this.speedMenu_Click);
            this.speedMenu.MouseHover += new System.EventHandler(this.speedMenu_MouseHover);
            this.speedMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.speedMenu_MouseUp);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            this.pickUpSpeedButton.ToolTipText = "Select";
            this.pickUpSpeedButton.Click += new System.EventHandler(this.pickUpSpeedButton_Click);
            // 
            // dragSelectionButton
            // 
            this.dragSelectionButton.CheckOnClick = true;
            this.dragSelectionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dragSelectionButton.Image = global::Draw.Properties.Resources.areaselect;
            this.dragSelectionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dragSelectionButton.Name = "dragSelectionButton";
            this.dragSelectionButton.Size = new System.Drawing.Size(23, 22);
            this.dragSelectionButton.Text = "toolStripButton1";
            this.dragSelectionButton.ToolTipText = "Drag Selection";
            this.dragSelectionButton.Click += new System.EventHandler(this.dragSelectionButton_Click);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(23, 22);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.ToolTipText = "Rectangle";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // drawEllipseButton
            // 
            this.drawEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseButton.Image")));
            this.drawEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseButton.Name = "drawEllipseButton";
            this.drawEllipseButton.Size = new System.Drawing.Size(23, 22);
            this.drawEllipseButton.Text = "toolStripButton1";
            this.drawEllipseButton.ToolTipText = "Ellipse";
            this.drawEllipseButton.Click += new System.EventHandler(this.drawEllipseButton_Click);
            // 
            // drawCircleButton
            // 
            this.drawCircleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircleButton.Image = ((System.Drawing.Image)(resources.GetObject("drawCircleButton.Image")));
            this.drawCircleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircleButton.Name = "drawCircleButton";
            this.drawCircleButton.Size = new System.Drawing.Size(23, 22);
            this.drawCircleButton.Text = "toolStripButton1";
            this.drawCircleButton.ToolTipText = "Circle";
            this.drawCircleButton.Click += new System.EventHandler(this.drawCircleButton_Click);
            // 
            // drawTriangleButton
            // 
            this.drawTriangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawTriangleButton.Image = ((System.Drawing.Image)(resources.GetObject("drawTriangleButton.Image")));
            this.drawTriangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawTriangleButton.Name = "drawTriangleButton";
            this.drawTriangleButton.Size = new System.Drawing.Size(23, 22);
            this.drawTriangleButton.Text = "toolStripButton1";
            this.drawTriangleButton.ToolTipText = "Triangle";
            this.drawTriangleButton.Click += new System.EventHandler(this.drawTriangleButton_Click);
            // 
            // drawPentagonButton
            // 
            this.drawPentagonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPentagonButton.Image = ((System.Drawing.Image)(resources.GetObject("drawPentagonButton.Image")));
            this.drawPentagonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPentagonButton.Name = "drawPentagonButton";
            this.drawPentagonButton.Size = new System.Drawing.Size(23, 22);
            this.drawPentagonButton.Text = "toolStripButton1";
            this.drawPentagonButton.ToolTipText = "Pentagon";
            this.drawPentagonButton.Click += new System.EventHandler(this.drawPentagonButton_Click);
            // 
            // drawStarButton
            // 
            this.drawStarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawStarButton.Image = ((System.Drawing.Image)(resources.GetObject("drawStarButton.Image")));
            this.drawStarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawStarButton.Name = "drawStarButton";
            this.drawStarButton.Size = new System.Drawing.Size(23, 22);
            this.drawStarButton.Text = "toolStripButton1";
            this.drawStarButton.ToolTipText = "Star";
            this.drawStarButton.Click += new System.EventHandler(this.drawStarButton_Click);
            // 
            // drawDotButton
            // 
            this.drawDotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawDotButton.Image = ((System.Drawing.Image)(resources.GetObject("drawDotButton.Image")));
            this.drawDotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawDotButton.Name = "drawDotButton";
            this.drawDotButton.Size = new System.Drawing.Size(23, 22);
            this.drawDotButton.Text = "toolStripButton1";
            this.drawDotButton.ToolTipText = "Dot";
            this.drawDotButton.Click += new System.EventHandler(this.drawDotButton_Click);
            // 
            // drawHorizontalLineButton
            // 
            this.drawHorizontalLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawHorizontalLineButton.Image = ((System.Drawing.Image)(resources.GetObject("drawHorizontalLineButton.Image")));
            this.drawHorizontalLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawHorizontalLineButton.Name = "drawHorizontalLineButton";
            this.drawHorizontalLineButton.Size = new System.Drawing.Size(23, 22);
            this.drawHorizontalLineButton.Text = "toolStripButton1";
            this.drawHorizontalLineButton.ToolTipText = "Horizontal Line";
            this.drawHorizontalLineButton.Click += new System.EventHandler(this.drawHorizontalLineButton_Click);
            // 
            // drawVerticalLineButton
            // 
            this.drawVerticalLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawVerticalLineButton.Image = ((System.Drawing.Image)(resources.GetObject("drawVerticalLineButton.Image")));
            this.drawVerticalLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawVerticalLineButton.Name = "drawVerticalLineButton";
            this.drawVerticalLineButton.Size = new System.Drawing.Size(23, 22);
            this.drawVerticalLineButton.Text = "toolStripButton1";
            this.drawVerticalLineButton.ToolTipText = "Vertical Line";
            this.drawVerticalLineButton.Click += new System.EventHandler(this.drawVerticalLineButton_Click);
            // 
            // drawBezierButton
            // 
            this.drawBezierButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawBezierButton.Image = ((System.Drawing.Image)(resources.GetObject("drawBezierButton.Image")));
            this.drawBezierButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawBezierButton.Name = "drawBezierButton";
            this.drawBezierButton.Size = new System.Drawing.Size(23, 22);
            this.drawBezierButton.Text = "toolStripButton1";
            this.drawBezierButton.ToolTipText = "Bezier Line";
            this.drawBezierButton.Click += new System.EventHandler(this.drawBezierButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // selectPrimaryColorButton
            // 
            this.selectPrimaryColorButton.BackColor = System.Drawing.Color.White;
            this.selectPrimaryColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectPrimaryColorButton.Image = ((System.Drawing.Image)(resources.GetObject("selectPrimaryColorButton.Image")));
            this.selectPrimaryColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectPrimaryColorButton.Name = "selectPrimaryColorButton";
            this.selectPrimaryColorButton.Size = new System.Drawing.Size(23, 22);
            this.selectPrimaryColorButton.Text = "toolStripButton1";
            this.selectPrimaryColorButton.ToolTipText = "Primary Color";
            this.selectPrimaryColorButton.Click += new System.EventHandler(this.selectPrimaryColorButton_Click);
            // 
            // selectSecondaryColorButton
            // 
            this.selectSecondaryColorButton.BackColor = System.Drawing.Color.White;
            this.selectSecondaryColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectSecondaryColorButton.Image = ((System.Drawing.Image)(resources.GetObject("selectSecondaryColorButton.Image")));
            this.selectSecondaryColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectSecondaryColorButton.Name = "selectSecondaryColorButton";
            this.selectSecondaryColorButton.Size = new System.Drawing.Size(23, 22);
            this.selectSecondaryColorButton.Text = "toolStripButton1";
            this.selectSecondaryColorButton.ToolTipText = "Secondary Color";
            this.selectSecondaryColorButton.Click += new System.EventHandler(this.selectSecondaryColorButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupButton
            // 
            this.groupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupButton.Image = global::Draw.Properties.Resources.link;
            this.groupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(23, 22);
            this.groupButton.Text = "toolStripButton1";
            this.groupButton.ToolTipText = "Group Selected";
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // ungroupButton
            // 
            this.ungroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ungroupButton.Image = global::Draw.Properties.Resources.unlink;
            this.ungroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ungroupButton.Name = "ungroupButton";
            this.ungroupButton.Size = new System.Drawing.Size(23, 22);
            this.ungroupButton.Text = "toolStripButton1";
            this.ungroupButton.ToolTipText = "Ungroup Selected";
            this.ungroupButton.Click += new System.EventHandler(this.ungroupButton_Click);
            // 
            // fullUngroupButton
            // 
            this.fullUngroupButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fullUngroupButton.Image = global::Draw.Properties.Resources.ungroup_all;
            this.fullUngroupButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fullUngroupButton.Name = "fullUngroupButton";
            this.fullUngroupButton.Size = new System.Drawing.Size(23, 22);
            this.fullUngroupButton.Text = "toolStripButton1";
            this.fullUngroupButton.ToolTipText = "Fully Ungroup Selected";
            this.fullUngroupButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // borderRadiusComboBox
            // 
            this.borderRadiusComboBox.Items.AddRange(new object[] {
            "2 px",
            "7 px",
            "5 px",
            "10 px",
            "15 px",
            "20 px",
            "25 px"});
            this.borderRadiusComboBox.Name = "borderRadiusComboBox";
            this.borderRadiusComboBox.Size = new System.Drawing.Size(75, 25);
            this.borderRadiusComboBox.Text = "2 px";
            this.borderRadiusComboBox.ToolTipText = "Border Radius";
            this.borderRadiusComboBox.TextChanged += new System.EventHandler(this.borderRadiusComboBox_TextChanged);
            // 
            // colorTypeComboBox
            // 
            this.colorTypeComboBox.Items.AddRange(new object[] {
            "Solid Brush",
            "Gradient Brush"});
            this.colorTypeComboBox.Name = "colorTypeComboBox";
            this.colorTypeComboBox.Size = new System.Drawing.Size(121, 25);
            this.colorTypeComboBox.Text = "Solid Brush";
            this.colorTypeComboBox.ToolTipText = "Brush Type";
            this.colorTypeComboBox.TextChanged += new System.EventHandler(this.colorTypeComboBox_TextChanged);
            // 
            // copyButton
            // 
            this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyButton.Image = global::Draw.Properties.Resources.copy;
            this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(23, 22);
            this.copyButton.Text = "toolStripButton1";
            this.copyButton.ToolTipText = "Copy";
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteButton.Image = global::Draw.Properties.Resources.paste;
            this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(23, 22);
            this.pasteButton.Text = "toolStripButton2";
            this.pasteButton.ToolTipText = "Paste";
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // cutButton
            // 
            this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutButton.Image = global::Draw.Properties.Resources.cut;
            this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(23, 22);
            this.cutButton.Text = "toolStripButton1";
            this.cutButton.ToolTipText = "Cut";
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(23, 22);
            this.deleteButton.Text = "toolStripButton1";
            this.deleteButton.ToolTipText = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateRightButton,
            this.rotateLeftButton,
            this.rotate180Button});
            this.toolStripSplitButton1.Image = global::Draw.Properties.Resources.rotate;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ToolTipText = "Rotate";
            // 
            // rotateRightButton
            // 
            this.rotateRightButton.Name = "rotateRightButton";
            this.rotateRightButton.Size = new System.Drawing.Size(167, 22);
            this.rotateRightButton.Text = "Rotate Right (90°)";
            this.rotateRightButton.Click += new System.EventHandler(this.rotateRightButton_Click);
            // 
            // rotateLeftButton
            // 
            this.rotateLeftButton.Name = "rotateLeftButton";
            this.rotateLeftButton.Size = new System.Drawing.Size(167, 22);
            this.rotateLeftButton.Text = "Rotate Left (90°)";
            this.rotateLeftButton.Click += new System.EventHandler(this.rotateLeftButton_Click);
            // 
            // rotate180Button
            // 
            this.rotate180Button.Name = "rotate180Button";
            this.rotate180Button.Size = new System.Drawing.Size(167, 22);
            this.rotate180Button.Text = "Rotate (180°)";
            this.rotate180Button.Click += new System.EventHandler(this.rotate180Button_Click);
            // 
            // slider1
            // 
            this.slider1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slider1.Location = new System.Drawing.Point(51, 16);
            this.slider1.Maximum = 100;
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(104, 45);
            this.slider1.TabIndex = 5;
            this.slider1.Value = 100;
            this.slider1.ValueChanged += new System.EventHandler(this.slider1_ValueChanged);
            // 
            // slider1Label
            // 
            this.slider1Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slider1Label.AutoSize = true;
            this.slider1Label.Location = new System.Drawing.Point(12, 16);
            this.slider1Label.Name = "slider1Label";
            this.slider1Label.Size = new System.Drawing.Size(33, 13);
            this.slider1Label.TabIndex = 6;
            this.slider1Label.Text = "100%";
            // 
            // opacityPanel
            // 
            this.opacityPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.opacityPanel.Controls.Add(this.slider1);
            this.opacityPanel.Controls.Add(this.slider1Label);
            this.opacityPanel.Location = new System.Drawing.Point(139, 10);
            this.opacityPanel.Name = "opacityPanel";
            this.opacityPanel.Size = new System.Drawing.Size(158, 52);
            this.opacityPanel.TabIndex = 7;
            // 
            // fillColorRadioButton
            // 
            this.fillColorRadioButton.AutoSize = true;
            this.fillColorRadioButton.Checked = true;
            this.fillColorRadioButton.Location = new System.Drawing.Point(6, 19);
            this.fillColorRadioButton.Name = "fillColorRadioButton";
            this.fillColorRadioButton.Size = new System.Drawing.Size(64, 17);
            this.fillColorRadioButton.TabIndex = 0;
            this.fillColorRadioButton.TabStop = true;
            this.fillColorRadioButton.Text = "Fill Color";
            this.fillColorRadioButton.UseVisualStyleBackColor = true;
            this.fillColorRadioButton.CheckedChanged += new System.EventHandler(this.fillColorRadioButton_CheckedChanged);
            // 
            // borderColorRadioButton
            // 
            this.borderColorRadioButton.AutoSize = true;
            this.borderColorRadioButton.Location = new System.Drawing.Point(6, 42);
            this.borderColorRadioButton.Name = "borderColorRadioButton";
            this.borderColorRadioButton.Size = new System.Drawing.Size(83, 17);
            this.borderColorRadioButton.TabIndex = 1;
            this.borderColorRadioButton.TabStop = true;
            this.borderColorRadioButton.Text = "Border Color";
            this.borderColorRadioButton.UseVisualStyleBackColor = true;
            this.borderColorRadioButton.CheckedChanged += new System.EventHandler(this.borderColorRadioButton_CheckedChanged);
            // 
            // colorGroupSelectionPanel
            // 
            this.colorGroupSelectionPanel.Controls.Add(this.borderColorRadioButton);
            this.colorGroupSelectionPanel.Controls.Add(this.fillColorRadioButton);
            this.colorGroupSelectionPanel.Location = new System.Drawing.Point(3, 3);
            this.colorGroupSelectionPanel.Name = "colorGroupSelectionPanel";
            this.colorGroupSelectionPanel.Size = new System.Drawing.Size(130, 70);
            this.colorGroupSelectionPanel.TabIndex = 9;
            this.colorGroupSelectionPanel.TabStop = false;
            this.colorGroupSelectionPanel.Text = "Color Group Selection";
            // 
            // toolsPanel2
            // 
            this.toolsPanel2.Controls.Add(this.panel3);
            this.toolsPanel2.Controls.Add(this.panel2);
            this.toolsPanel2.Controls.Add(this.panel1);
            this.toolsPanel2.Controls.Add(this.rotationPanel);
            this.toolsPanel2.Controls.Add(this.colorGroupSelectionPanel);
            this.toolsPanel2.Controls.Add(this.opacityPanel);
            this.toolsPanel2.Location = new System.Drawing.Point(12, 52);
            this.toolsPanel2.Name = "toolsPanel2";
            this.toolsPanel2.Size = new System.Drawing.Size(768, 81);
            this.toolsPanel2.TabIndex = 10;
            this.toolsPanel2.Click += new System.EventHandler(this.speedMenu_Click);
            this.toolsPanel2.MouseHover += new System.EventHandler(this.toolsPanel2_MouseHover);
            this.toolsPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolsPanel2_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.moveDownButton);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.moveUpButton);
            this.panel3.Location = new System.Drawing.Point(696, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(69, 52);
            this.panel3.TabIndex = 15;
            // 
            // moveDownButton
            // 
            this.moveDownButton.BackgroundImage = global::Draw.Properties.Resources.decrease;
            this.moveDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveDownButton.Location = new System.Drawing.Point(43, 26);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(21, 23);
            this.moveDownButton.TabIndex = 14;
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Layer";
            // 
            // moveUpButton
            // 
            this.moveUpButton.BackgroundImage = global::Draw.Properties.Resources.increase;
            this.moveUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveUpButton.Location = new System.Drawing.Point(43, 3);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(21, 23);
            this.moveUpButton.TabIndex = 13;
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.decreaseHeightButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.increaseHeightButton);
            this.panel2.Location = new System.Drawing.Point(624, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(69, 52);
            this.panel2.TabIndex = 14;
            // 
            // decreaseHeightButton
            // 
            this.decreaseHeightButton.BackgroundImage = global::Draw.Properties.Resources.decrease;
            this.decreaseHeightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.decreaseHeightButton.Location = new System.Drawing.Point(43, 26);
            this.decreaseHeightButton.Name = "decreaseHeightButton";
            this.decreaseHeightButton.Size = new System.Drawing.Size(21, 23);
            this.decreaseHeightButton.TabIndex = 14;
            this.decreaseHeightButton.UseVisualStyleBackColor = true;
            this.decreaseHeightButton.Click += new System.EventHandler(this.decreaseHeightButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Height";
            // 
            // increaseHeightButton
            // 
            this.increaseHeightButton.BackgroundImage = global::Draw.Properties.Resources.increase;
            this.increaseHeightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.increaseHeightButton.Location = new System.Drawing.Point(43, 3);
            this.increaseHeightButton.Name = "increaseHeightButton";
            this.increaseHeightButton.Size = new System.Drawing.Size(21, 23);
            this.increaseHeightButton.TabIndex = 13;
            this.increaseHeightButton.UseVisualStyleBackColor = true;
            this.increaseHeightButton.Click += new System.EventHandler(this.increaseHeightButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.decreaseWidthButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.increaseWidthButton);
            this.panel1.Location = new System.Drawing.Point(559, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 52);
            this.panel1.TabIndex = 13;
            // 
            // decreaseWidthButton
            // 
            this.decreaseWidthButton.BackgroundImage = global::Draw.Properties.Resources.decrease;
            this.decreaseWidthButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.decreaseWidthButton.Location = new System.Drawing.Point(38, 26);
            this.decreaseWidthButton.Name = "decreaseWidthButton";
            this.decreaseWidthButton.Size = new System.Drawing.Size(21, 23);
            this.decreaseWidthButton.TabIndex = 12;
            this.decreaseWidthButton.UseVisualStyleBackColor = true;
            this.decreaseWidthButton.Click += new System.EventHandler(this.decreaseWidthButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Width";
            // 
            // increaseWidthButton
            // 
            this.increaseWidthButton.BackgroundImage = global::Draw.Properties.Resources.increase;
            this.increaseWidthButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.increaseWidthButton.Location = new System.Drawing.Point(38, 3);
            this.increaseWidthButton.Name = "increaseWidthButton";
            this.increaseWidthButton.Size = new System.Drawing.Size(21, 23);
            this.increaseWidthButton.TabIndex = 11;
            this.increaseWidthButton.UseVisualStyleBackColor = true;
            this.increaseWidthButton.Click += new System.EventHandler(this.increaseWidthButton_Click);
            // 
            // rotationPanel
            // 
            this.rotationPanel.Controls.Add(this.slider2Label);
            this.rotationPanel.Controls.Add(this.slider2);
            this.rotationPanel.Location = new System.Drawing.Point(303, 10);
            this.rotationPanel.Name = "rotationPanel";
            this.rotationPanel.Size = new System.Drawing.Size(250, 52);
            this.rotationPanel.TabIndex = 11;
            // 
            // slider2Label
            // 
            this.slider2Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slider2Label.AutoSize = true;
            this.slider2Label.Location = new System.Drawing.Point(3, 16);
            this.slider2Label.Name = "slider2Label";
            this.slider2Label.Size = new System.Drawing.Size(17, 13);
            this.slider2Label.TabIndex = 12;
            this.slider2Label.Text = "0°";
            // 
            // slider2
            // 
            this.slider2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slider2.Location = new System.Drawing.Point(26, 16);
            this.slider2.Maximum = 360;
            this.slider2.Minimum = -360;
            this.slider2.Name = "slider2";
            this.slider2.Size = new System.Drawing.Size(221, 45);
            this.slider2.TabIndex = 11;
            this.slider2.ValueChanged += new System.EventHandler(this.slider2_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.shapeTree);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(786, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 665);
            this.panel4.TabIndex = 11;
            this.panel4.Click += new System.EventHandler(this.speedMenu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.65145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.34855F));
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.borderRadiusDropDown, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.rotationTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.heightTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.widthTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.brushTypeDropDown, 1, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Enabled = false;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 354);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(242, 311);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            this.tableLayoutPanel1.MouseHover += new System.EventHandler(this.tableLayoutPanel1_MouseHover);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseUp);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 26);
            this.label13.TabIndex = 25;
            this.label13.Text = "Brush Type";
            // 
            // borderRadiusDropDown
            // 
            this.borderRadiusDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderRadiusDropDown.FormattingEnabled = true;
            this.borderRadiusDropDown.Items.AddRange(new object[] {
            "2 px",
            "7 px",
            "5 px",
            "10 px",
            "15 px",
            "20 px",
            "25 px"});
            this.borderRadiusDropDown.Location = new System.Drawing.Point(61, 252);
            this.borderRadiusDropDown.Name = "borderRadiusDropDown";
            this.borderRadiusDropDown.Size = new System.Drawing.Size(177, 21);
            this.borderRadiusDropDown.TabIndex = 12;
            this.borderRadiusDropDown.Leave += new System.EventHandler(this.borderRadiusDropDown_Leave);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 26);
            this.label12.TabIndex = 23;
            this.label12.Text = "Border Radius";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.opacityUpDown);
            this.panel8.Controls.Add(this.opacityTypeDropDown);
            this.panel8.Location = new System.Drawing.Point(61, 221);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(177, 24);
            this.panel8.TabIndex = 22;
            // 
            // opacityUpDown
            // 
            this.opacityUpDown.Location = new System.Drawing.Point(90, 3);
            this.opacityUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.opacityUpDown.Name = "opacityUpDown";
            this.opacityUpDown.Size = new System.Drawing.Size(84, 20);
            this.opacityUpDown.TabIndex = 13;
            this.opacityUpDown.Leave += new System.EventHandler(this.opacityUpDown_Leave);
            // 
            // opacityTypeDropDown
            // 
            this.opacityTypeDropDown.FormattingEnabled = true;
            this.opacityTypeDropDown.Items.AddRange(new object[] {
            "Fill",
            "Border"});
            this.opacityTypeDropDown.Location = new System.Drawing.Point(3, 3);
            this.opacityTypeDropDown.Name = "opacityTypeDropDown";
            this.opacityTypeDropDown.Size = new System.Drawing.Size(81, 21);
            this.opacityTypeDropDown.TabIndex = 20;
            this.opacityTypeDropDown.Leave += new System.EventHandler(this.opacityTypeDropDown_Leave);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Opacity";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.secondaryBorderColorDropDown);
            this.panel7.Controls.Add(this.primaryBorderColorDropDown);
            this.panel7.Location = new System.Drawing.Point(61, 190);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(177, 24);
            this.panel7.TabIndex = 21;
            // 
            // secondaryBorderColorDropDown
            // 
            this.secondaryBorderColorDropDown.FormattingEnabled = true;
            this.secondaryBorderColorDropDown.Items.AddRange(new object[] {
            "AliceBlue",
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Azure",
            "Beige",
            "Bisque",
            "Black",
            "BlanchedAlmond",
            "Blue",
            "BlueViolet",
            "Brown",
            "BurlyWood",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkCyan",
            "DarkGoldenrod",
            "DarkGray",
            "DarkGreen",
            "DarkKhaki",
            "DarkMagenta",
            "DarkOliveGreen",
            "DarkOrange",
            "DarkOrchid",
            "DarkRed",
            "DarkSalmon",
            "DarkSeaGreen",
            "DarkSlateBlue",
            "DarkSlateGray",
            "DarkTurquoise",
            "DarkViolet",
            "DeepPink",
            "DeepSkyBlue",
            "DimGray",
            "DodgerBlue",
            "Firebrick",
            "FloralWhite",
            "ForestGreen",
            "Fuchsia",
            "Gainsboro",
            "GhostWhite",
            "Gold",
            "Goldenrod",
            "Gray",
            "Green",
            "GreenYellow",
            "Honeydew",
            "HotPink",
            "IndianRed",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LavenderBlush",
            "LawnGreen",
            "LemonChiffon",
            "LightBlue",
            "LightCoral",
            "LightCyan",
            "LightGoldenrodYellow",
            "LightGray",
            "LightGreen",
            "LightPink",
            "LightSalmon",
            "LightSeaGreen",
            "LightSkyBlue",
            "LightSlateGray",
            "LightSteelBlue",
            "LightYellow",
            "Lime",
            "LimeGreen",
            "Linen",
            "Magenta",
            "Maroon",
            "MediumAquamarine",
            "MediumBlue",
            "MediumOrchid",
            "MediumPurple",
            "MediumSeaGreen",
            "MediumSlateBlue",
            "MediumSpringGreen",
            "MediumTurquoise",
            "MediumVioletRed",
            "MidnightBlue",
            "MintCream",
            "MistyRose",
            "Moccasin",
            "NavajoWhite",
            "Navy",
            "OldLace",
            "Olive",
            "OliveDrab",
            "Orange",
            "OrangeRed",
            "Orchid",
            "PaleGoldenrod",
            "PaleGreen",
            "PaleTurquoise",
            "PaleVioletRed",
            "PapayaWhip",
            "PeachPuff",
            "Peru",
            "Pink",
            "Plum",
            "PowderBlue",
            "Purple",
            "Red",
            "RosyBrown",
            "RoyalBlue",
            "SaddleBrown",
            "Salmon",
            "SandyBrown",
            "SeaGreen",
            "SeaShell",
            "Sienna",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Snow",
            "SpringGreen",
            "SteelBlue",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato",
            "Turquoise",
            "Violet",
            "Wheat",
            "White",
            "WhiteSmoke",
            "Yellow",
            "YellowGreen"});
            this.secondaryBorderColorDropDown.Location = new System.Drawing.Point(90, 3);
            this.secondaryBorderColorDropDown.Name = "secondaryBorderColorDropDown";
            this.secondaryBorderColorDropDown.Size = new System.Drawing.Size(84, 21);
            this.secondaryBorderColorDropDown.TabIndex = 22;
            this.secondaryBorderColorDropDown.Leave += new System.EventHandler(this.secondaryBorderColorDropDown_Leave);
            // 
            // primaryBorderColorDropDown
            // 
            this.primaryBorderColorDropDown.FormattingEnabled = true;
            this.primaryBorderColorDropDown.Items.AddRange(new object[] {
            "AliceBlue",
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Azure",
            "Beige",
            "Bisque",
            "Black",
            "BlanchedAlmond",
            "Blue",
            "BlueViolet",
            "Brown",
            "BurlyWood",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkCyan",
            "DarkGoldenrod",
            "DarkGray",
            "DarkGreen",
            "DarkKhaki",
            "DarkMagenta",
            "DarkOliveGreen",
            "DarkOrange",
            "DarkOrchid",
            "DarkRed",
            "DarkSalmon",
            "DarkSeaGreen",
            "DarkSlateBlue",
            "DarkSlateGray",
            "DarkTurquoise",
            "DarkViolet",
            "DeepPink",
            "DeepSkyBlue",
            "DimGray",
            "DodgerBlue",
            "Firebrick",
            "FloralWhite",
            "ForestGreen",
            "Fuchsia",
            "Gainsboro",
            "GhostWhite",
            "Gold",
            "Goldenrod",
            "Gray",
            "Green",
            "GreenYellow",
            "Honeydew",
            "HotPink",
            "IndianRed",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LavenderBlush",
            "LawnGreen",
            "LemonChiffon",
            "LightBlue",
            "LightCoral",
            "LightCyan",
            "LightGoldenrodYellow",
            "LightGray",
            "LightGreen",
            "LightPink",
            "LightSalmon",
            "LightSeaGreen",
            "LightSkyBlue",
            "LightSlateGray",
            "LightSteelBlue",
            "LightYellow",
            "Lime",
            "LimeGreen",
            "Linen",
            "Magenta",
            "Maroon",
            "MediumAquamarine",
            "MediumBlue",
            "MediumOrchid",
            "MediumPurple",
            "MediumSeaGreen",
            "MediumSlateBlue",
            "MediumSpringGreen",
            "MediumTurquoise",
            "MediumVioletRed",
            "MidnightBlue",
            "MintCream",
            "MistyRose",
            "Moccasin",
            "NavajoWhite",
            "Navy",
            "OldLace",
            "Olive",
            "OliveDrab",
            "Orange",
            "OrangeRed",
            "Orchid",
            "PaleGoldenrod",
            "PaleGreen",
            "PaleTurquoise",
            "PaleVioletRed",
            "PapayaWhip",
            "PeachPuff",
            "Peru",
            "Pink",
            "Plum",
            "PowderBlue",
            "Purple",
            "Red",
            "RosyBrown",
            "RoyalBlue",
            "SaddleBrown",
            "Salmon",
            "SandyBrown",
            "SeaGreen",
            "SeaShell",
            "Sienna",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Snow",
            "SpringGreen",
            "SteelBlue",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato",
            "Turquoise",
            "Violet",
            "Wheat",
            "White",
            "WhiteSmoke",
            "Yellow",
            "YellowGreen"});
            this.primaryBorderColorDropDown.Location = new System.Drawing.Point(3, 3);
            this.primaryBorderColorDropDown.Name = "primaryBorderColorDropDown";
            this.primaryBorderColorDropDown.Size = new System.Drawing.Size(81, 21);
            this.primaryBorderColorDropDown.TabIndex = 20;
            this.primaryBorderColorDropDown.Leave += new System.EventHandler(this.primaryBorderColorDropDown_Leave);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Border Color";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.secondaryColorDropDown);
            this.panel6.Controls.Add(this.primaryColorDropDown);
            this.panel6.Location = new System.Drawing.Point(61, 159);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(177, 24);
            this.panel6.TabIndex = 12;
            // 
            // secondaryColorDropDown
            // 
            this.secondaryColorDropDown.FormattingEnabled = true;
            this.secondaryColorDropDown.Items.AddRange(new object[] {
            "AliceBlue",
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Azure",
            "Beige",
            "Bisque",
            "Black",
            "BlanchedAlmond",
            "Blue",
            "BlueViolet",
            "Brown",
            "BurlyWood",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkCyan",
            "DarkGoldenrod",
            "DarkGray",
            "DarkGreen",
            "DarkKhaki",
            "DarkMagenta",
            "DarkOliveGreen",
            "DarkOrange",
            "DarkOrchid",
            "DarkRed",
            "DarkSalmon",
            "DarkSeaGreen",
            "DarkSlateBlue",
            "DarkSlateGray",
            "DarkTurquoise",
            "DarkViolet",
            "DeepPink",
            "DeepSkyBlue",
            "DimGray",
            "DodgerBlue",
            "Firebrick",
            "FloralWhite",
            "ForestGreen",
            "Fuchsia",
            "Gainsboro",
            "GhostWhite",
            "Gold",
            "Goldenrod",
            "Gray",
            "Green",
            "GreenYellow",
            "Honeydew",
            "HotPink",
            "IndianRed",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LavenderBlush",
            "LawnGreen",
            "LemonChiffon",
            "LightBlue",
            "LightCoral",
            "LightCyan",
            "LightGoldenrodYellow",
            "LightGray",
            "LightGreen",
            "LightPink",
            "LightSalmon",
            "LightSeaGreen",
            "LightSkyBlue",
            "LightSlateGray",
            "LightSteelBlue",
            "LightYellow",
            "Lime",
            "LimeGreen",
            "Linen",
            "Magenta",
            "Maroon",
            "MediumAquamarine",
            "MediumBlue",
            "MediumOrchid",
            "MediumPurple",
            "MediumSeaGreen",
            "MediumSlateBlue",
            "MediumSpringGreen",
            "MediumTurquoise",
            "MediumVioletRed",
            "MidnightBlue",
            "MintCream",
            "MistyRose",
            "Moccasin",
            "NavajoWhite",
            "Navy",
            "OldLace",
            "Olive",
            "OliveDrab",
            "Orange",
            "OrangeRed",
            "Orchid",
            "PaleGoldenrod",
            "PaleGreen",
            "PaleTurquoise",
            "PaleVioletRed",
            "PapayaWhip",
            "PeachPuff",
            "Peru",
            "Pink",
            "Plum",
            "PowderBlue",
            "Purple",
            "Red",
            "RosyBrown",
            "RoyalBlue",
            "SaddleBrown",
            "Salmon",
            "SandyBrown",
            "SeaGreen",
            "SeaShell",
            "Sienna",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Snow",
            "SpringGreen",
            "SteelBlue",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato",
            "Turquoise",
            "Violet",
            "Wheat",
            "White",
            "WhiteSmoke",
            "Yellow",
            "YellowGreen"});
            this.secondaryColorDropDown.Location = new System.Drawing.Point(90, 3);
            this.secondaryColorDropDown.Name = "secondaryColorDropDown";
            this.secondaryColorDropDown.Size = new System.Drawing.Size(84, 21);
            this.secondaryColorDropDown.TabIndex = 22;
            this.secondaryColorDropDown.Leave += new System.EventHandler(this.secondaryColorDropDown_Leave);
            // 
            // primaryColorDropDown
            // 
            this.primaryColorDropDown.FormattingEnabled = true;
            this.primaryColorDropDown.Items.AddRange(new object[] {
            "AliceBlue",
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Azure",
            "Beige",
            "Bisque",
            "Black",
            "BlanchedAlmond",
            "Blue",
            "BlueViolet",
            "Brown",
            "BurlyWood",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkCyan",
            "DarkGoldenrod",
            "DarkGray",
            "DarkGreen",
            "DarkKhaki",
            "DarkMagenta",
            "DarkOliveGreen",
            "DarkOrange",
            "DarkOrchid",
            "DarkRed",
            "DarkSalmon",
            "DarkSeaGreen",
            "DarkSlateBlue",
            "DarkSlateGray",
            "DarkTurquoise",
            "DarkViolet",
            "DeepPink",
            "DeepSkyBlue",
            "DimGray",
            "DodgerBlue",
            "Firebrick",
            "FloralWhite",
            "ForestGreen",
            "Fuchsia",
            "Gainsboro",
            "GhostWhite",
            "Gold",
            "Goldenrod",
            "Gray",
            "Green",
            "GreenYellow",
            "Honeydew",
            "HotPink",
            "IndianRed",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LavenderBlush",
            "LawnGreen",
            "LemonChiffon",
            "LightBlue",
            "LightCoral",
            "LightCyan",
            "LightGoldenrodYellow",
            "LightGray",
            "LightGreen",
            "LightPink",
            "LightSalmon",
            "LightSeaGreen",
            "LightSkyBlue",
            "LightSlateGray",
            "LightSteelBlue",
            "LightYellow",
            "Lime",
            "LimeGreen",
            "Linen",
            "Magenta",
            "Maroon",
            "MediumAquamarine",
            "MediumBlue",
            "MediumOrchid",
            "MediumPurple",
            "MediumSeaGreen",
            "MediumSlateBlue",
            "MediumSpringGreen",
            "MediumTurquoise",
            "MediumVioletRed",
            "MidnightBlue",
            "MintCream",
            "MistyRose",
            "Moccasin",
            "NavajoWhite",
            "Navy",
            "OldLace",
            "Olive",
            "OliveDrab",
            "Orange",
            "OrangeRed",
            "Orchid",
            "PaleGoldenrod",
            "PaleGreen",
            "PaleTurquoise",
            "PaleVioletRed",
            "PapayaWhip",
            "PeachPuff",
            "Peru",
            "Pink",
            "Plum",
            "PowderBlue",
            "Purple",
            "Red",
            "RosyBrown",
            "RoyalBlue",
            "SaddleBrown",
            "Salmon",
            "SandyBrown",
            "SeaGreen",
            "SeaShell",
            "Sienna",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Snow",
            "SpringGreen",
            "SteelBlue",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato",
            "Turquoise",
            "Violet",
            "Wheat",
            "White",
            "WhiteSmoke",
            "Yellow",
            "YellowGreen"});
            this.primaryColorDropDown.Location = new System.Drawing.Point(3, 3);
            this.primaryColorDropDown.Name = "primaryColorDropDown";
            this.primaryColorDropDown.Size = new System.Drawing.Size(81, 21);
            this.primaryColorDropDown.TabIndex = 20;
            this.primaryColorDropDown.Leave += new System.EventHandler(this.primaryColorDropDown_Leave);
            // 
            // rotationTextBox
            // 
            this.rotationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotationTextBox.Location = new System.Drawing.Point(61, 128);
            this.rotationTextBox.Name = "rotationTextBox";
            this.rotationTextBox.Size = new System.Drawing.Size(177, 20);
            this.rotationTextBox.TabIndex = 18;
            this.rotationTextBox.Leave += new System.EventHandler(this.rotationTextBox_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Rotation";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.yTextBox);
            this.panel5.Controls.Add(this.xTextBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(61, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(177, 24);
            this.panel5.TabIndex = 12;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(90, 3);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(84, 20);
            this.yTextBox.TabIndex = 17;
            this.yTextBox.Leave += new System.EventHandler(this.yTextBox_Leave);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(3, 3);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(81, 20);
            this.xTextBox.TabIndex = 16;
            this.xTextBox.Leave += new System.EventHandler(this.xTextBox_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Location";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightTextBox.Location = new System.Drawing.Point(61, 66);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(177, 20);
            this.heightTextBox.TabIndex = 15;
            this.heightTextBox.Leave += new System.EventHandler(this.heightTextBox_Leave);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.widthTextBox.Location = new System.Drawing.Point(61, 35);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(177, 20);
            this.widthTextBox.TabIndex = 14;
            this.widthTextBox.Leave += new System.EventHandler(this.widthTextBox_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Height";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Width";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(61, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(177, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Color";
            // 
            // brushTypeDropDown
            // 
            this.brushTypeDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brushTypeDropDown.FormattingEnabled = true;
            this.brushTypeDropDown.Items.AddRange(new object[] {
            "Solid Brush",
            "Gradient Brush"});
            this.brushTypeDropDown.Location = new System.Drawing.Point(61, 283);
            this.brushTypeDropDown.Name = "brushTypeDropDown";
            this.brushTypeDropDown.Size = new System.Drawing.Size(177, 21);
            this.brushTypeDropDown.TabIndex = 24;
            this.brushTypeDropDown.Leave += new System.EventHandler(this.brushTypeDropDown_Leave);
            // 
            // shapeTree
            // 
            this.shapeTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shapeTree.Location = new System.Drawing.Point(0, 0);
            this.shapeTree.Name = "shapeTree";
            this.shapeTree.Size = new System.Drawing.Size(242, 665);
            this.shapeTree.TabIndex = 0;
            this.shapeTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.shapeTree_AfterSelect);
            this.shapeTree.MouseLeave += new System.EventHandler(this.speedMenu_Click);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 49);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1028, 665);
            this.viewPort.TabIndex = 4;
            this.viewPort.Load += new System.EventHandler(this.viewPort_Load);
            this.viewPort.Click += new System.EventHandler(this.speedMenu_Click);
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseHover += new System.EventHandler(this.viewPort_MouseHover);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 736);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.toolsPanel2);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider1)).EndInit();
            this.opacityPanel.ResumeLayout(false);
            this.opacityPanel.PerformLayout();
            this.colorGroupSelectionPanel.ResumeLayout(false);
            this.colorGroupSelectionPanel.PerformLayout();
            this.toolsPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rotationPanel.ResumeLayout(false);
            this.rotationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.opacityUpDown)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton drawEllipseButton;
        private System.Windows.Forms.ToolStripButton drawBezierButton;
        private System.Windows.Forms.ToolStripButton drawHorizontalLineButton;
        private System.Windows.Forms.ToolStripButton drawVerticalLineButton;
        private System.Windows.Forms.ToolStripButton drawTriangleButton;
        private System.Windows.Forms.ToolStripButton drawStarButton;
        private System.Windows.Forms.ToolStripButton drawPentagonButton;
        private System.Windows.Forms.ToolStripButton drawCircleButton;
        private System.Windows.Forms.ToolStripButton drawDotButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton selectPrimaryColorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton selectSecondaryColorButton;
        private System.Windows.Forms.ToolStripComboBox borderRadiusComboBox;
        private System.Windows.Forms.ToolStripComboBox colorTypeComboBox;
        private System.Windows.Forms.TrackBar slider1;
        private System.Windows.Forms.Label slider1Label;
        private System.Windows.Forms.Panel opacityPanel;
        private System.Windows.Forms.RadioButton fillColorRadioButton;
        private System.Windows.Forms.RadioButton borderColorRadioButton;
        private System.Windows.Forms.Panel toolsPanel2;
        private System.Windows.Forms.GroupBox colorGroupSelectionPanel;
        private System.Windows.Forms.TrackBar slider2;
        private System.Windows.Forms.Panel rotationPanel;
        private System.Windows.Forms.Label slider2Label;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button increaseWidthButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decreaseWidthButton;
        private System.Windows.Forms.Button decreaseHeightButton;
        private System.Windows.Forms.Button increaseHeightButton;
        private System.Windows.Forms.ToolStripButton groupButton;
        private System.Windows.Forms.ToolStripButton copyButton;
        private System.Windows.Forms.ToolStripButton pasteButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripButton cutButton;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ungroupButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton fullUngroupButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem rotateRightButton;
        private System.Windows.Forms.ToolStripMenuItem rotateLeftButton;
        private System.Windows.Forms.ToolStripMenuItem rotate180Button;
        private System.Windows.Forms.ToolStripButton dragSelectionButton;
        private System.Windows.Forms.ToolStripStatusLabel cursorLocationLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TreeView shapeTree;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rotationTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox primaryColorDropDown;
        private System.Windows.Forms.ComboBox secondaryColorDropDown;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox secondaryBorderColorDropDown;
        private System.Windows.Forms.ComboBox primaryBorderColorDropDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox opacityTypeDropDown;
        private System.Windows.Forms.NumericUpDown opacityUpDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox borderRadiusDropDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox brushTypeDropDown;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentagonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ungroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullToolStripMenuItem;
    }
}
