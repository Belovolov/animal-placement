using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AnimalPlacement
{
    /// <summary>
    /// A subclass of Animal that represents a Human
    /// Author: R.Belovolov
    /// Date: 02/05/2016
    /// </summary>
    public class Human : Animal
    {
        public Gender Gender;
        public static int AvgWeight = 70;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="weight"></param>
        public Human(Gender gender, int x, int y, int weight) : base(x, y, weight)
        {
            Gender = gender;
        }

        /// <summary>
        /// private constructor for XML serialization
        /// </summary>
        private Human()
        {            
        }
        
        /// <summary>
        /// implements unique behavior in the form of greeting
        /// </summary>
        public void Greet()
        {
            MessageBox.Show("Hello!");
        }

        /// <summary>
        /// String conversion for text form 
        /// </summary>
        /// <returns></returns>       
        public override string ToString()
        {
            return $"Human: {Enum.GetName(typeof(Gender), Gender)}, weight: {Weight}, at ({X};{Y})";
        }
        
        /// <summary>
        /// Defines the way instances should be displayed
        /// </summary>
        /// <param name="g"></param>
        public override void Display(Graphics g)
        {
            Image icon = (Gender == Gender.Male) ? Properties.Resources.human_male_120x120 :
                         (Gender == Gender.Female) ? Properties.Resources.human_female_120x120 : null;
            Rectangle r = new Rectangle(X, Y, ICON_SIZE, ICON_SIZE);
            g.DrawImage(icon, r);
            if (Highlight)
            {
                DrawBorder(g);
            }
        }        
    }
}
