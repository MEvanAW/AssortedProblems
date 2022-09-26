using FizzBuzz;

for (int i = 1; i <= 100; i++)
{
    string s = Identifier.TypeToString(Identifier.WhatType(i));
    if (s != "Null")
    {
        Console.WriteLine(s);
    } else
    {
        Console.WriteLine(i);
    }
}
