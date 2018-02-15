using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    /// <summary>
    /// Creates game items
    /// </summary>
    public static class ItemFactory
    {
        private static List<GameItem> _gameItems;

        /// <summary>
        /// Initialization function for the static class.
        /// </summary>
        static ItemFactory()
        {
            _gameItems = new List<GameItem>();

            _gameItems.Add(new Weapon(1001, "Blunt Stick", 1, 0, 1));
            _gameItems.Add(new Weapon(1002, "Broken Sword", 2, 1, 2));
        }

        /// <summary>
        /// Generates a game item based on the Item ID.
        /// </summary>
        /// <returns></returns>
        public static GameItem CreateGameItem(int itemTypeID)
        {
            // Queries the list for the GameItem that has the ID equal to the passed in ID. Returns null otherwise.
            GameItem gameItem = _gameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);


            // Return a copy of this object so that it is it's own unique object. This ensures that adding modifications to the
            // item will not affect all other items of this type.
            if(gameItem != null)
            {
                return gameItem.Clone();
            }

            return null; // Return null otherwise.
        }
    }
}
