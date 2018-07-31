using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace AnimalPlacement
{
    /// <summary>
    /// Graphic view of the application, allows to view,
    /// add, modify and delete animals from the platform
    /// Author: R.Belovolov
    /// Date: 02/05/2016
    /// </summary>
    public partial class GraphicView : Form, IAnimalView
    {
        private AnimalsModel myModel;

        bool dragging;
        Animal topShape; //  variable for selected shape
        Animal editShape; // variable for shape to edit

        // variables for mouse position
        Point lastPosition = new Point(0, 0);
        Point currentPosition = new Point(0, 0);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="model"></param>
        public GraphicView(AnimalsModel model)
        {
            InitializeComponent();
            myModel = model;
        }

        /// <summary>
        /// Refreshes this particular form based on the model's state
        /// </summary>
        public void RefreshView()
        {
            // clear drawing panel
            clearPanel();
            Graphics g = this.pnlDraw.CreateGraphics();
            // draw all animals in array
            foreach (Animal a in myModel.AnimalsList.Cast<Animal>())
            {
                a.Display(g);
            }
            //draw the center of mass
            
            Brush br = new SolidBrush(Color.Red);
            int pointSize = 10;
            g.FillEllipse(br,
                myModel.CenterOfMass().X + 30 - pointSize/2,
                myModel.CenterOfMass().Y + 30 - pointSize/2, 
                pointSize, pointSize);
            DrawAxes();
        }

        /// <summary>method: btnClearInput_Click
		/// clear user input fields
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClearInput_Click(object sender, System.EventArgs e)
        {
            numWeight.Value = numWeight.Minimum;
            numYpos.Value = numYpos.Minimum;
            numXpos.Value = numXpos.Minimum;
        }

        /// <summary>
        /// Opens the panel for adding a new object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenAddObject_Click(object sender, EventArgs e)
        {
            pnlActions.Enabled = false;
            pnlAddObject.Show();
        }

        /// <summary> method: btnAddObject_Click
        /// adds shape to model based on parameters entered by user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddObject_Click(object sender, EventArgs e)
        {
            // variables required for Animal object
            int X = (int)numXpos.Value;
            int Y = (int)numYpos.Value;
            int Weight = (int)numWeight.Value;            
            Animal anAnimal;

            pnlAddObject.Hide();
            pnlActions.Enabled = true;

            if (rbHuman.Checked) {
                Gender g = (Gender)lbGender.SelectedItem;
                anAnimal = new Human(g, X, Y, Weight);
                myModel.AddAnimal(anAnimal);
            }                  
            else if (rbCat.Checked)
            {
                Suit s = (Suit)lbSuit.SelectedItem;
                anAnimal = new Cat(s, X, Y, Weight);
                myModel.AddAnimal(anAnimal);
            }
            else if (rbDog.Checked)
            { 
                Breed b = (Breed)lbBreed.SelectedItem;
                anAnimal = new Dog(b, X, Y, Weight);
                myModel.AddAnimal(anAnimal);
            }
            else
            {
                MessageBox.Show("No object type is checked, something went wrong");
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
        /// Handles cancelling new object creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAdding_Click(object sender, EventArgs e)
        {
            pnlAddObject.Hide();
            pnlActions.Enabled = true;
            myModel.UpdateViews();
        }

        /// <summary>
        /// Handles object type checkbox changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbObjectType_Changed(object sender, EventArgs e)
        {            
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "rbHuman":
                        gbGender.Show();
                        gbSuit.Hide();
                        gbBreed.Hide();
                        numWeight.Value = Human.AvgWeight;
                        break;
                    case "rbCat":
                        gbSuit.Show();
                        gbGender.Hide();
                        gbBreed.Hide();
                        numWeight.Value = Cat.AvgWeight;
                        break;
                    case "rbDog":
                        gbBreed.Show();
                        gbGender.Hide();
                        gbSuit.Hide();
                        numWeight.Value = Dog.AvgWeight;
                        break;
                }
            }
        }

        /// <summary>
        /// Does initialization of some of the controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewForm2_Load(object sender, EventArgs e)
        {
            //initialize select boxes
            lbGender.DataSource = lbEditGender.DataSource = Enum.GetValues(typeof(Gender)).Cast<Gender>();
            lbBreed.DataSource = lbEditBreed.DataSource = Enum.GetValues(typeof(Breed)).Cast<Breed>();
            lbSuit.DataSource = lbEditSuit.DataSource = Enum.GetValues(typeof(Suit)).Cast<Suit>();

            //handle initial checkbox selection
            foreach (var control in pnlObjectType.Controls)
            {
                //handle if not checkbox is put on the panel
                try
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Checked)
                    {
                        switch (rb.Name)
                        {
                            case "rbHuman":
                                gbGender.Show();
                                numWeight.Value = Human.AvgWeight;
                                break;
                            case "rbCat":
                                gbSuit.Show();
                                numWeight.Value = Cat.AvgWeight;
                                break;
                            case "rbDog":
                                gbBreed.Show();
                                numWeight.Value = Dog.AvgWeight;
                                break;
                        }
                    }
                }
                catch (InvalidCastException)
                {
                    continue;
                }
            }
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
            g1.DrawLine(Pens.Black, padding, pnlXaxis.Height-1, pnlXaxis.Width, pnlXaxis.Height-1);
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
            g2.DrawLine(Pens.Black, pnlYaxis.Width-1, padding, pnlYaxis.Width-1, pnlYaxis.Height);
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

        /// <summary>
        /// Handles deletion of objects via context menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (topShape != null)
            {               
                // delete selected animal and redisplay remaining ones
                myModel.DeleteAnimal(topShape);
                myModel.UpdateViews();
            }            
        }
        /// <summary>
        /// Handle mouse hover effect and drag and drop
        /// Initially copied from Moodle example, but significantly refactored
        /// to prevent excessive updating
        /// and added boundaries restriction to prevent dragging object out of panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            // set last position to current position
            lastPosition = currentPosition;
            // set current position to mouse position
            currentPosition = new Point(e.X, e.Y);
            // calculate how far mouse has moved 
            int xMove = currentPosition.X - lastPosition.X;
            int yMove = currentPosition.Y - lastPosition.Y;

            if (!dragging) // mouse not down 
            { 
                //topShape = null;
                bool needsDisplay = false;

                // graphics object to draw shapes when required
                Graphics g = pnlDraw.CreateGraphics();

                //if there was a hovered shape, but now mouse left the area OR
                //if there was no hovered shape, but now one may have become
                if (topShape==null || (topShape != null && !topShape.HitTest(new Point(e.X, e.Y))))
                {
                    if (topShape!=null)
                    {
                        topShape = null;
                        needsDisplay = true;
                    }                   

                    //check if some animal is now hovered
                    foreach (Animal s in myModel.AnimalsList.Cast<Animal>())
                    {
                        // check if mouse is over shape
                        if (s.HitTest(new Point(e.X, e.Y)))
                        {
                            // if so make shape topShape and highlight it
                            topShape = s;
                            s.Highlight = true;
                            needsDisplay = true;
                        }
                        else
                        {
                            s.Highlight = false;
                        }
                    }
                }

                //if needsDisplay flag was raised, update the views
                if (needsDisplay)
                {
                    myModel.UpdateViews();
                }
            }
            else // mouse is down
            {
                // reset position of selected shape by value of mouse move 
                if ((topShape.X + xMove)<=400 && (topShape.X + xMove) >= 0)
                    topShape.X += xMove;
                if ((topShape.Y + yMove) <= 400 && (topShape.Y + yMove) >= 0)
                    topShape.Y += yMove;
                myModel.UpdateViews();
            }
        }

        /// <summary>
        /// Part of the drag and drop functionality. Handles mouse button release
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            // clear drawOn panel
            clearPanel();
            // create arrayList of shapes from model and convert to array of shapes
            ArrayList theAnimalsList = myModel.AnimalsList;
            Animal[] theShapes = (Animal[])theAnimalsList.ToArray(typeof(Animal));
            // graphics object to draw selected shape
            Graphics g = pnlDraw.CreateGraphics();

            // check if shape selected and if so display
            if (topShape != null)
            {
                theShapes[0] = topShape;
                topShape.Display(g);
            }
            myModel.UpdateViews();
        }

        /// <summary>
        /// Part of the drag and drop functionality. Handles mouse button hold
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (topShape != null)
                dragging = true;
        }

        /// <summary>
        /// Edit function in context menu. Opens editting panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (topShape!=null)
            {
                editShape = topShape;
                //block input
                pnlDraw.Enabled = false;
                pnlActions.Enabled = false;
                //open edit panel
                pnlEdit.Show();
                numEditWeight.Value = editShape.Weight;
                if (editShape.GetType() == typeof(Dog))
                    gbEditBreed.Show();
                else if (editShape.GetType() == typeof(Cat))
                    gbEditSuit.Show();
                else if (editShape.GetType() == typeof(Human))
                    gbEditGender.Show();                
            }
        }

        /// <summary>
        /// Refresh page function in context menu. Makes the model to refresh associated views
        /// </summary>
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myModel.UpdateViews();
        }

        /// <summary>
        /// Submits and finalizes the changes, made through the editting panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            editShape.Weight = (int)numEditWeight.Value;
            if (editShape.GetType() == typeof(Dog))
                ((Dog)editShape).Breed = (Breed)lbEditBreed.SelectedItem;
            else if (editShape.GetType() == typeof(Cat))
                ((Cat)editShape).Suit = (Suit)lbEditSuit.SelectedItem;
            else if (editShape.GetType() == typeof(Human))
                ((Human)editShape).Gender = (Gender)lbEditGender.SelectedItem;

            //repetitive block
            gbEditBreed.Hide();
            gbEditGender.Hide();
            gbEditSuit.Hide();
            pnlEdit.Hide();

            //unblock input
            pnlDraw.Enabled = true;
            pnlActions.Enabled = true;

            myModel.UpdateViews();
        }

        /// <summary>
        /// Handles cancellation of editting, closing the editting panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            
            //repetitive block
            gbEditBreed.Hide();
            gbEditGender.Hide();
            gbEditSuit.Hide();
            pnlEdit.Hide();

            //unblock input
            pnlDraw.Enabled = true;
            pnlActions.Enabled = true;

            editShape = null;
        }

        /// <summary>
        /// Clears input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearInput_Click_1(object sender, EventArgs e)
        {
            numYpos.Value = numYpos.Minimum;
            numXpos.Value = numXpos.Minimum;
            numWeight.Value = numWeight.Minimum;
        }

        /// <summary>
        /// Refreshes the form in multiple situations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            RefreshView();
        }

        /// <summary>
        /// Handles initiating unique behaviour in context menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uniqueBehaviourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (topShape!=null)
            {
                if (topShape.GetType() == typeof(Dog))
                    ((Dog)topShape).Bark();
                else if (topShape.GetType() == typeof(Human))
                    ((Human)topShape).Greet();
                else if (topShape.GetType() == typeof(Cat))
                {
                    ((Cat)topShape).JumpRandomly();
                    myModel.UpdateViews();
                }
                    
            }
        }        
        /// <summary>
        /// Saving current model's object list in a separate thread
        /// to avoid blocking user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            ThreadStart job = new ThreadStart(myModel.SaveToFile);
            Thread aWorker = new Thread(job);
            aWorker.Start();
            //myModel.SaveToFile();
        }

        /// <summary>
        /// Loading the object list from file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadModel_Click(object sender, EventArgs e)
        {
            myModel.LoadFromFile();
        }
    }
}
