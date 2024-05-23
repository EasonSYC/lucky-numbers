internal class Program
{
    const string _inputPromptText = "Please input a number to check: ";
    const string _isLuckyText = "True, all digits are different";
    const string _notLuckyText = "False, the following digits are repeated: ";
    static void Main()
    {
        string input = string.Empty;
        while (string.IsNullOrWhiteSpace(input) || !input.All(char.IsNumber))
        {
            Console.WriteLine(_inputPromptText);
            input = Console.ReadLine() ?? string.Empty;
        }

        int[] digitCount = new int[10];
        foreach (char cc in input)
        {
            ++digitCount[cc - '0'];
        }

        List<int> badDigit = [];
        for (int i = 0; i < 10; ++i)
        {
            if (digitCount[i] != 0 && digitCount[i] != 1)
            {
                badDigit.Add(i);
            }
        }

        if (badDigit.Count != 0)
        {
            Console.WriteLine(_notLuckyText + string.Join(", ", badDigit));
        }
        else
        {
            Console.WriteLine(_isLuckyText);
        }
    }
}