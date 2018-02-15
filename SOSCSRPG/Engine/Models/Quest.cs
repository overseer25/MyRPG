using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Quest
    {
        /// <summary>
        /// Quest ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Quest name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the quest
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Items required to complete the quest.
        /// </summary>
        public List<ItemQuantity> ItemsToComplete { get; set; }

        /// <summary>
        /// The amount of XP rewarded to the player upon completion.
        /// </summary>
        public int RewardXP { get; set; }

        /// <summary>
        /// Amount of gold rewarded to the player upon completion.
        /// </summary>
        public int RewardGold { get; set; }

        /// <summary>
        /// Items awarded to the player for completion.
        /// </summary>
        public List<ItemQuantity> RewardItems { get; set; }


        /// <summary>
        /// Constructor for the class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="itemsToComplete"></param>
        /// <param name="rewardXP"></param>
        /// <param name="rewardGold"></param>
        /// <param name="rewardItems"></param>
        public Quest(int id, string name, string description, List<ItemQuantity> itemsToComplete,
            int rewardXP, int rewardGold, List<ItemQuantity> rewardItems)
        {
            // Property instantiation
            ID = id;
            Name = name;
            Description = description;
            ItemsToComplete = itemsToComplete;
            RewardXP = rewardXP;
            RewardGold = rewardGold;
            RewardItems = rewardItems;
        }

    }
}
