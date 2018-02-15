using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    /// <summary>
    /// Generates monsters
    /// </summary>
    public static class MonsterFactory
    {
        /// <summary>
        /// Creates the monsters, and generates their loot.
        /// </summary>
        /// <param name="monsterID"></param>
        /// <returns></returns>
        public static Monster GetMonster(int monsterID)
        {
            switch(monsterID)
            {
                case 1:
                    Monster spider = new Monster("Spider", "enemy_spider.png", 4, 4, 5, 1);
                    AddLootItem(spider, 9001, 25);
                    AddLootItem(spider, 9002, 75);

                    return spider;

                case 2:
                    Monster feralDog = new Monster("Feral Dog", "enemy_feral_dog.png", 5, 5, 8, 2);
                    AddLootItem(feralDog, 9004, 25);
                    AddLootItem(feralDog, 9005, 75);

                    return feralDog;

                case 3:
                    Monster evilCat = new Monster("Feral Cat", "enemy_cat.png", 10, 10, 15, 5);
                    AddLootItem(evilCat, 9006, 25);
                    AddLootItem(evilCat, 9007, 75);

                    return evilCat;

                case 4:
                    Monster bear = new Monster("Bear", "enemy_bear.png", 15, 15, 20, 8);
                    AddLootItem(bear, 9008, 25);
                    AddLootItem(bear, 9009, 75);

                    return bear;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist, ", monsterID));
            }
        }

        /// <summary>
        /// Adds a loot item to a monster's inventory, based on a percent chance of occurring.
        /// </summary>
        /// <param name="monster"></param>
        /// <param name="itemID"></param>
        /// <param name="percentage"></param>
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if(RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}
