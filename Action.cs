using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Action : IAction
    {
        public int Attack(Characters characters)
        {
            int attack = 0;
            if (characters is Mage)
            {

               // double attack = characters.baseAttack + mage.distanceAt * 0.01 + mage.lvlIntelligence * 1.5;

                return Convert.ToInt32(attack);

            }
            else
                if (characters is Archer)
            {

            }
            else
                if (characters is Warrior)
            {

            }

            return attack;
        }

        public int Health(Characters characters)
        {
            throw new NotImplementedException();
        }

        public int Run(int distance, Characters characters)
        {
            throw new NotImplementedException();
        }
    }
}
