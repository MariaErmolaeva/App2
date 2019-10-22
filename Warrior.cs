

namespace App2
{
    public class Warrior : Characters
    {
        private int levelSave;
        private int power;

        public const int baseSpeed = 2;
        public const int baseAttack = 4;
        public const int baseHealth = 3;

        public int lvlSave { get { return levelSave; } }
        public int powerGet { get { return power; } }

        public int baseSpeedGet { get { return baseSpeed; } }
        public int baseAttackGet { get { return baseAttack; } }
        public int baseHealthGet { get { return baseHealth; } }

        public Warrior(string name, int age, Race race, int levelSave, int power) : base(name, age, race)
        {
            this.levelSave = levelSave;
            this.power = power;
        }
    }
}
