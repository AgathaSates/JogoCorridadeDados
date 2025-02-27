using Atividade02.Entities;
using Atividade02.Utils;

namespace Atividade02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write.MainTitle();
            while (true)
            {
                Write.MainMenu();
                int menuOption = Validators.IsInt(1, 3);
                switch (menuOption)
                {
                    case 1: Racing.StartRace(); break;
                    case 2: Write.Rules(); break;
                    case 3: Write.Goodbye(); return;
                }
            }
        }
    }
}
