using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public Characters(string name, int age, Race race)
        {
            this.name = name;
            this.age = age;
            this.race = race;
        }

    }

    public class Archer: Characters
    {
        private int distanceAtack;
        private int levelAgility;

        public Archer (string name, int age, Race race, int distanceAtack, int levelAgility) : base (name, age, race)
        {
            this.distanceAtack = distanceAtack;
            this.levelAgility = levelAgility;
        }
    }

    public class Mage: Characters
    {
        private int levelIntelligence;
        private int distanceAtack;

        public Mage(string name, int age, Race race, int levelIntelligence, int distanceAtack) : base (name,age,race)
        {
            this.levelIntelligence = levelIntelligence;
            this.distanceAtack = distanceAtack;
        }
    }

    public class Warrior: Characters
    {
        private int levelSave;
        private int power;

        public Warrior(string name, int age, Race race, int levelSave, int power) : base (name,age,race)
        {
            this.levelSave = levelSave;
            this.power = power;
        }
    }
}
