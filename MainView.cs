using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public class MainView : IMainView
    {
        public string OnSuccessAttack(Characters characters)
        {
            MessageBox.Show("Успешная атака");

            return "\n Персонаж " + characters.nameGet + " ударит на " + characters.attackSetGet.ToString() + " XP" ;
        }

        public string OnSuccessHealth(Characters characters)
        {
            MessageBox.Show("Успешное лечение");
            return "\n Персонаж " + characters.nameGet + " вылечится на " + characters.attackSetGet.ToString() + "XP";
        }

        public string OnSuccessRun(Characters characters)
        {
            MessageBox.Show("Успешный забег");

           return "\n Персонаж " + characters.nameGet + " пробежит за " + characters.attackSetGet.ToString() + " часов";
        }

        public string OnSuccessAddCharacters(Characters characters)
        {
            MessageBox.Show("Вы успешно добавили персонажа");

            return characters.nameGet;
        }
    }
}
