using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Mage: Characters
    {
        private int levelIntelligence;
        private int distanceAtack;

        public Mage(string name, int age, Race race, int levelIntelligence, int distanceAtack) : base(name, age, race)
        {
            this.levelIntelligence = levelIntelligence;
            this.distanceAtack = distanceAtack;
        }
    }
}
