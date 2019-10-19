using System;

namespace App2
{
    public class Action : IAction
    {
        public int Attack(Characters characters)
        {
            double attack = 0;
            if (characters is Mage)
            {
                Mage mage = (Mage)characters;
                attack = mage.baseAttackGet + mage.distanceAt * 0.01 + mage.lvlIntelligence * 1.5;
            }
            else
                if (characters is Archer)
            {
                Archer archer = (Archer)characters;
                attack = archer.baseAttackGet + archer.distanceAt * 0.9 + archer.lvlAgility * 1.5;
            }
            else
                if (characters is Warrior)
            {
                Warrior warrior = (Warrior)characters;
                attack = warrior.baseAttackGet + warrior.powerGet * 3;
            }

            return Convert.ToInt32(attack);
        }

        public int Health(Characters characters)
        {
            double health = 0;
            if (characters is Mage)
            {
                Mage mage = (Mage)characters;
                health = mage.baseHealthGet + mage.lvlIntelligence * 0.2;
            }
            else
                if (characters is Archer)
            {
                Archer archer = (Archer)characters;
                health = archer.baseHealthGet + archer.lvlAgility * 0.01;
            }
            else
                if (characters is Warrior)
            {
                Warrior warrior = (Warrior)characters;
                health = warrior.baseHealthGet + warrior.lvlSave * 0.9;
            }
            return Convert.ToInt32(health);
        }

        public int Run(int distance, Characters characters)
        {
            double time = 0;

            if (characters is Mage)
            {
                Mage mage = (Mage)characters;
                time = distance / (mage.baseSpeedGet + RunRace(mage));
            }
            else
                if (characters is Archer)
            {
                Archer archer = (Archer)characters;
                time = distance / (archer.baseSpeedGet + RunRace(archer));
            }
            else
                if (characters is Warrior)
            {
                Warrior warrior = (Warrior)characters;
                time = distance / (warrior.baseSpeedGet + RunRace(warrior));
            }

            return Convert.ToInt32(time);
        }


        public int RunRace(Characters characters)
        {
            int speed = 0;
            if (characters.raceGet == Race.Animal)
                speed = 15;
            else
                if (characters.raceGet == Race.Human)
                speed = 9;
            else
                if (characters.raceGet == Race.Orc)
                speed = 7;
            else
                if (characters.raceGet == Race.Elf)
                speed = 10;
            return speed;
        }
    }
}
