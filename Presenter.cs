using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Presenter
    {
        IMainView mainview;
        IAction action;

        public Presenter (IAction action)
        {
            this.action = action;
        }

        public void MainView (IMainView mainview)
        {
            this.mainview = mainview;
        }


        public void Run (Characters characters)
        {
            action.Run(100, characters);
            //mainview.OnSuccessRun();
        }

        public void Attack(Characters characters)
        {
            action.Attack(characters);
        }

        public void Health(Characters characters)
        {
            action.Health(characters);
        }

    }
}
