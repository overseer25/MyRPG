using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class QuestTracker
    {
        /// <summary>
        /// The quest
        /// </summary>
        public Quest PlayerQuest { get; set; }

        /// <summary>
        /// Is the quest complete
        /// </summary>
        public bool IsCompleted { get; set; }

        public QuestTracker(Quest quest)
        {
            PlayerQuest = quest;
            IsCompleted = false;
        }
    }
}
