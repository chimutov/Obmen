internal class Program
{
    static void Main(string[] args)
    {
        float rublseInWallet;
        float dollarsInWallet;

        int rubTousd = 64, usdToRub = 66;

        float exchangeCurrencyCount;

        string desiredOperacion;

        Console.WriteLine("Добро пожаловать в обменник валют! ");
        Console.Write("Введите баланс рублей: ");
        rublseInWallet = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите баланс долларов: ");
        dollarsInWallet = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Выберите необходимую операцию: ");
        Console.WriteLine("1 - обменять рубли на доллары. ");
        Console.WriteLine("2 - обменять доллары на рубли. ");
        Console.Write("Ваш выбор: ");
        desiredOperacion = Console.ReadLine();
        switch (desiredOperacion)
        {
            case "1":
                Console.WriteLine("Обмен рублей на доллары.");
                Console.Write("Сколько Вы хотите обменять? ");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                if (rublseInWallet >= exchangeCurrencyCount)
                {
                    rublseInWallet -= exchangeCurrencyCount;
                    dollarsInWallet += exchangeCurrencyCount / rubTousd;
                }
                else
                {
                    Console.WriteLine("Недопустимое значание.");
                }
                break;
            case "2":
                Console.WriteLine("Обмен долларов на рубли. ");
                Console.Write("Сколько Вы хотите обменять? ");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                if (dollarsInWallet >= exchangeCurrencyCount)
                {
                    dollarsInWallet -= exchangeCurrencyCount;
                    rublseInWallet += exchangeCurrencyCount * usdToRub;
                }
                else
                {
                    Console.WriteLine("Недопустимое значание.");
                }
                break;
            default:
                Console.WriteLine("Выбрана неверная операция.");
                break;

        }
        Console.WriteLine($"На вашем счету: {rublseInWallet} рублей," + $" {dollarsInWallet} долларов! ");
    }
}
