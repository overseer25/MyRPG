using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    /// <summary>
    /// This class is used for fetch quests, where the player is asked to retrieve a number of a given item.
    /// </summary>
    public class ItemQuantity
    {
        /// <summary>
        /// The ID of the item.
        /// </summary>
        public int ItemID { get; set; }

        /// <summary>
        /// How many of the item are required.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Constructor for the class.
        /// </summary>
        /// <param name="itemID"></param>
        /// <param name="quantity"></param>
        public ItemQuantity(int itemID, int quantity)
        {
            ItemID = itemID;
            Quantity = quantity;
        }
    }
}
