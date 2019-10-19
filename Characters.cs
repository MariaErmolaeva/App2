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

        public string nameGet { get { return name; } }
        public int ageGet { get { return age; } }
        public Race raceGet { get { return race; } }

        public Characters(string name, int age, Race race)
        {
            this.name = name;
            this.age = age;
            this.race = race;
        }
    }
}
