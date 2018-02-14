using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    /// <summary>
    /// Manages the current game being played by the player. Contains a Player object.
    /// </summary>
    public class GameSession
    {
        /// <summary>
        /// Contains the current player of the game session.
        /// </summary>
        public Player CurrentPlayer { get; set; }

        /// <summary>
        /// Contains the current location the player is in.
        /// </summary>
        public Location CurrentLocation { get; set; }

        /// <summary>
        /// Contains the current world the player is in. This allows for multiple worlds to exist.
        /// </summary>
        public World CurrentWorld { get; set; }

        /// <summary>
        /// Default constructor for a GameSession object.
        /// </summary>
        public GameSession()
        {
            // Create the world
            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentPlayer = new Player();

            CurrentLocation = CurrentWorld.GetLocation(0, 0);
        }

        /// <summary>
        /// Updates the player position north.
        /// </summary>
        public void MoveNorth()
        {

        }

        /// <summary>
        /// Updates the player position south
        /// </summary>
        public void MoveSouth()
        {

        }

        /// <summary>
        /// Updates the player position east
        /// </summary>
        public void MoveEast()
        {

        }

        /// <summary>
        /// Updates the player position west
        /// </summary>
        public void MoveWest()
        {

        }
    }
}
