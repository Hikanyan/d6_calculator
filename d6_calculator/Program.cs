// https://paiza.jp/works/mondai/drankfast/d6_calculator
using System;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Trim().Split('+');
        var a = line[0];
        var b = line[1];
        var ans = a + b;
        Console.WriteLine(ans);
    }
}