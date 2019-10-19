namespace App2
{
    public interface IAction
    {
        string Battle(int distance); 
        string Information();
        string Run(int distance);
    }


    public class Action : IAction
    {
        private Mage mage;
        private Archer archer;
        private Warrior warrior;

        public Action(Mage mage, Archer archer, Warrior warrior)
        {
            this.mage = mage;
            this.archer = archer;
            this.warrior = warrior;
        }

        public string Battle(int distance)
        {

            return "";
        }

        public string Information()
        {
            return "";
        }

        public string Run(int distance)
        {
            return "";
        }
    }
}
