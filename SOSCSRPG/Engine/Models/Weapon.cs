using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        /// <summary>
        /// The minimum damage the weapon can do.
        /// </summary>
        public int MinDamage { get; set; }

        /// <summary>
        /// The maximum damage the weapon can do.
        /// </summary>
        public int MaxDamage { get; set; }

        /// <summary>
        /// Constructor for a weapon object.
        /// </summary>
        /// <param name="itemTypeID"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Weapon(int itemTypeID, string name, int price, int min, int max) : base(itemTypeID, name, price)
        {
            // Property instantiation
            MinDamage = min;
            MaxDamage = max;
        }

        /// <summary>
        /// A cloning function that creates a copy of the object. Since the GameItem class has a Clone() function, and Weapon
        /// inherits from GameItem, we need to override this non-abstract function using the "new" keyword.
        /// </summary>
        /// <returns></returns>
        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MinDamage, MaxDamage);
        }
    }
}
