using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        // Contains the list of locations for the world.
        private List<Location> _locations;

        /// <summary>
        /// Default constructor
        /// </summary>
        public World()
        {
            _locations = new List<Location>();
        }

        /// <summary>
        /// Adds a location to the world. Marked as internal, as the only other class we want to add locations is the
        /// WorldFactory class.
        /// </summary>
        internal void AddLocation(int x, int y, string name, string description, string imageURL)
        {
            Location location = new Location(x, y, name, description, imageURL); // Created the location using the parameters.

            _locations.Add(location); // Adds the location
        }

        /// <summary>
        /// Gets the location at the given x,y coordinates. Returns a null value if the x and y are invalid, or if there
        /// is no location at the x,y coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Location GetLocation(int x, int y)
        {
            foreach(Location location in _locations)
            {
                if(location.X == x && location.Y == y) { return location; }
            }

            return null; // Return null if no location found.
        }
    }
}
