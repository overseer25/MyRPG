using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        /// <summary>
        /// Unique ID for the item
        /// </summary>
        public int ItemTypeID { get; set; }

        /// <summary>
        /// Name for the item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the item in the game economy
        /// </summary>
        public int Price { get; set; }

        public GameItem(int itemTypeID, string name, int price)
        {
            // Property instantiation
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
        }

        /// <summary>
        /// A cloning function that creates a copy of the object.
        /// </summary>
        /// <returns></returns>
        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price);
        }
    }
}
