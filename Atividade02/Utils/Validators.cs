using System.Globalization;

namespace Atividade02.Utils
{
    internal class Validators
    {
        public static int IsInt(int min, int max)
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
            {
                Write.WrongOption();
            }
            return number;
        }

        public static string IsValueName(string name)
        {

            while (string.IsNullOrWhiteSpace(name) || !name.All(space => char.IsLetter(space) || space == ' ') || name.Length < 3 || name.Length > 30)
            {
                Write.WrongName();
                name = Console.ReadLine();
            }
            name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            return name;
        }
        public static string YesorNo(string confirm)
        {
            while (string.IsNullOrEmpty(confirm) || confirm.ToLower() != "s" && confirm.ToLower() != "n")
            {
                Write.WrongOption();
                confirm = Console.ReadLine();               
            }
            return confirm.ToLower();
        }
    }
}
