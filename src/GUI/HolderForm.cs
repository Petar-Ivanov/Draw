using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Draw.src.GUI
{
    /// <summary>
    /// Прозорец рамка, който държи прозорците на отделните модели, с които работим, 
    /// както и контролите за създаване, премахване и дублиране на модели.
    /// </summary>
    public partial class HolderForm : Form
    {
        
        public HolderForm()
        {
            InitializeComponent();
        }

        private void HolderForm_Load(object sender, EventArgs e)
        {
            newModelButton_Click(sender, e);
        }

        private void newModelButton_Click(object sender, EventArgs e)
        {
            CreateNewModelForm();
        }

        /// <summary>
        /// Създава се или нов прозорец с нов празен модел или нов прозорец, 
        /// с модел копие на вече съществуващ (ако е подаден като параметър), 
        /// както и се добавят опции за премахването и дублирането му в 
        /// менюто на прозореца рамка.
        /// </summary>
        /// <param name="shapeList"></param>
        public void CreateNewModelForm(List<Shape> shapeList = null)
        {
            string modelName = Interaction.InputBox("Enter the name of the model.", "New Model", "");
            if (modelName.Trim(' ') == "") return;

            // Създаване на нов прозорец (и модел).
            MainForm form = new MainForm();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;

            TabPage tabPage;

            tabPage = new TabPage();
            tabControl1.TabPages.Add(tabPage);

            tabPage.Text = modelName;
            tabPage.Controls.Add(form);
            
            if (shapeList != null) form.SetFormModel(shapeList);

            // Създаване на бутон за премахване на новия модел / прозорец в менюто на рамката.
            ToolStripMenuItem removeDropDownButton = new ToolStripMenuItem(modelName, null, (newSender, newE) =>
            {
                tabControl1.TabPages.Remove(tabPage);

                ToolStripMenuItem clickedItem = newSender as ToolStripMenuItem;

                if (clickedItem != null)
                {
                    removeModelButton.DropDownItems.Remove(clickedItem);
                }
            });

            // Създаване на бутон за дублиране на новия модел / прозорец в менюто на рамката.
            ToolStripMenuItem copyDropDownButton = new ToolStripMenuItem(modelName, null, (newSender, newE) =>
            {
                CreateNewModelForm(form.GetFormModel());

            });

            removeModelButton.DropDownItems.Add(removeDropDownButton);
            copyModelButton.DropDownItems.Add(copyDropDownButton);

            form.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void removeModelButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /// <summary>
        /// При клик показва списък с бутони, съотстветващ 
        /// на моделите, чрез които могат да се създадат
        /// модели, копия.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyModelButton_Click(object sender, EventArgs e)
        {
            List<string> tabNames = new List<string>();
            List<ToolStripMenuItem> buttonsToRemove = new List<ToolStripMenuItem>();

            foreach (TabPage item in tabControl1.TabPages)
            {
                tabNames.Add(item.Text);
            }

            foreach (ToolStripMenuItem item in copyModelButton.DropDownItems)
            {
                if (tabNames.Contains(item.Text) == false)
                {
                    buttonsToRemove.Add(item);
                }
            }

            foreach(ToolStripMenuItem item in buttonsToRemove)
            {
                copyModelButton.DropDownItems.Remove(item);
            }
        }
    }
}
