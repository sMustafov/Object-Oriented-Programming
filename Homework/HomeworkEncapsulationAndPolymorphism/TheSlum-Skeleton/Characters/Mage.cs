﻿using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Mage : Character, IAttack
    {
        private const int AttackPointsDefault = 300;
        private const int DefensePointsDefault = 50;
        private const int HealthPointsDefault = 150;
        private const int RangeDefault = 5;

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, team, HealthPointsDefault, DefensePointsDefault, RangeDefault)
        {
            this.AttackPoints = AttackPointsDefault;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList.LastOrDefault(ch => (ch.Team != this.Team && ch.IsAlive));
            return target;
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

        protected override void ApplyItemEffects(Item item)
        {
            this.AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.AttackPoints -= item.AttackEffect;
            base.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() + ", Attack: " + AttackPoints;
        }
    }
}