
namespace App2
{
    public class Archer: Characters
    {
        private int distanceAtack;
        private int levelAgility;

        public int distanceAt { get { return distanceAtack; } }

        public int lvlAgility { get { return levelAgility; } }

        public Archer(string name, int age, Race race, int distanceAtack, int levelAgility) : base(name, age, race)
        {
            this.distanceAtack = distanceAtack;
            this.levelAgility = levelAgility;
        }
    }
}
