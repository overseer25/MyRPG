using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    /// <summary>
    /// Represents a player object. Players have a name, a class, hit points, 
    /// experience, current level, and gold count.
    /// </summary>
    class Player
    {
        /// <summary>
        /// The name of the player character.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The selected class of the character.
        /// </summary>
        string CharacterClass { get; set; }

        /// <summary>
        /// The amount of health the character has.
        /// </summary>
        int HitPoints { get; set; }

        /// <summary>
        /// The amount of experience points the character has.
        /// </summary>
        int ExperiencePoints { get; set; }

        /// <summary>
        /// The character's level.
        /// </summary>
        int Level { get; set; }

        /// <summary>
        /// The amount of gold the character is carrying.
        /// </summary>
        int Gold { get; set; }

        /// <summary>
        /// Default Constructor for a Player object. Calls the next constructor, and provides default parameters.
        /// </summary>
        public Player() : this("Josh", "Fighter", 20, 0, 1, 1000) { }


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
