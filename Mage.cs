
namespace App2
{
    public class Mage: Characters
    {
        private int levelIntelligence;
        private int distanceAtack;

        private const int baseSpeed = 2;
        private const int baseAttack = 2;
        private const int baseHealth = 3;

        public int lvlIntelligence { get { return levelIntelligence; } }
        public int distanceAt { get { return distanceAtack; } }

        public int baseSpeedGet { get { return baseSpeed; } }
        public int baseAttackGet { get { return baseAttack; } }
        public int baseHealthGet { get { return baseHealth; } }

        public Mage(string name, int age, Race race, int levelIntelligence, int distanceAtack) : base(name, age, race)
        {
            this.levelIntelligence = levelIntelligence;
            this.distanceAtack = distanceAtack;
        }
    }
}
