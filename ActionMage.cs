using System;

namespace App2
{
    public class ActionMage : IAction
    {
        Mage mage;
        private const int baseSpeed = 2;
        private const int baseAttack = 2;

        public ActionMage(string name, Race race)
        {
            Random rnd = new Random();
            mage = new Mage(name, rnd.Next(40), race, rnd.Next(10), rnd.Next(100));
        }

        public int Run(int distance)
        {
            //for mage
            int time = 0;
            if (mage.raceGet == Race.Animal)
                time = distance / (baseSpeed + 15);
            else
                if (mage.raceGet == Race.Human)
                time = distance / (baseSpeed + 9);
            else
                    if (mage.raceGet == Race.Orc)
                time = distance / (baseSpeed + 7);
            else
                        if (mage.raceGet == Race.Elf)
                time = distance / (baseSpeed + 10);
            return time;
        }

        public int Attack()
        {
            double attack = 0;

            attack = baseAttack + mage.distanceAt * 0.1 + mage.lvlIntelligence * 1.5;

            return Convert.ToInt32(attack);           
        }

        public void Health()
        {

        }
    }
}
