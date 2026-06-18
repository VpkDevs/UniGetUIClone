using System;
using System.Diagnostics;

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
                return;
            }
        }

        int dotCount = 0;
        bool first = true;

        foreach (char c in version)
        {
            if (char.IsDigit(c))
                versionItems[dotCount] += c;
            else if (!first && Array.IndexOf(separators, c) >= 0)
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
    }

    static void Optimized(string version) {
        if (string.IsNullOrEmpty(version)) return;

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
                if (seenLetterAfterDigit) return;
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
    }

    static void Main() {
        string[] tests = {
            "0", "", "dfgfdsgdfg", "-12", "4.0.0.1.0", "4.0.0.1.05", "2024.30.04.1223", "0.0", "10c8e557", "1.0-alpha1", "1.0.alpha.1", "1.0-alpha1beta2", "2147483648"
        };

        // Warmup
        for (int i = 0; i < 10000; i++) {
            foreach(var t in tests) { VersionStringToStruct(t); Optimized(t); }
        }

        var sw1 = Stopwatch.StartNew();
        for (int i = 0; i < 100000; i++) {
            foreach(var t in tests) { VersionStringToStruct(t); }
        }
        sw1.Stop();

        var sw2 = Stopwatch.StartNew();
        for (int i = 0; i < 100000; i++) {
            foreach(var t in tests) { Optimized(t); }
        }
        sw2.Stop();

        Console.WriteLine($"Original: {sw1.ElapsedMilliseconds}ms");
        Console.WriteLine($"Optimized: {sw2.ElapsedMilliseconds}ms");
        Console.WriteLine($"Speedup: {((double)sw1.ElapsedMilliseconds / sw2.ElapsedMilliseconds):F2}x");
    }
}
