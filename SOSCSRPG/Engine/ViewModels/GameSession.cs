using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;
using System.ComponentModel;

namespace Engine.ViewModels
{
    /// <summary>
    /// Manages the current game being played by the player. Contains a Player object.
    /// </summary>
    public class GameSession : BaseNotification
    {
        // private backing variables used by properties.
        private Location _currentLocation;

        /// <summary>
        /// Contains the current player of the game session.
        /// </summary>
        public Player CurrentPlayer { get; set; }

        /// <summary>
        /// Contains the current location the player is in.
        /// </summary>
        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationNorth));
                OnPropertyChanged(nameof(HasLocationSouth));
                OnPropertyChanged(nameof(HasLocationEast));
                OnPropertyChanged(nameof(HasLocationWest));

                GivePlayerQuestsAtLocation();
            }
        }

        /// <summary>
        /// Checks to see if the current world has a location north of the current location
        /// </summary>
        public bool HasLocationNorth
        {
            get { return CurrentWorld.GetLocation(CurrentLocation.X, CurrentLocation.Y + 1) != null; }
        }

        /// <summary>
        /// Checks to see if the current world has a location south of the current location
        /// </summary>
        public bool HasLocationSouth
        {
            get { return CurrentWorld.GetLocation(CurrentLocation.X, CurrentLocation.Y - 1) != null; }
        }

        /// <summary>
        /// Checks to see if the current world has a location east of the current location
        /// </summary>
        public bool HasLocationEast
        {
            get { return CurrentWorld.GetLocation(CurrentLocation.X + 1, CurrentLocation.Y) != null; }
        }

        /// <summary>
        /// Checks to see if the current world has a location west of the current location
        /// </summary>
        public bool HasLocationWest
        {
            get { return CurrentWorld.GetLocation(CurrentLocation.X - 1, CurrentLocation.Y) != null; }
        }

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
            CurrentWorld = WorldFactory.CreateWorld();

            CurrentPlayer = new Player();

            CurrentLocation = CurrentWorld.GetLocation(0, 0);
        }

        /// <summary>
        /// Updates the player position north.
        /// </summary>
        public void MoveNorth()
        {
            if (!HasLocationNorth) { return; }
            CurrentLocation = CurrentWorld.GetLocation(CurrentLocation.X, CurrentLocation.Y + 1);
        }

        /// <summary>
        /// Updates the player position south
        /// </summary>
        public void MoveSouth()
        {
            if (!HasLocationSouth) { return; }
            CurrentLocation = CurrentWorld.GetLocation(CurrentLocation.X, CurrentLocation.Y - 1);
        }

        /// <summary>
        /// Updates the player position east
        /// </summary>
        public void MoveEast()
        {
            if (!HasLocationEast) { return; }
            CurrentLocation = CurrentWorld.GetLocation(CurrentLocation.X + 1, CurrentLocation.Y);
        }

        /// <summary>
        /// Updates the player position west
        /// </summary>
        public void MoveWest()
        {
            if (!HasLocationWest) { return; }
            CurrentLocation = CurrentWorld.GetLocation(CurrentLocation.X - 1, CurrentLocation.Y);
        }

        private void GivePlayerQuestsAtLocation()
        {
            foreach(Quest quest in CurrentLocation.LocationQuests)
            {
                if(!CurrentPlayer.Quests.Any(q => q.PlayerQuest.ID == quest.ID))
                {
                    CurrentPlayer.Quests.Add(new QuestTracker(quest));
                }
            }
        }
    }
}
