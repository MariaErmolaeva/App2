namespace App2
{
    public class Mage: Characters
    {
        private int levelIntelligence;
        private int distanceAtack;

        public int lvlIntelligence { get { return levelIntelligence; } }
        public int distanceAt { get { return distanceAtack; } }

        public Mage(string name, int age, Race race, int levelIntelligence, int distanceAtack) : base(name, age, race)
        {
            this.levelIntelligence = levelIntelligence;
            this.distanceAtack = distanceAtack;
        }
    }
}
