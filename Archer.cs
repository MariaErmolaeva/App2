
namespace App2
{
    public class Archer : Characters
    {
        private int distanceAtack;
        private int levelAgility;

        public const int baseSpeed = 3;
        public const int baseAttack = 2;
        public const int baseHealth = 2;

        public int distanceAt { get { return distanceAtack; } }
        public int lvlAgility { get { return levelAgility; } }

        public int baseSpeedGet { get { return baseSpeed; } }
        public int baseAttackGet { get { return baseAttack; } }
        public int baseHealthGet { get { return baseHealth; } }

        public Archer(string name, int age, Race race, int distanceAtack, int levelAgility) : base(name, age, race)
        {
            this.distanceAtack = distanceAtack;
            this.levelAgility = levelAgility;
        }
    }
}
