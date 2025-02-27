using Atividade02.Entities;

namespace Atividade02.Utils
{
    internal class Write
    {
        public static void MainTitle()
        {
            Color.SetColorPhraseBlue(" =====================================");
            Color.SetColorPhraseBlue("     Bem Vindo à Corrida de Dados! ");
            Color.SetColorPhraseBlue(" =====================================");
            Console.WriteLine();
            Color.SetColorPhraseDarkYellow(" -> Enter para entrar no jogo ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void MainMenu()
        {
            Color.SetColorPhraseBlue(" ==============================");
            Color.SetColorPhraseBlue("      O que deseja fazer?");
            Color.SetColorPhraseBlue(" ==============================");
            Color.SetColorPhraseYellow(" -----------------------------");
            Color.SetColorPhraseYellow(" 1 - Começar um novo jogo.");
            Color.SetColorPhraseYellow(" 2 - Ver regras.");
            Color.SetColorPhraseYellow(" 3 - Sair do programa.");
            Color.SetColorPhraseYellow(" -----------------------------");
            Color.SetColorPhraseDarkYellow(" -> Escolha uma opção: ");
        }
        public static void Rules()
        {
            Console.Clear();
            Color.SetColorPhraseBlue(" ===================================================");
            Color.SetColorPhraseBlue("                  Regras do jogo");
            Color.SetColorPhraseBlue(" ===================================================");
            Color.SetColorPhraseYellow(" -------------------------------------------------");
            Color.SetColorPhraseYellow(" 1. Você precisa chegar a casa 50 para ganhar.");
            Color.SetColorPhraseYellow(" 2. Durante o jogo, terão casas de azar e sorte.");
            Color.SetColorPhraseYellow(" 3. Casas de sorte te ajudarão a avançar.");
            Color.SetColorPhraseYellow(" 4. Casas de azar farão você retroceder.");
            Color.SetColorPhraseYellow("                Boa Sorte!");
            Color.SetColorPhraseYellow(" -------------------------------------------------");
            Color.SetColorPhraseDarkYellow(" -> Enter para voltar ao menu ");
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();
            return;
        }

        public static void WriteUserName()
        {
            Color.SetColorPhraseBlue(" ============================================");
            Color.SetColorPhraseBlue("     Vamos registrar seu nome de jogador ");
            Color.SetColorPhraseBlue(" ============================================");
            Console.WriteLine();
            Color.SetColorPhraseDarkYellow(" -> Digite seu nome: ");
        }

        public static void RaceTitle(Player player1, Player player2)
        {
            Console.Clear();
            Color.SetColorPhraseBlue(" =================================");
            Color.SetColorPhraseBlue("       A corrida vai começar!");
            Color.SetColorPhraseBlue(" =================================");
            Color.SetColorPhraseDarkRed(" ---------- Hoje temos ----------- ");
            Console.WriteLine();
            Console.WriteLine();
            Color.SetColorPhraseMagenta($"   {player1} VS {player2}");
            Console.WriteLine();
            Color.SetColorPhraseDarkRed($" --------------------------------- ");
        }

        public static void StartPlayerTitle(Player player)
        {
            Color.SetColorPhraseBlue(" ==============================================");
            Color.SetColorPhraseBlue("    Vamos sortear o primeiro a rodar o dado! ");
            Color.SetColorPhraseBlue(" ==============================================");
            Console.WriteLine();
            Color.SetColorPhraseDarkYellow(" -> Enter para sortear. ");
            Console.ReadKey();
            Console.Clear();
            Color.SetColorPhraseBlue(" --------------- Boa Sorte! --------------- ");
            Console.WriteLine();
            Color.SetColorPhraseDarkGreen($" ->> {player} é o primeiro a jogar!");
            Console.WriteLine();
            Color.SetColorPhraseDarkYellow(" -> Enter para entrar no jogo ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void StartGameTitle()
        {
            Color.SetColorPhraseBlue(" ======================================================================");
            Color.SetColorPhraseBlue("     Que os Jogos comecem e que a sorte esteja sempre em seu favor");
            Color.SetColorPhraseBlue(" ======================================================================");
        }

        public static void LuckofFate(int position)
        {
            Console.WriteLine();
            Console.WriteLine($" Caiu na casa [_{position}_]");
            Console.WriteLine();
            Color.SetColorPhraseDarkGreen(" Recebeu a Turbina do Destino!");
            Color.SetColorPhraseDarkGreen(" A energia cósmica impulsiona sua jornada.");
            Color.SetColorPhraseDarkGreen(" Avançou 3 casas.");
        }

        public static void QuasarLuck(int position)
        {
            Console.WriteLine();
            Console.WriteLine($" Caiu na casa [_{position}_]");
            Console.WriteLine();
            Color.SetColorPhraseDarkGreen(" Recebeu o Pulso Quasar!");
            Color.SetColorPhraseDarkGreen(" A radiação poderosa te lança para longe.");
            Color.SetColorPhraseDarkGreen(" Avançou 3 casas.");
        }
        public static void luckofUniverse(int position)
        {
            Console.WriteLine();
            Console.WriteLine($" Caiu na casa [_{position}_]");
            Console.WriteLine();
            Color.SetColorPhraseDarkGreen(" Recebeu a Benção do Universo!");
            Color.SetColorPhraseDarkGreen(" Avançou direto para a casa 38!");
        }

        public static void UnluckyBreak(int position)
        {
            Console.WriteLine();
            Console.WriteLine($" Caiu na casa [_{position}_]");
            Console.WriteLine();
            Color.SetColorPhraseRed(" Sofreu a Ruptura Temporal!");
            Color.SetColorPhraseRed(" Uma fenda no tempo te jogou para trás.");
            Color.SetColorPhraseRed(" Recuou -2 casas.");
        }

        public static void UnluckyVortex(int position)
        {
            Console.WriteLine();
            Console.WriteLine($" Caiu na casa [_{position}_]");
            Console.WriteLine();
            Color.SetColorPhraseRed(" Sofreu o Vórtice Gravitacional!");
            Color.SetColorPhraseRed(" Uma onda gravitacional te arrasta para trás.");
            Color.SetColorPhraseRed(" Recuou -2 casas.");
        }

        public static void UnluckSetback(int position)
        {
            Console.WriteLine();
            Console.WriteLine($" Caiu na casa [_{position}_]");
            Console.WriteLine();
            Color.SetColorPhraseRed(" Sofreu o Retrocesso Cósmico!");
            Color.SetColorPhraseRed(" Voltou ao inicio do jogo.");
        }

        public static void RandomMovement(int position)
        {
            Console.WriteLine();
            Console.WriteLine($" Caiu na casa [_{position}_]");
            Console.WriteLine();
            Color.SetColorPhraseDarkMagenta(" Eclipse Cósmico!");
            Color.SetColorPhraseDarkMagenta(" Você fica perdido na escuridão.");
            Color.SetColorPhraseDarkMagenta(" Cairá em uma casa aleatória.");
        }
        public static void TurnInterface(Player player)
        {
            Console.WriteLine();
            Console.WriteLine(" ----------------------------------------------");
            Color.SetColorPhraseMagenta($" {player} jogou o dado!");
            Console.WriteLine();
            int lastPosition = player.Position;
            Console.WriteLine($" Estava na casa [_{lastPosition}_]");
            Console.WriteLine();
            player.Position = Racing.RolltheDice(player.Position);
            Console.WriteLine();
            Color.SetColorPhraseDarkCyan($" {player.Name} ficou na casa [_{player.Position}_]");
            Console.WriteLine(" ----------------------------------------------");
        }

        public static void ExtraSpin(int position)
        {
            Color.SetColorPhraseDarkGreen(" Avançou 6 casas e ganhou um giro extra!");
            Console.WriteLine();
            Console.WriteLine($" Caiu na casa [_{position}_]");
            Console.WriteLine();
            Console.WriteLine(" -> jogou o dado novamente.");
            Console.WriteLine();
        }
        public static void Winner(Player player)
        {
            Color.SetColorPhraseDarkGreen(" --------------------------------------");
            Color.SetColorPhraseDarkGreen("    *          *          * ");
            Color.SetColorPhraseDarkGreen("           *          *          * ");
            Color.SetColorPhraseDarkGreen("");
            Color.SetColorPhraseDarkGreen($"   !!! {player} foi o vencedor !!!");
            Color.SetColorPhraseDarkGreen("        Parábens pela vitória       ");
            Color.SetColorPhraseDarkGreen("");
            Color.SetColorPhraseDarkGreen("     *             *        ");
            Color.SetColorPhraseDarkGreen(" *          *          *         *");
            Color.SetColorPhraseDarkGreen(" --------------------------------------");
            Console.WriteLine();
            Color.SetColorPhraseDarkYellow(" -> Enter para voltar ao menu ");
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();
        }

        public static void Start()
        {
            Console.WriteLine();
            Console.WriteLine();
            Color.SetColorPhraseDarkYellow(" -> Enter para começar ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void WrongOption()
        {
            Color.SetColorPhraseDarkRed(" -> (X) Opção inválida! Digite novamente: ");
        }

        public static void WrongName()
        {
            Color.SetColorPhraseDarkRed(" -> (X) Nome inválido! Digite novamente: ");
        }

        public static void Goodbye()
        {
            Console.Clear();
            Console.WriteLine();
            Color.SetColorPhraseDarkCyan("---------------------");
            Color.SetColorPhraseDarkCyan(" Até a próxima!  0/ ");
            Color.SetColorPhraseDarkCyan("---------------------");
        }
    }
}
