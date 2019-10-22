namespace App2
{
    public interface IAction
    {
        int Run(int distance, Characters characters);
        int Attack(Characters characters);
        int Health(Characters characters);

        void CreateCharacters(string name, string race, string age, List<Characters> characters);
    }

}
