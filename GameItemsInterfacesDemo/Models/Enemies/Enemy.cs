using System;
using System.Collections.Generic;

namespace GameItemsInterfacesDemo
{
	public class Attack
	{

	}

	public abstract class Enemy
	{
		public string Name;
		public bool HasSurprise;
		public bool HasHit;
		public List<Attack> Attacks = new List<Attack>();

		public Enemy(string name)
		{
			this.Name = name;
		}

		public virtual void PerformAttack()
		{
			Console.WriteLine("I do the most basic-est of attacks. I sling starbucks at you.");
		}
	}

    public class MimickEnemy : Enemy
    {
        public MimickEnemy(string name) : base(name)
        {
        }

        public override void PerformAttack()
        {
			_PerformSpecialAttack();
			_RegenHealth();
        }

        private void _PerformSpecialAttack()
		{
			Console.WriteLine("I eat you.");
		}

		private void _RegenHealth()
		{
			//
		}
    }

	public class MonsterEnemy : Enemy
	{
		public MonsterEnemy(string name) : base(name)
		{

		}
	}

    public abstract class DaemonEnemey : MonsterEnemy
    {
        protected DaemonEnemey(string name) : base(name)
        {
        }
    }

    public class BalguraMonster : DaemonEnemey
    {
        public BalguraMonster(string name) : base(name)
        {
        }
    }

    public class GhostMonster : MonsterEnemy
    {
		public bool isPossessingSomething;
        public GhostMonster(string name) : base(name)
        {
        }

        public override void PerformAttack()
        {
			_PerformPossession();
        }

		private void _PerformPossession()
		{
			Console.WriteLine("I possess you. <insert exorcist reference>");
		}
    }

	public interface ISword
	{
		public bool hasBlade { get; set;  }
		public bool hasHandle { get; set; }
		public bool doesDamage { get; set; }

		public virtual void SwingSword()
		{
			if (hasHandle)
			{
				Console.WriteLine("I Swing Sword");
			}
		}
	}

    public class PossessedMetalSword : GhostMonster, ISword
    {
		public bool hasBlade { get; set; }
		public bool hasHandle { get; set;  }
		public bool doesDamage { get; set; }

		public void SwingSword()
		{
			if (hasHandle && isPossessingSomething)
			{
				Console.WriteLine("OoOoOo Feel the wrath of Casper. I Swing the sword.");
			}
		}

        public PossessedMetalSword(string name) : base(name)
        {
			hasHandle = true;
        }
    }

    public class MetalSword : ISword
	{
        public bool hasBlade { get; set; }
        public bool hasHandle { get; set; }
        public bool doesDamage { get; set; }

		public MetalSword(
			bool blade = true,
			bool handle = true,
			bool damage = true
		)
		{
			hasBlade = blade;
			hasHandle = handle;
			doesDamage = damage;
		}
    }
}

