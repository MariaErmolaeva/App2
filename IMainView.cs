
namespace App2
{
    public interface IMainView
    {
        string OnSuccessRun(Characters characters);
        string OnSuccessAttack(Characters characters);
        string OnSuccessHealth(Characters characters);
        string OnSuccessAddCharacters(Characters characters);
    }
}
