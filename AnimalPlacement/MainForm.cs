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
    /// Main form. Starts all the MVC components
    /// Author: R.Belovolov
    /// Date: 02/05/2016
    /// </summary>
    public partial class MainForm : Form
    {
        private AnimalsModel theModel;
        private AnimalsController theController;
        private TextView myViewForm1;
        private GraphicView myViewForm2;
        private ReadOnlyView myViewForm3;
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set up MVC components and run them
        /// </summary>
        private void CompleteSetUp()
        {
            // make controller
            theController = new AnimalsController();
            // make model
            theModel = new AnimalsModel(theController);
            // make views
            myViewForm1 = new TextView(theModel);
            myViewForm2 = new GraphicView(theModel);
            myViewForm3 = new ReadOnlyView(theModel);

            theController.AddView(myViewForm1);
            theController.AddView(myViewForm2);
            theController.AddView(myViewForm3);

            //show views
            myViewForm3.Show();
            myViewForm2.Show();
            myViewForm1.Show();
            this.Visible = true;
        }

        /// <summary>
        /// Form load handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.CompleteSetUp();
        }
    }
}
