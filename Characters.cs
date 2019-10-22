namespace App2
{
    public enum Race
    {
        Human,
        Orc,
        Elf,
        Animal
    }

    public class Characters
    {
        private string name;
        private int age;
        private Race race;
		
		private int attack;
        private int health;
        private int time;

        public string nameGet { get { return name; } }
        public int ageGet { get { return age; } }
        public Race raceGet { get { return race; } }
		
		public int attackSetGet { get { return attack; } set { attack = value; } }
        public int timeSetGet { get { return time; } set { time = value; } }
        public int healthSetGet { get { return health; } set { health = value; } }

        public Characters(string name, int age, Race race)
        {
            this.name = name;
            this.age = age;
            this.race = race;
        }
    }
}
