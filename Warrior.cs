using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Warrior : Characters
    {
        private int levelSave;
        private int power;

        public Warrior(string name, int age, Race race, int levelSave, int power) : base(name, age, race)
        {
            this.levelSave = levelSave;
            this.power = power;
        }
    }
}
