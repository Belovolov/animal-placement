using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Serialization;

namespace AnimalPlacement
{
    /// <summary>
    /// A superclass of Animal that generalizes the objects
    /// that can be placed on the main platform
    /// for calculation of the center of mass
    /// Author: R.Belovolov
    /// Date: 02/05/2016
    /// </summary>
    [XmlInclude(typeof(Human))]
    [XmlInclude(typeof(Dog))]
    [XmlInclude(typeof(Cat))]
    public abstract class Animal
    {
        public int X;
        public int Y;
        public int Weight;
        public static int ICON_SIZE = Configuration.IMAGE_SIZE;

        [XmlIgnore]
        public bool Highlight;
        /// <summary>
        /// Primary constructor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="weight"></param>
        public Animal(int x, int y, int weight)
        {
            X = x;
            Y = y;
            Weight = weight;
        }
        /// <summary>
        /// Constructor for XML serialization
        /// </summary>
        public Animal()
        {            
        }       

        /// <summary>
        /// This property returns a rectangle which
        /// outlines the border of the object
        /// </summary>
        private Rectangle Border { get
        {
            return new Rectangle(X, Y, Configuration.IMAGE_SIZE, Configuration.IMAGE_SIZE);
        } }
        
        /// <summary>
        /// Draws the border around the object
        /// </summary>
        /// <param name="g"></param>
        public void DrawBorder(Graphics g)
        {
            Pen p = new Pen(Brushes.Brown, 3);
            g.DrawRectangle(p, Border);
        }

        /// <summary>
        /// Checks if the given point falls
        /// into the area occupied by the object
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool HitTest(Point p)
        {
            return Border.Contains(p);
        }
        public abstract void Display(Graphics g);
    }
}
