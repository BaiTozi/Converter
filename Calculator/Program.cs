namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Изберете опция:");
                Console.WriteLine("1. Двоична към десетична");
                Console.WriteLine("2. Десетична към двоична");
                Console.WriteLine("3. Десетична към шестнадесетично");
                Console.WriteLine("4. Шестнадесетично към десетична");
                Console.WriteLine("5. Изход");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Въведи двоично число: ");
                        string binaryInput = Console.ReadLine();
                        int decimalResult = BinaryToDecimal(binaryInput);

                        Console.WriteLine($"Десетично: {decimalResult}");
                        break;

                    case 2:
                        Console.Write("Въведи десетично число: ");
                        int decimalInput = int.Parse(Console.ReadLine());
                        string binaryResult = DecimalToBinary(decimalInput);

                        Console.WriteLine($"Двоично: {binaryResult}");
                        break;

                    case 3:
                        Console.Write("Въведете десетично число: ");
                        int decimalInputForHexadecimal = int.Parse(Console.ReadLine());
                        string hexadecimalResult = DecimalToHexadecimal(decimalInputForHexadecimal);

                        Console.WriteLine($"Шестнадесетично: {hexadecimalResult}");
                        break;

                    case 4:
                        Console.Write("Въведете шестнадесетично число: ");
                        string hexadecimalInput = Console.ReadLine();
                        int decimalResultFromHex = HexadecimalToDecimal(hexadecimalInput);

                        Console.WriteLine($"Десетично: {decimalResultFromHex}");
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Невалиден избор.");                       
                        break;
                }

            }
            static int BinaryToDecimal(string binaryNum)
            {
                return Convert.ToInt32(binaryNum, 2);
            }

            static string DecimalToBinary(int decimalNum)
            {
                return Convert.ToString(decimalNum, 2).ToUpper();
            }
            static string DecimalToHexadecimal(int decimalNum)
            {
                return Convert.ToString(decimalNum, 16).ToUpper();
            }

            static int HexadecimalToDecimal(string hexadecimalNum)
            {
                return Convert.ToInt32(hexadecimalNum, 16);
            }
        }
    }
}