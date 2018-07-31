using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalPlacement
{
    /// <summary>
    /// Read-only view of the application, 
    /// allows to view, applying various filters
    /// Author: R.Belovolov
    /// Date: 02/05/2016
    /// </summary>
    public partial class ReadOnlyView : Form, IAnimalView
    {
        public Type animalType;
        public readonly AnimalsModel myModel;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="model"></param>
        public ReadOnlyView(AnimalsModel model)
        {
            InitializeComponent();
            myModel = model;
        }

        /// <summary>
        /// Refresh view based on the model's state
        /// </summary>
        public void RefreshView()
        {
            // clear drawOn panel
            clearPanel();
            IEnumerable<Animal> theAnimals = myModel.AnimalsList.Cast<Animal>();
            if (animalType!=null)
            {
                theAnimals = theAnimals.Where(a => a.GetType() == animalType);
            }
                
            Graphics g = this.pnlDraw.CreateGraphics();
            // draw all animals in array
            foreach (Animal a in theAnimals)
            {
                a.Display(g);
            }
            //draw the center of mass
            Brush br = new SolidBrush(Color.Red);
            int pointSize = 10;
            g.FillEllipse(br,
                myModel.CenterOfMass().X + 30 - pointSize / 2,
                myModel.CenterOfMass().Y + 30 - pointSize / 2,
                pointSize, pointSize);
            DrawAxes();
        }

        /// <summary>
        /// Draws horizontal and vertical axes
        /// </summary>
        private void DrawAxes()
        {
            int height = Configuration.PANEL_H;
            int width = Configuration.PANEL_W;
            int padding = Configuration.IMAGE_SIZE / 2;
            //draw axes            
            Graphics g1 = pnlXaxis.CreateGraphics();
            g1.DrawLine(Pens.Black, padding, pnlXaxis.Height - 1, pnlXaxis.Width, pnlXaxis.Height - 1);
            for (int i = 0; i <= width; i = i + Configuration.DIVISION)
            {
                g1.DrawLine(Pens.Black, i + padding, 0, i + padding, pnlXaxis.Height);
                g1.DrawString(i.ToString(),
                    SystemFonts.DefaultFont,
                    Brushes.Black,
                    i + padding + 2,
                    pnlXaxis.Height / 2 - 2);
            }

            Graphics g2 = pnlYaxis.CreateGraphics();
            g2.DrawLine(Pens.Black, pnlYaxis.Width - 1, padding, pnlYaxis.Width - 1, pnlYaxis.Height);
            for (int i = 0; i <= height; i = i + Configuration.DIVISION)
            {
                g2.DrawLine(Pens.Black, 0, i + padding, pnlYaxis.Width, i + padding);
                g2.DrawString(i.ToString(),
                    SystemFonts.DefaultFont,
                    Brushes.Black,
                    0,
                    i + padding + 2);
            }
        }

        /// <summary>method: clearPanel
		/// clear all shapes from display on panel
		/// </summary>
        private void clearPanel()
        {
            pnlDraw.CreateGraphics().Clear(pnlDraw.BackColor);
        }

        /// <summary>
        /// Initializes combo box on form start with types of filters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewForm3_Load(object sender, EventArgs e)
        {
            cmbShowFilter.DataSource = Enum.GetValues(typeof(FilterType)).Cast<FilterType>();
            cmbShowFilter.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles filtering type selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbShowFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((FilterType)cmbShowFilter.SelectedItem == FilterType.All)
                animalType = null;
            else if ((FilterType)cmbShowFilter.SelectedItem == FilterType.Human)
                animalType = typeof(Human);
            else if ((FilterType)cmbShowFilter.SelectedItem == FilterType.Dog)
                animalType = typeof(Dog);
            else if ((FilterType)cmbShowFilter.SelectedItem == FilterType.Cat)
                animalType = typeof(Cat);
            RefreshView();
        }

        /// <summary>
        /// Refreshes the form in multiple situations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewForm3_Paint(object sender, PaintEventArgs e)
        {
            RefreshView();
        }
    }
}
