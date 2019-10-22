using System;

namespace App2
{
    public interface IMainView
    {
        void OnSuccessRun(Characters characters);
        void OnSuccessAttack(Characters characters);
        void OnSuccessHealth(Characters characters);
        void OnSuccessCreateCharacters(Characters characters);

        int index { get; }
        string nameCharacters { get; }
        string race { get; }
        string type { get; }

        //события кнопок
        event EventHandler AttackClick;
        event EventHandler RunClick;
        event EventHandler HealthClick;
        event EventHandler CreateCharactersClick;
    }
}
