using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public class Presenter
    {
        private IMainView mainview;
        private IAction action;


        public Presenter (IAction action)
        {
            this.action = action;
        }

        public void MainView (IMainView mainview)
        {
            this.mainview = mainview;
        }


        public string Run (Characters characters)
        {
            characters.timeSetGet = action.Run(100, characters);
            return mainview.OnSuccessRun(characters);
        }

        public string Attack(Characters characters)
        {
            characters.attackSetGet = action.Attack(characters);
            return mainview.OnSuccessAttack(characters);
        }

        public string Health(Characters characters)
        {
            characters.healthSetGet = action.Health(characters);
            return mainview.OnSuccessHealth(characters);
        }

        public string AddCharacters(string name, string race, string type, List<Characters> characters)
        {

            action.CreateCharacters(name, race,type, characters);

           return mainview.OnSuccessAddCharacters(characters.Last());
 

        }

    }
}
