using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AnimalPlacement
{
    /// <summary>
    /// A subclass of Animal that represents a dog - domestic animal
    /// Author: R.Belovolov
    /// Date: 02/05/2016
    /// </summary>
    public class Dog : Animal
    {
        public Breed Breed;
        public static int AvgWeight = 15;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="breed"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="weight"></param>
        public Dog(Breed breed, int x, int y, int weight) : base(x, y, weight)
        {
            Breed = breed;
        }

        /// <summary>
        /// private constructor for XML serialization
        /// </summary>
        private Dog()
        {            
        }

        /// <summary>
        /// This method plays a sound of a dog
        /// </summary>
        public void Bark()
        {
            var barkSound = (Breed == Breed.Labrador) ? Properties.Resources.dog_big :
                (Breed == Breed.Dachshund) ? Properties.Resources.dog_medium :
                (Breed == Breed.ToyTerrier) ? Properties.Resources.dog_small : null;
            SoundPlayer sp = new SoundPlayer(barkSound);
            sp.Play();
        }

        /// <summary>
        /// String conversion for text form
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Dog: {Enum.GetName(typeof(Breed), Breed)}, weight: {Weight}, at ({X};{Y})";
        }
        
        /// <summary>
        /// Defines the way instances should be displayed
        /// </summary>
        /// <param name="g"></param>
        public override void Display(Graphics g)
        {
            Image icon = (Breed == Breed.Dachshund) ? Properties.Resources.dog_dachshund_110x110 :
                         (Breed == Breed.ToyTerrier) ? Properties.Resources.toy_terrier_100x100 :
                         (Breed == Breed.Labrador) ? Properties.Resources.labrador_120x120 : null;            
            Rectangle r = new Rectangle(X, Y, ICON_SIZE, ICON_SIZE);
            g.DrawImage(icon, r);
            if (Highlight)
            {
                DrawBorder(g);
            }
        }        
    }
}
