using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    /// <summary>
    /// Specifies the details of a location on the map. Note that a map is represented as a two-dimensional
    /// grid. Locations are positioned on the map using X,Y coordinate schemes.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// The X coordinate of the location.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// The Y coordinate of the location.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Name of the location.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A description of the location that will be displayed to the player.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The image associated with the location.
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// Default constructor. Calls the next constructor, populating the data with default values.
        /// </summary>
        public Location() : this(0, 0, "Home", "Your starting location", "/Engine;component/Images/Locations/home.png") { }


        /// <summary>
        /// Constructor that creates a location given specified values.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="imageURL"></param>
        public Location(int x, int y, string name, string description, string imageURL)
        {
            // Property initialization
            X = x;
            Y = y;
            Name = name;
            Description = description;
            ImageName = imageURL;
        }
    }
}
