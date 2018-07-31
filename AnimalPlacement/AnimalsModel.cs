using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Threading;

namespace AnimalPlacement
{
    /// <summary>
    /// Implements the model part of the application
    /// Contains the list of animals and provides interface to
    /// aggreagate functions
    /// Also responsible for invoking the controller's refresh views operation
    /// Author: R.Belovolov
    /// Date: 02/05/2016
    /// </summary>
    public class AnimalsModel
    {        
        public readonly ArrayList AnimalsList;        
        private AnimalsController theController;
        public AnimalsModel(AnimalsController aController)
        {
            AnimalsList = new ArrayList();
            theController = aController;
        }
        /// <summary>
        /// private constructor for XML serialization to work
        /// </summary>
        private AnimalsModel()
        {            
        }

        /// <summary>method: AddAnimal
        /// add animal to the model and update views
        /// </summary>
        /// <param name="anAnimal"></param>
        public void AddAnimal(Animal anAnimal)
        {
            AnimalsList.Add(anAnimal);
            UpdateViews();
        }
        
        /// <summary>
        /// A property which returns the total mass
        /// </summary>
        public int TotalMass { get 
            { 
                int totalMass = 0;
                foreach (Animal animal in AnimalsList)
                {
                    totalMass += animal.Weight;
                }
                return totalMass;
            }
        }

        /// <summary>
        /// Calculates the center of mass
        /// of model's objects
        /// </summary>
        /// <returns></returns>
        public Point CenterOfMass()
        {
            double totalMass = 0;
            double MassX = 0;
            double MassY = 0;
            foreach (Animal animal in AnimalsList)
            {
                totalMass += animal.Weight;
                MassX += animal.X * animal.Weight;
                MassY += animal.Y * animal.Weight;
            }
            if (totalMass==0)
            {
                return new Point(-100, -100);
            }
            else
            {
                int yCenter = (int)Math.Round(MassY / totalMass);
                int xCenter = (int)Math.Round(MassX / totalMass);
                return new Point(xCenter, yCenter);
            }          
        }

        /// <summary>method: DeleteAnimal
		/// delete animal and update views
		/// </summary>
		/// <param name="anAnimal"></param>
		public void DeleteAnimal(Animal anAnimal)
        {
            AnimalsList.Remove(anAnimal);
            UpdateViews();
        }

        /// <summary>method: UpdateViews
		/// refresh all views
		/// </summary>
        public void UpdateViews()
        {
            theController.UpdateViews();
        }
        
        /// <summary>
        /// Save model's animals into a file
        /// using serialization and multithreading
        /// </summary>
        public void SaveToFile()
        {
            //saving only the list of objects
            XmlSerializer s = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Animal) });
            TextWriter w = new StreamWriter(@"animalsList.xml");
            s.Serialize(w, this.AnimalsList);
            w.Close();
        }

        /// <summary>
        /// Load model's animals from a file
        /// using deserialization
        /// </summary>
        public void LoadFromFile()
        {
            XmlSerializer s = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Animal) });
            try
            {
                TextReader r = new StreamReader(@"animalsList.xml");
                ArrayList al = (ArrayList)s.Deserialize(r);
                if (al != null)
                {
                    AnimalsList.Clear();
                    AnimalsList.AddRange(al);
                    UpdateViews();
                }
                else
                {
                    throw new Exception("Loading was unsuccessfull");
                }
                r.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Save file is missing! First save your model");
            }            
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().ToString());
            }
            
        }
    }
}
