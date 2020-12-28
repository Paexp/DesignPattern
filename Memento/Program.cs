using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRole lixiaoyao = new GameRole();
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            RoleStateCaretaker stateCaretaker = new RoleStateCaretaker();
            stateCaretaker.Memento = lixiaoyao.SaveState();

            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            lixiaoyao.RecoveryState(stateCaretaker.Memento);
            lixiaoyao.StateDisplay();

            Console.Read();
        }
    }
}
