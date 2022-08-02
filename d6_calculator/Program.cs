// https://paiza.jp/works/mondai/drankfast/d6_calculator
using System;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Trim().Split('+');
        var a = int.Parse(line[0]);
        var b = int.Parse(line[1]);
        var ans = a + b;
        Console.WriteLine(ans);
    }
}