using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : BaseNotification
    {
        // private backing variables used by properties.
        private int _hp;

        /// <summary>
        /// Monster name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Image URL for the monster type
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// Maximum HP for the monster
        /// </summary>
        public int MaxHP { get; set; }

        /// <summary>
        /// Current HP for the monster
        /// </summary>
        public int HP
        {
            get { return _hp; }
            set { _hp = value; OnPropertyChanged(nameof(HP)); }
        }

        /// <summary>
        /// XP reward for defeating the monster
        /// </summary>
        public int RewardXP { get; set; }

        /// <summary>
        /// Gold reward for defeating the monster
        /// </summary>
        public int RewardGold { get; set; }

        /// <summary>
        /// The inventory for the monster. Randomly generated using a random number generator.
        /// </summary>
        public ObservableCollection<ItemQuantity> Inventory { get; set; }

        /// <summary>
        /// Constructor for a monster.
        /// </summary>
        public Monster(string name, string imageName, int maximumHP, int hp, int rewardXP, int rewardGold)
        {
            // Property instantiation
            Name = name;
            ImageName = imageName;
            MaxHP = maximumHP;
            HP = hp;
            RewardXP = rewardXP;
            RewardGold = rewardGold;

            Inventory = new ObservableCollection<ItemQuantity>();
        }
    }
}
