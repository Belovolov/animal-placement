using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace AnimalPlacement
{
    /// <summary>
    /// A subclass of Animal that represents a cat - domestic animal
    /// Author: R.Belovolov
    /// Date: 02/05/2016
    /// </summary>
    public class Cat : Animal
    {
        public static int JUMP_RADIUS = 50;
        public static int AvgWeight = 5;
        public Suit Suit;
        
        /// <summary>
        /// Primary constructor
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="weight"></param>
        public Cat(Suit suit, int x, int y, int weight) : base(x, y, weight)
        {
            Suit = suit;
        }
        
        /// <summary>
        /// Private constructor for XML serialization
        /// </summary>
        private Cat()
        {           
        }

        /// <summary>
        /// changes the position of the cat randomly
        /// </summary>
        public void JumpRandomly()
        {
            Random r = new Random();
            int angle = r.Next(0, 360); //360 degrees - all 2D directions
            int xDelta = (int)Math.Round(JUMP_RADIUS * Math.Cos(((double)angle / 180) * Math.PI));
            int yDelta = (int)Math.Round(JUMP_RADIUS * Math.Sin(((double)angle / 180) * Math.PI));

            X = NormalizeValue(Configuration.PANEL_W, 0, X + xDelta);
            Y = NormalizeValue(Configuration.PANEL_H, 0, Y + yDelta);

        }        
        /// <summary>
        /// String conversion for text form
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Cat: {Enum.GetName(typeof(Suit),Suit)}, weight: {Weight}, at ({X};{Y})";
        }

        /// <summary>
        /// Defines the way instance should be displayed
        /// </summary>
        /// <param name="g"></param>
        public override void Display(Graphics g)
        {
            Image icon = (Suit == Suit.Ginger) ? Properties.Resources.cat_ginger100x100 :
                         (Suit == Suit.Black) ? Properties.Resources.cat_black_100x100 :
                         (Suit == Suit.Grey) ? Properties.Resources.cat_grey_100x100 : null;
            Rectangle r = new Rectangle(X, Y, ICON_SIZE, ICON_SIZE);
            g.DrawImage(icon, r);
            if (Highlight)
            {
                DrawBorder(g);
            }
        }


        /// <summary>
        /// Auxiliary method to restric the given value 
        /// inside given boundaries. Used for random jumping
        /// </summary>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        private int NormalizeValue(int max, int min, int source) 
        {            
            var x = (source > max) ? max : source;
            x = (source < 0) ? min : source;
            return x;
        }
    }
}
