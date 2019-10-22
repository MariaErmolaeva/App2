using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace App2
{
    public class Presenter
    {
        private IMainView mainview;
        private IAction action;

        List<Characters> characters;


        public Presenter(IAction action, IMainView mainview)
        {
            characters = new List<Characters>();

            this.action = action;
            this.mainview = mainview;

            mainview.AttackClick += mainview_AttackClick;
            mainview.CreateCharactersClick += mainview_CreateCharactersClick;
            mainview.HealthClick += mainview_HealthClick;
            mainview.RunClick += mainview_RunClick;
        }

        void mainview_RunClick(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
            }
        }

        void mainview_HealthClick(object sender, EventArgs e)
        {
            
        }

        private void mainview_CreateCharactersClick(object sender, EventArgs e)
        {
            try
            {
                action.CreateCharacters(mainview.nameCharacters, mainview.race, mainview.type, characters);
                mainview.OnSuccessCreateCharacters(characters[mainview.index]);
            }
            catch
            {
                MessageBox.Show("Неудачно");
            }
        }

        private void mainview_AttackClick(object sender, EventArgs e)
        {
            try
            {
                characters[mainview.index].timeSetGet = action.Run(100, characters[mainview.index]);
                mainview.OnSuccessAttack(characters[mainview.index]);
            }
            catch
            {
                MessageBox.Show("Неудачно");
            }
        }



        public void Attack(Characters characters)
        {
            characters.attackSetGet = action.Attack(characters);
        }

        public void Health(Characters characters)
        {
            characters.healthSetGet = action.Health(characters);

        }

        public void AddCharacters(string name, string race, string type, List<Characters> characters)
        {

            action.CreateCharacters(name, race, type, characters);


        }

    }
}
