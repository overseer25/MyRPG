using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    /// <summary>
    /// Represents a player object. Players have a name, a class, hit points, 
    /// experience, current level, and gold count.
    /// </summary>
    public class Player : BaseNotification
    {
        // private backing variables used by properties.
        private int _experience, _hp, _level, _gold;

        /// <summary>
        /// The name of the player character.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The selected class of the character.
        /// </summary>
        public string CharacterClass { get; set; }

        /// <summary>
        /// The amount of health the character has.
        /// </summary>
        public int HitPoints
        {
            get { return _hp; }
            set {_hp = value; OnPropertyChanged(nameof(HitPoints)); }
        }

        /// <summary>
        /// The amount of experience points the character has.
        /// </summary>
        public int ExperiencePoints
        {
            get { return _experience; }
            set { _experience = value; OnPropertyChanged(nameof(ExperiencePoints)); }
        }

        /// <summary>
        /// The character's level.
        /// </summary>
        public int Level
        {
            get { return _level; }
            set { _level = value; OnPropertyChanged(nameof(Level)); }
        }

        /// <summary>
        /// The amount of gold the character is carrying.
        /// </summary>
        public int Gold
        {
            get { return _gold; }
            set { _gold = value; OnPropertyChanged(nameof(Gold)); }
        }

        /// <summary>
        /// Default Constructor for a Player object. Calls the next constructor, and provides default parameters.
        /// </summary>
        public Player() : this("Josh", "Fighter", 20, 0, 1, 0) { }


        /// <summary>
        /// Initials a player character based on the arguments passed into it.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="characterClass"></param>
        /// <param name="hp"></param>
        /// <param name="xp"></param>
        /// <param name="level"></param>
        /// <param name="gold"></param>
        public Player(string name, string characterClass, int hp, int xp, int level, int gold)
        {
            // Initialize properties
            Name = name;
            CharacterClass = characterClass;
            HitPoints = hp;
            ExperiencePoints = xp;
            Level = level;
            Gold = gold;
        }

    }
}
