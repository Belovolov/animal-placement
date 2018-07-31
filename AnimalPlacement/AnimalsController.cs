using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace AnimalPlacement
{
    /// <summary>
    /// An interface for forms that are used as views
    /// </summary>
    public interface IAnimalView
    {
        void RefreshView();
    }
    /// <summary>
    /// Represents the controller part of the MVC pattern
    /// Author: R.Belovolov
    /// Date: 02/05/2016
    /// </summary>
    public class AnimalsController
    {
        private List<IAnimalView> ViewList;

        // constructor
        public AnimalsController()
        {
            ViewList = new List<IAnimalView>();
        }

        /// <summary>method: AddView
        /// add view to viewlist
        /// </summary>
        /// <param name="aView"></param>
        public void AddView(IAnimalView aView)
        {
            ViewList.Add(aView);
        }

        /// <summary>method: UpdateViews
        /// update each view 
        /// </summary>
        public void UpdateViews()
        {
            foreach (IAnimalView v in ViewList)
            {
                //skip forms that have been closed                
                try
                {
                    v.RefreshView();
                }
                catch (ObjectDisposedException)
                {
                    continue;                    
                }                    
            }
        }
    }
}
