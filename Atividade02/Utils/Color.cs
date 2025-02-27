namespace Atividade02.Utils
{
    internal class Color
    {
        public static void SetColorPhraseBlue(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void SetColorPhraseDarkCyan(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void SetColorPhraseDarkYellow(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void SetColorPhraseYellow(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void SetColorPhraseDarkRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void SetColorPhraseRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void SetColorPhraseDarkGreen(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void SetColorPhraseGreen(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void SetColorPhraseMagenta(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void SetColorPhraseDarkMagenta(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
