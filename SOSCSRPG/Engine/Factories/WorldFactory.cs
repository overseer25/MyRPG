using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    /// <summary>
    /// Builds Worlds. This class is internal, meaning it can only be used by the Engine project.
    /// </summary>
    internal class WorldFactory
    {
        /// <summary>
        /// Function used to build a new World object.
        /// </summary>
        /// <returns></returns>
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, 0, "Home", "Your starting location", "/Engine;component/Images/Locations/home.png");
            newWorld.AddLocation(1, 0, "Town", "The center of town", "/Engine;component/Images/Locations/town.png");
            newWorld.AddLocation(2, 0, "Shop", "Purchase things here", "/Engine;component/Images/Locations/shop.png");

            return newWorld;
        }
    }
}
