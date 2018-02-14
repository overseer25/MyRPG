using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    /// <summary>
    /// Manages the current game being played by the player. Contains a Player object.
    /// </summary>
    class GameSession
    {
        /// <summary>
        /// Contains the current player of the game session.
        /// </summary>
        Player CurrentPlayer { get; set; }

        /// <summary>
        /// Default constructor for a GameSession object.
        /// </summary>
        public GameSession()
        {
            CurrentPlayer = new Player();
        }

    }
}
