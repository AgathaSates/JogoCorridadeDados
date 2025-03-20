using Atividade02.Utils;
namespace Atividade02.Entities
{
    internal class Racing
    {
        public static User user;
        public static Computer computer;

        public static int RolltheDice(int position)
        {
            Random random = new();
            int dice = random.Next(1, 7);
            Console.WriteLine($" O Dado parou em: {dice}");
            position += dice;
            if (dice == 6)
            {
                Write.ExtraSpin(position);
                position = RolltheDice(position);
            }
            position = LuckyorUnlucky(position);
            return position;
        }

        public static int LuckyorUnlucky(int position)
        {
            if (position == 3 || position == 14 || position == 21)
            {
                Write.LuckofFate(position);

                position += 3;
            }
            else if (position == 28 || position == 36 || position == 44)
            {
                Write.QuasarLuck(position);

                position += 3;
            }
            else if (position == 4 || position == 10 || position == 20)
            {
                Write.UnluckyBreak(position);

                position -= 2;
            }
            else if (position == 37 || position == 40 || position == 45)
            {
                Write.UnluckyVortex(position);

                position -= 2;
            }
            else if (position == 42)
            {
                Write.UnluckSetback(position);

                position = 0;
            }
            else if (position == 7)
            {
                Write.luckofUniverse(position);

                position = 38;
            }
            else if (position == 30)
            {
                Write.RandomMovement(position);
                Random random = new();
                position = random.Next(1, 50);
            }
            return position;
        }

        public static bool Turn(Player player)
        {
            Write.TurnInterface(player);

            const int finishLine = 50;
            if (player.Position >= finishLine)
            {
                Write.Winner(player);
                return true;
            }
            return false;
        }

        public static void UserName()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            string userName;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\x1b[3J");
                Write.WriteUserName();
                userName = Validators.IsValueName(Console.ReadLine());
                Console.WriteLine();
                Color.SetColorPhraseGreen($" -> [ {userName} ] Você confirma este nome? (S ou N): ");
                string confirm = Validators.YesorNo(Console.ReadLine());
                Console.WriteLine();
                if (confirm == "s")
                {
                    break;
                }
            }
            user = new(userName, 0);
            computer = new("Computador", 0);
        }

        public static Player StartPlayer(Player user, Player computador)
        {
            Random random = new Random();
            int startPlayer = random.Next(1, 3);
            if (startPlayer == 1)
            {
                return user;
            }
            else
            {
                return computador;
            }
        }

        public static void StartRace()
        {
            UserName();
            Write.RaceTitle(user, computer);
            Write.Start();
            Player startPlayer = StartPlayer(user, computer);
            Write.StartPlayerTitle(startPlayer);
            Write.StartGameTitle();

            bool gameover;

            while (true)
            {
                do
                {
                    if (startPlayer == user)
                    {
                        Console.WriteLine();
                        Color.SetColorPhraseDarkYellow(" -> Enter para rolar o dado.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\x1b[3J");
                        Color.SetColorPhraseYellow(" -> Sua vez: ");
                        gameover = Turn(user);
                        if (gameover == true)
                        {
                            break;
                        }
                        Console.WriteLine();
                        Color.SetColorPhraseYellow(" -> É a vez do seu oponente: ");
                        gameover = Turn(computer);
                    }

                    else
                    {
                        Console.WriteLine();
                        Color.SetColorPhraseYellow(" -> É a vez do seu oponente: ");
                        gameover = Turn(computer);
                        if (gameover == true)
                        {
                            break;
                        }
                        Console.WriteLine();

                        Console.WriteLine();
                        Color.SetColorPhraseDarkYellow(" -> Enter para rolar o dado.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("\x1b[3J");
                        Color.SetColorPhraseYellow(" -> Sua vez: ");
                        gameover = Turn(user);
                    }
                } while (gameover == false);
                {
                    break;
                }
            }
            return;
        }
    }
}





