using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Healer : Character, IHeal
    {
        private const int HealingPointsDefault = 60;
        private const int DefensePointsDefault = 50;
        private const int HealthPointsDefault = 75;
        private const int RangeDefault = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, team, HealthPointsDefault, DefensePointsDefault, RangeDefault)
        {
            this.HealingPoints = HealingPointsDefault;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var targets =
               from target in targetsList
               where target.IsAlive && target.Team == this.Team && target != this
               orderby target.HealthPoints
               select target;

            return targets.FirstOrDefault();
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() + ", Healing: " + HealingPoints;
        }
    }
}