using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace AnimalPlacement
{
    /// <summary>
    /// Text view of the application, allows to view,
    /// add, modify and delete animals from the platform in the text form
    /// Author: R.Belovolov
    /// Date: 02/05/2016
    /// </summary>
    public partial class TextView : Form, IAnimalView
    {
        public readonly AnimalsModel myModel;
        private Animal selected;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="model"></param>
        public TextView(AnimalsModel model)
        {
            InitializeComponent();
            myModel = model;
        }

        /// <summary>
        /// Refreshes this particular form based on the model's state
        /// </summary>
        public void RefreshView()
        {
            // clear listBox
            lbObjects.Items.Clear();
            IEnumerable<Animal> animalList = myModel.AnimalsList.Cast<Animal>();
            // add each animal in the array to the listBox
            foreach (Animal a in animalList)
            {
                lbObjects.Items.Add(a);                
            }
            if (animalList.Count()>0)
            {
                lblCenterOfMass.Text = $"Center of mass is at: ({myModel.CenterOfMass().X};{myModel.CenterOfMass().Y}), " +
                    $"total mass is {myModel.TotalMass}";
            }
            else
            {
                lblCenterOfMass.Text = "";
            }
        }

        /// <summary>
        /// Clears input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearInput_Click(object sender, EventArgs e)
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
            pnlActionMain.Enabled = false;
            pnlAddObject.Show();
        }

        /// <summary>
        /// Updates other forms when this form moves
        /// otherwise it erases drawings on other forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewForm1_Move(object sender, EventArgs e)
        {
            myModel.UpdateViews();
        }

        /// <summary>
        /// Handles deletion of a selected object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbObjects.SelectedItem != null)
            {
                selected = lbObjects.SelectedItem as Animal;
                myModel.DeleteAnimal(selected);
                pnlActions.Hide();
            }
        }

        /// <summary>
        /// Opens editting panel for the selected object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbObjects.SelectedItem != null)
            {
                selected = lbObjects.SelectedItem as Animal;
                numEditXpos.Value = selected.X;
                numEditYpos.Value = selected.Y;
                numEditWeight.Value = selected.Weight;
                if (selected.GetType() == typeof(Dog))
                    gbEditBreed.Show();
                else if (selected.GetType() == typeof(Cat))
                    gbEditSuit.Show();
                else if (selected.GetType() == typeof(Human))
                    gbEditGender.Show();

                //block input
                lbObjects.Enabled = false;
                pnlActionMain.Enabled = false;

                pnlEdit.Show();
            }
        }

        /// <summary>
        /// Handles surfing over list box items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = (sender as ListBox).SelectedIndex;
            if ((sender as ListBox).SelectedIndex!=-1)
                pnlActions.Show();
            else
                pnlActions.Hide();
        }

        /// <summary>
        /// Submits and finalizes the changes, made through the editting panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            selected.X = (int)numEditXpos.Value;
            selected.Y = (int)numEditYpos.Value;
            selected.Weight = (int)numEditWeight.Value;
            if (selected.GetType() == typeof(Dog))
                ((Dog)selected).Breed = (Breed)lbEditBreed.SelectedItem;
            else if (selected.GetType() == typeof(Cat))
                ((Cat)selected).Suit = (Suit)lbEditSuit.SelectedItem;
            else if (selected.GetType() == typeof(Human))
                ((Human)selected).Gender = (Gender)lbEditGender.SelectedItem;

            //repetitive block
            gbEditSuit.Hide();
            gbEditGender.Hide();
            gbEditBreed.Hide();
            pnlEdit.Hide();

            //unblock input
            lbObjects.Enabled = true;
            pnlActionMain.Enabled = true;
            pnlActions.Hide();

            myModel.UpdateViews();
        }

        /// <summary>
        /// Handles cancelation of editting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            //unblock input
            lbObjects.Enabled = true;
            pnlActionMain.Enabled = true;            

            //repetitive block
            gbEditSuit.Hide();
            gbEditGender.Hide();
            gbEditBreed.Hide();
            pnlEdit.Hide();
        }

        /// <summary>
        /// Initilize controls on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewForm1_Load(object sender, EventArgs e)
        {
            lbGender.DataSource = lbEditGender.DataSource = Enum.GetValues(typeof(Gender)).Cast<Gender>();
            lbBreed.DataSource = lbEditBreed.DataSource = Enum.GetValues(typeof(Breed)).Cast<Breed>();
            lbSuit.DataSource = lbEditSuit.DataSource = Enum.GetValues(typeof(Suit)).Cast<Suit>();
            //handle initial checkbox selection
            foreach (var control in pnlObjectType.Controls)
            {
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
        /// Closes adding new object when cancelled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void btnCancelAdding_Click_1(object sender, EventArgs e)
        {
            pnlAddObject.Hide();
            pnlActionMain.Enabled = true;
            myModel.UpdateViews();
        }

        /// <summary>
        /// Flushes inputs to the default minimal state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearInput_Click_1(object sender, EventArgs e)
        {
            numYpos.Value = numXpos.Minimum;
            numXpos.Value = numXpos.Minimum;
            numWeight.Value = numWeight.Minimum;
        }

        /// <summary>
        /// Submits new object to the model after 
        /// filling the corresponding panel's inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddObject_Click_1(object sender, EventArgs e)
        {
            // variables required for Animal object
            int X = (int)numXpos.Value;
            int Y = (int)numYpos.Value;
            int Weight = (int)numWeight.Value;
            Animal anAnimal;

            pnlAddObject.Hide();
            pnlActionMain.Enabled = true;

            if (rbHuman.Checked)
            {
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
    }
}
