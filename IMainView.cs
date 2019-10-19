
namespace App2
{
    public interface IMainView
    {
        void OnSuccessRun(int distance, Characters characters);

        void OnSuccessAttack(Characters characters);

        void onSuccessHealth(Characters characters);
    }
}
