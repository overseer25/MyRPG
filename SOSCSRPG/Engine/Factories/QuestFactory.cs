using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    /// <summary>
    /// Generates the quests of the world.
    /// </summary>
    internal static class QuestFactory
    {
        // Stores all quests of the world.
        private static readonly List<Quest> _quests = new List<Quest>();


        /// <summary>
        /// Acts as an init function for the static class.
        /// </summary>
        static QuestFactory()
        {

            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(9001, 5));
            rewardItems.Add(new ItemQuantity(1002, 1));

            //Create the quests
            _quests.Add(new Quest(1, "Trouble at Spider Hill", 
                "Eliminate the spider infestation at Spider Hill", itemsToComplete, 25, 10, rewardItems));
        }

        /// <summary>
        /// Gets a quest object by its ID. Returns null otherwise.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
