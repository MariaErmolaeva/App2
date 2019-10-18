using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{

    public enum Race
    {
        human = 1,
        orc = 2,
        elf = 3,
        animal = 4
    }

    public class Characters
    {
        private string name;
        private int age;
        private Race race;


        public Characters(string name, int age, Race race)
        {
            name = null;
            age = 0;
            race = Race.human;
        }

    }


    public class Archer: Characters
    {
        private int distanceAtack;
        private int levelAgility;

        public Archer (int distanceAtack, int levelAgility) : base (name, age, race)
        {
            distanceAtack = 100;
            levelAgility = 10;
        }
    }

    public class Mage: Characters
    {

    }

    public class Warrior: Characters
    {

    }
}
