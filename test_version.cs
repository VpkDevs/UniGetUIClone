using System;
using System.Linq;

class Program {
    static void VersionStringToStruct(string version) {
        char[] separators = ['.', '-', '/', '#'];
        string[] versionItems = ["", "", "", ""];

        string[] segments = version.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        foreach (var segment in segments)
        {
            bool seenDigit = false;
            bool seenLetterAfterDigit = false;
            bool seenDigitAfterLetter = false;
            foreach (char c in segment)
            {
                if (char.IsDigit(c))
                {
                    if (seenLetterAfterDigit)
                        seenDigitAfterLetter = true;
                    seenDigit = true;
                }
                else if (char.IsLetter(c) && seenDigit)
                {
                    seenLetterAfterDigit = true;
                }
            }

            if (seenDigit && seenLetterAfterDigit && seenDigitAfterLetter)
            {
                Console.WriteLine("NULL");
                return;
            }
        }

        int dotCount = 0;
        bool first = true;

        foreach (char c in version)
        {
            if (char.IsDigit(c))
                versionItems[dotCount] += c;
            else if (!first && separators.Contains(c))
                if (dotCount < 3)
                    dotCount++;
            first = false;
        }

        int[] numbers = { 0, 0, 0, 0 };
        for (int i = 0; i < 4; i++)
        {
            if (int.TryParse(versionItems[i], out int val))
                numbers[i] = val;
        }

        Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}");
    }

    static void Optimized(string version) {
        if (string.IsNullOrEmpty(version)) { Console.WriteLine("0, 0, 0, 0"); return; }

        bool seenDigit = false;
        bool seenLetterAfterDigit = false;

        for (int i = 0; i < version.Length; i++)
        {
            char c = version[i];
            if (c == '.' || c == '-' || c == '/' || c == '#')
            {
                seenDigit = false;
                seenLetterAfterDigit = false;
            }
            else if (char.IsDigit(c))
            {
                if (seenLetterAfterDigit)
                {
                    Console.WriteLine("NULL");
                    return;
                }
                seenDigit = true;
            }
            else if (char.IsLetter(c) && seenDigit)
            {
                seenLetterAfterDigit = true;
            }
        }

        int dotCount = 0;
        int[] numbers = new int[4];
        bool[] hasValue = new bool[4];
        bool first = true;

        for (int i = 0; i < version.Length; i++)
        {
            char c = version[i];
            if (char.IsDigit(c))
            {
                long val = (long)numbers[dotCount] * 10 + (c - '0');
                if (val > int.MaxValue) {
                    numbers[dotCount] = -1; // Overflow indicator to simulate TryParse failing
                } else if (numbers[dotCount] != -1) {
                    numbers[dotCount] = (int)val;
                    hasValue[dotCount] = true;
                }
            }
            else if (!first && (c == '.' || c == '-' || c == '/' || c == '#'))
            {
                if (dotCount < 3)
                    dotCount++;
            }
            first = false;
        }

        for (int i = 0; i < 4; i++) {
            if (numbers[i] == -1 || !hasValue[i]) numbers[i] = 0;
        }

        Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}");
    }

    static void Main() {
        string[] tests = {
            "0", "", "dfgfdsgdfg", "-12", "4.0.0.1.0", "4.0.0.1.05", "2024.30.04.1223", "0.0", "10c8e557", "1.0-alpha1", "1.0.alpha.1", "1.0-alpha1beta2", "2147483648"
        };
        foreach (var t in tests) {
            Console.Write($"Test '{t}': ");
            VersionStringToStruct(t);
            Console.Write($" Opt '{t}': ");
            Optimized(t);
        }
    }
}
