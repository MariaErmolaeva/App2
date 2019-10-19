namespace App2
{
    public class Warrior : Characters
    {
        private int levelSave;
        private int power;

        public int lvlSave { get { return levelSave; } }
        public int powerGet { get { return power; } }

        public Warrior(string name, int age, Race race, int levelSave, int power) : base(name, age, race)
        {
            this.levelSave = levelSave;
            this.power = power;
        }
    }
}

